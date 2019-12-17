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
    public partial class StockForm : template.Form1
    {

        string sqlQueryStock = "select p.pname as 商品名, p.pbrand as ブランド, s.quantity as 数,s.shop_id  as 店 from stock s inner join products p on (s.productID = p.pid) order by 1,2 " ;
        string sqlQueryProducts = "select distinct shop_id from stock";
        public StockForm()
        {
            InitializeComponent();

            try
            {
                reloadDataGridView(sqlQueryStock, dataGridView1);
                reloadDataGridView(sqlQueryProducts, dataGridView2);

                /**
                dataGridView1.Width =
    dataGridView1.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width)
    + (dataGridView1.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0) + 3;



                dataGridView2.Width =
    dataGridView2.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width)
    + (dataGridView2.RowHeadersVisible ? dataGridView2.RowHeadersWidth : 0) + 3;

    **/
                stockIdComboBox.SelectedIndex = 1;

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

            string lastAddedId = "select @@identity ";
            cmd.CommandText = lastAddedId;
            

            object result = cmd.ExecuteScalar();
            result = (result == DBNull.Value) ? null : result;
            int restockingID = Convert.ToInt32(result);

            AddStockForm newAddStockForm = new AddStockForm(shopid, restockingID);

            
            newAddStockForm.FormClosing += new FormClosingEventHandler(this.Form2_FormClosing); //links the 2 forms together so if one closes it does something
            newAddStockForm.Show();
            MessageBox.Show("Restocking Order has been started");

        }



        private void Form2_FormClosing(object sender, FormClosingEventArgs e)//this is what it does
        {

            //check if form closed and if then executes this code
           
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
