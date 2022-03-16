using LightsOut.Services.Contracts;
using LightsOut.Services.Data;
using LightsOut.Services.Data.TableEntity;
using LightsOut.Services.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LightsOut.Services.Implementations
{
    public class LightsOutService : ILightsOutService
    {
        private readonly ILightsOutSettingRepository _ILightsOutSettingRepository;

        public LightsOutService(ILightsOutSettingRepository lightsOutSettingRepository)
        {
            _ILightsOutSettingRepository = lightsOutSettingRepository;
        }

        public IEnumerable<LightsOutSetting> GetAllLightsOutSetting()
        {
            return _ILightsOutSettingRepository.GetAllLightsOutSetting();
        }

        public async Task<LightsOutSetting> GetLightsOutSettingByNameAsync(string name)
        {
            return await _ILightsOutSettingRepository.GetLightsOutSettingByNameAsync(name);
        }

        public async Task<GameBoardModel> GetLightsOutModelAsync()
        {
            var size = await _ILightsOutSettingRepository.GetLightsOutSettingByNameAsync("BoardSize");
            if (size == null) throw new Exception("The 'BoardSize' setting does not exist! This configuration is required!");

            if (int.TryParse(size.SettingValue, out int sizeValue))
                return new GameBoardModel(sizeValue);

            return new GameBoardModel();
        }
    }
}
