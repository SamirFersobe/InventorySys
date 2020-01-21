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
                //create function that deletes orders with no items

                groupBox2.Text = "注文依頼一覧";
                OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
                string sql1 = genericQueryString + " where orderRequest = -1 and orderCanceled = 0 and orderApproved = 0 order by 4";

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
            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            string sql2 = "SELECT * FROM orderDetails";
           if (orderDetails != "")
            {
                
                sql2 = "SELECT b.BrandName as ブランド, p.pName as 商品名,format(avg(od.Pcurrentprice),'currency') as 値段 ,sum(od.quantity) as 枚数, format(sum(od.quantity) * avg(od.pCurrentPrice),'Currency') as 合計 FROM ((products p inner join brands b on (b.BrandId = p.brand))  inner join categories c on (c.CategoryId = p.categoryId)) inner join orderDetails od on (od.pid = p.pid) where od.orderId = " + orderDetails + "  group by od.pid ,b.brandName, p.pName  having sum(od.quantity) > 0";

                OleDbDataAdapter da2 = new OleDbDataAdapter(sql2, con);
                dt2.Clear();
                da2.Fill(dt2);
                dataGridView2.DataSource = dt2;
                this.currentOrder = orderDetails;
            }

            try { 

           // MessageBox.Show("Values changed");
            }
            catch(Exception ex)
            {
               // MessageBox.Show(ex.Message + "ss");
            }
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
                else
                {
                    MessageBox.Show("在庫たりないです。");
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
                        MessageBox.Show("Items Decreased");


 

                    }


                }

            }
        }

        private void DecreaseParticularProductFromStock(int productID, int productQuantity)
        {

            MessageBox.Show("decreasing " + productID.ToString() + " by " + productQuantity.ToString());
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

            con.Close();

            OleDbConnection conn = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmmd = new OleDbCommand();
            conn.Open();
            cmmd.Connection = conn;
            cmmd.CommandType = CommandType.Text;

            string sqlQueryUpdateValues;
            
            foreach (var item in itemsInStock)
            {
                if (item.stockQuantity < productQuantity)
                {
                    productQuantity = productQuantity - item.stockQuantity;
                    item.stockQuantity = 0;
                    sqlQueryUpdateValues = "update stock set quantity = 0 where shop_id = " + item.stockShopID.ToString();
                    cmmd.CommandText = sqlQueryUpdateValues;
                   // MessageBox.Show(item.stockQuantity.ToString() + " -   " + productQuantity.ToString() + " and productID = " + productID.ToString());
                 //   MessageBox.Show("decreasing");
                    cmmd.ExecuteNonQuery();
               //     MessageBox.Show("decreas");

                }
                else
                {
                    item.stockQuantity = item.stockQuantity - productQuantity;
                    sqlQueryUpdateValues = "update stock  set quantity = " + item.stockQuantity.ToString() + " where shop_id = " + item.stockShopID.ToString()+ " and productID = " + productID.ToString();
                    cmmd.CommandText = sqlQueryUpdateValues;
                    cmmd.ExecuteNonQuery();
                    
                    productQuantity = 0;
                    

                }
            }

            con.Close();
            








            /**

            List<StockItem> sortedItemsInStock = itemsInStock.OrderBy(o => o.stockQuantity).ToList();
          

            OleDbConnection conn = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmmd = new OleDbCommand();
            conn.Open();
            cmmd.Connection = conn;
            cmmd.CommandType = CommandType.Text;

            MessageBox.Show("1");
            using (conn) { 
            while (productQuantity != 0)
            {
                    
                     * 
                     * the bug seems to be here , when deleting the productquantity it goes on a sells everything 
                     i dont know why tho. Anyways still gotta fix this so that orders with more than 2 items can be 
                    sent and the program doesn't crash.  mayeb its time to redo the function.
                     * 
  
                     

            }
        }

            MessageBox.Show("2");
            conn.Close();
        **/
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
                groupBox2.BackColor = Color.White;
                buttonEnabler(true, true, true);
                groupBox2.Text = "注文依頼一覧";
                OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
                string sql1 =  genericQueryString + " where orderRequest = -1 and orderCanceled = 0  and orderApproved = 0 order by 4";

                OleDbDataAdapter da = new OleDbDataAdapter(sql1, con);
                dt1.Clear();
                da.Fill(dt1);

                dataGridView1.DataSource = dt1;
               // MessageBox.Show("データロード中");

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
                groupBox2.BackColor = Color.Red;
                buttonEnabler(false, false, false);

                groupBox2.Text = "キャンセルした注文一覧";
                OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
                string sql1 = genericQueryString + " where orderRequest = -1 and orderCanceled = -1 order by 4";

                OleDbDataAdapter da = new OleDbDataAdapter(sql1, con);
                dt1.Clear();
                da.Fill(dt1);

                dataGridView1.DataSource = dt1;
               // MessageBox.Show("データロード中");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 1");
            }
        }


        private void buttonEnabler(Boolean confirmation, Boolean cancel , Boolean sent)
        {
            ApproveOrder.Enabled = confirmation;
            CancelOrder.Enabled = cancel;
            SendOrder.Enabled = sent;
        }

        private void DisplaySentOrders_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox2.BackColor = Color.Green;
                buttonEnabler(false, false, false);
                groupBox2.Text = "発送した注文一覧";
                OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
                string sql1 = genericQueryString + " where orderApproved = -1 and orderCanceled = 0";

                OleDbDataAdapter da = new OleDbDataAdapter(sql1, con);
                dt1.Clear();
                da.Fill(dt1);

                dataGridView1.DataSource = dt1;
              //  MessageBox.Show("データロード中");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 1");
            }

        }

        private void CancelOrder_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("この注文をキャンセルしますか？", "注文キャンセル確認", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string sqlQuery = "update [order]  set orderCanceled = -1 where id = " + this.currentOrder;
                OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
                OleDbCommand cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlQuery;
                cmd.ExecuteNonQuery();

                

                MessageBox.Show("注文はキャンセルしました。");
                DisplayCanceledOrders.PerformClick();

            }
            else if (dialogResult == DialogResult.No)
            {
                //dont do anything
            }


            
            
        }

        private void SendOrder_Click(object sender, EventArgs e)
        {
            if (this.currentOrder != null && CheckParticularOrderStock(this.currentOrder))
            {
                ApproveParticularOrder(this.currentOrder); //send the items
                OrderSetToSent(this.currentOrder);
                MessageBox.Show("発送しました！");
                dataGridView1.Refresh();
                DisplaySentOrders.PerformClick();

            }
            else
            {
                if (this.currentOrder == null)
                {
                    MessageBox.Show("注文を選んでください");
                }
                else
                {
                    MessageBox.Show("在庫たりないです！");
                }
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
            con.Close();
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
