using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniInventorySystem.Models;

namespace MiniInventorySystem.Services
{
    public class MockComputerRepository : IComputerRepository
    {
        private List<Computer> _computers;

        public MockComputerRepository()
        {
            if (_computers == null)
            {
                InitializeComputers();
            }
        }

        private void InitializeComputers()
        {
            _computers = new List<Computer>
            {
                new Computer
                {
                    Id = Guid.NewGuid()
                },
                new Computer
                {
                    Id = Guid.NewGuid()
                }
            };
        }

        public IEnumerable<Computer> GetComputers()
        {
            return _computers;
        }

        public Computer GetComputer(Guid computerId)
        {
            return _computers.FirstOrDefault(n => n.Id == computerId);
        }
    }
}
