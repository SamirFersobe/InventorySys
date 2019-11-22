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

        string sqlQuery = "select * from stock";
        public StockForm()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            try
            {
                reloadDataGridView(sqlQuery, dataGridView1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "ProductError");
            }


            
        }


    }
}
