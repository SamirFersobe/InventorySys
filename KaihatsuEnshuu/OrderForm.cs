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
    public partial class OrderForm : template.Form1
    {
        string currentOrderString ;
        string currentOrderId;
        string currentProductID = "";
        Boolean sentorder = true;
        string genericProductQuery = "SELECT p.pid,b.BrandName as ブランド,c.categoryName as 種類 ,p.pName as 商品名, format(p.Pprice,'currency') as 値段 FROM (products p inner join brands b on (b.BrandId = p.brand))  inner join categories c on (c.CategoryId = p.categoryId) ";

        public OrderForm(string customerID , string employeeID, string orderId)
        {
            currentOrderId = orderId;
            
            InitializeComponent();

            try
            {
              
               
                reloadDataGridView(genericProductQuery, dataGridView1);
                this.dataGridView1.Columns["pid"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 1");
            }

            try
            {
                
                currentOrderString = "SELECT b.BrandName as ブランド, p.pName as 商品名,format(avg(p.Pprice),'currency') as 値段 ,sum(od.quantity) as 枚数 ,format(avg(p.Pprice) * sum(od.quantity),'currency') as 合計 FROM ((products p inner join brands b on (b.BrandId = p.brand))  inner join categories c on (c.CategoryId = p.categoryId)) inner join orderDetails od on (od.pid = p.pid) where od.orderId = "+ currentOrderId + "  group by od.pid ,b.brandName, p.pName order by 1";
                reloadDataGridView(currentOrderString, dataGridView2);
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 2");
            }

            // get the values for 
    

            FillComboBox("CategoryName", "CategoryId",CategoryComboBoxFilter , "Categories");
            FillComboBox("BrandName", "BrandID", BrandComboBoxFilter, "Brands");



        }

        private Boolean productSelectedNotNull(string pid)
        {
            if (pid != "")
                return true;
            else
                return false;
        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            if (productSelectedNotNull(currentProductID)) { 
            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            
            con.Open();//opening connection
            string currentItem = ProductName.Text.ToString();
            string sql = " select distinct ordercustomerId from [order] where Id = " + currentOrderId;
            cmd.CommandText = sql;
            string customerString = cmd.ExecuteScalar().ToString();

            string priceString = "select pprice from products where pid = " + currentProductID;
            cmd.CommandText = priceString;
            int price = Convert.ToInt32(cmd.ExecuteScalar());

            string sql2 = "INSERT INTO orderDetails(orderId,customerId,pId,quantity,pCurrentPrice) values (@orderId,@customerId,@pId,@quantity,@pCurrentPrice)";
            cmd.CommandText = sql2;


            
            try
            {


                cmd.Parameters.AddWithValue("@orderId", currentOrderId);
                cmd.Parameters.AddWithValue("@customerId", customerString);
                cmd.Parameters.AddWithValue("@pId", currentProductID);
                cmd.Parameters.AddWithValue("@quantity", textBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@pCurrentPrice", price);
                cmd.ExecuteNonQuery();
                MessageBox.Show("商品追加しました。");


            }
            catch(Exception ex)
            {
                MessageBox.Show("数字だけを入力してください。");
            }

            try
            {
                 BrandName.Clear();
                ProductName.Clear();
                currentProductID = "";
                textBox1.Clear();
                
               
                reloadDataGridView(currentOrderString, dataGridView2);
           

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 3");
            }
            }
            else
            {
                MessageBox.Show("商品を選んでください");
            }
        }

        private void CancelOrder_Click(object sender, EventArgs e)
        {
            DeleteLastOrder();
            sentorder = false;
            this.Close();

        }


        private void DeleteAllAddedItems()
        {
            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            con.Open();//opening connection
            string lastAddedId = "select id from [order]  order by orderdate desc ";  //getting values
            cmd.CommandText = lastAddedId;
            string orderString = cmd.ExecuteScalar().ToString();
            string cmdString = "DELETE * from orderdetails where orderid = " + orderString;
            cmd.CommandText = cmdString;
            try
            {
                cmd.ExecuteNonQuery();
                reloadDataGridView(currentOrderString, dataGridView2);
            }
            catch(Exception ex)
            {

            }
            MessageBox.Show("Items have been deleted");
            reloadDataGridView(currentOrderString,dataGridView2);
            
        }


        private void DeleteLastOrder()
        {

            DeleteAllAddedItems();
            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            con.Open();//opening connection
            string currentItem = ProductName.Text.ToString();
            string lastAddedId = "select id from [order]  order by orderdate desc ";  //getting values
            cmd.CommandText = lastAddedId;
            string orderString = cmd.ExecuteScalar().ToString();
            string cmdString = "DELETE * from [order] where id = " + orderString;
            cmd.CommandText = cmdString;
            cmd.ExecuteNonQuery();



            

            
        }

        private void ClearOrder_Click(object sender, EventArgs e)
        {
            DeleteAllAddedItems();
            
            
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("注文確認しました？", "注文確定注意", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SubmitOrder();
                sentorder = false;
                this.Close();
            }


        }

        private void SubmitOrder()
        {
            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            con.Open();//opening connection
            string currentItem = ProductName.Text.ToString();
            string lastAddedId = "select id from [order]  order by orderdate desc ";  //getting values
            cmd.CommandText = lastAddedId;
            string orderString = cmd.ExecuteScalar().ToString();

            //-1 Implies a YES and  0 is False
            string cmdString = "update [order] set orderrequest = -1 where id = " + orderString;
            cmd.CommandText = cmdString;
            cmd.ExecuteNonQuery();
        }

        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sentorder)
            {
                DialogResult dialogResult = MessageBox.Show("この注文を確定しますか？", "注文確認", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SubmitOrder();

                }
                else if (dialogResult == DialogResult.No)
                {
                    DeleteLastOrder();
                }
            }
        }

        private void ShowAllProducts_Click(object sender, EventArgs e)
        {
            try
            {

                string sql1 = "SELECT p.pid, b.BrandName as ブランド,c.categoryName as 種類,p.pName as 商品名,p.Pprice as 値段 FROM (products p inner join brands b on (b.BrandId = p.brand))  inner join categories c on (c.CategoryId = p.categoryId) order by 1";
                reloadDataGridView(sql1, dataGridView1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 1");
            }
        }





        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string pid = "";
            if (e.RowIndex == -1) return; //check if row index is not 
            if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                pid = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            currentProductID = pid;

            ProductName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            BrandName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            
     
        }

        private void filterButton_Click_1(object sender, EventArgs e)
        {
            string currentBrand = BrandComboBoxFilter.SelectedValue.ToString();
            
            string currentCategory = CategoryComboBoxFilter.SelectedValue.ToString();

            string sqlFilterQuery = genericProductQuery;
            Boolean sentenceStartedFlag = false;

            if (brandFilterCheckBox.Checked)
            {
                sqlFilterQuery = sqlFilterQuery + " where p.brand = " + currentBrand;
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
                    sqlFilterQuery = sqlFilterQuery + " where p.categoryId = " + currentCategory;
                    sentenceStartedFlag = true;
                }

            }


            reloadDataGridView(sqlFilterQuery, dataGridView1);
        }
    }

   


}
