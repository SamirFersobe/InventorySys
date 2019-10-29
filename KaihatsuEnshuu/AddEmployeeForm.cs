using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KaihatsuEnshuu
{
    public partial class AddEmployeeForm : template.Form1
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'oI21Database1DataSet.社員ファイル' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.社員ファイルTableAdapter.Fill(this.oI21Database1DataSet.社員ファイル);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
