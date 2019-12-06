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
    public partial class AddStockForm : template.Form1
    {
        string DatabaseConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";
        string sqlqueryRestocking;
        int restockingOrder;
        int shopIDGlobal;
        string sqlQueryProducts = "select * from products";

        public AddStockForm(int shopid,int restockingId , int randomnumber)
        {



        }




        private void RequiredStockForAllOrders(List<MyData> stockItems)
        {
            string orderDetailsQuery = " select pid, sum(quantity) from orderDetails group by pid";


            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            var OrderItems = new List<MyData>();

            using (con)
            {
                cmd.CommandText = orderDetailsQuery;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var item = new MyData()
                        {
                            productId = Convert.ToInt32(dr[0]),
                            productQuantity = Convert.ToInt32(dr[1])
                        };

                        OrderItems.Add(item);
                    };


                    foreach (var item1 in OrderItems)
                    {
                        var item2 = new MyData()
                        { 
                        productId = item1.productId,
                        productQuantity = ParticularProductStockRequiredQuantity(item1.productId, item1.productQuantity)

                        
                        };
                        if (item2.productQuantity != 0)
                        {
                            MessageBox.Show(" I will add  " + item2.productId.ToString() + "  with  " + item2.productQuantity.ToString());

                            stockItems.Add(item2);
                        }
                    };


                }


            }

        }


        private int ParticularProductStockRequiredQuantity(int pid, int requiredQuantity)
        {

            string sqlQueryToCheckAvailability = "select sum(quantity) from stock where productID = " + Convert.ToString(pid) + " group by productID";
            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlQueryToCheckAvailability;
            int stockQuantity = Convert.ToInt32(cmd.ExecuteScalar());

            if (stockQuantity >= requiredQuantity)
            {
                return 0;
            }
            else
            {
                return requiredQuantity - stockQuantity;
            }
        }
        public AddStockForm(int shopid, int restockingId)
        {
            InitializeComponent();
            shopIDGlobal = shopid;

            sqlqueryRestocking = "select * from restockingDetails where restockingid = " + restockingId.ToString();
            restockingOrder = restockingId;


            reloadDataGridView(sqlqueryRestocking, dataGridView1);
            reloadDataGridView(sqlQueryProducts, dataGridView2);
            FillComboBox("pName", "pId", comboBox1, "products");
        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            con.Open();//opening connection
            string sql2 = "INSERT INTO restockingDetails(RestockingID,ProductID,Quantity,Shop_ID) values (@restockingID,@productID,@quantity,@shop_id)";
            cmd.CommandText = sql2;


            try
            {

                cmd.Parameters.AddWithValue("@restockingID", restockingOrder);
                cmd.Parameters.AddWithValue("@productID", comboBox1.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@quantity", textBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@shop_id", shopIDGlobal);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Item added to list");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            reloadDataGridView(sqlqueryRestocking, dataGridView1);
        }

        private void SubmitRestock_Click(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            con.Open();//opening connection

            string sqlQueryStockInsert = "insert into stock(productID,quantity,shop_id) select productID , quantity,shop_id  from RestockingDetails where restockingID =  " + restockingOrder.ToString();
            

            cmd.CommandText = sqlQueryStockInsert;

            try
            {

                cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }

            this.Close();

           
        }

        private void AddAllRequiredItems_Click(object sender, EventArgs e)
        {
            var stockItems = new List<MyData>();
            RequiredStockForAllOrders(stockItems);

            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            con.Open();

            string sql2 = "INSERT INTO restockingDetails(RestockingID,ProductID,Quantity,Shop_ID) values (@restockingID,@productID,@quantity,@shop_id)";
            cmd.CommandText = sql2;


            int i = 0;

            while (i < stockItems.Count)
            {
                try
                {
                    MessageBox.Show(stockItems[i].productId.ToString());
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@restockingID", restockingOrder);
                    cmd.Parameters.AddWithValue("@productID", stockItems[i].productId);
                    cmd.Parameters.AddWithValue("@quantity", stockItems[i].productQuantity);
                    cmd.Parameters.AddWithValue("@shop_id", shopIDGlobal);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Item added to list");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }


                i = i + 1;
            }

            con.Close();




            MessageBox.Show("The required items have been added to the order");

            reloadDataGridView(sqlqueryRestocking, dataGridView2);
            reloadDataGridView(sqlQueryProducts, dataGridView1);
        }
    }
}
