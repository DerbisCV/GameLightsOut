using LightsOut.Services.Data.TableEntity;
using LightsOut.Services.Models;
using Solvtio.Data;
using Solvtio.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solvtio.Services.Implementations
{
    public class ConfiguracionService : IConfiguracionService
    {
        private readonly IConfiguracionRepository _IConfiguracionRepository;

        public ConfiguracionService(IConfiguracionRepository configuracionRepository)
        {
            _IConfiguracionRepository = configuracionRepository;
        }

        public IEnumerable<Configuracion> GetAllConfiguracion()
        {
            return _IConfiguracionRepository.GetAllConfiguracion();
        }

        public async Task<Configuracion> GetConfiguracionByNameAsync(string name)
        {
            return await _IConfiguracionRepository.GetConfiguracionByNameAsync(name);
        }

        //public async Task<GameBoardModel> GetLightsOutModelAsync()
        //{
        //    var size = await _IConfiguracionRepository.GetLightsOutSettingByNameAsync("BoardSize");
        //    if (size == null) throw new Exception("The 'BoardSize' setting does not exist! This configuration is required!");

        //    if (int.TryParse(size.SettingValue, out int sizeValue))
        //        return new GameBoardModel(sizeValue);

        //    return new GameBoardModel();
        //}
    }
}
