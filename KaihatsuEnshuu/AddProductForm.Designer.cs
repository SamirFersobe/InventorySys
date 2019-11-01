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
            this.oI21Database1DataSet = new KaihatsuEnshuu.OI21Database1DataSet();
            this.商品BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.商品TableAdapter = new KaihatsuEnshuu.OI21Database1DataSetTableAdapters.商品TableAdapter();
            this.商品IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.カテゴリーIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品価格DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品説明DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.色可能DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.サイズ可能DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ProductNameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.色BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.色TableAdapter = new KaihatsuEnshuu.OI21Database1DataSetTableAdapters.色TableAdapter();
            this.サイズBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.サイズTableAdapter = new KaihatsuEnshuu.OI21Database1DataSetTableAdapters.サイズTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.色BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.サイズBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ProductNameMaskedTextBox);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Category);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.商品IDDataGridViewTextBoxColumn,
            this.カテゴリーIDDataGridViewTextBoxColumn,
            this.商品名DataGridViewTextBoxColumn,
            this.商品価格DataGridViewTextBoxColumn,
            this.商品説明DataGridViewTextBoxColumn,
            this.色可能DataGridViewTextBoxColumn,
            this.サイズ可能DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.商品BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1097, 580);
            this.dataGridView1.TabIndex = 0;
            // 
            // oI21Database1DataSet
            // 
            this.oI21Database1DataSet.DataSetName = "OI21Database1DataSet";
            this.oI21Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 商品BindingSource
            // 
            this.商品BindingSource.DataMember = "商品";
            this.商品BindingSource.DataSource = this.oI21Database1DataSet;
            // 
            // 商品TableAdapter
            // 
            this.商品TableAdapter.ClearBeforeFill = true;
            // 
            // 商品IDDataGridViewTextBoxColumn
            // 
            this.商品IDDataGridViewTextBoxColumn.DataPropertyName = "商品ID";
            this.商品IDDataGridViewTextBoxColumn.HeaderText = "商品ID";
            this.商品IDDataGridViewTextBoxColumn.Name = "商品IDDataGridViewTextBoxColumn";
            // 
            // カテゴリーIDDataGridViewTextBoxColumn
            // 
            this.カテゴリーIDDataGridViewTextBoxColumn.DataPropertyName = "カテゴリーID";
            this.カテゴリーIDDataGridViewTextBoxColumn.HeaderText = "カテゴリーID";
            this.カテゴリーIDDataGridViewTextBoxColumn.Name = "カテゴリーIDDataGridViewTextBoxColumn";
            // 
            // 商品名DataGridViewTextBoxColumn
            // 
            this.商品名DataGridViewTextBoxColumn.DataPropertyName = "商品名";
            this.商品名DataGridViewTextBoxColumn.HeaderText = "商品名";
            this.商品名DataGridViewTextBoxColumn.Name = "商品名DataGridViewTextBoxColumn";
            // 
            // 商品価格DataGridViewTextBoxColumn
            // 
            this.商品価格DataGridViewTextBoxColumn.DataPropertyName = "商品価格";
            this.商品価格DataGridViewTextBoxColumn.HeaderText = "商品価格";
            this.商品価格DataGridViewTextBoxColumn.Name = "商品価格DataGridViewTextBoxColumn";
            // 
            // 商品説明DataGridViewTextBoxColumn
            // 
            this.商品説明DataGridViewTextBoxColumn.DataPropertyName = "商品説明";
            this.商品説明DataGridViewTextBoxColumn.HeaderText = "商品説明";
            this.商品説明DataGridViewTextBoxColumn.Name = "商品説明DataGridViewTextBoxColumn";
            // 
            // 色可能DataGridViewTextBoxColumn
            // 
            this.色可能DataGridViewTextBoxColumn.DataPropertyName = "色可能";
            this.色可能DataGridViewTextBoxColumn.HeaderText = "色可能";
            this.色可能DataGridViewTextBoxColumn.Name = "色可能DataGridViewTextBoxColumn";
            // 
            // サイズ可能DataGridViewTextBoxColumn
            // 
            this.サイズ可能DataGridViewTextBoxColumn.DataPropertyName = "サイズ可能";
            this.サイズ可能DataGridViewTextBoxColumn.HeaderText = "サイズ可能";
            this.サイズ可能DataGridViewTextBoxColumn.Name = "サイズ可能DataGridViewTextBoxColumn";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(63, 38);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(70, 17);
            this.Category.TabIndex = 0;
            this.Category.Text = "カテゴリー";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "商品価格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "商品名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "商品説明";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "色";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(148, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 25);
            this.comboBox1.TabIndex = 5;
            // 
            // ProductNameMaskedTextBox
            // 
            this.ProductNameMaskedTextBox.Location = new System.Drawing.Point(148, 84);
            this.ProductNameMaskedTextBox.Name = "ProductNameMaskedTextBox";
            this.ProductNameMaskedTextBox.Size = new System.Drawing.Size(198, 24);
            this.ProductNameMaskedTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "サイズ";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(148, 125);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(198, 24);
            this.maskedTextBox1.TabIndex = 8;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(148, 156);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(198, 96);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.色BindingSource;
            this.comboBox2.DisplayMember = "色";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(148, 260);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(198, 25);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.ValueMember = "ID";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.サイズBindingSource;
            this.comboBox3.DisplayMember = "サイズ省略";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(148, 296);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(198, 25);
            this.comboBox3.TabIndex = 11;
            this.comboBox3.ValueMember = "サイズID";
            // 
            // 色BindingSource
            // 
            this.色BindingSource.DataMember = "色";
            this.色BindingSource.DataSource = this.oI21Database1DataSet;
            // 
            // 色TableAdapter
            // 
            this.色TableAdapter.ClearBeforeFill = true;
            // 
            // サイズBindingSource
            // 
            this.サイズBindingSource.DataMember = "サイズ";
            this.サイズBindingSource.DataSource = this.oI21Database1DataSet;
            // 
            // サイズTableAdapter
            // 
            this.サイズTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品BindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn カテゴリーIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品価格DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品説明DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 色可能DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn サイズ可能DataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox ProductNameMaskedTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.BindingSource 色BindingSource;
        private OI21Database1DataSetTableAdapters.色TableAdapter 色TableAdapter;
        private System.Windows.Forms.BindingSource サイズBindingSource;
        private OI21Database1DataSetTableAdapters.サイズTableAdapter サイズTableAdapter;
    }
}
