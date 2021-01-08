using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniInventorySystem.Services;

namespace MiniInventorySystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComputersController : ControllerBase
    {
        private IDesktopRepository _desktopRepository;

        public ComputersController(IDesktopRepository desktopRepository)
        {
            _desktopRepository = desktopRepository;
        }

        public IActionResult GetComputers()
        {
            var computers = _desktopRepository.GetDesktops();
            return Ok(computers);
        }
    }
}
