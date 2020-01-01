using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace online_market_api
{
    public class Product
    {
        public int id { get; set; }
        public string productImageUrl { get; set; }

        public decimal price { get; set; }

        public string productName { get; set; }
    }
}
