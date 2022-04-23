using Microsoft.EntityFrameworkCore;
using Solvtio.Data.Contracts;
using Solvtio.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solvtio.Data.Implementations
{
    public class AlquilerRepository : GenericRepository<Alq_Expediente>, IAlquilerRepository
    {
        //private readonly SolvtioDbContext _solvtioDbContext;

        public AlquilerRepository(SolvtioDbContext solvtioDbContext) : base(solvtioDbContext)
        {
            //_context = solvtioDbContext;
        }

        public async Task<IEnumerable<Alq_Expediente>> GetWithPagination(PaginationFilter paginationFilter)
        {
            var result = _dbSet.AsQueryable()
                .Include(x => x.Expediente)
                .Skip(paginationFilter.Pagination.Rows2Skip)
                .Take(paginationFilter.Pagination.PageLimit);

            return await result.ToListAsync();
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
