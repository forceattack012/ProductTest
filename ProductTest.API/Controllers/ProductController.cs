using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductTest.Data;
using ProductTest.BLL;

namespace ProductTest.API.Controllers
{
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController
    {
        [HttpPost,Route("GetData")]
        public IHttpActionResult GetData(ProductTestData product)
        {
            ProductTestBLL pb = new ProductTestBLL();
<<<<<<< HEAD
            pb.SendToDal(product);
            return Ok(product);
=======
            return Ok(pb.SendToDal(product));
>>>>>>> master
        }
    }
}
