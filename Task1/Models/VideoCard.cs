using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Задача_1.Models
{
    public class VideoCard : Product
    {
        public int MemoryCapacity { get; set; } //6GB
        public string MemoryType { get; set; } // DDR5

        public VideoCard(int id, string name, decimal price, int memoryCapcity, string memoryType)
            : base(id, name, price)
        {
            this.MemoryCapacity = memoryCapcity;
            this.MemoryType = memoryType;
        }
    }
}
