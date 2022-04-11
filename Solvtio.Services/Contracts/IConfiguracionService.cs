using Solvtio.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solvtio.Services.Contracts
{
    public interface IConfiguracionService
    {
        //Task<GameBoardModel> GetLightsOutModelAsync();
        IEnumerable<Configuracion> GetAllConfiguracion();
        Task<Configuracion> GetConfiguracionByNameAsync(string name);
    }
}
