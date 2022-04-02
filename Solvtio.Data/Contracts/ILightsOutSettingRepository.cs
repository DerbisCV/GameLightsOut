using LightsOut.Services.Data.TableEntity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LightsOut.Services.Data
{
    public interface ILightsOutSettingRepository
    {
        IEnumerable<LightsOutSetting> GetAllLightsOutSetting();
        Task<LightsOutSetting> GetLightsOutSettingByNameAsync(string settingName);
    }
}
