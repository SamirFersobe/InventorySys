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
    public partial class StockForm : template.Form1
    {

        string sqlQueryStock = "select productID,sum(quantity) as Quantity from stock group by productid";
        string sqlQueryProducts = "select * from products";
        public StockForm()
        {
            InitializeComponent();

            try
            {
                reloadDataGridView(sqlQueryStock, dataGridView1);
                reloadDataGridView(sqlQueryProducts, dataGridView2);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "ProductError");

            }


        }

        private void AddStock_Click(object sender, EventArgs e)
        {
            int shopid = Convert.ToInt32(stockIdComboBox.Text);

            string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";
            OleDbConnection con = new OleDbConnection(str);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO restocking(RestockingDate,ShopID) values(date(),@shopID)";
            cmd.Parameters.AddWithValue("@shopID", shopid);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("An order has been started");

            string lastAddedId = "select restockingID from restocking  order by orderdate desc ";
            cmd.CommandText = lastAddedId;

            object result = cmd.ExecuteScalar();
            result = (result == DBNull.Value) ? null : result;
            int restockingID = Convert.ToInt32(result);

            AddStockForm newAddStockForm = new AddStockForm(shopid, restockingID);

            
            newAddStockForm.FormClosing += new FormClosingEventHandler(this.Form2_FormClosing); //links the 2 forms together so if one closes it does something
            newAddStockForm.Show();


        }



        private void Form2_FormClosing(object sender, FormClosingEventArgs e)//this is what it does
        {

            //check if form closed and if then executes this code
            MessageBox.Show("Hey panini");
            try
            {
                reloadDataGridView(sqlQueryStock, dataGridView1);
                reloadDataGridView(sqlQueryProducts, dataGridView2);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "ProductError");

            }

        }
    }

}
