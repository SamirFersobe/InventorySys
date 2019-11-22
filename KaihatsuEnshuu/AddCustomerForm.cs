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
    public partial class AddCustomerForm : template.Form1
    {

        string sqlQuery = "Select * from customers";
        public AddCustomerForm()
        {
            InitializeComponent();

        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

            reloadDataGridView(sqlQuery, dataGridView1);

        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {

            string name = CustomerName.Text.ToString();
            string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";
            OleDbConnection con = new OleDbConnection(str);
            con.Open();
            OleDbCommand cmmd = new OleDbCommand("INSERT INTO customers(customerName) Values(@Name)", con);
            if (con.State == ConnectionState.Open)
            {
                cmmd.Parameters.AddWithValue("@Name", name);
                cmmd.ExecuteNonQuery();

                reloadDataGridView(sqlQuery, dataGridView1);

            }
            con.Close();

            reloadDataGridView(sqlQuery,dataGridView1);

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
