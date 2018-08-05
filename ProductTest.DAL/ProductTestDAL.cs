using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProductTest.Data;


namespace ProductTest.DAL
{
    public class ProductTestDAL
    {
        public List<ProductTestData> InsertToDB(ProductTestData product)
        {
            List<ProductTestData> products = new List<ProductTestData>();
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Server=4X\\SQLEXPRESS;Database=ProductTest;Trusted_Connection=True";
                conn.Open();

                string insetProduct = "INSERT INTO Product VALUES(@ProductID,@ProductName,@ProductPrice)";

                SqlCommand cmd = new SqlCommand(insetProduct, conn);
                cmd.Parameters.Add(new SqlParameter("ProductID", product.ProductID));
                cmd.Parameters.Add(new SqlParameter("ProductName", product.ProductName));
                cmd.Parameters.Add(new SqlParameter("ProductPrice", product.ProductPrice));
                cmd.ExecuteNonQuery();

                string showInsert = "select * from Product where ProductID =" + product.ProductID;
                cmd = new SqlCommand(showInsert, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    products.Add(new ProductTestData
                    {
                        ProductID = reader.GetString(0),
                        ProductName = reader.GetString(1),
                        ProductPrice = reader.GetDouble(2)
                    });
                }

            }catch(Exception e)
            {
                Console.Write(e.ToString());
            }







            /*string strConn = "Server=4X\\SQLEXPRESS;Database=ProductTest;Trusted_Connection=True";
            SqlConnection conn = new SqlConnection();

            List<ProductTestData> products = new List<ProductTestData>();
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from Product", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    products.Add(new ProductTestData
                    {
                        ProductID = reader.GetString(0),
                        ProductName = reader.GetString(1),
                        ProductPrice = reader.GetDouble(2)
                    });
                }
            }catch(Exception e)
            {
                Console.Write(e.ToString());
            }*/


            /* SqlDataReader reader = command.ExecuteReader();
             ProductTestData data = new ProductTestData();
             while (reader.Read())
             {

                 data.ProductID = reader[0].ToString();
                 data.ProductName = reader[1].ToString();
                 data.ProductPrice = double.Parse(reader[2].ToString());
             }*/

            return products;
        }
    }
}
