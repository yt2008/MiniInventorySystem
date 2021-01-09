using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniInventorySystem.Interfaces
{
    public interface IHasBattery
    {
        public decimal BatteryCapacity { get; set; }
    }
}
