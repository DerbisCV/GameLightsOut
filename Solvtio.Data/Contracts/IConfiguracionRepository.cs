using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solvtio.Data
{
    public interface IConfiguracionRepository
    {
        IEnumerable<Configuracion> GetAllConfiguracion();
        Task<Configuracion> GetConfiguracionByNameAsync(string settingName);
    }
}
