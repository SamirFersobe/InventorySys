using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaihatsuEnshuu
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void addproduct_Click(object sender, EventArgs e)
        {




            
        }

        private void cancelProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを '販売在庫管理システムDBDataSet.テーブル2' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.テーブル2TableAdapter.Fill(this.販売在庫管理システムDBDataSet.テーブル2);
            // TODO: このコード行はデータを '販売在庫管理システムDBDataSet.テーブル1' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.テーブル1TableAdapter.Fill(this.販売在庫管理システムDBDataSet.テーブル1);

        }
    }
}
