namespace KaihatsuEnshuu
{
    partial class Order
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
            this.商品名 = new System.Windows.Forms.Label();
            this.addproduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.cancelProduct = new System.Windows.Forms.Button();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productDescription = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // 商品名
            // 
            this.商品名.AutoSize = true;
            this.商品名.Location = new System.Drawing.Point(310, 25);
            this.商品名.Name = "商品名";
            this.商品名.Size = new System.Drawing.Size(52, 15);
            this.商品名.TabIndex = 0;
            this.商品名.Text = "商品名";
            this.商品名.Click += new System.EventHandler(this.Form1_Load);
            // 
            // addproduct
            // 
            this.addproduct.Location = new System.Drawing.Point(301, 434);
            this.addproduct.Name = "addproduct";
            this.addproduct.Size = new System.Drawing.Size(157, 64);
            this.addproduct.TabIndex = 1;
            this.addproduct.Text = "追加";
            this.addproduct.UseVisualStyleBackColor = true;
            this.addproduct.Click += new System.EventHandler(this.addproduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "商品価格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "カテゴリー";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "色";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "仕入先";
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(483, 25);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(220, 22);
            this.productName.TabIndex = 6;
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(483, 83);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(220, 22);
            this.productPrice.TabIndex = 7;
            // 
            // cancelProduct
            // 
            this.cancelProduct.Location = new System.Drawing.Point(546, 434);
            this.cancelProduct.Name = "cancelProduct";
            this.cancelProduct.Size = new System.Drawing.Size(157, 64);
            this.cancelProduct.TabIndex = 11;
            this.cancelProduct.Text = "キャンセル";
            this.cancelProduct.UseVisualStyleBackColor = true;
            this.cancelProduct.Click += new System.EventHandler(this.cancelProduct_Click);
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(483, 266);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(220, 23);
            this.supplierComboBox.TabIndex = 12;
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(483, 209);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(220, 23);
            this.colorComboBox.TabIndex = 13;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(483, 147);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(220, 23);
            this.categoryComboBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "商品説明";
            // 
            // productDescription
            // 
            this.productDescription.Location = new System.Drawing.Point(483, 313);
            this.productDescription.Name = "productDescription";
            this.productDescription.Size = new System.Drawing.Size(220, 96);
            this.productDescription.TabIndex = 17;
            this.productDescription.Text = "";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 562);
            this.Controls.Add(this.productDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.supplierComboBox);
            this.Controls.Add(this.cancelProduct);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addproduct);
            this.Controls.Add(this.商品名);
            this.Name = "Order";
            this.Text = "商品入力画面";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 商品名;
        private System.Windows.Forms.Button addproduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.Button cancelProduct;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox productDescription;
    }
}

