using Microsoft.EntityFrameworkCore;
using MiniInventorySystem.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiniInventorySystem.Services
{
    public class DesktopRepository : IDesktopRepository
    {
        private readonly MiniInventorySystemContext _context;

        public DesktopRepository(MiniInventorySystemContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Desktop>> GetDesktopsAsync()
        {
            return await _context.Desktops.ToListAsync();
        }

        public async Task<Desktop> GetDesktopAsync(Guid id)
        {
            return await _context.Desktops.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Desktop> AddDesktopAsync(Desktop desktopViewModel)
        {
            try
            {
                await _context.AddAsync(desktopViewModel);
                return desktopViewModel;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
