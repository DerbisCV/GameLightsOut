using Microsoft.EntityFrameworkCore;
using Solvtio.Data.Contracts;
using Solvtio.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solvtio.Data.Implementations
{
    public class ExpedienteRepository : IExpedienteRepository //GenericRepository<Expediente>, IExpedienteRepository
    {
        private readonly SolvtioDbContext _solvtioDbContext;

        public ExpedienteRepository(SolvtioDbContext solvtioDbContext) //: base(solvtioDbContext)
        {
            //_context = solvtioDbContext ?? throw new ArgumentNullException(nameof(context));
            _solvtioDbContext = solvtioDbContext;
        }

        //public void Add(Expediente entity)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void Delete(Expediente entity)
        //{
        //    throw new System.NotImplementedException();
        //}

        public async Task<ModelExpediente> GetModelExpediente(int id)
        {
            var result = await _solvtioDbContext.ExpedienteSet
                .Where(x => x.IdExpediente == id)
                .Select(x => new ModelExpediente 
                {
                    IdExpediente = id,
                    NoExpediente = x.NoExpediente,
                    ReferenciaExterna = x.ReferenciaExterna,
                    TipoExpediente = x.TipoExpediente,
                    ClienteOficina = x.Gnr_ClienteOficina.Nombre                    
                })
                .FirstOrDefaultAsync();

            return result;
        }

        //public IEnumerable<Expediente> GetAll()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public IEnumerable<Configuracion> GetAllConfiguracion()
        //{
        //    return _solvtioDbContext.ConfiguracionSet.ToList();
        //}

        //public async Task<Configuracion> GetConfiguracionByNameAsync(string settingName)
        //{
        //    return await _solvtioDbContext.ConfiguracionSet.FindAsync(settingName);
        //}

        //public void Update(Expediente entity)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
