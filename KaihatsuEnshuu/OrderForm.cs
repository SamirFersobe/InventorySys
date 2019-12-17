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
        string currentOrderString ;

        public OrderForm(string customerID , string employeeID, string orderId)
        {

            
            InitializeComponent();

            try
            {
              
                string sql1 = "SELECT pBrand as ブランド ,pName as 商品名,Pprice as 値段 FROM products order by 1";
                reloadDataGridView(sql1, dataGridView1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 1");
            }

            try
            {
                
                currentOrderString = "SELECT   p.pbrand as ブランド,p.pname as 名前, od.pcurrentprice as 値段 ,sum(od.quantity) as 数  FROM orderDetails od inner join products p on (p.pid =  od.pid) where orderId = " + orderId +" group by p.pbrand,p.pname,od.pcurrentprice,p.pid ";
                reloadDataGridView(currentOrderString, dataGridView2);
                MessageBox.Show("Values loaded ...!!!");

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
 
               
                reloadDataGridView(currentOrderString, dataGridView2);
           

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 3");
            }
            
        }

        private void CancelOrder_Click(object sender, EventArgs e)
        {
            DeleteLastOrder();
            this.Close();

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
                SubmitOrder();

                this.Close();
            }


        }

        private void SubmitOrder()
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
        }

        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("この注文を確定しますか？", "注文確認", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SubmitOrder();
               
            }
            else if (dialogResult == DialogResult.No)
            {
                DeleteLastOrder();
            }
        }
    }

   


}
