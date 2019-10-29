using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KaihatsuEnshuu
{
    public partial class SupplyChainManager : template.Form1
    {
        public SupplyChainManager()
        {
            InitializeComponent();
        }

        private void SupplyChainManager_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'oI21Database1DataSet.注文内容' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.注文内容TableAdapter.Fill(this.oI21Database1DataSet.注文内容);
            // TODO: このコード行はデータを 'oI21Database1DataSet.注文' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.注文TableAdapter.Fill(this.oI21Database1DataSet.注文);

        }
    }
}
