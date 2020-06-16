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
        List<Product> list = new List<Product>()
        {
            new Product()
            {
                id = 1,
                productImageUrl = "/static/productImg/product1.jpg",
                price = 5899.99M,
                productName = "笔记本电脑"
            },
            new Product()
            {
                id = 2,
                productImageUrl = "/static/productImg/product2.jpg",
                price = 5899.99M,
                productName = "笔记本电脑2"
            },
            new Product()
            {
                id = 3,
                productImageUrl = "/static/productImg/product3.jpg",
                price = 5899.99M,
                productName = "笔记本电脑3"
            }

        };

        [HttpGet]
        public IEnumerable<Product> Get()
        {
         
            return list.ToArray();
        }
        /// <summary>
        /// 待参数的get(http://localhost:5676/api/product/3)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return list.Find(p => p.id == id);
        }
        /// <summary>
        /// 请求 http://localhost:5676/api/product/3,4 ，符合restful
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        [HttpGet("{productId},{count}")]
        public int Get(int productId, int count)
        {
            return productId+count;
        }

        
    }
}