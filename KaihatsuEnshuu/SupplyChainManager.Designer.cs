namespace KaihatsuEnshuu
{
    partial class SupplyChainManager
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.oI21Database1DataSet = new KaihatsuEnshuu.OI21Database1DataSet();
            this.注文BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.注文TableAdapter = new KaihatsuEnshuu.OI21Database1DataSetTableAdapters.注文TableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.注文内容BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.注文内容TableAdapter = new KaihatsuEnshuu.OI21Database1DataSetTableAdapters.注文内容TableAdapter();
            this.ApproveOrder = new System.Windows.Forms.Button();
            this.CancelOrder = new System.Windows.Forms.Button();
            this.SendOrder = new System.Windows.Forms.Button();
            this.DisplaySentOrders = new System.Windows.Forms.Button();
            this.DisplayOrders = new System.Windows.Forms.Button();
            this.DisplayCanceledOrders = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.注文BindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.注文内容BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DisplayCanceledOrders);
            this.groupBox1.Controls.Add(this.DisplayOrders);
            this.groupBox1.Controls.Add(this.DisplaySentOrders);
            this.groupBox1.Controls.Add(this.SendOrder);
            this.groupBox1.Controls.Add(this.CancelOrder);
            this.groupBox1.Controls.Add(this.ApproveOrder);
            this.groupBox1.Location = new System.Drawing.Point(18, 21);
            this.groupBox1.Size = new System.Drawing.Size(644, 296);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(671, 21);
            this.groupBox3.Size = new System.Drawing.Size(823, 698);
            this.groupBox3.Text = "注文内容";
            // 
            // oI21Database1DataSet
            // 
            this.oI21Database1DataSet.DataSetName = "OI21Database1DataSet";
            this.oI21Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 注文BindingSource
            // 
            this.注文BindingSource.DataMember = "注文";
            this.注文BindingSource.DataSource = this.oI21Database1DataSet;
            // 
            // 注文TableAdapter
            // 
            this.注文TableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(15, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 393);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "注文一覧";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(644, 372);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(817, 675);
            this.dataGridView2.TabIndex = 0;
            // 
            // 注文内容BindingSource
            // 
            this.注文内容BindingSource.DataMember = "注文内容";
            this.注文内容BindingSource.DataSource = this.oI21Database1DataSet;
            // 
            // 注文内容TableAdapter
            // 
            this.注文内容TableAdapter.ClearBeforeFill = true;
            // 
            // ApproveOrder
            // 
            this.ApproveOrder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ApproveOrder.ForeColor = System.Drawing.Color.Black;
            this.ApproveOrder.Location = new System.Drawing.Point(397, 23);
            this.ApproveOrder.Name = "ApproveOrder";
            this.ApproveOrder.Size = new System.Drawing.Size(204, 83);
            this.ApproveOrder.TabIndex = 0;
            this.ApproveOrder.Text = "注文確認";
            this.ApproveOrder.UseVisualStyleBackColor = false;
            this.ApproveOrder.Click += new System.EventHandler(this.ApproveOrder_Click);
            // 
            // CancelOrder
            // 
            this.CancelOrder.ForeColor = System.Drawing.Color.Black;
            this.CancelOrder.Location = new System.Drawing.Point(397, 112);
            this.CancelOrder.Name = "CancelOrder";
            this.CancelOrder.Size = new System.Drawing.Size(204, 88);
            this.CancelOrder.TabIndex = 3;
            this.CancelOrder.Text = "注文キャンセル";
            this.CancelOrder.UseVisualStyleBackColor = true;
            this.CancelOrder.Click += new System.EventHandler(this.CancelOrder_Click);
            // 
            // SendOrder
            // 
            this.SendOrder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SendOrder.ForeColor = System.Drawing.Color.Black;
            this.SendOrder.Location = new System.Drawing.Point(397, 206);
            this.SendOrder.Name = "SendOrder";
            this.SendOrder.Size = new System.Drawing.Size(204, 84);
            this.SendOrder.TabIndex = 4;
            this.SendOrder.Text = "注文発送";
            this.SendOrder.UseVisualStyleBackColor = false;
            this.SendOrder.Click += new System.EventHandler(this.SendOrder_Click);
            // 
            // DisplaySentOrders
            // 
            this.DisplaySentOrders.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DisplaySentOrders.ForeColor = System.Drawing.Color.Black;
            this.DisplaySentOrders.Location = new System.Drawing.Point(6, 109);
            this.DisplaySentOrders.Name = "DisplaySentOrders";
            this.DisplaySentOrders.Size = new System.Drawing.Size(211, 91);
            this.DisplaySentOrders.TabIndex = 5;
            this.DisplaySentOrders.Text = "発送した注文一覧";
            this.DisplaySentOrders.UseVisualStyleBackColor = false;
            this.DisplaySentOrders.Click += new System.EventHandler(this.DisplaySentOrders_Click);
            // 
            // DisplayOrders
            // 
            this.DisplayOrders.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DisplayOrders.ForeColor = System.Drawing.Color.Black;
            this.DisplayOrders.Location = new System.Drawing.Point(6, 23);
            this.DisplayOrders.Name = "DisplayOrders";
            this.DisplayOrders.Size = new System.Drawing.Size(211, 80);
            this.DisplayOrders.TabIndex = 6;
            this.DisplayOrders.Text = "注文一覧";
            this.DisplayOrders.UseVisualStyleBackColor = false;
            this.DisplayOrders.Click += new System.EventHandler(this.DisplayOrders_Click);
            // 
            // DisplayCanceledOrders
            // 
            this.DisplayCanceledOrders.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DisplayCanceledOrders.ForeColor = System.Drawing.Color.Black;
            this.DisplayCanceledOrders.Location = new System.Drawing.Point(6, 206);
            this.DisplayCanceledOrders.Name = "DisplayCanceledOrders";
            this.DisplayCanceledOrders.Size = new System.Drawing.Size(211, 84);
            this.DisplayCanceledOrders.TabIndex = 7;
            this.DisplayCanceledOrders.Text = "キャンセルした注文一覧";
            this.DisplayCanceledOrders.UseVisualStyleBackColor = false;
            this.DisplayCanceledOrders.Click += new System.EventHandler(this.DisplayCanceledOrders_Click);
            // 
            // SupplyChainManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1506, 757);
            this.Controls.Add(this.groupBox2);
            this.Name = "SupplyChainManager";
            this.Text = "物流担当";
            this.Load += new System.EventHandler(this.SupplyChainManager_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.注文BindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.注文内容BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private OI21Database1DataSet oI21Database1DataSet;
        private System.Windows.Forms.BindingSource 注文BindingSource;
        private OI21Database1DataSetTableAdapters.注文TableAdapter 注文TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource 注文内容BindingSource;
        private OI21Database1DataSetTableAdapters.注文内容TableAdapter 注文内容TableAdapter;
        private System.Windows.Forms.Button CancelOrder;
        private System.Windows.Forms.Button ApproveOrder;
        private System.Windows.Forms.Button DisplayCanceledOrders;
        private System.Windows.Forms.Button DisplayOrders;
        private System.Windows.Forms.Button DisplaySentOrders;
        private System.Windows.Forms.Button SendOrder;
    }
}
