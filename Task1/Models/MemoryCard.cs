using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Задача_1.Models
{
    public class MemoryCard : Product
    {
        public int MemoryCapacity { get; set; }
        public string MemoryType { get; set; }

        public MemoryCard(int id, string name, decimal price, int memoryCapcity, string memoryType)
            : base(id, name, price)
        {
            this.MemoryCapacity = memoryCapcity;
            this.MemoryType = memoryType;
        }
    }
}
