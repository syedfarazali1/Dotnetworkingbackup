using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Order_product
    {
        public ORDERS GetORDERS { get; set; }

        public ICollection<Product> GetProducts { get; set; }
    }
}