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
            this.注文内容IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.注文IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.色IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.サイズIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.合計DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.注文IDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.顧客IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.営業所IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.日付DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.合計DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出庫IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox1.Size = new System.Drawing.Size(352, 288);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
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
            this.groupBox2.Location = new System.Drawing.Point(15, 419);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 285);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.注文IDDataGridViewTextBoxColumn1,
            this.顧客IDDataGridViewTextBoxColumn,
            this.営業所IDDataGridViewTextBoxColumn,
            this.日付DataGridViewTextBoxColumn,
            this.合計DataGridViewTextBoxColumn1,
            this.出庫IDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.注文BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(346, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.注文内容IDDataGridViewTextBoxColumn,
            this.注文IDDataGridViewTextBoxColumn,
            this.商品IDDataGridViewTextBoxColumn,
            this.数量DataGridViewTextBoxColumn,
            this.色IDDataGridViewTextBoxColumn,
            this.サイズIDDataGridViewTextBoxColumn,
            this.合計DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.注文内容BindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1097, 580);
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
            // 注文内容IDDataGridViewTextBoxColumn
            // 
            this.注文内容IDDataGridViewTextBoxColumn.DataPropertyName = "注文内容ID";
            this.注文内容IDDataGridViewTextBoxColumn.HeaderText = "注文内容ID";
            this.注文内容IDDataGridViewTextBoxColumn.Name = "注文内容IDDataGridViewTextBoxColumn";
            // 
            // 注文IDDataGridViewTextBoxColumn
            // 
            this.注文IDDataGridViewTextBoxColumn.DataPropertyName = "注文ID";
            this.注文IDDataGridViewTextBoxColumn.HeaderText = "注文ID";
            this.注文IDDataGridViewTextBoxColumn.Name = "注文IDDataGridViewTextBoxColumn";
            // 
            // 商品IDDataGridViewTextBoxColumn
            // 
            this.商品IDDataGridViewTextBoxColumn.DataPropertyName = "商品ID";
            this.商品IDDataGridViewTextBoxColumn.HeaderText = "商品ID";
            this.商品IDDataGridViewTextBoxColumn.Name = "商品IDDataGridViewTextBoxColumn";
            // 
            // 数量DataGridViewTextBoxColumn
            // 
            this.数量DataGridViewTextBoxColumn.DataPropertyName = "数量";
            this.数量DataGridViewTextBoxColumn.HeaderText = "数量";
            this.数量DataGridViewTextBoxColumn.Name = "数量DataGridViewTextBoxColumn";
            // 
            // 色IDDataGridViewTextBoxColumn
            // 
            this.色IDDataGridViewTextBoxColumn.DataPropertyName = "色ID";
            this.色IDDataGridViewTextBoxColumn.HeaderText = "色ID";
            this.色IDDataGridViewTextBoxColumn.Name = "色IDDataGridViewTextBoxColumn";
            // 
            // サイズIDDataGridViewTextBoxColumn
            // 
            this.サイズIDDataGridViewTextBoxColumn.DataPropertyName = "サイズID";
            this.サイズIDDataGridViewTextBoxColumn.HeaderText = "サイズID";
            this.サイズIDDataGridViewTextBoxColumn.Name = "サイズIDDataGridViewTextBoxColumn";
            // 
            // 合計DataGridViewTextBoxColumn
            // 
            this.合計DataGridViewTextBoxColumn.DataPropertyName = "合計";
            this.合計DataGridViewTextBoxColumn.HeaderText = "合計";
            this.合計DataGridViewTextBoxColumn.Name = "合計DataGridViewTextBoxColumn";
            // 
            // 注文IDDataGridViewTextBoxColumn1
            // 
            this.注文IDDataGridViewTextBoxColumn1.DataPropertyName = "注文ID";
            this.注文IDDataGridViewTextBoxColumn1.HeaderText = "注文ID";
            this.注文IDDataGridViewTextBoxColumn1.Name = "注文IDDataGridViewTextBoxColumn1";
            // 
            // 顧客IDDataGridViewTextBoxColumn
            // 
            this.顧客IDDataGridViewTextBoxColumn.DataPropertyName = "顧客ID";
            this.顧客IDDataGridViewTextBoxColumn.HeaderText = "顧客ID";
            this.顧客IDDataGridViewTextBoxColumn.Name = "顧客IDDataGridViewTextBoxColumn";
            // 
            // 営業所IDDataGridViewTextBoxColumn
            // 
            this.営業所IDDataGridViewTextBoxColumn.DataPropertyName = "営業所ID";
            this.営業所IDDataGridViewTextBoxColumn.HeaderText = "営業所ID";
            this.営業所IDDataGridViewTextBoxColumn.Name = "営業所IDDataGridViewTextBoxColumn";
            // 
            // 日付DataGridViewTextBoxColumn
            // 
            this.日付DataGridViewTextBoxColumn.DataPropertyName = "日付";
            this.日付DataGridViewTextBoxColumn.HeaderText = "日付";
            this.日付DataGridViewTextBoxColumn.Name = "日付DataGridViewTextBoxColumn";
            // 
            // 合計DataGridViewTextBoxColumn1
            // 
            this.合計DataGridViewTextBoxColumn1.DataPropertyName = "合計";
            this.合計DataGridViewTextBoxColumn1.HeaderText = "合計";
            this.合計DataGridViewTextBoxColumn1.Name = "合計DataGridViewTextBoxColumn1";
            // 
            // 出庫IDDataGridViewTextBoxColumn
            // 
            this.出庫IDDataGridViewTextBoxColumn.DataPropertyName = "出庫ID}";
            this.出庫IDDataGridViewTextBoxColumn.HeaderText = "出庫ID}";
            this.出庫IDDataGridViewTextBoxColumn.Name = "出庫IDDataGridViewTextBoxColumn";
            // 
            // SupplyChainManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1506, 757);
            this.Controls.Add(this.groupBox2);
            this.Name = "SupplyChainManager";
            this.Text = "物量担当";
            this.Load += new System.EventHandler(this.SupplyChainManager_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.注文BindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.注文内容BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridViewTextBoxColumn 注文内容IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 注文IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 色IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn サイズIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 合計DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 注文IDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 顧客IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 営業所IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日付DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 合計DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出庫IDDataGridViewTextBoxColumn;
    }
}
