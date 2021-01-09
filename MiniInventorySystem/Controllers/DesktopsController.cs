using Microsoft.AspNetCore.Mvc;
using MiniInventorySystem.Services;
using System;
using System.Threading.Tasks;
using MiniInventorySystem.Models;

namespace MiniInventorySystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesktopsController : ControllerBase
    {
        private readonly IDesktopRepository _desktopRepository;

        public DesktopsController(IDesktopRepository desktopRepository)
        {
            _desktopRepository = desktopRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetDesktops()
        {
            var desktops = await _desktopRepository.GetDesktopsAsync();
            return Ok(desktops);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDesktop(Guid id)
        {
            var desktop = await _desktopRepository.GetDesktopAsync(id);
            return Ok(desktop);
        }

        [HttpPost]
        public async Task<IActionResult> AddDesktop([FromBody] Desktop desktopViewModel)
        {
            try
            {
                var desktop = await _desktopRepository.AddDesktopAsync(desktopViewModel);
                return Ok(desktop);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
