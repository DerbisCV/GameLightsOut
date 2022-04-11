using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solvtio.Data
{
    public class ConfiguracionRepository : IConfiguracionRepository
    {
        private readonly SolvtioDbContext _solvtioDbContext;

        public ConfiguracionRepository(SolvtioDbContext solvtioDbContext)
        {
            _solvtioDbContext = solvtioDbContext;
        }

        public IEnumerable<Configuracion> GetAllConfiguracion()
        {
            return _solvtioDbContext.ConfiguracionSet.ToList();
        }

        public async Task<Configuracion> GetConfiguracionByNameAsync(string settingName)
        {
            return await _solvtioDbContext.ConfiguracionSet.FindAsync(settingName);
        }
    }
}
