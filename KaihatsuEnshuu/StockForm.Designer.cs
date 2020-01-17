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
            this.AddStock = new System.Windows.Forms.Button();
            this.stockIdComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StockInventoryLabel = new System.Windows.Forms.Label();
            this.labels222 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.displayAllButton = new System.Windows.Forms.Button();
            this.shopFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.brandFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.categoryFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.oI21Database1DataSet1 = new KaihatsuEnshuu.OI21Database1DataSet();
            this.allTogetherButton = new System.Windows.Forms.Button();
            this.AddShopsCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddShopsCheckBox);
            this.groupBox1.Controls.Add(this.allTogetherButton);
            this.groupBox1.Controls.Add(this.categoryFilterCheckBox);
            this.groupBox1.Controls.Add(this.brandFilterCheckBox);
            this.groupBox1.Controls.Add(this.shopFilterCheckBox);
            this.groupBox1.Controls.Add(this.displayAllButton);
            this.groupBox1.Controls.Add(this.FilterButton);
            this.groupBox1.Controls.Add(this.brandComboBox);
            this.groupBox1.Controls.Add(this.categoryComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labels222);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.stockIdComboBox);
            this.groupBox1.Controls.Add(this.AddStock);
            this.groupBox1.Location = new System.Drawing.Point(18, 105);
            this.groupBox1.Size = new System.Drawing.Size(352, 494);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.StockInventoryLabel);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox3.Location = new System.Drawing.Point(391, 12);
            this.groupBox3.Size = new System.Drawing.Size(1103, 758);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1097, 735);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddStock
            // 
            this.AddStock.Location = new System.Drawing.Point(98, 388);
            this.AddStock.Name = "AddStock";
            this.AddStock.Size = new System.Drawing.Size(173, 86);
            this.AddStock.TabIndex = 0;
            this.AddStock.Text = "入荷";
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
            this.stockIdComboBox.Location = new System.Drawing.Point(154, 200);
            this.stockIdComboBox.Name = "stockIdComboBox";
            this.stockIdComboBox.Size = new System.Drawing.Size(170, 25);
            this.stockIdComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "店";
            // 
            // StockInventoryLabel
            // 
            this.StockInventoryLabel.AutoSize = true;
            this.StockInventoryLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StockInventoryLabel.Location = new System.Drawing.Point(6, 0);
            this.StockInventoryLabel.Name = "StockInventoryLabel";
            this.StockInventoryLabel.Size = new System.Drawing.Size(93, 20);
            this.StockInventoryLabel.TabIndex = 1;
            this.StockInventoryLabel.Text = "在庫一覧";
            // 
            // labels222
            // 
            this.labels222.AutoSize = true;
            this.labels222.Location = new System.Drawing.Point(28, 92);
            this.labels222.Name = "labels222";
            this.labels222.Size = new System.Drawing.Size(120, 17);
            this.labels222.TabIndex = 3;
            this.labels222.Text = "商品類フィルター";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "ブランドフィルター";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(154, 92);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(170, 25);
            this.categoryComboBox.TabIndex = 6;
            // 
            // brandComboBox
            // 
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(154, 150);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(170, 25);
            this.brandComboBox.TabIndex = 7;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(208, 254);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(140, 40);
            this.FilterButton.TabIndex = 9;
            this.FilterButton.Text = "フィルター";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // displayAllButton
            // 
            this.displayAllButton.Location = new System.Drawing.Point(31, 254);
            this.displayAllButton.Name = "displayAllButton";
            this.displayAllButton.Size = new System.Drawing.Size(121, 42);
            this.displayAllButton.TabIndex = 11;
            this.displayAllButton.Text = "すべて表示";
            this.displayAllButton.UseVisualStyleBackColor = true;
            this.displayAllButton.Click += new System.EventHandler(this.displayAllButton_Click);
            // 
            // shopFilterCheckBox
            // 
            this.shopFilterCheckBox.AutoSize = true;
            this.shopFilterCheckBox.Location = new System.Drawing.Point(330, 204);
            this.shopFilterCheckBox.Name = "shopFilterCheckBox";
            this.shopFilterCheckBox.Size = new System.Drawing.Size(18, 17);
            this.shopFilterCheckBox.TabIndex = 12;
            this.shopFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // brandFilterCheckBox
            // 
            this.brandFilterCheckBox.AutoSize = true;
            this.brandFilterCheckBox.Location = new System.Drawing.Point(330, 154);
            this.brandFilterCheckBox.Name = "brandFilterCheckBox";
            this.brandFilterCheckBox.Size = new System.Drawing.Size(18, 17);
            this.brandFilterCheckBox.TabIndex = 13;
            this.brandFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // categoryFilterCheckBox
            // 
            this.categoryFilterCheckBox.AutoSize = true;
            this.categoryFilterCheckBox.Location = new System.Drawing.Point(330, 96);
            this.categoryFilterCheckBox.Name = "categoryFilterCheckBox";
            this.categoryFilterCheckBox.Size = new System.Drawing.Size(18, 17);
            this.categoryFilterCheckBox.TabIndex = 14;
            this.categoryFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // oI21Database1DataSet1
            // 
            this.oI21Database1DataSet1.DataSetName = "OI21Database1DataSet";
            this.oI21Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allTogetherButton
            // 
            this.allTogetherButton.Location = new System.Drawing.Point(32, 311);
            this.allTogetherButton.Name = "allTogetherButton";
            this.allTogetherButton.Size = new System.Drawing.Size(120, 50);
            this.allTogetherButton.TabIndex = 15;
            this.allTogetherButton.Text = "すべてまとめて表示";
            this.allTogetherButton.UseVisualStyleBackColor = true;
            this.allTogetherButton.Click += new System.EventHandler(this.allTogetherButton_Click);
            // 
            // AddShopsCheckBox
            // 
            this.AddShopsCheckBox.AutoSize = true;
            this.AddShopsCheckBox.Location = new System.Drawing.Point(116, 32);
            this.AddShopsCheckBox.Name = "AddShopsCheckBox";
            this.AddShopsCheckBox.Size = new System.Drawing.Size(102, 21);
            this.AddShopsCheckBox.TabIndex = 16;
            this.AddShopsCheckBox.Text = "在庫まとめ";
            this.AddShopsCheckBox.UseVisualStyleBackColor = true;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1506, 798);
            this.Name = "StockForm";
            this.Text = "StockForm";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stockIdComboBox;
        private System.Windows.Forms.Label StockInventoryLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labels222;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button displayAllButton;
        private System.Windows.Forms.CheckBox categoryFilterCheckBox;
        private System.Windows.Forms.CheckBox brandFilterCheckBox;
        private System.Windows.Forms.CheckBox shopFilterCheckBox;
        private OI21Database1DataSet oI21Database1DataSet1;
        private System.Windows.Forms.Button allTogetherButton;
        private System.Windows.Forms.CheckBox AddShopsCheckBox;
    }
}
