using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1.Models
{
    public class Processor : Product
    {
        public int Cores { get; set; }

        public Processor(int id, string name, decimal price, int cores)
            : base(id, name, price)
        {
            this.Cores = cores;
        }
    }
}
