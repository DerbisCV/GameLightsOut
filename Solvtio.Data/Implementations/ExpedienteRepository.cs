using Microsoft.EntityFrameworkCore;
using Solvtio.Data.Contracts;
using Solvtio.Models;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace Solvtio.Data.Implementations
{
    public class ExpedienteRepository : IExpedienteRepository //GenericRepository<Expediente>, IExpedienteRepository
    {
        private readonly SolvtioDbContext _solvtioDbContext;
        private readonly IMapper _mapper;

        public ExpedienteRepository(SolvtioDbContext solvtioDbContext, IMapper mapper) //: base(solvtioDbContext)
        {
            //_context = solvtioDbContext ?? throw new ArgumentNullException(nameof(context));
            _solvtioDbContext = solvtioDbContext;
            _mapper = mapper;
        }

        //public void Add(Expediente entity)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void Delete(Expediente entity)
        //{
        //    throw new System.NotImplementedException();
        //}

        public async Task<ModelExpedienteEdit> GetModelExpediente(int id)
        {
            var result = await _solvtioDbContext.ExpedienteSet
                .Where(x => x.IdExpediente == id)
                //.Select(x => new ModelExpediente
                //{
                //    IdExpediente = id,
                //    NoExpediente = x.NoExpediente,
                //    ReferenciaExterna = x.ReferenciaExterna,
                //    TipoExpediente = x.TipoExpediente,
                //    ClienteOficina = x.Gnr_ClienteOficina.Nombre
                //})
                .FirstOrDefaultAsync();
            
            //mapper.Map<OrderDto>(order);
            
            return _mapper.Map<ModelExpedienteEdit>(result);
        }

        public async Task<SearchExpediente> GetWithPagination(PaginationFilter paginationFilter)
        {
            var result = new SearchExpediente(paginationFilter);

            var query = _solvtioDbContext.ExpedienteSet.AsNoTracking()
                .Select(x => new ModelExpediente
                {
                    IdExpediente = x.IdExpediente,
                    NoExpediente = x.NoExpediente,
                    ReferenciaExterna = x.ReferenciaExterna,
                    TipoExpediente = x.TipoExpediente,
                    ClienteOficina = x.Gnr_ClienteOficina.Nombre,
                    Inicio = x.Inicio,
                    Fin = x.Fin
                });

            if (!string.IsNullOrWhiteSpace(paginationFilter.Filter.Code1))
                query = query.Where(x => x.NoExpediente.Contains(paginationFilter.Filter.Code1));
            if (!string.IsNullOrWhiteSpace(paginationFilter.Filter.Code2))
                query = query.Where(x => x.ReferenciaExterna.Contains(paginationFilter.Filter.Code2));

            result.Result = await query
                .Skip(paginationFilter.Pagination.Rows2Skip)
                .Take(paginationFilter.Pagination.PageLimit)
                .ToListAsync();

            result.PaginationFilter.Pagination.TotalElements = await query.CountAsync();

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
