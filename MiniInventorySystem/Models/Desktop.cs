using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniInventorySystem.Models
{
    public class Desktop : Computer
    {
        public int UsbPorts { get; set; }
        public int RamSlots { get; set; }
        public string FormFactor { get; set; }
    }
}
