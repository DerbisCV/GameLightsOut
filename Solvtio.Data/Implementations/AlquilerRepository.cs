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
        private readonly SolvtioDbContext _solvtioDbContext;

        public AlquilerRepository(SolvtioDbContext solvtioDbContext) : base(solvtioDbContext)
        {
            _solvtioDbContext = solvtioDbContext;
        }

        public async Task<IEnumerable<Alq_Expediente>> GetWithPagination(PaginationFilter paginationFilter)
        {
            var result = _dbSet.AsQueryable()
                .Include(x => x.Expediente)
                .Skip(paginationFilter.Pagination.Rows2Skip)
                .Take(paginationFilter.Pagination.PageLimit);

            return await result.ToListAsync();
        }

        public async Task<string> Update(AlqExpedienteDto model)
        {
            try
            {
                var entity = _dbSet
                    .Include(x => x.Expediente)
                    .FirstOrDefault(x => x.IdExpediente == model.IdExpediente);
                if (entity == null) throw new System.Exception("No se encontró el expediente");

                entity.RefreshBy(model);
                _context.SaveChanges();

                //var expediente = await _solvtioDbContext.ExpedienteSet
                //    .FirstOrDefaultAsync(x => x.IdExpediente == model.IdExpediente);
                //entity.Expediente.RefreshBy(model);
                //_context.SaveChanges();

                return string.Empty;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
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
