using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1.Models
{
    public class Order
    {
        public List<Product> Products { get; set; }

        public Order()
        {
            this.Products = new List<Product>();
        }
    }
}
