using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Solvtio.API.Controllers
{
    public class ControllerBaseSolvtioApi : ControllerBase
    {
        private readonly ILogger<ControllerBaseSolvtioApi> _logger;

        public ControllerBaseSolvtioApi(ILogger<ControllerBaseSolvtioApi> logger)
        {
            _logger = logger;
        }

        internal string LogError(Exception ex, string headMessage = "Something went wrong: ")
        {
            var msg = $"{headMessage}{ex.Message}";
            _logger.LogError(msg);
            return msg;
        }

        public string UserIdentityName => User?.Identity?.Name;
    }
}
