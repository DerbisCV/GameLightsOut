using Microsoft.EntityFrameworkCore;
using Solvtio.Data.Contracts;
using Solvtio.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solvtio.Data.Implementations
{
    public class CaracteristicaBaseRepository : GenericRepository<CaracteristicaBase>, ICaracteristicaBaseRepository
    {
        //private readonly SolvtioDbContext _solvtioDbContext;

        public CaracteristicaBaseRepository(SolvtioDbContext solvtioDbContext) : base(solvtioDbContext)
        {
            //_context = solvtioDbContext;
        }

        public async Task<List<CaracteristicaBase>> GetByGrup(string grupo, bool soloActivos)
        {
            var query = _context.CaracteristicaBaseSet
                .Where(x => x.Grupo == grupo);
            if (soloActivos)
                query = query.Where(x => x.Activo);

            return await query.ToListAsync();
        }

        //public void Add(CaracteristicaBase entity)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void Delete(CaracteristicaBase entity)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public CaracteristicaBase Get(int id)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public IEnumerable<CaracteristicaBase> GetAll()
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

        //public void Update(CaracteristicaBase entity)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
