using Microsoft.AspNetCore.Mvc;
using MiniInventorySystem.Services;
using System;
using System.Threading.Tasks;

namespace MiniInventorySystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComputersController : ControllerBase
    {
        private readonly IDesktopRepository _desktopRepository;

        public ComputersController(IDesktopRepository desktopRepository)
        {
            _desktopRepository = desktopRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetComputers()
        {
            var computers = await _desktopRepository.GetDesktopsAsync();
            return Ok(computers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetComputer(Guid id)
        {
            var computers = await _desktopRepository.GetDesktopAsync(id);
            return Ok(computers);
        }
    }
}
