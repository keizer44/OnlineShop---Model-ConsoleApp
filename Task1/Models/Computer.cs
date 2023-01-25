using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1.Models
{
    public class Computer : Product
    {
        public Processor Processor { get; set; }
        public MemoryCard MemoryCard { get; set; }
        public Disk HardDisk { get; set; }
        public VideoCard VideoCard { get; set; }

        public Computer(int id, string name, decimal price, Processor processor, MemoryCard memoryCard, Disk hardDisk, VideoCard videoCard)
            : base(id, name, price)
        {
            this.Processor = processor;
            this.MemoryCard = memoryCard;
            this.HardDisk = hardDisk;
            this.VideoCard = videoCard;
        }
    }
}
