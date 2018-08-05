using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductTest.Data;
using ProductTest.DAL;

namespace ProductTest.BLL
{

    public class ProductTestBLL
    {
        public List<ProductTestData> SendToDal(ProductTestData product)
        {
            ProductTestDAL pd = new ProductTestDAL();
            return pd.InsertToDB(product);
        }

    }
}
