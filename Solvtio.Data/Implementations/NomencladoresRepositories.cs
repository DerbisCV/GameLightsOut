using AutoMapper;
using Solvtio.Data.Contracts;
using Solvtio.Data.Models.Dtos;
using Solvtio.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

//using Microsoft.EntityFrameworkCore;
//using Solvtio.Data.Contracts;
//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;


namespace Solvtio.Data.Implementations
{
    public class NomencladorReadOnlyRepository : INomencladorReadOnlyRepository
    {
        private readonly SolvtioDbContext _context;
        private readonly IMapper _mapper;

        public NomencladorReadOnlyRepository(SolvtioDbContext solvtioDbContext, IMapper mapper)
        {
            _context = solvtioDbContext;
            _mapper = mapper;
        }

        public async Task<IList<ModelDtoNombre>> GetProcuradores()
        {
            return await _context.Gnr_Procurador
                .Select(x => new ModelDtoNombre
                {
                    Id = x.IdPersona,
                    Nombre = x.Gnr_Persona.NombreApellidos,
                })
                .OrderBy(x => x.Nombre)
                .ToListAsync();
        }

        public async Task<IList<ModelDtoNombre>> GetAbogados()
        {
            return await _context.Gnr_Abogado
                .Where(x => x.Activo == true)
                .Select(x => new ModelDtoNombre
                {
                    Id = x.IdPersona,
                    Nombre = x.Persona.NombreApellidos,
                })
                .OrderBy(x => x.Nombre)
                .ToListAsync();
        }


        public async Task<IList<ModelDtoNombre>> GetPagadoresPorOficina(int? idClienteOficina)
        {
            var query = _context.PagadorSet
                //.Include(x => x.ClienteSet)
                .Where(x => x.Activo == true);
            if (idClienteOficina.HasValue)
            {
                var oficina = _context.Gnr_ClienteOficina.FirstOrDefault(x => x.IdClienteOficina == idClienteOficina);
                if (oficina != null)
                    query = query.Where(x => x.PagadorClienteSet.Any(c => c.IdCliente == oficina.IdCliente));
            }

            return await query
                .OrderBy(x => x.Nombre)
                .Select(x => new ModelDtoNombre
                {
                    Id = x.IdPagador,
                    Nombre = x.Nombre,
                })
                .ToListAsync();
        }

        public async Task<IList<ModelDtoNombre>> GetJuzgados()
        {
            return await _context.JuzgadoSet
                .OrderBy(x => x.Nombre)
                .Select(x => new ModelDtoNombre
                {
                    Id = x.IdJuzgado,
                    Nombre = x.Nombre,
                }).ToListAsync();
        }

        public async Task<IList<ModelDtoNombre>> GetPartidoJudiciales()
        {
            return await _context.PartidoJudicialSet.Select(x => new ModelDtoNombre
            {
                Id = x.IdPartidoJudicial,
                Nombre = x.Nombre,
            }).ToListAsync();
        }

        public async Task<IList<ModelDtoNombre>> GetCarteras()
        {
            return await _context.CarteraSet
                .OrderBy(x => x.Nombre)
                .Select(x => new ModelDtoNombre
                {
                    Id = x.IdCartera,
                    Nombre = x.Nombre,
                }).ToListAsync();
        }

        public async Task<IList<ModelDtoNombre>> TipoDeudorGetAll()
        {
            return await _context.Gnr_TipoDeudor
                .OrderBy(x => x.Descripcion)
                .Select(x => new ModelDtoNombre
                {
                    Id = x.IdTipoDeudor,
                    Nombre = x.Descripcion,
                }).ToListAsync();
        }

        public async Task<IList<ModelDtoNombre>> TipoEstadoClienteGetAll(bool soloActivos = true)
        {
            var query = _context.Gnr_TipoEstadoClienteSet.AsQueryable();
            if (soloActivos) query = query.Where(x => x.Activo);

            return await query.OrderBy(x => x.Descripcion)
                .Select(x => new ModelDtoNombre
                {
                    Id = x.IdTipoEstadoCliente,
                    Nombre = x.Descripcion,
                }).ToListAsync();
        }

        #region Provincia Municipio

        public async Task<IList<ModelDtoNombre>> GetProvincias()
        {
            return await _context.ProvinciaSet
                .OrderBy(x => x.Nombre)
                .Select(x => new ModelDtoNombre
                {
                    Id = x.IdProvincia,
                    Nombre = x.Nombre,
                }).ToListAsync();
        }

