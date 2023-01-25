using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1.Models
{
    public class Disk : Product
    {
        public string Capacity { get; set; }
        public string Speed { get; set; }

        public Disk(int id, string name, decimal price, string capacity, string speed)
            : base(id, name, price)
        {
            this.Capacity = capacity;
            this.Speed = speed;
        }
    }
}
