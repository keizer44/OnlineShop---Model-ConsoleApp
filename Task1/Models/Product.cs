using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Задача_1.Models
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } // Марка и Модел
        public decimal Price { get; set; }

        public Product(int id, string name, decimal price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Price}.lv";
        }
    }
}
