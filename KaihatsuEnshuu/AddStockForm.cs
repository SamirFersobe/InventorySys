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
    }
}
