using Microsoft.EntityFrameworkCore;
using Solvtio.Data.Contracts;
using Solvtio.Models;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Solvtio.Data.Common;
using Solvtio.Data.Models.Dtos;
using System.Collections.Generic;

namespace Solvtio.Data.Implementations
{
    public class ExpedienteRepository : IExpedienteRepository
    {
        private readonly SolvtioDbContext _solvtioDbContext;
        private readonly IMapper _mapper;

        public ExpedienteRepository(SolvtioDbContext solvtioDbContext, IMapper mapper)
        {
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
                .FirstOrDefaultAsync();
            
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

        public async Task<ModelResult> Update(ModelExpedienteEdit model)
        {
            var result = new ModelResult();

            var entity = await _solvtioDbContext.ExpedienteSet
                .FirstOrDefaultAsync(x => x.IdExpediente == model.IdExpediente);
            if (entity == null) throw new System.Exception("No se encontró el expediente");

            entity.RefreshBy(model);
            await _solvtioDbContext.SaveChangesAsync();

            return result;
        }

        public async Task<ExpedienteEstadoDto> GetEstadoActual(int idExpediente)
        {
            var idEstadoLast = _solvtioDbContext.ExpedienteSet.First(x => x.IdExpediente == idExpediente)?.IdEstadoLast;
            if (!idEstadoLast.HasValue) throw new System.Exception("No se encontró el expediente o este no tiene estado");

            var result = await _solvtioDbContext.ExpedienteEstadoes
                .Include(x => x.Gnr_TipoEstado)
                .FirstOrDefaultAsync(x => x.ExpedienteEstadoIdSiguiente == idEstadoLast.Value);
            if (result == null) return null;

            var estadoDto = _mapper.Map<ExpedienteEstadoDto>(result);
            estadoDto.TipoEstado = _mapper.Map<ModelDtoNombre>(result.Gnr_TipoEstado);

            return estadoDto;
        }
        
        public async Task<List<ExpedienteNotaDto>> GetNotas(int idExpediente)
        {
            var result = await _solvtioDbContext.ExpedienteNotaSet
                .Where(x => x.IdExpediente == idExpediente)
                .ToListAsync();

            return _mapper.Map<List<ExpedienteNotaDto>>(result);
        }
        

        //public IEnumerable<Configuracion> GetAllConfiguracion()
        //{
        //    return _solvtioDbContext.ConfiguracionSet.ToList();
        //}

        //public async Task<Configuracion> GetConfiguracionByNameAsync(string settingName)
        //{
        //    return await _solvtioDbContext.ConfiguracionSet.FindAsync(settingName);
        //}

    }
}
