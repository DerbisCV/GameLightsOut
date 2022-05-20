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
            var msg = $"{headMessage}{GetErrorMessageFull(ex)}";
            _logger.LogError(msg);
            return msg;
        }

        private object GetErrorMessageFull(Exception ex)
        {
            if (ex == null) return null;
            if (ex.InnerException == null) return ex.Message;

            return $"{ex.Message} | (InnerException => {ex.InnerException.Message})" ;
        }

        public string UserIdentityName => User?.Identity?.Name;
    }
}
