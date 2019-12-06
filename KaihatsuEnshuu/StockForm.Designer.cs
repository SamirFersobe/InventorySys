namespace KaihatsuEnshuu
{
    partial class StockForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.AddStock = new System.Windows.Forms.Button();
            this.stockIdComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.restockExistingOrders = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.restockExistingOrders);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.stockIdComboBox);
            this.groupBox1.Controls.Add(this.AddStock);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(15, 493);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 277);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(346, 256);
            this.dataGridView2.TabIndex = 0;
            // 
            // AddStock
            // 
            this.AddStock.Location = new System.Drawing.Point(90, 92);
            this.AddStock.Name = "AddStock";
            this.AddStock.Size = new System.Drawing.Size(129, 63);
            this.AddStock.TabIndex = 0;
            this.AddStock.Text = "Add Stock";
            this.AddStock.UseVisualStyleBackColor = true;
            this.AddStock.Click += new System.EventHandler(this.AddStock_Click);
            // 
            // stockIdComboBox
            // 
            this.stockIdComboBox.FormattingEnabled = true;
            this.stockIdComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.stockIdComboBox.Location = new System.Drawing.Point(158, 41);
            this.stockIdComboBox.Name = "stockIdComboBox";
            this.stockIdComboBox.Size = new System.Drawing.Size(77, 25);
            this.stockIdComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "SHOP ID";
            // 
            // restockExistingOrders
            // 
            this.restockExistingOrders.Location = new System.Drawing.Point(90, 170);
            this.restockExistingOrders.Name = "restockExistingOrders";
            this.restockExistingOrders.Size = new System.Drawing.Size(129, 69);
            this.restockExistingOrders.TabIndex = 3;
            this.restockExistingOrders.Text = "Restock Current Orders";
            this.restockExistingOrders.UseVisualStyleBackColor = true;
            this.restockExistingOrders.Click += new System.EventHandler(this.restockExistingOrders_Click);
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1506, 798);
            this.Controls.Add(this.groupBox2);
            this.Name = "StockForm";
            this.Text = "StockForm";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button AddStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stockIdComboBox;
        private System.Windows.Forms.Button restockExistingOrders;
    }
}
