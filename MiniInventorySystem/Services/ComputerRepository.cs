using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniInventorySystem.Models;

namespace MiniInventorySystem.Services
{
    public class ComputerRepository : IComputerRepository
    {
        private readonly MiniInventorySystemContext _context;

        public ComputerRepository(MiniInventorySystemContext context)
        {
            _context = context;
        }
        public IEnumerable<Computer> GetComputers()
        {
            return _context.Computers;
        }

        public Computer GetComputer(Guid computerId)
        {
            return _context.Computers.FirstOrDefault(x => x.Id == computerId);
        }
    }
}
