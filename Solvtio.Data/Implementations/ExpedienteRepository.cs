using Microsoft.EntityFrameworkCore;
using Solvtio.Data.Contracts;
using Solvtio.Models;
using Solvtio.Models;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Solvtio.Data.Common;
using Solvtio.Data.Models.Dtos;
using System.Collections.Generic;
using System;
using Solvtio.Models.Common;

namespace Solvtio.Data.Implementations
{
    public class ExpedienteRepository : BaseValues, IExpedienteRepository
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
                .Include(x => x.Gnr_TipoExpediente)
                .Include(x => x.Gnr_ClienteOficina)
                .Include(x => x.Juzgado)
                .Include(x => x.Gnr_Persona)
                .Include(x => x.Gnr_Abogado.Persona)
                .FirstOrDefaultAsync(x => x.IdExpediente == id);

            return _mapper.Map<ModelExpedienteEdit>(result);
        }

        public async Task<SearchExpediente> GetWithPagination(PaginationFilter paginationFilter)
        {
            try
            {
                var result = new SearchExpediente(paginationFilter);

                var query = _solvtioDbContext.ExpedienteSet
                    .Include(x => x.Gnr_Abogado.Persona)
                    .Include(x => x.Gnr_TipoExpediente)
                    .Include(x => x.Gnr_TipoArea)
                    .Include(x => x.Gnr_ClienteOficina)
                    .Include(x => x.Juzgado)
                    .Include(x => x.Gnr_Persona)
                    .AsNoTracking();
                //.Include(x => x.ExpedienteEstadoLast.Gnr_TipoEstado)


                if (!string.IsNullOrWhiteSpace(paginationFilter.Filter.Code1))
                    query = query.Where(x => x.NoExpediente.Contains(paginationFilter.Filter.Code1));
                if (!string.IsNullOrWhiteSpace(paginationFilter.Filter.Code2))
                    query = query.Where(x =>
                        x.ReferenciaExterna.Contains(paginationFilter.Filter.Code2)
                        || x.Referencia2.Contains(paginationFilter.Filter.Code2)
                        || x.NoAuto.Contains(paginationFilter.Filter.Code2)
                    );
                if (!string.IsNullOrWhiteSpace(paginationFilter.Filter.Code3))
                    query = query.Where(x => x.Gnr_Persona.NombreApellidos.Contains(paginationFilter.Filter.Code3));

                if (paginationFilter.Filter.IdTipo1.HasValue)
                    query = query.Where(x => x.IdClienteOficina == paginationFilter.Filter.IdTipo1);
                if (paginationFilter.Filter.IdTipo2.HasValue)
                    query = query.Where(x => x.IdCartera == paginationFilter.Filter.IdTipo2);

                if (paginationFilter.Filter.IdTipo3.HasValue)
                    query = query.Where(x => x.IdProcurador == paginationFilter.Filter.IdTipo3);
                if (paginationFilter.Filter.IdTipo4.HasValue)
                    query = query.Where(x => x.IdTipoExpediente == paginationFilter.Filter.IdTipo4);
                if (paginationFilter.Filter.IdTipo5.HasValue)
                    query = query.Where(x => x.IdTipoArea == paginationFilter.Filter.IdTipo5);

                if (paginationFilter.Filter.IsOnOff1.HasValue)
                    query = query.Where(x => x.Paralizado == paginationFilter.Filter.IsOnOff1);

                var queryResult = query.Select(x => new ModelExpediente
                {
                    IdExpediente = x.IdExpediente,
                    NoExpediente = x.NoExpediente,
                    ReferenciaExterna = x.ReferenciaExterna,
                    NoAuto = x.NoAuto,
                    Abogado = new DtoIdNombre(x.Gnr_Abogado),
                    Oficina = new DtoIdNombre(x.Gnr_ClienteOficina),
                    TipoExpediente = new DtoIdNombre(x.Gnr_TipoExpediente),
                    Juzgado = new DtoIdNombre(x.Juzgado),
                    Deudor = new DtoIdNombre(x.Gnr_Persona),
                    IdEstadoLast = x.IdEstadoLast,
                    DeudaFinal = x.DeudaFinal,
                    FechaAlta = x.FechaAlta,
                    Inicio = x.Inicio,
                    Fin = x.Fin
                });

                result.Result = await queryResult
                    .Skip(paginationFilter.Pagination.Rows2Skip)
                    .Take(paginationFilter.Pagination.PageLimit)
                    .ToListAsync();

                foreach (var item in result.Result)
                {
                    item.Estado = new EstadoDtoMin(_solvtioDbContext.ExpedienteEstadoSet.Include(x => x.Gnr_TipoEstado).FirstOrDefault(x => x.ExpedienteEstadoId == item.IdEstadoLast));
                }

                result.PaginationFilter.Pagination.TotalElements = await queryResult.CountAsync();

                return result;
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                throw ex;
            }
            catch (System.Exception ex)
            {
                throw;
            }
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

        public int? GetIdExpedienteByNo(string noExpediente)
        {
            return _solvtioDbContext.ExpedienteSet.FirstOrDefault(x => x.NoExpediente == noExpediente)?.IdExpediente;
        }

        public async Task<ExpedienteEstadoDto> GetEstadoActual(int idExpediente)
        {
            var idEstadoLast = _solvtioDbContext.ExpedienteSet.First(x => x.IdExpediente == idExpediente)?.IdEstadoLast;
            if (!idEstadoLast.HasValue) throw new System.Exception("No se encontró el expediente o este no tiene estado");

            var result = await _solvtioDbContext.ExpedienteEstadoSet
                .Include(x => x.Gnr_TipoEstado)
                .FirstOrDefaultAsync(x => x.ExpedienteEstadoIdSiguiente == idEstadoLast.Value);
            if (result == null) return null;

            var estadoDto = _mapper.Map<ExpedienteEstadoDto>(result);
            estadoDto.TipoEstado = _mapper.Map<DtoIdNombre>(result.Gnr_TipoEstado);

            return estadoDto;
        }

        public async Task<List<ExpedienteNotaDto>> GetNotas(int idExpediente)
        {
            var result = await _solvtioDbContext.ExpedienteNotaSet
                .Where(x => x.IdExpediente == idExpediente)
                .ToListAsync();

            return _mapper.Map<List<ExpedienteNotaDto>>(result);
        }

        public async Task<List<ExpedienteDeudorDto>> GetDeudores(int idExpediente)
        {
            try
            {
                var result = await _solvtioDbContext.ExpedienteDeudors
                    .Include(x => x.Gnr_TipoDeudor)
                    .Include(x => x.Provincia)
                    .Include(x => x.Gnr_Persona)
                    .Where(x => x.IdExpediente == idExpediente)
                    .ToListAsync();

                return _mapper.Map<List<ExpedienteDeudorDto>>(result);
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                throw ex;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            //Invalid column name 'Gnr_TipoExpedienteIdTipoExpediente'.            
        }

        #region ExpedienteByType

        public async Task<ExpedienteHipDto> GetExpedienteByTypeHip(int idExpediente)
        {
            return null;
        }

        #endregion


        #region Dashboards

        public async Task<ModelDashboardAlarmas> GetModelDashboardAlarmas(FilterBase filter, bool quitarLosResultadosConGestionReciente = false)
        {
            //var result1 = new ModelDashboardAlarmas();
            //var books = _solvtioDbContext.ModelExpedienteToKpiSet.FromSqlRaw($"EXEC sp_GetModelExpedienteToKpi @IdTipoExpediente=1");
            //var lstBooks = await books.ToListAsync();



            var result = new ModelDashboardAlarmas(filter);

            #region Variables y Constantes

            var fechaActualMenos20 = DateTime.Now.AddDays(-20);
            var FechaActualMenos30 = DateTime.Now.AddDays(-30);
            var fechaActualMenos60 = DateTime.Now.AddDays(-60);
            var FechaActualMenos90 = DateTime.Now.AddDays(-90);
            var fechaActualMenos120 = DateTime.Now.AddDays(-120);
            var fechaActualMenos180 = DateTime.Now.AddDays(-180);

            #endregion

            //using (var db = new ChmSaceContext())
            //{            }
            var db = _solvtioDbContext;
            var lstExpedientesParalizado = db.Gnr_TipoEstado.Where(x => x.Paralizado).Select(x => x.IdTipoEstado);
            var lstExpedientesFinalizado = db.Gnr_TipoEstado.Where(x => x.Fin).Select(x => x.IdTipoEstado);

            var queryBase = db.Expedientes.Include(x => x.Gnr_ClienteOficina).AsNoTracking();
            var queryBaseInmueble = db.Hip_Inmueble.Include(x => x.Hip_TipoInmueble).AsNoTracking();

            if (quitarLosResultadosConGestionReciente) //Sin Gestion Reciente
            {
                queryBase = queryBase.Where(x => !x.ExpedienteNotaSet.Any(y => y.Fecha > FechaActualMenos30));
            }
            if (filter.IsOnOff1.HasValue)
            {
                if (!filter.IsOnOff1.Value) queryBase = queryBase.Where(x => !x.ExpedienteNotaSet.Any(y => y.Fecha > FechaActualMenos30)); //Sin Gestion Reciente
                if (filter.IsOnOff1.Value) queryBase = queryBase.Where(x => x.ExpedienteNotaSet.Any(y => y.Fecha > FechaActualMenos30)); //Con Gestion Reciente
            }

            if (filter.IdTipo2.HasValue)
            {
                queryBase = queryBase.Where(x => x.IdClienteOficina == filter.IdTipo2);
                queryBaseInmueble = queryBaseInmueble.Where(x => x.IdExpediente.HasValue && x.Expediente.IdClienteOficina == filter.IdTipo2);
            }
            if (filter.IdTipo3.HasValue)
            {
                queryBase = queryBase.Where(x => x.IdAbogado == filter.IdTipo3);
                queryBaseInmueble = queryBaseInmueble.Where(x => x.IdExpediente.HasValue && x.Expediente.IdAbogado == filter.IdTipo3);
            }


            //var queryModelExpedienteToKpi = _solvtioDbContext.GetModelExpedienteToKpi(filter);
            //var resultLista = await queryModelExpedienteToKpi.ToListAsync();

            #region Hipotecarios

            if (filter.IdTipo1 == (int)TipoExpedienteEnum.Hipotecario)
            {
                result.HipotecarioAlarmaIncidentados = _solvtioDbContext.GetModelExpedienteToKpi(1, TipoIndicadorQa.HipotecarioAlarmaIncidentados).Count();

                //result.HipotecarioAlarmaIncidentados = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaIncidentados, queryBase).Count();
                //result.HipotecarioAlarmaAdmisionDemanda = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaAdmisionDemanda, queryBase).Count();
                //result.HipotecarioAlarmaInadmisionDemanda = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaInadmisionDemanda, queryBase).Count();
                //result.HipotecarioAlarmaSucesionCopiaSellada = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaSucesionCopiaSellada, queryBase).Count();
                //result.HipotecarioAlarmaCertificacionCargas = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaCertificacionCargas, queryBase).Count();
                //result.HipotecarioAlarmaRequerimientoPago = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaRequerimientoPago, queryBase).Count();
                //result.HipotecarioAlarmaSolicitudSubasta = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaSolicitudSubasta, queryBase).Count();
                //result.HipotecarioAlarmaDecretoConvocatoria = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaDecretoConvocatoria, queryBase).Count();
                //result.HipotecarioAlarmaDecretoAdjudicacion = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaDecretoAdjudicacion, queryBase).Count();
                //result.HipotecarioAlarmaPosesion = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaPosesion, queryBase).Count();
                //result.HipotecarioAlarmaTestimonio = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaTestimonio, queryBase).Count();
                //result.HipotecarioAlarmaRecepcionSolicitudCierre01 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre01, queryBase).Count();
                //result.HipotecarioAlarmaRecepcionSolicitudCierre02 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre02, queryBase).Count();
                //result.HipotecarioAlarmaRecepcionSolicitudCierre03 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre03, queryBase).Count();
                //result.HipotecarioAlarmaRecepcionSolicitudCierre04 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre04, queryBase).Count();
                //result.HipotecarioAlarmaRecepcionSolicitudCierre05 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre05, queryBase).Count();
            }

            #endregion

            #region Alquiler

            if (filter.IdTipo1 == (int)TipoExpedienteEnum.Alquiler)
            {
                result.AlquilerAlarmaPresentacionDemanda = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.AlquilerAlarmaPresentacionDemanda, queryBase).Count();
                result.AlquilerAlarmaDemandaAdmitida = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.AlquilerAlarmaDemandaAdmitida, queryBase).Count();
                result.AlquilerAlarmaPendienteNotificacion = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.AlquilerAlarmaPendienteNotificacion, queryBase).Count();
                result.AlquilerAlarmaPendienteDecretoFin = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.AlquilerAlarmaPendienteDecretoFin, queryBase).Count();
                result.AlquilerAlarmaPendienteTomaPosesion = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.AlquilerAlarmaPendienteTomaPosesion, queryBase).Count();
                result.AlquilerAlarmaPendienteEnervacion = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.AlquilerAlarmaPendienteEnervacion, queryBase).Count();
                result.AlquilerAlarmaRecepcionDemandaSellada = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.AlquilerAlarmaRecepcionDemandaSellada, queryBase).Count();
                result.AlquilerAlarmaRecepcionDemandaSelladaOrd = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.AlquilerAlarmaRecepcionDemandaSelladaOrd, queryBase).Count();
                result.AlquilerAlarmaRecepcionDemandaSelladaEjc = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.AlquilerAlarmaRecepcionDemandaSelladaEjc, queryBase).Count();
                result.AlquilerAlarmaRecepcionDemandaSelladaMn = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.AlquilerAlarmaRecepcionDemandaSelladaMn, queryBase).Count();
                result.AlquilerAlarmaRecepcionDenuncia = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.AlquilerAlarmaRecepcionDenuncia, queryBase).Count();
                result.AlquilerAlarmaPendienteAjg = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.AlquilerAlarmaPendienteAjg, queryBase).Count();
                result.AlquilerAlarmaPendienteAcuerdo = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.AlquilerAlarmaPendienteAcuerdo, queryBase).Count();
                result.AlquilerAlarmaPendienteInstruccionesCliente = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.AlquilerAlarmaPendienteInstruccionesCliente, queryBase).Count();
                result.AlquilerAlarmaImpulsoPendienteAplicativoCliente = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.AlquilerAlarmaImpulsoPendienteAplicativoCliente, queryBase).Count();
                result.AlquilerAlarmaPdteFechaResolucionIncidencia = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.AlquilerAlarmaPdteFechaResolucionIncidencia, queryBase).Count();
                result.AlquilerAlarmaEjecutarDecretoFinSentencia = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.AlquilerAlarmaEjecutarDecretoFinSentencia, queryBase).Count();
            }

            #endregion

            #region Ejecutivo 

            if (filter.IdTipo1 == (int)TipoExpedienteEnum.Ejecutivo)
            {
                result.EjecutivoAlarmaRecepcionDemandaSellada = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.EjecutivoAlarmaRecepcionDemandaSellada, queryBase).Count();
                result.EjecutivoAlarmaAdmisionDemanda = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.EjecutivoAlarmaAdmisionDemanda, queryBase).Count();
                result.EjecutivoAlarmaRequerimientoPago = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.EjecutivoAlarmaRequerimientoPago, queryBase).Count();
                result.EjecutivoAlarmaAveriguacionPatrimonial = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.EjecutivoAlarmaAveriguacionPatrimonial, queryBase).Count();
                result.EjecutivoAlarmaMejoraEmbargo = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.EjecutivoAlarmaMejoraEmbargo, queryBase).Count();
                result.EjecutivoAlarmaDecretoEmbargo = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.EjecutivoAlarmaDecretoEmbargo, queryBase).Count();
                result.EjecutivoAlarmaProrrogaEmbargo = GetInmueblesByTipoIndicadorQa(TipoIndicadorQa.EjecutivoAlarmaProrrogaEmbargo, queryBaseInmueble).Count();
                result.EjecutivoAlarmaSucesionCopiaSellada = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.EjecutivoAlarmaSucesionCopiaSellada, queryBase).Count();
            }

            #endregion

            #region Negociacion

            if (filter.IdTipo1 == (int)TipoExpedienteEnum.Negociacion)
            {
                result.NegociacionAlarmaExpiradoTiempoNegAlquiler = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.NegociacionAlarmaExpiradoTiempoNegAlquiler).Count();
                result.NegociacionAlarmaExpiradoTiempoNegPrecontencioso = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.NegociacionAlarmaExpiradoTiempoNegPrecontencioso).Count();
            }

            #endregion

            #region Ordinario 

            if (filter.IdTipo1 == (int)TipoExpedienteEnum.Ordinario)
            {
                result.OrdinarioAlarmaPdteDemanda = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.OrdinarioAlarmaPdteDemanda).Count();
                result.OrdinarioAlarmaDecretoAdmision = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.OrdinarioAlarmaDecretoAdmision).Count();
                result.OrdinarioAlarmaEmplazamientoPositivo = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.OrdinarioAlarmaEmplazamientoPositivo).Count();
                result.OrdinarioAlarmaEmplazamientoNegativo = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.OrdinarioAlarmaEmplazamientoNegativo).Count();
                result.OrdinarioAlarmaAudienciaPrevia = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.OrdinarioAlarmaAudienciaPrevia).Count();
                result.OrdinarioAlarmaJuicio = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.OrdinarioAlarmaJuicio).Count();
                result.OrdinarioAlarmaSentencia = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.OrdinarioAlarmaSentencia).Count();
                result.OrdinarioAlarmaPdteSentencia = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.OrdinarioAlarmaPdteSentencia).Count();
                result.OrdinarioAlarmaRecepcionDemandaSellada = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.OrdinarioAlarmaRecepcionDemandaSellada).Count();
                result.OrdinarioAlarmaSucesionCopiaSellada = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.OrdinarioAlarmaSucesionCopiaSellada).Count();


            }

            #endregion

            #region OrdinarioCs 

            if (filter.IdTipo1 == (int)TipoExpedienteEnum.OrdinarioCs)
            {
                result.OrdinarioCsAlarmaVencimientoAllanamiento = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.OrdinarioCsAlarmaVencimientoAllanamiento).Count();
                result.OrdinarioCsAlarmaPendienteCopiaSelladaAllanamiento = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.OrdinarioCsAlarmaPendienteCopiaSelladaAllanamiento).Count();
                result.OrdinarioCsAlarmaSentencia = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.OrdinarioCsAlarmaSentencia).Count();
                result.OrdinarioCsAlarmaSentenciaSinCostasAbonadas = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.OrdinarioCsAlarmaSentenciaSinCostasAbonadas).Count();
                result.OrdinarioCsAlarmaPendienteFinalizacion = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.OrdinarioCsAlarmaPendienteFinalizacion).Count();
            }

            #endregion

            #region JV 

            if (filter.IdTipo1 == (int)TipoExpedienteEnum.JurisdiccionVoluntaria)
            {
                result.JvAlarmaPdteAdmision = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.JvAlarmaPdteAdmision).Count();
                result.JvAlarmaPdteLibradoMandamiento = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.JvAlarmaPdteLibradoMandamiento).Count();
                result.JvAlarmaPdteNotificacion = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.JvAlarmaPdteNotificacion).Count();
                result.JvAlarmaPdteRecepcionEscritura = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.JvAlarmaPdteRecepcionEscritura).Count();
                result.JvAlarmaRecepcionDemandaSellada = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.JvAlarmaRecepcionDemandaSellada).Count();
            }

            #endregion

            #region Monitorio 

            if (filter.IdTipo1 == (int)TipoExpedienteEnum.Monitorio)
            {
                result.MonitorioAlarmaRecepcionDemandaSellada = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.MonitorioAlarmaRecepcionDemandaSellada).Count();
                result.MonitorioAlarmaSucesionCopiaSellada = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.MonitorioAlarmaSucesionCopiaSellada).Count();
            }

            #endregion

            #region CyM / Concurso  

            if (filter.IdTipo1 == (int)TipoExpedienteEnum.Concurso)
            {
                //result.ConcursoAlarmaCumplidoHito01 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.ConcursoAlarmaCumplidoHito01, queryBase).Count();
                //result.ConcursoAlarmaCumplidoHito57 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.ConcursoAlarmaCumplidoHito57, queryBase).Count();
                //result.ConcursoAlarmaCumplidoHito14_18 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.ConcursoAlarmaCumplidoHito14_18, queryBase).Count();
                //result.ConcursoAlarmaCumplidoHito14_48 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.ConcursoAlarmaCumplidoHito14_48, queryBase).Count();
                //result.ConcursoAlarmaCumplidoHito73 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.ConcursoAlarmaCumplidoHito73, queryBase).Count();
                //result.ConcursoAlarmaCumplidoHito74 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.ConcursoAlarmaCumplidoHito74, queryBase).Count();

                result.ConcursoAlarmaProcedeFacturacion_01 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_01, queryBase).Count();
                result.ConcursoAlarmaProcedeFacturacion_57 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_57, queryBase).Count();
                result.ConcursoAlarmaProcedeFacturacion_14_18m = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_14_18m, queryBase).Count();
                result.ConcursoAlarmaProcedeFacturacion_14_48m = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_14_48m, queryBase).Count();
                result.ConcursoAlarmaProcedeFacturacion_74 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_74, queryBase).Count();
                result.ConcursoAlarmaProcedeFacturacion_78 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_78, queryBase).Count();
                result.ConcursoAlarmaProcedeFacturacion_79 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_79, queryBase).Count();


                result.ConcursoAlarmaProcedeFacturacion_73 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_73, queryBase).Count();
                result.ConcursoAlarmaProcedeFacturacion_52 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_52, queryBase).Count();
                result.ConcursoAlarmaProcedeFacturacion_54 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_54, queryBase).Count();
                result.ConcursoAlarmaProcedeFacturacion_55 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_55, queryBase).Count();
                result.ConcursoAlarmaProcedeFacturacion_56 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_56, queryBase).Count();
                result.ConcursoAlarmaProcedeFacturacion_63 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_63, queryBase).Count();
                result.ConcursoAlarmaProcedeFacturacion_64 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_64, queryBase).Count();
            }

            #endregion



            return result;
        }

        public IQueryable<Expediente> GetExpedienteByTipoIndicadorQa(TipoIndicadorQa tipoIndicadorQa, IQueryable<Expediente> queryBase = null)
        {
            //var queryModelExpedienteToKpi = _solvtioDbContext.GetModelExpedienteToKpi(1);

            //var lst = queryModelExpedienteToKpi.ToList();

            #region Variables

            var db = _solvtioDbContext;
            int[] arrInt;

            const int idTipoEstadoHipNegociacionPosesion = (int)ExpedienteEstadoTipo.HipotecarioNegociacionPosesion;
            var lstClientesBase1 = new List<int>
            {
                    27, //SAREB
                    44, //ALTAMIRA SANTANDER REAL ESTATE SA
                    54  //LLOGATALIA, S.L.
            };
            var lstResultadoPosesionPermitidas = new List<int>
            {
                    1, //Positiva
                    2, //Negativa - Prórroga Ley 1/13
                    3, //Negativa - Reconocido Arrendamiento
            };

            var lstExpedientesParalizado = db.Gnr_TipoEstado.AsNoTracking().Where(x => x.Paralizado).Select(x => x.IdTipoEstado);
            var lstExpedientesFinalizado = db.Gnr_TipoEstado.AsNoTracking().Where(x => x.Fin).Select(x => x.IdTipoEstado);
            var lstEstadosInicio = db.Gnr_TipoEstado.AsNoTracking().Where(x => x.Inicio).Select(x => x.IdTipoEstado);

            var lstClientesAlqFactPersonalizados = new List<int> {
                IdClienteAltamiraSantander,
                IdClienteLlogatalia,
                IdClienteLuri4,
                IdClienteLuri6
            };
            var lstAltamiraAlq = new List<int> { 92, 44, 55, 56 };
            var lstAnticipaAlq = new List<int> { 62, 71, 82, 105, 106, 107 };

            #endregion

            if (queryBase == null) queryBase = db.Expedientes.Include(x => x.Gnr_ClienteOficina);

            if (!tipoIndicadorQa.EsDeNegociacion())
                queryBase = queryBase.Where(x => !x.Paralizado);

            var queryBaseConParalizados = queryBase; // == null ? db.Expedientes.AsQueryable() : queryBase;

            if (tipoIndicadorQa.EsDeFacturacion())
                queryBase = queryBase.Where(x => !x.EsNofacturable && !x.FacturacionCompleta);

            switch (tipoIndicadorQa)
            {
                #region Facturas

                case TipoIndicadorQa.FacturaHito1:
                    return queryBase.Where(x => //x.IdTipoExpediente == IdTipoExpedienteHipotecario && 
                        x.ImpFacturableH1.HasValue
                        && x.FechaFacturableH1.HasValue
                        && x.FechaFacturableH1 < FechaActual
                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.Hito1 && f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito1 && f.HitoFacturacion != HitoFacturacionValue.AlquilerHito1)
                    );

                case TipoIndicadorQa.FacturaHito2:
                    return queryBase.Where(x => //x.IdTipoExpediente == IdTipoExpedienteHipotecario && 
                        x.ImpFacturableH2.HasValue
                        && x.FechaFacturableH2.HasValue
                        && x.FechaFacturableH2 < FechaActual
                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.Hito2 && f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito2 && f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
                    );

                case TipoIndicadorQa.FacturaHito3:
                    return queryBase.Where(x => //x.IdTipoExpediente == IdTipoExpedienteHipotecario && 
                        x.ImpFacturableH3.HasValue
                        && x.FechaFacturableH3.HasValue
                        && x.FechaFacturableH3 < FechaActual
                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.Hito3 && f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito3 && f.HitoFacturacion != HitoFacturacionValue.AlquilerHito3)
                    );

                case TipoIndicadorQa.FacturaHito4:
                    return queryBase.Where(x =>
                        x.ImpFacturableH4.HasValue
                        && x.FechaFacturableH4.HasValue
                        && x.FechaFacturableH4 < FechaActual
                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.Hito4 && f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito4)
                    );
                case TipoIndicadorQa.FacturaHito5:
                    return queryBase.Where(x =>
                        x.ImpFacturableH5.HasValue
                        && x.FechaFacturableH5.HasValue
                        && x.FechaFacturableH5 < FechaActual
                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.Hito5)
                    );
                case TipoIndicadorQa.FacturaHito6:
                    return queryBase.Where(x =>
                        x.ImpFacturableH6.HasValue
                        && x.FechaFacturableH6.HasValue
                        && x.FechaFacturableH6 < FechaActual
                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.Hito6)
                    );

                #endregion

                #region Hipotecario

                #region Hipotecario - Indicadores

                case TipoIndicadorQa.HipTestimonioPdteInscripcion:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.IdTipoEstadoLast == IdTipoEstadoHipAdjudicacion
                        && x.ExpedienteEstadoes.Any(ee =>
                            ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio.HasValue
                            && !ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion.HasValue
                        )
                    );

                case TipoIndicadorQa.HipotecarioInactivo:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.FechaModificacion < FechaActualMenos90
                        && x.IdTipoEstadoLast.HasValue
                        && lstExpedientesParalizado.All(y => y != x.IdTipoEstadoLast)
                        && lstExpedientesFinalizado.All(y => y != x.IdTipoEstadoLast)
                        && x.ExpedienteEstadoes.All(e => e.FechaAlta < FechaActualMenos60)
                        && x.ExpedienteNotaSet.All(e => e.Fecha < FechaActualMenos60)
                        && x.ImpulsoSet.All(e => e.Fecha < FechaActualMenos60)
                        && x.ActuacionSet.All(e => e.Fecha < FechaActualMenos60)
                    );
                case TipoIndicadorQa.HipotecarioIncidenciaDocumental:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoRecepcionExpediente
                        && x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                        && (
                            x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0102IncidenciaDocumental
                            || x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0104
                        )
                    );
                case TipoIndicadorQa.HipotecarioEnRevisionNoVeniados:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && !x.EsHeredado
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoRecepcionExpediente
                        && (
                            !x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                            || x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0101RecepcionRevision
                        )
                    );
                case TipoIndicadorQa.HipotecarioEnRevisionVeniados:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.EsHeredado
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoRecepcionExpediente
                        && (
                            !x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                            || x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0101RecepcionRevision
                        )
                    );

                case TipoIndicadorQa.HipotecarioJurisdiccionVoluntaria:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && x.ExpedienteEstadoLast != null
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipJurisdiccionVoluntaria
                    //&& (
                    //    !x.ExpedienteEscrituraSet.Any()
                    ////|| x.ExpedienteEscrituraSet.Any(y => !y.FechaRecepcion.HasValue)
                    //)
                    //&& x.ExpedienteJurisdiccionVoluntaria != null
                    //&& !x.ExpedienteJurisdiccionVoluntaria.FechaRecepcionEscritura.HasValue
                    );
                case TipoIndicadorQa.HipotecarioAutosIncompletoErroneo:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
                        && x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0302
                    );

                case TipoIndicadorQa.HipotecarioPendientePreparacionDemanda:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast != null
                        && (
                            (
                                x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoRecepcionExpediente
                                && x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0103PreparacionDemanda
                            )
                            ||
                                x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipGeneracionExpediente
                            ||
                            (
                                x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipPresentDemanda
                                && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoPresentacionDemanda != null
                                && !x.ExpedienteEstadoLast.Hip_ExpedienteEstadoPresentacionDemanda.FechaEnvioProcurador.HasValue
                            )
                        ));

                case TipoIndicadorQa.HipotecarioPendientePresentacionDemanda:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast != null
                        && (
                            x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoRecepcionExpediente
                            ||
                                x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipGeneracionExpediente
                            ||
                            (
                                x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipPresentDemanda
                                && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoPresentacionDemanda != null
                                && !x.ExpedienteEstadoLast.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
                            )
                        ));

                case TipoIndicadorQa.HipotecarioPendienteDemandaAdmitida:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.ExpedienteEstadoLast != null
                        && (
                            x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
                            && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
                            && (
                                !x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                                || LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
                            )
                            && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta != null
                            && !x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.AdmitidaFecha.HasValue
                        ) || (
                           x.IdTipoEstadoLast == IdTipoEstadoHipPresentDemanda
                           && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoPresentacionDemanda != null
                           && !x.ExpedienteEstadoLast.Hip_ExpedienteEstadoPresentacionDemanda.NoAdmitidaFecha.HasValue
                           && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
                        )
                    );

                case TipoIndicadorQa.HipotecarioPendienteCertificacionCargas:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
                        && (
                            !x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                        || LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
                        )
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta != null
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.AdmitidaFecha.HasValue
                        && !x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.FechaCertificacionCargas.HasValue
                    );

                case TipoIndicadorQa.HipotecarioPendienteRequerimientoPago:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
                        && (
                            !x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                            || LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
                        )
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta != null
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.FechaCertificacionCargas.HasValue
                        && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoDatoRequerimiento.Any(y => !y.Positivo)
                    );

                case TipoIndicadorQa.HipotecarioPendienteNotificacion:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
                        && (
                            !x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                            || LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
                        )
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta != null
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.FechaCertificacionCargas.HasValue
                        && !x.ExpedienteEstadoLast.Hip_ExpedienteEstadoDatoRequerimiento.Any()
                    );

                case TipoIndicadorQa.HipotecarioPendienteSolicitarSubasta:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
                        && (
                            !x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                            || LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
                        )
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta != null
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.FechaCertificacionCargas.HasValue
                        && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoDatoRequerimiento.All(y => y.Positivo)
                        //&& x.ExpedienteSubastaSet.All(s => s.IdMotivoSuspension.HasValue)
                        && (
                            !x.IdExpedienteSubastaLast.HasValue
                            || x.ExpedienteSubastaLast.IdMotivoSuspension.HasValue
                        )
                    //&& !x.ExpedienteSubastaSet.Any()
                    );

                case TipoIndicadorQa.HipotecarioPendienteConvocatoriaSubasta:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
                        //&& x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                        && !LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
                        && x.IdExpedienteSubastaLast.HasValue
                        && !x.ExpedienteSubastaLast.FechaDecretoSubasta.HasValue
                        && !x.ExpedienteSubastaLast.FechaCelebracion.HasValue
                    );

                case TipoIndicadorQa.HipotecarioPendienteSuspensionDecreto:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
                        && x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                        && !LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
                        && x.IdExpedienteSubastaLast.HasValue
                        && x.ExpedienteSubastaLast.IdMotivoSuspensionDecretoSubasta.HasValue
                    );

                case TipoIndicadorQa.HipotecarioPendienteSubastasSuspendidas:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
                        && x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                        && !LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
                        && x.IdExpedienteSubastaLast.HasValue
                        && x.ExpedienteSubastaLast.IdMotivoSuspension.HasValue
                    );

                case TipoIndicadorQa.HipotecarioPendienteAdjudicacion:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
                        && x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                        && !LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta != null
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.PostSubastaFechaSolicitudAdjudicacion.HasValue
                    );

                case TipoIndicadorQa.HipotecarioDecretoConvocatoriaSubasta:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
                        && x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                        && !LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
                        && x.IdExpedienteSubastaLast.HasValue
                        && x.ExpedienteSubastaLast.FechaDecretoSubasta.HasValue
                        && !x.ExpedienteSubastaLast.FechaCelebracion.HasValue
                        && !x.ExpedienteSubastaLast.IdMotivoSuspension.HasValue
                        && !x.ExpedienteSubastaLast.IdMotivoSuspensionDecretoSubasta.HasValue
                    );

                case TipoIndicadorQa.HipotecarioIncidenciaDecretoAjdudicacion:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.IdTipoEstadoLast == IdTipoEstadoHipAdjudicacion
                        && x.ExpedienteEstadoes.Any(e =>
                            e.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
                            && e.HipExpedienteEstadoTramitacionSubasta != null
                            && (
                                e.HipExpedienteEstadoTramitacionSubasta.PostSubastaCesion == SubastaCesionType.Pendiente
                                || e.HipExpedienteEstadoTramitacionSubasta.IdPostSubastaEstadoConsignacion == 1
                                || e.HipExpedienteEstadoTramitacionSubasta.IdPostSubastaEstadoIndicenciaDecreto == 1
                                || e.HipExpedienteEstadoTramitacionSubasta.PostSubastaAdjudicacionTercero
                            )
                        )
                    );

                case TipoIndicadorQa.HipotecarioPendienteTestimonioAdjudicacion:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.IdTipoEstadoLast == IdTipoEstadoHipAdjudicacion
                        && x.ExpedienteEstadoes.Any(ee =>
                            ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaAdjudicacion.HasValue
                            && !ee.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio.HasValue
                        )
                    );

                case TipoIndicadorQa.HipotecarioPendienteSolicitudPosesion:
                    return queryBase.Where(x => x.IdTipoExpediente == 1
                        && x.IdTipoEstadoLast == IdTipoEstadoHipAdjudicacion
                        && x.ExpedienteEstadoes.Any(ee =>
                            ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio.HasValue
                            && !ee.Hip_ExpedienteEstadoAdjudicacion.FechaSolicitudPosesion.HasValue
                            && !ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion.HasValue
                        ));

                case TipoIndicadorQa.HipotecarioPendienteLanzamiento:
                    int idTipoVistaLanzamiento = (int)TipoVistaEnum.HipotecarioLanzamiento;
                    //int idTipoVistaPosesion = (int)TipoVistaEnum.HipotecarioPosesion;
                    int idMotivoSuspReconocidoArrendamiento = 76; //Reconocido Arrendamiento
                    int idMotivoSuspAcuerdoFormalizado = 77; //Acuerdo Formalizado
                    int idMotivoSuspLey1_2013 = 3; //Ley 1/2013

                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                        && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion != null
                        && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio.HasValue
                        && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaSolicitudPosesion.HasValue
                        && !x.ExpedienteVistas.Any(ev => ev.IdTipoVista == idTipoVistaLanzamiento
                            && (
                                ev.Resultado == PositivoNegativoType.Positivo
                                || ev.IdMotivoSuspension == idMotivoSuspReconocidoArrendamiento
                                || ev.IdMotivoSuspension == idMotivoSuspAcuerdoFormalizado
                                || ev.IdMotivoSuspension == idMotivoSuspLey1_2013
                               )
                        ));


                //&& x.ExpedienteVistas.Any(ev =>
                //    ev.IdTipoVista == idTipoVistaPosesion
                //    && ev.Resultado != PositivoNegativoType.Negativo
                //    && ev.IdMotivoSuspension != idMotivoSuspReconocidoArrendamiento
                //));

                //return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                //    && x.IdTipoEstadoLast == IdTipoEstadoHipAdjudicacion
                //    && !x.ExpedienteVistas.Any(ev => ev.IdTipoVista == idTipoVistaLanzamiento)
                //    && x.ExpedienteVistas.Any(ev =>
                //        ev.IdTipoVista == idTipoVistaPosesion
                //        && ev.Resultado != PositivoNegativoType.Negativo
                //        && ev.IdMotivoSuspension != idMotivoSuspReconocidoArrendamiento
                //    ));

                //&& x.ExpedienteEstadoes.Any(ee =>
                //    ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                //    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion.HasValue
                //    && !ee.Hip_ExpedienteEstadoAdjudicacion.FechaLanzamiento.HasValue
                //    && ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion != 1 //positivo
                //    && ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion != 3 //Negativa - Reconocido Arrendamiento
                //));

                case TipoIndicadorQa.HipotecarioPendienteNegociacionPosesion:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.IdClienteOficina == 8 //Bankia
                        && x.IdTipoEstadoLast == IdTipoEstadoHipAdjudicacion
                    //&& !x.ExpedienteNegociacion.IdGestorContencioso.HasValue
                    );

                //return queryBase.Where(x =>
                //    (!x.IdExpedienteNegociacion.HasValue || (
                //         !x.ExpedienteNegociacion.IdGestor.HasValue
                //         && !x.ExpedienteNegociacion.PrecontenciosoFechaFin.HasValue
                //     ))
                //    && x.IdTipoExpediente == IdTipoExpedienteAlquiler
                //    && lstEstadosInicio.Any(e => e == x.IdTipoEstadoLast)
                //    && LstAlqClientes.Any(c => c == x.Gnr_ClienteOficina.IdCliente)
                //);

                case TipoIndicadorQa.HipotecarioPendienteTestimoniosInscripcion:
                    break;
                case TipoIndicadorQa.HipotecarioPendienteAdjudicacionLey12013:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.IdTipoEstadoLast == IdTipoEstadoHipAdjudicacion
                        && x.ExpedienteEstadoes.Any(ee =>
                            ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                            && !ee.FechaFin.HasValue
                            && ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion == 2 // Negativa - Prórroga Ley 1/13
                        ));

                case TipoIndicadorQa.HipotecarioCalificacionNegativa:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                            && x.IdEstadoLast.HasValue
                                            && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                                            && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion != null
                                            && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio.HasValue
                                            && !x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion.HasValue
                                            && (
                                                x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaActaSituacionArrendaticia
                                                || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaInscripcionCredito
                                                || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaOtro
                                                || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaOmisionImputacionPagos654
                                                || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaDefectosImpultacion654
                                                || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaIndenciaImportesAdjudicacion
                                                || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaExcesoResponsabilidadHip
                                                || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaDefectosNotificaciones
                                                || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaCargasPrevias
                                                || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaInstanciasConfusionDerechos
                                                || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaCargasUrbanisticas
                                                || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaLimitacionesLibreDisposición
                                                || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaIbisPendientes
                                                || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaDeudasComunidadPropietario
                                                || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaDerechosTanteoRetracto
                                                || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaDefectosMandamientosCancelacion
                                                || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaPteCancelacionNotaMarginal
                                            )
                                         );

                case TipoIndicadorQa.HipotecarioLiquidacionItp:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                        && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion != null
                        && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio.HasValue
                        && !x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.LiquidacionITP
                    );

                #endregion

                #region Hipotecario - Alarmas

                case TipoIndicadorQa.HipotecarioAlarmaIncidentados:
                    var lstSubfases = new List<int> { 1010102, 1010104 };

                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoRecepcionExpediente
                        && x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                        && lstSubfases.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
                        && x.ExpedienteEstadoLast.Fecha < FechaActualMenos30
                    );

                case TipoIndicadorQa.HipotecarioAlarmaAdmisionDemanda:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && !x.EsHeredado
                        && x.IdTipoEstadoLast == IdTipoEstadoHipPresentDemanda
                        && x.ExpedienteEstadoes.Any(ee =>
                            ee.IdTipoEstado == IdTipoEstadoHipPresentDemanda
                            && !ee.FechaFin.HasValue
                            && !ee.Hip_ExpedienteEstadoPresentacionDemanda.NoAdmitidaFecha.HasValue
                            && ee.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
                            && ee.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion < FechaActualMenos80
                        ));

                case TipoIndicadorQa.HipotecarioAlarmaInadmisionDemanda:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.IdTipoEstadoLast == IdTipoEstadoHipPresentDemanda
                        && x.ExpedienteEstadoes.Any(ee =>
                            ee.IdTipoEstado == IdTipoEstadoHipPresentDemanda
                            && !ee.FechaFin.HasValue
                            && ee.Hip_ExpedienteEstadoPresentacionDemanda.NoAdmitidaFecha.HasValue
                            && !ee.Hip_ExpedienteEstadoPresentacionDemanda.NoAdmitidaFechaApelacion.HasValue
                            && ee.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
                            && ee.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion < FechaActualMenos80
                        ));

                case TipoIndicadorQa.HipotecarioAlarmaSucesionCopiaSellada:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && !x.Fin.HasValue
                        && !x.SucesionCopiaSellada.HasValue
                        && x.SucesionPresentada.HasValue
                        && x.SucesionPresentada < FechaActualMenos2
                    );

                case TipoIndicadorQa.HipotecarioAlarmaCertificacionCargas:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
                        && (
                            !x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                            || LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
                        )
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta != null
                        && !x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.FechaCertificacionCargas.HasValue
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.AdmitidaFecha.HasValue
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.AdmitidaFecha < FechaActualMenos90
                    );

                case TipoIndicadorQa.HipotecarioAlarmaRequerimientoPago:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
                        && (
                            !x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                            || LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
                        )
                        && x.ExpedienteDeudors.Any(ed => !ed.RequerimientoPagoPositivo)
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta != null
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.AdmitidaFecha.HasValue
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.AdmitidaFecha < FechaActualMenos150
                    );

                case TipoIndicadorQa.HipotecarioAlarmaSolicitudSubasta:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
                        && (
                            !x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                            || LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
                        )
                        && (
                            !x.IdExpedienteSubastaLast.HasValue
                            || x.ExpedienteSubastaLast.IdMotivoSuspension.HasValue
                        )
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta != null
                        && !x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.Oposicion
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.FechaCertificacionCargas.HasValue
                        && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoDatoRequerimiento.Any()
                        && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoDatoRequerimiento.All(r =>
                            r.Positivo
                            && r.FechaRequerimientoPago.HasValue
                            && r.FechaRequerimientoPago < FechaActualMenos20)
                    );

                case TipoIndicadorQa.HipotecarioAlarmaDecretoConvocatoria:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
                        && x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                        && !LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
                        && x.IdExpedienteSubastaLast.HasValue
                        && x.ExpedienteSubastaLast != null
                        && !x.ExpedienteSubastaLast.IdMotivoSuspension.HasValue
                        && !x.ExpedienteSubastaLast.FechaCelebracion.HasValue
                        && !x.ExpedienteSubastaLast.IdMotivoSuspensionDecretoSubasta.HasValue
                        && x.ExpedienteSubastaLast.FechaDecretoSubasta.HasValue
                        && x.ExpedienteSubastaLast.FechaDecretoSubasta < FechaActualMenos80
                    );

                case TipoIndicadorQa.HipotecarioAlarmaDecretoAdjudicacion:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
                        && x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                        && !LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
                        && x.IdExpedienteSubastaLast.HasValue
                        && x.ExpedienteSubastaLast != null
                        && !x.ExpedienteSubastaLast.IdMotivoSuspension.HasValue
                        && x.ExpedienteSubastaLast.FechaCelebracion.HasValue
                        && x.ExpedienteSubastaLast.FechaCelebracion < FechaActualMenos80
                    );

                case TipoIndicadorQa.HipotecarioAlarmaPosesion:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                        && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion != null
                        && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaAdjudicacion.HasValue
                        && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaAdjudicacion < FechaActualMenos200
                        && !x.Hip_Inmueble.Any(i =>
                            i.Ley12013 || i.ReconocidoArrendamiento || i.AcuerdoFormalizado || i.InstruccionGestores || i.RecuperadaPosesionJudicial
                        )
                        && (
                            x.Hip_Inmueble.Count == 0
                            || !x.Hip_Inmueble.Any(i => i.Ley12013 || i.ReconocidoArrendamiento || i.AcuerdoFormalizado || i.InstruccionGestores || i.RecuperadaPosesionJudicial)
                        )
                        && (
                            x.ExpedienteVistas.Count == 0
                            || !x.ExpedienteVistas.Any(v => v.Resultado == PositivoNegativoType.Positivo)
                        )
                    );

                case TipoIndicadorQa.HipotecarioAlarmaTestimonio:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                        && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion != null
                        && !x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion.HasValue
                        && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio.HasValue
                        && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio < FechaActualMenos120
                    );

                case TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre01:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipGeneracionExpediente
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion != null
                        && !x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.TituloEjecutivoFechaObtencion.HasValue
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.TituloEjecutivoFechaSolicitud.HasValue
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.TituloEjecutivoFechaSolicitud < FechaActualMenos30
                    );

                case TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre02:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipGeneracionExpediente
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion != null
                        && !x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.BuroFax30FechaObtencion.HasValue
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.BuroFax30FechaSolicitud.HasValue
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.BuroFax30FechaSolicitud < FechaActualMenos3
                    );

                case TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre05:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipGeneracionExpediente
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion != null
                        && !x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.BuroFax10FechaObtencion.HasValue
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.BuroFax10FechaSolicitud.HasValue
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.BuroFax10FechaSolicitud < FechaActualMenos5
                    );

                case TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre03:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipGeneracionExpediente
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion != null
                        && !x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.LiquidacionFechaObtencion.HasValue
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.LiquidacionFechaSolicitud.HasValue
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.LiquidacionFechaSolicitud < FechaActualMenos33
                    );

                case TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre04:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipGeneracionExpediente
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion != null
                        && !x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.CertificadoFechaObtencion.HasValue
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.CertificadoFechaSolicitud.HasValue
                        && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.CertificadoFechaSolicitud < FechaActualMenos15
                    );

                #endregion

                #region Hipotecario - Facturas

                #region Hipotecario - Facturas - Solvia





                case TipoIndicadorQa.HipotecarioFacturaSolviaHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && LstOficinasSolvia.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito1 && f.HitoFacturacion != HitoFacturacionValue.Hito1)
                                                && x.ExpedienteEstadoes.Any(ee =>
                                                    ee.IdTipoEstado == IdTipoEstadoHipPresentDemanda
                                                    && ee.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
                                                    && ee.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion <= FechaActual
                                                ));

                case TipoIndicadorQa.HipotecarioFacturaSolviaHito2:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && LstOficinasSolvia.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito2 && f.HitoFacturacion != HitoFacturacionValue.Hito2)
                                                && x.ExpedienteEstadoes.Any(ee =>
                                                    ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaAdjudicacion.HasValue
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaAdjudicacion <= FechaActual
                                                ));

                case TipoIndicadorQa.HipotecarioFacturaSolviaHito3:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && LstOficinasSolvia.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito3)
                                                && x.ExpedienteEstadoes.Any(ee =>
                                                    ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                                                    && (
                                                        ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion == 1
                                                        || ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion == 3
                                                    )
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion.HasValue
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion <= FechaActual
                                                ));

                case TipoIndicadorQa.HipotecarioFacturaSolviaHito4:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && LstOficinasSolvia.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito4)
                                                && x.ExpedienteEstadoes.Any(ee =>
                                                    ee.IdTipoEstado == IdTipoEstadoHipFinalizado
                                                    && ee.Hip_ExpedienteEstadoFinalizacion != null
                                                    && ee.Fecha <= FechaActual
                                                ));

                #endregion

                #region Hipotecario - Facturas - Sabadel

                case TipoIndicadorQa.HipotecarioFacturaSabadellHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && LstOficinasSabadel.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito1 && f.HitoFacturacion != HitoFacturacionValue.Hito1)
                                                && x.IdExpedienteSubastaLast.HasValue
                                                && !x.ExpedienteSubastaLast.IdMotivoSuspension.HasValue
                                                && x.ExpedienteSubastaLast.FechaCelebracion.HasValue
                                                && x.ExpedienteSubastaLast.FechaCelebracion <= FechaActual
                                                );
                case TipoIndicadorQa.HipotecarioFacturaSabadellHito2:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && LstOficinasSabadel.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito2 && f.HitoFacturacion != HitoFacturacionValue.Hito2)
                                                && x.ExpedienteEstadoes.Any(ee =>
                                                    ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion != null
                                                    && lstResultadoPosesionPermitidas.Any(r => r == ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion)
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion.HasValue
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion <= FechaActual
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion.HasValue
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion <= FechaActual
                                                ));

                case TipoIndicadorQa.HipotecarioFacturaSabadellHito3:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && LstOficinasSabadel.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito2 && f.HitoFacturacion != HitoFacturacionValue.Hito2)
                                                && x.ExpedienteEstadoes.Any(ee =>
                                                    ee.IdTipoEstado == IdTipoEstadoHipFinalizado
                                                    && ee.Hip_ExpedienteEstadoFinalizacion != null
                                                    && ee.Fecha <= FechaActual
                                                ));
                #endregion

                #region Hipotecario - Facturas - Anticipa / Sareb / PostEjc

                case TipoIndicadorQa.HipotecarioFacturaAnticipaHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && LstOficinasAnticipa.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito1 && f.HitoFacturacion != HitoFacturacionValue.Hito1)
                                                && x.ExpedienteEstadoes.Any(ee =>
                                                    ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion != null
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaAdjudicacion.HasValue
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaAdjudicacion <= FechaActual
                                                ));
                case TipoIndicadorQa.HipotecarioFacturaAnticipaHito2:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && LstOficinasAnticipa.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito2 && f.HitoFacturacion != HitoFacturacionValue.Hito2)
                                                && x.ExpedienteEstadoes.Any(ee =>
                                                    ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion != null
                                                    && lstResultadoPosesionPermitidas.Any(r => r == ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion)
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion.HasValue
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion <= FechaActual
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion.HasValue
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion <= FechaActual
                                                ));

                case TipoIndicadorQa.HipotecarioFacturaSarebHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && LstOficinasSareb.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito1 && f.HitoFacturacion != HitoFacturacionValue.Hito1)
                                                && x.ExpedienteEstadoes.Any(ee =>
                                                    ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion != null
                                                    && lstResultadoPosesionPermitidas.Any(r => r == ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion)
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion.HasValue
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion <= FechaActual
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion.HasValue
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion <= FechaActual
                                                ));
                case TipoIndicadorQa.HipotecarioFacturaSarebHito2:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && LstOficinasSareb.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito2 && f.HitoFacturacion != HitoFacturacionValue.Hito2)
                                                && x.ExpedienteEstadoes.Any(ee =>
                                                    ee.IdTipoEstado == IdTipoEstadoHipFinalizado
                                                    && ee.Hip_ExpedienteEstadoFinalizacion != null
                                                    && ee.Fecha <= FechaActual
                                                ));
                case TipoIndicadorQa.HipotecarioFacturaPostEjcHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && LstHipOficinasPostEjc.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito1 && f.HitoFacturacion != HitoFacturacionValue.Hito1)
                                                && x.ExpedienteEstadoes.Any(ee =>
                                                    ee.IdTipoEstado == IdTipoEstadoHipFinalizado
                                                    && ee.Hip_ExpedienteEstadoFinalizacion != null
                                                    && ee.Fecha <= FechaActual
                                                ));
                #endregion

                #region Hipotecario - Facturas - Bankia

                case TipoIndicadorQa.HipotecarioFacturaBankiaHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && LstHipOficinasBankia.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito1 && f.HitoFacturacion != HitoFacturacionValue.Hito1)
                                                && x.IdExpedienteSubastaLast.HasValue
                                                && !x.ExpedienteSubastaLast.IdMotivoSuspension.HasValue
                                                && x.ExpedienteSubastaLast.FechaCelebracion.HasValue
                                                && x.ExpedienteSubastaLast.FechaCelebracion <= FechaActual
                    );
                case TipoIndicadorQa.HipotecarioFacturaBankiaHito2a:
                    return queryBase
                        .Include(x => x.ExpedienteEstadoLast.Hip_ExpedienteEstadoFinalizacion.Gnr_TipoEstadoMotivo)
                        .Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && LstHipOficinasBankia.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito2)
                                                && x.ExpedienteEstadoes.Any(ee =>
                                                    ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion != null
                                                    && lstResultadoPosesionPermitidas.Any(r => r == ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion)
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion.HasValue
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion <= FechaActual
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion.HasValue
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion <= FechaActual
                                                ));

                case TipoIndicadorQa.HipotecarioFacturaBankiaHito2b:
                    return queryBase
                        .Include(x => x.ExpedienteEstadoLast.Hip_ExpedienteEstadoFinalizacion.Gnr_TipoEstadoMotivo)
                        .Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && LstHipOficinasBankia.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito2 && f.HitoFacturacion != HitoFacturacionValue.Hito2)
                                                && x.ExpedienteEstadoes.Any(ee =>
                                                    ee.IdTipoEstado == IdTipoEstadoHipFinalizado
                                                    && ee.Hip_ExpedienteEstadoFinalizacion != null
                                                    && ee.Fecha <= FechaActual
                                                ));
                #endregion

                #region Hipotecario - Facturas - Aliseda

                case TipoIndicadorQa.HipotecarioFacturaAlisedaNoVeniadoHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && !x.EsHeredado
                                                && !x.FacturacionCompleta && !x.EsNofacturable
                                                && LstHipOficinasAliseda.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito1 && f.HitoFacturacion != HitoFacturacionValue.Hito1)
                                                && x.ExpedienteEstadoes.Any(ee =>
                                                    ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion != null
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaAdjudicacion.HasValue
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaAdjudicacion <= FechaActual
                                                ));
                case TipoIndicadorQa.HipotecarioFacturaAlisedaVeniadoHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && x.EsHeredado
                                                && LstHipOficinasAliseda.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito1 && f.HitoFacturacion != HitoFacturacionValue.Hito1)
                                                && x.FechaCargaAppCliente.HasValue);

                case TipoIndicadorQa.HipotecarioFacturaAlisedaNoVeniadoHito2:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && !x.EsHeredado
                                                && LstHipOficinasAliseda.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito2 && f.HitoFacturacion != HitoFacturacionValue.Hito2)
                                                && x.ExpedienteEstadoes.Any(ee =>
                                                    ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion != null
                                                    && lstResultadoPosesionPermitidas.Any(r => r == ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion)
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion.HasValue
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion <= FechaActual
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion.HasValue
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion <= FechaActual
                                                ));
                case TipoIndicadorQa.HipotecarioFacturaAlisedaVeniadoHito2:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && x.EsHeredado
                                                && LstHipOficinasAliseda.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito2 && f.HitoFacturacion != HitoFacturacionValue.Hito2)
                                                && x.ExpedienteEstadoes.Any(ee =>
                                                    ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion != null
                                                    && lstResultadoPosesionPermitidas.Any(r => r == ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion)
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion.HasValue
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion <= FechaActual
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion.HasValue
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion <= FechaActual
                                                ));

                case TipoIndicadorQa.HipotecarioFacturaAlisedaNoVeniadoFinalizadosPdteFacturar:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && !x.EsHeredado
                                                && x.Fin.HasValue
                                                && LstHipOficinasAliseda.Any(y => y == x.IdClienteOficina)
                                                && (
                                                    !x.FacturaSet.Any(f => f.HitoFacturacion == HitoFacturacionValue.HipotecarioHito1)
                                                    || !x.FacturaSet.Any(f => f.HitoFacturacion == HitoFacturacionValue.HipotecarioHito2)
                                                ));
                case TipoIndicadorQa.HipotecarioFacturaAlisedaVeniadoFinalizadosPdteFacturar:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && x.EsHeredado
                                                && x.Fin.HasValue
                                                && LstHipOficinasAliseda.Any(y => y == x.IdClienteOficina)
                                                && (
                                                    !x.FacturaSet.Any(f => f.HitoFacturacion == HitoFacturacionValue.HipotecarioHito1)
                                                    || !x.FacturaSet.Any(f => f.HitoFacturacion == HitoFacturacionValue.HipotecarioHito2)
                                                ));

                #endregion

                #region Hipotecario - Facturas - Abanca

                case TipoIndicadorQa.HipotecarioFacturaAbancaHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && LstHipOficinasAbanca.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito1 && f.HitoFacturacion != HitoFacturacionValue.Hito1)
                                                && x.ExpedienteEstadoes.Any(ee =>
                                                    ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion != null
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio.HasValue
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio <= FechaActual
                                                ));
                case TipoIndicadorQa.HipotecarioFacturaAbancaHito2:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && LstHipOficinasAbanca.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito2 && f.HitoFacturacion != HitoFacturacionValue.Hito2)
                                                && x.ExpedienteEstadoes.Any(ee =>
                                                    ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion != null
                                                    && lstResultadoPosesionPermitidas.Any(r => r == ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion)
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion.HasValue
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion <= FechaActual
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion.HasValue
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion <= FechaActual
                                                ));

                case TipoIndicadorQa.HipotecarioFacturaAbancaHito3:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && LstHipOficinasAbanca.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito3)
                                                && x.ExpedienteEstadoes.Any(ee =>
                                                    ee.IdTipoEstado == IdTipoEstadoHipFinalizado
                                                    && ee.Hip_ExpedienteEstadoFinalizacion != null
                                                    && ee.Fecha <= FechaActual
                                                ));
                #endregion

                #region Hipotecario - Facturas - VoyagerAltamira

                case TipoIndicadorQa.HipotecarioFacturaVoyagerAltamiraNoVeniadoHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && !x.EsHeredado
                                                && LstHipOficinasVoyagerAltamira.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito1 && f.HitoFacturacion != HitoFacturacionValue.Hito1)
                                                && x.ExpedienteEstadoes.Any(ee =>
                                                    ee.IdTipoEstado == IdTipoEstadoHipPresentDemanda
                                                    && ee.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
                                                    && ee.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion <= FechaActual
                                                ));

                case TipoIndicadorQa.HipotecarioFacturaVoyagerAltamiraNoVeniadoHito2:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && !x.EsHeredado
                                                && LstHipOficinasVoyagerAltamira.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito2 && f.HitoFacturacion != HitoFacturacionValue.Hito2)
                                                && x.IdExpedienteSubastaLast.HasValue
                                                && !x.ExpedienteSubastaLast.IdMotivoSuspension.HasValue
                                                && x.ExpedienteSubastaLast.FechaCelebracion.HasValue
                                                && x.ExpedienteSubastaLast.FechaCelebracion <= FechaActual
                                                );

                case TipoIndicadorQa.HipotecarioFacturaVoyagerAltamiraNoVeniadoHitoFinalizacion:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && !x.EsHeredado
                                                && LstHipOficinasVoyagerAltamira.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito4)
                                                && x.ExpedienteEstadoes.Any(ee =>
                                                    ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion != null
                                                    && lstResultadoPosesionPermitidas.Any(r => r == ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion)
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion.HasValue
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion <= FechaActual
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion.HasValue
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion <= FechaActual
                                                ));

                case TipoIndicadorQa.HipotecarioFacturaVoyagerAltamiraVeniadoHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && x.EsHeredado
                                                && LstHipOficinasVoyagerAltamira.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito1 && f.HitoFacturacion != HitoFacturacionValue.Hito1)
                                                && x.IdExpedienteSubastaLast.HasValue
                                                && !x.ExpedienteSubastaLast.IdMotivoSuspension.HasValue
                                                && x.ExpedienteSubastaLast.FechaCelebracion.HasValue
                                                && x.ExpedienteSubastaLast.FechaCelebracion <= FechaActual
                                                );

                case TipoIndicadorQa.HipotecarioFacturaVoyagerAltamiraVeniadoHitoFinalizacion:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && x.EsHeredado
                                                && LstHipOficinasVoyagerAltamira.Any(y => y == x.IdClienteOficina)
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito4)
                                                && x.ExpedienteEstadoes.Any(ee =>
                                                    ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion != null
                                                    && lstResultadoPosesionPermitidas.Any(r => r == ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion)
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion.HasValue
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion <= FechaActual
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion.HasValue
                                                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion <= FechaActual
                                                ));

                #endregion

                #region Otros

                //result. = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioFinalizadoSinFactura).Count();
                case TipoIndicadorQa.HipotecarioFinalizadoSinFactura:
                    return queryBase.Where(x =>
                        x.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && !x.EsHeredado
                        && !x.FacturacionCompleta
                        && x.Fin.HasValue
                        && !x.FacturaSet.Any()
                    );

                case TipoIndicadorQa.AlquilerFinalizadoSinFactura:
                    return queryBase.Where(x =>
                        x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && !x.EsHeredado
                        && !x.FacturacionCompleta
                        && x.Fin.HasValue
                        && !x.FacturaSet.Any()
                    );

                case TipoIndicadorQa.OrdinarioFinalizadoSinFactura:
                    return queryBase.Where(x =>
                        x.IdTipoExpediente == IdTipoExpedienteOrdinario
                        && !x.EsHeredado
                        && !x.FacturacionCompleta
                        && x.Fin.HasValue
                        && !x.FacturaSet.Any()
                    );

                case TipoIndicadorQa.EjecutivoFinalizadoSinFactura:
                    return queryBase.Where(x =>
                        x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                        && !x.EsHeredado
                        && !x.FacturacionCompleta
                        && x.Fin.HasValue
                        && !x.FacturaSet.Any()
                    );

                #endregion

                #endregion

                #region Hipotecario - SLA

                #region Hipotecario - SLA - PresentacionDemanda

                case TipoIndicadorQa.HipotecarioSlaPresentacionDemandaBankia:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && LstHipOficinasBankia.Any(y => y == x.IdClienteOficina)
                                                && !x.ExpedienteEstadoes.Any(ee => ee.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue)
                                                && !x.Fin.HasValue
                                                && !x.Paralizado
                    );

                #endregion

                #endregion

                #region Hipotecario - QaDatos

                case TipoIndicadorQa.ExpHipQaDatosSinInmueble:
                    var lstTipoEstadoPosibles = new List<int> { IdTipoEstadoHipPresentDemanda, IdTipoEstadoHipTramitacionSubasta, IdTipoEstadoHipAdjudicacion };
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && !x.Fin.HasValue
                                                && !x.Paralizado
                                                && x.IdEstadoLast.HasValue
                                                && lstTipoEstadoPosibles.Contains(x.ExpedienteEstadoLast.IdTipoEstado)
                                                && !x.Hip_Inmueble.Any()

                    );

                case TipoIndicadorQa.ExpHipQaDatosSinPartidoJudicial:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && !x.Fin.HasValue
                                                && !x.Paralizado
                                                && x.ExpedienteEstadoLast != null
                                                && x.ExpedienteEstadoLast.IdTipoEstado >= IdTipoEstadoHipTramitacionSubasta
                                                && !x.IdPartidoJudicial.HasValue

                    );

                case TipoIndicadorQa.ExpHipQaDatosSinNoAuto:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && !x.Fin.HasValue
                                                && !x.Paralizado
                                                && x.ExpedienteEstadoLast != null
                                                && x.ExpedienteEstadoLast.IdTipoEstado >= IdTipoEstadoHipTramitacionSubasta
                                                && (x.NoAuto == null || x.NoAuto == "")
                                                && x.ExpedienteEstadoLast.IdTipoEstado != IdTipoEstadoHipJurisdiccionVoluntaria
                    );



                case TipoIndicadorQa.ExpHipQaDatosSinFechaDemanda:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && !x.Fin.HasValue
                                                && !x.Paralizado
                                                && !x.EsHeredado
                                                && x.ExpedienteEstadoLast != null
                                                && x.ExpedienteEstadoLast.IdTipoEstado >= IdTipoEstadoHipTramitacionSubasta
                                                && x.ExpedienteEstadoes.Any(ee =>
                                                    ee.IdTipoEstado == IdTipoEstadoHipPresentDemanda
                                                    && ee.Hip_ExpedienteEstadoPresentacionDemanda != null
                                                    && (
                                                        !ee.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
                                                        || !ee.Hip_ExpedienteEstadoPresentacionDemanda.FechaEnvioProcurador.HasValue)
                                                    )
                    );

                case TipoIndicadorQa.ExpHipQaDatosSinJuzgado:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && !x.Fin.HasValue
                                                //&& !x.Paralizado
                                                //&& !x.EsHeredado
                                                && x.ExpedienteEstadoLast != null
                                                && x.ExpedienteEstadoLast.IdTipoEstado >= IdTipoEstadoHipTramitacionSubasta
                                                && x.ExpedienteEstadoLast.IdTipoEstado != IdTipoEstadoHipJurisdiccionVoluntaria
                                                && (!x.IdJuzgado.HasValue || x.IdJuzgado == 5710 || x.IdJuzgado == 0)

                    );

                case TipoIndicadorQa.ExpHipQaDatosSinDemandaAdmitida:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && !x.Fin.HasValue
                                                && !x.Paralizado
                                                && !x.EsHeredado
                                                && x.ExpedienteEstadoLast != null
                                                && x.ExpedienteEstadoLast.IdTipoEstado >= IdTipoEstadoHipTramitacionSubasta
                                                && x.ExpedienteEstadoes.Any(ee =>
                                                    ee.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
                                                    && ee.HipExpedienteEstadoTramitacionSubasta != null
                                                    && !ee.HipExpedienteEstadoTramitacionSubasta.AdmitidaFecha.HasValue)

                    );

                case TipoIndicadorQa.ExpHipQaDatosAdjudicacionIncompletos:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
                                                && !x.Fin.HasValue
                                                && !x.Paralizado
                                                && !x.EsHeredado
                                                && x.ExpedienteEstadoLast != null
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                                                && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion != null
                                                && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaSolicitudPosesion.HasValue
                                                && (
                                                        !x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio.HasValue
                                                        || !x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaAdjudicacion.HasValue
                                                        || !x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.ActaArrendaticiaFechaSolicitud.HasValue
                                                    )
                    );

                #endregion

                #endregion

                #region Conciliacion

                #region Facturas 

                case TipoIndicadorQa.ConciliacionFacturasHito1Caixa:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConciliacion
                        && x.Gnr_ClienteOficina.IdCliente == IdClienteCaixa
                        && !x.FacturaSet.Any()
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoCclFinalizado
                    );

                #endregion

                #endregion

                #region Alquiler

                #region Alquiler Indicadores

                case TipoIndicadorQa.AlquilerInactivo:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                                                && x.FechaModificacion < FechaActualMenos90
                                                && x.IdTipoEstadoLast.HasValue
                                                && lstExpedientesParalizado.All(y => y != x.IdTipoEstadoLast)
                                                && lstExpedientesFinalizado.All(y => y != x.IdTipoEstadoLast)
                                                && x.ExpedienteEstadoes.All(e => e.FechaAlta < FechaActualMenos90)
                                                && x.ExpedienteNotaSet.All(e => e.Fecha < FechaActualMenos90)
                                                && x.ImpulsoSet.All(e => e.Fecha < FechaActualMenos90)
                                                && x.ActuacionSet.All(e => e.Fecha < FechaActualMenos90)
                    );

                case TipoIndicadorQa.AlquilerPendienteOficiosEdictos:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                                                && x.IdEstadoLast.HasValue
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
                                                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado != null
                                                && !x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.Oposicion
                                                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.AdmitidaFecha.HasValue
                                                && x.ExpedienteDeudors.Any(d => d.NotificacionEstado == PositivoNegativoType.Negativo)
                    );

                case TipoIndicadorQa.AlquilerEnRevision:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && x.ExpedienteEstadoLast != null
                        && (x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoRecepcionExpediente || x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqRecepcionExpediente)
                        && (!x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue || x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0101RecepcionRevision)
                    );

                case TipoIndicadorQa.AlquilerPendientePreparacion:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                                                && x.ExpedienteEstadoLast != null
                                                && (x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoRecepcionExpediente || x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqRecepcionExpediente)
                                                && x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0103PreparacionDemanda
                    //&& x.Alq_Expediente != null
                    //&& x.Alq_Expediente.IdTipoEstadoCliente == 3 //1.3	PREPARACION DEMANDA
                    );

                case TipoIndicadorQa.AlquilerPendientePresentacionDemanda:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && x.IdTipoEstadoLast < IdTipoEstadoAlqPresentDemanda
                        || (
                                x.IdTipoEstadoLast == IdTipoEstadoAlqPresentDemanda
                                && x.ExpedienteEstadoes.Any(ee =>
                                    ee.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
                                    && !ee.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue))
                    );

                case TipoIndicadorQa.AlquilerPendienteDemandaAdmitida:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                                                && x.ExpedienteEstadoLast != null
                                                && (
                                                    (
                                                        x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
                                                        && !x.ExpedienteEstadoLast.Alq_Expediente_EstadoPresentacionDemanda.NoAdmitidaFecha.HasValue
                                                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue
                                                    )
                                                    || (
                                                        x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
                                                        && !x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.AdmitidaFecha.HasValue
                                                    )
                                            ));

                case TipoIndicadorQa.AlquilerRecursosApelacion:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado != null
                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.ApelacionFecha.HasValue
                        && !x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.ApelacionResultado.HasValue
                    );

                case TipoIndicadorQa.AlquilerPendienteEjecucionDineraria:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && x.Ejc_Expediente.IdExpedienteAlq.HasValue
                        && x.IdTipoEstadoLast != IdTipoEstadoEjcFinalizacion
                    );

                case TipoIndicadorQa.AlquilerIncidenciaDocumental:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqRecepcionExpediente
                        && x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                        && (
                            x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0102IncidenciaDocumental
                            || x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0104
                        )
                    );

                case TipoIndicadorQa.AlquilerFacturasPendientes:
                    break;


                case TipoIndicadorQa.AlquilerPendienteEjecucionLanzamiento:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && x.IdTipoEstadoLast == IdTipoEstadoAlqLanzamiento);
                case TipoIndicadorQa.AlquilerPendienteTransferirCantidadConsiganada:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && x.IdTipoEstadoLast == IdTipoEstadoAlqEnervacion);
                case TipoIndicadorQa.AlquilerPendienteSolicitarDecretoFin:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado != null
                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.AdmitidaFecha.HasValue
                        && !x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.Oposicion
                        && x.ExpedienteDeudors.All(d => d.NotificacionFecha.HasValue)
                    );
                //&& x.ExpedienteEstadoes.Any(ee =>
                //    ee.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
                //    && !ee.FechaFin.HasValue
                //    && ee.Alq_Expediente_EstadoTramitaJuzgado.AdmitidaFecha.HasValue
                //    //&& ee.Alq_Expediente_EstadoTramitaJuzgado.FechaNotificacionDemandado.HasValue
                //    && !ee.Alq_Expediente_EstadoTramitaJuzgado.Oposicion
                //)
                case TipoIndicadorQa.AlquilerPendienteMediacion:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && x.IdTipoEstadoLast != IdTipoEstadoAlqFinalizado
                        && x.Alq_Expediente.IdTipoEstadoCliente == 7 //2.4	MEDIACION
                    );
                case TipoIndicadorQa.AlquilerPendienteExpedienteEjecucion:
                    var lstEstadoClienteExcluir = new List<int> { 31, 32, 33, 38 };
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                                                && x.IdEstadoLast.HasValue
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqFinalizado
                                                && !x.Alq_Expediente.IdExpedienteEjc.HasValue
                                                && lstClientesBase1.Any(c => c == x.Gnr_ClienteOficina.IdCliente)
                                                && (
                                                    !x.Alq_Expediente.IdTipoEstadoCliente.HasValue ||
                                                    !lstEstadoClienteExcluir.Any(y => y == x.Alq_Expediente.IdTipoEstadoCliente)
                                                )
                    );
                case TipoIndicadorQa.AlquilerPendienteDemandaEjecucion:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                        && x.Ejc_Expediente.IdExpedienteAlq.HasValue
                        && x.IdTipoEstadoLast == IdTipoEstadoEjcPresentacionDemanda
                        && x.ExpedienteEstadoes.Any(ee =>
                            ee.IdTipoEstado == IdTipoEstadoEjcPresentacionDemanda
                            && !ee.FechaFin.HasValue
                            && !ee.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
                        ));

                case TipoIndicadorQa.AlquilerPendienteInstrucciones:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && x.ExpedienteEstadoLast != null
                        && (x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0104
                            || (x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
                                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.SuspensionInstruccionesCliente
                            )
                        ));

                case TipoIndicadorQa.AlquilerPendienteRevisionEjecutivo:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                        && x.ExpedienteEstadoLast != null
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcRecepcion
                        && x.Ejc_Expediente != null
                        && x.Ejc_Expediente.IdExpedienteAlq.HasValue
                    );

                case TipoIndicadorQa.AlquilerDerivadoConcursal:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && x.Alq_Expediente != null
                        && x.Alq_Expediente.DerivadoDepartamentoConcursal
                    );

                case TipoIndicadorQa.AlquilerDecretoFinSinEjecutivo:
                    var lstEstadoClienteTmp1 = new List<int> { 62, 71, 72 };
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                                && lstEstadoClienteTmp1.Any(c => c == x.Gnr_ClienteOficina.IdCliente)
                                && x.IdEstadoLast.HasValue
                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
                                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado != null
                                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.OposicionFechaDecretoFin.HasValue
                                && !x.Alq_Expediente.IdExpedienteEjc.HasValue
                    );

                #endregion

                #region Alquiler Alarmas 

                case TipoIndicadorQa.AlquilerAlarmaPdteFechaResolucionIncidencia:
                    var lstClientesRes = new List<int> { 62, 71, 72 };

                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqRecepcionExpediente
                        && (
                            x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0102IncidenciaDocumental
                            || x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0105
                        )
                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoRecepcion != null
                        && !x.ExpedienteEstadoLast.Alq_Expediente_EstadoRecepcion.FechaResolucionIncidenciaDocumental.HasValue
                        && lstClientesRes.Contains(x.Gnr_ClienteOficina.IdCliente)
                    );

                case TipoIndicadorQa.AlquilerAlarmaRecepcionDemandaSellada:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoPresentacionDemanda != null
                        && !x.ExpedienteEstadoLast.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue
                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoPresentacionDemanda.FechaEnvioProcurador.HasValue
                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoPresentacionDemanda.FechaEnvioProcurador < FechaActualMenos3
                    );


                case TipoIndicadorQa.AlquilerAlarmaRecepcionDemandaSelladaOrd:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario && x.IdTipoArea == IdTipoAreaDesahucios
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdPresentacionDemanda
                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda != null
                        && !x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda.FechaPresentacion.HasValue
                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda.FechaEnvioProcurador.HasValue
                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda.FechaEnvioProcurador < FechaActualMenos3
                    );
                case TipoIndicadorQa.AlquilerAlarmaRecepcionDemandaSelladaEjc:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcPresentacionDemanda
                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda != null
                        && !x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda.FechaEnvioProcurador.HasValue
                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda.FechaEnvioProcurador < FechaActualMenos3
                    );
                case TipoIndicadorQa.AlquilerAlarmaRecepcionDemandaSelladaMn:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMonitorio && x.IdTipoArea == IdTipoAreaDesahucios
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoMnPresentDemanda
                        && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioPresentacionDemanda != null
                        && !x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioPresentacionDemanda.FechaPresentacion.HasValue
                        && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioPresentacionDemanda.FechaEnvioProcurador.HasValue
                        && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioPresentacionDemanda.FechaEnvioProcurador < FechaActualMenos3
                    );

                case TipoIndicadorQa.AlquilerAlarmaRecepcionDenuncia:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqPresentDenuncia
                        && x.ExpedienteEstadoLast.AlqExpedienteEstadoPresentacionDenuncia != null
                        && !x.ExpedienteEstadoLast.AlqExpedienteEstadoPresentacionDenuncia.FechaPresentacion.HasValue
                        && x.ExpedienteEstadoLast.AlqExpedienteEstadoPresentacionDenuncia.FechaEnvioProcurador.HasValue
                        && x.ExpedienteEstadoLast.AlqExpedienteEstadoPresentacionDenuncia.FechaEnvioProcurador < FechaActualMenos3
                    );


                case TipoIndicadorQa.AlquilerAlarmaPendienteAjg:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                                                && x.IdEstadoLast.HasValue
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
                                                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado != null
                                                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.SuspensionAjg
                                                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.SuspensionFecha.HasValue
                                                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.SuspensionFecha < FechaActualMenos45
                    );

                case TipoIndicadorQa.AlquilerAlarmaPendienteAcuerdo:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                                                && x.IdEstadoLast.HasValue
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
                                                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado != null
                                                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.SuspensionPendienteAcuerdo
                                                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.SuspensionFecha.HasValue
                                                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.SuspensionFecha < FechaActualMenos15
                    );

                case TipoIndicadorQa.AlquilerAlarmaPendienteInstruccionesCliente:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                                                && x.IdEstadoLast.HasValue
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
                                                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado != null
                                                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.SuspensionInstruccionesCliente
                                                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.SuspensionFecha.HasValue
                                                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.SuspensionFecha < FechaActualMenos10
                    );

                case TipoIndicadorQa.AlquilerAlarmaPresentacionDemanda:
                    var lstCliente05Dias = new List<int> { 27, 42, 44, 54, 55, 56, 60 };
                    var lstCliente25Dias = new List<int> { 71, 72 };
                    //var lstOficinasVarias = LstOficinasSolvia
                    //    .Union(LstOficinasSareb)
                    //    .Union(LstOficinasSantander)
                    //    .Union(LstOficinasLlogatalia)
                    //    .ToList();
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                                                && x.IdEstadoLast.HasValue
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqRecepcionExpediente
                                                && (x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0101RecepcionRevision || x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0103PreparacionDemanda)
                                                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoRecepcion != null
                                                && (
                                                    (
                                                        lstCliente05Dias.Contains(x.Gnr_ClienteOficina.IdCliente) && (
                                                            x.ExpedienteEstadoLast.Fecha < FechaActualMenos5
                                                            || (
                                                                x.ExpedienteEstadoLast.Alq_Expediente_EstadoRecepcion.FechaResolucionIncidenciaDocumental.HasValue
                                                                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoRecepcion.FechaResolucionIncidenciaDocumental < FechaActualMenos5
                                                            )
                                                        )
                                                    ) || (
                                                        lstCliente25Dias.Contains(x.Gnr_ClienteOficina.IdCliente) && (
                                                            x.ExpedienteEstadoLast.Fecha < FechaActualMenos25
                                                            || (
                                                                x.ExpedienteEstadoLast.Alq_Expediente_EstadoRecepcion.FechaResolucionIncidenciaDocumental.HasValue
                                                                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoRecepcion.FechaResolucionIncidenciaDocumental < FechaActualMenos25
                                                            )
                                                    ))
                                                )
                                            );

                case TipoIndicadorQa.AlquilerAlarmaDemandaAdmitida:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && x.IdTipoEstadoLast == IdTipoEstadoAlqPresentDemanda
                        && x.ExpedienteEstadoes.Any(ee => ee.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
                            && !ee.FechaFin.HasValue
                            && !ee.Alq_Expediente_EstadoPresentacionDemanda.NoAdmitidaFecha.HasValue
                            && ee.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue
                            && ee.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.Value < FechaActualMenos30)
                    );

                case TipoIndicadorQa.AlquilerAlarmaPendienteNotificacion:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado != null
                        && !x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.Oposicion
                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.AdmitidaFecha.HasValue
                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.AdmitidaFecha < FechaActualMenos30
                        && x.ExpedienteDeudors.Any(d => !d.NotificacionFecha.HasValue)
                    );

                case TipoIndicadorQa.AlquilerAlarmaPendienteDecretoFin:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado != null
                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.AdmitidaFecha.HasValue
                        && !x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.Oposicion
                        && x.ExpedienteDeudors.All(d =>
                            (d.NotificacionEstado == PositivoNegativoType.Positivo || d.NotificacionEdictos)
                            && d.NotificacionFecha.HasValue
                            && d.NotificacionFecha < FechaActualMenos15)
                    );

                //&& x.ExpedienteEstadoes.Any(ee => ee.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
                //    && !ee.FechaFin.HasValue
                //    && !ee.Alq_Expediente_EstadoTramitaJuzgado.Oposicion
                //    && ee.Alq_Expediente_EstadoTramitaJuzgado.AdmitidaFecha.HasValue
                //&& ee.Alq_Expediente_EstadoTramitaJuzgado.FechaNotificacionDemandado.HasValue
                //&& ee.Alq_Expediente_EstadoTramitaJuzgado.FechaNotificacionDemandado.Value < FechaActualMenos15
                //)

                case TipoIndicadorQa.AlquilerAlarmaPendienteTomaPosesion:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && x.IdTipoEstadoLast != IdTipoEstadoAlqFinalizado
                        && x.IdTipoEstadoLast != IdTipoEstadoAlqEnervacion
                        && x.ExpedienteEstadoes.Any(ee => ee.Fecha < FechaActualMenos180)
                    );

                case TipoIndicadorQa.AlquilerAlarmaPendienteEnervacion:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && x.IdTipoEstadoLast == IdTipoEstadoAlqEnervacion
                        && x.ExpedienteEstadoes.Any(ee => ee.IdTipoEstado == IdTipoEstadoAlqEnervacion
                            && !ee.FechaFin.HasValue
                            && ee.Fecha < FechaActualMenos20)
                    );

                case TipoIndicadorQa.AlquilerAlarmaImpulsoPendienteAplicativoCliente:
                    //var lstOficinaVarios = LstOficinasSolvia
                    //    .Union(LstOficinasAnticipa)
                    //    .ToList();
                    var lstCliente = new List<int> { 14, 15, 36, 42, 57, 62, 71, 72 };
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                                                //&& lstOficinaVarios.Contains(x.IdClienteOficina)
                                                && lstCliente.Contains(x.Gnr_ClienteOficina.IdCliente)
                                                && x.ImpulsoSet.Any(i => !i.AplicativoCliente)
                    );

                case TipoIndicadorQa.AlquilerAlarmaEjecutarDecretoFinSentencia:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado != null
                        //&& x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.AdmitidaFecha.HasValue
                        && !x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.OposicionSentenciaResultado.HasValue
                        && (
                            (
                                x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.OposicionFechaDecretoFin.HasValue
                                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.OposicionFechaDecretoFin < FechaActualMenos5
                            ) ||
                            (
                                x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.OposicionFechaSentencia.HasValue
                                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.OposicionFechaSentencia < FechaActualMenos5
                            )
                        )
                    );

                #endregion

                #region Facturas 

                case TipoIndicadorQa.AlquilerFacturaAltamiraHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && lstAltamiraAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
                        && !x.FacturacionCompleta && !x.EsNofacturable
                        && !x.FacturaSet.Any()
                        && x.Fin.HasValue
                    );

                case TipoIndicadorQa.AlquilerFacturaEjcAltamiraHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios
                        && lstAltamiraAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
                        && !x.FacturacionCompleta && !x.EsNofacturable
                        && !x.FacturaSet.Any()
                        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoEjcPresentDemanda
                            && e.Ejc_ExpedienteEstadoPresentacionDemanda != null
                            && e.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
                        )
                    );

                case TipoIndicadorQa.AlquilerFacturasHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && lstClientesAlqFactPersonalizados.All(c => c != x.Gnr_ClienteOficina.IdCliente)
                        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
                            && e.Alq_Expediente_EstadoPresentacionDemanda != null
                            && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue
                        )
                        && !x.FacturaSet.Any(f => f.HitoFacturacion == HitoFacturacionValue.AlquilerPresentacionDemanda)
                    );
                case TipoIndicadorQa.AlquilerFacturasHito2:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && lstClientesAlqFactPersonalizados.All(c => c != x.Gnr_ClienteOficina.IdCliente)
                        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqFinalizado)
                        && !x.FacturaSet.Any(f => f.HitoFacturacion == HitoFacturacionValue.AlquilerFinalizado)
                    );

                #region Llogatalia

                case TipoIndicadorQa.AlquilerFacturaLlogataliaHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                       && x.Gnr_ClienteOficina.IdCliente == IdClienteLlogatalia
                       && !x.FacturaSet.Any()
                       && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
                           && e.Alq_Expediente_EstadoPresentacionDemanda != null
                           && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue
                       )
                   );
                case TipoIndicadorQa.AlquilerFacturaLlogataliaHito2:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                       && x.Gnr_ClienteOficina.IdCliente == IdClienteLlogatalia
                       && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
                       && (
                            x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
                            ||
                            (
                                x.ExpedienteEstadoLast != null &&
                                x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqFinalizado &&
                                x.ExpedienteEstadoLast.Alq_Expediente_EstadoFinalizacion != null &&
                                x.ExpedienteEstadoLast.Alq_Expediente_EstadoFinalizacion.EntregaPosesion
                            )
                        )
                   );
                case TipoIndicadorQa.AlquilerFacturaEjcLlogataliaHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios
                        && x.Gnr_ClienteOficina.IdCliente == IdClienteLlogatalia
                        && !x.FacturaSet.Any()
                        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoEjcPresentDemanda
                            && e.Ejc_ExpedienteEstadoPresentacionDemanda != null
                            && e.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
                        )
                   );
                case TipoIndicadorQa.AlquilerFacturaPdteLlogatalia:
                    return queryBase.Where(x =>
                        (x.IdTipoExpediente == IdTipoExpedienteAlquiler || (x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios))
                        && x.Gnr_ClienteOficina.IdCliente == IdClienteLlogatalia
                        && !x.FacturaSet.Any()
                        && x.Fin.HasValue
                    );

                #endregion

                #region MerlinRetail

                case TipoIndicadorQa.AlquilerFacturaMerlinRetailHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                       && x.Gnr_ClienteOficina.IdCliente == IdClienteMerlinRetail
                       && !x.FacturaSet.Any()
                       && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
                           && e.Alq_Expediente_EstadoPresentacionDemanda != null
                           && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue
                       )
                   );
                case TipoIndicadorQa.AlquilerFacturaMerlinRetailHito2:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                       && x.Gnr_ClienteOficina.IdCliente == IdClienteMerlinRetail
                       && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
                       && (
                            x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
                            ||
                            (
                                x.ExpedienteEstadoLast != null &&
                                x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqFinalizado &&
                                x.ExpedienteEstadoLast.Alq_Expediente_EstadoFinalizacion != null &&
                                x.ExpedienteEstadoLast.Alq_Expediente_EstadoFinalizacion.EntregaPosesion
                            )
                        )
                   );
                case TipoIndicadorQa.AlquilerFacturaEjcMerlinRetailHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios
                        && x.Gnr_ClienteOficina.IdCliente == IdClienteMerlinRetail
                        && !x.FacturaSet.Any()
                        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoEjcPresentDemanda
                            && e.Ejc_ExpedienteEstadoPresentacionDemanda != null
                            && e.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
                        )
                   );
                case TipoIndicadorQa.AlquilerFacturaPdteMerlinRetail:
                    return queryBase.Where(x =>
                        (x.IdTipoExpediente == IdTipoExpedienteAlquiler || (x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios))
                        && x.Gnr_ClienteOficina.IdCliente == IdClienteMerlinRetail
                        && !x.FacturaSet.Any()
                        && x.Fin.HasValue
                    );

                #endregion

                #region SolviaHoteles

                case TipoIndicadorQa.AlquilerFacturaSolviaHotelesHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                       && x.Gnr_ClienteOficina.IdCliente == IdClienteSolviaHoteles
                       && !x.FacturaSet.Any()
                       && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
                           && e.Alq_Expediente_EstadoPresentacionDemanda != null
                           && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue
                       )
                   );
                case TipoIndicadorQa.AlquilerFacturaSolviaHotelesHito2:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                       && x.Gnr_ClienteOficina.IdCliente == IdClienteSolviaHoteles
                       && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
                       && (
                            x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
                            ||
                            (
                                x.ExpedienteEstadoLast != null &&
                                x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqFinalizado &&
                                x.ExpedienteEstadoLast.Alq_Expediente_EstadoFinalizacion != null &&
                                x.ExpedienteEstadoLast.Alq_Expediente_EstadoFinalizacion.EntregaPosesion
                            )
                        )
                   );
                case TipoIndicadorQa.AlquilerFacturaEjcSolviaHotelesHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios
                        && x.Gnr_ClienteOficina.IdCliente == IdClienteSolviaHoteles
                        && !x.FacturaSet.Any()
                        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoEjcPresentDemanda
                            && e.Ejc_ExpedienteEstadoPresentacionDemanda != null
                            && e.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
                        )
                   );
                case TipoIndicadorQa.AlquilerFacturaPdteSolviaHoteles:
                    return queryBase.Where(x =>
                        (x.IdTipoExpediente == IdTipoExpedienteAlquiler || (x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios))
                        && x.Gnr_ClienteOficina.IdCliente == IdClienteSolviaHoteles
                        && !x.FacturaSet.Any()
                        && x.Fin.HasValue
                    );

                #endregion

                #region Azzam

                case TipoIndicadorQa.AlquilerFacturaAzzamHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                       && x.Gnr_ClienteOficina.IdCliente == IdClienteAzzam
                       && !x.FacturaSet.Any()
                       && (
                            (x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
                               && e.Alq_Expediente_EstadoPresentacionDemanda != null
                               && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)
                            )
                            ||
                            (x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDenuncia
                               && e.AlqExpedienteEstadoPresentacionDenuncia != null
                               && e.AlqExpedienteEstadoPresentacionDenuncia.FechaPresentacion.HasValue)
                            )
                       )
                   );
                case TipoIndicadorQa.AlquilerFacturaAzzamHito2:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                       && x.Gnr_ClienteOficina.IdCliente == IdClienteAzzam
                       && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
                       && (
                            x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
                            ||
                            (
                                x.ExpedienteEstadoLast != null &&
                                x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqFinalizado
                            )
                        )
                   );
                case TipoIndicadorQa.AlquilerFacturaEjcAzzamHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios
                        && x.Gnr_ClienteOficina.IdCliente == IdClienteAzzam
                        && !x.FacturaSet.Any()
                        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoEjcPresentDemanda
                            && e.Ejc_ExpedienteEstadoPresentacionDemanda != null
                            && e.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
                        )
                   );

                #endregion

                #region Homes

                case TipoIndicadorQa.AlquilerFacturaHomesHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                       && x.Gnr_ClienteOficina.IdCliente == IdClienteHomes
                       && !x.FacturaSet.Any()
                       && (
                            (x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
                               && e.Alq_Expediente_EstadoPresentacionDemanda != null
                               && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)
                            )
                            ||
                            (x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDenuncia
                               && e.AlqExpedienteEstadoPresentacionDenuncia != null
                               && e.AlqExpedienteEstadoPresentacionDenuncia.FechaPresentacion.HasValue)
                            )
                       )
                   );
                case TipoIndicadorQa.AlquilerFacturaHomesHito2:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                       && x.Gnr_ClienteOficina.IdCliente == IdClienteHomes
                       && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
                       && (
                            x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
                            ||
                            (
                                x.ExpedienteEstadoLast != null &&
                                x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqFinalizado
                            )
                        )
                   );
                case TipoIndicadorQa.AlquilerFacturaEjcHomesHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios
                        && x.Gnr_ClienteOficina.IdCliente == IdClienteHomes
                        && !x.FacturaSet.Any()
                        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoEjcPresentDemanda
                            && e.Ejc_ExpedienteEstadoPresentacionDemanda != null
                            && e.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
                        )
                   );

                #endregion

                #region Anticipa

                case TipoIndicadorQa.AlquilerFacturaAnticipaHito1:
                    return queryBase.Where(
                        x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && !x.FacturacionCompleta && !x.EsNofacturable
                        && lstAnticipaAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
                        && !x.FacturaSet.Any()
                        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)
                   );

                case TipoIndicadorQa.AlquilerFacturaAnticipaHito2:
                    return queryBase.Where(
                        x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                        && !x.FacturacionCompleta && !x.EsNofacturable
                        && lstAnticipaAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
                        && x.FacturaSet.Any(f => f.HitoFacturacion == HitoFacturacionValue.AlquilerHito1)
                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
                        && x.Fin.HasValue
                   );

                case TipoIndicadorQa.AlquilerFacturaEjcAnticipaHito1:
                    return queryBase.Where(x =>
                        x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                        && x.IdTipoArea == IdTipoAreaDesahucios
                        && lstAnticipaAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito1)
                        && !x.FacturacionCompleta && !x.EsNofacturable
                        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoEjcPresentDemanda
                            && e.Ejc_ExpedienteEstadoPresentacionDemanda != null
                            && e.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
                        )
                   );




                //case TipoIndicadorQa.AlquilerFacturaAnticipaHito1_Finalizado:
                //    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                //        && !x.FacturacionCompleta
                //        && lstAnticipaAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
                //        && !x.FacturaSet.Any()
                //        && x.Fin.HasValue
                //   );

                //case TipoIndicadorQa.AlquilerFacturaAnticipaHito3:
                //    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                //        && !x.FacturacionCompleta
                //        && lstAnticipaAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
                //        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito3)
                //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqEnervacion)
                //   );

                //case TipoIndicadorQa.AlquilerFacturaAnticipaHito2_ConVista_0_120:
                //    var queryLocal = queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                //        && !x.FacturacionCompleta
                //        && lstAnticipaAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
                //        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
                //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)
                //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento || e.IdTipoEstado == IdTipoEstadoAlqFinalizado)
                //        && (
                //            x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
                //            || 
                //            x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento && e.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)                            
                //        )                        
                //        && x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqTramiteCelebracionVista && !v.Suspendida)
                //    );
                //    #region Preparar para remover los de mas de 120 dias

                //    var lstExpRemove = new List<int>();
                //    var resultLocal = queryLocal.ToList();
                //    foreach (var exp in resultLocal)
                //    {
                //        var fechaDemanda = exp.ExpedienteEstadoes.FirstOrDefault(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)?
                //            .Alq_Expediente_EstadoPresentacionDemanda?
                //            .FechaPresentacion;
                //        if (!fechaDemanda.HasValue) lstExpRemove.Add(exp.IdExpediente);
                //        else
                //        {
                //            var fecha2 = exp.ExpedienteEstadoes.FirstOrDefault(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento && e.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)?
                //                .Alq_Expediente_EstadoLanzamiento?
                //                .PosesionFechaRecepcion;
                //            if (!fecha2.HasValue)
                //                fecha2 = exp.ExpedienteVistas.FirstOrDefault(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)?.Fecha;

                //            if (!fecha2.HasValue || fechaDemanda.Value.GetDaysBetweenDates(fecha2.Value) > 120)
                //                lstExpRemove.Add(exp.IdExpediente);
                //        }
                //    }

                //    #endregion
                //    return resultLocal
                //        .Where(x => !lstExpRemove.Contains(x.IdExpediente))
                //        .AsQueryable();

                //case TipoIndicadorQa.AlquilerFacturaAnticipaHito2_SinVista_0_120:
                //    var queryAnticipaSinVista120 = queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                //        && !x.FacturacionCompleta
                //        && lstAnticipaAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
                //        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
                //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)
                //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento || e.IdTipoEstado == IdTipoEstadoAlqFinalizado)
                //        && (
                //            x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
                //            ||
                //            x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento && e.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)
                //        )
                //        && !x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqTramiteCelebracionVista && !v.Suspendida)
                //    );
                //    #region Preparar para remover los de mas de 120 dias

                //    lstExpRemove = new List<int>();
                //    foreach (var exp in queryAnticipaSinVista120)
                //    {
                //        var fechaDemanda = exp.ExpedienteEstadoes.FirstOrDefault(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)?
                //            .Alq_Expediente_EstadoPresentacionDemanda?
                //            .FechaPresentacion;
                //        if (!fechaDemanda.HasValue) lstExpRemove.Add(exp.IdExpediente);
                //        else
                //        {
                //            var fecha2 = exp.ExpedienteEstadoes.FirstOrDefault(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento && e.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)?
                //                .Alq_Expediente_EstadoLanzamiento?
                //                .PosesionFechaRecepcion;
                //            if (!fecha2.HasValue)
                //                fecha2 = exp.ExpedienteVistas.FirstOrDefault(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)?.Fecha;

                //            if (!fecha2.HasValue || fechaDemanda.Value.GetDaysBetweenDates(fecha2.Value) > 120)
                //                lstExpRemove.Add(exp.IdExpediente);
                //        }
                //    }

                //    #endregion
                //    return queryAnticipaSinVista120
                //        .Where(x => !lstExpRemove.Contains(x.IdExpediente))
                //        .AsQueryable();

                //case TipoIndicadorQa.AlquilerFacturaAnticipaHito2_ConVista_121_180:
                //    var queryAnticipa180Con = queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                //        && !x.FacturacionCompleta
                //        && lstAnticipaAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
                //        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
                //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)
                //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento || e.IdTipoEstado == IdTipoEstadoAlqFinalizado)
                //        && (
                //            x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
                //            ||
                //            x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento && e.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)
                //        )
                //        && x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqTramiteCelebracionVista && !v.Suspendida)
                //    );
                //    #region Preparar para remover los que estan fuera del periodo 121-180
                //    lstExpRemove = new List<int>();
                //    foreach (var exp in queryAnticipa180Con)
                //    {
                //        var fechaDemanda = exp.ExpedienteEstadoes.FirstOrDefault(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)?
                //            .Alq_Expediente_EstadoPresentacionDemanda?
                //            .FechaPresentacion;
                //        if (!fechaDemanda.HasValue) lstExpRemove.Add(exp.IdExpediente);
                //        else
                //        {
                //            var fecha2 = exp.ExpedienteEstadoes.FirstOrDefault(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento && e.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)?
                //                .Alq_Expediente_EstadoLanzamiento?
                //                .PosesionFechaRecepcion;
                //            if (!fecha2.HasValue)
                //                fecha2 = exp.ExpedienteVistas.FirstOrDefault(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)?.Fecha;

                //            if (!fecha2.HasValue || fechaDemanda.Value.GetDaysBetweenDates(fecha2.Value) < 121 || fechaDemanda.Value.GetDaysBetweenDates(fecha2.Value) > 180)
                //                lstExpRemove.Add(exp.IdExpediente);
                //        }
                //    }
                //    #endregion
                //    return queryAnticipa180Con
                //        .Where(x => !lstExpRemove.Contains(x.IdExpediente))
                //        .AsQueryable();

                //case TipoIndicadorQa.AlquilerFacturaAnticipaHito2_SinVista_121_180:
                //    var queryAnticipa180Sin = queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                //        && !x.FacturacionCompleta
                //        && lstAnticipaAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
                //        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
                //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)
                //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento || e.IdTipoEstado == IdTipoEstadoAlqFinalizado)
                //        && (
                //            x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
                //            ||
                //            x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento && e.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)
                //        )
                //        && !x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqTramiteCelebracionVista && !v.Suspendida)
                //    );
                //    #region Preparar para remover los que estan fuera del periodo 121-180
                //    lstExpRemove = new List<int>();
                //    foreach (var exp in queryAnticipa180Sin)
                //    {
                //        var fechaDemanda = exp.ExpedienteEstadoes.FirstOrDefault(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)?
                //            .Alq_Expediente_EstadoPresentacionDemanda?
                //            .FechaPresentacion;
                //        if (!fechaDemanda.HasValue) lstExpRemove.Add(exp.IdExpediente);
                //        else
                //        {
                //            var fecha2 = exp.ExpedienteEstadoes.FirstOrDefault(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento && e.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)?
                //                .Alq_Expediente_EstadoLanzamiento?
                //                .PosesionFechaRecepcion;
                //            if (!fecha2.HasValue)
                //                fecha2 = exp.ExpedienteVistas.FirstOrDefault(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)?.Fecha;

                //            if (!fecha2.HasValue || fechaDemanda.Value.GetDaysBetweenDates(fecha2.Value) < 121 || fechaDemanda.Value.GetDaysBetweenDates(fecha2.Value) > 180)
                //                lstExpRemove.Add(exp.IdExpediente);
                //        }
                //    }
                //    #endregion
                //    return queryAnticipa180Sin
                //        .Where(x => !lstExpRemove.Contains(x.IdExpediente))
                //        .AsQueryable();

                //case TipoIndicadorQa.AlquilerFacturaAnticipaHito2_ConVista_181:
                //    var queryAnticipa181Con = queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                //        && !x.FacturacionCompleta
                //        && lstAnticipaAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
                //        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
                //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)
                //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento || e.IdTipoEstado == IdTipoEstadoAlqFinalizado)
                //        && (
                //            x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
                //            ||
                //            x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento && e.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)
                //        )
                //        && x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqTramiteCelebracionVista && !v.Suspendida)
                //    );
                //    #region Preparar para remover los de menos de 181 días
                //    lstExpRemove = new List<int>();
                //    foreach (var exp in queryAnticipa181Con)
                //    {
                //        var fechaDemanda = exp.ExpedienteEstadoes.FirstOrDefault(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)?
                //            .Alq_Expediente_EstadoPresentacionDemanda?
                //            .FechaPresentacion;
                //        if (!fechaDemanda.HasValue) lstExpRemove.Add(exp.IdExpediente);
                //        else
                //        {
                //            var fecha2 = exp.ExpedienteEstadoes.FirstOrDefault(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento && e.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)?
                //                .Alq_Expediente_EstadoLanzamiento?
                //                .PosesionFechaRecepcion;
                //            if (!fecha2.HasValue)
                //                fecha2 = exp.ExpedienteVistas.FirstOrDefault(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)?.Fecha;

                //            if (!fecha2.HasValue || fechaDemanda.Value.GetDaysBetweenDates(fecha2.Value) < 181)
                //                lstExpRemove.Add(exp.IdExpediente);
                //        }
                //    }
                //    #endregion
                //    return queryAnticipa181Con
                //        .Where(x => !lstExpRemove.Contains(x.IdExpediente))
                //        .AsQueryable();

                //case TipoIndicadorQa.AlquilerFacturaAnticipaHito2_SinVista_181:
                //    var queryAnticipa181Sin = queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                //        && !x.FacturacionCompleta
                //        && lstAnticipaAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
                //        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
                //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)
                //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento || e.IdTipoEstado == IdTipoEstadoAlqFinalizado)
                //        && (
                //            x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
                //            ||
                //            x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento && e.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)
                //        )
                //        && !x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqTramiteCelebracionVista && !v.Suspendida)
                //    );
                //    #region Preparar para remover los de menos de 181 días
                //    lstExpRemove = new List<int>();
                //    foreach (var exp in queryAnticipa181Sin)
                //    {
                //        var fechaDemanda = exp.ExpedienteEstadoes.FirstOrDefault(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)?
                //            .Alq_Expediente_EstadoPresentacionDemanda?
                //            .FechaPresentacion;
                //        if (!fechaDemanda.HasValue) lstExpRemove.Add(exp.IdExpediente);
                //        else
                //        {
                //            var fecha2 = exp.ExpedienteEstadoes.FirstOrDefault(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento && e.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)?
                //                .Alq_Expediente_EstadoLanzamiento?
                //                .PosesionFechaRecepcion;
                //            if (!fecha2.HasValue)
                //                fecha2 = exp.ExpedienteVistas.FirstOrDefault(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)?.Fecha;

                //            if (!fecha2.HasValue || fechaDemanda.Value.GetDaysBetweenDates(fecha2.Value) < 181)
                //                lstExpRemove.Add(exp.IdExpediente);
                //        }
                //    }
                //    #endregion
                //    return queryAnticipa181Sin
                //        .Where(x => !lstExpRemove.Contains(x.IdExpediente))
                //        .AsQueryable();



                //case TipoIndicadorQa.AlquilerFacturaEjcAnticipaHito2:
                //    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios
                //        && x.Gnr_ClienteOficina.IdCliente == IdClienteAzzam
                //        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito1)
                //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoEjcPresentDemanda
                //            && e.Ejc_ExpedienteEstadoPresentacionDemanda != null
                //            && e.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
                //        )
                //   );

                #endregion

                #region Ahora Asset Management

                case TipoIndicadorQa.AlquilerFacturaAhoraAssetManagementHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                       && x.Gnr_ClienteOficina.IdCliente == IdClienteAhoraAssetManagement
                       && !x.FacturaSet.Any()
                       && (
                            x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
                            && e.Alq_Expediente_EstadoPresentacionDemanda != null
                            && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue
                            ) ||
                            x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDenuncia
                            && e.AlqExpedienteEstadoPresentacionDenuncia != null
                            && e.AlqExpedienteEstadoPresentacionDenuncia.FechaPresentacion.HasValue
                            )
                       )
                   );
                case TipoIndicadorQa.AlquilerFacturaAhoraAssetManagementHito2:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                       && x.Gnr_ClienteOficina.IdCliente == IdClienteAhoraAssetManagement
                       && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
                       && x.Fin.HasValue
                   //&& (
                   //     x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
                   //     ||
                   //     (
                   //         x.ExpedienteEstadoLast != null &&
                   //         x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqFinalizado &&
                   //         x.ExpedienteEstadoLast.Alq_Expediente_EstadoFinalizacion != null &&
                   //         x.ExpedienteEstadoLast.Alq_Expediente_EstadoFinalizacion.EntregaPosesion
                   //     )
                   // )
                   );

                #endregion

                case TipoIndicadorQa.AlquilerFacturaAlisedaHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                       //&& lstAlisedaAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
                       && x.Gnr_ClienteOficina.IdCliente == IdClienteAlisedaAlquileres
                       && !x.FacturaSet.Any()
                       && (
                            x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
                            && e.Alq_Expediente_EstadoPresentacionDemanda != null
                            && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue
                            ) ||
                            x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDenuncia
                            && e.AlqExpedienteEstadoPresentacionDenuncia != null
                            && e.AlqExpedienteEstadoPresentacionDenuncia.FechaPresentacion.HasValue
                            )
                       )
                   );
                case TipoIndicadorQa.AlquilerFacturaAlisedaHito2:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                       && x.Gnr_ClienteOficina.IdCliente == IdClienteAlisedaAlquileres
                       && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
                       && (
                            x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
                            ||
                            (
                                x.ExpedienteEstadoLast != null &&
                                x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqFinalizado &&
                                x.ExpedienteEstadoLast.Alq_Expediente_EstadoFinalizacion != null &&
                                x.ExpedienteEstadoLast.Alq_Expediente_EstadoFinalizacion.EntregaPosesion
                            )
                        )
                   );
                case TipoIndicadorQa.AlquilerFacturaEjcAlisedaHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios
                        && x.Gnr_ClienteOficina.IdCliente == IdClienteAlisedaAlquileres
                        && !x.FacturaSet.Any()
                        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoEjcPresentDemanda
                            && e.Ejc_ExpedienteEstadoPresentacionDemanda != null
                            && e.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
                        )
                   );
                case TipoIndicadorQa.AlquilerFacturaPdteAliseda:
                    return queryBase.Where(x =>
                        (x.IdTipoExpediente == IdTipoExpedienteAlquiler || (x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios))
                        && x.Gnr_ClienteOficina.IdCliente == IdClienteAlisedaAlquileres
                        && !x.FacturaSet.Any()
                        && x.Fin.HasValue
                    );


                case TipoIndicadorQa.AlquilerFacturaFidereHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                       && x.Gnr_ClienteOficina.IdCliente == IdClienteFidere
                       && !x.FacturaSet.Any()
                       && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
                           && e.Alq_Expediente_EstadoPresentacionDemanda != null
                           && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue
                       )
                   );
                case TipoIndicadorQa.AlquilerFacturaFidereHito2:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
                       && x.Gnr_ClienteOficina.IdCliente == IdClienteFidere
                       && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
                       && (
                            x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
                            ||
                            (
                                x.ExpedienteEstadoLast != null &&
                                x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqFinalizado &&
                                x.ExpedienteEstadoLast.Alq_Expediente_EstadoFinalizacion != null &&
                                x.ExpedienteEstadoLast.Alq_Expediente_EstadoFinalizacion.EntregaPosesion
                            )
                        )
                   );
                case TipoIndicadorQa.AlquilerFacturaEjcFidereHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios
                        && x.Gnr_ClienteOficina.IdCliente == IdClienteFidere
                        && !x.FacturaSet.Any()
                        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoEjcPresentDemanda
                            && e.Ejc_ExpedienteEstadoPresentacionDemanda != null
                            && e.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
                        )
                   );
                case TipoIndicadorQa.AlquilerFacturaPdteFidere:
                    return queryBase.Where(x =>
                        (x.IdTipoExpediente == IdTipoExpedienteAlquiler || (x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios))
                        && x.Gnr_ClienteOficina.IdCliente == IdClienteFidere
                        && !x.FacturaSet.Any()
                        && x.Fin.HasValue
                    );


                #endregion

                #endregion

                #region Ejecutivo

                #region Ejecutivo - Indicadores

                case TipoIndicadorQa.EjecutivoInactivo:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                                                && x.FechaModificacion < FechaActualMenos90
                                                && x.IdTipoEstadoLast.HasValue
                                                && lstExpedientesParalizado.All(y => y != x.IdTipoEstadoLast)
                                                && lstExpedientesFinalizado.All(y => y != x.IdTipoEstadoLast)
                                                && x.ExpedienteEstadoes.All(e => e.FechaAlta < FechaActualMenos90)
                                                && x.ExpedienteNotaSet.All(e => e.Fecha < FechaActualMenos90)
                                                && x.ImpulsoSet.All(e => e.Fecha < FechaActualMenos90)
                                                && x.ActuacionSet.All(e => e.Fecha < FechaActualMenos90)
                    );

                case TipoIndicadorQa.EjecutivoIncidenciaDocumental:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                                                && x.IdEstadoLast.HasValue
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcRecepcionExpediente
                                                && x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                                                && (
                                                    x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0102IncidenciaDocumental
                                                    || x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0104
                                                )
                    );

                case TipoIndicadorQa.EjecutivoPendientePreparacionDemanda:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                        && x.IdEstadoLast.HasValue
                        && (
                            (
                                x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcRecepcionExpediente
                                && x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0103PreparacionDemanda
                            )
                            //|| x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcGeneracionExpediente
                            ||
                            (
                                x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcPresentacionDemanda
                                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda != null
                                && !x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda.FechaEnvioProcurador.HasValue
                            )
                        ));

                case TipoIndicadorQa.EjecutivoPendienteDemandaAdmitida:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                        && x.IdEstadoLast.HasValue
                        && (
                            (
                                x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcPresentacionDemanda
                                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda != null
                                && !x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda.NoAdmitidaFecha.HasValue
                                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
                            )
                            ||
                            (
                                x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcAdmisionTramiteEmbargo
                                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoNotificacion != null
                                && !x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoNotificacion.AdmitidaFecha.HasValue
                            )
                        )
                    );

                case TipoIndicadorQa.EjecutivoConOposicion:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcAdmisionTramiteEmbargo
                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoNotificacion != null
                        && x.ExpedienteDeudors.Any(d => d.ExpedienteDeudorEjcutivoSet.Any(de => de.Oposicion))
                    );

                case TipoIndicadorQa.EjecutivoPendienteTestimonioAdjudicacion:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                                                && x.IdEstadoLast.HasValue
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcAdjudicacion
                                                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoAdjudicacion != null
                                                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoAdjudicacion.FechaAdjudicacion.HasValue
                                                && !x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoAdjudicacion.FechaTestimonio.HasValue
                    );

                case TipoIndicadorQa.EjecutivoPendienteRequerimientoPago:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                                                && x.ExpedienteEstadoLast != null
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcAdmisionTramiteEmbargo
                                                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoNotificacion != null
                                                && x.ExpedienteDeudors.Any(d => d.ExpedienteDeudorEjcutivoSet.Any(de => de.RequerimientoPagoResultado != PositivoNegativoType.Positivo))
                    );

                case TipoIndicadorQa.EjecutivoPendienteSolicitarSubasta:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                                                && x.ExpedienteEstadoLast != null
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcSubasta
                                                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoSubasta != null
                                                && !x.IdExpedienteSubastaLast.HasValue
                    );

                case TipoIndicadorQa.EjecutivoPendienteSolicitudPosesion:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                                                && x.ExpedienteEstadoLast != null
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcAdjudicacion
                                                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoAdjudicacion != null
                                                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoAdjudicacion.FechaTestimonio.HasValue
                                                && !x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoAdjudicacion.FechaPosesion.HasValue
                    );

                case TipoIndicadorQa.EjecutivoPendienteLanzamiento:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                                                && x.ExpedienteEstadoLast != null
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcAdjudicacion
                                                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoAdjudicacion != null
                                                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoAdjudicacion.FechaPosesion.HasValue
                                                && !x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoAdjudicacion.FechaLanzamiento.HasValue
                    //&& x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoAdjudicacion.ResultadoPosesion != 1 //positivo
                    //&& x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoAdjudicacion.ResultadoPosesion != 3 //Negativa - Reconocido Arrendamiento   
                    );

                case TipoIndicadorQa.EjecutivoPendienteSubastasSuspendidas:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                                                && x.ExpedienteEstadoLast != null
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcSubasta
                                                //&& x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                                                && !LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
                                                && x.IdExpedienteSubastaLast.HasValue
                                                && x.ExpedienteSubastaLast.IdMotivoSuspension.HasValue
                    );

                case TipoIndicadorQa.EjecutivoPendienteAdjudicacion:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                                                && x.ExpedienteEstadoLast != null
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcSubasta
                                                //&& x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                                                && !LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
                                                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoSubasta != null
                                                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoSubasta.FechaSolicitudAdjudicacion.HasValue
                    );

                case TipoIndicadorQa.EjecutivoDecretoConvocatoriaSubasta:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                                                && x.ExpedienteEstadoLast != null
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcSubasta
                                                //&& x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                                                && !LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
                                                && x.IdExpedienteSubastaLast.HasValue
                                                && x.ExpedienteSubastaLast.FechaDecretoSubasta.HasValue
                                                && !x.ExpedienteSubastaLast.FechaCelebracion.HasValue
                                                && !x.ExpedienteSubastaLast.IdMotivoSuspension.HasValue
                                                && !x.ExpedienteSubastaLast.IdMotivoSuspensionDecretoSubasta.HasValue
                    );

                case TipoIndicadorQa.EjecutivoPendienteAvaluo:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                                                && x.ExpedienteEstadoLast != null
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcEfectividadEmbargo
                                                && x.Hip_Inmueble.Any(i => i.EjcValoracionViaApremio
                                                    && !i.EjcImporte.HasValue
                                                )
                    );

                #endregion

                #region Ejecutivo - Alarmas 

                case TipoIndicadorQa.EjecutivoAlarmaRecepcionDemandaSellada:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                                                && x.IdEstadoLast.HasValue
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcPresentDemanda
                                                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda != null
                                                && !x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
                                                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda.FechaEnvioProcurador.HasValue
                                                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda.FechaEnvioProcurador < FechaActualMenos3
                                                );
                case TipoIndicadorQa.EjecutivoAlarmaAdmisionDemanda:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcPresentDemanda
                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda != null
                        && !x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda.NoAdmitidaFecha.HasValue
                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion < FechaActualMenos90
                        );
                case TipoIndicadorQa.EjecutivoAlarmaRequerimientoPago:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcAdmisionTramiteEmbargo
                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoNotificacion != null
                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoNotificacion.AdmitidaFecha.HasValue
                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoNotificacion.AdmitidaFecha < FechaActualMenos90
                        && x.ExpedienteDeudors.Any(d => d.ExpedienteDeudorEjcutivoSet.Any(de => de.RequerimientoPagoResultado != PositivoNegativoType.Positivo))
                        );

                case TipoIndicadorQa.EjecutivoAlarmaAveriguacionPatrimonial:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcAdmisionTramiteEmbargo
                        && x.ExpedienteDeudors.All(d => d.ExpedienteDeudorEjcutivoAveriguacionSet.All(de =>
                            de.AveriguacionPatrimonialFecha.HasValue && de.AveriguacionPatrimonialFecha < FechaActualMenos180)
                            )
                        );

                case TipoIndicadorQa.EjecutivoAlarmaMejoraEmbargo:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcAdmisionTramiteEmbargo
                        && x.ExpedienteDeudors.All(d => d.ExpedienteDeudorEjcutivoAveriguacionSet.All(de =>
                            de.AveriguacionPatrimonialFecha.HasValue && de.AveriguacionPatrimonialFecha < FechaActualMenos90)
                            )
                        );

                case TipoIndicadorQa.EjecutivoAlarmaDecretoEmbargo:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcAdmisionTramiteEmbargo
                        && x.ExpedienteDeudors.All(d => d.ExpedienteDeudorEjcutivoAveriguacionSet.All(de =>
                            de.MejoraEmbargoFecha.HasValue && de.MejoraEmbargoFecha < FechaActualMenos90)
                            )
                        );

                case TipoIndicadorQa.EjecutivoAlarmaSucesionCopiaSellada:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
                        && !x.SucesionCopiaSellada.HasValue
                        && x.SucesionPresentada.HasValue
                        && x.SucesionPresentada < FechaActualMenos2
                    );

                //case TipoIndicadorQa.EjecutivoAlarmaProrrogaEmbargo:

                #endregion

                #endregion

                #region Negociacion

                #region Negociacion Indicadores

                //case TipoIndicadorQa.NegociacionPrecontenciosoFinalizada:
                //    return queryBaseConParalizados.Where(x =>
                //            x.IdExpedienteNegociacion.HasValue
                //            && x.ExpedienteNegociacion != null
                //            && x.ExpedienteNegociacion.PrecontenciosoFechaFin.HasValue
                //        );

                //case TipoIndicadorQa.NegociacionContenciosoFinalizada:
                //    return queryBaseConParalizados.Where(x =>
                //        x.IdExpedienteNegociacion.HasValue
                //        && x.ExpedienteNegociacion != null
                //        && x.ExpedienteNegociacion.ContenciosoFechaFin.HasValue
                //    );

                //case TipoIndicadorQa.NegociacionPrecontencioso:
                //    return queryBaseConParalizados.Where(x =>
                //        x.IdExpedienteNegociacion.HasValue
                //        && !x.ExpedienteNegociacion.PrecontenciosoFechaFin.HasValue
                //        && x.ExpedienteNegociacion.IdGestor.HasValue
                //        && x.IdClienteOficina == IdClienteOficinaAcinsaBankia
                //        && (
                //            (x.IdTipoExpediente == IdTipoExpedienteHipotecario && x.IdTipoEstadoLast != IdTipoEstadoHipFinalizado)
                //            || (x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoEstadoLast != IdTipoEstadoEjcFinalizacion)
                //            || (x.IdTipoExpediente == IdTipoExpedienteOrdinario && x.IdTipoEstadoLast != IdTipoEstadoOrdFinalizacion)
                //        ));

                //case TipoIndicadorQa.NegociacionPrecontenciosoPendienteAsignar:
                //    return queryBaseConParalizados.Where(x =>
                //        (!x.IdExpedienteNegociacion.HasValue || (
                //            !x.ExpedienteNegociacion.IdGestor.HasValue
                //            && !x.ExpedienteNegociacion.PrecontenciosoFechaFin.HasValue
                //        ))
                //        && x.IdClienteOficina == IdClienteOficinaAcinsaBankia
                //        && (
                //            (x.IdTipoExpediente == IdTipoExpedienteHipotecario && x.IdTipoEstadoLast < IdTipoEstadoHipPresentDemanda)
                //            || (x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoEstadoLast <= IdTipoEstadoEjcAdmisionTramiteEmbargo)
                //            || (x.IdTipoExpediente == IdTipoExpedienteOrdinario && x.IdTipoEstadoLast < IdTipoEstadoOrdFinalizacion)
                //        ));


                //case TipoIndicadorQa.NegociacionAlquilerPrecontencioso:
                //    return queryBaseConParalizados.Where(x =>
                //        x.IdExpedienteNegociacion.HasValue
                //        && !x.ExpedienteNegociacion.PrecontenciosoFechaFin.HasValue
                //        && x.ExpedienteNegociacion.IdGestor.HasValue
                //        && x.IdTipoExpediente == IdTipoExpedienteAlquiler
                //        && lstEstadosInicio.Any(e => e == x.IdTipoEstadoLast)
                //        && x.IdTipoArea == IdTipoAreaNegociaciones
                //    //&& LstAlqClientes.Any(c => c == x.Gnr_ClienteOficina.IdCliente)
                //    );
                //case TipoIndicadorQa.NegociacionAlquilerPrecontenciosoPendienteAsignar:
                //    return queryBaseConParalizados.Where(x =>
                //        (!x.IdExpedienteNegociacion.HasValue || (
                //            !x.ExpedienteNegociacion.IdGestor.HasValue
                //             && !x.ExpedienteNegociacion.PrecontenciosoFechaFin.HasValue
                //         ))
                //        && x.IdTipoExpediente == IdTipoExpedienteAlquiler
                //        && lstEstadosInicio.Any(e => e == x.IdTipoEstadoLast)
                //        && x.IdTipoArea == IdTipoAreaNegociaciones
                //    //&& LstAlqClientes.Any(c => c == x.Gnr_ClienteOficina.IdCliente)
                //    );

                //case TipoIndicadorQa.NegociacionAlquilerContencioso:
                //    return queryBaseConParalizados.Where(x =>
                //        x.IdExpedienteNegociacion.HasValue
                //        && !x.ExpedienteNegociacion.ContenciosoFechaFin.HasValue
                //        && x.ExpedienteNegociacion.IdGestorContencioso.HasValue
                //        && x.IdTipoExpediente == IdTipoExpedienteAlquiler
                //        && x.ExpedienteEstadoLast != null
                //        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqLanzamiento
                //        && LstAlqClientes.Any(c => c == x.Gnr_ClienteOficina.IdCliente)
                //    );
                //case TipoIndicadorQa.NegociacionAlquilerContenciosoPendienteAsignar:
                //    return queryBaseConParalizados.Where(x =>
                //        (!x.IdExpedienteNegociacion.HasValue || (
                //            !x.ExpedienteNegociacion.IdGestorContencioso.HasValue
                //             && !x.ExpedienteNegociacion.ContenciosoFechaFin.HasValue
                //         ))
                //        && x.IdTipoExpediente == IdTipoExpedienteAlquiler
                //        && x.ExpedienteEstadoLast != null
                //        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqLanzamiento
                //        && LstAlqClientes.Any(c => c == x.Gnr_ClienteOficina.IdCliente)
                //    );


                //case TipoIndicadorQa.NegociacionContencioso:
                //    return queryBaseConParalizados.Where(x =>
                //        x.IdTipoExpediente == IdTipoExpedienteHipotecario
                //        && x.IdClienteOficina == IdClienteOficinaAcinsaBankia
                //        //&& x.IdTipoEstadoLast == IdTipoEstadoHipAdjudicacion
                //        && x.IdTipoEstadoLast.HasValue
                //        && lstExpedientesParalizado.All(y => y != x.IdTipoEstadoLast)
                //        && lstExpedientesFinalizado.All(y => y != x.IdTipoEstadoLast)

                //        && x.IdExpedienteNegociacion.HasValue
                //        && !x.ExpedienteNegociacion.ContenciosoFechaFin.HasValue
                //        && x.ExpedienteNegociacion.IdGestorContencioso.HasValue
                //    );
                //case TipoIndicadorQa.NegociacionContenciosoPendienteAsignar:
                //    return queryBaseConParalizados.Where(x =>
                //        x.IdTipoExpediente == IdTipoExpedienteHipotecario
                //        && x.IdClienteOficina == IdClienteOficinaAcinsaBankia
                //        && x.IdTipoEstadoLast == IdTipoEstadoHipAdjudicacion
                //        && (
                //            x.ExpedienteNegociacion == null
                //            || (
                //                !x.ExpedienteNegociacion.IdGestorContencioso.HasValue
                //                && !x.ExpedienteNegociacion.ContenciosoFechaFin.HasValue
                //            )
                //        )
                //        //&& x.IdExpedienteNegociacion.HasValue
                //        //&& !x.ExpedienteNegociacion.ContenciosoFechaFin.HasValue
                //        //&& !x.ExpedienteNegociacion.IdGestorContencioso.HasValue

                //        );

                //case TipoIndicadorQa.NegociacionContenciosoFechaTestimonio:
                //    return queryBaseConParalizados.Where(x =>
                //        x.IdTipoExpediente == IdTipoExpedienteHipotecario
                //        && x.IdClienteOficina == IdClienteOficinaAcinsaBankia
                //        && x.IdEstadoLast.HasValue
                //        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                //        && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio.HasValue
                //        && x.IdExpedienteNegociacion.HasValue
                //        && !x.ExpedienteNegociacion.ContenciosoFechaFin.HasValue
                //        && x.ExpedienteNegociacion.IdGestorContencioso.HasValue
                //        );

                //case TipoIndicadorQa.NegociacionTpa:
                //    return queryBaseConParalizados.Where(x =>
                //        x.IdTipoExpediente == IdTipoExpedienteTpa
                //        && x.IdExpedienteNegociacion.HasValue
                //        && !x.ExpedienteNegociacion.ContenciosoFechaFin.HasValue
                //        && x.ExpedienteNegociacion.IdGestorContencioso.HasValue
                //    );

                //case TipoIndicadorQa.NegociacionTpaPendienteAsignar:
                //    return queryBaseConParalizados.Where(x =>
                //        x.IdTipoExpediente == IdTipoExpedienteTpa
                //        && (
                //            !x.IdExpedienteNegociacion.HasValue
                //            || (
                //                !x.ExpedienteNegociacion.IdGestorContencioso.HasValue
                //                && !x.ExpedienteNegociacion.ContenciosoFechaFin.HasValue
                //            )
                //        ));

                case TipoIndicadorQa.TpaFallidas:
                    return queryBaseConParalizados.Where(x =>
                        x.IdTipoEstadoLast == idTipoEstadoHipNegociacionPosesion
                        && x.ExpedienteEstadoes.Any(ee =>
                            ee.IdTipoEstado == idTipoEstadoHipNegociacionPosesion
                            && ee.Hip_ExpedienteEstadoNegociacionPosesion.NegociacionFinalizadaPor.HasValue
                            && ee.Hip_ExpedienteEstadoNegociacionPosesion.NegociacionFinalizadaPor.Value == 4));
                case TipoIndicadorQa.PropuestaAceptada:
                    return queryBaseConParalizados.Where(x =>
                            x.IdTipoEstadoLast == idTipoEstadoHipNegociacionPosesion
                            && x.ExpedienteEstadoes.Any(ee =>
                            ee.IdTipoEstado == idTipoEstadoHipNegociacionPosesion
                            && ee.Hip_ExpedienteEstadoNegociacionPosesion.ExpedienteEstadoId == (int)ExpedienteEstadoTipo.NegociacionSucursalFinalizadoPropuestaAceptada));
                case TipoIndicadorQa.PropuestaDenegada:
                    return queryBaseConParalizados.Where(x =>
                            x.IdEstadoLast == idTipoEstadoHipNegociacionPosesion
                            && x.ExpedienteEstadoes.Any(ee =>
                            ee.IdTipoEstado == idTipoEstadoHipNegociacionPosesion
                            && ee.Hip_ExpedienteEstadoNegociacionPosesion.ExpedienteEstadoId == (int)ExpedienteEstadoTipo.NegociacionSucursalFinalizadoPropuestaDenegada));
                case TipoIndicadorQa.PagoDeuda:
                    return queryBaseConParalizados.Where(x =>
                            x.IdEstadoLast == idTipoEstadoHipNegociacionPosesion
                            && x.ExpedienteEstadoes.Any(ee =>
                            ee.IdTipoEstado == idTipoEstadoHipNegociacionPosesion
                            && ee.Hip_ExpedienteEstadoNegociacionPosesion.ExpedienteEstadoId == (int)ExpedienteEstadoTipo.NegociacionFinalizadoPagoDeuda));
                case TipoIndicadorQa.EntregaInmueble:
                    return queryBaseConParalizados.Where(x =>
                            x.IdEstadoLast == idTipoEstadoHipNegociacionPosesion
                            && x.ExpedienteEstadoes.Any(ee =>
                            ee.IdTipoEstado == idTipoEstadoHipNegociacionPosesion
                            && ee.Hip_ExpedienteEstadoNegociacionPosesion.ExpedienteEstadoId == (int)ExpedienteEstadoTipo.NegociacionSucursalInviable));
                case TipoIndicadorQa.Inviables:
                    return queryBaseConParalizados.Where(x =>
                            x.IdEstadoLast == idTipoEstadoHipNegociacionPosesion
                            && x.ExpedienteEstadoes.Any(ee =>
                            ee.IdTipoEstado == idTipoEstadoHipNegociacionPosesion
                            && ee.Hip_ExpedienteEstadoNegociacionPosesion.ExpedienteEstadoId == (int)ExpedienteEstadoTipo.NegociacionFinalizadoInviable));





                #endregion

                #region Negociacion Alarmas

                //case TipoIndicadorQa.NegociacionAlarmaExpiradoTiempoNegAlquiler:
                //    return queryBase.Where(x =>
                //            x.IdTipoExpediente == IdTipoExpedienteAlquiler
                //            && x.IdEstadoLast.HasValue
                //            && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqRecepcionExpediente
                //            && x.ExpedienteNegociacion != null
                //            && !x.ExpedienteNegociacion.PrecontenciosoFechaFin.HasValue
                //            && x.ExpedienteEstadoLast.Fecha < FechaActualMenos30
                //        );

                //case TipoIndicadorQa.NegociacionAlarmaExpiradoTiempoNegPrecontencioso:
                //    return queryBase.Where(x =>
                //            x.IdTipoExpediente != IdTipoExpedienteAlquiler
                //            && x.IdEstadoLast.HasValue
                //            && x.ExpedienteEstadoLast.Gnr_TipoEstado.Inicio
                //            && x.ExpedienteNegociacion != null
                //            && !x.ExpedienteNegociacion.PrecontenciosoFechaFin.HasValue
                //            && x.ExpedienteEstadoLast.Fecha < FechaActualMenos30
                //        );

                #endregion

                #endregion

                #region Ordinario

                #region Ordinario - Indicadores

                case TipoIndicadorQa.OrdinarioInactivo:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
                                                && x.FechaModificacion < FechaActualMenos90
                                                && x.IdTipoEstadoLast.HasValue
                                                && lstExpedientesParalizado.All(y => y != x.IdTipoEstadoLast)
                                                && lstExpedientesFinalizado.All(y => y != x.IdTipoEstadoLast)
                                                && x.ExpedienteEstadoes.All(e => e.FechaAlta < FechaActualMenos90)
                                                && x.ExpedienteNotaSet.All(e => e.Fecha < FechaActualMenos90)
                                                && x.ImpulsoSet.All(e => e.Fecha < FechaActualMenos90)
                                                && x.ActuacionSet.All(e => e.Fecha < FechaActualMenos90)
                    );

                case TipoIndicadorQa.OrdinarioIncidenciaDocumental:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdRecepcionExpediente
                        && x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
                        && (
                            x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0102IncidenciaDocumental
                            || x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0104
                        )
                    );

                case TipoIndicadorQa.OrdinarioPendientePreparacionDemanda:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
                                                && x.IdTipoEstadoLast.HasValue
                                                && (
                                                    (x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdRecepcionExpediente
                                                        && x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0103PreparacionDemanda
                                                    ) || (
                                                        x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdPresentacionDemanda
                                                        && !x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda.FechaEnvioProcurador.HasValue
                                                    )
                                                )
                    );

                case TipoIndicadorQa.OrdinarioPendienteDecretoAdmision:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
                                                && x.IdTipoEstadoLast.HasValue
                                                && (
                                                    (
                                                        x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdPresentacionDemanda
                                                        && !x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda.NoAdmitidaFecha.HasValue
                                                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda.FechaPresentacion.HasValue
                                                    ) || (
                                                        x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdAutoAdmisionNotificacion
                                                        && !x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioAutoAdmisionNotificacion.AdmitidaFecha.HasValue
                                                    )
                                                )
                    );

                case TipoIndicadorQa.OrdinarioAudienciaPrevia:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
                                                && x.IdTipoEstadoLast.HasValue
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdTramitacionJuzgado
                                                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioTramitacionJuzgado.AudienciaPreviaFecha.HasValue
                    );

                case TipoIndicadorQa.OrdinarioJuicio:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
                                                && x.IdTipoEstadoLast.HasValue
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdJuicio
                                                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioJuicio.JuicioFecha.HasValue
                    );

                case TipoIndicadorQa.OrdinarioSentencia:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
                                                && x.IdTipoEstadoLast.HasValue
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdSentencia
                                                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioSentencia.SentenciaFecha.HasValue
                    );

                case TipoIndicadorQa.OrdinarioRecursoApelacion:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
                                                && x.IdTipoEstadoLast.HasValue
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdSentencia
                                                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioSentencia.ApelacionFecha.HasValue
                    );

                case TipoIndicadorQa.OrdinarioCasacionInfraccionProcesal:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
                                                && x.IdTipoEstadoLast.HasValue
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdSentencia
                                                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioSentencia.InfraccionProcesalFecha.HasValue
                    );

                case TipoIndicadorQa.OrdinarioEjecucionSentencia:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
                                                && x.IdTipoEstadoLast.HasValue
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdFinalizacion
                                                && x.ExpedienteEstadoLast.IdTipoSubFaseEstado == IdTipoSubFaseEstadoEjecucionSentencia
                    );

                case TipoIndicadorQa.OrdinarioPendienteFirmezaSentenciaEstimatoria:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdSentencia
                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioSentencia.SentenciaFecha.HasValue
                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioSentencia.SentenciaResultado == 2 //Estimatoria
                        && !x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioSentencia.SentenciaFirmezaFecha.HasValue
                    );

                #endregion

                #region Ordinario - Alarmas 

                case TipoIndicadorQa.OrdinarioAlarmaPdteDemanda:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdRecepcionExpediente
                        && x.ExpedienteEstadoLast.Fecha < FechaActualMenos30
                    );

                case TipoIndicadorQa.OrdinarioAlarmaDecretoAdmision:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdPresentacionDemanda
                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda != null
                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda.FechaPresentacion.HasValue
                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda.FechaPresentacion < FechaActualMenos30
                    );

                case TipoIndicadorQa.OrdinarioAlarmaEmplazamientoPositivo:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdTramitacionJuzgado
                        && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoDatoRequerimiento.Any(y =>
                            y.Positivo
                            && y.FechaRequerimientoPago.HasValue
                            && y.FechaRequerimientoPago.Value < FechaActualMenos20
                        )
                    );

                case TipoIndicadorQa.OrdinarioAlarmaEmplazamientoNegativo:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdTramitacionJuzgado
                        && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoDatoRequerimiento.Any(y =>
                            !y.Positivo
                            && y.FechaRequerimientoPago.HasValue
                            && y.FechaRequerimientoPago.Value < FechaActualMenos30
                        )
                    );

                case TipoIndicadorQa.OrdinarioAlarmaAudienciaPrevia:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdTramitacionJuzgado
                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioTramitacionJuzgado != null
                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioTramitacionJuzgado.AudienciaPreviaFecha.HasValue
                        && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoDatoRequerimiento.Any(y =>
                            !y.Positivo
                            && y.FechaRequerimientoPago.HasValue
                            && y.FechaRequerimientoPago.Value < FechaActualMenos30
                        )
                    );

                case TipoIndicadorQa.OrdinarioAlarmaJuicio:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdTramitacionJuzgado
                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioTramitacionJuzgado != null
                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioTramitacionJuzgado.AudienciaPreviaFecha.HasValue
                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioTramitacionJuzgado.AudienciaPreviaFecha.Value < FechaActualMenos60
                    );

                case TipoIndicadorQa.OrdinarioAlarmaSentencia:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdJuicio
                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioJuicio != null
                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioJuicio.JuicioFecha.HasValue
                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioJuicio.JuicioFecha.Value < FechaActualMenos30
                    );

                case TipoIndicadorQa.OrdinarioAlarmaPdteSentencia:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdSentencia
                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioSentencia != null
                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioSentencia.SentenciaFirmezaFecha.HasValue
                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioSentencia.SentenciaFirmezaFecha.Value < FechaActualMenos30
                    );

                case TipoIndicadorQa.OrdinarioAlarmaRecepcionDemandaSellada:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdPresentacionDemanda
                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda != null
                        && !x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda.FechaPresentacion.HasValue
                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda.FechaEnvioProcurador.HasValue
                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda.FechaEnvioProcurador < FechaActualMenos3
                    );

                case TipoIndicadorQa.OrdinarioAlarmaSucesionCopiaSellada:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
                        && !x.SucesionCopiaSellada.HasValue
                        && x.SucesionPresentada.HasValue
                        && x.SucesionPresentada < FechaActualMenos2
                    );

                #endregion

                #region Ordinario - Facturas 

                case TipoIndicadorQa.OrdinarioFacturasHito1Caixa:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
                        && x.IdTipoArea == IdTipoAreaDesahucios
                        && x.Gnr_ClienteOficina.IdCliente == IdClienteCaixa
                        && !x.FacturaSet.Any()
                        && (
                            x.ExpedienteEstadoes.Any(y => y.IdTipoEstado == IdTipoEstadoOrdFinalizacion)
                            || x.ExpedienteEstadoes.Any(y => y.IdTipoEstado == IdTipoEstadoOrdSentencia)
                        )
                    );

                #endregion

                #endregion

                #region OrdinarioCs

                #region OrdinarioCs - Indicadores
                #endregion

                #region OrdinarioCs - Alarmas

                case TipoIndicadorQa.OrdinarioCsAlarmaVencimientoAllanamiento:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
                                                && x.IdEstadoLast.HasValue
                                                //&& lstExpedientesFinalizado.All(y => y != x.ExpedienteEstadoLast.IdTipoEstado)
                                                //&& lstExpedientesParalizado.All(y => y != x.ExpedienteEstadoLast.IdTipoEstado)
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdCsRecepcionExpediente
                                                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsRecepcion != null
                                                && x.ExpedienteEstadoLast.IdTipoSubFaseEstado != TipoFaseEstadoOcs0101

                                                && x.ExpedienteOrdinarioCs != null
                                                && !x.ExpedienteOrdinarioCs.AllanamientoFecha.HasValue
                                                && x.ExpedienteOrdinarioCs.FechaNotificacionDemanda.HasValue
                                                && x.ExpedienteOrdinarioCs.FechaNotificacionDemanda < FechaActualMenos13
                    );

                case TipoIndicadorQa.OrdinarioCsAlarmaPendienteCopiaSelladaAllanamiento:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
                                                && x.IdEstadoLast.HasValue
                                                && lstExpedientesFinalizado.All(y => y != x.ExpedienteEstadoLast.IdTipoEstado)
                                                && lstExpedientesParalizado.All(y => y != x.ExpedienteEstadoLast.IdTipoEstado)
                                                && x.ExpedienteOrdinarioCs != null
                                                && !x.ExpedienteOrdinarioCs.FechaAllanamientoCopiaSellada.HasValue
                                                && x.ExpedienteOrdinarioCs.AllanamientoFecha.HasValue
                                                && x.ExpedienteOrdinarioCs.AllanamientoFecha < FechaActualMenos3
                    );

                case TipoIndicadorQa.OrdinarioCsAlarmaSentencia:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
                                                && x.IdEstadoLast.HasValue
                                                && x.ExpedienteEstadoes.All(ee => ee.IdTipoEstado != IdTipoEstadoOrdCsSentencia)
                                                && x.ExpedienteOrdinarioCs != null
                                                && x.ExpedienteOrdinarioCs.FechaAllanamientoCopiaSellada.HasValue
                                                && x.ExpedienteOrdinarioCs.FechaAllanamientoCopiaSellada < FechaActualMenos90
                    );

                case TipoIndicadorQa.OrdinarioCsAlarmaSentenciaSinCostasAbonadas:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
                                                && x.IdEstadoLast.HasValue
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdCsSentencia
                                                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia != null
                                                && !x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia.CostasAbonadas
                                                && x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoOcs0705
                                                && x.ExpedienteEstadoLast.Fecha < FechaActualMenos15
                    );

                case TipoIndicadorQa.OrdinarioCsAlarmaPendienteFinalizacion:
                    var lstSubFases = new List<int?> { TipoFaseEstadoOcs0703, TipoFaseEstadoOcs0704, TipoFaseEstadoOcs0705, TipoFaseEstadoOcs0708, TipoFaseEstadoOcs0709 };
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
                                                && x.IdEstadoLast.HasValue
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdCsSentencia
                                                && !lstSubFases.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado)
                                                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia.SentenciaFecha.HasValue
                                                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia.SentenciaFecha < FechaActualMenos40
                    );

                #endregion

                #region OrdinarioCs - Facturas

                case TipoIndicadorQa.OrdinarioCsFacturasBancoPopularHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
                                                && x.IdClienteOficina == IdOficinaBancoPopular
                                                && x.ExpedienteOrdinarioCs != null
                                                && x.ExpedienteOrdinarioCs.AllanamientoFecha.HasValue
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.OrdinarioCsHito1)
                    );

                case TipoIndicadorQa.OrdinarioCsFacturasBancoPopularHito2:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
                                                && x.IdClienteOficina == IdOficinaBancoPopular
                                                && x.ExpedienteOrdinarioCs != null
                                                && x.ExpedienteEstadoLast != null
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdCsFinalizacion
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.OrdinarioCsHito2)
                    );

                case TipoIndicadorQa.OrdinarioCsFacturasHito2PendienteFinalizar:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
                                                && x.IdEstadoLast.HasValue
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdCsSentencia
                                                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia != null
                                                //&& !x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia.Apelacion
                                                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia.SentenciaFecha.HasValue
                                                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia.SentenciaFecha < FechaActualMenos30
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.OrdinarioCsHito2)
                    );

                #endregion

                #endregion

                #region TPA

                #region TPA - Indicadores / Facturas

                //case TipoIndicadorQa.TpaFacturasPendientesHito1:
                //    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteTpa
                //                                && x.ExpedienteNegociacion != null
                //                                //&& x.ExpedienteNegociacion.PrecontenciosoFechaLocalizado.HasValue
                //                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.TpaHito1)
                //    );
                //case TipoIndicadorQa.TpaFacturasPendientesHito2:
                //    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteTpa
                //                                && x.ExpedienteNegociacion != null
                //                                && x.ExpedienteNegociacion.ContenciosoNegociacionFinalizadaPor == 3 //Finalización Toma de posesión Anticipada
                //                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.TpaHito2)
                //    );

                #endregion

                #region TPA - Alarmas

                //case TipoIndicadorQa.OrdinarioCsAlarmaVencimientoAllanamiento:
                //    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
                //                                && x.IdEstadoLast.HasValue
                //                                //&& lstExpedientesFinalizado.All(y => y != x.ExpedienteEstadoLast.IdTipoEstado)
                //                                //&& lstExpedientesParalizado.All(y => y != x.ExpedienteEstadoLast.IdTipoEstado)
                //                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdCsRecepcionExpediente
                //                                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsRecepcion != null
                //                                && x.ExpedienteEstadoLast.IdTipoSubFaseEstado != TipoFaseEstadoOcs0101

                //                                && x.ExpedienteOrdinarioCs != null
                //                                && !x.ExpedienteOrdinarioCs.AllanamientoFecha.HasValue
                //                                && x.ExpedienteOrdinarioCs.FechaNotificacionDemanda.HasValue
                //                                && x.ExpedienteOrdinarioCs.FechaNotificacionDemanda < FechaActualMenos13
                //    );

                //case TipoIndicadorQa.OrdinarioCsAlarmaPendienteCopiaSelladaAllanamiento:
                //    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
                //                                && x.IdEstadoLast.HasValue
                //                                && lstExpedientesFinalizado.All(y => y != x.ExpedienteEstadoLast.IdTipoEstado)
                //                                && lstExpedientesParalizado.All(y => y != x.ExpedienteEstadoLast.IdTipoEstado)
                //                                && x.ExpedienteOrdinarioCs != null
                //                                && !x.ExpedienteOrdinarioCs.FechaAllanamientoCopiaSellada.HasValue
                //                                && x.ExpedienteOrdinarioCs.AllanamientoFecha.HasValue
                //                                && x.ExpedienteOrdinarioCs.AllanamientoFecha < FechaActualMenos3
                //    );

                #endregion

                #endregion

                #region JC

                #region JC - Indicadores / Facturas

                case TipoIndicadorQa.JcFacturasPendientesHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteJuraCuenta
                                                && !x.FacturacionCompleta && !x.EsNofacturable
                                                && x.FechaFacturableH1.HasValue
                                                && x.FechaFacturableH1 < FechaActual
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.Hito1)
                    );
                case TipoIndicadorQa.JcFacturasPendientesHito1ConHito2:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteJuraCuenta
                                                && !x.FacturacionCompleta && !x.EsNofacturable
                                                && x.FacturaSet.Any()
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.Hito1)
                    );
                case TipoIndicadorQa.JcFacturasPendientesHito2:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteJuraCuenta
                                                && !x.FacturacionCompleta && !x.EsNofacturable
                                                && x.FechaFacturableH2.HasValue
                                                && x.FechaFacturableH2 < FechaActual
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.Hito2)
                    );

                #endregion

                #region JC - Alarmas

                #endregion

                #endregion

                #region Concursal (ReI, MyC)

                #region Concursal - Facturas

                case TipoIndicadorQa.MyCFacturasPendientesHito1:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
                                                && x.FechaFacturableH1.HasValue
                                                && x.FechaFacturableH1 < FechaActual
                                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.Hito1)
                    );

                case TipoIndicadorQa.MyCFacturasAbanca52:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
                                                && x.Gnr_ClienteOficina.IdCliente == IdClienteAbanca
                                                && x.ExpedienteHitoSet.Any(y => y.IdTipoHitoProcesal == ID_TIPO_HITO_PROCESAL_CONCURSAL_52)
                                                && x.FacturaSet.All(f => f.IdTipoHitoProcesal != ID_TIPO_HITO_PROCESAL_CONCURSAL_52)
                    );

                #endregion

                #region Concursal - Alarmas 

                case TipoIndicadorQa.ConcursoAlarmaCumplidoHito01:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
                        && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.TipoHitoProcesal.Orden == 1)
                    );

                case TipoIndicadorQa.ConcursoAlarmaCumplidoHito57:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
                        && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.TipoHitoProcesal.Orden == 57)
                    );

                case TipoIndicadorQa.ConcursoAlarmaCumplidoHito14_18:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
                        && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.TipoHitoProcesal.Orden == 14 && y.Fecha < FechaActualMenos540)
                    );

                case TipoIndicadorQa.ConcursoAlarmaCumplidoHito14_48:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
                        && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.TipoHitoProcesal.Orden == 14 && y.Fecha < FechaActualMenos1440)
                    );

                case TipoIndicadorQa.ConcursoAlarmaCumplidoHito73:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
                        && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.TipoHitoProcesal.Orden == 73)
                    );

                case TipoIndicadorQa.ConcursoAlarmaCumplidoHito74:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
                        && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.TipoHitoProcesal.Orden == 74)
                    );

                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_01:
                    int[] arr1 = { 8, 419, 751, 571, 574, 586, 883, 920 };
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
                        && x.Inicio >= Fecha20210101
                        && arr1.Contains(x.IdClienteOficina)
                        //&& ((int[])({ 1, 8 })).Contains(x.IdClienteOficina)
                        && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_01 && y.Fecha <= FechaActual)
                    );

                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_57:
                    int[] arr2 = { 8, 571 };
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
                        && x.Inicio >= Fecha20210101
                        && arr2.Contains(x.IdClienteOficina)
                        && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_57 && y.Fecha <= FechaActual)
                    );

                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_14_18m:
                    int[] arr3 = { 8 };
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
                        && x.Inicio >= Fecha20210101
                        && arr3.Contains(x.IdClienteOficina)
                        && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_14 && y.Fecha <= FechaActualMenos540)
                    );

                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_14_48m:
                    int[] arr4 = { -1, 8 };
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
                        && x.Inicio >= Fecha20210101
                        && arr4.Contains(x.IdClienteOficina)
                        && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_14 && y.Fecha <= FechaActualMenos1440)
                    );

                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_74:
                    int[] arr5 = { 8, 419, 751, 571, 574, 1, 883, 920 };
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
                        && x.Inicio >= Fecha20210101
                        && arr5.Contains(x.IdClienteOficina)
                        && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_74 && y.Fecha <= FechaActual)
                    );

                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_78:
                    int[] arr6 = { 8 };
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
                        && x.Inicio >= Fecha20210101
                        && arr6.Contains(x.IdClienteOficina)
                        && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_78 && y.Fecha <= FechaActual)
                    );

                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_79:
                    int[] arr7 = { 8 };
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
                        && x.Inicio >= Fecha20210101
                        && arr7.Contains(x.IdClienteOficina)
                        && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_79 && y.Fecha <= FechaActual)
                    );

                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_73:
                    int[] arr8 = { 8, 419, 751, 571, 574 };
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
                        && x.Inicio >= Fecha20210101
                        && arr8.Contains(x.IdClienteOficina)
                        && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_73 && y.Fecha <= FechaActual)
                    );
                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_52:
                    int[] arr9 = { 8, 419, 751, 571, 574, 586, 1, 883, 920 };
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
                        && x.Inicio >= Fecha20210101
                        && arr9.Contains(x.IdClienteOficina)
                        && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_52 && y.Fecha <= FechaActual)
                    );
                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_54:
                    int[] arr10 = { 8, 419, 751, 571, 574, 586, 1, 883, 920 };
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
                        && x.Inicio >= Fecha20210101
                        && arr10.Contains(x.IdClienteOficina)
                        && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_54 && y.Fecha <= FechaActual)
                    );
                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_55:
                    int[] arr11 = { 8, 419, 751, 571, 574, 586, 1, 883, 920 };
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
                        && x.Inicio >= Fecha20210101
                        && arr11.Contains(x.IdClienteOficina)
                        && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_55 && y.Fecha <= FechaActual)
                    );
                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_56:
                    int[] arr12 = { 8, 419, 751, 571, 574, 586, 1, 883, 920 };
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
                        && x.Inicio >= Fecha20210101
                        && arr12.Contains(x.IdClienteOficina)
                        && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_56 && y.Fecha <= FechaActual)
                    );
                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_63:
                    int[] arr13 = { 8, 419, 751, 574 };
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
                        && x.Inicio >= Fecha20210101
                        && arr13.Contains(x.IdClienteOficina)
                        && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_63 && y.Fecha <= FechaActual)
                    );
                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_64:
                    int[] arr14 = { 8, 419, 751, 574 };
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
                        && x.Inicio >= Fecha20210101
                        && arr14.Contains(x.IdClienteOficina)
                        && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_64 && y.Fecha <= FechaActual)
                    );

                #endregion

                #endregion

                #region JV

                #region JV - Indicadores
                #endregion

                #region JV - Alarmas

                case TipoIndicadorQa.JvAlarmaPdteAdmision:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteJv
                        && x.ExpedienteJV.FechaEnvioProcurador.HasValue
                        && x.ExpedienteJV.FechaEnvioProcurador < FechaActualMenos30
                    //&& x.ExpedienteEscrituraSet.Any(y =>
                    //    !y.AdmisionFecha.HasValue)
                    );

                case TipoIndicadorQa.JvAlarmaPdteLibradoMandamiento:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteJv
                    //&& x.ExpedienteEscrituraSet.Any(y =>
                    //    //!y.AdmisionFecha.HasValue
                    //    //&& 
                    //    y.MandamientoFechaAutoLibrar.HasValue
                    //    && y.MandamientoFechaAutoLibrar < FechaActualMenos45)
                    );

                case TipoIndicadorQa.JvAlarmaPdteNotificacion:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteJv
                    //&& x.ExpedienteEscrituraSet.Any(y =>
                    //    !y.NotificacionFechaVistaJurisdiccionVoluntaria.HasValue
                    //    && y.AdmisionFecha.HasValue
                    //    && y.AdmisionFecha < FechaActualMenos30)
                    );

                case TipoIndicadorQa.JvAlarmaPdteRecepcionEscritura:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteJv
                        && x.ExpedienteJV.FechaRecepcion.HasValue
                    //&& x.ExpedienteEscrituraSet.Any(y =>
                    //    y.MandamientoFechaLibrado.HasValue
                    //    && y.MandamientoFechaLibrado < FechaActualMenos30)
                    );

                case TipoIndicadorQa.JvAlarmaRecepcionDemandaSellada:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteJv
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoJvPresentDemanda
                        && x.ExpedienteEstadoLast.JvExpedienteEstadoPresentacionDemanda != null
                        && !x.ExpedienteEstadoLast.JvExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
                        && x.ExpedienteEstadoLast.JvExpedienteEstadoPresentacionDemanda.FechaEnvioProcurador.HasValue
                        && x.ExpedienteEstadoLast.JvExpedienteEstadoPresentacionDemanda.FechaEnvioProcurador < FechaActualMenos3
                    );

                //case TipoIndicadorQa.OrdinarioCsAlarmaPendienteCopiaSelladaAllanamiento:
                //    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
                //                                && x.IdEstadoLast.HasValue
                //                                && lstExpedientesFinalizado.All(y => y != x.ExpedienteEstadoLast.IdTipoEstado)
                //                                && lstExpedientesParalizado.All(y => y != x.ExpedienteEstadoLast.IdTipoEstado)
                //                                && x.ExpedienteOrdinarioCs != null
                //                                && !x.ExpedienteOrdinarioCs.FechaAllanamientoCopiaSellada.HasValue
                //                                && x.ExpedienteOrdinarioCs.AllanamientoFecha.HasValue
                //                                && x.ExpedienteOrdinarioCs.AllanamientoFecha < FechaActualMenos3
                //    );

                //case TipoIndicadorQa.OrdinarioCsAlarmaSentencia:
                //    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
                //                                && x.IdEstadoLast.HasValue
                //                                && x.ExpedienteEstadoes.All(ee => ee.IdTipoEstado != IdTipoEstadoOrdCsSentencia)
                //                                && x.ExpedienteOrdinarioCs != null
                //                                && x.ExpedienteOrdinarioCs.FechaAllanamientoCopiaSellada.HasValue
                //                                && x.ExpedienteOrdinarioCs.FechaAllanamientoCopiaSellada < FechaActualMenos90
                //    );

                //case TipoIndicadorQa.OrdinarioCsAlarmaSentenciaSinCostasAbonadas:
                //    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
                //                                && x.IdEstadoLast.HasValue
                //                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdCsSentencia
                //                                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia != null
                //                                && !x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia.CostasAbonadas
                //                                && x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoOcs0705
                //                                && x.ExpedienteEstadoLast.Fecha < FechaActualMenos15
                //    );

                //case TipoIndicadorQa.OrdinarioCsAlarmaPendienteFinalizacion:
                //    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
                //                                && x.IdEstadoLast.HasValue
                //                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdCsSentencia
                //                                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia != null
                //                                && !x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia.Apelacion
                //                                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia.SentenciaFecha.HasValue
                //                                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia.SentenciaFecha < FechaActualMenos30
                //    );

                #endregion

                #region JV - Facturas

                #endregion

                #endregion

                #region Monitorio

                #region Monitorio - Indicadores

                case TipoIndicadorQa.MonitorioPdteExpVerbal:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMonitorio
                                                && x.IdTipoEstadoLast.HasValue
                                                && x.ExpedienteEstadoLast != null
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoMnTramitJuzgado
                                                && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioTramitacionJuzgado != null
                                                && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioTramitacionJuzgado.TrasladoOposicionFecha.HasValue
                                                && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioTramitacionJuzgado.ImporteAdmision.HasValue
                                                && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioTramitacionJuzgado.ImporteAdmision.Value < 6000
                                                && !x.ExpedienteMonitorio.IdExpedienteVb.HasValue
                                                && !x.ExpedienteMonitorio.IdExpedienteOrd.HasValue
                                                && !x.ExpedienteMonitorio.IdExpedienteEjc.HasValue
                    );

                case TipoIndicadorQa.MonitorioPdteExpOrdinario:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMonitorio
                                                && x.IdTipoEstadoLast.HasValue
                                                && x.ExpedienteEstadoLast != null
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoMnTramitJuzgado
                                                && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioTramitacionJuzgado != null
                                                && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioTramitacionJuzgado.TrasladoOposicionFecha.HasValue
                                                && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioTramitacionJuzgado.ImporteAdmision.HasValue
                                                && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioTramitacionJuzgado.ImporteAdmision.Value >= 6000
                                                && !x.ExpedienteMonitorio.IdExpedienteVb.HasValue
                                                && !x.ExpedienteMonitorio.IdExpedienteOrd.HasValue
                                                && !x.ExpedienteMonitorio.IdExpedienteEjc.HasValue
                    );

                case TipoIndicadorQa.MonitorioPdteExpEjecutivo:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMonitorio
                                                && x.IdTipoEstadoLast.HasValue
                                                && x.ExpedienteEstadoLast != null
                                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoMnTramitJuzgado
                                                && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioTramitacionJuzgado != null
                                                && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioTramitacionJuzgado.DecretoArchivoFecha.HasValue
                                                && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioTramitacionJuzgado.TipoDecretoArchivo == TipoDecretoArchivo.SinPago
                                                && !x.ExpedienteMonitorio.IdExpedienteVb.HasValue
                                                && !x.ExpedienteMonitorio.IdExpedienteOrd.HasValue
                                                && !x.ExpedienteMonitorio.IdExpedienteEjc.HasValue
                    );

                #endregion

                #region Monitorio - Alarmas 

                case TipoIndicadorQa.MonitorioAlarmaRecepcionDemandaSellada:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMonitorio
                        && x.IdEstadoLast.HasValue
                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoMnPresentDemanda
                        && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioPresentacionDemanda != null
                        && !x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioPresentacionDemanda.FechaPresentacion.HasValue
                        && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioPresentacionDemanda.FechaEnvioProcurador.HasValue
                        && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioPresentacionDemanda.FechaEnvioProcurador < FechaActualMenos3
                    );

                case TipoIndicadorQa.MonitorioAlarmaSucesionCopiaSellada:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMonitorio
                        && !x.SucesionCopiaSellada.HasValue
                        && x.SucesionPresentada.HasValue
                        && x.SucesionPresentada < FechaActualMenos2
                    );

                #endregion

                #region Facturas

                case TipoIndicadorQa.MonitorioFacturaHito1:
                    return queryBase.Where(x =>
                        x.IdTipoExpediente == IdTipoExpedienteMonitorio
                        && !x.FacturaSet.Any()
                        && x.Fin.HasValue
                    );

                #endregion

                #endregion

                #region MultiDivisa

                #region MultiDivisa - Indicadores

                case TipoIndicadorQa.MultiDivisaPendienteContacto:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMultiDivisa
                        && x.ExpedienteMultiDivisa != null
                        && x.ExpedienteMultiDivisa.IdFinalizadoPor == IdEstadoNegocNoContactado
                    );

                case TipoIndicadorQa.MultiDivisaContactoEnNegociacion:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMultiDivisa
                        && x.ExpedienteMultiDivisa != null
                        && x.ExpedienteMultiDivisa.IdFinalizadoPor == IdEstadoNegocEnNegociacion
                    );

                case TipoIndicadorQa.MultiDivisaContactoConAcuerdo:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMultiDivisa
                        && x.ExpedienteMultiDivisa != null
                        && x.ExpedienteMultiDivisa.IdFinalizadoPor == IdEstadoNegocAceptado
                    );

                case TipoIndicadorQa.MultiDivisaFinalizadoConExito:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMultiDivisa
                        && x.ExpedienteMultiDivisa != null
                        && x.Fin.HasValue
                        && x.ExpedienteMultiDivisa.IdFinalizadoPor == IdEstadoNegocFirmado
                    );

                case TipoIndicadorQa.MultiDivisaFinalizadoLocalizado:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMultiDivisa
                        && x.ExpedienteMultiDivisa != null
                        && x.Fin.HasValue
                        && x.ExpedienteMultiDivisa.IdFinalizadoPor == IdEstadoNegocRechazado
                    );

                case TipoIndicadorQa.MultiDivisaFinalizadoNoLocalizado:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMultiDivisa
                        && x.ExpedienteMultiDivisa != null
                        && x.Fin.HasValue
                        && x.ExpedienteMultiDivisa.IdFinalizadoPor == IdEstadoNegocNoContactado
                    );

                case TipoIndicadorQa.MultiDivisaFinalizadoExcluido:
                    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMultiDivisa
                        && x.ExpedienteMultiDivisa != null
                        && x.Fin.HasValue
                        && (x.ExpedienteMultiDivisa.IdFinalizadoPor == IdEstadoNegocExcluido || x.ExpedienteMultiDivisa.IdFinalizadoPor == IdEstadoNegocExcluidoPorCliente)
                    );

                #endregion

                #region MultiDivisa - Alarmas 

                #endregion

                #region Facturas

                #endregion

                #endregion

                #region Procura

                #region Procura - Factura

                case TipoIndicadorQa.ProcuraFacturasHito1:
                    return queryBase.Where(x =>
                        x.IdTipoExpediente == IdTipoExpedienteProcura
                        && !x.EsNofacturable
                        && !x.FacturacionCompleta
                        && x.Fin.HasValue
                        && !x.FacturaSet.Any()
                    );

                    #endregion

                    #endregion
            }

            return queryBase;
        }

        #region Inmuebles

        protected IQueryable<Hip_Inmueble> GetInmueblesByTipoIndicadorQa(TipoIndicadorQa tipoIndicadorQa, IQueryable<Hip_Inmueble> queryBase = null)
        {
            var db = _solvtioDbContext;
            if (queryBase == null) queryBase = db.Hip_Inmueble.AsQueryable();

            switch (tipoIndicadorQa)
            {
                case TipoIndicadorQa.EjecutivoProrrogaEmbargo:
                    return queryBase.Where(x => x.IdExpediente > 0
                                                && x.Expediente != null
                                                && x.Expediente.IdTipoExpediente == IdTipoExpedienteEjecutivo
                                                && !x.EjcFechaEmbargoInstruccionesNoProrrogar.HasValue
                                                && (x.EjcFechaInscripcion.HasValue || x.EjcFechaEmbargoSolicitudProrroga.HasValue)
                    );

                case TipoIndicadorQa.EjecutivoAlarmaProrrogaEmbargo:
                    return queryBase.Where(x => x.IdExpediente > 0
                                                && x.Expediente != null
                                                && x.Expediente.IdTipoExpediente == IdTipoExpedienteEjecutivo
                                                && !x.EjcFechaEmbargoInstruccionesNoProrrogar.HasValue
                                                && (
                                                    (x.EjcFechaInscripcion.HasValue && x.EjcFechaInscripcion < FechaActualMenos1277)
                                                    ||
                                                    (x.EjcFechaEmbargoSolicitudProrroga.HasValue && x.EjcFechaEmbargoSolicitudProrroga < FechaActualMenos1277)
                                                )
                    );


                case TipoIndicadorQa.RealEstateResidencial:
                    return queryBase.Where(x => x.Hip_TipoInmueble.IdTipologia == IdTipologiaInmuebleResidencial && !x.Expediente.Fin.HasValue);
                case TipoIndicadorQa.RealEstateTerciarios:
                    return queryBase.Where(x => x.Hip_TipoInmueble.IdTipologia == IdTipologiaInmuebleTerciario && !x.Expediente.Fin.HasValue);
                case TipoIndicadorQa.RealEstateDotacional:
                    return queryBase.Where(x => x.Hip_TipoInmueble.IdTipologia == IdTipologiaInmuebleDotacional && !x.Expediente.Fin.HasValue);
                case TipoIndicadorQa.RealEstateSuelos:
                    return queryBase.Where(x => x.Hip_TipoInmueble.IdTipologia == IdTipologiaInmuebleSuelos && !x.Expediente.Fin.HasValue);

                case TipoIndicadorQa.RealEstateNpls:
                    return queryBase.Where(x => x.Expediente.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && x.Expediente.ExpedienteEstadoLast.IdTipoEstado != IdTipoEstadoHipAdjudicacion
                        && x.Expediente.ExpedienteEstadoLast.IdTipoEstado != IdTipoEstadoHipFinalizado);
                case TipoIndicadorQa.RealEstateReos:
                    return queryBase.Where(x => x.Expediente.IdTipoExpediente == IdTipoExpedienteHipotecario
                        && (
                            x.Expediente.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipAdjudicacion
                            || x.Expediente.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipFinalizado
                        ));
                case TipoIndicadorQa.RealEstateConcursos:
                    return queryBase.Where(x => x.Expediente.IdTipoExpediente == IdTipoExpedienteConcurso
                        && x.Expediente.ExpedienteEstadoLast.IdTipoEstado != IdTipoEstadoHipFinalizado);

            }

            return queryBase;
        }

        #endregion

        #endregion

    }
}
