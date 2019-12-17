using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace template
{
    public partial class Form1 : Form
    {

     public string DatabaseConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();

        }

        public void FillComboBox(String displayMember, String valueMember, ComboBox combo, String table)
        {

            DataTable dt = new DataTable();
            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            string sql1 = "SELECT " + displayMember + "  , " + valueMember + " FROM " + table;
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sql1, con);

            da.Fill(dt);

            combo.DataSource = dt.DefaultView;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;

            con.Close();
        }


        public void reloadDataGridView(string sql, DataGridView dataGridView1)
        {
            DataTable dt = new DataTable();
            OleDbConnection conReload = new OleDbConnection(DatabaseConnectionString);
            OleDbDataAdapter da = new OleDbDataAdapter(sql, conReload);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           
        }
    }
}
