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

        public DbSet<Computer> Computers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Computer>().HasData(new Computer
            {
                Id = Guid.NewGuid(),
                Brand = "Dell",
                FromFactor = "",
                Processor = "i7",
                Quantity = 10,
                RamSlots = 4,
                UsbPorts = 3
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
