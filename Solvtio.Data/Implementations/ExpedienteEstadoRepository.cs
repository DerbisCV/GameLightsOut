using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Solvtio.Data.Contracts;
using Solvtio.Data.Models.Dtos;
using Solvtio.Data.Models.Estado;
using Solvtio.Data.Models.Estado.Alquiler;
using Solvtio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solvtio.Data.Implementations
{
    public class ExpedienteEstadoRepository : GenericRepository<ExpedienteEstado>, IExpedienteEstadoRepository
    {
        private readonly IMapper _mapper;

        public ExpedienteEstadoRepository(SolvtioDbContext solvtioDbContext, IMapper mapper) : base(solvtioDbContext)
        {
            _mapper = mapper;
        }

        public override IEnumerable<ExpedienteEstado> GetAll()
        {
            return _context.ExpedienteEstadoSet.Include(x => x.Gnr_TipoEstado);
        }

        public override async Task<ExpedienteEstado> Get(int id)
        {
            return await _context.ExpedienteEstadoSet
                .Include(x => x.Gnr_TipoEstado)
                //.Include(x => x.Provincia)
                //.Include(x => x.Gnr_Persona)
                .FirstOrDefaultAsync(x => x.ExpedienteEstadoId == id);
        }

        public void Update(ExpedienteEstadoDto model)
        {
            var entity = _context.ExpedienteEstadoSet
                .Include(x => x.Gnr_TipoEstado)
                .FirstOrDefault(x => x.ExpedienteEstadoId == model.IdExpedienteEstado);
            if (entity == null) throw new Exception($"El estado ({model.IdExpedienteEstado}) no existe.");

            entity.RefreshBy(model);
            _context.SaveChanges();



            //var entidad = db.AlqExpedienteEstadoPresentacionDenunciaSet.FirstOrDefault(x => x.IdExpedienteEstado == model.IdExpedienteEstado);
            //if (entidad == null) throw new Exception("La estado a modificar no existe");

            //entidad.ExpedienteEstado.RefreshBy(model.ExpedienteEstado);
            EstadoUpdate(entity);
            AddNoteIfApplicable(entity, model.Observacion);

            //estadoEspecifico.RefreshBy(model);
            //db.SaveChanges();

            ExpedienteUpdatedFromEstado(entity);
        }

        #region Alquiler

        public async Task<EstadoAlqFinalizacionDto> GetEstadoAlqFinalizacion(int idExpedienteEstado)
        {
            var entity = _context.Alq_Expediente_EstadoFinalizaciones
                .FirstOrDefault(x => x.IdExpedienteEstado == idExpedienteEstado);

            return _mapper.Map<EstadoAlqFinalizacionDto>(entity);
        }

        public async Task<string> Update(EstadoAlqFinalizacionDto model)
        {
            try
            {
                var entity = _context.Alq_Expediente_EstadoFinalizaciones
                    .FirstOrDefault(x => x.IdExpedienteEstado == model.IdExpedienteEstado);
                if (entity == null) throw new Exception($"El estado ({model.IdExpedienteEstado}) no existe.");

                entity.RefreshBy(model);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return null;
        }

        #endregion

        internal void EstadoUpdate(ExpedienteEstado estado)
        {
            if (estado == null) return;

            var lstEstadosDependientes = _context.ExpedienteEstadoSet
                .Where(x => x.ExpedienteEstadoIdSiguiente == estado.ExpedienteEstadoId);

            foreach (var estadoDpte in lstEstadosDependientes)
                estadoDpte.FechaFin = estado.Fecha;
        }
        private void AddNoteIfApplicable(ExpedienteEstado estado, string observacion)
        {
            if (string.IsNullOrWhiteSpace(observacion)) return;

            var nota = new ExpedienteNota(estado);
            nota.Nota = observacion;

            _context.ExpedienteNotaSet.Add(nota);
            _context.SaveChanges();
        }

        public Expediente ExpedienteUpdatedFromEstado(ExpedienteEstado estado)
        {
            if (estado == null) return null;

            var expediente = _context.ExpedienteSet.FirstOrDefault(x => x.IdExpediente == estado.IdExpediente);
            if (expediente == null) return null;

            if (estado.Gnr_TipoEstado.Fin) expediente.Fin = estado.Fecha;

            if (expediente.Fin.HasValue)
            {
                var hitosProcesalesNoCerrados = _context.ExpedienteHitoProcesalSet.Where(x => x.IdExpediente == expediente.IdExpediente && !x.FechaFinReal.HasValue);
                foreach (var hitoProcesal in hitosProcesalesNoCerrados)
                    hitoProcesal.FechaCancelacion = expediente.Fin;
            }

            _context.SaveChanges();
            return expediente;
        }



        public async Task<List<ExpedienteEstadoDto>> GetByExpediente(int idExpediente)
        {
            var result = await _context.ExpedienteEstadoSet
                .Include(x => x.Gnr_TipoEstado)
                .Where(x => x.IdExpediente == idExpediente)
                .ToListAsync();

            return _mapper.Map<List<ExpedienteEstadoDto>>(result);
        }

        public async Task<List<ExpedienteNotaDto>> GetExpedienteNotaByEstado(int idExpedienteEstado)
        {
            var query = _context.ExpedienteNotaSet.AsNoTracking()
                .Include(x => x.Expediente)
                .Include(x => x.ExpedienteEstado)
                .Where(x => x.IdExpedienteEstado == idExpedienteEstado);

            var result = await query
                .OrderByDescending(x => x.Fecha)
                .ThenByDescending(x => x.IdExpedienteNota)
                .ToListAsync();

            return _mapper.Map<List<ExpedienteNotaDto>>(result);
        }

        public async Task<List<LogEstadoSubfase>> LogEstadoSubfaseByEstado(int idExpedienteEstado)
        {
            var query = _context.LogEstadoSubfaseSet.AsNoTracking()
                .Include(x => x.TipoSubFaseEstado)
                .Include(x => x.TipoSubFaseCliente)
                .Where(x => x.IdExpedienteEstado == idExpedienteEstado);

            var result = await query
                .OrderBy(x => x.Fecha)
                .ToListAsync();

            return result;
        }



    }

}
