using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniInventorySystem.Models
{
    public class Computer
    {
        public Guid Id { get; set; }
        public string Processor { get; set; }
        public string Brand { get; set; }
        public int UsbPorts { get; set; }
        public int RamSlots { get; set; }
        public string FromFactor { get; set; }
        public int Quantity { get; set; }

    }
}
