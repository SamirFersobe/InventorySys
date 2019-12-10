using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KaihatsuEnshuu
{
    public partial class SupplyChainManager : template.Form1
    {
        string DatabaseConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";
        int currentDisplay = 0;
        string genericQueryString = "select [order].ID,emp.empname , customers.customerName , [order].orderDate from ([order] inner join customers on [order].ordercustomerid = customers.customerID)inner join emp on emp.empno = [order].orderempno ";
        private string currentOrder;
        public SupplyChainManager()
        {
      
            InitializeComponent();
        }
     
        string orderDetails;
        DataTable dt1 = new DataTable(); // This one has the orders
        DataTable dt2 = new DataTable();//This one display the orders 内容
        private void SupplyChainManager_Load(object sender, EventArgs e)
        {

            //loading all the values for the order table
            try
            {
                OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
                string sql1 = genericQueryString + " where orderRequest = -1 and orderCanceled = 0";

                OleDbDataAdapter da = new OleDbDataAdapter(sql1, con);
                da.Fill(dt1);

                dataGridView1.DataSource = dt1;
                MessageBox.Show("データロード中");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 1");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
            MessageBox.Show("発送しました");
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

                                //DecreaseParticularProductFromStock(item1.productId, item1.productQuantity);

                        }


 

                    }


                }

            }
        }

        private void DecreaseParticularProductFromStock(int productID, int productQuantity)
        {
            string sqlQueryToCheckAvailability = "select sum(quantity) from stock where productID = " + Convert.ToString(productID) + " group by productID";
            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlQueryToCheckAvailability;
            int stockQuantity = Convert.ToInt32(cmd.ExecuteScalar());
            int remainingStock = stockQuantity - productQuantity;
            OleDbCommand cmmd = new OleDbCommand("INSERT INTO stock(productID,pBrand,pPrice) Values(@Name,@Brand,@Price)", con);
            if (con.State == ConnectionState.Open)
            {
               // cmmd.Parameters.AddWithValue("@Brand", brand);
              //  cmmd.Parameters.AddWithValue("@Name", name);
              //  cmmd.Parameters.AddWithValue("@Price", price);
              //  cmmd.ExecuteNonQuery();

                try
                {

                    con.Close();
                }
                catch (OleDbException expe)
                {
                    MessageBox.Show(expe.Message);
                    con.Close();
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
            Boolean flag = false;
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

                    
                    string lacking = "";
                    foreach (var item1 in items)
                    {
                        if (!item1.stockAvaiable)
                        {
                             flag = true;
                             lacking = "\n Add " + item1.productId.ToString() + lacking;
                        }
                    }

                }

               
            }
             // if true then it means that there are items lacking
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
    }
}
class MyData{
    public int productId { get; set; }
    public int productQuantity { get; set; }

    public Boolean stockAvaiable { get; set; }
}
