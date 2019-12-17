using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Linq;

namespace KaihatsuEnshuu
{
    public partial class SupplyChainManager : template.Form1
    {
  
        string genericQueryString = "select [order].ID,emp.empname , customers.customerName , [order].orderDate from ([order] inner join customers on [order].ordercustomerid = customers.customerID)inner join emp on emp.empno = [order].orderempno ";
        private string currentOrder;
        public SupplyChainManager()
        {
      
            InitializeComponent();
        }
        DataTable dt1 = new DataTable(); // This one has the orders
        DataTable dt2 = new DataTable();//This one display the orders 内容
        private void SupplyChainManager_Load(object sender, EventArgs e)
        {

            //loading all the values for the order table
            try
            {
                OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
                string sql1 = genericQueryString + " where orderRequest = -1 and orderCanceled = 0 and orderApproved = 0";

                OleDbDataAdapter da = new OleDbDataAdapter(sql1, con);
                da.Fill(dt1);

                dataGridView1.DataSource = dt1;
              //  MessageBox.Show("データロード中");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 1");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string orderDetails = "";
            if (e.RowIndex == -1) return; //check if row index is not 
            if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                orderDetails = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";
            OleDbConnection con = new OleDbConnection(str);
            string sql2 = "SELECT * FROM orderDetails";
            if (orderDetails != null)
            {
                sql2 = "SELECT products.pName,products.Pbrand ,orderdetails.pCurrentPrice,orderdetails.quantity  FROM orderDetails inner join products on (products.pid = orderdetails.pid) where orderID = " + orderDetails;
            }
            OleDbDataAdapter da2 = new OleDbDataAdapter(sql2, con);
            dt2.Clear();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            this.currentOrder = orderDetails;
            MessageBox.Show("Values changed");
        }

        private void ApproveOrder_Click(object sender, EventArgs e)
        {
            if (this.currentOrder != null)
            {
                if (CheckParticularOrderStock(this.currentOrder))
                {
                    OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
                    OleDbCommand cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    //Need to add the function that  subtracts from the inventory
                    string cmdString = "update [order] set orderApproved = -1 where id = " + this.currentOrder;
                    cmd.CommandText = cmdString;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("注文は発送可能です");
                }
            }
        }

        private void ApproveParticularOrder(string orderIdString)
        {
            if (CheckParticularOrderStock(orderIdString))
            {
                string sqlQuery = "select pid, sum(quantity) from orderDetails where orderId =  " + orderIdString + " group by pID";
                OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
                OleDbCommand cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                var items = new List<MyData>();

                using (con)
                {
                    cmd.CommandText = sqlQuery;
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var item = new MyData()
                            {
                                productId = Convert.ToInt32(dr[0]),
                                productQuantity = Convert.ToInt32(dr[1])
                            };

                            items.Add(item);
                        };

                        foreach (var item1 in items)
                        {

                                DecreaseParticularProductFromStock(item1.productId, item1.productQuantity);

                        }


 

                    }


                }

            }
        }

