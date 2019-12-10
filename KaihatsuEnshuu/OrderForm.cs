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
    public partial class OrderForm : template.Form1
    {
        string currentOrderString;

        string DatabaseConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";
        public OrderForm(string customerID , string employeeID, string orderId)
        {

            
            InitializeComponent();

            try
            {
              
                string sql1 = "SELECT pBrand,pName,Pprice FROM products";
                reloadDataGridView(sql1, dataGridView1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 1");
            }

            try
            {
                
                currentOrderString = "SELECT  * FROM orderDetails where orderId = " + orderId;
                reloadDataGridView(currentOrderString, dataGridView2);
               // MessageBox.Show("Values loaded ...!!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 2");
            }

            // get the values for 
    

            FillComboBox("pName", "pId", comboBox1, "products");



        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            con.Open();//opening connection
            string currentItem = comboBox1.SelectedValue.ToString();
            string lastAddedId = "select id from [order]  order by orderdate desc ";  //getting values
            cmd.CommandText = lastAddedId;
            string orderString = cmd.ExecuteScalar().ToString();
            lastAddedId = "select orderCustomerId from [order]  order by orderdate desc ";
            cmd.CommandText = lastAddedId;
            string customerString = cmd.ExecuteScalar().ToString();
            string priceString = "select pprice from products where pid = " + comboBox1.SelectedValue.ToString();
            cmd.CommandText = priceString;
            int price = Convert.ToInt32(cmd.ExecuteScalar());

            string sql2 = "INSERT INTO orderDetails(orderId,customerId,pId,quantity,pCurrentPrice) values (@orderId,@customerId,@pId,@quantity,@pCurrentPrice)";
            cmd.CommandText = sql2;


            
            try
            {


                cmd.Parameters.AddWithValue("@orderId", orderString);
                cmd.Parameters.AddWithValue("@customerId", customerString);
                cmd.Parameters.AddWithValue("@pId", comboBox1.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@quantity", textBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@pCurrentPrice", price);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Item added to list");


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
 
                string sql3 = "SELECT  * FROM orderDetails where orderId = " + orderString;
                reloadDataGridView(sql3, dataGridView2);
           

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 3");
            }
            
        }

        private void CancelOrder_Click(object sender, EventArgs e)
        {
            DeleteLastOrder();

        }


        private void DeleteAllAddedItems()
        {
            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            con.Open();//opening connection
            string lastAddedId = "select id from [order]  order by orderdate desc ";  //getting values
            cmd.CommandText = lastAddedId;
            string orderString = cmd.ExecuteScalar().ToString();
            string cmdString = "DELETE * from orderdetails where orderid = " + orderString;
            cmd.CommandText = cmdString;
            try
            {
                cmd.ExecuteNonQuery();
                reloadDataGridView(currentOrderString, dataGridView2);
            }
            catch(Exception ex)
            {

            }
            MessageBox.Show("Items have been deleted");
            reloadDataGridView(currentOrderString,dataGridView2);
            
        }


        private void DeleteLastOrder()
        {

            DeleteAllAddedItems();
            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            con.Open();//opening connection
            string currentItem = comboBox1.SelectedValue.ToString();
            string lastAddedId = "select id from [order]  order by orderdate desc ";  //getting values
            cmd.CommandText = lastAddedId;
            string orderString = cmd.ExecuteScalar().ToString();
            string cmdString = "DELETE * from [order] where id = " + orderString;
            cmd.CommandText = cmdString;
            cmd.ExecuteNonQuery();

            this.Close();

            
        }

        private void ClearOrder_Click(object sender, EventArgs e)
        {
            DeleteAllAddedItems();
            
            
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("注文確認しました？", "注文確定注意", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                con.Open();//opening connection
                string currentItem = comboBox1.SelectedValue.ToString();
                string lastAddedId = "select id from [order]  order by orderdate desc ";  //getting values
                cmd.CommandText = lastAddedId;
                string orderString = cmd.ExecuteScalar().ToString();

                //-1 Implies a YES and  0 is False
                string cmdString = "update [order] set orderrequest = -1 where id = " + orderString;
                cmd.CommandText = cmdString;
                cmd.ExecuteNonQuery();

                this.Close();
            }


        }
    }

   


}
