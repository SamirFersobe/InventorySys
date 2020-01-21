namespace KaihatsuEnshuu
{
    partial class AddStockForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ClearOrder = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelOrder = new System.Windows.Forms.Button();
            this.AddToOrderButton = new System.Windows.Forms.Button();
            this.SubmitRestock = new System.Windows.Forms.Button();
            this.AddAllRequiredItems = new System.Windows.Forms.Button();
            this.categoryFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.brandFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labels222 = new System.Windows.Forms.Label();
            this.Filter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.productName);
            this.groupBox1.Controls.Add(this.brandTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Filter);
            this.groupBox1.Controls.Add(this.categoryFilterCheckBox);
            this.groupBox1.Controls.Add(this.brandFilterCheckBox);
            this.groupBox1.Controls.Add(this.brandComboBox);
            this.groupBox1.Controls.Add(this.categoryComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labels222);
            this.groupBox1.Controls.Add(this.AddAllRequiredItems);
            this.groupBox1.Controls.Add(this.SubmitRestock);
            this.groupBox1.Controls.Add(this.ClearOrder);
            this.groupBox1.Controls.Add(this.quantityTextBox);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CancelOrder);
            this.groupBox1.Controls.Add(this.AddToOrderButton);
            this.groupBox1.Location = new System.Drawing.Point(15, 52);
            this.groupBox1.Size = new System.Drawing.Size(681, 307);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(722, 52);
            this.groupBox3.Size = new System.Drawing.Size(758, 664);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(15, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 354);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restocking Order";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(678, 333);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(752, 641);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // ClearOrder
            // 
            this.ClearOrder.Location = new System.Drawing.Point(480, 184);
            this.ClearOrder.Name = "ClearOrder";
            this.ClearOrder.Size = new System.Drawing.Size(150, 51);
            this.ClearOrder.TabIndex = 13;
            this.ClearOrder.Text = "入荷クリア";
            this.ClearOrder.UseVisualStyleBackColor = true;
            this.ClearOrder.Click += new System.EventHandler(this.ClearOrder_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(118, 174);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(58, 24);
            this.quantityTextBox.TabIndex = 12;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(34, 139);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(42, 17);
            this.label.TabIndex = 10;
            this.label.Text = "商品";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "数";
            // 
            // CancelOrder
            // 
            this.CancelOrder.Location = new System.Drawing.Point(480, 241);
            this.CancelOrder.Name = "CancelOrder";
            this.CancelOrder.Size = new System.Drawing.Size(150, 60);
            this.CancelOrder.TabIndex = 8;
            this.CancelOrder.Text = "入荷キャンセル";
            this.CancelOrder.UseVisualStyleBackColor = true;
            this.CancelOrder.Click += new System.EventHandler(this.CancelOrder_Click);
            // 
            // AddToOrderButton
            // 
            this.AddToOrderButton.Location = new System.Drawing.Point(118, 204);
            this.AddToOrderButton.Name = "AddToOrderButton";
            this.AddToOrderButton.Size = new System.Drawing.Size(196, 75);
            this.AddToOrderButton.TabIndex = 7;
            this.AddToOrderButton.Text = "追加";
            this.AddToOrderButton.UseVisualStyleBackColor = true;
            this.AddToOrderButton.Click += new System.EventHandler(this.AddToOrderButton_Click);
            // 
            // SubmitRestock
            // 
            this.SubmitRestock.Location = new System.Drawing.Point(480, 120);
            this.SubmitRestock.Name = "SubmitRestock";
            this.SubmitRestock.Size = new System.Drawing.Size(150, 56);
            this.SubmitRestock.TabIndex = 14;
            this.SubmitRestock.Text = "入荷確定";
            this.SubmitRestock.UseVisualStyleBackColor = true;
            this.SubmitRestock.Click += new System.EventHandler(this.SubmitRestock_Click);
            // 
            // AddAllRequiredItems
            // 
            this.AddAllRequiredItems.Location = new System.Drawing.Point(498, 24);
            this.AddAllRequiredItems.Name = "AddAllRequiredItems";
            this.AddAllRequiredItems.Size = new System.Drawing.Size(157, 75);
            this.AddAllRequiredItems.TabIndex = 15;
            this.AddAllRequiredItems.Text = "すべてのアイテムを追加します";
            this.AddAllRequiredItems.UseVisualStyleBackColor = true;
            this.AddAllRequiredItems.Click += new System.EventHandler(this.AddAllRequiredItems_Click);
            // 
            // categoryFilterCheckBox
            // 
            this.categoryFilterCheckBox.AutoSize = true;
            this.categoryFilterCheckBox.Location = new System.Drawing.Point(366, 24);
            this.categoryFilterCheckBox.Name = "categoryFilterCheckBox";
            this.categoryFilterCheckBox.Size = new System.Drawing.Size(18, 17);
            this.categoryFilterCheckBox.TabIndex = 21;
            this.categoryFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // brandFilterCheckBox
            // 
            this.brandFilterCheckBox.AutoSize = true;
            this.brandFilterCheckBox.Location = new System.Drawing.Point(366, 63);
            this.brandFilterCheckBox.Name = "brandFilterCheckBox";
            this.brandFilterCheckBox.Size = new System.Drawing.Size(18, 17);
            this.brandFilterCheckBox.TabIndex = 20;
            this.brandFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // brandComboBox
            // 
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(162, 55);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(197, 25);
            this.brandComboBox.TabIndex = 19;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(162, 20);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(197, 25);
            this.categoryComboBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "ブランドフィルター";
            // 
            // labels222
            // 
            this.labels222.AutoSize = true;
            this.labels222.Location = new System.Drawing.Point(36, 20);
            this.labels222.Name = "labels222";
            this.labels222.Size = new System.Drawing.Size(120, 17);
            this.labels222.TabIndex = 16;
            this.labels222.Text = "商品類フィルター";
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(400, 23);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(92, 56);
            this.Filter.TabIndex = 22;
            this.Filter.Text = "フィルター";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "ブランド";
            // 
            // brandTextBox
            // 
            this.brandTextBox.Enabled = false;
            this.brandTextBox.Location = new System.Drawing.Point(118, 107);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(196, 24);
            this.brandTextBox.TabIndex = 25;
            // 
            // productName
            // 
            this.productName.Enabled = false;
            this.productName.Location = new System.Drawing.Point(118, 137);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(196, 24);
            this.productName.TabIndex = 27;
            // 
            // AddStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1506, 757);
            this.Controls.Add(this.groupBox2);
            this.Name = "AddStockForm";
            this.Text = "入荷注文画面";
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ClearOrder;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelOrder;
        private System.Windows.Forms.Button AddToOrderButton;
        private System.Windows.Forms.Button SubmitRestock;
        private System.Windows.Forms.Button AddAllRequiredItems;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.CheckBox categoryFilterCheckBox;
        private System.Windows.Forms.CheckBox brandFilterCheckBox;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labels222;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productName;
    }
}
