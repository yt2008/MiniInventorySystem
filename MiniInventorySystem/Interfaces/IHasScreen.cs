using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniInventorySystem.Interfaces
{
    public interface IHasScreen
    {
        public decimal ScreenSize { get; set; }
        public decimal BatterySize { get; set; }
    }
}
