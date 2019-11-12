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
        public OrderForm(string customerID , string employeeID)
        {
            InitializeComponent();

            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            try
            {
                string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";
                OleDbConnection con = new OleDbConnection(str);
                string sql1 = "SELECT pBrand,pName,Pprice FROM products";

                OleDbDataAdapter da = new OleDbDataAdapter(sql1, con);
                da.Fill(dt1);

                dataGridView1.DataSource = dt1;
                //MessageBox.Show("Values loaded ...!!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 1");
            }

            try
            {
                string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";
                OleDbConnection con = new OleDbConnection(str);
                string sql2 = "SELECT  * FROM orderDetails where customerId = " + customerID;

                OleDbDataAdapter da = new OleDbDataAdapter(sql2, con);
                da.Fill(dt2);

                dataGridView2.DataSource = dt2;
               // MessageBox.Show("Values loaded ...!!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 2");
            }


            FillComboBox("pName", "pId", comboBox1, "products");



        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {


            string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";
            OleDbConnection con = new OleDbConnection(str);
            string sql2 = "INSERT INTO orderDetails ()";

            OleDbDataAdapter da = new OleDbDataAdapter(sql2, con);
            this.Refresh();
        }
    }
}
