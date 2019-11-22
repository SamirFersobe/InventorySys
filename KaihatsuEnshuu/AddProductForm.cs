using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KaihatsuEnshuu
{
    public partial class AddProductForm : template.Form1
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        String sqlQuery = "select * from products";
        private void AddProductForm_Load(object sender, EventArgs e)
        {

            

            try
            {

                reloadDataGridView(sqlQuery, dataGridView1);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "ProductError");
            }


            

                DataGridView dgv = dataGridView1;

                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel);

                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            string name;
            int  price;
            string brand;

            name = ProductNameMaskedTextBox.Text.ToString();
            price = Convert.ToInt32(productPrice.Text);
            brand = brandTextBox.Text.ToString();



            string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";
            OleDbConnection con = new OleDbConnection(str);
            con.Open();
            OleDbCommand cmmd = new OleDbCommand("INSERT INTO products(pName,pBrand,pPrice) Values(@Name,@Brand,@Price)", con);
            if(con.State == ConnectionState.Open)
            {
               cmmd.Parameters.AddWithValue("@Brand",brand );
               cmmd.Parameters.AddWithValue("@Name", name);
               cmmd.Parameters.AddWithValue("@Price", price);
               cmmd.ExecuteNonQuery();

                try
                {
                    
                    con.Close();
                }
                catch (OleDbException expe)
                {
                    MessageBox.Show(expe.Message);
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("CON FAILED");
            }


            
            reloadDataGridView(sqlQuery,dataGridView1);
           




        }


    }
    }