        private void DecreaseParticularProductFromStock(int productID, int productQuantity)
        {
            string sqlQueryToCheckAvailability = "select quantity,shop_ID from stock where productID = " + Convert.ToString(productID);
            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlQueryToCheckAvailability;

            var itemsInStock = new List<StockItem>();

            using (con)
            {
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var currentStock = new StockItem()
                        {
                            stockProductID = productID,
                            stockQuantity = Convert.ToInt32(dr[0]),
                            stockShopID = Convert.ToInt32(dr[1])
                        };

                        itemsInStock.Add(currentStock);
                    }
                }
            }

            List<StockItem> sortedItemsInStock = itemsInStock.OrderBy(o => o.stockQuantity).ToList();
            string sqlQueryUpdateValues;

            OleDbConnection conn = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmmd = new OleDbCommand();
            conn.Open();
            cmmd.Connection = conn;
            cmmd.CommandType = CommandType.Text;


            using (conn) { 
            while (productQuantity != 0)
            {
                foreach (var item in sortedItemsInStock)
                {
                    if (item.stockQuantity < productQuantity)
                    {
                        productQuantity = productQuantity - item.stockQuantity;
                        item.stockQuantity = 0;
                        sqlQueryUpdateValues = "update stock set quantity = 0 where shop_id = " + item.stockShopID.ToString();
                            MessageBox.Show(sqlQueryUpdateValues);
                        cmmd.CommandText = sqlQueryUpdateValues;
                        cmmd.ExecuteNonQuery();
                    }
                    else
                    {
                        item.stockQuantity = item.stockQuantity - productQuantity;
                        sqlQueryUpdateValues = "update stock  set quantity = " + item.stockQuantity.ToString() + " where shop_id = " + item.stockShopID.ToString();
                        cmmd.CommandText = sqlQueryUpdateValues;
                        cmmd.ExecuteNonQuery();
                        productQuantity = 0;
                        break;
                    }
                }
            }
        }




        }

        private Boolean CheckParticularOrderStock(string orderIdString)
        {
            //check
            string sqlQuery = "select pid, sum(quantity) from orderDetails where orderId =  " + orderIdString + " group by pID";
            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            var items = new List<MyData>();
            Boolean flag = true;
            using (con)
            {
                cmd.CommandText = sqlQuery;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                            var item = new MyData() {
                            productId = Convert.ToInt32(dr[0]),
                            productQuantity = Convert.ToInt32(dr[1])
                    };

                        items.Add(item);
                    };

                    foreach (var item1 in items)
                    {

                        item1.stockAvaiable = CheckParticularProductStock(item1.productId, item1.productQuantity);

                    }

                    foreach (var item1 in items)
                    {
                        if (!item1.stockAvaiable)
                        {
                             flag = false;
                     
                        }
                    }

                }

               
            }
            
            return flag;

        }

        

        private Boolean CheckParticularProductStock(int pid,int requiredQuantity)
        {
            string sqlQueryToCheckAvailability = "select sum(quantity) from stock where productID = " + Convert.ToString(pid) + " group by productID";
            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlQueryToCheckAvailability;
            int stockQuantity = Convert.ToInt32(cmd.ExecuteScalar());

            if(stockQuantity >= requiredQuantity)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private void DisplayOrders_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox2.Text = "注文依頼一覧";
                OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
                string sql1 =  genericQueryString + " where orderRequest = -1 and orderCanceled = 0  and orderApproved = 0";

                OleDbDataAdapter da = new OleDbDataAdapter(sql1, con);
                dt1.Clear();
                da.Fill(dt1);

                dataGridView1.DataSource = dt1;
                MessageBox.Show("データロード中");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 1");
            }

        }

        private void DisplayCanceledOrders_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox2.Text = "キャンセルした注文一覧";
                OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
                string sql1 = genericQueryString + " where orderRequest = -1 and orderCanceled = -1";

                OleDbDataAdapter da = new OleDbDataAdapter(sql1, con);
                dt1.Clear();
                da.Fill(dt1);

                dataGridView1.DataSource = dt1;
                MessageBox.Show("データロード中");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 1");
            }
        }

        private void DisplaySentOrders_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox2.Text = "発送した注文一覧";
                OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
                string sql1 = genericQueryString + " where orderApproved = -1 and orderCanceled = 0";

                OleDbDataAdapter da = new OleDbDataAdapter(sql1, con);
                dt1.Clear();
                da.Fill(dt1);

                dataGridView1.DataSource = dt1;
                MessageBox.Show("データロード中");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 1");
            }

        }

        private void CancelOrder_Click(object sender, EventArgs e)
        {
            string sqlQuery = "update [order]  set orderCanceled = -1 where id = " + this.currentOrder;
            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlQuery;
            cmd.ExecuteNonQuery();
        }

        private void SendOrder_Click(object sender, EventArgs e)
        {
            if (this.currentOrder != null && CheckParticularOrderStock(this.currentOrder))
            {
                ApproveParticularOrder(this.currentOrder);
                OrderSetToSent(this.currentOrder);
                MessageBox.Show("発送しました！");
                dataGridView1.Refresh();

            }
            else
            {
                MessageBox.Show("注文を選んでください");
            }
        }

        private void OrderSetToSent(string orderdetails)
        {
            string sqlQuery = "update [order]  set orderapproved = -1 where id = "+ orderdetails;
            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlQuery;
            cmd.ExecuteNonQuery();
        }
    }
}

class StockItem
{
    public int stockProductID { get; set; }
    public int stockShopID { get; set; }
    public int stockQuantity { get; set; }
}
class MyData{
    public int productId { get; set; }
    public int productQuantity { get; set; }

    public Boolean stockAvaiable { get; set; }
}
