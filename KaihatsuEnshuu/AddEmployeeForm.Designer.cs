namespace KaihatsuEnshuu
{
	partial class AddEmployeeForm
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
			if(disposing && (components != null))
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
            this.社員ファイルBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.oI21Database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oI21Database1DataSet = new KaihatsuEnshuu.OI21Database1DataSet();
            this.社員ファイルBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.社員ファイルTableAdapter = new KaihatsuEnshuu.OI21Database1DataSetTableAdapters.社員ファイルTableAdapter();
            this.社員名 = new System.Windows.Forms.Label();
            this.入社日 = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.TextBox();
            this.hiredate = new System.Windows.Forms.DateTimePicker();
            this.addEmployee = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.社員ファイルBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.社員ファイルBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addEmployee);
            this.groupBox1.Controls.Add(this.hiredate);
            this.groupBox1.Controls.Add(this.employeeName);
            this.groupBox1.Controls.Add(this.入社日);
            this.groupBox1.Controls.Add(this.社員名);
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
            // 社員ファイルBindingSource1
            // 
            this.社員ファイルBindingSource1.DataMember = "社員ファイル";
            this.社員ファイルBindingSource1.DataSource = this.oI21Database1DataSetBindingSource;
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
            // 社員ファイルBindingSource
            // 
            this.社員ファイルBindingSource.DataMember = "社員ファイル";
            this.社員ファイルBindingSource.DataSource = this.oI21Database1DataSetBindingSource;
            // 
            // 社員ファイルTableAdapter
            // 
            this.社員ファイルTableAdapter.ClearBeforeFill = true;
            // 
            // 社員名
            // 
            this.社員名.AutoSize = true;
            this.社員名.Location = new System.Drawing.Point(33, 57);
            this.社員名.Name = "社員名";
            this.社員名.Size = new System.Drawing.Size(59, 17);
            this.社員名.TabIndex = 1;
            this.社員名.Text = "社員名";
            // 
            // 入社日
            // 
            this.入社日.AutoSize = true;
            this.入社日.Location = new System.Drawing.Point(33, 98);
            this.入社日.Name = "入社日";
            this.入社日.Size = new System.Drawing.Size(59, 17);
            this.入社日.TabIndex = 2;
            this.入社日.Text = "入社日";
            // 
            // employeeName
            // 
            this.employeeName.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.社員ファイルBindingSource, "社員名", true));
            this.employeeName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.社員ファイルBindingSource, "社員名", true));
            this.employeeName.Location = new System.Drawing.Point(132, 50);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(194, 24);
            this.employeeName.TabIndex = 5;
            // 
            // hiredate
            // 
            this.hiredate.Location = new System.Drawing.Point(132, 98);
            this.hiredate.Name = "hiredate";
            this.hiredate.Size = new System.Drawing.Size(194, 24);
            this.hiredate.TabIndex = 8;
            // 
            // addEmployee
            // 
            this.addEmployee.Location = new System.Drawing.Point(79, 153);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(191, 36);
            this.addEmployee.TabIndex = 9;
            this.addEmployee.Text = "Add Employee";
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1506, 757);
            this.Name = "AddEmployeeForm";
            this.Text = "社員";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.社員ファイルBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.社員ファイルBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource oI21Database1DataSetBindingSource;
        private OI21Database1DataSet oI21Database1DataSet;
        private System.Windows.Forms.BindingSource 社員ファイルBindingSource;
        private OI21Database1DataSetTableAdapters.社員ファイルTableAdapter 社員ファイルTableAdapter;
        private System.Windows.Forms.Label 入社日;
        private System.Windows.Forms.Label 社員名;
        private System.Windows.Forms.TextBox employeeName;
        private System.Windows.Forms.BindingSource 社員ファイルBindingSource1;
        private System.Windows.Forms.DateTimePicker hiredate;
        private System.Windows.Forms.Button addEmployee;
    }
}
