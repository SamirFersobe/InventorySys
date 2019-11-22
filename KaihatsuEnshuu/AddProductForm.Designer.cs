namespace KaihatsuEnshuu
{
    partial class AddProductForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.商品BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oI21Database1DataSet = new KaihatsuEnshuu.OI21Database1DataSet();
            this.商品TableAdapter = new KaihatsuEnshuu.OI21Database1DataSetTableAdapters.商品TableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.カテゴリーBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductNameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.productPrice = new System.Windows.Forms.MaskedTextBox();
            this.色BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.サイズBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.色TableAdapter = new KaihatsuEnshuu.OI21Database1DataSetTableAdapters.色TableAdapter();
            this.サイズTableAdapter = new KaihatsuEnshuu.OI21Database1DataSetTableAdapters.サイズTableAdapter();
            this.カテゴリーTableAdapter = new KaihatsuEnshuu.OI21Database1DataSetTableAdapters.カテゴリーTableAdapter();
            this.addProductButton = new System.Windows.Forms.Button();
            this.brandTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.カテゴリーBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.色BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.サイズBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.brandTextBox);
            this.groupBox1.Controls.Add(this.addProductButton);
            this.groupBox1.Controls.Add(this.productPrice);
            this.groupBox1.Controls.Add(this.ProductNameMaskedTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
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
            // 商品BindingSource
            // 
            this.商品BindingSource.DataMember = "商品";
            this.商品BindingSource.DataSource = this.oI21Database1DataSet;
            // 
            // oI21Database1DataSet
            // 
            this.oI21Database1DataSet.DataSetName = "OI21Database1DataSet";
            this.oI21Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 商品TableAdapter
            // 
            this.商品TableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "商品価格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "商品名";
            // 
            // カテゴリーBindingSource
            // 
            this.カテゴリーBindingSource.DataMember = "カテゴリー";
            this.カテゴリーBindingSource.DataSource = this.oI21Database1DataSet;
            // 
            // ProductNameMaskedTextBox
            // 
            this.ProductNameMaskedTextBox.Location = new System.Drawing.Point(139, 20);
            this.ProductNameMaskedTextBox.Name = "ProductNameMaskedTextBox";
            this.ProductNameMaskedTextBox.Size = new System.Drawing.Size(198, 24);
            this.ProductNameMaskedTextBox.TabIndex = 6;
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(139, 139);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(198, 24);
            this.productPrice.TabIndex = 8;
            // 
            // 色BindingSource
            // 
            this.色BindingSource.DataMember = "色";
            this.色BindingSource.DataSource = this.oI21Database1DataSet;
            // 
            // サイズBindingSource
            // 
            this.サイズBindingSource.DataMember = "サイズ";
            this.サイズBindingSource.DataSource = this.oI21Database1DataSet;
            // 
            // 色TableAdapter
            // 
            this.色TableAdapter.ClearBeforeFill = true;
            // 
            // サイズTableAdapter
            // 
            this.サイズTableAdapter.ClearBeforeFill = true;
            // 
            // カテゴリーTableAdapter
            // 
            this.カテゴリーTableAdapter.ClearBeforeFill = true;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(39, 229);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(116, 59);
            this.addProductButton.TabIndex = 12;
            this.addProductButton.Text = "追加";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(139, 80);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(198, 24);
            this.brandTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "商品ブランド";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1506, 757);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.カテゴリーBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.色BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.サイズBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private OI21Database1DataSet oI21Database1DataSet;
        private System.Windows.Forms.BindingSource 商品BindingSource;
        private OI21Database1DataSetTableAdapters.商品TableAdapter 商品TableAdapter;
        private System.Windows.Forms.MaskedTextBox productPrice;
        private System.Windows.Forms.MaskedTextBox ProductNameMaskedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource 色BindingSource;
        private OI21Database1DataSetTableAdapters.色TableAdapter 色TableAdapter;
        private System.Windows.Forms.BindingSource サイズBindingSource;
        private OI21Database1DataSetTableAdapters.サイズTableAdapter サイズTableAdapter;
        private System.Windows.Forms.BindingSource カテゴリーBindingSource;
        private OI21Database1DataSetTableAdapters.カテゴリーTableAdapter カテゴリーTableAdapter;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.MaskedTextBox brandTextBox;
        private System.Windows.Forms.Label label1;
    }
}
