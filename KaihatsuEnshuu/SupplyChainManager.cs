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
    public partial class SupplyChainManager : template.Form1
    {
        public SupplyChainManager()
        {
            InitializeComponent();
        }


        DataTable dt = new DataTable();
        private void SupplyChainManager_Load(object sender, EventArgs e)
        {


            try
            {
                string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";
                OleDbConnection con = new OleDbConnection(str);
                string sql = "SELECT * FROM 色";//change info to name of database
                OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
                da.Fill(dt);
                dataGridView3.DataSource = dt;
                MessageBox.Show("Values loaded ...!!!");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "pen");
            }
            // TODO: このコード行はデータを 'oI21Database1DataSet.注文内容' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.注文内容TableAdapter.Fill(this.oI21Database1DataSet.注文内容);
            // TODO: このコード行はデータを 'oI21Database1DataSet.注文' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.注文TableAdapter.Fill(this.oI21Database1DataSet.注文);

        }
    }
}
