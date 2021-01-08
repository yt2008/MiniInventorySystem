using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniInventorySystem.Interfaces;

namespace MiniInventorySystem.Models
{
    public class Laptop : Computer, IHasScreen
    {
        public string FromFactor { get; set; }
        public decimal ScreenSize { get; set; }
        public decimal BatterySize { get; set; }
    }
}
