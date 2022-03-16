using LightsOut.Services.Contracts;
using LightsOut.Services.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LightsOut.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LightsOutController : ControllerBase
    {
        private readonly ILightsOutService _lightsOutService;

        public LightsOutController(ILightsOutService lightsOutService)
        {
            _lightsOutService = lightsOutService;
        }

        [HttpGet]
        public async Task<GameBoardModel> Get()
        {
            return await _lightsOutService.GetLightsOutModelAsync();
        }
    }
}
