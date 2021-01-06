using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniInventorySystem.Models;

namespace MiniInventorySystem.Services
{
    public interface IComputerRepository
    {
        IEnumerable<Computer> GetComputers();
        Computer GetComputer(Guid computerId);
    }
}
