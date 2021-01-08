using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniInventorySystem.Models
{
    public abstract class Computer
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Processor { get; set; }
        public string Brand { get; set; }
        public int UsbPorts { get; set; }
        public int RamSlots { get; set; }
        public int Quantity { get; set; }
    }
}
