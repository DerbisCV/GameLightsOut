using LightsOut.Services.Data.TableEntity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LightsOut.Services.Data
{
    public class LightsOutSettingRepository : ILightsOutSettingRepository
    {
        private readonly LightsOutDbContext _lightsOutDbContext;

        public LightsOutSettingRepository(LightsOutDbContext lightsOutDbContext)
        {
            _lightsOutDbContext = lightsOutDbContext;
        }

        public IEnumerable<LightsOutSetting> GetAllLightsOutSetting()
        {
            return _lightsOutDbContext.LightsOutSettingSet.ToList();
        }

        public async Task<LightsOutSetting> GetLightsOutSettingByNameAsync(string settingName)
        {
            return await _lightsOutDbContext.LightsOutSettingSet.FindAsync(settingName);
        }
    }
}
