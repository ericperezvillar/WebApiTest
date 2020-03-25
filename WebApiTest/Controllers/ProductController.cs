using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public static Product[] products = new Product[]
        {
            new Product {Code = "014600301", Description = "BARILLA FARINA 1 KG", Um = "PZ", PcCart = 24, NetWeight = 1, Price = 1.09 },
            new Product {Code = "013500121", Description = "BARILLA PASTA GR.500 N.70 1/2 PENNE", Um = "PZ", PcCart = 30, NetWeight = 0.5, Price = 1.3 },
            new Product {Code = "007686402", Description = "FINDUS FIOR DI NASELLO 300 GR", Um = "PZ", PcCart = 8, NetWeight = 0.3, Price = 6.46 },
            new Product {Code = "057549001", Description = "FINDUS CROCCOLE 400 GR", Um = "PZ", PcCart = 12, NetWeight = 0.4, Price = 5.97 }
        };


        /// <summary>
        /// Get the full list of products
        /// </summary> 
        [SwaggerOperation("ListAllProducts")]
        [HttpGet]
        public IEnumerable<Product> ListAllProducts()
        {
            return products;
        }

        [HttpGet("code/{codart}")]
        public IEnumerable<Product> ListProductsByCode(string codart)
        {
            IEnumerable<Product> retVal =
               from g in products
               where g.Code.Equals(codart)
               select g;

            return retVal;
        }

        [HttpGet("description/{desart}")]
        public IEnumerable<Product> ListProductsByDescription(string desart)
        {
            IEnumerable<Product> retVal =
                from g in products
                where g.Description.ToUpper().Contains(desart.ToUpper())
                orderby g.Code
                select g;

            return retVal;

        }

        [HttpPost]
        public void AddProduct(Product product)
        {
            products.Append(product);
        }
    }
}
