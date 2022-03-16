using LightsOut.Services.Data.TableEntity;
using LightsOut.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LightsOut.Services.Contracts
{
    public interface ILightsOutService
    {
        Task<GameBoardModel> GetLightsOutModelAsync();
        IEnumerable<LightsOutSetting> GetAllLightsOutSetting();
        Task<LightsOutSetting> GetLightsOutSettingByNameAsync(string name);
    }
}
