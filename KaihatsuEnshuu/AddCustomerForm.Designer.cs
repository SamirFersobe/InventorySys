namespace KaihatsuEnshuu
{
    partial class AddCustomerForm
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
            this.顧客BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oI21Database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oI21Database1DataSet = new KaihatsuEnshuu.OI21Database1DataSet();
            this.顧客TableAdapter = new KaihatsuEnshuu.OI21Database1DataSetTableAdapters.顧客TableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.顧客BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancel);
            this.groupBox1.Controls.Add(this.AddCustomer);
            this.groupBox1.Controls.Add(this.CustomerName);
            this.groupBox1.Controls.Add(this.label2);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            // 
            // 顧客BindingSource
            // 
            this.顧客BindingSource.DataMember = "顧客";
            this.顧客BindingSource.DataSource = this.oI21Database1DataSetBindingSource;
            // 
            // oI21Database1DataSetBindingSource
            // 
            this.oI21Database1DataSetBindingSource.DataSource = this.oI21Database1DataSet;
            this.oI21Database1DataSetBindingSource.Position = 0;
            // 
            // oI21Database1DataSet
            // 
            this.oI21Database1DataSet.DataSetName = "OI21Database1DataSet";
            this.oI21Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 顧客TableAdapter
            // 
            this.顧客TableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "顧客名";
            // 
            // CustomerName
            // 
            this.CustomerName.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.顧客BindingSource, "顧客名", true));
            this.CustomerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.顧客BindingSource, "顧客名", true));
            this.CustomerName.Location = new System.Drawing.Point(110, 78);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(160, 24);
            this.CustomerName.TabIndex = 1;
            // 
            // AddCustomer
            // 
            this.AddCustomer.Location = new System.Drawing.Point(40, 288);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(104, 46);
            this.AddCustomer.TabIndex = 2;
            this.AddCustomer.Text = "Add Customer";
            this.AddCustomer.UseVisualStyleBackColor = true;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1097, 580);
            this.dataGridView1.TabIndex = 0;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(190, 288);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(104, 46);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancel ";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1506, 757);
            this.Name = "AddCustomerForm";
            this.Load += new System.EventHandler(this.AddCustomerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.顧客BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource oI21Database1DataSetBindingSource;
        private OI21Database1DataSet oI21Database1DataSet;
        private System.Windows.Forms.BindingSource 顧客BindingSource;
        private OI21Database1DataSetTableAdapters.顧客TableAdapter 顧客TableAdapter;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cancel;
    }
}
