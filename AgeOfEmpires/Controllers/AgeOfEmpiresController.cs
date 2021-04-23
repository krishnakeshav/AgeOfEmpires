using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AgeOfEmpires.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AgeOfEmpiresController : ControllerBase
    {
        private readonly IAgeOfEmpires _game;
        private readonly ILogger<AgeOfEmpiresController> _logger;

        public AgeOfEmpiresController(IAgeOfEmpires game, ILogger<AgeOfEmpiresController> logger)
        {
            _game = game;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok( _game.DoBattle());
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Error in dual battle");
                return StatusCode(404);
            }
        }
    }
}
