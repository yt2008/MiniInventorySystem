using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniInventorySystem.Models;

namespace MiniInventorySystem.Services
{
    public class DesktopRepository : IDesktopRepository
    {
        private readonly MiniInventorySystemContext _context;

        public DesktopRepository(MiniInventorySystemContext context)
        {
            _context = context;
        }
        public IEnumerable<Desktop> GetDesktops()
        {
            return _context.Desktops;
        }

        public Desktop GetDesktop(Guid id)
        {
            return _context.Desktops.FirstOrDefault(x => x.Id == id);
        }
    }
}
