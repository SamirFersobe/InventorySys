using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Linq;
using System.Threading;

namespace KaihatsuEnshuu
{
    public partial class StockForm : template.Form1
    {
       // string genericStockQuery  = "SELECT s.shop_id, s.productId,b.BrandName as ブランド,c.categoryName as 種類 ,p.pName as 商品名,　s.quantity as 枚数,p.Pprice as 値段 FROM ((products p inner join brands b on (b.BrandId = p.brand))  inner join categories c on (c.CategoryId = p.categoryId)) inner join stock s on (s.productId = p.pid) where s.quantity > 0";
        //string sqlQueryStock = "select p.pname as 商品名, p.brand as ブランド, s.quantity as 数,s.shop_id  as 店 from (stock s inner join products p on (s.productID = p.pid)) inner join brands b on (b.brandid = p.brand) where s.quantity > 0 order by 1,2 ";
        string sqlQueryStock = "SELECT s.shop_Id ,s.productId,b.BrandName as ブランド,c.categoryName as 種類 ,p.pName as 商品名,s.quantity as 枚数,p.Pprice as 値段 FROM ((products p inner join brands b on (b.BrandId = p.brand))  inner join categories c on (c.CategoryId = p.categoryId)) inner join stock s on (s.productId = p.pid) where s.quantity > 0";
        Boolean ShopGrouping ;
        string dgvShopId = "";
        string sqlQueryShops = "select distinct shop_id as Shops from stock";

        public StockForm()
        {
            InitializeComponent();
            

            try
            {
              
                reloadDataGridView(sqlQueryStock, dataGridView1);
                
              
                FillComboBox("CategoryName", "CategoryId", categoryComboBox, "Categories");
                FillComboBox("BrandName", "BrandID", brandComboBox, "Brands");
                stockIdComboBox.SelectedIndex = 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "ProductError");

            }


        }

        private void AddStock_Click(object sender, EventArgs e)
        {
            int shopid = Convert.ToInt32(stockIdComboBox.Text);

            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO restocking(RestockingDate,ShopID) values(date(),@shopID)";
            cmd.Parameters.AddWithValue("@shopID", shopid);
            con.Open();
            cmd.ExecuteNonQuery();
            

            string lastAddedId = "select @@identity ";
            cmd.CommandText = lastAddedId;
            

            object result = cmd.ExecuteScalar();
            result = (result == DBNull.Value) ? null : result;
            int restockingID = Convert.ToInt32(result);

            AddStockForm newAddStockForm = new AddStockForm(shopid, restockingID);

            
            newAddStockForm.FormClosing += new FormClosingEventHandler(this.Form2_FormClosing); //links the 2 forms together so if one closes it does something
            newAddStockForm.Show();
            

        }



        private void Form2_FormClosing(object sender, FormClosingEventArgs e)//this is what it does
        {

            //check if form closed and if then executes this code
           
            try
            {
                reloadDataGridView(sqlQueryStock, dataGridView1);
                Thread.Sleep(700);
                displayAllButton.PerformClick();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "ProductError");

            }

        }





        private void FilterButton_Click(object sender, EventArgs e)
        {
            string currentBrand = brandComboBox.SelectedValue.ToString();
            string currentCategory = categoryComboBox.SelectedValue.ToString();
            string currentShopId = stockIdComboBox.SelectedItem.ToString();
            string sqlFilterQuery = sqlQueryStock;
            Boolean sentenceStartedFlag = false;

            if (AddShopsCheckBox.Checked)
            {
                string sqlInitialQuery = "SELECT c.categoryName, b.brandName,s.productId,p.pname, sum(s.quantity) as 枚数 FROM ((products p inner join brands b on (b.BrandId = p.brand))  inner join categories c on (c.CategoryId = p.categoryId)) inner join stock s on (s.productId = p.pid)  "  ;
                string sqlGroupByQUery = " group by c.categoryName,b.brandName,p.pname,s.productId having sum(s.quantity) > 0";
                sqlFilterQuery = "";

                if (brandFilterCheckBox.Checked)
                {
                    sqlFilterQuery =  " where p.brand = " + currentBrand ;
                    sentenceStartedFlag = true;
                }

                if (categoryFilterCheckBox.Checked)
                {
                    if (sentenceStartedFlag)
                    {
                        sqlFilterQuery = sqlFilterQuery + " and p.categoryId = " + currentCategory ;

                    }
                    else
                    {
                        sqlFilterQuery = sqlFilterQuery + " where p.categoryId = " + currentCategory;
                        sentenceStartedFlag = true;
                    }

                }

                if (shopFilterCheckBox.Checked)
                {
                    if (sentenceStartedFlag)
                    {
                        sqlFilterQuery = sqlFilterQuery + " and s.shop_id = " + currentShopId;
                    }
                    else
                    {
                        sqlFilterQuery = sqlFilterQuery + " where s.shop_id = " + currentShopId;
                    }
                }

                sqlFilterQuery = sqlInitialQuery + sqlFilterQuery + sqlGroupByQUery;


            }
            else
            {

                if (brandFilterCheckBox.Checked)
                {
                    sqlFilterQuery = sqlFilterQuery + " and p.brand = " + currentBrand;
                    sentenceStartedFlag = true;
                }

                if (categoryFilterCheckBox.Checked)
                {
                    if (sentenceStartedFlag)
                    {
                        sqlFilterQuery = sqlFilterQuery + " and p.categoryId = " + currentCategory;

                    }
                    else
                    {
                        sqlFilterQuery = sqlFilterQuery + " and p.categoryId = " + currentCategory;
                        sentenceStartedFlag = true;
                    }

                }

                if (shopFilterCheckBox.Checked)
                {
                    if (sentenceStartedFlag)
                    {
                        sqlFilterQuery = sqlFilterQuery + " and s.shop_id = " + currentShopId;
                    }
                    else
                    {
                        sqlFilterQuery = sqlFilterQuery + " and s.shop_id = " + currentShopId;
                    }
                }

            }



           
            

            reloadDataGridView(sqlFilterQuery, dataGridView1);

        }

        private void displayAllButton_Click(object sender, EventArgs e)
        {

            reloadDataGridView(sqlQueryStock, dataGridView1);
            ShopGrouping = false;
        }

        private void allTogetherButton_Click(object sender, EventArgs e)
        {
            string sqlQueryFilter = "SELECT c.categoryName, b.brandName,s.productId,p.pname, sum(s.quantity) as 枚数 FROM ((products p inner join brands b on (b.BrandId = p.brand))  inner join categories c on (c.CategoryId = p.categoryId)) inner join stock s on (s.productId = p.pid)  group by c.categoryName,b.brandName,p.pname,s.productId having sum(s.quantity) > 0";
            reloadDataGridView(sqlQueryFilter, dataGridView1);
            ShopGrouping = true;

        }
    }

}
