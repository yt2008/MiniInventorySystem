using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MiniInventorySystem.Models
{
    public class MiniInventorySystemContext : DbContext
    {
        public MiniInventorySystemContext(DbContextOptions<MiniInventorySystemContext> options) : base(options)
        {

        }

        public DbSet<Desktop> Desktops { get; set; }
        public DbSet<Laptop> Laptops { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Desktop>().HasData(new Desktop
            {
                Id = Guid.NewGuid(),
                Brand = "Dell",
                Processor = "i7",
                Quantity = 10,
                RamSlots = 4,
                UsbPorts = 3
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
