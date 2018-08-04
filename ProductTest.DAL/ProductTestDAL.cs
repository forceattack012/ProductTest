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
        public bool InsertToDB(ProductTestData product)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=ProductTable ; Database=Product ; Trusted_Connection=true";
            

            SqlCommand command = new SqlCommand("select * from Product", conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.Write("{0} \t {1} \t {2} \t", reader[0], reader[1], reader[2]);
            }
            return true;
        }
    }
}
