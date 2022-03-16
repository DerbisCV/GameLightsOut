using Flurl;
using Flurl.Http;
using LightsOut.Services.Models;
using LightsOut.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace LightsOut.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly string _apiUrlBase;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            _apiUrlBase = configuration.GetValue<string>("Endpoints:apiUrlBase");
        }

        public IActionResult Index()
        {
            return RedirectToAction("GameLightsOut");
        }

        public async Task<IActionResult> GameLightsOut()
        {
            var gameBoardModel = await GetLightsOutModelAsync();

            return View(gameBoardModel);
        }

        private async Task<GameBoardModel> GetLightsOutModelAsync()
        {
            var gameBoardModel = await _apiUrlBase
                .AppendPathSegment("LightsOut")
                .GetJsonAsync<GameBoardModel>();

            return gameBoardModel;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
