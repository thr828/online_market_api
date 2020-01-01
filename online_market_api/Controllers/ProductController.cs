using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace online_market_api.Controllers
{
    [EnableCors("any")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            List<Product> list = new List<Product>();
            Product p = new Product()
            {
                id = 1,
                productImageUrl = "/static/productImg/product1.jpg",
                price = 5899.99M,
                productName= "笔记本电脑"
            };
            list.Add(p);
            Product p1 = new Product()
            {
                id = 1,
                productImageUrl = "/static/productImg/product2.jpg",
                price = 5899.99M,
                productName = "笔记本电脑2"
            };
            list.Add(p1);
            Product p2 = new Product()
            {
                id = 1,
                productImageUrl = "/static/productImg/product3.jpg",
                price = 5899.99M,
                productName = "笔记本电脑3"
            };
            list.Add(p2);
            return list.ToArray();
        }
    }
}