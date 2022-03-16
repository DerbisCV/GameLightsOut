using LightsOut.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace LightsOut.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SettingController : ControllerBase
    {
        private readonly ILogger<LightsOutController> _logger;
        private readonly ILightsOutService _lightsOutService;

        public SettingController(ILogger<LightsOutController> logger, ILightsOutService lightsOutService)
        {
            _logger = logger;
            _lightsOutService = lightsOutService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_lightsOutService.GetAllLightsOutSetting());
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
            var setting = _lightsOutService.GetLightsOutSettingByNameAsync(id).Result;
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
