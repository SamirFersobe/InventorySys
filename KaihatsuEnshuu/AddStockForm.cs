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
    public partial class AddStockForm : template.Form1
    {
        string sqlqueryRestocking;
        int restockingOrder;
        int shopIDGlobal;
        string sqlQueryProducts = "select pname as 商品名,pbrand as ブランド, restockingPRice as 仕入価格 from products";


        private void RequiredStockForAllOrders(List<MyData> stockItems)
        {
            string orderDetailsQuery = " select pid, sum(quantity) from orderDetails group by pid";


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

            sqlqueryRestocking = "select p.pbrand as ブランド,p.pname as 商品名,sum(r.quantity) as 数, avg(p.restockingPrice) as 価格 ,sum(p.restockingPrice) as 合計 from restockingDetails r inner join products p on (p.pid = r.productID) where restockingid = " + restockingId.ToString() +" group by p.pbrand,p.pid ,p.pname";
            restockingOrder = restockingId;


            reloadDataGridView(sqlqueryRestocking, dataGridView1);
            reloadDataGridView(sqlQueryProducts, dataGridView2);
            FillComboBox("pName", "pId", comboBox1, "products");
        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
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
                cmd.Parameters.AddWithValue("@productID", comboBox1.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@quantity", textBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@shop_id", shopIDGlobal);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Item added to list");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            reloadDataGridView(sqlqueryRestocking, dataGridView1);
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




            MessageBox.Show("The required items have been added to the order");

            reloadDataGridView(sqlqueryRestocking, dataGridView1);
            reloadDataGridView(sqlQueryProducts, dataGridView2);
        }
    }
}