        public async Task<IList<ModelDtoNombre>> GetMunicipiosByProvincia(int? idProvincia)
        {
            return await _context.MunicipioSet
                .Where(x => x.IdProvincia == idProvincia)
                .OrderBy(x => x.Nombre)
                .Select(x => new ModelDtoNombre
                {
                    Id = x.IdMunicipio,
                    Nombre = x.Nombre,
                }).ToListAsync();
        }

        #endregion

        #region CaracteristicaBase & Estado

        public async Task<IList<ModelDtoNombre>> GetCaracteristicaBaseByGrupo(string grupo, bool soloActivos = false)
        {
            var query = _context.CaracteristicaBaseSet.Where(x => x.Grupo.Equals(grupo));
            if (soloActivos) query = query.Where(x => x.Activo);

            return await query
                .OrderBy(x => x.Nombre)
                .Select(x => new ModelDtoNombre
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                }).ToListAsync();
        }

        //Task<IList<ModelDtoNombre>> (int? );
        public async Task<IList<ModelDtoNombre>> TipoEstadoGetAllByExpediente(int? idExpediente)
        {
            if (!idExpediente.HasValue || idExpediente == 0) return new List<ModelDtoNombre>();

            var idTipoExpediente = _context.ExpedienteSet.Find(idExpediente).IdTipoExpediente;

            return await _context.Gnr_TipoEstado
                .Where(x => x.IdTipoExpediente == idTipoExpediente)
                .OrderBy(x => x.IdTipoEstado)
                .Select(x => new ModelDtoNombre
                {
                    Id = x.IdTipoEstado,
                    Nombre = x.Nombre,
                }).ToListAsync();
        }

        public async Task<List<TipoSubFaseEstado>> GetTipoSubFaseByEstado(ExpedienteEstadoTipo estadoTipo, bool soloActivos = true)
        {
            var query = _context.TipoSubFaseEstadoSet.AsNoTracking()
                .Where(x => x.TipoEstado == estadoTipo);
            if (soloActivos)
                query = query.Where(x => x.Activo);

            return await query.ToListAsync();
        }

        public async Task<List<TipoIncidenciaEstado>> GetTipoIncidenciaByEstado(ExpedienteEstadoTipo estadoTipo, bool soloActivos = true)
        {
            var query = _context.TipoIncidenciaEstadoSet
                .AsNoTracking()
                .Where(x => x.TipoEstado == estadoTipo);
            if (soloActivos)
                query = query.Where(x => x.Activo);

            return await query.ToListAsync();
        }

        #endregion
    }

    public class ClienteRepository : GenericRepository<Gnr_Cliente>, IClienteRepository
    {
        public ClienteRepository(SolvtioDbContext solvtioDbContext) : base(solvtioDbContext) { }
    }
    public class ClienteOficinaRepository : GenericRepository<Gnr_ClienteOficina>, IClienteOficinaRepository
    {
        public ClienteOficinaRepository(SolvtioDbContext solvtioDbContext) : base(solvtioDbContext) { }
    }
    public class TipoAreaRepository : GenericRepository<Gnr_TipoArea>, ITipoAreaRepository
    {
        public TipoAreaRepository(SolvtioDbContext solvtioDbContext) : base(solvtioDbContext) { }
    }
    public class TipoExpedienteRepository : GenericRepository<Gnr_TipoExpediente>, ITipoExpedienteRepository
    {
        public TipoExpedienteRepository(SolvtioDbContext solvtioDbContext) : base(solvtioDbContext) { }
    }

    public class AbogadoRepository : GenericRepository<Gnr_Abogado>, IAbogadoRepository
    {
        public AbogadoRepository(SolvtioDbContext solvtioDbContext) : base(solvtioDbContext) { }

        public override IEnumerable<Gnr_Abogado> GetAll()
        {
            return _context.Gnr_Abogado.Include(x => x.Persona);
        }
    }
    public class ProcuradorRepository : GenericRepository<Gnr_Procurador>, IProcuradorRepository
    {
        public ProcuradorRepository(SolvtioDbContext solvtioDbContext) : base(solvtioDbContext) { }

        public override IEnumerable<Gnr_Procurador> GetAll()
        {
            return _context.Gnr_Procurador.Include(x => x.Gnr_Persona);
        }
    }


    public class ExpedienteNotaRepository : GenericRepository<ExpedienteNota>, IExpedienteNotaRepository
    {
        public ExpedienteNotaRepository(SolvtioDbContext solvtioDbContext) : base(solvtioDbContext) { }
    }



}
