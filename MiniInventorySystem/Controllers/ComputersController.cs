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
        private IComputerRepository _computerRepository;

        public ComputersController(IComputerRepository computerRepository)
        {
            _computerRepository = computerRepository;
        }

        public IActionResult GetComputers()
        {
            var computers = _computerRepository.GetComputers();
            return Ok(computers);
        }
    }
}
