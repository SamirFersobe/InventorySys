namespace KaihatsuEnshuu
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddProductButton = new System.Windows.Forms.Button();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openStock = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(40, 236);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(213, 126);
            this.AddProductButton.TabIndex = 0;
            this.AddProductButton.Text = "商品登録";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.openProductForm_Click);
            // 
            // AddClientButton
            // 
            this.AddClientButton.Location = new System.Drawing.Point(515, 235);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(222, 127);
            this.AddClientButton.TabIndex = 1;
            this.AddClientButton.Text = "顧客登録";
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.addStock_Click);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(270, 236);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(222, 126);
            this.AddEmployeeButton.TabIndex = 2;
            this.AddEmployeeButton.Text = "社員登録";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployee_Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 110);
            this.button1.TabIndex = 5;
            this.button1.Text = "物流担当者";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openStock
            // 
            this.openStock.Location = new System.Drawing.Point(270, 37);
            this.openStock.Name = "openStock";
            this.openStock.Size = new System.Drawing.Size(222, 110);
            this.openStock.TabIndex = 6;
            this.openStock.Text = "ストック表";
            this.openStock.UseVisualStyleBackColor = true;
            this.openStock.Click += new System.EventHandler(this.openStock_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(515, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 110);
            this.button2.TabIndex = 7;
            this.button2.Text = "注文";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.openStock);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.AddClientButton);
            this.Controls.Add(this.AddProductButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "メイン画面";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button AddClientButton;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button openStock;
        private System.Windows.Forms.Button button2;
    }
}