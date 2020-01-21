using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace KaihatsuEnshuu
{
    public partial class AddStockForm : template.Form1
    {
        string currentProductId;
        string sqlqueryRestocking;
        int restockingOrder;
        int shopIDGlobal;
        string sqlQueryProducts = "SELECT p.pid as productId,b.BrandName as ブランド,c.categoryName as 種類 ,p.pName as 商品名,p.restockingPrice as 入荷価格 FROM (products p inner join brands b on (b.BrandId = p.brand))  inner join categories c on (c.CategoryId = p.categoryId) ";


        private void RequiredStockForAllOrders(List<MyData> stockItems)
        {
            string orderDetailsQuery = " select od.pid, sum(od.quantity) from orderDetails od inner join [order] o on(od.orderId = o.Id)  where o.orderRequest = -1 and o.orderApproved = 0 and  o.orderCanceled = 0 group by od.pid";


            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            var OrderItems = new List<MyData>();

            using (con)
            {
                cmd.CommandText = orderDetailsQuery;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var item = new MyData()
                        {
                            productId = Convert.ToInt32(dr[0]),
                            productQuantity = Convert.ToInt32(dr[1])
                        };

                        OrderItems.Add(item);
                    };


                    foreach (var item1 in OrderItems)
                    {
                        var item2 = new MyData()
                        { 
                        productId = item1.productId,
                        productQuantity = ParticularProductStockRequiredQuantity(item1.productId, item1.productQuantity)

                        
                        };
                        if (item2.productQuantity != 0)
                        {
                            

                            stockItems.Add(item2);
                        }
                    };


                }


            }

        }


        private int ParticularProductStockRequiredQuantity(int pid, int requiredQuantity)
        {

            string sqlQueryToCheckAvailability = "select sum(quantity) from stock where productID = " + Convert.ToString(pid) + " group by productID";
            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlQueryToCheckAvailability;
            int stockQuantity = Convert.ToInt32(cmd.ExecuteScalar());

            if (stockQuantity >= requiredQuantity)
            {
                return 0;
            }
            else
            {
                return requiredQuantity - stockQuantity;
            }
        }
        public AddStockForm(int shopid, int restockingId)
        {
            InitializeComponent();
            shopIDGlobal = shopid;

            //sqlqueryRestocking = "select p.brand as ブランド,p.pname as 商品名,sum(r.quantity) as 数, p.restockingPrice as 価格  from restockingDetails r inner join products p on (p.pid = r.productID) where restockingid = " + restockingId.ToString() +" group by p.brand,p.pid ,p.pname";
            sqlqueryRestocking = "SELECT b.BrandName as ブランド, p.pName as 商品名,format(avg(p.restockingprice),'currency') as 入荷価格 ,sum(r.quantity) as 枚数, format(avg(p.restockingprice) * sum(r.quantity),'currency') as 合計  FROM ((products p inner join brands b on (b.BrandId = p.brand))  inner join categories c on (c.CategoryId = p.categoryId)) inner join restockingDetails r on (r.productid = p.pid) where r.restockingId = " + restockingId.ToString() + "  group by r.productid ,b.brandName, p.pName ";
            restockingOrder = restockingId;

            FillComboBox("CategoryName", "CategoryId", categoryComboBox, "Categories");
            FillComboBox("BrandName", "BrandID", brandComboBox, "Brands");
            reloadDataGridView(sqlqueryRestocking, dataGridView1);
            reloadDataGridView(sqlQueryProducts, dataGridView2);
            this.dataGridView2.Columns["productId"].Visible = false;



        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            if(currentProductId != null) { 
            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            con.Open();//opening connection
            string sql2 = "INSERT INTO restockingDetails(RestockingID,ProductID,Quantity,Shop_ID) values (@restockingID,@productID,@quantity,@shop_id)";
            cmd.CommandText = sql2;


            try
            {

                cmd.Parameters.AddWithValue("@restockingID", restockingOrder);
                cmd.Parameters.AddWithValue("@productID", currentProductId);
                cmd.Parameters.AddWithValue("@quantity", quantityTextBox.Text.ToString());
                cmd.Parameters.AddWithValue("@shop_id", shopIDGlobal);
                cmd.ExecuteNonQuery();
                MessageBox.Show("商品追加しました。");
               //     Thread.Sleep(200);


            }
            catch (Exception ex)
            {
                MessageBox.Show("枚数を入力してください");
            }

            
            reloadDataGridView(sqlqueryRestocking, dataGridView1);

            quantityTextBox.Clear();
            productName.Clear();
            brandTextBox.Clear();
            currentProductId = null;
            }
            else
            {
                MessageBox.Show("商品を選んでください");
            }
        }

        private int ProductandShopInStock(int productID,int shopID)
        {
            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandType = CommandType.Text;

          string productIdString =  productID.ToString();
          string  shopIdString = shopID.ToString();
          string productandShopQuery = "select quantity from stock where productid = " + productIdString + " and shop_id = " + shopIdString;

            cmd.CommandText = productandShopQuery;
            object productShopExists = cmd.ExecuteScalar();

            if(productShopExists == null)
            {
                //object doesnt exist
                return -1;
            }
            return Convert.ToInt32(productShopExists);



            
        }
  
        private void SubmitRestock_Click(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            con.Open();//opening connection

            string sqlQuery = "select productID, sum(quantity) from RestockingDetails where restockingID =  " + restockingOrder.ToString() + " group by productid";
            string sqlInsertQuery;
            var items = new List<MyData>();

            using (con)
            {
                cmd.CommandText = sqlQuery;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var item = new MyData()
                        {
                            productId = Convert.ToInt32(dr[0]),
                            productQuantity = Convert.ToInt32(dr[1])
                        };

                        items.Add(item);
                    };
                }


                foreach (var item1 in items)
                {
                    if (ProductandShopInStock(item1.productId, shopIDGlobal) == -1)
                    {
                        //if value is -1 then do the insert stament because it doesnt exist
                        sqlInsertQuery = "insert into stock(ProductID,Quantity,Shop_ID) values (@productID,@quantity,@shop_id)";
                        cmd.Parameters.Clear();
                        cmd.CommandText = sqlInsertQuery;
                        cmd.Parameters.AddWithValue("@productID", item1.productId);
                        cmd.Parameters.AddWithValue("@quantity", item1.productQuantity);
                        cmd.Parameters.AddWithValue("@shop_id", shopIDGlobal);
                        
                        cmd.ExecuteNonQuery();
                    }
                    else//if it exists then it is a value between 0 + 2^32 
                    {
                        int quantity = item1.productQuantity + ProductandShopInStock(item1.productId, shopIDGlobal);
                        cmd.Parameters.Clear();
                        sqlInsertQuery = "update stock set quantity = " + quantity.ToString() + "  where productid= " + item1.productId.ToString() + " and shop_id = " + shopIDGlobal.ToString();
                        cmd.CommandText = sqlInsertQuery;
                        cmd.ExecuteNonQuery();

                    }

                }

                this.Close();


            }
        }

        private void AddAllRequiredItems_Click(object sender, EventArgs e)
        {
            var stockItems = new List<MyData>();
            RequiredStockForAllOrders(stockItems);

            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            con.Open();

            string sql2 = "INSERT INTO restockingDetails(RestockingID,ProductID,Quantity,Shop_ID) values (@restockingID,@productID,@quantity,@shop_id)";
            cmd.CommandText = sql2;


            int i = 0;

            while (i < stockItems.Count)
            {
                try
                {
                   
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@restockingID", restockingOrder);
                    cmd.Parameters.AddWithValue("@productID", stockItems[i].productId);
                    cmd.Parameters.AddWithValue("@quantity", stockItems[i].productQuantity);
                    cmd.Parameters.AddWithValue("@shop_id", shopIDGlobal);
                    cmd.ExecuteNonQuery();
                    


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }


                i = i + 1;
            }

            con.Close();




            MessageBox.Show("必要な商品を追加しました！");

            reloadDataGridView(sqlqueryRestocking, dataGridView1);
            reloadDataGridView(sqlQueryProducts, dataGridView2);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string pid = "";
            if (e.RowIndex == -1) return; //check if row index is not 
            if (dataGridView2.CurrentCell != null && dataGridView2.CurrentCell.Value != null)
                pid = dataGridView2.CurrentRow.Cells[0].Value.ToString();

            currentProductId = pid;

            productName.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();

            brandTextBox.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();


        }

        private void Filter_Click(object sender, EventArgs e)
        {
            string currentBrand = brandComboBox.SelectedValue.ToString();
            string currentCategory = categoryComboBox.SelectedValue.ToString();
            
            string sqlFilterQuery = sqlQueryProducts;
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


            reloadDataGridView(sqlFilterQuery, dataGridView2);
        }

        private void ClearOrder_Click(object sender, EventArgs e)
        {
            Boolean done = false;
            DialogResult dialogResult = MessageBox.Show("入荷をクリアしますか?", "クリア", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                con.Open();

                string deleteAllSql = "delete * from restockingdetails where restockingId = " + restockingOrder.ToString();

                cmd.CommandText = deleteAllSql;
                cmd.ExecuteNonQuery();
                done = true;
                reloadDataGridView(sqlqueryRestocking, dataGridView1);
                reloadDataGridView(sqlQueryProducts, dataGridView2);
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }


            if (done)
            {
                MessageBox.Show("クリアしました！");

            }
            reloadDataGridView(sqlqueryRestocking, dataGridView1);
            reloadDataGridView(sqlQueryProducts, dataGridView2);


        }

        private void CancelOrder_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("入荷をキャンセルますか?", "キャンセル", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                con.Open();

                string deleteAllSql = "delete * from restockingdetails where restockingId = " + restockingOrder.ToString();

                cmd.CommandText = deleteAllSql;
                cmd.ExecuteNonQuery();

                string deleterestockingOrder = "delete * from restocking where restockingID = " + restockingOrder.ToString();
                cmd.CommandText = deleterestockingOrder;
                cmd.ExecuteNonQuery();

                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
