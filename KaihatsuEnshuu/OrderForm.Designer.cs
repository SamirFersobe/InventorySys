namespace KaihatsuEnshuu
{
    partial class OrderForm
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
            this.AddToOrderButton = new System.Windows.Forms.Button();
            this.CancelOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ClearOrder = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.brandLabel = new System.Windows.Forms.Label();
            this.BrandComboBoxFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoryComboBoxFilter = new System.Windows.Forms.ComboBox();
            this.ShowAllProducts = new System.Windows.Forms.Button();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BrandName = new System.Windows.Forms.TextBox();
            this.categoryFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.brandFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filterButton);
            this.groupBox1.Controls.Add(this.categoryFilterCheckBox);
            this.groupBox1.Controls.Add(this.brandFilterCheckBox);
            this.groupBox1.Controls.Add(this.BrandName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ProductName);
            this.groupBox1.Controls.Add(this.ShowAllProducts);
            this.groupBox1.Controls.Add(this.CategoryComboBoxFilter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BrandComboBoxFilter);
            this.groupBox1.Controls.Add(this.brandLabel);
            this.groupBox1.Controls.Add(this.SubmitButton);
            this.groupBox1.Controls.Add(this.ClearOrder);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CancelOrder);
            this.groupBox1.Controls.Add(this.AddToOrderButton);
            this.groupBox1.Location = new System.Drawing.Point(26, 48);
            this.groupBox1.Size = new System.Drawing.Size(736, 273);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(793, 28);
            this.groupBox3.Size = new System.Drawing.Size(671, 671);
            this.groupBox3.Text = "商品一覧";
            // 
            // AddToOrderButton
            // 
            this.AddToOrderButton.Location = new System.Drawing.Point(92, 204);
            this.AddToOrderButton.Name = "AddToOrderButton";
            this.AddToOrderButton.Size = new System.Drawing.Size(279, 50);
            this.AddToOrderButton.TabIndex = 0;
            this.AddToOrderButton.Text = "商品を追加";
            this.AddToOrderButton.UseVisualStyleBackColor = true;
            this.AddToOrderButton.Click += new System.EventHandler(this.AddToOrderButton_Click);
            // 
            // CancelOrder
            // 
            this.CancelOrder.Location = new System.Drawing.Point(422, 109);
            this.CancelOrder.Name = "CancelOrder";
            this.CancelOrder.Size = new System.Drawing.Size(128, 50);
            this.CancelOrder.TabIndex = 1;
            this.CancelOrder.Text = "注文キャンセル";
            this.CancelOrder.UseVisualStyleBackColor = true;
            this.CancelOrder.Click += new System.EventHandler(this.CancelOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "数量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "商品名";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(665, 648);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(733, 351);
            this.dataGridView2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 24);
            this.textBox1.TabIndex = 5;
            // 
            // ClearOrder
            // 
            this.ClearOrder.Location = new System.Drawing.Point(565, 109);
            this.ClearOrder.Name = "ClearOrder";
            this.ClearOrder.Size = new System.Drawing.Size(128, 50);
            this.ClearOrder.TabIndex = 6;
            this.ClearOrder.Text = "注文クリア";
            this.ClearOrder.UseVisualStyleBackColor = true;
            this.ClearOrder.Click += new System.EventHandler(this.ClearOrder_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(435, 204);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(238, 50);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "注文確定";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(26, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 372);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "注文一覧";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(36, 56);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(119, 17);
            this.brandLabel.TabIndex = 8;
            this.brandLabel.Text = "ブランドフィルター";
            // 
            // BrandComboBoxFilter
            // 
            this.BrandComboBoxFilter.FormattingEnabled = true;
            this.BrandComboBoxFilter.Location = new System.Drawing.Point(184, 51);
            this.BrandComboBoxFilter.Name = "BrandComboBoxFilter";
            this.BrandComboBoxFilter.Size = new System.Drawing.Size(187, 25);
            this.BrandComboBoxFilter.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "商品類フィルター";
            // 
            // CategoryComboBoxFilter
            // 
            this.CategoryComboBoxFilter.FormattingEnabled = true;
            this.CategoryComboBoxFilter.Location = new System.Drawing.Point(183, 20);
            this.CategoryComboBoxFilter.Name = "CategoryComboBoxFilter";
            this.CategoryComboBoxFilter.Size = new System.Drawing.Size(188, 25);
            this.CategoryComboBoxFilter.TabIndex = 11;
            // 
            // ShowAllProducts
            // 
            this.ShowAllProducts.Location = new System.Drawing.Point(565, 24);
            this.ShowAllProducts.Name = "ShowAllProducts";
            this.ShowAllProducts.Size = new System.Drawing.Size(125, 46);
            this.ShowAllProducts.TabIndex = 13;
            this.ShowAllProducts.Text = "全品表示";
            this.ShowAllProducts.UseVisualStyleBackColor = true;
            this.ShowAllProducts.Click += new System.EventHandler(this.ShowAllProducts_Click);
            // 
            // ProductName
            // 
            this.ProductName.Enabled = false;
            this.ProductName.Location = new System.Drawing.Point(100, 135);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(271, 24);
            this.ProductName.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "ブランド";
            // 
            // BrandName
            // 
            this.BrandName.Enabled = false;
            this.BrandName.Location = new System.Drawing.Point(101, 98);
            this.BrandName.Name = "BrandName";
            this.BrandName.Size = new System.Drawing.Size(270, 24);
            this.BrandName.TabIndex = 18;
            // 
            // categoryFilterCheckBox
            // 
            this.categoryFilterCheckBox.AutoSize = true;
            this.categoryFilterCheckBox.Location = new System.Drawing.Point(380, 28);
            this.categoryFilterCheckBox.Name = "categoryFilterCheckBox";
            this.categoryFilterCheckBox.Size = new System.Drawing.Size(18, 17);
            this.categoryFilterCheckBox.TabIndex = 20;
            this.categoryFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // brandFilterCheckBox
            // 
            this.brandFilterCheckBox.AutoSize = true;
            this.brandFilterCheckBox.Location = new System.Drawing.Point(380, 59);
            this.brandFilterCheckBox.Name = "brandFilterCheckBox";
            this.brandFilterCheckBox.Size = new System.Drawing.Size(18, 17);
            this.brandFilterCheckBox.TabIndex = 19;
            this.brandFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(422, 24);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(128, 44);
            this.filterButton.TabIndex = 21;
            this.filterButton.Text = "フィルター";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click_1);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1506, 769);
            this.Controls.Add(this.groupBox2);
            this.Name = "OrderForm";
            this.Text = "注文画面";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderForm_FormClosed);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelOrder;
        private System.Windows.Forms.Button AddToOrderButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ClearOrder;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Button ShowAllProducts;
        private System.Windows.Forms.ComboBox CategoryComboBoxFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BrandComboBoxFilter;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.TextBox BrandName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.CheckBox categoryFilterCheckBox;
        private System.Windows.Forms.CheckBox brandFilterCheckBox;
    }
}
