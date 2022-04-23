using Solvtio.Data.Contracts;
using Solvtio.Models;
using System.Collections.Generic;

namespace Solvtio.Data.Implementations
{
    public class ExpedienteRepository : GenericRepository<Expediente>, IExpedienteRepository
    {
        //private readonly SolvtioDbContext _solvtioDbContext;

        public ExpedienteRepository(SolvtioDbContext solvtioDbContext) : base(solvtioDbContext)
        {
            //_context = solvtioDbContext;
        }

        //public void Add(Expediente entity)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void Delete(Expediente entity)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public Expediente Get(int id)
        //{
        //    throw new System.NotImplementedException();
        //}

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
