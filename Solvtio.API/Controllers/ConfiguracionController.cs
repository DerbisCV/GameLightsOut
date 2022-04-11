using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Solvtio.Services.Contracts;
using System;

namespace Solvtio.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConfiguracionController : ControllerBase
    {
        private readonly ILogger<ConfiguracionController> _logger;
        private readonly IConfiguracionService _lightsOutService;

        public ConfiguracionController(ILogger<ConfiguracionController> logger, IConfiguracionService lightsOutService)
        {
            _logger = logger;
            _lightsOutService = lightsOutService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_lightsOutService.GetAllConfiguracion());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllLightsOutSetting: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var setting = _lightsOutService.GetConfiguracionByNameAsync(id).Result;
            if (setting == null)
            {
                var errorMessage = $"The '{id}' setting does not exist!";
                _logger.LogError(errorMessage);
                return NotFound(errorMessage);
            }

            return Ok(setting);
        }
    }
}
