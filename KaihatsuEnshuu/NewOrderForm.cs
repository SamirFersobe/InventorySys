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

namespace KaihatsuEnshuu
{
    public partial class NewOrderForm : Form
    {
        public NewOrderForm()
        {
            InitializeComponent();
            FillComboBox("customerName", "customerId", comboBox1, "customers");
        }


        DataTable dt = new DataTable();
        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //start new order  ---> get customer Id , Empno ,date and create a new ID for the order




            OrderForm order = new OrderForm();
            order.Show();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void FillComboBox(String displayMember, String valueMember, ComboBox combo, String table)
        {

            
           DataTable dt = new DataTable();
            InitializeComponent();
            string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";
            OleDbConnection con = new OleDbConnection(str);
            string sql1 = "SELECT "+ displayMember +  "  , "+valueMember+ " FROM "+ table ;
            MessageBox.Show(sql1);

            OleDbDataAdapter da = new OleDbDataAdapter(sql1, con);

            da.Fill(dt);

        　

            combo.DataSource = dt.DefaultView;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;

            con.Close();

        }
    }
}
