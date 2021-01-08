using MiniInventorySystem.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiniInventorySystem.Services
{
    public interface IDesktopRepository
    {
        Task<IEnumerable<Desktop>> GetDesktopsAsync();
        Task<Desktop> GetDesktopAsync(Guid id);
    }
}
