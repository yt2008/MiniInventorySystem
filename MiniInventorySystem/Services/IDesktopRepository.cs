using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniInventorySystem.Models;

namespace MiniInventorySystem.Services
{
    public interface IDesktopRepository
    {
        IEnumerable<Desktop> GetDesktops();
        Desktop GetDesktop(Guid id);
    }
}
