using Microsoft.EntityFrameworkCore;
using Solvtio.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Configuration;

using Solvtio.Models.Mapping;
using System.Linq;
using System.Data.Entity.ModelConfiguration;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Solvtio.Data
{
    public class SolvtioDbContext : DbContext
    {
        #region Constructors

        //public SolvtioDbContext() { }
        public SolvtioDbContext(DbContextOptions<SolvtioDbContext> options) : base(options) { }







        

        #endregion

        #region DbSet

        //        Message	"A relationship cycle involving the primary keys of the following enitity types was detected:
        //        'AlqExpedienteEstadoEnervacion -> ExpedienteEstado'.
        //        This would prevent any entity to be inserted without violating the store constraints. Review the foreign keys defined on the primary keys and either remove or use other properties for at least one of them."	string


        public DbSet<Configuracion> ConfiguracionSet { get; set; }
        public DbSet<CaracteristicaBase> CaracteristicaBaseSet { get; set; }
        public DbSet<Expediente> ExpedienteSet { get; set; }

        public DbSet<ModelExpedienteToKpi> ModelExpedienteToKpiSet { get; set; }


        #region Tablas Comunes
        public DbSet<NotificacionMail> NotificacionMailSet { get; set; }
        public DbSet<NotificacionMailAttachment> NotificacionMailAttachmentSet { get; set; }
        public DbSet<NotificacionMailAsignacion> NotificacionMailAsignacionSet { get; set; }
        public DbSet<NotificacionMailTimeline> NotificacionMailTimelineSet { get; set; }
        public DbSet<NotificacionBuzon> NotificacionBuzonSet { get; set; }

        public DbSet<TipoNotificacion> TipoNotificacionSet { get; set; }
        public DbSet<TipoAreaNotificacion> TipoAreaNotificacionSet { get; set; }
        public DbSet<Holiday> HolidaySet { get; set; }
        public DbSet<JobResult> JobResultSet { get; set; }

        public DbSet<ActividadAbogado> ActividadAbogadoSet { get; set; }
        public DbSet<ActividadAbogadoDetalle> ActividadAbogadoDetalleSet { get; set; }

        #endregion

        #region Usuario
        public DbSet<Usuario> UsuarioSet { get; set; }
        public DbSet<UsuarioRole> UsuarioRoleSet { get; set; }
        public DbSet<Role> RoleSet { get; set; }
        public DbSet<RolePage> RolePageSet { get; set; }
        public DbSet<UsuarioLog> UsuarioLogSet { get; set; }
        public DbSet<Grupo> GrupoSet { get; set; }
        public DbSet<GrupoUsuario> GrupoUsuarioSet { get; set; }
        public DbSet<Nomina> NominaSet { get; set; }

        #endregion

        #region Nomencladores

        public DbSet<ComunidadAutonoma> ComunidadAutonomaSet { get; set; }
        public DbSet<Provincia> ProvinciaSet { get; set; }
        public DbSet<Municipio> MunicipioSet { get; set; }
        public DbSet<CodigoPostal> CodigoPostalSet { get; set; }
        public DbSet<Juzgado> JuzgadoSet { get; set; }
        public DbSet<TramiteJudicial> TramiteJudicialSet { get; set; }
        public DbSet<JuzgadoTramiteJudicial> JuzgadoTramiteJudicialSet { get; set; }
        public DbSet<Area> AreaSet { get; set; }
        public DbSet<AreaNegocio> AreaNegocioSet { get; set; }
        public DbSet<HitoFacturacion> HitoFacturacionSet { get; set; }
        public DbSet<Sla> SlaSet { get; set; }
        public DbSet<SlaOficina> SlaOficinaSet { get; set; }
        public DbSet<TipoSubFaseEstado> TipoSubFaseEstadoSet { get; set; }
        public DbSet<TipoIncidenciaEstado> TipoIncidenciaEstadoSet { get; set; }
        public DbSet<Cartera> CarteraSet { get; set; }
        public DbSet<EntidadGestora> EntidadGestoraSet { get; set; }
        public DbSet<EntidadGestoraGestor> EntidadGestoraGestorSet { get; set; }
        public DbSet<FacturadorRegla> FacturadorReglaSet { get; set; }
        public DbSet<Proveedor> ProveedorSet { get; set; }
        public DbSet<Informe> InformeSet { get; set; }

        #endregion

        #region Facturacion
        public DbSet<Hito> HitoSet { get; set; }
        public DbSet<HitoExpediente> HitoExpedienteSet { get; set; }
        public DbSet<ContratoFactura> ContratoFacturaSet { get; set; }
        public DbSet<ContratoFacturaCondicion> ContratoFacturaCondicionSet { get; set; }

        #endregion

        #region Expediente - Hijos Comunes

        public DbSet<ExpedienteNegociacion> ExpedienteNegociacionSet { get; set; }
        public DbSet<ExpedienteJurisdiccionVoluntaria> ExpedienteJurisdiccionVoluntariaSet { get; set; }
        public DbSet<ExpedienteInscripcionCredito> ExpedienteInscripcionCreditoSet { get; set; }
        public DbSet<ExpedienteEscritura> ExpedienteEscrituraSet { get; set; }
        public DbSet<ExpedienteSubasta> ExpedienteSubastaSet { get; set; }
        public DbSet<ExpedienteNota> ExpedienteNotaSet { get; set; }
        public DbSet<ExpedienteHito> ExpedienteHitoSet { get; set; }
        public DbSet<Impulso> ImpulsoSet { get; set; }
        public DbSet<Actuacion> ActuacionSet { get; set; }
        public DbSet<Mediacion> MediacionSet { get; set; }
        public DbSet<ExpedienteHitoProcesal> ExpedienteHitoProcesalSet { get; set; }
        public DbSet<ExpedienteVencimiento> ExpedienteVencimientoSet { get; set; }
        public DbSet<ExpedienteParalizado> ExpedienteParalizadoSet { get; set; }
        public DbSet<ExpedientePrestamo> ExpedientePrestamoSet { get; set; }
        public DbSet<ExpedienteHora> ExpedienteHoraSet { get; set; }
        public DbSet<ExpedienteContrato> ExpedienteContratoSet { get; set; }
        public DbSet<ExpedienteContratoRecuperacion> ExpedienteContratoRecuperacionSet { get; set; }
        public DbSet<ExpedienteContratoDeudaDesglose> ExpedienteContratoDeudaDesgloseSet { get; set; }
        public DbSet<ExpedienteResolucionJudicial> ExpedienteResolucionJudicialSet { get; set; }
        public DbSet<ExpedienteAcuerdo> ExpedienteAcuerdoSet { get; set; }
        public DbSet<ExpedienteRecursoReposicion> ExpedienteRecursoReposicionSet { get; set; }

        public DbSet<ExpedienteFaseCliente> ExpedienteFaseClienteSet { get; set; }
        public DbSet<FaseCliente> FaseClienteSet { get; set; }
        public DbSet<MotivoCliente> MotivoClienteSet { get; set; }

        #endregion

        #region ExpedienteEstado

        public DbSet<ExpedienteEstadoCitacion> ExpedienteEstadoCitacionSet { get; set; }
        public DbSet<ExpedienteEstadoAbogadoHistorico> ExpedienteEstadoAbogadoHistoricoSet { get; set; }
        public DbSet<ExpedienteEstadoParalizado> ExpedienteEstadoParalizadoSet { get; set; }
        public DbSet<ExpedienteEstadoJurisdiccionVoluntaria> ExpedienteEstadoJurisdiccionVoluntariaSet { get; set; }

        #endregion

        #region ExpedienteOrdinario

        public DbSet<ExpedienteOrdinario> ExpedienteOrdinarioSet { get; set; }

        public DbSet<ExpedienteEstadoOrdinarioRecepcion> ExpedienteEstadoOrdinarioRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioPresentacionDemanda> ExpedienteEstadoOrdinarioPresentacionDemandaSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioTramitacionJuzgado> ExpedienteEstadoOrdinarioTramitacionJuzgadoSet { get; set; }
        //public DbSet<ExpedienteEstadoOrdinarioDatoRequerimiento> ExpedienteEstadoOrdinarioDatoRequerimientoSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioProcesoParalizado> ExpedienteEstadoOrdinarioProcesoParalizadoSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioSubasta> ExpedienteEstadoOrdinarioSubastaSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioAdjudicacion> ExpedienteEstadoOrdinarioAdjudicacionSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioNegociacionPosesion> ExpedienteEstadoOrdinarioNegociacionPosesionSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioFinalizacion> ExpedienteEstadoOrdinarioFinalizacionSet { get; set; }

        public DbSet<ExpedienteEstadoOrdinarioJuicio> ExpedienteEstadoOrdinarioJuicioSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioAutoAdmisionNotificacion> ExpedienteEstadoOrdinarioAutoAdmisionNotificacionSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioSentencia> ExpedienteEstadoOrdinarioSentenciaSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioEjecucionSentencia> ExpedienteEstadoOrdinarioEjecucionSentenciaSet { get; set; }

        #endregion

        #region ExpedienteOrdinarioCs 

        public DbSet<ExpedienteOrdinarioCs> ExpedienteOrdinarioCsSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsRecepcion> ExpedienteEstadoOrdinarioCsRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsAudienciaPrevia> ExpedienteEstadoOrdinarioCsAudienciaPreviaSet { get; set; }

        public DbSet<ExpedienteEstadoOrdinarioCsTramitacionJuzgado> ExpedienteEstadoOrdinarioCsTramitacionJuzgadoSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsProcesoParalizado> ExpedienteEstadoOrdinarioCsProcesoParalizadoSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsSubasta> ExpedienteEstadoOrdinarioCsSubastaSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsAdjudicacion> ExpedienteEstadoOrdinarioCsAdjudicacionSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsNegociacionPosesion> ExpedienteEstadoOrdinarioCsNegociacionPosesionSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsFinalizacion> ExpedienteEstadoOrdinarioCsFinalizacionSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsJuicio> ExpedienteEstadoOrdinarioCsJuicioSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsAutoAdmisionNotificacion> ExpedienteEstadoOrdinarioCsAutoAdmisionNotificacionSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsEjecucionSentencia> ExpedienteEstadoOrdinarioCsEjecucionSentenciaSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsSentencia> ExpedienteEstadoOrdinarioCsSentenciaSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsAllanamientoTotal> ExpedienteEstadoOrdinarioCsAllanamientoTotalSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsAllanamientoParcial> ExpedienteEstadoOrdinarioCsAllanamientoParcialSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsAcuerdo> ExpedienteEstadoOrdinarioCsAcuerdoSet { get; set; }
        public DbSet<ExpedienteEstadoOrdinarioCsContestacionDemanda> ExpedienteEstadoOrdinarioCsContestacionDemandaSet { get; set; }

        #endregion

        #region Hipotecario

        public DbSet<HipExpedienteEstadoGeneracion> HipExpedienteEstadoGeneracionSet { get; set; }

        public DbSet<Hip_ExpedienteEstadoAdjudicacionVencimiento> Hip_ExpedienteEstadoAdjudicacionVencimientoSet { get; set; }

        #endregion

        #region Alquiler

        public DbSet<AlqExpedienteEstadoEnervacion> AlqExpedienteEstadoEnervacionSet { get; set; }
        public DbSet<AlqExpedienteEstadoEnervacionPago> AlqExpedienteEstadoEnervacionPagoSet { get; set; }
        public DbSet<AlqExpedienteEstadoProcesoParalizado> AlqExpedienteEstadoProcesoParalizadoSet { get; set; }
        public DbSet<AlqExpedienteEstadoPresentacionDenuncia> AlqExpedienteEstadoPresentacionDenunciaSet { get; set; }
        public DbSet<AlqExpedienteEstadoTramitacionDenuncia> AlqExpedienteEstadoTramitacionDenunciaSet { get; set; }

        #endregion

        #region Ejecutivo

        public DbSet<Ejc_Expediente> Ejc_Expediente { get; set; }
        public DbSet<Ejc_ExpedienteEstadoAdjudicacion> Ejc_ExpedienteEstadoAdjudicacionSet { get; set; }
        public DbSet<Ejc_ExpedienteEstadoEfectividadEmbargo> Ejc_ExpedienteEstadoEfectividadEmbargoSet { get; set; }
        public DbSet<Ejc_ExpedienteEstadoFinalizacion> Ejc_ExpedienteEstadoFinalizacionSet { get; set; }
        public DbSet<Ejc_ExpedienteEstadoNotificacion> Ejc_ExpedienteEstadoNotificacionSet { get; set; }
        public DbSet<Ejc_ExpedienteEstadoPresentacionDemanda> Ejc_ExpedienteEstadoPresentacionDemandaSet { get; set; }
        public DbSet<Ejc_ExpedienteEstadoRecepcion> Ejc_ExpedienteEstadoRecepcionSet { get; set; }
        public DbSet<Ejc_ExpedienteEstadoRequerimientoPago> Ejc_ExpedienteEstadoRequerimientoPagoSet { get; set; }
        public DbSet<Ejc_ExpedienteEstadoSolicitudSubasta> Ejc_ExpedienteEstadoSolicitudSubastaSet { get; set; }
        public DbSet<Ejc_ExpedienteEstadoSubasta> Ejc_ExpedienteEstadoSubastaSet { get; set; }
        public DbSet<Ejc_ExpedienteEstadoTramiteEmbargo> Ejc_ExpedienteEstadoTramiteEmbargoSet { get; set; }

        public DbSet<EjcExpedienteEstadoEnvioDemandaProcurador> EjcExpedienteEstadoEnvioDemandaProcuradorSet { get; set; }
        public DbSet<EjcExpedienteEstadoPresentacionEscrito579> EjcExpedienteEstadoPresentacionEscrito579Set { get; set; }

        public DbSet<ExpedienteDeudorEjcutivo> ExpedienteDeudorEjcutivoSet { get; set; }
        public DbSet<ExpedienteDeudorEjcutivoAveriguacion> ExpedienteDeudorEjcutivoAveriguacionSet { get; set; }
        public DbSet<ExpedienteDeudorMueble> ExpedienteDeudorMuebleSet { get; set; }
        //public DbSet<ExpedienteDeudorInmueble> ExpedienteDeudorInmuebleSet { get; set; }
        public DbSet<ExpedienteDeudorSalarioSaldo> ExpedienteDeudorSalarioSaldoSet { get; set; }


        public DbSet<ExpedienteSalarioSaldo> ExpedienteSalarioSaldoSet { get; set; }
        public DbSet<ExpedienteMueble> ExpedienteMuebleSet { get; set; }

        #endregion

        #region JV 

        public DbSet<ExpedienteJV> ExpedienteJVSet { get; set; }
        public DbSet<JvExpedienteEstadoRecepcion> JvExpedienteEstadoRecepcionSet { get; set; }
        public DbSet<JvExpedienteEstadoPresentacionDemanda> JvExpedienteEstadoPresentacionDemandaSet { get; set; }

        #endregion

        #region Monitorio

        public DbSet<ExpedienteMonitorio> ExpedienteMonitorioSet { get; set; }

        public DbSet<ExpedienteEstadoMonitorioRecepcion> ExpedienteEstadoMonitorioRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoMonitorioPresentacionDemanda> ExpedienteEstadoMonitorioPresentacionDemandaSet { get; set; }
        public DbSet<ExpedienteEstadoMonitorioTramitacionJuzgado> ExpedienteEstadoMonitorioTramitacionJuzgadoSet { get; set; }
        public DbSet<ExpedienteEstadoMonitorioFinalizacion> ExpedienteEstadoMonitorioFinalizacionSet { get; set; }

        #endregion

        #region Verbal

        public DbSet<ExpedienteVerbal> ExpedienteVerbalSet { get; set; }

        public DbSet<ExpedienteEstadoVerbalRecepcion> ExpedienteEstadoVerbalRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoVerbalPresentacionDemanda> ExpedienteEstadoVerbalPresentacionDemandaSet { get; set; }
        public DbSet<ExpedienteEstadoVerbalTramitacionJuzgado> ExpedienteEstadoVerbalTramitacionJuzgadoSet { get; set; }
        public DbSet<ExpedienteEstadoVerbalFinalizacion> ExpedienteEstadoVerbalFinalizacionSet { get; set; }

        #endregion

        #region ExpedienteMultiDivisa

        public DbSet<ExpedienteMultiDivisa> ExpedienteMultiDivisaSet { get; set; }

        public DbSet<ExpedienteEstadoMDRecepcion> ExpedienteEstadoMDRecepcionSet { get; set; }

        #endregion

        #region ExpedienteProcura

        public DbSet<ExpedienteProcura> ExpedienteProcuraSet { get; set; }

        public DbSet<ExpedienteEstadoProcuraRecepcion> ExpedienteEstadoProcuraRecepcionSet { get; set; }
        //public DbSet<ExpedienteEstadoProcuraFinalizacion> ExpedienteEstadoProcuraFinalizacionSet { get; set; }

        #endregion

        #region ExpedienteScne

        public DbSet<ExpedienteScne> ExpedienteScneSet { get; set; }

        //public DbSet<ExpedienteEstadoScneRecepcion> ExpedienteEstadoScneRecepcionSet { get; set; }
        //public DbSet<ExpedienteEstadoScneFinalizacion> ExpedienteEstadoScneFinalizacionSet { get; set; }

        #endregion

        #region ExpedienteBastanteo

        public DbSet<ExpedienteBastanteo> ExpedienteBastanteoSet { get; set; }

        public DbSet<ExpedienteEstadoBastanteoRecepcion> ExpedienteEstadoBastanteoRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoBastanteoFinalizacion> ExpedienteEstadoBastanteoFinalizacionSet { get; set; }

        #endregion

        #region ExpedientePrelitigio

        public DbSet<ExpedientePrelitigio> ExpedientePrelitigioSet { get; set; }
        public DbSet<ExpedienteDeudorBurofax> ExpedienteDeudorBurofaxSet { get; set; }

        public DbSet<ExpedienteEstadoPrelitigioRecepcion> ExpedienteEstadoPrelitigioRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoPrelitigioFinalizacion> ExpedienteEstadoPrelitigioFinalizacionSet { get; set; }

        #endregion

        #region ExpedienteTestamentario

        public DbSet<ExpedienteTestamentario> ExpedienteTestamentarioSet { get; set; }

        public DbSet<ExpedienteEstadoTestamentarioRecepcion> ExpedienteEstadoTestamentarioRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoTestamentarioFinalizacion> ExpedienteEstadoTestamentarioFinalizacionSet { get; set; }

        #endregion

        #region ExpedienteTpn

        public DbSet<ExpedienteTpn> ExpedienteTpnSet { get; set; }
        public DbSet<ExpedienteEstadoTpnRecepcion> ExpedienteEstadoTpnRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoTpnFinalizacion> ExpedienteEstadoTpnFinalizacionSet { get; set; }

        #endregion

        #region Saneamiento

        public DbSet<ExpedienteSaneamiento> ExpedienteSaneamientoSet { get; set; }

        public DbSet<ExpedienteEstadoSaneamientoRecepcion> ExpedienteEstadoSaneamientoRecepcionSet { get; set; }
        //public DbSet<ExpedienteEstadoSaneamientoPresentacionDemanda> ExpedienteEstadoSaneamientoPresentacionDemandaSet { get; set; }
        //public DbSet<ExpedienteEstadoSaneamientoTramitacionJuzgado> ExpedienteEstadoSaneamientoTramitacionJuzgadoSet { get; set; }
        public DbSet<ExpedienteEstadoSaneamientoFinalizacion> ExpedienteEstadoSaneamientoFinalizacionSet { get; set; }

        #endregion

        #region Concursal

        public DbSet<ConcursalComunicacionCredito> ConcursalComunicacionCreditoSet { get; set; }
        public DbSet<ConcursalGarantiaOtra> ConcursalGarantiaOtraSet { get; set; }
        public DbSet<ConcursalConvenioDesglose> ConcursalConvenioDesgloseSet { get; set; }
        public DbSet<ConcursalConvenioDesglosePago> ConcursalConvenioDesglosePagoSet { get; set; }

        public DbSet<Con_Expediente> Con_Expediente { get; set; }
        public DbSet<Con_ExpedienteAdministrador> Con_ExpedienteAdministrador { get; set; }
        public DbSet<Con_ExpedienteCredito> Con_ExpedienteCredito { get; set; }
        public DbSet<Con_ExpedienteCreditoCalificacion> Con_ExpedienteCreditoCalificacion { get; set; }
        public DbSet<Con_ExpedienteCreditoGarantiaAvalista> Con_ExpedienteCreditoGarantiaAvalista { get; set; }
        public DbSet<Con_ExpedienteCreditoGarantiaInmuebles> Con_ExpedienteCreditoGarantiaInmuebles { get; set; }
        public DbSet<Con_ExpedienteCreditoGarantiaOtros> Con_ExpedienteCreditoGarantiaOtros { get; set; }

        public DbSet<Con_ExpedienteEstadoComun> Con_ExpedienteEstadoComun { get; set; }
        public DbSet<Con_ExpedienteEstadoConvenio> Con_ExpedienteEstadoConvenio { get; set; }
        public DbSet<Con_ExpedienteEstadoFinalizado> Con_ExpedienteEstadoFinalizado { get; set; }
        public DbSet<Con_ExpedienteEstadoLiquidacion> Con_ExpedienteEstadoLiquidacion { get; set; }
        public DbSet<Con_ExpedienteEstadoLiquidacionLote> Con_ExpedienteEstadoLiquidacionLote { get; set; }
        public DbSet<Con_ExpedienteIncidente> Con_ExpedienteIncidente { get; set; }
        public DbSet<Con_TipoCalificacion> Con_TipoCalificacion { get; set; }
        public DbSet<Con_TipoCalificacionTiempo> Con_TipoCalificacionTiempo { get; set; }
        public DbSet<Con_TipoFase> Con_TipoFase { get; set; }
        public DbSet<Con_TipoIncidente> Con_TipoIncidente { get; set; }

        #endregion

        #region Civil

        public DbSet<ExpedienteCivil> ExpedienteCivilSet { get; set; }
        public DbSet<ExpedienteEstadoCivilRecepcion> ExpedienteEstadoCivilRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoCivilFinalizacion> ExpedienteEstadoCivilFinalizacionSet { get; set; }

        public DbSet<ExpedienteMercantilInmobiliario> ExpedienteMercantilInmobiliarioSet { get; set; }
        public DbSet<ExpedienteEstadoMercantilInmobiliarioRecepcion> ExpedienteEstadoMercantilInmobiliarioRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoMercantilInmobiliarioFinalizacion> ExpedienteEstadoMercantilInmobiliarioFinalizacionSet { get; set; }

        public DbSet<ExpedienteDdl> ExpedienteDdlSet { get; set; }
        public DbSet<ExpedienteEstadoDdlRecepcion> ExpedienteEstadoDdlRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoDdlFinalizacion> ExpedienteEstadoDdlFinalizacionSet { get; set; }

        public DbSet<ExpedienteContenciosoAdministrativo> ExpedienteContenciosoAdministrativoSet { get; set; }
        public DbSet<ExpedienteEstadoContenciosoAdministrativoRecepcion> ExpedienteEstadoContenciosoAdministrativoRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoContenciosoAdministrativoFinalizacion> ExpedienteEstadoContenciosoAdministrativoFinalizacionSet { get; set; }

        public DbSet<ExpedienteContenciosoOrdinario> ExpedienteContenciosoOrdinarioSet { get; set; }
        public DbSet<ExpedienteEstadoContenciosoOrdinarioRecepcion> ExpedienteEstadoContenciosoOrdinarioRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoContenciosoOrdinarioFinalizacion> ExpedienteEstadoContenciosoOrdinarioFinalizacionSet { get; set; }

        public DbSet<ExpedienteCambiario> ExpedienteCambiarioSet { get; set; }
        public DbSet<ExpedienteEstadoCambiarioRecepcion> ExpedienteEstadoCambiarioRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoCambiarioFinalizacion> ExpedienteEstadoCambiarioFinalizacionSet { get; set; }

        #endregion

        #region Penal 

        public DbSet<ExpedientePenal> ExpedientePenalSet { get; set; }

        public DbSet<ExpedienteEstadoPenalRecepcion> ExpedienteEstadoPenalRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoPenalFinalizacion> ExpedienteEstadoPenalFinalizacionSet { get; set; }
        public DbSet<ExpedienteEstadoPenal> ExpedienteEstadoPenalSet { get; set; }
        public DbSet<Auto> AutoSet { get; set; }
        public DbSet<ExpedientePropuesta> ExpedientePropuestaSet { get; set; }

        public DbSet<ExpedienteAbogado> ExpedienteAbogadoSet { get; set; }
        public DbSet<ExpedienteCliente> ExpedienteClienteSet { get; set; }

        #endregion

        #region Facturacion y tiempos medios

        public DbSet<TipoHitoProcesal> TipoHitoProcesalSet { get; set; }
        public DbSet<TipoHitoProcesalTiempoMedio> TipoHitoProcesalTiempoMedioSet { get; set; }
        public DbSet<ClienteFacturaHitoProcesal> ClienteFacturaHitoProcesalSet { get; set; }

        #endregion

        #region Fiscal 

        public DbSet<ExpedienteFiscal> ExpedienteFiscalSet { get; set; }

        public DbSet<ExpedienteEstadoFiscalRecepcion> ExpedienteEstadoFiscalRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoFiscalFinalizacion> ExpedienteEstadoFiscalFinalizacionSet { get; set; }
        //public DbSet<ExpedienteEstadoFiscal> ExpedienteEstadoFiscalSet { get; set; }
        //public DbSet<Auto> AutoSet { get; set; }
        //public DbSet<ExpedientePropuesta> ExpedientePropuestaSet { get; set; }

        //public DbSet<ExpedienteAbogado> ExpedienteAbogadoSet { get; set; }
        //public DbSet<ExpedienteCliente> ExpedienteClienteSet { get; set; }

        #endregion

        #region Conciliacion 

        public DbSet<ExpedienteConciliacion> ExpedienteConciliacionSet { get; set; }
        public DbSet<ExpedienteEstadoConciliacionRecepcion> ExpedienteEstadoConciliacionRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoConciliacionFinalizacion> ExpedienteEstadoConciliacionFinalizacionSet { get; set; }
        public DbSet<ExpedienteEstadoConciliacionActo> ExpedienteEstadoConciliacionActoSet { get; set; }

        #endregion

        #region JuraCuenta 

        public DbSet<ExpedienteJuraCuenta> ExpedienteJuraCuentaSet { get; set; }

        public DbSet<ExpedienteEstadoJuraCuentaRecepcion> ExpedienteEstadoJuraCuentaRecepcionSet { get; set; }
        public DbSet<ExpedienteEstadoJuraCuentaFinalizacion> ExpedienteEstadoJuraCuentaFinalizacionSet { get; set; }
        public DbSet<ExpedienteEstadoJuraCuentaTramitacion> ExpedienteEstadoJuraCuentaTramitacionSet { get; set; }

        //'Gnr_TipoEstadoMotivo.Hip_ExpedienteEstadoSubastaSet
        //public DbSet<Auto> AutoSet { get; set; }
        //public DbSet<ExpedientePropuesta> ExpedientePropuestaSet { get; set; }
        //public DbSet<ExpedienteAbogado> ExpedienteAbogadoSet { get; set; }
        //public DbSet<ExpedienteCliente> ExpedienteClienteSet { get; set; }

        #endregion

        #region Migrados de DB First - Code First

        public DbSet<Procura> ProcuraSet { get; set; }
        public DbSet<AccionFlujo> AccionFlujoes { get; set; }
        public DbSet<AlertaDestinatario> AlertaDestinatarios { get; set; }
        public DbSet<AlertaSupervisor> AlertaSupervisors { get; set; }
        public DbSet<Alq_Expediente> AlqExpedienteSet { get; set; }
        public DbSet<Alq_Expediente_Contrato> Alq_Expediente_Contratos { get; set; }
        public DbSet<Alq_Expediente_Contratos_Deuda_Lineas> Alq_Expediente_Contratos_Deuda_Lineas { get; set; }
        public DbSet<Alq_Expediente_Contratos_PlanPagos_Lineas> Alq_Expediente_Contratos_PlanPagos_Lineas { get; set; }
        public DbSet<Alq_Expediente_EstadoAdjudicacion> Alq_Expediente_EstadoAdjudicacion { get; set; }
        public DbSet<Alq_Expediente_EstadoFinalizacion> Alq_Expediente_EstadoFinalizaciones { get; set; }
        public DbSet<Alq_Expediente_EstadoLanzamiento> Alq_Expediente_EstadoLanzamientos { get; set; }
        public DbSet<Alq_Expediente_EstadoPresentacionDemanda> Alq_Expediente_EstadoPresentacionDemandas { get; set; }
        public DbSet<Alq_Expediente_EstadoRecepcion> Alq_Expediente_EstadoRecepciones { get; set; }
        public DbSet<Alq_Expediente_EstadoTramitaJuzgado> Alq_Expediente_EstadoTramitaJuzgadoSet { get; set; }
        public DbSet<Alq_Expediente_EstadoTramitaJuzgado_Actuacion> Alq_Expediente_EstadoTramitaJuzgado_ActuacionSet { get; set; }
        //public DbSet<aspnet_Applications> aspnet_Applications { get; set; }
        //public DbSet<aspnet_Membership> aspnet_Membership { get; set; }
        //public DbSet<aspnet_Paths> aspnet_Paths { get; set; }
        //public DbSet<aspnet_PersonalizationAllUsers> aspnet_PersonalizationAllUsers { get; set; }
        //public DbSet<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; }
        //public DbSet<aspnet_Profile> aspnet_Profile { get; set; }
        //public DbSet<aspnet_Roles> aspnet_Roles { get; set; }
        //public DbSet<aspnet_SchemaVersions> aspnet_SchemaVersions { get; set; }
        //public DbSet<aspnet_Users> aspnet_Users { get; set; }
        //public DbSet<aspnet_WebEvent_Events> aspnet_WebEvent_Events { get; set; }

        public DbSet<Configuracion> Configuracions { get; set; }
        public DbSet<Departamento> DepartamentoSet { get; set; }

        //public DbSet<Expediente> Expedientes { get; set; }
        public DbSet<ExpedienteAccion> ExpedienteAccions { get; set; }
        public DbSet<ExpedienteAcreedore> ExpedienteAcreedores { get; set; }
        public DbSet<ExpedienteAlerta> ExpedienteAlertas { get; set; }
        public DbSet<ExpedienteDeudor> ExpedienteDeudors { get; set; }
        //public DbSet<ExpedienteDocumento> ExpedienteDocumentoes { get; set; }
        public DbSet<ExpedienteEstado> ExpedienteEstadoSet { get; set; }
        public DbSet<ExpedienteFactura> ExpedienteFacturaSet { get; set; }
        public DbSet<ExpedienteGastoSuplido> ExpedienteGastoSuplidoSet { get; set; }
        public DbSet<ExpedienteCobro> ExpedienteCobroSet { get; set; }
        public DbSet<ExpedienteGasto> ExpedienteGastoes { get; set; }
        public DbSet<ExpedienteIngreso> ExpedienteIngresoes { get; set; }

        public DbSet<ExpedienteVista> ExpedienteVistaSet { get; set; }
        public DbSet<ExpedienteTituloEjecutivo> ExpedienteTituloEjecutivoSet { get; set; }

        public DbSet<Factura> FacturaSet { get; set; }
        public DbSet<FileRecord> FileRecords { get; set; }
        public DbSet<Gnr_Abogado> Gnr_Abogado { get; set; }
        public DbSet<AbogadoFacturacion> AbogadoFacturacionSet { get; set; }
        public DbSet<Gnr_Cliente> Gnr_Cliente { get; set; }
        public DbSet<ClienteObjetivo> ClienteObjetivoSet { get; set; }
        public DbSet<Gnr_ClienteOficina> Gnr_ClienteOficina { get; set; }
        public DbSet<Pagador> PagadorSet { get; set; }
        public DbSet<ClienteTipoExpedienteConfiguracion> ClienteTipoExpedienteConfiguracionSet { get; set; }
        public DbSet<Gnr_ListasValores_Listas> Gnr_ListasValores_ListasSet { get; set; }
        public DbSet<Gnr_ListasValores_Valores> Gnr_ListasValores_Valores { get; set; }
        public DbSet<Gnr_Persona> Gnr_Persona { get; set; }
        public DbSet<Gnr_PersonaDireccion> Gnr_PersonaDireccion { get; set; }
        public DbSet<Gnr_PersonaExpediente> Gnr_PersonaExpediente { get; set; }
        public DbSet<Gnr_PersonaTelefono> Gnr_PersonaTelefono { get; set; }
        public DbSet<Gnr_PlantillasDoc> Gnr_PlantillasDoc { get; set; }
        public DbSet<Gnr_Procurador> Gnr_Procurador { get; set; }
        public DbSet<GNR_Procuradores> GNR_Procuradores { get; set; }
        public DbSet<Gnr_TipoAlerta> Gnr_TipoAlerta { get; set; }
        public DbSet<Gnr_TipoArea> Gnr_TipoArea { get; set; }
        public DbSet<Gnr_TipoDeudor> Gnr_TipoDeudor { get; set; }
        public DbSet<Gnr_TipoDireccion> Gnr_TipoDireccion { get; set; }
        public DbSet<Gnr_TipoEstado> Gnr_TipoEstado { get; set; }
        public DbSet<Gnr_TipoEstadoCliente> Gnr_TipoEstadoClienteSet { get; set; }
        public DbSet<Gnr_TipoEstadoMotivo> Gnr_TipoEstadoMotivoSet { get; set; }
        public DbSet<Gnr_TipoExpediente> Gnr_TipoExpediente { get; set; }
        public DbSet<Gnr_TipoExpedienteDocumento> Gnr_TipoExpedienteDocumento { get; set; }
        public DbSet<Gnr_TipoIdentidad> Gnr_TipoIdentidad { get; set; }
        public DbSet<Gnr_TipoPersona> Gnr_TipoPersona { get; set; }
        public DbSet<Gnr_TipoTelefono> Gnr_TipoTelefono { get; set; }
        public DbSet<Gnr_TipoTratamiento> Gnr_TipoTratamiento { get; set; }
        //public DbSet<Gnr_Valija> Gnr_Valija { get; set; }
        public DbSet<Hip_Expediente> Hip_Expediente { get; set; }
        public DbSet<Hip_ExpedienteEstadoAdjudicacion> Hip_ExpedienteEstadoAdjudicacion { get; set; }
        public DbSet<Hip_ExpedienteEstadoDatoRequerimiento> Hip_ExpedienteEstadoDatoRequerimiento { get; set; }
        public DbSet<Hip_ExpedienteEstadoFinalizacion> Hip_ExpedienteEstadoFinalizacion { get; set; }
        public DbSet<Hip_ExpedienteEstadoNegociacionPosesion> Hip_ExpedienteEstadoNegociacionPosesionSet { get; set; }
        public DbSet<HipExpedienteEstadoPresentacionDemanda> Hip_ExpedienteEstadoPresentacionDemanda { get; set; }
        public DbSet<Hip_ExpedienteEstadoProcesoParalizado> Hip_ExpedienteEstadoProcesoParalizado { get; set; }
        public DbSet<HipExpedienteEstadoRecepcion> Hip_ExpedienteEstadoRecepcion { get; set; }
        public DbSet<Hip_ExpedienteEstadoSubasta> Hip_ExpedienteEstadoSubasta { get; set; }
        public DbSet<HipExpedienteEstadoTramitacionSubasta> Hip_ExpedienteEstadoTramitacionJuzgado { get; set; }
        public DbSet<Hip_ExpedienteGarantia> Hip_ExpedienteGarantia { get; set; }
        public DbSet<Hip_Hipoteca> Hip_Hipoteca { get; set; }
        public DbSet<Hip_HipotecaDatoEscritura> Hip_HipotecaDatoEscritura { get; set; }
        public DbSet<Hip_HipotecaPagoACuenta> Hip_HipotecaPagoACuenta { get; set; }
        public DbSet<Hip_Inmueble> Hip_Inmueble { get; set; }
        public DbSet<Inmueble> InmuebleSet { get; set; }
        public DbSet<InmuebleNota> InmuebleNotaSet { get; set; }
        public DbSet<InmuebleContacto> InmuebleContactoSet { get; set; }
        public DbSet<InmuebleOferta> InmuebleOfertaSet { get; set; }
        public DbSet<InmuebleContrato> InmuebleContratoSet { get; set; }
        public DbSet<InmuebleEstado> InmuebleEstadoSet { get; set; }
        public DbSet<HipInmuebleNota> HipInmuebleNotaSet { get; set; }

        public DbSet<PartidoJudicial> PartidoJudicialSet { get; set; }
        public DbSet<HIP_PartidosJudiciales> HIP_PartidosJudiciales { get; set; }
        public DbSet<Hip_TipoDemanda> Hip_TipoDemanda { get; set; }
        public DbSet<Hip_TipoInmueble> Hip_TipoInmueble { get; set; }
        public DbSet<Hip_TipoLugarEjecucion> Hip_TipoLugarEjecucion { get; set; }
        public DbSet<Hip_TipoPeriodicidad> Hip_TipoPeriodicidad { get; set; }
        public DbSet<Hip_TipoReferenciaHipotecaria> Hip_TipoReferenciaHipotecaria { get; set; }
        public DbSet<Hip_TipoSubasta> Hip_TipoSubasta { get; set; }
        public DbSet<Hip_TipoTitulizado> Hip_TipoTitulizado { get; set; }
        public DbSet<Hip_TitularInmueble> Hip_TitularInmueble { get; set; }
        public DbSet<Mnt_Expediente> Mnt_Expediente { get; set; }
        public DbSet<Neg_Gestion> Neg_Gestiones { get; set; }
        public DbSet<Neg_GestionEstado> Neg_GestionEstados { get; set; }
        public DbSet<ProcuradoresCliente> ProcuradoresClientes { get; set; }
        public DbSet<ProcuradorPartidoJudicial> ProcuradorPartidoJudicialSet { get; set; }
        public DbSet<PropuestaComercial> PropuestaComercials { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        //public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TipoAccion> TipoAccions { get; set; }
        public DbSet<TipoCalificacionCreditoTiempo> TipoCalificacionCreditoTiempoes { get; set; }
        public DbSet<TipoClasificacionCredito> TipoClasificacionCreditoes { get; set; }
        public DbSet<TipoExpedienteAccion> TipoExpedienteAccions { get; set; }
        public DbSet<TipoFormaPago> TipoFormaPagoes { get; set; }
        public DbSet<TipoGarantia> TipoGarantias { get; set; }
        public DbSet<TipoVista> TipoVistaSet { get; set; }

        public DbSet<SolicitudDocumental> SolicitudDocumentalSet { get; set; }

        //public DbSet<Hip_Hipoteca_EnEjecucion_View> Hip_Hipoteca_EnEjecucion_View { get; set; }
        //public DbSet<vAlq_DEMANDA> vAlq_DEMANDA { get; set; }
        //public DbSet<vAlq_Expediente_EstadoTramitaJuzgado_ActuacionesLast> vAlq_Expediente_EstadoTramitaJuzgado_ActuacionesLastSet { get; set; }
        //public DbSet<vAlq_InformeTotalP> vAlq_InformeTotalP { get; set; }
        //public DbSet<vExpedienteDeudorPrincipal> vExpedienteDeudorPrincipals { get; set; }
        //public DbSet<vGnr_NombresCampos> vGnr_NombresCampos { get; set; }
        //public DbSet<vGnr_PlantillaDoc_ALQUILER_BUROFAX> vGnr_PlantillaDoc_ALQUILER_BUROFAX { get; set; }
        //public DbSet<vHip_HipotecaEnEjecucion> vHip_HipotecaEnEjecucion { get; set; }
        //public DbSet<vHipotecaPrincipal> vHipotecaPrincipals { get; set; }
        //public DbSet<View_1> View_1 { get; set; }
        //public DbSet<View_5> View_5 { get; set; }
        //public DbSet<vInmueblePrincipal> vInmueblePrincipals { get; set; }
        //public DbSet<vw_aspnet_Applications> vw_aspnet_Applications { get; set; }
        //public DbSet<vw_aspnet_MembershipUsers> vw_aspnet_MembershipUsers { get; set; }
        //public DbSet<vw_aspnet_Profiles> vw_aspnet_Profiles { get; set; }
        //public DbSet<vw_aspnet_Roles> vw_aspnet_Roles { get; set; }
        //public DbSet<vw_aspnet_Users> vw_aspnet_Users { get; set; }
        //public DbSet<vw_aspnet_UsersInRoles> vw_aspnet_UsersInRoles { get; set; }
        //public DbSet<vw_aspnet_WebPartState_Paths> vw_aspnet_WebPartState_Paths { get; set; }
        //public DbSet<vw_aspnet_WebPartState_Shared> vw_aspnet_WebPartState_Shared { get; set; }
        //public DbSet<vw_aspnet_WebPartState_User> vw_aspnet_WebPartState_User { get; set; }

        #endregion

        #region Recursos Humanos

        public DbSet<Candidato> CandidatoSet { get; set; }
        public DbSet<UsuarioExperiencia> UsuarioExperienciaSet { get; set; }
        public DbSet<UsuarioFormacion> UsuarioFormacionSet { get; set; }
        public DbSet<UsuarioIdioma> UsuarioIdiomaSet { get; set; }
        public DbSet<UsuarioInformatica> UsuarioInformaticaSet { get; set; }
        public DbSet<UsuarioAreasDominio> UsuarioAreasDominioSet { get; set; }
        public DbSet<UsuarioRetribucion> UsuarioRetribucionSet { get; set; }
        public DbSet<UsuarioEvaluacion> UsuarioEvaluacionSet { get; set; }

        #endregion

        #region Tmp

        public DbSet<TmpNegociacionAliseda> TmpNegociacionAlisedaSet { get; set; }

        #endregion

        #region CRM

        public DbSet<Oportunidad> OportunidadSet { get; set; }
        public DbSet<Contacto> ContactoSet { get; set; }
        public DbSet<OportunidadContacto> OportunidadContactoSet { get; set; }
        public DbSet<OportunidadUsuario> OportunidadUsuarioSet { get; set; }
        public DbSet<Tarea> TareaSet { get; set; }
        public DbSet<TareaServicioBufete> TareaServicioBufeteSet { get; set; }
        public DbSet<Nota> NotaSet { get; set; }
        public DbSet<Contrato> ContratoSet { get; set; }
        public DbSet<Comite> ComiteSet { get; set; }
        public DbSet<ServicioBufete> ServicioBufeteSet { get; set; }
        public DbSet<ClienteServicioBufete> ClienteServicioBufeteSet { get; set; }

        #endregion

        #region FichaNegocio

        public DbSet<FichaNegocio> FichaNegocioSet { get; set; }
        public DbSet<FichaNegocioMes> FichaNegocioMesSet { get; set; }

        public DbSet<PeriodoSemana> PeriodoSemanaSet { get; set; }
        public DbSet<Division> DivisionSet { get; set; }
        public DbSet<DivisionPlan> DivisionPlanSet { get; set; }
        public DbSet<DivisionReal> DivisionRealSet { get; set; }

        #endregion

        #region Inmuebles y Carteras

        public DbSet<CarteraInmobiliaria> CarteraInmobiliariaSet { get; set; }
        public DbSet<CarteraInmueble> CarteraInmuebleSet { get; set; }

        public DbSet<Asset> AssetSet { get; set; }

        #endregion

        #region CAU / RegistroComunicacion

        public DbSet<Tiket> TiketSet { get; set; }
        public DbSet<RegistroComunicacion> RegistroComunicacionSet { get; set; }

        #endregion

        #region LOGs

        public DbSet<LogEstadoSubfase> LogEstadoSubfaseSet { get; set; }

        public DbSet<LogKpiAbogado> LogKpiAbogadoSet { get; set; }

        #endregion


        #region Evaluacion del Desempeño

        public DbSet<EvaluacionEmpleado> EvaluacionEmpleadoSet { get; set; }
        public DbSet<EvaluacionEmpleadoObjetivo> EvaluacionEmpleadoObjetivoSet { get; set; }
        public DbSet<EvaluacionEmpleadoCompetencia> EvaluacionEmpleadoCompetenciaSet { get; set; }

        public DbSet<EvaluacionCompetencia> EvaluacionCompetenciaSet { get; set; }
        public DbSet<EvaluacionCompetenciaGrupo> EvaluacionCompetenciaGrupoSet { get; set; }

        #endregion

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ModelExpedienteToKpi>();
            
            
            // Create the Composite Key
            modelBuilder.Entity<PagadorCliente>().HasKey(e => new { e.IdPagador, e.IdCliente });


            //modelBuilder.Entity<Expediente>()
            //    .HasOne(s => s.ExpedienteEstadoLast)
            //    .WithOne(g => g.Expediente)
            //    .HasForeignKey(f => f.IdEstadoLast);


            // modelBuilder.Entity<ExpedienteEstado>()
            //.HasOne<Blog>()
            //.WithMany()
            //.HasForeignKey(p => p.BlogId);

            //            modelBuilder.Entity<ExpedienteEstado>()
            //.HasOne(p => p.Expediente)
            //.WithOne(b => b.ExpedienteEstadoLast)
            //.HasForeignKey(p => p.IdEstadoLast);

            //            modelBuilder.Entity<Expediente>()
            //        .HasOne(p => p.ExpedienteEstadoLast)
            //        .WithOne(b => b.Expediente)
            //        .HasForeignKey(p => p.IdEstadoLast);

            //            builder.HasOne(s => s.WarrantyCompany)
            //                .WithMany(g => g.WarrantyCompanyJobs)
            //                .HasForeignKey(f => f.WarrantyCompanyId);


            #region Evaluacion del Desempeño

            modelBuilder.Entity<EvaluacionEmpleado>().OwnsOne(p => p.EvaluadoNotas);
            modelBuilder.Entity<EvaluacionEmpleado>().OwnsOne(p => p.EvaluadorNotas);

            modelBuilder.Entity<ClienteObjetivo>().OwnsOne(p => p.Mes01);
            modelBuilder.Entity<ClienteObjetivo>().OwnsOne(p => p.Mes02);
            modelBuilder.Entity<ClienteObjetivo>().OwnsOne(p => p.Mes03);
            modelBuilder.Entity<ClienteObjetivo>().OwnsOne(p => p.Mes04);
            modelBuilder.Entity<ClienteObjetivo>().OwnsOne(p => p.Mes05); 
            modelBuilder.Entity<ClienteObjetivo>().OwnsOne(p => p.Mes06);
            modelBuilder.Entity<ClienteObjetivo>().OwnsOne(p => p.Mes07);
            modelBuilder.Entity<ClienteObjetivo>().OwnsOne(p => p.Mes08);
            modelBuilder.Entity<ClienteObjetivo>().OwnsOne(p => p.Mes09);
            modelBuilder.Entity<ClienteObjetivo>().OwnsOne(p => p.Mes10);
            modelBuilder.Entity<ClienteObjetivo>().OwnsOne(p => p.Mes11);
            modelBuilder.Entity<ClienteObjetivo>().OwnsOne(p => p.Mes12);

            modelBuilder.Entity<Tarea>().OwnsOne(p => p.ActivoResidencial);
            modelBuilder.Entity<Tarea>().OwnsOne(p => p.SueloWip);
            modelBuilder.Entity<Tarea>().OwnsOne(p => p.ActivoComercial);
            modelBuilder.Entity<Tarea>().OwnsOne(p => p.ActivoOficina);
            modelBuilder.Entity<Tarea>().OwnsOne(p => p.ActivoHotel);



        //modelBuilder
        //    .Entity<Blog>()
        //    .Property(b => b.Url)
        //    .IsRequired();

        // series of statements
        //modelBuilder.Entity<Order>().Property(t => t.OrderDate).IsRequired();
        //modelBuilder.Entity<Order>().Property(t => t.OrderDate).HasColumnType("Date");
        //modelBuilder.Entity<Order>().Property(t => t.OrderDate).HasDefaultValueSql("GetDate()");
        //// fluent api chained calls
        //modelBuilder.Entity<Order>()
        //    .Property(t => t.OrderDate)
        //        .IsRequired()
        //        .HasColumnType("Date")
        //        .HasDefaultValueSql("GetDate()");


        modelBuilder
                .Entity<Usuario>()
                .HasMany(i => i.EvaluacionEmpleadoSet)
                //.IsRequired()
                //.WillCascadeOnDelete(false)
                ;

            //modelBuilder.Entity<Pagador>()
            //    .HasMany(p => p.ClienteSet)
            //    .WithMany(c => c.Pagadores)
                //.Map(pc =>
                //{
                //    pc.MapLeftKey("IdPagador");
                //    pc.MapRightKey("IdCliente");
                //    pc.ToTable("PagadorCliente");
                //})
                ;

            #endregion

            #region JV

            //builder.ToTable("AlertaDestinatario").HasKey(t => t.IdPersona);
            //builder.Property(t => t.IdPersona).ValueGeneratedNever();

            //modelBuilder.Entity<JvExpedienteEstadoRecepcion>().HasKey(t => t.IdExpedienteEstado);
            modelBuilder.Entity<JvExpedienteEstadoRecepcion>()
                .Property(t => t.IdExpedienteEstado).ValueGeneratedNever();
            //modelBuilder.Entity<JvExpedienteEstadoRecepcion>()
            //    .Property(t => t.ExpedienteEstado).IsRequired();
            //modelBuilder.Entity<JvExpedienteEstadoRecepcion>()
            //    .HasOne(t => t.JvExpedienteEstadoRecepcion);

            modelBuilder.Entity<JvExpedienteEstadoPresentacionDemanda>().HasKey(t => t.IdExpedienteEstado);
            modelBuilder.Entity<JvExpedienteEstadoPresentacionDemanda>()
                .Property(t => t.IdExpedienteEstado).ValueGeneratedNever();

            //modelBuilder.Entity<JvExpedienteEstadoPresentacionDemanda>()
            //    .HasRequired(t => t.ExpedienteEstado)
            //    .WithOptional(t => t.JvExpedienteEstadoPresentacionDemanda);

            modelBuilder.Entity<JvExpedienteEstadoPresentacionDemanda>()
                .HasOne(p => p.ExpedienteEstado) //HasRequired
                .WithOne(i => i.JvExpedienteEstadoPresentacionDemanda); // WithOptional

            #endregion

            #region OLDs

            //modelBuilder.ApplyConfiguration(new AccionFlujoMap());
            // //public class AccionFlujoMap : IEntityTypeConfiguration<AccionFlujo>

            modelBuilder.ApplyConfiguration(new AccionFlujoMap());
            //modelBuilder.ApplyConfiguration<AccionFlujo>(new AccionFlujoMap());



            modelBuilder.ApplyConfiguration(new AlertaDestinatarioMap());
            modelBuilder.ApplyConfiguration(new AlertaSupervisorMap());
            modelBuilder.ApplyConfiguration(new Alq_ExpedienteMap());
            modelBuilder.ApplyConfiguration(new Alq_Expediente_ContratosMap());
            modelBuilder.ApplyConfiguration(new Alq_Expediente_Contratos_Deuda_LineasMap());
            modelBuilder.ApplyConfiguration(new Alq_Expediente_Contratos_PlanPagos_LineasMap());
            modelBuilder.ApplyConfiguration(new Alq_Expediente_EstadoAdjudicacionMap());
            modelBuilder.ApplyConfiguration(new Alq_Expediente_EstadoFinalizacionMap());
            modelBuilder.ApplyConfiguration(new Alq_Expediente_EstadoLanzamientoMap());
            modelBuilder.ApplyConfiguration(new Alq_Expediente_EstadoPresentacionDemandaMap());
            modelBuilder.ApplyConfiguration(new Alq_Expediente_EstadoRecepcionMap());
            modelBuilder.ApplyConfiguration(new Alq_Expediente_EstadoTramitaJuzgadoMap());
            modelBuilder.ApplyConfiguration(new Alq_Expediente_EstadoTramitaJuzgado_ActuacionesMap());
            //modelBuilder.ApplyConfiguration(new aspnet_ApplicationsMap());
            //modelBuilder.ApplyConfiguration(new aspnet_MembershipMap());
            //modelBuilder.ApplyConfiguration(new aspnet_PathsMap());
            //modelBuilder.ApplyConfiguration(new aspnet_PersonalizationAllUsersMap());
            //modelBuilder.ApplyConfiguration(new aspnet_PersonalizationPerUserMap());
            //modelBuilder.ApplyConfiguration(new aspnet_ProfileMap());
            //modelBuilder.ApplyConfiguration(new aspnet_RolesMap());
            //modelBuilder.ApplyConfiguration(new aspnet_SchemaVersionsMap());
            //modelBuilder.ApplyConfiguration(new aspnet_UsersMap());
            //modelBuilder.ApplyConfiguration(new aspnet_WebEvent_EventsMap());
            modelBuilder.ApplyConfiguration(new Con_ExpedienteMap());
            modelBuilder.ApplyConfiguration(new Con_ExpedienteAdministradorMap());
            modelBuilder.ApplyConfiguration(new Con_ExpedienteCreditoMap());
            modelBuilder.ApplyConfiguration(new Con_ExpedienteCreditoCalificacionMap());
            modelBuilder.ApplyConfiguration(new Con_ExpedienteCreditoGarantiaAvalistaMap());
            modelBuilder.ApplyConfiguration(new Con_ExpedienteCreditoGarantiaInmueblesMap());
            modelBuilder.ApplyConfiguration(new Con_ExpedienteCreditoGarantiaOtrosMap());
            modelBuilder.ApplyConfiguration(new Con_ExpedienteEstadoComunMap());
            modelBuilder.ApplyConfiguration(new Con_ExpedienteEstadoConvenioMap());
            modelBuilder.ApplyConfiguration(new Con_ExpedienteEstadoFinalizadoMap());
            modelBuilder.ApplyConfiguration(new Con_ExpedienteEstadoLiquidacionMap());
            modelBuilder.ApplyConfiguration(new Con_ExpedienteEstadoLiquidacionLoteMap());
            modelBuilder.ApplyConfiguration(new Con_ExpedienteIncidenteMap());
            modelBuilder.ApplyConfiguration(new Con_TipoCalificacionMap());
            modelBuilder.ApplyConfiguration(new Con_TipoCalificacionTiempoMap());
            modelBuilder.ApplyConfiguration(new Con_TipoFaseMap());
            modelBuilder.ApplyConfiguration(new Con_TipoIncidenteMap());
            modelBuilder.ApplyConfiguration(new ConfiguracionMap());
            modelBuilder.ApplyConfiguration(new DepartamentoMap());
            modelBuilder.ApplyConfiguration(new Ejc_ExpedienteMap());
            modelBuilder.ApplyConfiguration(new Ejc_ExpedienteEstadoAdjudicacionMap());
            modelBuilder.ApplyConfiguration(new Ejc_ExpedienteEstadoEfectividadEmbargoMap());
            modelBuilder.ApplyConfiguration(new Ejc_ExpedienteEstadoFinalizacionMap());
            modelBuilder.ApplyConfiguration(new Ejc_ExpedienteEstadoNotificacionMap());
            modelBuilder.ApplyConfiguration(new Ejc_ExpedienteEstadoPresentacionDemandaMap());
            modelBuilder.ApplyConfiguration(new Ejc_ExpedienteEstadoRecepcionMap());
            modelBuilder.ApplyConfiguration(new Ejc_ExpedienteEstadoRequerimientoPagoMap());
            modelBuilder.ApplyConfiguration(new Ejc_ExpedienteEstadoSolicitudSubastaMap());
            modelBuilder.ApplyConfiguration(new Ejc_ExpedienteEstadoSubastaMap());
            modelBuilder.ApplyConfiguration(new Ejc_ExpedienteEstadoTramiteEmbargoMap());
            modelBuilder.ApplyConfiguration(new ExpedienteMap());
            modelBuilder.ApplyConfiguration(new ExpedienteAccionMap());
            modelBuilder.ApplyConfiguration(new ExpedienteAcreedoreMap());
            modelBuilder.ApplyConfiguration(new ExpedienteAlertaMap());
            modelBuilder.ApplyConfiguration(new ExpedienteDeudorMap());
            //modelBuilder.ApplyConfiguration(new ExpedienteDocumentoMap());
            modelBuilder.ApplyConfiguration(new ExpedienteEstadoMap());
            modelBuilder.ApplyConfiguration(new ExpedienteFacturaMap());
            modelBuilder.ApplyConfiguration(new ExpedienteGastoMap());
            modelBuilder.ApplyConfiguration(new ExpedienteIngresoMap());
            modelBuilder.ApplyConfiguration(new ExpedienteVistaMap());
            modelBuilder.ApplyConfiguration(new FacturaMap());
            modelBuilder.ApplyConfiguration(new FileRecordMap());
            modelBuilder.ApplyConfiguration(new Gnr_AbogadoMap());
            modelBuilder.ApplyConfiguration(new Gnr_ClienteMap());
            modelBuilder.ApplyConfiguration(new Gnr_ClienteOficinaMap());
            modelBuilder.ApplyConfiguration(new Gnr_JuzgadoMap());
            modelBuilder.ApplyConfiguration(new Gnr_ListasValores_ListasMap());
            modelBuilder.ApplyConfiguration(new Gnr_ListasValores_ValoresMap());
            modelBuilder.ApplyConfiguration(new Gnr_PersonaMap());
            modelBuilder.ApplyConfiguration(new Gnr_PersonaDireccionMap());
            modelBuilder.ApplyConfiguration(new Gnr_PersonaExpedienteMap());
            modelBuilder.ApplyConfiguration(new Gnr_PersonaTelefonoMap());
            modelBuilder.ApplyConfiguration(new Gnr_PlantillasDocMap());
            modelBuilder.ApplyConfiguration(new Gnr_ProcuradorMap());
            modelBuilder.ApplyConfiguration(new GNR_ProcuradoresMap());
            modelBuilder.ApplyConfiguration(new Gnr_TipoAlertaMap());
            modelBuilder.ApplyConfiguration(new Gnr_TipoAreaMap());
            modelBuilder.ApplyConfiguration(new Gnr_TipoDeudorMap());
            modelBuilder.ApplyConfiguration(new Gnr_TipoDireccionMap());
            modelBuilder.ApplyConfiguration(new Gnr_TipoEstadoMap());
            modelBuilder.ApplyConfiguration(new Gnr_TipoEstadoClienteMap());
            modelBuilder.ApplyConfiguration(new Gnr_TipoEstadoMotivoMap());
            modelBuilder.ApplyConfiguration(new Gnr_TipoExpedienteMap());
            modelBuilder.ApplyConfiguration(new Gnr_TipoExpedienteDocumentoMap());
            modelBuilder.ApplyConfiguration(new Gnr_TipoIdentidadMap());
            modelBuilder.ApplyConfiguration(new Gnr_TipoPersonaMap());
            modelBuilder.ApplyConfiguration(new Gnr_TipoTelefonoMap());
            modelBuilder.ApplyConfiguration(new Gnr_TipoTratamientoMap());
            //modelBuilder.ApplyConfiguration(new Gnr_ValijaMap());
            modelBuilder.ApplyConfiguration(new Hip_ExpedienteMap());
            modelBuilder.ApplyConfiguration(new Hip_ExpedienteEstadoAdjudicacionMap());
            modelBuilder.ApplyConfiguration(new Hip_ExpedienteEstadoDatoRequerimientoMap());
            modelBuilder.ApplyConfiguration(new Hip_ExpedienteEstadoFinalizacionMap());
            modelBuilder.ApplyConfiguration(new Hip_ExpedienteEstadoNegociacionPosesionMap());
            modelBuilder.ApplyConfiguration(new Hip_ExpedienteEstadoPresentacionDemandaMap());
            modelBuilder.ApplyConfiguration(new Hip_ExpedienteEstadoProcesoParalizadoMap());
            modelBuilder.ApplyConfiguration(new Hip_ExpedienteEstadoRecepcionMap());
            modelBuilder.ApplyConfiguration(new Hip_ExpedienteEstadoSubastaMap());
            modelBuilder.ApplyConfiguration(new Hip_ExpedienteEstadoTramitacionJuzgadoMap());
            modelBuilder.ApplyConfiguration(new Hip_ExpedienteGarantiaMap());
            modelBuilder.ApplyConfiguration(new Hip_HipotecaMap());
            modelBuilder.ApplyConfiguration(new Hip_HipotecaDatoEscrituraMap());
            modelBuilder.ApplyConfiguration(new Hip_HipotecaPagoACuentaMap());
            modelBuilder.ApplyConfiguration(new Hip_InmuebleMap());
            modelBuilder.ApplyConfiguration(new Hip_PartidoJudicialMap());
            modelBuilder.ApplyConfiguration(new HIP_PartidosJudicialesMap());
            modelBuilder.ApplyConfiguration(new Hip_TipoDemandaMap());
            modelBuilder.ApplyConfiguration(new Hip_TipoInmuebleMap());
            modelBuilder.ApplyConfiguration(new Hip_TipoLugarEjecucionMap());
            modelBuilder.ApplyConfiguration(new Hip_TipoPeriodicidadMap());
            modelBuilder.ApplyConfiguration(new Hip_TipoReferenciaHipotecariaMap());
            modelBuilder.ApplyConfiguration(new Hip_TipoSubastaMap());
            modelBuilder.ApplyConfiguration(new Hip_TipoTitulizadoMap());
            modelBuilder.ApplyConfiguration(new Hip_TitularInmuebleMap());
            modelBuilder.ApplyConfiguration(new Mnt_ExpedienteMap());
            modelBuilder.ApplyConfiguration(new Neg_GestionMap());
            modelBuilder.ApplyConfiguration(new Neg_GestionEstadoMap());
            modelBuilder.ApplyConfiguration(new ProcuradoresClienteMap());
            modelBuilder.ApplyConfiguration(new ProcuradorPartidoJudicialMap());
            modelBuilder.ApplyConfiguration(new PropuestaComercialMap());
            modelBuilder.ApplyConfiguration(new RolePermissionMap());
            //modelBuilder.ApplyConfiguration(new sysdiagramMap());
            modelBuilder.ApplyConfiguration(new TipoAccionMap());
            modelBuilder.ApplyConfiguration(new TipoCalificacionCreditoTiempoMap());
            modelBuilder.ApplyConfiguration(new TipoClasificacionCreditoMap());
            modelBuilder.ApplyConfiguration(new TipoExpedienteAccionMap());
            modelBuilder.ApplyConfiguration(new TipoFormaPagoMap());
            modelBuilder.ApplyConfiguration(new TipoGarantiaMap());
            modelBuilder.ApplyConfiguration(new TipoVistaMap());
            modelBuilder.ApplyConfiguration(new Hip_Hipoteca_EnEjecucion_ViewMap());
            //modelBuilder.ApplyConfiguration(new vAlq_DEMANDAMap());
            //modelBuilder.ApplyConfiguration(new vAlq_Expediente_EstadoTramitaJuzgado_ActuacionesLastMap());
            //modelBuilder.ApplyConfiguration(new vAlq_InformeTotalPMap());
            //modelBuilder.ApplyConfiguration(new vExpedienteDeudorPrincipalMap());
            //modelBuilder.ApplyConfiguration(new vGnr_NombresCamposMap());
            //modelBuilder.ApplyConfiguration(new vGnr_PlantillaDoc_ALQUILER_BUROFAXMap());
            //modelBuilder.ApplyConfiguration(new vHip_HipotecaEnEjecucionMap());
            //modelBuilder.ApplyConfiguration(new vHipotecaPrincipalMap());
            //modelBuilder.ApplyConfiguration(new View_1Map());
            //modelBuilder.ApplyConfiguration(new View_5Map());
            //modelBuilder.ApplyConfiguration(new vInmueblePrincipalMap());
            //modelBuilder.ApplyConfiguration(new vw_aspnet_ApplicationsMap());
            //modelBuilder.ApplyConfiguration(new vw_aspnet_MembershipUsersMap());
            //modelBuilder.ApplyConfiguration(new vw_aspnet_ProfilesMap());
            //modelBuilder.ApplyConfiguration(new vw_aspnet_RolesMap());
            //modelBuilder.ApplyConfiguration(new vw_aspnet_UsersMap());
            //modelBuilder.ApplyConfiguration(new vw_aspnet_UsersInRolesMap());
            //modelBuilder.ApplyConfiguration(new vw_aspnet_WebPartState_PathsMap());
            //modelBuilder.ApplyConfiguration(new vw_aspnet_WebPartState_SharedMap());
            //modelBuilder.ApplyConfiguration(new vw_aspnet_WebPartState_UserMap());

            #endregion
        }

        public void SeedDataInitial()
        {
            //if (LightsOutSettingSet.Count() == 0)
            //{
            //    LightsOutSettingSet.Add(new LightsOutSetting("BoardSize", "5"));
            //    SaveChanges();
            //}
        }


        #region Methods Others

         public IEnumerable<ModelExpedienteToKpi> GetModelExpedienteToKpi(int idTipoExpediente, TipoIndicadorQa tipoIndicadorQa)
        {
             var queryBase = ModelExpedienteToKpiSet.FromSqlInterpolated($"EXEC sp_GetModelExpedienteToKpi @IdTipoExpediente={idTipoExpediente}, @TipoIndicadorQa={((int)tipoIndicadorQa)}");

            return queryBase;
        }

        //public IQueryable<Expediente> GetExpedienteByTipoIndicadorQa(TipoIndicadorQa tipoIndicadorQa, IQueryable<Expediente> queryBase = null)
        //{
        //    //var queryModelExpedienteToKpi = _solvtioDbContext.GetModelExpedienteToKpi(1);

        //    //var lst = queryModelExpedienteToKpi.ToList();

        //    #region Variables

        //    var db = _solvtioDbContext;
        //    int[] arrInt;

        //    const int idTipoEstadoHipNegociacionPosesion = (int)ExpedienteEstadoTipo.HipotecarioNegociacionPosesion;
        //    var lstClientesBase1 = new List<int>
        //    {
        //            27, //SAREB
        //            44, //ALTAMIRA SANTANDER REAL ESTATE SA
        //            54  //LLOGATALIA, S.L.
        //    };
        //    var lstResultadoPosesionPermitidas = new List<int>
        //    {
        //            1, //Positiva
        //            2, //Negativa - Prórroga Ley 1/13
        //            3, //Negativa - Reconocido Arrendamiento
        //    };

        //    var lstExpedientesParalizado = db.Gnr_TipoEstado.AsNoTracking().Where(x => x.Paralizado).Select(x => x.IdTipoEstado);
        //    var lstExpedientesFinalizado = db.Gnr_TipoEstado.AsNoTracking().Where(x => x.Fin).Select(x => x.IdTipoEstado);
        //    var lstEstadosInicio = db.Gnr_TipoEstado.AsNoTracking().Where(x => x.Inicio).Select(x => x.IdTipoEstado);

        //    var lstClientesAlqFactPersonalizados = new List<int> {
        //        IdClienteAltamiraSantander,
        //        IdClienteLlogatalia,
        //        IdClienteLuri4,
        //        IdClienteLuri6
        //    };
        //    var lstAltamiraAlq = new List<int> { 92, 44, 55, 56 };
        //    var lstAnticipaAlq = new List<int> { 62, 71, 82, 105, 106, 107 };

        //    #endregion

        //    if (queryBase == null) queryBase = db.Expedientes.Include(x => x.Gnr_ClienteOficina);

        //    if (!tipoIndicadorQa.EsDeNegociacion())
        //        queryBase = queryBase.Where(x => !x.Paralizado);

        //    var queryBaseConParalizados = queryBase; // == null ? db.Expedientes.AsQueryable() : queryBase;

        //    if (tipoIndicadorQa.EsDeFacturacion())
        //        queryBase = queryBase.Where(x => !x.EsNofacturable && !x.FacturacionCompleta);

        //    switch (tipoIndicadorQa)
        //    {
        //        #region Facturas

        //        case TipoIndicadorQa.FacturaHito1:
        //            return queryBase.Where(x => //x.IdTipoExpediente == IdTipoExpedienteHipotecario && 
        //                x.ImpFacturableH1.HasValue
        //                && x.FechaFacturableH1.HasValue
        //                && x.FechaFacturableH1 < FechaActual
        //                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.Hito1 && f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito1 && f.HitoFacturacion != HitoFacturacionValue.AlquilerHito1)
        //            );

        //        case TipoIndicadorQa.FacturaHito2:
        //            return queryBase.Where(x => //x.IdTipoExpediente == IdTipoExpedienteHipotecario && 
        //                x.ImpFacturableH2.HasValue
        //                && x.FechaFacturableH2.HasValue
        //                && x.FechaFacturableH2 < FechaActual
        //                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.Hito2 && f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito2 && f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
        //            );

        //        case TipoIndicadorQa.FacturaHito3:
        //            return queryBase.Where(x => //x.IdTipoExpediente == IdTipoExpedienteHipotecario && 
        //                x.ImpFacturableH3.HasValue
        //                && x.FechaFacturableH3.HasValue
        //                && x.FechaFacturableH3 < FechaActual
        //                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.Hito3 && f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito3 && f.HitoFacturacion != HitoFacturacionValue.AlquilerHito3)
        //            );

        //        case TipoIndicadorQa.FacturaHito4:
        //            return queryBase.Where(x =>
        //                x.ImpFacturableH4.HasValue
        //                && x.FechaFacturableH4.HasValue
        //                && x.FechaFacturableH4 < FechaActual
        //                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.Hito4 && f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito4)
        //            );
        //        case TipoIndicadorQa.FacturaHito5:
        //            return queryBase.Where(x =>
        //                x.ImpFacturableH5.HasValue
        //                && x.FechaFacturableH5.HasValue
        //                && x.FechaFacturableH5 < FechaActual
        //                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.Hito5)
        //            );
        //        case TipoIndicadorQa.FacturaHito6:
        //            return queryBase.Where(x =>
        //                x.ImpFacturableH6.HasValue
        //                && x.FechaFacturableH6.HasValue
        //                && x.FechaFacturableH6 < FechaActual
        //                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.Hito6)
        //            );

        //        #endregion

        //        #region Hipotecario

        //        #region Hipotecario - Indicadores

        //        case TipoIndicadorQa.HipTestimonioPdteInscripcion:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.IdTipoEstadoLast == IdTipoEstadoHipAdjudicacion
        //                && x.ExpedienteEstadoes.Any(ee =>
        //                    ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio.HasValue
        //                    && !ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion.HasValue
        //                )
        //            );

        //        case TipoIndicadorQa.HipotecarioInactivo:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.FechaModificacion < FechaActualMenos90
        //                && x.IdTipoEstadoLast.HasValue
        //                && lstExpedientesParalizado.All(y => y != x.IdTipoEstadoLast)
        //                && lstExpedientesFinalizado.All(y => y != x.IdTipoEstadoLast)
        //                && x.ExpedienteEstadoes.All(e => e.FechaAlta < FechaActualMenos60)
        //                && x.ExpedienteNotaSet.All(e => e.Fecha < FechaActualMenos60)
        //                && x.ImpulsoSet.All(e => e.Fecha < FechaActualMenos60)
        //                && x.ActuacionSet.All(e => e.Fecha < FechaActualMenos60)
        //            );
        //        case TipoIndicadorQa.HipotecarioIncidenciaDocumental:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoRecepcionExpediente
        //                && x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                && (
        //                    x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0102IncidenciaDocumental
        //                    || x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0104
        //                )
        //            );
        //        case TipoIndicadorQa.HipotecarioEnRevisionNoVeniados:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && !x.EsHeredado
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoRecepcionExpediente
        //                && (
        //                    !x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                    || x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0101RecepcionRevision
        //                )
        //            );
        //        case TipoIndicadorQa.HipotecarioEnRevisionVeniados:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.EsHeredado
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoRecepcionExpediente
        //                && (
        //                    !x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                    || x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0101RecepcionRevision
        //                )
        //            );

        //        case TipoIndicadorQa.HipotecarioJurisdiccionVoluntaria:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && x.ExpedienteEstadoLast != null
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipJurisdiccionVoluntaria
        //            //&& (
        //            //    !x.ExpedienteEscrituraSet.Any()
        //            ////|| x.ExpedienteEscrituraSet.Any(y => !y.FechaRecepcion.HasValue)
        //            //)
        //            //&& x.ExpedienteJurisdiccionVoluntaria != null
        //            //&& !x.ExpedienteJurisdiccionVoluntaria.FechaRecepcionEscritura.HasValue
        //            );
        //        case TipoIndicadorQa.HipotecarioAutosIncompletoErroneo:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
        //                && x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0302
        //            );

        //        case TipoIndicadorQa.HipotecarioPendientePreparacionDemanda:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast != null
        //                && (
        //                    (
        //                        x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoRecepcionExpediente
        //                        && x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0103PreparacionDemanda
        //                    )
        //                    ||
        //                        x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipGeneracionExpediente
        //                    ||
        //                    (
        //                        x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipPresentDemanda
        //                        && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoPresentacionDemanda != null
        //                        && !x.ExpedienteEstadoLast.Hip_ExpedienteEstadoPresentacionDemanda.FechaEnvioProcurador.HasValue
        //                    )
        //                ));

        //        case TipoIndicadorQa.HipotecarioPendientePresentacionDemanda:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast != null
        //                && (
        //                    x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoRecepcionExpediente
        //                    ||
        //                        x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipGeneracionExpediente
        //                    ||
        //                    (
        //                        x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipPresentDemanda
        //                        && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoPresentacionDemanda != null
        //                        && !x.ExpedienteEstadoLast.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                    )
        //                ));

        //        case TipoIndicadorQa.HipotecarioPendienteDemandaAdmitida:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.ExpedienteEstadoLast != null
        //                && (
        //                    x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
        //                    && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
        //                    && (
        //                        !x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                        || LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
        //                    )
        //                    && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta != null
        //                    && !x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.AdmitidaFecha.HasValue
        //                ) || (
        //                   x.IdTipoEstadoLast == IdTipoEstadoHipPresentDemanda
        //                   && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoPresentacionDemanda != null
        //                   && !x.ExpedienteEstadoLast.Hip_ExpedienteEstadoPresentacionDemanda.NoAdmitidaFecha.HasValue
        //                   && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                )
        //            );

        //        case TipoIndicadorQa.HipotecarioPendienteCertificacionCargas:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
        //                && (
        //                    !x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                || LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
        //                )
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta != null
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.AdmitidaFecha.HasValue
        //                && !x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.FechaCertificacionCargas.HasValue
        //            );

        //        case TipoIndicadorQa.HipotecarioPendienteRequerimientoPago:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
        //                && (
        //                    !x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                    || LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
        //                )
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta != null
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.FechaCertificacionCargas.HasValue
        //                && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoDatoRequerimiento.Any(y => !y.Positivo)
        //            );

        //        case TipoIndicadorQa.HipotecarioPendienteNotificacion:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
        //                && (
        //                    !x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                    || LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
        //                )
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta != null
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.FechaCertificacionCargas.HasValue
        //                && !x.ExpedienteEstadoLast.Hip_ExpedienteEstadoDatoRequerimiento.Any()
        //            );

        //        case TipoIndicadorQa.HipotecarioPendienteSolicitarSubasta:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
        //                && (
        //                    !x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                    || LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
        //                )
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta != null
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.FechaCertificacionCargas.HasValue
        //                && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoDatoRequerimiento.All(y => y.Positivo)
        //                //&& x.ExpedienteSubastaSet.All(s => s.IdMotivoSuspension.HasValue)
        //                && (
        //                    !x.IdExpedienteSubastaLast.HasValue
        //                    || x.ExpedienteSubastaLast.IdMotivoSuspension.HasValue
        //                )
        //            //&& !x.ExpedienteSubastaSet.Any()
        //            );

        //        case TipoIndicadorQa.HipotecarioPendienteConvocatoriaSubasta:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
        //                //&& x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                && !LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
        //                && x.IdExpedienteSubastaLast.HasValue
        //                && !x.ExpedienteSubastaLast.FechaDecretoSubasta.HasValue
        //                && !x.ExpedienteSubastaLast.FechaCelebracion.HasValue
        //            );

        //        case TipoIndicadorQa.HipotecarioPendienteSuspensionDecreto:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
        //                && x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                && !LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
        //                && x.IdExpedienteSubastaLast.HasValue
        //                && x.ExpedienteSubastaLast.IdMotivoSuspensionDecretoSubasta.HasValue
        //            );

        //        case TipoIndicadorQa.HipotecarioPendienteSubastasSuspendidas:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
        //                && x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                && !LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
        //                && x.IdExpedienteSubastaLast.HasValue
        //                && x.ExpedienteSubastaLast.IdMotivoSuspension.HasValue
        //            );

        //        case TipoIndicadorQa.HipotecarioPendienteAdjudicacion:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
        //                && x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                && !LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta != null
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.PostSubastaFechaSolicitudAdjudicacion.HasValue
        //            );

        //        case TipoIndicadorQa.HipotecarioDecretoConvocatoriaSubasta:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
        //                && x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                && !LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
        //                && x.IdExpedienteSubastaLast.HasValue
        //                && x.ExpedienteSubastaLast.FechaDecretoSubasta.HasValue
        //                && !x.ExpedienteSubastaLast.FechaCelebracion.HasValue
        //                && !x.ExpedienteSubastaLast.IdMotivoSuspension.HasValue
        //                && !x.ExpedienteSubastaLast.IdMotivoSuspensionDecretoSubasta.HasValue
        //            );

        //        case TipoIndicadorQa.HipotecarioIncidenciaDecretoAjdudicacion:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.IdTipoEstadoLast == IdTipoEstadoHipAdjudicacion
        //                && x.ExpedienteEstadoes.Any(e =>
        //                    e.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
        //                    && e.HipExpedienteEstadoTramitacionSubasta != null
        //                    && (
        //                        e.HipExpedienteEstadoTramitacionSubasta.PostSubastaCesion == SubastaCesionType.Pendiente
        //                        || e.HipExpedienteEstadoTramitacionSubasta.IdPostSubastaEstadoConsignacion == 1
        //                        || e.HipExpedienteEstadoTramitacionSubasta.IdPostSubastaEstadoIndicenciaDecreto == 1
        //                        || e.HipExpedienteEstadoTramitacionSubasta.PostSubastaAdjudicacionTercero
        //                    )
        //                )
        //            );

        //        case TipoIndicadorQa.HipotecarioPendienteTestimonioAdjudicacion:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.IdTipoEstadoLast == IdTipoEstadoHipAdjudicacion
        //                && x.ExpedienteEstadoes.Any(ee =>
        //                    ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaAdjudicacion.HasValue
        //                    && !ee.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio.HasValue
        //                )
        //            );

        //        case TipoIndicadorQa.HipotecarioPendienteSolicitudPosesion:
        //            return queryBase.Where(x => x.IdTipoExpediente == 1
        //                && x.IdTipoEstadoLast == IdTipoEstadoHipAdjudicacion
        //                && x.ExpedienteEstadoes.Any(ee =>
        //                    ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //                    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio.HasValue
        //                    && !ee.Hip_ExpedienteEstadoAdjudicacion.FechaSolicitudPosesion.HasValue
        //                    && !ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion.HasValue
        //                ));

        //        case TipoIndicadorQa.HipotecarioPendienteLanzamiento:
        //            int idTipoVistaLanzamiento = (int)TipoVistaEnum.HipotecarioLanzamiento;
        //            //int idTipoVistaPosesion = (int)TipoVistaEnum.HipotecarioPosesion;
        //            int idMotivoSuspReconocidoArrendamiento = 76; //Reconocido Arrendamiento
        //            int idMotivoSuspAcuerdoFormalizado = 77; //Acuerdo Formalizado
        //            int idMotivoSuspLey1_2013 = 3; //Ley 1/2013

        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //                && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion != null
        //                && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio.HasValue
        //                && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaSolicitudPosesion.HasValue
        //                && !x.ExpedienteVistas.Any(ev => ev.IdTipoVista == idTipoVistaLanzamiento
        //                    && (
        //                        ev.Resultado == PositivoNegativoType.Positivo
        //                        || ev.IdMotivoSuspension == idMotivoSuspReconocidoArrendamiento
        //                        || ev.IdMotivoSuspension == idMotivoSuspAcuerdoFormalizado
        //                        || ev.IdMotivoSuspension == idMotivoSuspLey1_2013
        //                       )
        //                ));


        //        //&& x.ExpedienteVistas.Any(ev =>
        //        //    ev.IdTipoVista == idTipoVistaPosesion
        //        //    && ev.Resultado != PositivoNegativoType.Negativo
        //        //    && ev.IdMotivoSuspension != idMotivoSuspReconocidoArrendamiento
        //        //));

        //        //return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //        //    && x.IdTipoEstadoLast == IdTipoEstadoHipAdjudicacion
        //        //    && !x.ExpedienteVistas.Any(ev => ev.IdTipoVista == idTipoVistaLanzamiento)
        //        //    && x.ExpedienteVistas.Any(ev =>
        //        //        ev.IdTipoVista == idTipoVistaPosesion
        //        //        && ev.Resultado != PositivoNegativoType.Negativo
        //        //        && ev.IdMotivoSuspension != idMotivoSuspReconocidoArrendamiento
        //        //    ));

        //        //&& x.ExpedienteEstadoes.Any(ee =>
        //        //    ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //        //    && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion.HasValue
        //        //    && !ee.Hip_ExpedienteEstadoAdjudicacion.FechaLanzamiento.HasValue
        //        //    && ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion != 1 //positivo
        //        //    && ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion != 3 //Negativa - Reconocido Arrendamiento
        //        //));

        //        case TipoIndicadorQa.HipotecarioPendienteNegociacionPosesion:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.IdClienteOficina == 8 //Bankia
        //                && x.IdTipoEstadoLast == IdTipoEstadoHipAdjudicacion
        //            //&& !x.ExpedienteNegociacion.IdGestorContencioso.HasValue
        //            );

        //        //return queryBase.Where(x =>
        //        //    (!x.IdExpedienteNegociacion.HasValue || (
        //        //         !x.ExpedienteNegociacion.IdGestor.HasValue
        //        //         && !x.ExpedienteNegociacion.PrecontenciosoFechaFin.HasValue
        //        //     ))
        //        //    && x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //        //    && lstEstadosInicio.Any(e => e == x.IdTipoEstadoLast)
        //        //    && LstAlqClientes.Any(c => c == x.Gnr_ClienteOficina.IdCliente)
        //        //);

        //        case TipoIndicadorQa.HipotecarioPendienteTestimoniosInscripcion:
        //            break;
        //        case TipoIndicadorQa.HipotecarioPendienteAdjudicacionLey12013:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.IdTipoEstadoLast == IdTipoEstadoHipAdjudicacion
        //                && x.ExpedienteEstadoes.Any(ee =>
        //                    ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //                    && !ee.FechaFin.HasValue
        //                    && ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion == 2 // Negativa - Prórroga Ley 1/13
        //                ));

        //        case TipoIndicadorQa.HipotecarioCalificacionNegativa:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                    && x.IdEstadoLast.HasValue
        //                                    && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //                                    && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion != null
        //                                    && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio.HasValue
        //                                    && !x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion.HasValue
        //                                    && (
        //                                        x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaActaSituacionArrendaticia
        //                                        || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaInscripcionCredito
        //                                        || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaOtro
        //                                        || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaOmisionImputacionPagos654
        //                                        || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaDefectosImpultacion654
        //                                        || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaIndenciaImportesAdjudicacion
        //                                        || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaExcesoResponsabilidadHip
        //                                        || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaDefectosNotificaciones
        //                                        || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaCargasPrevias
        //                                        || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaInstanciasConfusionDerechos
        //                                        || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaCargasUrbanisticas
        //                                        || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaLimitacionesLibreDisposición
        //                                        || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaIbisPendientes
        //                                        || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaDeudasComunidadPropietario
        //                                        || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaDerechosTanteoRetracto
        //                                        || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaDefectosMandamientosCancelacion
        //                                        || x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.CalificacionNegativaPteCancelacionNotaMarginal
        //                                    )
        //                                 );

        //        case TipoIndicadorQa.HipotecarioLiquidacionItp:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //                && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion != null
        //                && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio.HasValue
        //                && !x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.LiquidacionITP
        //            );

        //        #endregion

        //        #region Hipotecario - Alarmas

        //        case TipoIndicadorQa.HipotecarioAlarmaIncidentados:
        //            var lstSubfases = new List<int> { 1010102, 1010104 };

        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoRecepcionExpediente
        //                && x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                && lstSubfases.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
        //                && x.ExpedienteEstadoLast.Fecha < FechaActualMenos30
        //            );

        //        case TipoIndicadorQa.HipotecarioAlarmaAdmisionDemanda:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && !x.EsHeredado
        //                && x.IdTipoEstadoLast == IdTipoEstadoHipPresentDemanda
        //                && x.ExpedienteEstadoes.Any(ee =>
        //                    ee.IdTipoEstado == IdTipoEstadoHipPresentDemanda
        //                    && !ee.FechaFin.HasValue
        //                    && !ee.Hip_ExpedienteEstadoPresentacionDemanda.NoAdmitidaFecha.HasValue
        //                    && ee.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                    && ee.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion < FechaActualMenos80
        //                ));

        //        case TipoIndicadorQa.HipotecarioAlarmaInadmisionDemanda:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.IdTipoEstadoLast == IdTipoEstadoHipPresentDemanda
        //                && x.ExpedienteEstadoes.Any(ee =>
        //                    ee.IdTipoEstado == IdTipoEstadoHipPresentDemanda
        //                    && !ee.FechaFin.HasValue
        //                    && ee.Hip_ExpedienteEstadoPresentacionDemanda.NoAdmitidaFecha.HasValue
        //                    && !ee.Hip_ExpedienteEstadoPresentacionDemanda.NoAdmitidaFechaApelacion.HasValue
        //                    && ee.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                    && ee.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion < FechaActualMenos80
        //                ));

        //        case TipoIndicadorQa.HipotecarioAlarmaSucesionCopiaSellada:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && !x.Fin.HasValue
        //                && !x.SucesionCopiaSellada.HasValue
        //                && x.SucesionPresentada.HasValue
        //                && x.SucesionPresentada < FechaActualMenos2
        //            );

        //        case TipoIndicadorQa.HipotecarioAlarmaCertificacionCargas:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
        //                && (
        //                    !x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                    || LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
        //                )
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta != null
        //                && !x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.FechaCertificacionCargas.HasValue
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.AdmitidaFecha.HasValue
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.AdmitidaFecha < FechaActualMenos90
        //            );

        //        case TipoIndicadorQa.HipotecarioAlarmaRequerimientoPago:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
        //                && (
        //                    !x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                    || LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
        //                )
        //                && x.ExpedienteDeudors.Any(ed => !ed.RequerimientoPagoPositivo)
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta != null
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.AdmitidaFecha.HasValue
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.AdmitidaFecha < FechaActualMenos150
        //            );

        //        case TipoIndicadorQa.HipotecarioAlarmaSolicitudSubasta:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
        //                && (
        //                    !x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                    || LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
        //                )
        //                && (
        //                    !x.IdExpedienteSubastaLast.HasValue
        //                    || x.ExpedienteSubastaLast.IdMotivoSuspension.HasValue
        //                )
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta != null
        //                && !x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.Oposicion
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.FechaCertificacionCargas.HasValue
        //                && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoDatoRequerimiento.Any()
        //                && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoDatoRequerimiento.All(r =>
        //                    r.Positivo
        //                    && r.FechaRequerimientoPago.HasValue
        //                    && r.FechaRequerimientoPago < FechaActualMenos20)
        //            );

        //        case TipoIndicadorQa.HipotecarioAlarmaDecretoConvocatoria:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
        //                && x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                && !LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
        //                && x.IdExpedienteSubastaLast.HasValue
        //                && x.ExpedienteSubastaLast != null
        //                && !x.ExpedienteSubastaLast.IdMotivoSuspension.HasValue
        //                && !x.ExpedienteSubastaLast.FechaCelebracion.HasValue
        //                && !x.ExpedienteSubastaLast.IdMotivoSuspensionDecretoSubasta.HasValue
        //                && x.ExpedienteSubastaLast.FechaDecretoSubasta.HasValue
        //                && x.ExpedienteSubastaLast.FechaDecretoSubasta < FechaActualMenos80
        //            );

        //        case TipoIndicadorQa.HipotecarioAlarmaDecretoAdjudicacion:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.IdTipoEstadoLast == IdTipoEstadoHipTramitacionSubasta
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
        //                && x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                && !LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
        //                && x.IdExpedienteSubastaLast.HasValue
        //                && x.ExpedienteSubastaLast != null
        //                && !x.ExpedienteSubastaLast.IdMotivoSuspension.HasValue
        //                && x.ExpedienteSubastaLast.FechaCelebracion.HasValue
        //                && x.ExpedienteSubastaLast.FechaCelebracion < FechaActualMenos80
        //            );

        //        case TipoIndicadorQa.HipotecarioAlarmaPosesion:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //                && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion != null
        //                && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaAdjudicacion.HasValue
        //                && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaAdjudicacion < FechaActualMenos200
        //                && !x.Hip_Inmueble.Any(i =>
        //                    i.Ley12013 || i.ReconocidoArrendamiento || i.AcuerdoFormalizado || i.InstruccionGestores || i.RecuperadaPosesionJudicial
        //                )
        //                && (
        //                    x.Hip_Inmueble.Count == 0
        //                    || !x.Hip_Inmueble.Any(i => i.Ley12013 || i.ReconocidoArrendamiento || i.AcuerdoFormalizado || i.InstruccionGestores || i.RecuperadaPosesionJudicial)
        //                )
        //                && (
        //                    x.ExpedienteVistas.Count == 0
        //                    || !x.ExpedienteVistas.Any(v => v.Resultado == PositivoNegativoType.Positivo)
        //                )
        //            );

        //        case TipoIndicadorQa.HipotecarioAlarmaTestimonio:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //                && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion != null
        //                && !x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion.HasValue
        //                && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio.HasValue
        //                && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio < FechaActualMenos120
        //            );

        //        case TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre01:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipGeneracionExpediente
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion != null
        //                && !x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.TituloEjecutivoFechaObtencion.HasValue
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.TituloEjecutivoFechaSolicitud.HasValue
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.TituloEjecutivoFechaSolicitud < FechaActualMenos30
        //            );

        //        case TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre02:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipGeneracionExpediente
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion != null
        //                && !x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.BuroFax30FechaObtencion.HasValue
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.BuroFax30FechaSolicitud.HasValue
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.BuroFax30FechaSolicitud < FechaActualMenos3
        //            );

        //        case TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre05:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipGeneracionExpediente
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion != null
        //                && !x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.BuroFax10FechaObtencion.HasValue
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.BuroFax10FechaSolicitud.HasValue
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.BuroFax10FechaSolicitud < FechaActualMenos5
        //            );

        //        case TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre03:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipGeneracionExpediente
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion != null
        //                && !x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.LiquidacionFechaObtencion.HasValue
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.LiquidacionFechaSolicitud.HasValue
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.LiquidacionFechaSolicitud < FechaActualMenos33
        //            );

        //        case TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre04:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipGeneracionExpediente
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion != null
        //                && !x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.CertificadoFechaObtencion.HasValue
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.CertificadoFechaSolicitud.HasValue
        //                && x.ExpedienteEstadoLast.HipExpedienteEstadoGeneracion.CertificadoFechaSolicitud < FechaActualMenos15
        //            );

        //        #endregion

        //        #region Hipotecario - Facturas

        //        #region Hipotecario - Facturas - Solvia





        //        case TipoIndicadorQa.HipotecarioFacturaSolviaHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && LstOficinasSolvia.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito1 && f.HitoFacturacion != HitoFacturacionValue.Hito1)
        //                                        && x.ExpedienteEstadoes.Any(ee =>
        //                                            ee.IdTipoEstado == IdTipoEstadoHipPresentDemanda
        //                                            && ee.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                                            && ee.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion <= FechaActual
        //                                        ));

        //        case TipoIndicadorQa.HipotecarioFacturaSolviaHito2:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && LstOficinasSolvia.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito2 && f.HitoFacturacion != HitoFacturacionValue.Hito2)
        //                                        && x.ExpedienteEstadoes.Any(ee =>
        //                                            ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaAdjudicacion.HasValue
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaAdjudicacion <= FechaActual
        //                                        ));

        //        case TipoIndicadorQa.HipotecarioFacturaSolviaHito3:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && LstOficinasSolvia.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito3)
        //                                        && x.ExpedienteEstadoes.Any(ee =>
        //                                            ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //                                            && (
        //                                                ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion == 1
        //                                                || ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion == 3
        //                                            )
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion.HasValue
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion <= FechaActual
        //                                        ));

        //        case TipoIndicadorQa.HipotecarioFacturaSolviaHito4:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && LstOficinasSolvia.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito4)
        //                                        && x.ExpedienteEstadoes.Any(ee =>
        //                                            ee.IdTipoEstado == IdTipoEstadoHipFinalizado
        //                                            && ee.Hip_ExpedienteEstadoFinalizacion != null
        //                                            && ee.Fecha <= FechaActual
        //                                        ));

        //        #endregion

        //        #region Hipotecario - Facturas - Sabadel

        //        case TipoIndicadorQa.HipotecarioFacturaSabadellHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && LstOficinasSabadel.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito1 && f.HitoFacturacion != HitoFacturacionValue.Hito1)
        //                                        && x.IdExpedienteSubastaLast.HasValue
        //                                        && !x.ExpedienteSubastaLast.IdMotivoSuspension.HasValue
        //                                        && x.ExpedienteSubastaLast.FechaCelebracion.HasValue
        //                                        && x.ExpedienteSubastaLast.FechaCelebracion <= FechaActual
        //                                        );
        //        case TipoIndicadorQa.HipotecarioFacturaSabadellHito2:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && LstOficinasSabadel.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito2 && f.HitoFacturacion != HitoFacturacionValue.Hito2)
        //                                        && x.ExpedienteEstadoes.Any(ee =>
        //                                            ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion != null
        //                                            && lstResultadoPosesionPermitidas.Any(r => r == ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion)
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion.HasValue
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion <= FechaActual
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion.HasValue
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion <= FechaActual
        //                                        ));

        //        case TipoIndicadorQa.HipotecarioFacturaSabadellHito3:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && LstOficinasSabadel.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito2 && f.HitoFacturacion != HitoFacturacionValue.Hito2)
        //                                        && x.ExpedienteEstadoes.Any(ee =>
        //                                            ee.IdTipoEstado == IdTipoEstadoHipFinalizado
        //                                            && ee.Hip_ExpedienteEstadoFinalizacion != null
        //                                            && ee.Fecha <= FechaActual
        //                                        ));
        //        #endregion

        //        #region Hipotecario - Facturas - Anticipa / Sareb / PostEjc

        //        case TipoIndicadorQa.HipotecarioFacturaAnticipaHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && LstOficinasAnticipa.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito1 && f.HitoFacturacion != HitoFacturacionValue.Hito1)
        //                                        && x.ExpedienteEstadoes.Any(ee =>
        //                                            ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion != null
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaAdjudicacion.HasValue
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaAdjudicacion <= FechaActual
        //                                        ));
        //        case TipoIndicadorQa.HipotecarioFacturaAnticipaHito2:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && LstOficinasAnticipa.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito2 && f.HitoFacturacion != HitoFacturacionValue.Hito2)
        //                                        && x.ExpedienteEstadoes.Any(ee =>
        //                                            ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion != null
        //                                            && lstResultadoPosesionPermitidas.Any(r => r == ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion)
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion.HasValue
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion <= FechaActual
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion.HasValue
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion <= FechaActual
        //                                        ));

        //        case TipoIndicadorQa.HipotecarioFacturaSarebHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && LstOficinasSareb.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito1 && f.HitoFacturacion != HitoFacturacionValue.Hito1)
        //                                        && x.ExpedienteEstadoes.Any(ee =>
        //                                            ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion != null
        //                                            && lstResultadoPosesionPermitidas.Any(r => r == ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion)
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion.HasValue
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion <= FechaActual
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion.HasValue
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion <= FechaActual
        //                                        ));
        //        case TipoIndicadorQa.HipotecarioFacturaSarebHito2:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && LstOficinasSareb.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito2 && f.HitoFacturacion != HitoFacturacionValue.Hito2)
        //                                        && x.ExpedienteEstadoes.Any(ee =>
        //                                            ee.IdTipoEstado == IdTipoEstadoHipFinalizado
        //                                            && ee.Hip_ExpedienteEstadoFinalizacion != null
        //                                            && ee.Fecha <= FechaActual
        //                                        ));
        //        case TipoIndicadorQa.HipotecarioFacturaPostEjcHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && LstHipOficinasPostEjc.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito1 && f.HitoFacturacion != HitoFacturacionValue.Hito1)
        //                                        && x.ExpedienteEstadoes.Any(ee =>
        //                                            ee.IdTipoEstado == IdTipoEstadoHipFinalizado
        //                                            && ee.Hip_ExpedienteEstadoFinalizacion != null
        //                                            && ee.Fecha <= FechaActual
        //                                        ));
        //        #endregion

        //        #region Hipotecario - Facturas - Bankia

        //        case TipoIndicadorQa.HipotecarioFacturaBankiaHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && LstHipOficinasBankia.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito1 && f.HitoFacturacion != HitoFacturacionValue.Hito1)
        //                                        && x.IdExpedienteSubastaLast.HasValue
        //                                        && !x.ExpedienteSubastaLast.IdMotivoSuspension.HasValue
        //                                        && x.ExpedienteSubastaLast.FechaCelebracion.HasValue
        //                                        && x.ExpedienteSubastaLast.FechaCelebracion <= FechaActual
        //            );
        //        case TipoIndicadorQa.HipotecarioFacturaBankiaHito2a:
        //            return queryBase
        //                .Include(x => x.ExpedienteEstadoLast.Hip_ExpedienteEstadoFinalizacion.Gnr_TipoEstadoMotivo)
        //                .Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && LstHipOficinasBankia.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito2)
        //                                        && x.ExpedienteEstadoes.Any(ee =>
        //                                            ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion != null
        //                                            && lstResultadoPosesionPermitidas.Any(r => r == ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion)
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion.HasValue
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion <= FechaActual
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion.HasValue
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion <= FechaActual
        //                                        ));

        //        case TipoIndicadorQa.HipotecarioFacturaBankiaHito2b:
        //            return queryBase
        //                .Include(x => x.ExpedienteEstadoLast.Hip_ExpedienteEstadoFinalizacion.Gnr_TipoEstadoMotivo)
        //                .Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && LstHipOficinasBankia.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito2 && f.HitoFacturacion != HitoFacturacionValue.Hito2)
        //                                        && x.ExpedienteEstadoes.Any(ee =>
        //                                            ee.IdTipoEstado == IdTipoEstadoHipFinalizado
        //                                            && ee.Hip_ExpedienteEstadoFinalizacion != null
        //                                            && ee.Fecha <= FechaActual
        //                                        ));
        //        #endregion

        //        #region Hipotecario - Facturas - Aliseda

        //        case TipoIndicadorQa.HipotecarioFacturaAlisedaNoVeniadoHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && !x.EsHeredado
        //                                        && !x.FacturacionCompleta && !x.EsNofacturable
        //                                        && LstHipOficinasAliseda.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito1 && f.HitoFacturacion != HitoFacturacionValue.Hito1)
        //                                        && x.ExpedienteEstadoes.Any(ee =>
        //                                            ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion != null
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaAdjudicacion.HasValue
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaAdjudicacion <= FechaActual
        //                                        ));
        //        case TipoIndicadorQa.HipotecarioFacturaAlisedaVeniadoHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && x.EsHeredado
        //                                        && LstHipOficinasAliseda.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito1 && f.HitoFacturacion != HitoFacturacionValue.Hito1)
        //                                        && x.FechaCargaAppCliente.HasValue);

        //        case TipoIndicadorQa.HipotecarioFacturaAlisedaNoVeniadoHito2:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && !x.EsHeredado
        //                                        && LstHipOficinasAliseda.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito2 && f.HitoFacturacion != HitoFacturacionValue.Hito2)
        //                                        && x.ExpedienteEstadoes.Any(ee =>
        //                                            ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion != null
        //                                            && lstResultadoPosesionPermitidas.Any(r => r == ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion)
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion.HasValue
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion <= FechaActual
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion.HasValue
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion <= FechaActual
        //                                        ));
        //        case TipoIndicadorQa.HipotecarioFacturaAlisedaVeniadoHito2:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && x.EsHeredado
        //                                        && LstHipOficinasAliseda.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito2 && f.HitoFacturacion != HitoFacturacionValue.Hito2)
        //                                        && x.ExpedienteEstadoes.Any(ee =>
        //                                            ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion != null
        //                                            && lstResultadoPosesionPermitidas.Any(r => r == ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion)
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion.HasValue
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion <= FechaActual
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion.HasValue
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion <= FechaActual
        //                                        ));

        //        case TipoIndicadorQa.HipotecarioFacturaAlisedaNoVeniadoFinalizadosPdteFacturar:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && !x.EsHeredado
        //                                        && x.Fin.HasValue
        //                                        && LstHipOficinasAliseda.Any(y => y == x.IdClienteOficina)
        //                                        && (
        //                                            !x.FacturaSet.Any(f => f.HitoFacturacion == HitoFacturacionValue.HipotecarioHito1)
        //                                            || !x.FacturaSet.Any(f => f.HitoFacturacion == HitoFacturacionValue.HipotecarioHito2)
        //                                        ));
        //        case TipoIndicadorQa.HipotecarioFacturaAlisedaVeniadoFinalizadosPdteFacturar:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && x.EsHeredado
        //                                        && x.Fin.HasValue
        //                                        && LstHipOficinasAliseda.Any(y => y == x.IdClienteOficina)
        //                                        && (
        //                                            !x.FacturaSet.Any(f => f.HitoFacturacion == HitoFacturacionValue.HipotecarioHito1)
        //                                            || !x.FacturaSet.Any(f => f.HitoFacturacion == HitoFacturacionValue.HipotecarioHito2)
        //                                        ));

        //        #endregion

        //        #region Hipotecario - Facturas - Abanca

        //        case TipoIndicadorQa.HipotecarioFacturaAbancaHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && LstHipOficinasAbanca.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito1 && f.HitoFacturacion != HitoFacturacionValue.Hito1)
        //                                        && x.ExpedienteEstadoes.Any(ee =>
        //                                            ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion != null
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio.HasValue
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio <= FechaActual
        //                                        ));
        //        case TipoIndicadorQa.HipotecarioFacturaAbancaHito2:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && LstHipOficinasAbanca.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito2 && f.HitoFacturacion != HitoFacturacionValue.Hito2)
        //                                        && x.ExpedienteEstadoes.Any(ee =>
        //                                            ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion != null
        //                                            && lstResultadoPosesionPermitidas.Any(r => r == ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion)
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion.HasValue
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion <= FechaActual
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion.HasValue
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion <= FechaActual
        //                                        ));

        //        case TipoIndicadorQa.HipotecarioFacturaAbancaHito3:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && LstHipOficinasAbanca.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito3)
        //                                        && x.ExpedienteEstadoes.Any(ee =>
        //                                            ee.IdTipoEstado == IdTipoEstadoHipFinalizado
        //                                            && ee.Hip_ExpedienteEstadoFinalizacion != null
        //                                            && ee.Fecha <= FechaActual
        //                                        ));
        //        #endregion

        //        #region Hipotecario - Facturas - VoyagerAltamira

        //        case TipoIndicadorQa.HipotecarioFacturaVoyagerAltamiraNoVeniadoHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && !x.EsHeredado
        //                                        && LstHipOficinasVoyagerAltamira.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito1 && f.HitoFacturacion != HitoFacturacionValue.Hito1)
        //                                        && x.ExpedienteEstadoes.Any(ee =>
        //                                            ee.IdTipoEstado == IdTipoEstadoHipPresentDemanda
        //                                            && ee.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                                            && ee.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion <= FechaActual
        //                                        ));

        //        case TipoIndicadorQa.HipotecarioFacturaVoyagerAltamiraNoVeniadoHito2:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && !x.EsHeredado
        //                                        && LstHipOficinasVoyagerAltamira.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito2 && f.HitoFacturacion != HitoFacturacionValue.Hito2)
        //                                        && x.IdExpedienteSubastaLast.HasValue
        //                                        && !x.ExpedienteSubastaLast.IdMotivoSuspension.HasValue
        //                                        && x.ExpedienteSubastaLast.FechaCelebracion.HasValue
        //                                        && x.ExpedienteSubastaLast.FechaCelebracion <= FechaActual
        //                                        );

        //        case TipoIndicadorQa.HipotecarioFacturaVoyagerAltamiraNoVeniadoHitoFinalizacion:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && !x.EsHeredado
        //                                        && LstHipOficinasVoyagerAltamira.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito4)
        //                                        && x.ExpedienteEstadoes.Any(ee =>
        //                                            ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion != null
        //                                            && lstResultadoPosesionPermitidas.Any(r => r == ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion)
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion.HasValue
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion <= FechaActual
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion.HasValue
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion <= FechaActual
        //                                        ));

        //        case TipoIndicadorQa.HipotecarioFacturaVoyagerAltamiraVeniadoHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && x.EsHeredado
        //                                        && LstHipOficinasVoyagerAltamira.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito1 && f.HitoFacturacion != HitoFacturacionValue.Hito1)
        //                                        && x.IdExpedienteSubastaLast.HasValue
        //                                        && !x.ExpedienteSubastaLast.IdMotivoSuspension.HasValue
        //                                        && x.ExpedienteSubastaLast.FechaCelebracion.HasValue
        //                                        && x.ExpedienteSubastaLast.FechaCelebracion <= FechaActual
        //                                        );

        //        case TipoIndicadorQa.HipotecarioFacturaVoyagerAltamiraVeniadoHitoFinalizacion:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && x.EsHeredado
        //                                        && LstHipOficinasVoyagerAltamira.Any(y => y == x.IdClienteOficina)
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.HipotecarioHito4)
        //                                        && x.ExpedienteEstadoes.Any(ee =>
        //                                            ee.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion != null
        //                                            && lstResultadoPosesionPermitidas.Any(r => r == ee.Hip_ExpedienteEstadoAdjudicacion.ResultadoPosesion)
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion.HasValue
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaCertificadoInscripcion <= FechaActual
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion.HasValue
        //                                            && ee.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion <= FechaActual
        //                                        ));

        //        #endregion

        //        #region Otros

        //        //result. = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioFinalizadoSinFactura).Count();
        //        case TipoIndicadorQa.HipotecarioFinalizadoSinFactura:
        //            return queryBase.Where(x =>
        //                x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                && !x.EsHeredado
        //                && !x.FacturacionCompleta
        //                && x.Fin.HasValue
        //                && !x.FacturaSet.Any()
        //            );

        //        case TipoIndicadorQa.AlquilerFinalizadoSinFactura:
        //            return queryBase.Where(x =>
        //                x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && !x.EsHeredado
        //                && !x.FacturacionCompleta
        //                && x.Fin.HasValue
        //                && !x.FacturaSet.Any()
        //            );

        //        case TipoIndicadorQa.OrdinarioFinalizadoSinFactura:
        //            return queryBase.Where(x =>
        //                x.IdTipoExpediente == IdTipoExpedienteOrdinario
        //                && !x.EsHeredado
        //                && !x.FacturacionCompleta
        //                && x.Fin.HasValue
        //                && !x.FacturaSet.Any()
        //            );

        //        case TipoIndicadorQa.EjecutivoFinalizadoSinFactura:
        //            return queryBase.Where(x =>
        //                x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                && !x.EsHeredado
        //                && !x.FacturacionCompleta
        //                && x.Fin.HasValue
        //                && !x.FacturaSet.Any()
        //            );

        //        #endregion

        //        #endregion

        //        #region Hipotecario - SLA

        //        #region Hipotecario - SLA - PresentacionDemanda

        //        case TipoIndicadorQa.HipotecarioSlaPresentacionDemandaBankia:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && LstHipOficinasBankia.Any(y => y == x.IdClienteOficina)
        //                                        && !x.ExpedienteEstadoes.Any(ee => ee.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue)
        //                                        && !x.Fin.HasValue
        //                                        && !x.Paralizado
        //            );

        //        #endregion

        //        #endregion

        //        #region Hipotecario - QaDatos

        //        case TipoIndicadorQa.ExpHipQaDatosSinInmueble:
        //            var lstTipoEstadoPosibles = new List<int> { IdTipoEstadoHipPresentDemanda, IdTipoEstadoHipTramitacionSubasta, IdTipoEstadoHipAdjudicacion };
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && !x.Fin.HasValue
        //                                        && !x.Paralizado
        //                                        && x.IdEstadoLast.HasValue
        //                                        && lstTipoEstadoPosibles.Contains(x.ExpedienteEstadoLast.IdTipoEstado)
        //                                        && !x.Hip_Inmueble.Any()

        //            );

        //        case TipoIndicadorQa.ExpHipQaDatosSinPartidoJudicial:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && !x.Fin.HasValue
        //                                        && !x.Paralizado
        //                                        && x.ExpedienteEstadoLast != null
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado >= IdTipoEstadoHipTramitacionSubasta
        //                                        && !x.IdPartidoJudicial.HasValue

        //            );

        //        case TipoIndicadorQa.ExpHipQaDatosSinNoAuto:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && !x.Fin.HasValue
        //                                        && !x.Paralizado
        //                                        && x.ExpedienteEstadoLast != null
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado >= IdTipoEstadoHipTramitacionSubasta
        //                                        && (x.NoAuto == null || x.NoAuto == "")
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado != IdTipoEstadoHipJurisdiccionVoluntaria
        //            );



        //        case TipoIndicadorQa.ExpHipQaDatosSinFechaDemanda:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && !x.Fin.HasValue
        //                                        && !x.Paralizado
        //                                        && !x.EsHeredado
        //                                        && x.ExpedienteEstadoLast != null
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado >= IdTipoEstadoHipTramitacionSubasta
        //                                        && x.ExpedienteEstadoes.Any(ee =>
        //                                            ee.IdTipoEstado == IdTipoEstadoHipPresentDemanda
        //                                            && ee.Hip_ExpedienteEstadoPresentacionDemanda != null
        //                                            && (
        //                                                !ee.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                                                || !ee.Hip_ExpedienteEstadoPresentacionDemanda.FechaEnvioProcurador.HasValue)
        //                                            )
        //            );

        //        case TipoIndicadorQa.ExpHipQaDatosSinJuzgado:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && !x.Fin.HasValue
        //                                        //&& !x.Paralizado
        //                                        //&& !x.EsHeredado
        //                                        && x.ExpedienteEstadoLast != null
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado >= IdTipoEstadoHipTramitacionSubasta
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado != IdTipoEstadoHipJurisdiccionVoluntaria
        //                                        && (!x.IdJuzgado.HasValue || x.IdJuzgado == 5710 || x.IdJuzgado == 0)

        //            );

        //        case TipoIndicadorQa.ExpHipQaDatosSinDemandaAdmitida:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && !x.Fin.HasValue
        //                                        && !x.Paralizado
        //                                        && !x.EsHeredado
        //                                        && x.ExpedienteEstadoLast != null
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado >= IdTipoEstadoHipTramitacionSubasta
        //                                        && x.ExpedienteEstadoes.Any(ee =>
        //                                            ee.IdTipoEstado == IdTipoEstadoHipTramitacionSubasta
        //                                            && ee.HipExpedienteEstadoTramitacionSubasta != null
        //                                            && !ee.HipExpedienteEstadoTramitacionSubasta.AdmitidaFecha.HasValue)

        //            );

        //        case TipoIndicadorQa.ExpHipQaDatosAdjudicacionIncompletos:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //                                        && !x.Fin.HasValue
        //                                        && !x.Paralizado
        //                                        && !x.EsHeredado
        //                                        && x.ExpedienteEstadoLast != null
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //                                        && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion != null
        //                                        && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaSolicitudPosesion.HasValue
        //                                        && (
        //                                                !x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio.HasValue
        //                                                || !x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaAdjudicacion.HasValue
        //                                                || !x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.ActaArrendaticiaFechaSolicitud.HasValue
        //                                            )
        //            );

        //        #endregion

        //        #endregion

        //        #region Conciliacion

        //        #region Facturas 

        //        case TipoIndicadorQa.ConciliacionFacturasHito1Caixa:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConciliacion
        //                && x.Gnr_ClienteOficina.IdCliente == IdClienteCaixa
        //                && !x.FacturaSet.Any()
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoCclFinalizado
        //            );

        //        #endregion

        //        #endregion

        //        #region Alquiler

        //        #region Alquiler Indicadores

        //        case TipoIndicadorQa.AlquilerInactivo:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                                        && x.FechaModificacion < FechaActualMenos90
        //                                        && x.IdTipoEstadoLast.HasValue
        //                                        && lstExpedientesParalizado.All(y => y != x.IdTipoEstadoLast)
        //                                        && lstExpedientesFinalizado.All(y => y != x.IdTipoEstadoLast)
        //                                        && x.ExpedienteEstadoes.All(e => e.FechaAlta < FechaActualMenos90)
        //                                        && x.ExpedienteNotaSet.All(e => e.Fecha < FechaActualMenos90)
        //                                        && x.ImpulsoSet.All(e => e.Fecha < FechaActualMenos90)
        //                                        && x.ActuacionSet.All(e => e.Fecha < FechaActualMenos90)
        //            );

        //        case TipoIndicadorQa.AlquilerPendienteOficiosEdictos:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                                        && x.IdEstadoLast.HasValue
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
        //                                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado != null
        //                                        && !x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.Oposicion
        //                                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.AdmitidaFecha.HasValue
        //                                        && x.ExpedienteDeudors.Any(d => d.NotificacionEstado == PositivoNegativoType.Negativo)
        //            );

        //        case TipoIndicadorQa.AlquilerEnRevision:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && x.ExpedienteEstadoLast != null
        //                && (x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoRecepcionExpediente || x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqRecepcionExpediente)
        //                && (!x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue || x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0101RecepcionRevision)
        //            );

        //        case TipoIndicadorQa.AlquilerPendientePreparacion:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                                        && x.ExpedienteEstadoLast != null
        //                                        && (x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoRecepcionExpediente || x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqRecepcionExpediente)
        //                                        && x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0103PreparacionDemanda
        //            //&& x.Alq_Expediente != null
        //            //&& x.Alq_Expediente.IdTipoEstadoCliente == 3 //1.3	PREPARACION DEMANDA
        //            );

        //        case TipoIndicadorQa.AlquilerPendientePresentacionDemanda:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && x.IdTipoEstadoLast < IdTipoEstadoAlqPresentDemanda
        //                || (
        //                        x.IdTipoEstadoLast == IdTipoEstadoAlqPresentDemanda
        //                        && x.ExpedienteEstadoes.Any(ee =>
        //                            ee.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
        //                            && !ee.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue))
        //            );

        //        case TipoIndicadorQa.AlquilerPendienteDemandaAdmitida:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                                        && x.ExpedienteEstadoLast != null
        //                                        && (
        //                                            (
        //                                                x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
        //                                                && !x.ExpedienteEstadoLast.Alq_Expediente_EstadoPresentacionDemanda.NoAdmitidaFecha.HasValue
        //                                                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                                            )
        //                                            || (
        //                                                x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
        //                                                && !x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.AdmitidaFecha.HasValue
        //                                            )
        //                                    ));

        //        case TipoIndicadorQa.AlquilerRecursosApelacion:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
        //                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado != null
        //                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.ApelacionFecha.HasValue
        //                && !x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.ApelacionResultado.HasValue
        //            );

        //        case TipoIndicadorQa.AlquilerPendienteEjecucionDineraria:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && x.Ejc_Expediente.IdExpedienteAlq.HasValue
        //                && x.IdTipoEstadoLast != IdTipoEstadoEjcFinalizacion
        //            );

        //        case TipoIndicadorQa.AlquilerIncidenciaDocumental:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqRecepcionExpediente
        //                && x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                && (
        //                    x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0102IncidenciaDocumental
        //                    || x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0104
        //                )
        //            );

        //        case TipoIndicadorQa.AlquilerFacturasPendientes:
        //            break;


        //        case TipoIndicadorQa.AlquilerPendienteEjecucionLanzamiento:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && x.IdTipoEstadoLast == IdTipoEstadoAlqLanzamiento);
        //        case TipoIndicadorQa.AlquilerPendienteTransferirCantidadConsiganada:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && x.IdTipoEstadoLast == IdTipoEstadoAlqEnervacion);
        //        case TipoIndicadorQa.AlquilerPendienteSolicitarDecretoFin:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
        //                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado != null
        //                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.AdmitidaFecha.HasValue
        //                && !x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.Oposicion
        //                && x.ExpedienteDeudors.All(d => d.NotificacionFecha.HasValue)
        //            );
        //        //&& x.ExpedienteEstadoes.Any(ee =>
        //        //    ee.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
        //        //    && !ee.FechaFin.HasValue
        //        //    && ee.Alq_Expediente_EstadoTramitaJuzgado.AdmitidaFecha.HasValue
        //        //    //&& ee.Alq_Expediente_EstadoTramitaJuzgado.FechaNotificacionDemandado.HasValue
        //        //    && !ee.Alq_Expediente_EstadoTramitaJuzgado.Oposicion
        //        //)
        //        case TipoIndicadorQa.AlquilerPendienteMediacion:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && x.IdTipoEstadoLast != IdTipoEstadoAlqFinalizado
        //                && x.Alq_Expediente.IdTipoEstadoCliente == 7 //2.4	MEDIACION
        //            );
        //        case TipoIndicadorQa.AlquilerPendienteExpedienteEjecucion:
        //            var lstEstadoClienteExcluir = new List<int> { 31, 32, 33, 38 };
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                                        && x.IdEstadoLast.HasValue
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqFinalizado
        //                                        && !x.Alq_Expediente.IdExpedienteEjc.HasValue
        //                                        && lstClientesBase1.Any(c => c == x.Gnr_ClienteOficina.IdCliente)
        //                                        && (
        //                                            !x.Alq_Expediente.IdTipoEstadoCliente.HasValue ||
        //                                            !lstEstadoClienteExcluir.Any(y => y == x.Alq_Expediente.IdTipoEstadoCliente)
        //                                        )
        //            );
        //        case TipoIndicadorQa.AlquilerPendienteDemandaEjecucion:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                && x.Ejc_Expediente.IdExpedienteAlq.HasValue
        //                && x.IdTipoEstadoLast == IdTipoEstadoEjcPresentacionDemanda
        //                && x.ExpedienteEstadoes.Any(ee =>
        //                    ee.IdTipoEstado == IdTipoEstadoEjcPresentacionDemanda
        //                    && !ee.FechaFin.HasValue
        //                    && !ee.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                ));

        //        case TipoIndicadorQa.AlquilerPendienteInstrucciones:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && x.ExpedienteEstadoLast != null
        //                && (x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0104
        //                    || (x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
        //                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.SuspensionInstruccionesCliente
        //                    )
        //                ));

        //        case TipoIndicadorQa.AlquilerPendienteRevisionEjecutivo:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                && x.ExpedienteEstadoLast != null
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcRecepcion
        //                && x.Ejc_Expediente != null
        //                && x.Ejc_Expediente.IdExpedienteAlq.HasValue
        //            );

        //        case TipoIndicadorQa.AlquilerDerivadoConcursal:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && x.Alq_Expediente != null
        //                && x.Alq_Expediente.DerivadoDepartamentoConcursal
        //            );

        //        case TipoIndicadorQa.AlquilerDecretoFinSinEjecutivo:
        //            var lstEstadoClienteTmp1 = new List<int> { 62, 71, 72 };
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                        && lstEstadoClienteTmp1.Any(c => c == x.Gnr_ClienteOficina.IdCliente)
        //                        && x.IdEstadoLast.HasValue
        //                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
        //                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado != null
        //                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.OposicionFechaDecretoFin.HasValue
        //                        && !x.Alq_Expediente.IdExpedienteEjc.HasValue
        //            );

        //        #endregion

        //        #region Alquiler Alarmas 

        //        case TipoIndicadorQa.AlquilerAlarmaPdteFechaResolucionIncidencia:
        //            var lstClientesRes = new List<int> { 62, 71, 72 };

        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqRecepcionExpediente
        //                && (
        //                    x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0102IncidenciaDocumental
        //                    || x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0105
        //                )
        //                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoRecepcion != null
        //                && !x.ExpedienteEstadoLast.Alq_Expediente_EstadoRecepcion.FechaResolucionIncidenciaDocumental.HasValue
        //                && lstClientesRes.Contains(x.Gnr_ClienteOficina.IdCliente)
        //            );

        //        case TipoIndicadorQa.AlquilerAlarmaRecepcionDemandaSellada:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
        //                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoPresentacionDemanda != null
        //                && !x.ExpedienteEstadoLast.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoPresentacionDemanda.FechaEnvioProcurador.HasValue
        //                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoPresentacionDemanda.FechaEnvioProcurador < FechaActualMenos3
        //            );


        //        case TipoIndicadorQa.AlquilerAlarmaRecepcionDemandaSelladaOrd:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario && x.IdTipoArea == IdTipoAreaDesahucios
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdPresentacionDemanda
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda != null
        //                && !x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda.FechaPresentacion.HasValue
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda.FechaEnvioProcurador.HasValue
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda.FechaEnvioProcurador < FechaActualMenos3
        //            );
        //        case TipoIndicadorQa.AlquilerAlarmaRecepcionDemandaSelladaEjc:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcPresentacionDemanda
        //                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda != null
        //                && !x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda.FechaEnvioProcurador.HasValue
        //                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda.FechaEnvioProcurador < FechaActualMenos3
        //            );
        //        case TipoIndicadorQa.AlquilerAlarmaRecepcionDemandaSelladaMn:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMonitorio && x.IdTipoArea == IdTipoAreaDesahucios
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoMnPresentDemanda
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioPresentacionDemanda != null
        //                && !x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioPresentacionDemanda.FechaPresentacion.HasValue
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioPresentacionDemanda.FechaEnvioProcurador.HasValue
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioPresentacionDemanda.FechaEnvioProcurador < FechaActualMenos3
        //            );

        //        case TipoIndicadorQa.AlquilerAlarmaRecepcionDenuncia:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqPresentDenuncia
        //                && x.ExpedienteEstadoLast.AlqExpedienteEstadoPresentacionDenuncia != null
        //                && !x.ExpedienteEstadoLast.AlqExpedienteEstadoPresentacionDenuncia.FechaPresentacion.HasValue
        //                && x.ExpedienteEstadoLast.AlqExpedienteEstadoPresentacionDenuncia.FechaEnvioProcurador.HasValue
        //                && x.ExpedienteEstadoLast.AlqExpedienteEstadoPresentacionDenuncia.FechaEnvioProcurador < FechaActualMenos3
        //            );


        //        case TipoIndicadorQa.AlquilerAlarmaPendienteAjg:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                                        && x.IdEstadoLast.HasValue
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
        //                                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado != null
        //                                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.SuspensionAjg
        //                                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.SuspensionFecha.HasValue
        //                                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.SuspensionFecha < FechaActualMenos45
        //            );

        //        case TipoIndicadorQa.AlquilerAlarmaPendienteAcuerdo:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                                        && x.IdEstadoLast.HasValue
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
        //                                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado != null
        //                                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.SuspensionPendienteAcuerdo
        //                                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.SuspensionFecha.HasValue
        //                                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.SuspensionFecha < FechaActualMenos15
        //            );

        //        case TipoIndicadorQa.AlquilerAlarmaPendienteInstruccionesCliente:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                                        && x.IdEstadoLast.HasValue
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
        //                                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado != null
        //                                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.SuspensionInstruccionesCliente
        //                                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.SuspensionFecha.HasValue
        //                                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.SuspensionFecha < FechaActualMenos10
        //            );

        //        case TipoIndicadorQa.AlquilerAlarmaPresentacionDemanda:
        //            var lstCliente05Dias = new List<int> { 27, 42, 44, 54, 55, 56, 60 };
        //            var lstCliente25Dias = new List<int> { 71, 72 };
        //            //var lstOficinasVarias = LstOficinasSolvia
        //            //    .Union(LstOficinasSareb)
        //            //    .Union(LstOficinasSantander)
        //            //    .Union(LstOficinasLlogatalia)
        //            //    .ToList();
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                                        && x.IdEstadoLast.HasValue
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqRecepcionExpediente
        //                                        && (x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0101RecepcionRevision || x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0103PreparacionDemanda)
        //                                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoRecepcion != null
        //                                        && (
        //                                            (
        //                                                lstCliente05Dias.Contains(x.Gnr_ClienteOficina.IdCliente) && (
        //                                                    x.ExpedienteEstadoLast.Fecha < FechaActualMenos5
        //                                                    || (
        //                                                        x.ExpedienteEstadoLast.Alq_Expediente_EstadoRecepcion.FechaResolucionIncidenciaDocumental.HasValue
        //                                                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoRecepcion.FechaResolucionIncidenciaDocumental < FechaActualMenos5
        //                                                    )
        //                                                )
        //                                            ) || (
        //                                                lstCliente25Dias.Contains(x.Gnr_ClienteOficina.IdCliente) && (
        //                                                    x.ExpedienteEstadoLast.Fecha < FechaActualMenos25
        //                                                    || (
        //                                                        x.ExpedienteEstadoLast.Alq_Expediente_EstadoRecepcion.FechaResolucionIncidenciaDocumental.HasValue
        //                                                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoRecepcion.FechaResolucionIncidenciaDocumental < FechaActualMenos25
        //                                                    )
        //                                            ))
        //                                        )
        //                                    );

        //        case TipoIndicadorQa.AlquilerAlarmaDemandaAdmitida:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && x.IdTipoEstadoLast == IdTipoEstadoAlqPresentDemanda
        //                && x.ExpedienteEstadoes.Any(ee => ee.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
        //                    && !ee.FechaFin.HasValue
        //                    && !ee.Alq_Expediente_EstadoPresentacionDemanda.NoAdmitidaFecha.HasValue
        //                    && ee.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                    && ee.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.Value < FechaActualMenos30)
        //            );

        //        case TipoIndicadorQa.AlquilerAlarmaPendienteNotificacion:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
        //                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado != null
        //                && !x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.Oposicion
        //                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.AdmitidaFecha.HasValue
        //                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.AdmitidaFecha < FechaActualMenos30
        //                && x.ExpedienteDeudors.Any(d => !d.NotificacionFecha.HasValue)
        //            );

        //        case TipoIndicadorQa.AlquilerAlarmaPendienteDecretoFin:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
        //                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado != null
        //                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.AdmitidaFecha.HasValue
        //                && !x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.Oposicion
        //                && x.ExpedienteDeudors.All(d =>
        //                    (d.NotificacionEstado == PositivoNegativoType.Positivo || d.NotificacionEdictos)
        //                    && d.NotificacionFecha.HasValue
        //                    && d.NotificacionFecha < FechaActualMenos15)
        //            );

        //        //&& x.ExpedienteEstadoes.Any(ee => ee.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
        //        //    && !ee.FechaFin.HasValue
        //        //    && !ee.Alq_Expediente_EstadoTramitaJuzgado.Oposicion
        //        //    && ee.Alq_Expediente_EstadoTramitaJuzgado.AdmitidaFecha.HasValue
        //        //&& ee.Alq_Expediente_EstadoTramitaJuzgado.FechaNotificacionDemandado.HasValue
        //        //&& ee.Alq_Expediente_EstadoTramitaJuzgado.FechaNotificacionDemandado.Value < FechaActualMenos15
        //        //)

        //        case TipoIndicadorQa.AlquilerAlarmaPendienteTomaPosesion:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && x.IdTipoEstadoLast != IdTipoEstadoAlqFinalizado
        //                && x.IdTipoEstadoLast != IdTipoEstadoAlqEnervacion
        //                && x.ExpedienteEstadoes.Any(ee => ee.Fecha < FechaActualMenos180)
        //            );

        //        case TipoIndicadorQa.AlquilerAlarmaPendienteEnervacion:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && x.IdTipoEstadoLast == IdTipoEstadoAlqEnervacion
        //                && x.ExpedienteEstadoes.Any(ee => ee.IdTipoEstado == IdTipoEstadoAlqEnervacion
        //                    && !ee.FechaFin.HasValue
        //                    && ee.Fecha < FechaActualMenos20)
        //            );

        //        case TipoIndicadorQa.AlquilerAlarmaImpulsoPendienteAplicativoCliente:
        //            //var lstOficinaVarios = LstOficinasSolvia
        //            //    .Union(LstOficinasAnticipa)
        //            //    .ToList();
        //            var lstCliente = new List<int> { 14, 15, 36, 42, 57, 62, 71, 72 };
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                                        //&& lstOficinaVarios.Contains(x.IdClienteOficina)
        //                                        && lstCliente.Contains(x.Gnr_ClienteOficina.IdCliente)
        //                                        && x.ImpulsoSet.Any(i => !i.AplicativoCliente)
        //            );

        //        case TipoIndicadorQa.AlquilerAlarmaEjecutarDecretoFinSentencia:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado
        //                && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado != null
        //                //&& x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.AdmitidaFecha.HasValue
        //                && !x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.OposicionSentenciaResultado.HasValue
        //                && (
        //                    (
        //                        x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.OposicionFechaDecretoFin.HasValue
        //                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.OposicionFechaDecretoFin < FechaActualMenos5
        //                    ) ||
        //                    (
        //                        x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.OposicionFechaSentencia.HasValue
        //                        && x.ExpedienteEstadoLast.Alq_Expediente_EstadoTramitaJuzgado.OposicionFechaSentencia < FechaActualMenos5
        //                    )
        //                )
        //            );

        //        #endregion

        //        #region Facturas 

        //        case TipoIndicadorQa.AlquilerFacturaAltamiraHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && lstAltamiraAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
        //                && !x.FacturacionCompleta && !x.EsNofacturable
        //                && !x.FacturaSet.Any()
        //                && x.Fin.HasValue
        //            );

        //        case TipoIndicadorQa.AlquilerFacturaEjcAltamiraHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios
        //                && lstAltamiraAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
        //                && !x.FacturacionCompleta && !x.EsNofacturable
        //                && !x.FacturaSet.Any()
        //                && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoEjcPresentDemanda
        //                    && e.Ejc_ExpedienteEstadoPresentacionDemanda != null
        //                    && e.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                )
        //            );

        //        case TipoIndicadorQa.AlquilerFacturasHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && lstClientesAlqFactPersonalizados.All(c => c != x.Gnr_ClienteOficina.IdCliente)
        //                && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
        //                    && e.Alq_Expediente_EstadoPresentacionDemanda != null
        //                    && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                )
        //                && !x.FacturaSet.Any(f => f.HitoFacturacion == HitoFacturacionValue.AlquilerPresentacionDemanda)
        //            );
        //        case TipoIndicadorQa.AlquilerFacturasHito2:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && lstClientesAlqFactPersonalizados.All(c => c != x.Gnr_ClienteOficina.IdCliente)
        //                && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqFinalizado)
        //                && !x.FacturaSet.Any(f => f.HitoFacturacion == HitoFacturacionValue.AlquilerFinalizado)
        //            );

        //        #region Llogatalia

        //        case TipoIndicadorQa.AlquilerFacturaLlogataliaHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //               && x.Gnr_ClienteOficina.IdCliente == IdClienteLlogatalia
        //               && !x.FacturaSet.Any()
        //               && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
        //                   && e.Alq_Expediente_EstadoPresentacionDemanda != null
        //                   && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue
        //               )
        //           );
        //        case TipoIndicadorQa.AlquilerFacturaLlogataliaHito2:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //               && x.Gnr_ClienteOficina.IdCliente == IdClienteLlogatalia
        //               && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
        //               && (
        //                    x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
        //                    ||
        //                    (
        //                        x.ExpedienteEstadoLast != null &&
        //                        x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqFinalizado &&
        //                        x.ExpedienteEstadoLast.Alq_Expediente_EstadoFinalizacion != null &&
        //                        x.ExpedienteEstadoLast.Alq_Expediente_EstadoFinalizacion.EntregaPosesion
        //                    )
        //                )
        //           );
        //        case TipoIndicadorQa.AlquilerFacturaEjcLlogataliaHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios
        //                && x.Gnr_ClienteOficina.IdCliente == IdClienteLlogatalia
        //                && !x.FacturaSet.Any()
        //                && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoEjcPresentDemanda
        //                    && e.Ejc_ExpedienteEstadoPresentacionDemanda != null
        //                    && e.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                )
        //           );
        //        case TipoIndicadorQa.AlquilerFacturaPdteLlogatalia:
        //            return queryBase.Where(x =>
        //                (x.IdTipoExpediente == IdTipoExpedienteAlquiler || (x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios))
        //                && x.Gnr_ClienteOficina.IdCliente == IdClienteLlogatalia
        //                && !x.FacturaSet.Any()
        //                && x.Fin.HasValue
        //            );

        //        #endregion

        //        #region MerlinRetail

        //        case TipoIndicadorQa.AlquilerFacturaMerlinRetailHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //               && x.Gnr_ClienteOficina.IdCliente == IdClienteMerlinRetail
        //               && !x.FacturaSet.Any()
        //               && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
        //                   && e.Alq_Expediente_EstadoPresentacionDemanda != null
        //                   && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue
        //               )
        //           );
        //        case TipoIndicadorQa.AlquilerFacturaMerlinRetailHito2:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //               && x.Gnr_ClienteOficina.IdCliente == IdClienteMerlinRetail
        //               && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
        //               && (
        //                    x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
        //                    ||
        //                    (
        //                        x.ExpedienteEstadoLast != null &&
        //                        x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqFinalizado &&
        //                        x.ExpedienteEstadoLast.Alq_Expediente_EstadoFinalizacion != null &&
        //                        x.ExpedienteEstadoLast.Alq_Expediente_EstadoFinalizacion.EntregaPosesion
        //                    )
        //                )
        //           );
        //        case TipoIndicadorQa.AlquilerFacturaEjcMerlinRetailHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios
        //                && x.Gnr_ClienteOficina.IdCliente == IdClienteMerlinRetail
        //                && !x.FacturaSet.Any()
        //                && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoEjcPresentDemanda
        //                    && e.Ejc_ExpedienteEstadoPresentacionDemanda != null
        //                    && e.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                )
        //           );
        //        case TipoIndicadorQa.AlquilerFacturaPdteMerlinRetail:
        //            return queryBase.Where(x =>
        //                (x.IdTipoExpediente == IdTipoExpedienteAlquiler || (x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios))
        //                && x.Gnr_ClienteOficina.IdCliente == IdClienteMerlinRetail
        //                && !x.FacturaSet.Any()
        //                && x.Fin.HasValue
        //            );

        //        #endregion

        //        #region SolviaHoteles

        //        case TipoIndicadorQa.AlquilerFacturaSolviaHotelesHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //               && x.Gnr_ClienteOficina.IdCliente == IdClienteSolviaHoteles
        //               && !x.FacturaSet.Any()
        //               && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
        //                   && e.Alq_Expediente_EstadoPresentacionDemanda != null
        //                   && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue
        //               )
        //           );
        //        case TipoIndicadorQa.AlquilerFacturaSolviaHotelesHito2:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //               && x.Gnr_ClienteOficina.IdCliente == IdClienteSolviaHoteles
        //               && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
        //               && (
        //                    x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
        //                    ||
        //                    (
        //                        x.ExpedienteEstadoLast != null &&
        //                        x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqFinalizado &&
        //                        x.ExpedienteEstadoLast.Alq_Expediente_EstadoFinalizacion != null &&
        //                        x.ExpedienteEstadoLast.Alq_Expediente_EstadoFinalizacion.EntregaPosesion
        //                    )
        //                )
        //           );
        //        case TipoIndicadorQa.AlquilerFacturaEjcSolviaHotelesHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios
        //                && x.Gnr_ClienteOficina.IdCliente == IdClienteSolviaHoteles
        //                && !x.FacturaSet.Any()
        //                && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoEjcPresentDemanda
        //                    && e.Ejc_ExpedienteEstadoPresentacionDemanda != null
        //                    && e.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                )
        //           );
        //        case TipoIndicadorQa.AlquilerFacturaPdteSolviaHoteles:
        //            return queryBase.Where(x =>
        //                (x.IdTipoExpediente == IdTipoExpedienteAlquiler || (x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios))
        //                && x.Gnr_ClienteOficina.IdCliente == IdClienteSolviaHoteles
        //                && !x.FacturaSet.Any()
        //                && x.Fin.HasValue
        //            );

        //        #endregion

        //        #region Azzam

        //        case TipoIndicadorQa.AlquilerFacturaAzzamHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //               && x.Gnr_ClienteOficina.IdCliente == IdClienteAzzam
        //               && !x.FacturaSet.Any()
        //               && (
        //                    (x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
        //                       && e.Alq_Expediente_EstadoPresentacionDemanda != null
        //                       && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)
        //                    )
        //                    ||
        //                    (x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDenuncia
        //                       && e.AlqExpedienteEstadoPresentacionDenuncia != null
        //                       && e.AlqExpedienteEstadoPresentacionDenuncia.FechaPresentacion.HasValue)
        //                    )
        //               )
        //           );
        //        case TipoIndicadorQa.AlquilerFacturaAzzamHito2:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //               && x.Gnr_ClienteOficina.IdCliente == IdClienteAzzam
        //               && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
        //               && (
        //                    x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
        //                    ||
        //                    (
        //                        x.ExpedienteEstadoLast != null &&
        //                        x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqFinalizado
        //                    )
        //                )
        //           );
        //        case TipoIndicadorQa.AlquilerFacturaEjcAzzamHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios
        //                && x.Gnr_ClienteOficina.IdCliente == IdClienteAzzam
        //                && !x.FacturaSet.Any()
        //                && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoEjcPresentDemanda
        //                    && e.Ejc_ExpedienteEstadoPresentacionDemanda != null
        //                    && e.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                )
        //           );

        //        #endregion

        //        #region Homes

        //        case TipoIndicadorQa.AlquilerFacturaHomesHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //               && x.Gnr_ClienteOficina.IdCliente == IdClienteHomes
        //               && !x.FacturaSet.Any()
        //               && (
        //                    (x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
        //                       && e.Alq_Expediente_EstadoPresentacionDemanda != null
        //                       && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)
        //                    )
        //                    ||
        //                    (x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDenuncia
        //                       && e.AlqExpedienteEstadoPresentacionDenuncia != null
        //                       && e.AlqExpedienteEstadoPresentacionDenuncia.FechaPresentacion.HasValue)
        //                    )
        //               )
        //           );
        //        case TipoIndicadorQa.AlquilerFacturaHomesHito2:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //               && x.Gnr_ClienteOficina.IdCliente == IdClienteHomes
        //               && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
        //               && (
        //                    x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
        //                    ||
        //                    (
        //                        x.ExpedienteEstadoLast != null &&
        //                        x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqFinalizado
        //                    )
        //                )
        //           );
        //        case TipoIndicadorQa.AlquilerFacturaEjcHomesHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios
        //                && x.Gnr_ClienteOficina.IdCliente == IdClienteHomes
        //                && !x.FacturaSet.Any()
        //                && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoEjcPresentDemanda
        //                    && e.Ejc_ExpedienteEstadoPresentacionDemanda != null
        //                    && e.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                )
        //           );

        //        #endregion

        //        #region Anticipa

        //        case TipoIndicadorQa.AlquilerFacturaAnticipaHito1:
        //            return queryBase.Where(
        //                x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && !x.FacturacionCompleta && !x.EsNofacturable
        //                && lstAnticipaAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
        //                && !x.FacturaSet.Any()
        //                && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)
        //           );

        //        case TipoIndicadorQa.AlquilerFacturaAnticipaHito2:
        //            return queryBase.Where(
        //                x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //                && !x.FacturacionCompleta && !x.EsNofacturable
        //                && lstAnticipaAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
        //                && x.FacturaSet.Any(f => f.HitoFacturacion == HitoFacturacionValue.AlquilerHito1)
        //                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
        //                && x.Fin.HasValue
        //           );

        //        case TipoIndicadorQa.AlquilerFacturaEjcAnticipaHito1:
        //            return queryBase.Where(x =>
        //                x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                && x.IdTipoArea == IdTipoAreaDesahucios
        //                && lstAnticipaAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
        //                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito1)
        //                && !x.FacturacionCompleta && !x.EsNofacturable
        //                && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoEjcPresentDemanda
        //                    && e.Ejc_ExpedienteEstadoPresentacionDemanda != null
        //                    && e.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                )
        //           );




        //        //case TipoIndicadorQa.AlquilerFacturaAnticipaHito1_Finalizado:
        //        //    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //        //        && !x.FacturacionCompleta
        //        //        && lstAnticipaAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
        //        //        && !x.FacturaSet.Any()
        //        //        && x.Fin.HasValue
        //        //   );

        //        //case TipoIndicadorQa.AlquilerFacturaAnticipaHito3:
        //        //    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //        //        && !x.FacturacionCompleta
        //        //        && lstAnticipaAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
        //        //        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito3)
        //        //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqEnervacion)
        //        //   );

        //        //case TipoIndicadorQa.AlquilerFacturaAnticipaHito2_ConVista_0_120:
        //        //    var queryLocal = queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //        //        && !x.FacturacionCompleta
        //        //        && lstAnticipaAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
        //        //        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
        //        //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)
        //        //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento || e.IdTipoEstado == IdTipoEstadoAlqFinalizado)
        //        //        && (
        //        //            x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
        //        //            || 
        //        //            x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento && e.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)                            
        //        //        )                        
        //        //        && x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqTramiteCelebracionVista && !v.Suspendida)
        //        //    );
        //        //    #region Preparar para remover los de mas de 120 dias

        //        //    var lstExpRemove = new List<int>();
        //        //    var resultLocal = queryLocal.ToList();
        //        //    foreach (var exp in resultLocal)
        //        //    {
        //        //        var fechaDemanda = exp.ExpedienteEstadoes.FirstOrDefault(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)?
        //        //            .Alq_Expediente_EstadoPresentacionDemanda?
        //        //            .FechaPresentacion;
        //        //        if (!fechaDemanda.HasValue) lstExpRemove.Add(exp.IdExpediente);
        //        //        else
        //        //        {
        //        //            var fecha2 = exp.ExpedienteEstadoes.FirstOrDefault(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento && e.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)?
        //        //                .Alq_Expediente_EstadoLanzamiento?
        //        //                .PosesionFechaRecepcion;
        //        //            if (!fecha2.HasValue)
        //        //                fecha2 = exp.ExpedienteVistas.FirstOrDefault(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)?.Fecha;

        //        //            if (!fecha2.HasValue || fechaDemanda.Value.GetDaysBetweenDates(fecha2.Value) > 120)
        //        //                lstExpRemove.Add(exp.IdExpediente);
        //        //        }
        //        //    }

        //        //    #endregion
        //        //    return resultLocal
        //        //        .Where(x => !lstExpRemove.Contains(x.IdExpediente))
        //        //        .AsQueryable();

        //        //case TipoIndicadorQa.AlquilerFacturaAnticipaHito2_SinVista_0_120:
        //        //    var queryAnticipaSinVista120 = queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //        //        && !x.FacturacionCompleta
        //        //        && lstAnticipaAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
        //        //        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
        //        //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)
        //        //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento || e.IdTipoEstado == IdTipoEstadoAlqFinalizado)
        //        //        && (
        //        //            x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
        //        //            ||
        //        //            x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento && e.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)
        //        //        )
        //        //        && !x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqTramiteCelebracionVista && !v.Suspendida)
        //        //    );
        //        //    #region Preparar para remover los de mas de 120 dias

        //        //    lstExpRemove = new List<int>();
        //        //    foreach (var exp in queryAnticipaSinVista120)
        //        //    {
        //        //        var fechaDemanda = exp.ExpedienteEstadoes.FirstOrDefault(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)?
        //        //            .Alq_Expediente_EstadoPresentacionDemanda?
        //        //            .FechaPresentacion;
        //        //        if (!fechaDemanda.HasValue) lstExpRemove.Add(exp.IdExpediente);
        //        //        else
        //        //        {
        //        //            var fecha2 = exp.ExpedienteEstadoes.FirstOrDefault(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento && e.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)?
        //        //                .Alq_Expediente_EstadoLanzamiento?
        //        //                .PosesionFechaRecepcion;
        //        //            if (!fecha2.HasValue)
        //        //                fecha2 = exp.ExpedienteVistas.FirstOrDefault(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)?.Fecha;

        //        //            if (!fecha2.HasValue || fechaDemanda.Value.GetDaysBetweenDates(fecha2.Value) > 120)
        //        //                lstExpRemove.Add(exp.IdExpediente);
        //        //        }
        //        //    }

        //        //    #endregion
        //        //    return queryAnticipaSinVista120
        //        //        .Where(x => !lstExpRemove.Contains(x.IdExpediente))
        //        //        .AsQueryable();

        //        //case TipoIndicadorQa.AlquilerFacturaAnticipaHito2_ConVista_121_180:
        //        //    var queryAnticipa180Con = queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //        //        && !x.FacturacionCompleta
        //        //        && lstAnticipaAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
        //        //        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
        //        //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)
        //        //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento || e.IdTipoEstado == IdTipoEstadoAlqFinalizado)
        //        //        && (
        //        //            x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
        //        //            ||
        //        //            x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento && e.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)
        //        //        )
        //        //        && x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqTramiteCelebracionVista && !v.Suspendida)
        //        //    );
        //        //    #region Preparar para remover los que estan fuera del periodo 121-180
        //        //    lstExpRemove = new List<int>();
        //        //    foreach (var exp in queryAnticipa180Con)
        //        //    {
        //        //        var fechaDemanda = exp.ExpedienteEstadoes.FirstOrDefault(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)?
        //        //            .Alq_Expediente_EstadoPresentacionDemanda?
        //        //            .FechaPresentacion;
        //        //        if (!fechaDemanda.HasValue) lstExpRemove.Add(exp.IdExpediente);
        //        //        else
        //        //        {
        //        //            var fecha2 = exp.ExpedienteEstadoes.FirstOrDefault(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento && e.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)?
        //        //                .Alq_Expediente_EstadoLanzamiento?
        //        //                .PosesionFechaRecepcion;
        //        //            if (!fecha2.HasValue)
        //        //                fecha2 = exp.ExpedienteVistas.FirstOrDefault(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)?.Fecha;

        //        //            if (!fecha2.HasValue || fechaDemanda.Value.GetDaysBetweenDates(fecha2.Value) < 121 || fechaDemanda.Value.GetDaysBetweenDates(fecha2.Value) > 180)
        //        //                lstExpRemove.Add(exp.IdExpediente);
        //        //        }
        //        //    }
        //        //    #endregion
        //        //    return queryAnticipa180Con
        //        //        .Where(x => !lstExpRemove.Contains(x.IdExpediente))
        //        //        .AsQueryable();

        //        //case TipoIndicadorQa.AlquilerFacturaAnticipaHito2_SinVista_121_180:
        //        //    var queryAnticipa180Sin = queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //        //        && !x.FacturacionCompleta
        //        //        && lstAnticipaAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
        //        //        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
        //        //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)
        //        //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento || e.IdTipoEstado == IdTipoEstadoAlqFinalizado)
        //        //        && (
        //        //            x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
        //        //            ||
        //        //            x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento && e.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)
        //        //        )
        //        //        && !x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqTramiteCelebracionVista && !v.Suspendida)
        //        //    );
        //        //    #region Preparar para remover los que estan fuera del periodo 121-180
        //        //    lstExpRemove = new List<int>();
        //        //    foreach (var exp in queryAnticipa180Sin)
        //        //    {
        //        //        var fechaDemanda = exp.ExpedienteEstadoes.FirstOrDefault(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)?
        //        //            .Alq_Expediente_EstadoPresentacionDemanda?
        //        //            .FechaPresentacion;
        //        //        if (!fechaDemanda.HasValue) lstExpRemove.Add(exp.IdExpediente);
        //        //        else
        //        //        {
        //        //            var fecha2 = exp.ExpedienteEstadoes.FirstOrDefault(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento && e.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)?
        //        //                .Alq_Expediente_EstadoLanzamiento?
        //        //                .PosesionFechaRecepcion;
        //        //            if (!fecha2.HasValue)
        //        //                fecha2 = exp.ExpedienteVistas.FirstOrDefault(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)?.Fecha;

        //        //            if (!fecha2.HasValue || fechaDemanda.Value.GetDaysBetweenDates(fecha2.Value) < 121 || fechaDemanda.Value.GetDaysBetweenDates(fecha2.Value) > 180)
        //        //                lstExpRemove.Add(exp.IdExpediente);
        //        //        }
        //        //    }
        //        //    #endregion
        //        //    return queryAnticipa180Sin
        //        //        .Where(x => !lstExpRemove.Contains(x.IdExpediente))
        //        //        .AsQueryable();

        //        //case TipoIndicadorQa.AlquilerFacturaAnticipaHito2_ConVista_181:
        //        //    var queryAnticipa181Con = queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //        //        && !x.FacturacionCompleta
        //        //        && lstAnticipaAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
        //        //        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
        //        //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)
        //        //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento || e.IdTipoEstado == IdTipoEstadoAlqFinalizado)
        //        //        && (
        //        //            x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
        //        //            ||
        //        //            x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento && e.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)
        //        //        )
        //        //        && x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqTramiteCelebracionVista && !v.Suspendida)
        //        //    );
        //        //    #region Preparar para remover los de menos de 181 días
        //        //    lstExpRemove = new List<int>();
        //        //    foreach (var exp in queryAnticipa181Con)
        //        //    {
        //        //        var fechaDemanda = exp.ExpedienteEstadoes.FirstOrDefault(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)?
        //        //            .Alq_Expediente_EstadoPresentacionDemanda?
        //        //            .FechaPresentacion;
        //        //        if (!fechaDemanda.HasValue) lstExpRemove.Add(exp.IdExpediente);
        //        //        else
        //        //        {
        //        //            var fecha2 = exp.ExpedienteEstadoes.FirstOrDefault(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento && e.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)?
        //        //                .Alq_Expediente_EstadoLanzamiento?
        //        //                .PosesionFechaRecepcion;
        //        //            if (!fecha2.HasValue)
        //        //                fecha2 = exp.ExpedienteVistas.FirstOrDefault(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)?.Fecha;

        //        //            if (!fecha2.HasValue || fechaDemanda.Value.GetDaysBetweenDates(fecha2.Value) < 181)
        //        //                lstExpRemove.Add(exp.IdExpediente);
        //        //        }
        //        //    }
        //        //    #endregion
        //        //    return queryAnticipa181Con
        //        //        .Where(x => !lstExpRemove.Contains(x.IdExpediente))
        //        //        .AsQueryable();

        //        //case TipoIndicadorQa.AlquilerFacturaAnticipaHito2_SinVista_181:
        //        //    var queryAnticipa181Sin = queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //        //        && !x.FacturacionCompleta
        //        //        && lstAnticipaAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
        //        //        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
        //        //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)
        //        //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento || e.IdTipoEstado == IdTipoEstadoAlqFinalizado)
        //        //        && (
        //        //            x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
        //        //            ||
        //        //            x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento && e.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)
        //        //        )
        //        //        && !x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqTramiteCelebracionVista && !v.Suspendida)
        //        //    );
        //        //    #region Preparar para remover los de menos de 181 días
        //        //    lstExpRemove = new List<int>();
        //        //    foreach (var exp in queryAnticipa181Sin)
        //        //    {
        //        //        var fechaDemanda = exp.ExpedienteEstadoes.FirstOrDefault(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)?
        //        //            .Alq_Expediente_EstadoPresentacionDemanda?
        //        //            .FechaPresentacion;
        //        //        if (!fechaDemanda.HasValue) lstExpRemove.Add(exp.IdExpediente);
        //        //        else
        //        //        {
        //        //            var fecha2 = exp.ExpedienteEstadoes.FirstOrDefault(e => e.IdTipoEstado == IdTipoEstadoAlqLanzamiento && e.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)?
        //        //                .Alq_Expediente_EstadoLanzamiento?
        //        //                .PosesionFechaRecepcion;
        //        //            if (!fecha2.HasValue)
        //        //                fecha2 = exp.ExpedienteVistas.FirstOrDefault(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)?.Fecha;

        //        //            if (!fecha2.HasValue || fechaDemanda.Value.GetDaysBetweenDates(fecha2.Value) < 181)
        //        //                lstExpRemove.Add(exp.IdExpediente);
        //        //        }
        //        //    }
        //        //    #endregion
        //        //    return queryAnticipa181Sin
        //        //        .Where(x => !lstExpRemove.Contains(x.IdExpediente))
        //        //        .AsQueryable();



        //        //case TipoIndicadorQa.AlquilerFacturaEjcAnticipaHito2:
        //        //    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios
        //        //        && x.Gnr_ClienteOficina.IdCliente == IdClienteAzzam
        //        //        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito1)
        //        //        && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoEjcPresentDemanda
        //        //            && e.Ejc_ExpedienteEstadoPresentacionDemanda != null
        //        //            && e.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
        //        //        )
        //        //   );

        //        #endregion

        //        #region Ahora Asset Management

        //        case TipoIndicadorQa.AlquilerFacturaAhoraAssetManagementHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //               && x.Gnr_ClienteOficina.IdCliente == IdClienteAhoraAssetManagement
        //               && !x.FacturaSet.Any()
        //               && (
        //                    x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
        //                    && e.Alq_Expediente_EstadoPresentacionDemanda != null
        //                    && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                    ) ||
        //                    x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDenuncia
        //                    && e.AlqExpedienteEstadoPresentacionDenuncia != null
        //                    && e.AlqExpedienteEstadoPresentacionDenuncia.FechaPresentacion.HasValue
        //                    )
        //               )
        //           );
        //        case TipoIndicadorQa.AlquilerFacturaAhoraAssetManagementHito2:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //               && x.Gnr_ClienteOficina.IdCliente == IdClienteAhoraAssetManagement
        //               && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
        //               && x.Fin.HasValue
        //           //&& (
        //           //     x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
        //           //     ||
        //           //     (
        //           //         x.ExpedienteEstadoLast != null &&
        //           //         x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqFinalizado &&
        //           //         x.ExpedienteEstadoLast.Alq_Expediente_EstadoFinalizacion != null &&
        //           //         x.ExpedienteEstadoLast.Alq_Expediente_EstadoFinalizacion.EntregaPosesion
        //           //     )
        //           // )
        //           );

        //        #endregion

        //        case TipoIndicadorQa.AlquilerFacturaAlisedaHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //               //&& lstAlisedaAlq.Contains(x.Gnr_ClienteOficina.IdCliente)
        //               && x.Gnr_ClienteOficina.IdCliente == IdClienteAlisedaAlquileres
        //               && !x.FacturaSet.Any()
        //               && (
        //                    x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
        //                    && e.Alq_Expediente_EstadoPresentacionDemanda != null
        //                    && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                    ) ||
        //                    x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDenuncia
        //                    && e.AlqExpedienteEstadoPresentacionDenuncia != null
        //                    && e.AlqExpedienteEstadoPresentacionDenuncia.FechaPresentacion.HasValue
        //                    )
        //               )
        //           );
        //        case TipoIndicadorQa.AlquilerFacturaAlisedaHito2:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //               && x.Gnr_ClienteOficina.IdCliente == IdClienteAlisedaAlquileres
        //               && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
        //               && (
        //                    x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
        //                    ||
        //                    (
        //                        x.ExpedienteEstadoLast != null &&
        //                        x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqFinalizado &&
        //                        x.ExpedienteEstadoLast.Alq_Expediente_EstadoFinalizacion != null &&
        //                        x.ExpedienteEstadoLast.Alq_Expediente_EstadoFinalizacion.EntregaPosesion
        //                    )
        //                )
        //           );
        //        case TipoIndicadorQa.AlquilerFacturaEjcAlisedaHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios
        //                && x.Gnr_ClienteOficina.IdCliente == IdClienteAlisedaAlquileres
        //                && !x.FacturaSet.Any()
        //                && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoEjcPresentDemanda
        //                    && e.Ejc_ExpedienteEstadoPresentacionDemanda != null
        //                    && e.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                )
        //           );
        //        case TipoIndicadorQa.AlquilerFacturaPdteAliseda:
        //            return queryBase.Where(x =>
        //                (x.IdTipoExpediente == IdTipoExpedienteAlquiler || (x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios))
        //                && x.Gnr_ClienteOficina.IdCliente == IdClienteAlisedaAlquileres
        //                && !x.FacturaSet.Any()
        //                && x.Fin.HasValue
        //            );


        //        case TipoIndicadorQa.AlquilerFacturaFidereHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //               && x.Gnr_ClienteOficina.IdCliente == IdClienteFidere
        //               && !x.FacturaSet.Any()
        //               && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoAlqPresentDemanda
        //                   && e.Alq_Expediente_EstadoPresentacionDemanda != null
        //                   && e.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue
        //               )
        //           );
        //        case TipoIndicadorQa.AlquilerFacturaFidereHito2:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //               && x.Gnr_ClienteOficina.IdCliente == IdClienteFidere
        //               && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.AlquilerHito2)
        //               && (
        //                    x.ExpedienteVistas.Any(v => v.IdTipoVista == IdTipoVistaAlqLanzamiento && v.Resultado == PositivoNegativoType.Positivo)
        //                    ||
        //                    (
        //                        x.ExpedienteEstadoLast != null &&
        //                        x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqFinalizado &&
        //                        x.ExpedienteEstadoLast.Alq_Expediente_EstadoFinalizacion != null &&
        //                        x.ExpedienteEstadoLast.Alq_Expediente_EstadoFinalizacion.EntregaPosesion
        //                    )
        //                )
        //           );
        //        case TipoIndicadorQa.AlquilerFacturaEjcFidereHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios
        //                && x.Gnr_ClienteOficina.IdCliente == IdClienteFidere
        //                && !x.FacturaSet.Any()
        //                && x.ExpedienteEstadoes.Any(e => e.IdTipoEstado == IdTipoEstadoEjcPresentDemanda
        //                    && e.Ejc_ExpedienteEstadoPresentacionDemanda != null
        //                    && e.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                )
        //           );
        //        case TipoIndicadorQa.AlquilerFacturaPdteFidere:
        //            return queryBase.Where(x =>
        //                (x.IdTipoExpediente == IdTipoExpedienteAlquiler || (x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoArea == IdTipoAreaDesahucios))
        //                && x.Gnr_ClienteOficina.IdCliente == IdClienteFidere
        //                && !x.FacturaSet.Any()
        //                && x.Fin.HasValue
        //            );


        //        #endregion

        //        #endregion

        //        #region Ejecutivo

        //        #region Ejecutivo - Indicadores

        //        case TipoIndicadorQa.EjecutivoInactivo:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                                        && x.FechaModificacion < FechaActualMenos90
        //                                        && x.IdTipoEstadoLast.HasValue
        //                                        && lstExpedientesParalizado.All(y => y != x.IdTipoEstadoLast)
        //                                        && lstExpedientesFinalizado.All(y => y != x.IdTipoEstadoLast)
        //                                        && x.ExpedienteEstadoes.All(e => e.FechaAlta < FechaActualMenos90)
        //                                        && x.ExpedienteNotaSet.All(e => e.Fecha < FechaActualMenos90)
        //                                        && x.ImpulsoSet.All(e => e.Fecha < FechaActualMenos90)
        //                                        && x.ActuacionSet.All(e => e.Fecha < FechaActualMenos90)
        //            );

        //        case TipoIndicadorQa.EjecutivoIncidenciaDocumental:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                                        && x.IdEstadoLast.HasValue
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcRecepcionExpediente
        //                                        && x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                                        && (
        //                                            x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0102IncidenciaDocumental
        //                                            || x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0104
        //                                        )
        //            );

        //        case TipoIndicadorQa.EjecutivoPendientePreparacionDemanda:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                && x.IdEstadoLast.HasValue
        //                && (
        //                    (
        //                        x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcRecepcionExpediente
        //                        && x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0103PreparacionDemanda
        //                    )
        //                    //|| x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcGeneracionExpediente
        //                    ||
        //                    (
        //                        x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcPresentacionDemanda
        //                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda != null
        //                        && !x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda.FechaEnvioProcurador.HasValue
        //                    )
        //                ));

        //        case TipoIndicadorQa.EjecutivoPendienteDemandaAdmitida:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                && x.IdEstadoLast.HasValue
        //                && (
        //                    (
        //                        x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcPresentacionDemanda
        //                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda != null
        //                        && !x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda.NoAdmitidaFecha.HasValue
        //                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                    )
        //                    ||
        //                    (
        //                        x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcAdmisionTramiteEmbargo
        //                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoNotificacion != null
        //                        && !x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoNotificacion.AdmitidaFecha.HasValue
        //                    )
        //                )
        //            );

        //        case TipoIndicadorQa.EjecutivoConOposicion:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcAdmisionTramiteEmbargo
        //                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoNotificacion != null
        //                && x.ExpedienteDeudors.Any(d => d.ExpedienteDeudorEjcutivoSet.Any(de => de.Oposicion))
        //            );

        //        case TipoIndicadorQa.EjecutivoPendienteTestimonioAdjudicacion:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                                        && x.IdEstadoLast.HasValue
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcAdjudicacion
        //                                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoAdjudicacion != null
        //                                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoAdjudicacion.FechaAdjudicacion.HasValue
        //                                        && !x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoAdjudicacion.FechaTestimonio.HasValue
        //            );

        //        case TipoIndicadorQa.EjecutivoPendienteRequerimientoPago:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                                        && x.ExpedienteEstadoLast != null
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcAdmisionTramiteEmbargo
        //                                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoNotificacion != null
        //                                        && x.ExpedienteDeudors.Any(d => d.ExpedienteDeudorEjcutivoSet.Any(de => de.RequerimientoPagoResultado != PositivoNegativoType.Positivo))
        //            );

        //        case TipoIndicadorQa.EjecutivoPendienteSolicitarSubasta:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                                        && x.ExpedienteEstadoLast != null
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcSubasta
        //                                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoSubasta != null
        //                                        && !x.IdExpedienteSubastaLast.HasValue
        //            );

        //        case TipoIndicadorQa.EjecutivoPendienteSolicitudPosesion:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                                        && x.ExpedienteEstadoLast != null
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcAdjudicacion
        //                                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoAdjudicacion != null
        //                                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoAdjudicacion.FechaTestimonio.HasValue
        //                                        && !x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoAdjudicacion.FechaPosesion.HasValue
        //            );

        //        case TipoIndicadorQa.EjecutivoPendienteLanzamiento:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                                        && x.ExpedienteEstadoLast != null
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcAdjudicacion
        //                                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoAdjudicacion != null
        //                                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoAdjudicacion.FechaPosesion.HasValue
        //                                        && !x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoAdjudicacion.FechaLanzamiento.HasValue
        //            //&& x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoAdjudicacion.ResultadoPosesion != 1 //positivo
        //            //&& x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoAdjudicacion.ResultadoPosesion != 3 //Negativa - Reconocido Arrendamiento   
        //            );

        //        case TipoIndicadorQa.EjecutivoPendienteSubastasSuspendidas:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                                        && x.ExpedienteEstadoLast != null
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcSubasta
        //                                        //&& x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                                        && !LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
        //                                        && x.IdExpedienteSubastaLast.HasValue
        //                                        && x.ExpedienteSubastaLast.IdMotivoSuspension.HasValue
        //            );

        //        case TipoIndicadorQa.EjecutivoPendienteAdjudicacion:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                                        && x.ExpedienteEstadoLast != null
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcSubasta
        //                                        //&& x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                                        && !LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
        //                                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoSubasta != null
        //                                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoSubasta.FechaSolicitudAdjudicacion.HasValue
        //            );

        //        case TipoIndicadorQa.EjecutivoDecretoConvocatoriaSubasta:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                                        && x.ExpedienteEstadoLast != null
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcSubasta
        //                                        //&& x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                                        && !LstEstadoSubfaseHipTramitacion.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado.Value)
        //                                        && x.IdExpedienteSubastaLast.HasValue
        //                                        && x.ExpedienteSubastaLast.FechaDecretoSubasta.HasValue
        //                                        && !x.ExpedienteSubastaLast.FechaCelebracion.HasValue
        //                                        && !x.ExpedienteSubastaLast.IdMotivoSuspension.HasValue
        //                                        && !x.ExpedienteSubastaLast.IdMotivoSuspensionDecretoSubasta.HasValue
        //            );

        //        case TipoIndicadorQa.EjecutivoPendienteAvaluo:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                                        && x.ExpedienteEstadoLast != null
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcEfectividadEmbargo
        //                                        && x.Hip_Inmueble.Any(i => i.EjcValoracionViaApremio
        //                                            && !i.EjcImporte.HasValue
        //                                        )
        //            );

        //        #endregion

        //        #region Ejecutivo - Alarmas 

        //        case TipoIndicadorQa.EjecutivoAlarmaRecepcionDemandaSellada:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                                        && x.IdEstadoLast.HasValue
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcPresentDemanda
        //                                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda != null
        //                                        && !x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda.FechaEnvioProcurador.HasValue
        //                                        && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda.FechaEnvioProcurador < FechaActualMenos3
        //                                        );
        //        case TipoIndicadorQa.EjecutivoAlarmaAdmisionDemanda:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcPresentDemanda
        //                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda != null
        //                && !x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda.NoAdmitidaFecha.HasValue
        //                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion < FechaActualMenos90
        //                );
        //        case TipoIndicadorQa.EjecutivoAlarmaRequerimientoPago:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcAdmisionTramiteEmbargo
        //                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoNotificacion != null
        //                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoNotificacion.AdmitidaFecha.HasValue
        //                && x.ExpedienteEstadoLast.Ejc_ExpedienteEstadoNotificacion.AdmitidaFecha < FechaActualMenos90
        //                && x.ExpedienteDeudors.Any(d => d.ExpedienteDeudorEjcutivoSet.Any(de => de.RequerimientoPagoResultado != PositivoNegativoType.Positivo))
        //                );

        //        case TipoIndicadorQa.EjecutivoAlarmaAveriguacionPatrimonial:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcAdmisionTramiteEmbargo
        //                && x.ExpedienteDeudors.All(d => d.ExpedienteDeudorEjcutivoAveriguacionSet.All(de =>
        //                    de.AveriguacionPatrimonialFecha.HasValue && de.AveriguacionPatrimonialFecha < FechaActualMenos180)
        //                    )
        //                );

        //        case TipoIndicadorQa.EjecutivoAlarmaMejoraEmbargo:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcAdmisionTramiteEmbargo
        //                && x.ExpedienteDeudors.All(d => d.ExpedienteDeudorEjcutivoAveriguacionSet.All(de =>
        //                    de.AveriguacionPatrimonialFecha.HasValue && de.AveriguacionPatrimonialFecha < FechaActualMenos90)
        //                    )
        //                );

        //        case TipoIndicadorQa.EjecutivoAlarmaDecretoEmbargo:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoEjcAdmisionTramiteEmbargo
        //                && x.ExpedienteDeudors.All(d => d.ExpedienteDeudorEjcutivoAveriguacionSet.All(de =>
        //                    de.MejoraEmbargoFecha.HasValue && de.MejoraEmbargoFecha < FechaActualMenos90)
        //                    )
        //                );

        //        case TipoIndicadorQa.EjecutivoAlarmaSucesionCopiaSellada:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteEjecutivo
        //                && !x.SucesionCopiaSellada.HasValue
        //                && x.SucesionPresentada.HasValue
        //                && x.SucesionPresentada < FechaActualMenos2
        //            );

        //        //case TipoIndicadorQa.EjecutivoAlarmaProrrogaEmbargo:

        //        #endregion

        //        #endregion

        //        #region Negociacion

        //        #region Negociacion Indicadores

        //        //case TipoIndicadorQa.NegociacionPrecontenciosoFinalizada:
        //        //    return queryBaseConParalizados.Where(x =>
        //        //            x.IdExpedienteNegociacion.HasValue
        //        //            && x.ExpedienteNegociacion != null
        //        //            && x.ExpedienteNegociacion.PrecontenciosoFechaFin.HasValue
        //        //        );

        //        //case TipoIndicadorQa.NegociacionContenciosoFinalizada:
        //        //    return queryBaseConParalizados.Where(x =>
        //        //        x.IdExpedienteNegociacion.HasValue
        //        //        && x.ExpedienteNegociacion != null
        //        //        && x.ExpedienteNegociacion.ContenciosoFechaFin.HasValue
        //        //    );

        //        //case TipoIndicadorQa.NegociacionPrecontencioso:
        //        //    return queryBaseConParalizados.Where(x =>
        //        //        x.IdExpedienteNegociacion.HasValue
        //        //        && !x.ExpedienteNegociacion.PrecontenciosoFechaFin.HasValue
        //        //        && x.ExpedienteNegociacion.IdGestor.HasValue
        //        //        && x.IdClienteOficina == IdClienteOficinaAcinsaBankia
        //        //        && (
        //        //            (x.IdTipoExpediente == IdTipoExpedienteHipotecario && x.IdTipoEstadoLast != IdTipoEstadoHipFinalizado)
        //        //            || (x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoEstadoLast != IdTipoEstadoEjcFinalizacion)
        //        //            || (x.IdTipoExpediente == IdTipoExpedienteOrdinario && x.IdTipoEstadoLast != IdTipoEstadoOrdFinalizacion)
        //        //        ));

        //        //case TipoIndicadorQa.NegociacionPrecontenciosoPendienteAsignar:
        //        //    return queryBaseConParalizados.Where(x =>
        //        //        (!x.IdExpedienteNegociacion.HasValue || (
        //        //            !x.ExpedienteNegociacion.IdGestor.HasValue
        //        //            && !x.ExpedienteNegociacion.PrecontenciosoFechaFin.HasValue
        //        //        ))
        //        //        && x.IdClienteOficina == IdClienteOficinaAcinsaBankia
        //        //        && (
        //        //            (x.IdTipoExpediente == IdTipoExpedienteHipotecario && x.IdTipoEstadoLast < IdTipoEstadoHipPresentDemanda)
        //        //            || (x.IdTipoExpediente == IdTipoExpedienteEjecutivo && x.IdTipoEstadoLast <= IdTipoEstadoEjcAdmisionTramiteEmbargo)
        //        //            || (x.IdTipoExpediente == IdTipoExpedienteOrdinario && x.IdTipoEstadoLast < IdTipoEstadoOrdFinalizacion)
        //        //        ));


        //        //case TipoIndicadorQa.NegociacionAlquilerPrecontencioso:
        //        //    return queryBaseConParalizados.Where(x =>
        //        //        x.IdExpedienteNegociacion.HasValue
        //        //        && !x.ExpedienteNegociacion.PrecontenciosoFechaFin.HasValue
        //        //        && x.ExpedienteNegociacion.IdGestor.HasValue
        //        //        && x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //        //        && lstEstadosInicio.Any(e => e == x.IdTipoEstadoLast)
        //        //        && x.IdTipoArea == IdTipoAreaNegociaciones
        //        //    //&& LstAlqClientes.Any(c => c == x.Gnr_ClienteOficina.IdCliente)
        //        //    );
        //        //case TipoIndicadorQa.NegociacionAlquilerPrecontenciosoPendienteAsignar:
        //        //    return queryBaseConParalizados.Where(x =>
        //        //        (!x.IdExpedienteNegociacion.HasValue || (
        //        //            !x.ExpedienteNegociacion.IdGestor.HasValue
        //        //             && !x.ExpedienteNegociacion.PrecontenciosoFechaFin.HasValue
        //        //         ))
        //        //        && x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //        //        && lstEstadosInicio.Any(e => e == x.IdTipoEstadoLast)
        //        //        && x.IdTipoArea == IdTipoAreaNegociaciones
        //        //    //&& LstAlqClientes.Any(c => c == x.Gnr_ClienteOficina.IdCliente)
        //        //    );

        //        //case TipoIndicadorQa.NegociacionAlquilerContencioso:
        //        //    return queryBaseConParalizados.Where(x =>
        //        //        x.IdExpedienteNegociacion.HasValue
        //        //        && !x.ExpedienteNegociacion.ContenciosoFechaFin.HasValue
        //        //        && x.ExpedienteNegociacion.IdGestorContencioso.HasValue
        //        //        && x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //        //        && x.ExpedienteEstadoLast != null
        //        //        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqLanzamiento
        //        //        && LstAlqClientes.Any(c => c == x.Gnr_ClienteOficina.IdCliente)
        //        //    );
        //        //case TipoIndicadorQa.NegociacionAlquilerContenciosoPendienteAsignar:
        //        //    return queryBaseConParalizados.Where(x =>
        //        //        (!x.IdExpedienteNegociacion.HasValue || (
        //        //            !x.ExpedienteNegociacion.IdGestorContencioso.HasValue
        //        //             && !x.ExpedienteNegociacion.ContenciosoFechaFin.HasValue
        //        //         ))
        //        //        && x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //        //        && x.ExpedienteEstadoLast != null
        //        //        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqLanzamiento
        //        //        && LstAlqClientes.Any(c => c == x.Gnr_ClienteOficina.IdCliente)
        //        //    );


        //        //case TipoIndicadorQa.NegociacionContencioso:
        //        //    return queryBaseConParalizados.Where(x =>
        //        //        x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //        //        && x.IdClienteOficina == IdClienteOficinaAcinsaBankia
        //        //        //&& x.IdTipoEstadoLast == IdTipoEstadoHipAdjudicacion
        //        //        && x.IdTipoEstadoLast.HasValue
        //        //        && lstExpedientesParalizado.All(y => y != x.IdTipoEstadoLast)
        //        //        && lstExpedientesFinalizado.All(y => y != x.IdTipoEstadoLast)

        //        //        && x.IdExpedienteNegociacion.HasValue
        //        //        && !x.ExpedienteNegociacion.ContenciosoFechaFin.HasValue
        //        //        && x.ExpedienteNegociacion.IdGestorContencioso.HasValue
        //        //    );
        //        //case TipoIndicadorQa.NegociacionContenciosoPendienteAsignar:
        //        //    return queryBaseConParalizados.Where(x =>
        //        //        x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //        //        && x.IdClienteOficina == IdClienteOficinaAcinsaBankia
        //        //        && x.IdTipoEstadoLast == IdTipoEstadoHipAdjudicacion
        //        //        && (
        //        //            x.ExpedienteNegociacion == null
        //        //            || (
        //        //                !x.ExpedienteNegociacion.IdGestorContencioso.HasValue
        //        //                && !x.ExpedienteNegociacion.ContenciosoFechaFin.HasValue
        //        //            )
        //        //        )
        //        //        //&& x.IdExpedienteNegociacion.HasValue
        //        //        //&& !x.ExpedienteNegociacion.ContenciosoFechaFin.HasValue
        //        //        //&& !x.ExpedienteNegociacion.IdGestorContencioso.HasValue

        //        //        );

        //        //case TipoIndicadorQa.NegociacionContenciosoFechaTestimonio:
        //        //    return queryBaseConParalizados.Where(x =>
        //        //        x.IdTipoExpediente == IdTipoExpedienteHipotecario
        //        //        && x.IdClienteOficina == IdClienteOficinaAcinsaBankia
        //        //        && x.IdEstadoLast.HasValue
        //        //        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipAdjudicacion
        //        //        && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio.HasValue
        //        //        && x.IdExpedienteNegociacion.HasValue
        //        //        && !x.ExpedienteNegociacion.ContenciosoFechaFin.HasValue
        //        //        && x.ExpedienteNegociacion.IdGestorContencioso.HasValue
        //        //        );

        //        //case TipoIndicadorQa.NegociacionTpa:
        //        //    return queryBaseConParalizados.Where(x =>
        //        //        x.IdTipoExpediente == IdTipoExpedienteTpa
        //        //        && x.IdExpedienteNegociacion.HasValue
        //        //        && !x.ExpedienteNegociacion.ContenciosoFechaFin.HasValue
        //        //        && x.ExpedienteNegociacion.IdGestorContencioso.HasValue
        //        //    );

        //        //case TipoIndicadorQa.NegociacionTpaPendienteAsignar:
        //        //    return queryBaseConParalizados.Where(x =>
        //        //        x.IdTipoExpediente == IdTipoExpedienteTpa
        //        //        && (
        //        //            !x.IdExpedienteNegociacion.HasValue
        //        //            || (
        //        //                !x.ExpedienteNegociacion.IdGestorContencioso.HasValue
        //        //                && !x.ExpedienteNegociacion.ContenciosoFechaFin.HasValue
        //        //            )
        //        //        ));

        //        case TipoIndicadorQa.TpaFallidas:
        //            return queryBaseConParalizados.Where(x =>
        //                x.IdTipoEstadoLast == idTipoEstadoHipNegociacionPosesion
        //                && x.ExpedienteEstadoes.Any(ee =>
        //                    ee.IdTipoEstado == idTipoEstadoHipNegociacionPosesion
        //                    && ee.Hip_ExpedienteEstadoNegociacionPosesion.NegociacionFinalizadaPor.HasValue
        //                    && ee.Hip_ExpedienteEstadoNegociacionPosesion.NegociacionFinalizadaPor.Value == 4));
        //        case TipoIndicadorQa.PropuestaAceptada:
        //            return queryBaseConParalizados.Where(x =>
        //                    x.IdTipoEstadoLast == idTipoEstadoHipNegociacionPosesion
        //                    && x.ExpedienteEstadoes.Any(ee =>
        //                    ee.IdTipoEstado == idTipoEstadoHipNegociacionPosesion
        //                    && ee.Hip_ExpedienteEstadoNegociacionPosesion.ExpedienteEstadoId == (int)ExpedienteEstadoTipo.NegociacionSucursalFinalizadoPropuestaAceptada));
        //        case TipoIndicadorQa.PropuestaDenegada:
        //            return queryBaseConParalizados.Where(x =>
        //                    x.IdEstadoLast == idTipoEstadoHipNegociacionPosesion
        //                    && x.ExpedienteEstadoes.Any(ee =>
        //                    ee.IdTipoEstado == idTipoEstadoHipNegociacionPosesion
        //                    && ee.Hip_ExpedienteEstadoNegociacionPosesion.ExpedienteEstadoId == (int)ExpedienteEstadoTipo.NegociacionSucursalFinalizadoPropuestaDenegada));
        //        case TipoIndicadorQa.PagoDeuda:
        //            return queryBaseConParalizados.Where(x =>
        //                    x.IdEstadoLast == idTipoEstadoHipNegociacionPosesion
        //                    && x.ExpedienteEstadoes.Any(ee =>
        //                    ee.IdTipoEstado == idTipoEstadoHipNegociacionPosesion
        //                    && ee.Hip_ExpedienteEstadoNegociacionPosesion.ExpedienteEstadoId == (int)ExpedienteEstadoTipo.NegociacionFinalizadoPagoDeuda));
        //        case TipoIndicadorQa.EntregaInmueble:
        //            return queryBaseConParalizados.Where(x =>
        //                    x.IdEstadoLast == idTipoEstadoHipNegociacionPosesion
        //                    && x.ExpedienteEstadoes.Any(ee =>
        //                    ee.IdTipoEstado == idTipoEstadoHipNegociacionPosesion
        //                    && ee.Hip_ExpedienteEstadoNegociacionPosesion.ExpedienteEstadoId == (int)ExpedienteEstadoTipo.NegociacionSucursalInviable));
        //        case TipoIndicadorQa.Inviables:
        //            return queryBaseConParalizados.Where(x =>
        //                    x.IdEstadoLast == idTipoEstadoHipNegociacionPosesion
        //                    && x.ExpedienteEstadoes.Any(ee =>
        //                    ee.IdTipoEstado == idTipoEstadoHipNegociacionPosesion
        //                    && ee.Hip_ExpedienteEstadoNegociacionPosesion.ExpedienteEstadoId == (int)ExpedienteEstadoTipo.NegociacionFinalizadoInviable));





        //        #endregion

        //        #region Negociacion Alarmas

        //        //case TipoIndicadorQa.NegociacionAlarmaExpiradoTiempoNegAlquiler:
        //        //    return queryBase.Where(x =>
        //        //            x.IdTipoExpediente == IdTipoExpedienteAlquiler
        //        //            && x.IdEstadoLast.HasValue
        //        //            && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoAlqRecepcionExpediente
        //        //            && x.ExpedienteNegociacion != null
        //        //            && !x.ExpedienteNegociacion.PrecontenciosoFechaFin.HasValue
        //        //            && x.ExpedienteEstadoLast.Fecha < FechaActualMenos30
        //        //        );

        //        //case TipoIndicadorQa.NegociacionAlarmaExpiradoTiempoNegPrecontencioso:
        //        //    return queryBase.Where(x =>
        //        //            x.IdTipoExpediente != IdTipoExpedienteAlquiler
        //        //            && x.IdEstadoLast.HasValue
        //        //            && x.ExpedienteEstadoLast.Gnr_TipoEstado.Inicio
        //        //            && x.ExpedienteNegociacion != null
        //        //            && !x.ExpedienteNegociacion.PrecontenciosoFechaFin.HasValue
        //        //            && x.ExpedienteEstadoLast.Fecha < FechaActualMenos30
        //        //        );

        //        #endregion

        //        #endregion

        //        #region Ordinario

        //        #region Ordinario - Indicadores

        //        case TipoIndicadorQa.OrdinarioInactivo:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
        //                                        && x.FechaModificacion < FechaActualMenos90
        //                                        && x.IdTipoEstadoLast.HasValue
        //                                        && lstExpedientesParalizado.All(y => y != x.IdTipoEstadoLast)
        //                                        && lstExpedientesFinalizado.All(y => y != x.IdTipoEstadoLast)
        //                                        && x.ExpedienteEstadoes.All(e => e.FechaAlta < FechaActualMenos90)
        //                                        && x.ExpedienteNotaSet.All(e => e.Fecha < FechaActualMenos90)
        //                                        && x.ImpulsoSet.All(e => e.Fecha < FechaActualMenos90)
        //                                        && x.ActuacionSet.All(e => e.Fecha < FechaActualMenos90)
        //            );

        //        case TipoIndicadorQa.OrdinarioIncidenciaDocumental:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdRecepcionExpediente
        //                && x.ExpedienteEstadoLast.IdTipoSubFaseEstado.HasValue
        //                && (
        //                    x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0102IncidenciaDocumental
        //                    || x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0104
        //                )
        //            );

        //        case TipoIndicadorQa.OrdinarioPendientePreparacionDemanda:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
        //                                        && x.IdTipoEstadoLast.HasValue
        //                                        && (
        //                                            (x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdRecepcionExpediente
        //                                                && x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoHip0103PreparacionDemanda
        //                                            ) || (
        //                                                x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdPresentacionDemanda
        //                                                && !x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda.FechaEnvioProcurador.HasValue
        //                                            )
        //                                        )
        //            );

        //        case TipoIndicadorQa.OrdinarioPendienteDecretoAdmision:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
        //                                        && x.IdTipoEstadoLast.HasValue
        //                                        && (
        //                                            (
        //                                                x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdPresentacionDemanda
        //                                                && !x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda.NoAdmitidaFecha.HasValue
        //                                                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda.FechaPresentacion.HasValue
        //                                            ) || (
        //                                                x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdAutoAdmisionNotificacion
        //                                                && !x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioAutoAdmisionNotificacion.AdmitidaFecha.HasValue
        //                                            )
        //                                        )
        //            );

        //        case TipoIndicadorQa.OrdinarioAudienciaPrevia:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
        //                                        && x.IdTipoEstadoLast.HasValue
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdTramitacionJuzgado
        //                                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioTramitacionJuzgado.AudienciaPreviaFecha.HasValue
        //            );

        //        case TipoIndicadorQa.OrdinarioJuicio:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
        //                                        && x.IdTipoEstadoLast.HasValue
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdJuicio
        //                                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioJuicio.JuicioFecha.HasValue
        //            );

        //        case TipoIndicadorQa.OrdinarioSentencia:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
        //                                        && x.IdTipoEstadoLast.HasValue
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdSentencia
        //                                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioSentencia.SentenciaFecha.HasValue
        //            );

        //        case TipoIndicadorQa.OrdinarioRecursoApelacion:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
        //                                        && x.IdTipoEstadoLast.HasValue
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdSentencia
        //                                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioSentencia.ApelacionFecha.HasValue
        //            );

        //        case TipoIndicadorQa.OrdinarioCasacionInfraccionProcesal:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
        //                                        && x.IdTipoEstadoLast.HasValue
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdSentencia
        //                                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioSentencia.InfraccionProcesalFecha.HasValue
        //            );

        //        case TipoIndicadorQa.OrdinarioEjecucionSentencia:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
        //                                        && x.IdTipoEstadoLast.HasValue
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdFinalizacion
        //                                        && x.ExpedienteEstadoLast.IdTipoSubFaseEstado == IdTipoSubFaseEstadoEjecucionSentencia
        //            );

        //        case TipoIndicadorQa.OrdinarioPendienteFirmezaSentenciaEstimatoria:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdSentencia
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioSentencia.SentenciaFecha.HasValue
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioSentencia.SentenciaResultado == 2 //Estimatoria
        //                && !x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioSentencia.SentenciaFirmezaFecha.HasValue
        //            );

        //        #endregion

        //        #region Ordinario - Alarmas 

        //        case TipoIndicadorQa.OrdinarioAlarmaPdteDemanda:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdRecepcionExpediente
        //                && x.ExpedienteEstadoLast.Fecha < FechaActualMenos30
        //            );

        //        case TipoIndicadorQa.OrdinarioAlarmaDecretoAdmision:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdPresentacionDemanda
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda != null
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda.FechaPresentacion.HasValue
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda.FechaPresentacion < FechaActualMenos30
        //            );

        //        case TipoIndicadorQa.OrdinarioAlarmaEmplazamientoPositivo:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdTramitacionJuzgado
        //                && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoDatoRequerimiento.Any(y =>
        //                    y.Positivo
        //                    && y.FechaRequerimientoPago.HasValue
        //                    && y.FechaRequerimientoPago.Value < FechaActualMenos20
        //                )
        //            );

        //        case TipoIndicadorQa.OrdinarioAlarmaEmplazamientoNegativo:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdTramitacionJuzgado
        //                && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoDatoRequerimiento.Any(y =>
        //                    !y.Positivo
        //                    && y.FechaRequerimientoPago.HasValue
        //                    && y.FechaRequerimientoPago.Value < FechaActualMenos30
        //                )
        //            );

        //        case TipoIndicadorQa.OrdinarioAlarmaAudienciaPrevia:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdTramitacionJuzgado
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioTramitacionJuzgado != null
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioTramitacionJuzgado.AudienciaPreviaFecha.HasValue
        //                && x.ExpedienteEstadoLast.Hip_ExpedienteEstadoDatoRequerimiento.Any(y =>
        //                    !y.Positivo
        //                    && y.FechaRequerimientoPago.HasValue
        //                    && y.FechaRequerimientoPago.Value < FechaActualMenos30
        //                )
        //            );

        //        case TipoIndicadorQa.OrdinarioAlarmaJuicio:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdTramitacionJuzgado
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioTramitacionJuzgado != null
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioTramitacionJuzgado.AudienciaPreviaFecha.HasValue
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioTramitacionJuzgado.AudienciaPreviaFecha.Value < FechaActualMenos60
        //            );

        //        case TipoIndicadorQa.OrdinarioAlarmaSentencia:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdJuicio
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioJuicio != null
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioJuicio.JuicioFecha.HasValue
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioJuicio.JuicioFecha.Value < FechaActualMenos30
        //            );

        //        case TipoIndicadorQa.OrdinarioAlarmaPdteSentencia:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdSentencia
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioSentencia != null
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioSentencia.SentenciaFirmezaFecha.HasValue
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioSentencia.SentenciaFirmezaFecha.Value < FechaActualMenos30
        //            );

        //        case TipoIndicadorQa.OrdinarioAlarmaRecepcionDemandaSellada:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdPresentacionDemanda
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda != null
        //                && !x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda.FechaPresentacion.HasValue
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda.FechaEnvioProcurador.HasValue
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioPresentacionDemanda.FechaEnvioProcurador < FechaActualMenos3
        //            );

        //        case TipoIndicadorQa.OrdinarioAlarmaSucesionCopiaSellada:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
        //                && !x.SucesionCopiaSellada.HasValue
        //                && x.SucesionPresentada.HasValue
        //                && x.SucesionPresentada < FechaActualMenos2
        //            );

        //        #endregion

        //        #region Ordinario - Facturas 

        //        case TipoIndicadorQa.OrdinarioFacturasHito1Caixa:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinario
        //                && x.IdTipoArea == IdTipoAreaDesahucios
        //                && x.Gnr_ClienteOficina.IdCliente == IdClienteCaixa
        //                && !x.FacturaSet.Any()
        //                && (
        //                    x.ExpedienteEstadoes.Any(y => y.IdTipoEstado == IdTipoEstadoOrdFinalizacion)
        //                    || x.ExpedienteEstadoes.Any(y => y.IdTipoEstado == IdTipoEstadoOrdSentencia)
        //                )
        //            );

        //        #endregion

        //        #endregion

        //        #region OrdinarioCs

        //        #region OrdinarioCs - Indicadores
        //        #endregion

        //        #region OrdinarioCs - Alarmas

        //        case TipoIndicadorQa.OrdinarioCsAlarmaVencimientoAllanamiento:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
        //                                        && x.IdEstadoLast.HasValue
        //                                        //&& lstExpedientesFinalizado.All(y => y != x.ExpedienteEstadoLast.IdTipoEstado)
        //                                        //&& lstExpedientesParalizado.All(y => y != x.ExpedienteEstadoLast.IdTipoEstado)
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdCsRecepcionExpediente
        //                                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsRecepcion != null
        //                                        && x.ExpedienteEstadoLast.IdTipoSubFaseEstado != TipoFaseEstadoOcs0101

        //                                        && x.ExpedienteOrdinarioCs != null
        //                                        && !x.ExpedienteOrdinarioCs.AllanamientoFecha.HasValue
        //                                        && x.ExpedienteOrdinarioCs.FechaNotificacionDemanda.HasValue
        //                                        && x.ExpedienteOrdinarioCs.FechaNotificacionDemanda < FechaActualMenos13
        //            );

        //        case TipoIndicadorQa.OrdinarioCsAlarmaPendienteCopiaSelladaAllanamiento:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
        //                                        && x.IdEstadoLast.HasValue
        //                                        && lstExpedientesFinalizado.All(y => y != x.ExpedienteEstadoLast.IdTipoEstado)
        //                                        && lstExpedientesParalizado.All(y => y != x.ExpedienteEstadoLast.IdTipoEstado)
        //                                        && x.ExpedienteOrdinarioCs != null
        //                                        && !x.ExpedienteOrdinarioCs.FechaAllanamientoCopiaSellada.HasValue
        //                                        && x.ExpedienteOrdinarioCs.AllanamientoFecha.HasValue
        //                                        && x.ExpedienteOrdinarioCs.AllanamientoFecha < FechaActualMenos3
        //            );

        //        case TipoIndicadorQa.OrdinarioCsAlarmaSentencia:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
        //                                        && x.IdEstadoLast.HasValue
        //                                        && x.ExpedienteEstadoes.All(ee => ee.IdTipoEstado != IdTipoEstadoOrdCsSentencia)
        //                                        && x.ExpedienteOrdinarioCs != null
        //                                        && x.ExpedienteOrdinarioCs.FechaAllanamientoCopiaSellada.HasValue
        //                                        && x.ExpedienteOrdinarioCs.FechaAllanamientoCopiaSellada < FechaActualMenos90
        //            );

        //        case TipoIndicadorQa.OrdinarioCsAlarmaSentenciaSinCostasAbonadas:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
        //                                        && x.IdEstadoLast.HasValue
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdCsSentencia
        //                                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia != null
        //                                        && !x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia.CostasAbonadas
        //                                        && x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoOcs0705
        //                                        && x.ExpedienteEstadoLast.Fecha < FechaActualMenos15
        //            );

        //        case TipoIndicadorQa.OrdinarioCsAlarmaPendienteFinalizacion:
        //            var lstSubFases = new List<int?> { TipoFaseEstadoOcs0703, TipoFaseEstadoOcs0704, TipoFaseEstadoOcs0705, TipoFaseEstadoOcs0708, TipoFaseEstadoOcs0709 };
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
        //                                        && x.IdEstadoLast.HasValue
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdCsSentencia
        //                                        && !lstSubFases.Contains(x.ExpedienteEstadoLast.IdTipoSubFaseEstado)
        //                                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia.SentenciaFecha.HasValue
        //                                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia.SentenciaFecha < FechaActualMenos40
        //            );

        //        #endregion

        //        #region OrdinarioCs - Facturas

        //        case TipoIndicadorQa.OrdinarioCsFacturasBancoPopularHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
        //                                        && x.IdClienteOficina == IdOficinaBancoPopular
        //                                        && x.ExpedienteOrdinarioCs != null
        //                                        && x.ExpedienteOrdinarioCs.AllanamientoFecha.HasValue
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.OrdinarioCsHito1)
        //            );

        //        case TipoIndicadorQa.OrdinarioCsFacturasBancoPopularHito2:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
        //                                        && x.IdClienteOficina == IdOficinaBancoPopular
        //                                        && x.ExpedienteOrdinarioCs != null
        //                                        && x.ExpedienteEstadoLast != null
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdCsFinalizacion
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.OrdinarioCsHito2)
        //            );

        //        case TipoIndicadorQa.OrdinarioCsFacturasHito2PendienteFinalizar:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
        //                                        && x.IdEstadoLast.HasValue
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdCsSentencia
        //                                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia != null
        //                                        //&& !x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia.Apelacion
        //                                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia.SentenciaFecha.HasValue
        //                                        && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia.SentenciaFecha < FechaActualMenos30
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.OrdinarioCsHito2)
        //            );

        //        #endregion

        //        #endregion

        //        #region TPA

        //        #region TPA - Indicadores / Facturas

        //        //case TipoIndicadorQa.TpaFacturasPendientesHito1:
        //        //    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteTpa
        //        //                                && x.ExpedienteNegociacion != null
        //        //                                //&& x.ExpedienteNegociacion.PrecontenciosoFechaLocalizado.HasValue
        //        //                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.TpaHito1)
        //        //    );
        //        //case TipoIndicadorQa.TpaFacturasPendientesHito2:
        //        //    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteTpa
        //        //                                && x.ExpedienteNegociacion != null
        //        //                                && x.ExpedienteNegociacion.ContenciosoNegociacionFinalizadaPor == 3 //Finalización Toma de posesión Anticipada
        //        //                                && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.TpaHito2)
        //        //    );

        //        #endregion

        //        #region TPA - Alarmas

        //        //case TipoIndicadorQa.OrdinarioCsAlarmaVencimientoAllanamiento:
        //        //    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
        //        //                                && x.IdEstadoLast.HasValue
        //        //                                //&& lstExpedientesFinalizado.All(y => y != x.ExpedienteEstadoLast.IdTipoEstado)
        //        //                                //&& lstExpedientesParalizado.All(y => y != x.ExpedienteEstadoLast.IdTipoEstado)
        //        //                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdCsRecepcionExpediente
        //        //                                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsRecepcion != null
        //        //                                && x.ExpedienteEstadoLast.IdTipoSubFaseEstado != TipoFaseEstadoOcs0101

        //        //                                && x.ExpedienteOrdinarioCs != null
        //        //                                && !x.ExpedienteOrdinarioCs.AllanamientoFecha.HasValue
        //        //                                && x.ExpedienteOrdinarioCs.FechaNotificacionDemanda.HasValue
        //        //                                && x.ExpedienteOrdinarioCs.FechaNotificacionDemanda < FechaActualMenos13
        //        //    );

        //        //case TipoIndicadorQa.OrdinarioCsAlarmaPendienteCopiaSelladaAllanamiento:
        //        //    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
        //        //                                && x.IdEstadoLast.HasValue
        //        //                                && lstExpedientesFinalizado.All(y => y != x.ExpedienteEstadoLast.IdTipoEstado)
        //        //                                && lstExpedientesParalizado.All(y => y != x.ExpedienteEstadoLast.IdTipoEstado)
        //        //                                && x.ExpedienteOrdinarioCs != null
        //        //                                && !x.ExpedienteOrdinarioCs.FechaAllanamientoCopiaSellada.HasValue
        //        //                                && x.ExpedienteOrdinarioCs.AllanamientoFecha.HasValue
        //        //                                && x.ExpedienteOrdinarioCs.AllanamientoFecha < FechaActualMenos3
        //        //    );

        //        #endregion

        //        #endregion

        //        #region JC

        //        #region JC - Indicadores / Facturas

        //        case TipoIndicadorQa.JcFacturasPendientesHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteJuraCuenta
        //                                        && !x.FacturacionCompleta && !x.EsNofacturable
        //                                        && x.FechaFacturableH1.HasValue
        //                                        && x.FechaFacturableH1 < FechaActual
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.Hito1)
        //            );
        //        case TipoIndicadorQa.JcFacturasPendientesHito1ConHito2:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteJuraCuenta
        //                                        && !x.FacturacionCompleta && !x.EsNofacturable
        //                                        && x.FacturaSet.Any()
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.Hito1)
        //            );
        //        case TipoIndicadorQa.JcFacturasPendientesHito2:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteJuraCuenta
        //                                        && !x.FacturacionCompleta && !x.EsNofacturable
        //                                        && x.FechaFacturableH2.HasValue
        //                                        && x.FechaFacturableH2 < FechaActual
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.Hito2)
        //            );

        //        #endregion

        //        #region JC - Alarmas

        //        #endregion

        //        #endregion

        //        #region Concursal (ReI, MyC)

        //        #region Concursal - Facturas

        //        case TipoIndicadorQa.MyCFacturasPendientesHito1:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
        //                                        && x.FechaFacturableH1.HasValue
        //                                        && x.FechaFacturableH1 < FechaActual
        //                                        && x.FacturaSet.All(f => f.HitoFacturacion != HitoFacturacionValue.Hito1)
        //            );

        //        case TipoIndicadorQa.MyCFacturasAbanca52:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
        //                                        && x.Gnr_ClienteOficina.IdCliente == IdClienteAbanca
        //                                        && x.ExpedienteHitoSet.Any(y => y.IdTipoHitoProcesal == ID_TIPO_HITO_PROCESAL_CONCURSAL_52)
        //                                        && x.FacturaSet.All(f => f.IdTipoHitoProcesal != ID_TIPO_HITO_PROCESAL_CONCURSAL_52)
        //            );

        //        #endregion

        //        #region Concursal - Alarmas 

        //        case TipoIndicadorQa.ConcursoAlarmaCumplidoHito01:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
        //                && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.TipoHitoProcesal.Orden == 1)
        //            );

        //        case TipoIndicadorQa.ConcursoAlarmaCumplidoHito57:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
        //                && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.TipoHitoProcesal.Orden == 57)
        //            );

        //        case TipoIndicadorQa.ConcursoAlarmaCumplidoHito14_18:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
        //                && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.TipoHitoProcesal.Orden == 14 && y.Fecha < FechaActualMenos540)
        //            );

        //        case TipoIndicadorQa.ConcursoAlarmaCumplidoHito14_48:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
        //                && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.TipoHitoProcesal.Orden == 14 && y.Fecha < FechaActualMenos1440)
        //            );

        //        case TipoIndicadorQa.ConcursoAlarmaCumplidoHito73:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
        //                && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.TipoHitoProcesal.Orden == 73)
        //            );

        //        case TipoIndicadorQa.ConcursoAlarmaCumplidoHito74:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
        //                && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.TipoHitoProcesal.Orden == 74)
        //            );

        //        case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_01:
        //            int[] arr1 = { 8, 419, 751, 571, 574, 586, 883, 920 };
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
        //                && x.Inicio >= Fecha20210101
        //                && arr1.Contains(x.IdClienteOficina)
        //                //&& ((int[])({ 1, 8 })).Contains(x.IdClienteOficina)
        //                && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_01 && y.Fecha <= FechaActual)
        //            );

        //        case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_57:
        //            int[] arr2 = { 8, 571 };
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
        //                && x.Inicio >= Fecha20210101
        //                && arr2.Contains(x.IdClienteOficina)
        //                && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_57 && y.Fecha <= FechaActual)
        //            );

        //        case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_14_18m:
        //            int[] arr3 = { 8 };
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
        //                && x.Inicio >= Fecha20210101
        //                && arr3.Contains(x.IdClienteOficina)
        //                && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_14 && y.Fecha <= FechaActualMenos540)
        //            );

        //        case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_14_48m:
        //            int[] arr4 = { -1, 8 };
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
        //                && x.Inicio >= Fecha20210101
        //                && arr4.Contains(x.IdClienteOficina)
        //                && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_14 && y.Fecha <= FechaActualMenos1440)
        //            );

        //        case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_74:
        //            int[] arr5 = { 8, 419, 751, 571, 574, 1, 883, 920 };
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
        //                && x.Inicio >= Fecha20210101
        //                && arr5.Contains(x.IdClienteOficina)
        //                && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_74 && y.Fecha <= FechaActual)
        //            );

        //        case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_78:
        //            int[] arr6 = { 8 };
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
        //                && x.Inicio >= Fecha20210101
        //                && arr6.Contains(x.IdClienteOficina)
        //                && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_78 && y.Fecha <= FechaActual)
        //            );

        //        case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_79:
        //            int[] arr7 = { 8 };
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
        //                && x.Inicio >= Fecha20210101
        //                && arr7.Contains(x.IdClienteOficina)
        //                && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_79 && y.Fecha <= FechaActual)
        //            );

        //        case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_73:
        //            int[] arr8 = { 8, 419, 751, 571, 574 };
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
        //                && x.Inicio >= Fecha20210101
        //                && arr8.Contains(x.IdClienteOficina)
        //                && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_73 && y.Fecha <= FechaActual)
        //            );
        //        case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_52:
        //            int[] arr9 = { 8, 419, 751, 571, 574, 586, 1, 883, 920 };
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
        //                && x.Inicio >= Fecha20210101
        //                && arr9.Contains(x.IdClienteOficina)
        //                && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_52 && y.Fecha <= FechaActual)
        //            );
        //        case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_54:
        //            int[] arr10 = { 8, 419, 751, 571, 574, 586, 1, 883, 920 };
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
        //                && x.Inicio >= Fecha20210101
        //                && arr10.Contains(x.IdClienteOficina)
        //                && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_54 && y.Fecha <= FechaActual)
        //            );
        //        case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_55:
        //            int[] arr11 = { 8, 419, 751, 571, 574, 586, 1, 883, 920 };
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
        //                && x.Inicio >= Fecha20210101
        //                && arr11.Contains(x.IdClienteOficina)
        //                && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_55 && y.Fecha <= FechaActual)
        //            );
        //        case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_56:
        //            int[] arr12 = { 8, 419, 751, 571, 574, 586, 1, 883, 920 };
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
        //                && x.Inicio >= Fecha20210101
        //                && arr12.Contains(x.IdClienteOficina)
        //                && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_56 && y.Fecha <= FechaActual)
        //            );
        //        case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_63:
        //            int[] arr13 = { 8, 419, 751, 574 };
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
        //                && x.Inicio >= Fecha20210101
        //                && arr13.Contains(x.IdClienteOficina)
        //                && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_63 && y.Fecha <= FechaActual)
        //            );
        //        case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_64:
        //            int[] arr14 = { 8, 419, 751, 574 };
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteConcurso
        //                && x.Inicio >= Fecha20210101
        //                && arr14.Contains(x.IdClienteOficina)
        //                && x.ExpedienteHitoSet.Any(y => !y.Facturar.HasValue && y.IdTipoHitoProcesal == IdTipoHitoProcesal_64 && y.Fecha <= FechaActual)
        //            );

        //        #endregion

        //        #endregion

        //        #region JV

        //        #region JV - Indicadores
        //        #endregion

        //        #region JV - Alarmas

        //        case TipoIndicadorQa.JvAlarmaPdteAdmision:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteJv
        //                && x.ExpedienteJV.FechaEnvioProcurador.HasValue
        //                && x.ExpedienteJV.FechaEnvioProcurador < FechaActualMenos30
        //            //&& x.ExpedienteEscrituraSet.Any(y =>
        //            //    !y.AdmisionFecha.HasValue)
        //            );

        //        case TipoIndicadorQa.JvAlarmaPdteLibradoMandamiento:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteJv
        //            //&& x.ExpedienteEscrituraSet.Any(y =>
        //            //    //!y.AdmisionFecha.HasValue
        //            //    //&& 
        //            //    y.MandamientoFechaAutoLibrar.HasValue
        //            //    && y.MandamientoFechaAutoLibrar < FechaActualMenos45)
        //            );

        //        case TipoIndicadorQa.JvAlarmaPdteNotificacion:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteJv
        //            //&& x.ExpedienteEscrituraSet.Any(y =>
        //            //    !y.NotificacionFechaVistaJurisdiccionVoluntaria.HasValue
        //            //    && y.AdmisionFecha.HasValue
        //            //    && y.AdmisionFecha < FechaActualMenos30)
        //            );

        //        case TipoIndicadorQa.JvAlarmaPdteRecepcionEscritura:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteJv
        //                && x.ExpedienteJV.FechaRecepcion.HasValue
        //            //&& x.ExpedienteEscrituraSet.Any(y =>
        //            //    y.MandamientoFechaLibrado.HasValue
        //            //    && y.MandamientoFechaLibrado < FechaActualMenos30)
        //            );

        //        case TipoIndicadorQa.JvAlarmaRecepcionDemandaSellada:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteJv
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoJvPresentDemanda
        //                && x.ExpedienteEstadoLast.JvExpedienteEstadoPresentacionDemanda != null
        //                && !x.ExpedienteEstadoLast.JvExpedienteEstadoPresentacionDemanda.FechaPresentacion.HasValue
        //                && x.ExpedienteEstadoLast.JvExpedienteEstadoPresentacionDemanda.FechaEnvioProcurador.HasValue
        //                && x.ExpedienteEstadoLast.JvExpedienteEstadoPresentacionDemanda.FechaEnvioProcurador < FechaActualMenos3
        //            );

        //        //case TipoIndicadorQa.OrdinarioCsAlarmaPendienteCopiaSelladaAllanamiento:
        //        //    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
        //        //                                && x.IdEstadoLast.HasValue
        //        //                                && lstExpedientesFinalizado.All(y => y != x.ExpedienteEstadoLast.IdTipoEstado)
        //        //                                && lstExpedientesParalizado.All(y => y != x.ExpedienteEstadoLast.IdTipoEstado)
        //        //                                && x.ExpedienteOrdinarioCs != null
        //        //                                && !x.ExpedienteOrdinarioCs.FechaAllanamientoCopiaSellada.HasValue
        //        //                                && x.ExpedienteOrdinarioCs.AllanamientoFecha.HasValue
        //        //                                && x.ExpedienteOrdinarioCs.AllanamientoFecha < FechaActualMenos3
        //        //    );

        //        //case TipoIndicadorQa.OrdinarioCsAlarmaSentencia:
        //        //    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
        //        //                                && x.IdEstadoLast.HasValue
        //        //                                && x.ExpedienteEstadoes.All(ee => ee.IdTipoEstado != IdTipoEstadoOrdCsSentencia)
        //        //                                && x.ExpedienteOrdinarioCs != null
        //        //                                && x.ExpedienteOrdinarioCs.FechaAllanamientoCopiaSellada.HasValue
        //        //                                && x.ExpedienteOrdinarioCs.FechaAllanamientoCopiaSellada < FechaActualMenos90
        //        //    );

        //        //case TipoIndicadorQa.OrdinarioCsAlarmaSentenciaSinCostasAbonadas:
        //        //    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
        //        //                                && x.IdEstadoLast.HasValue
        //        //                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdCsSentencia
        //        //                                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia != null
        //        //                                && !x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia.CostasAbonadas
        //        //                                && x.ExpedienteEstadoLast.IdTipoSubFaseEstado == TipoFaseEstadoOcs0705
        //        //                                && x.ExpedienteEstadoLast.Fecha < FechaActualMenos15
        //        //    );

        //        //case TipoIndicadorQa.OrdinarioCsAlarmaPendienteFinalizacion:
        //        //    return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteOrdinarioCs
        //        //                                && x.IdEstadoLast.HasValue
        //        //                                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoOrdCsSentencia
        //        //                                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia != null
        //        //                                && !x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia.Apelacion
        //        //                                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia.SentenciaFecha.HasValue
        //        //                                && x.ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsSentencia.SentenciaFecha < FechaActualMenos30
        //        //    );

        //        #endregion

        //        #region JV - Facturas

        //        #endregion

        //        #endregion

        //        #region Monitorio

        //        #region Monitorio - Indicadores

        //        case TipoIndicadorQa.MonitorioPdteExpVerbal:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMonitorio
        //                                        && x.IdTipoEstadoLast.HasValue
        //                                        && x.ExpedienteEstadoLast != null
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoMnTramitJuzgado
        //                                        && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioTramitacionJuzgado != null
        //                                        && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioTramitacionJuzgado.TrasladoOposicionFecha.HasValue
        //                                        && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioTramitacionJuzgado.ImporteAdmision.HasValue
        //                                        && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioTramitacionJuzgado.ImporteAdmision.Value < 6000
        //                                        && !x.ExpedienteMonitorio.IdExpedienteVb.HasValue
        //                                        && !x.ExpedienteMonitorio.IdExpedienteOrd.HasValue
        //                                        && !x.ExpedienteMonitorio.IdExpedienteEjc.HasValue
        //            );

        //        case TipoIndicadorQa.MonitorioPdteExpOrdinario:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMonitorio
        //                                        && x.IdTipoEstadoLast.HasValue
        //                                        && x.ExpedienteEstadoLast != null
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoMnTramitJuzgado
        //                                        && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioTramitacionJuzgado != null
        //                                        && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioTramitacionJuzgado.TrasladoOposicionFecha.HasValue
        //                                        && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioTramitacionJuzgado.ImporteAdmision.HasValue
        //                                        && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioTramitacionJuzgado.ImporteAdmision.Value >= 6000
        //                                        && !x.ExpedienteMonitorio.IdExpedienteVb.HasValue
        //                                        && !x.ExpedienteMonitorio.IdExpedienteOrd.HasValue
        //                                        && !x.ExpedienteMonitorio.IdExpedienteEjc.HasValue
        //            );

        //        case TipoIndicadorQa.MonitorioPdteExpEjecutivo:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMonitorio
        //                                        && x.IdTipoEstadoLast.HasValue
        //                                        && x.ExpedienteEstadoLast != null
        //                                        && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoMnTramitJuzgado
        //                                        && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioTramitacionJuzgado != null
        //                                        && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioTramitacionJuzgado.DecretoArchivoFecha.HasValue
        //                                        && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioTramitacionJuzgado.TipoDecretoArchivo == TipoDecretoArchivo.SinPago
        //                                        && !x.ExpedienteMonitorio.IdExpedienteVb.HasValue
        //                                        && !x.ExpedienteMonitorio.IdExpedienteOrd.HasValue
        //                                        && !x.ExpedienteMonitorio.IdExpedienteEjc.HasValue
        //            );

        //        #endregion

        //        #region Monitorio - Alarmas 

        //        case TipoIndicadorQa.MonitorioAlarmaRecepcionDemandaSellada:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMonitorio
        //                && x.IdEstadoLast.HasValue
        //                && x.ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoMnPresentDemanda
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioPresentacionDemanda != null
        //                && !x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioPresentacionDemanda.FechaPresentacion.HasValue
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioPresentacionDemanda.FechaEnvioProcurador.HasValue
        //                && x.ExpedienteEstadoLast.ExpedienteEstadoMonitorioPresentacionDemanda.FechaEnvioProcurador < FechaActualMenos3
        //            );

        //        case TipoIndicadorQa.MonitorioAlarmaSucesionCopiaSellada:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMonitorio
        //                && !x.SucesionCopiaSellada.HasValue
        //                && x.SucesionPresentada.HasValue
        //                && x.SucesionPresentada < FechaActualMenos2
        //            );

        //        #endregion

        //        #region Facturas

        //        case TipoIndicadorQa.MonitorioFacturaHito1:
        //            return queryBase.Where(x =>
        //                x.IdTipoExpediente == IdTipoExpedienteMonitorio
        //                && !x.FacturaSet.Any()
        //                && x.Fin.HasValue
        //            );

        //        #endregion

        //        #endregion

        //        #region MultiDivisa

        //        #region MultiDivisa - Indicadores

        //        case TipoIndicadorQa.MultiDivisaPendienteContacto:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMultiDivisa
        //                && x.ExpedienteMultiDivisa != null
        //                && x.ExpedienteMultiDivisa.IdFinalizadoPor == IdEstadoNegocNoContactado
        //            );

        //        case TipoIndicadorQa.MultiDivisaContactoEnNegociacion:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMultiDivisa
        //                && x.ExpedienteMultiDivisa != null
        //                && x.ExpedienteMultiDivisa.IdFinalizadoPor == IdEstadoNegocEnNegociacion
        //            );

        //        case TipoIndicadorQa.MultiDivisaContactoConAcuerdo:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMultiDivisa
        //                && x.ExpedienteMultiDivisa != null
        //                && x.ExpedienteMultiDivisa.IdFinalizadoPor == IdEstadoNegocAceptado
        //            );

        //        case TipoIndicadorQa.MultiDivisaFinalizadoConExito:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMultiDivisa
        //                && x.ExpedienteMultiDivisa != null
        //                && x.Fin.HasValue
        //                && x.ExpedienteMultiDivisa.IdFinalizadoPor == IdEstadoNegocFirmado
        //            );

        //        case TipoIndicadorQa.MultiDivisaFinalizadoLocalizado:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMultiDivisa
        //                && x.ExpedienteMultiDivisa != null
        //                && x.Fin.HasValue
        //                && x.ExpedienteMultiDivisa.IdFinalizadoPor == IdEstadoNegocRechazado
        //            );

        //        case TipoIndicadorQa.MultiDivisaFinalizadoNoLocalizado:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMultiDivisa
        //                && x.ExpedienteMultiDivisa != null
        //                && x.Fin.HasValue
        //                && x.ExpedienteMultiDivisa.IdFinalizadoPor == IdEstadoNegocNoContactado
        //            );

        //        case TipoIndicadorQa.MultiDivisaFinalizadoExcluido:
        //            return queryBase.Where(x => x.IdTipoExpediente == IdTipoExpedienteMultiDivisa
        //                && x.ExpedienteMultiDivisa != null
        //                && x.Fin.HasValue
        //                && (x.ExpedienteMultiDivisa.IdFinalizadoPor == IdEstadoNegocExcluido || x.ExpedienteMultiDivisa.IdFinalizadoPor == IdEstadoNegocExcluidoPorCliente)
        //            );

        //        #endregion

        //        #region MultiDivisa - Alarmas 

        //        #endregion

        //        #region Facturas

        //        #endregion

        //        #endregion

        //        #region Procura

        //        #region Procura - Factura

        //        case TipoIndicadorQa.ProcuraFacturasHito1:
        //            return queryBase.Where(x =>
        //                x.IdTipoExpediente == IdTipoExpedienteProcura
        //                && !x.EsNofacturable
        //                && !x.FacturacionCompleta
        //                && x.Fin.HasValue
        //                && !x.FacturaSet.Any()
        //            );

        //            #endregion

        //            #endregion
        //    }

        //    return queryBase;
        //}
        
        //public IQueryable<ModelExpedienteToKpi> GetModelExpedienteToKpi(FilterBase filter)
        //{
        //    var tipoIndicadorQa = 1;
        //    var queryBase = ModelExpedienteToKpiSet.FromSqlInterpolated($"EXEC sp_GetModelExpedienteToKpi @TipoIndicadorQa={((int)tipoIndicadorQa)}");

        //    var resultLista = queryBase.ToList();

            

        //    #region Variables y Constantes

        //    //var fechaActualMenos20 = DateTime.Now.AddDays(-20);
        //    //var FechaActualMenos30 = DateTime.Now.AddDays(-30);
        //    //var fechaActualMenos60 = DateTime.Now.AddDays(-60);
        //    //var FechaActualMenos90 = DateTime.Now.AddDays(-90);
        //    //var fechaActualMenos120 = DateTime.Now.AddDays(-120);
        //    //var fechaActualMenos180 = DateTime.Now.AddDays(-180);

        //    #endregion

        //    //var db = this;
        //    //var lstExpedientesParalizado = db.Gnr_TipoEstado.Where(x => x.Paralizado).Select(x => x.IdTipoEstado);
        //    //var lstExpedientesFinalizado = db.Gnr_TipoEstado.Where(x => x.Fin).Select(x => x.IdTipoEstado);

        //    //var queryBase = db.Expedientes.Include(x => x.Gnr_ClienteOficina).AsNoTracking();
        //    //var queryBaseInmueble = db.Hip_Inmueble.Include(x => x.Hip_TipoInmueble).AsNoTracking();

        //    //if (quitarLosResultadosConGestionReciente) //Sin Gestion Reciente
        //    //{
        //    //    queryBase = queryBase.Where(x => !x.ExpedienteNotaSet.Any(y => y.Fecha > FechaActualMenos30));
        //    //}
        //    //if (filter.IsOnOff1.HasValue)
        //    //{
        //    //    if (!filter.IsOnOff1.Value) queryBase = queryBase.Where(x => !x.ExpedienteNotaSet.Any(y => y.Fecha > FechaActualMenos30)); //Sin Gestion Reciente
        //    //    if (filter.IsOnOff1.Value) queryBase = queryBase.Where(x => x.ExpedienteNotaSet.Any(y => y.Fecha > FechaActualMenos30)); //Con Gestion Reciente
        //    //}

        //    //if (filter.IdTipo2.HasValue)
        //    //{
        //    //    queryBase = queryBase.Where(x => x.IdClienteOficina == filter.IdTipo2);
        //    //    queryBaseInmueble = queryBaseInmueble.Where(x => x.IdExpediente.HasValue && x.Expediente.IdClienteOficina == filter.IdTipo2);
        //    //}
        //    //if (filter.IdTipo3.HasValue)
        //    //{
        //    //    queryBase = queryBase.Where(x => x.IdAbogado == filter.IdTipo3);
        //    //    queryBaseInmueble = queryBaseInmueble.Where(x => x.IdExpediente.HasValue && x.Expediente.IdAbogado == filter.IdTipo3);
        //    //}

        //    #region Hipotecarios

        //    //if (filter.IdTipo1 == (int)TipoExpedienteEnum.Hipotecario)
        //    //{
        //    //    result.HipotecarioAlarmaIncidentados = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaIncidentados, queryBase).Count();
        //    //    result.HipotecarioAlarmaAdmisionDemanda = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaAdmisionDemanda, queryBase).Count();
        //    //    result.HipotecarioAlarmaInadmisionDemanda = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaInadmisionDemanda, queryBase).Count();
        //    //    result.HipotecarioAlarmaSucesionCopiaSellada = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaSucesionCopiaSellada, queryBase).Count();
        //    //    result.HipotecarioAlarmaCertificacionCargas = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaCertificacionCargas, queryBase).Count();
        //    //    result.HipotecarioAlarmaRequerimientoPago = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaRequerimientoPago, queryBase).Count();
        //    //    result.HipotecarioAlarmaSolicitudSubasta = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaSolicitudSubasta, queryBase).Count();
        //    //    result.HipotecarioAlarmaDecretoConvocatoria = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaDecretoConvocatoria, queryBase).Count();
        //    //    result.HipotecarioAlarmaDecretoAdjudicacion = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaDecretoAdjudicacion, queryBase).Count();
        //    //    result.HipotecarioAlarmaPosesion = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaPosesion, queryBase).Count();
        //    //    result.HipotecarioAlarmaTestimonio = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaTestimonio, queryBase).Count();
        //    //    result.HipotecarioAlarmaRecepcionSolicitudCierre01 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre01, queryBase).Count();
        //    //    result.HipotecarioAlarmaRecepcionSolicitudCierre02 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre02, queryBase).Count();
        //    //    result.HipotecarioAlarmaRecepcionSolicitudCierre03 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre03, queryBase).Count();
        //    //    result.HipotecarioAlarmaRecepcionSolicitudCierre04 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre04, queryBase).Count();
        //    //    result.HipotecarioAlarmaRecepcionSolicitudCierre05 = GetExpedienteByTipoIndicadorQa(TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre05, queryBase).Count();
        //    //}

        //    #endregion

        //    return queryBase;


        //    //            < div class="row state-overview">
        //    //    @Html.DcvGetIndicadorQaInfo(TipoIndicadorQa.HipotecarioAlarmaIncidentados, Model.HipotecarioAlarmaIncidentados, "yellow", "icon-file-text", null, Model.Filter.ClienteOficinaSelected, Model.Filter.IdUsuario, "col-lg-3", Model.Filter.IdTipoOtro4)
        //    //    @Html.DcvGetIndicadorQaInfo(TipoIndicadorQa.HipotecarioAlarmaAdmisionDemanda, Model.HipotecarioAlarmaAdmisionDemanda, "yellow", "icon-file-text", null, Model.Filter.ClienteOficinaSelected, Model.Filter.IdUsuario, "col-lg-3", Model.Filter.IdTipoOtro4)
        //    //    @Html.DcvGetIndicadorQaInfo(TipoIndicadorQa.HipotecarioAlarmaInadmisionDemanda, Model.HipotecarioAlarmaInadmisionDemanda, "yellow", "icon-file-text", null, Model.Filter.ClienteOficinaSelected, Model.Filter.IdUsuario, "col-lg-3", Model.Filter.IdTipoOtro4)
        //    //    @Html.DcvGetIndicadorQaInfo(TipoIndicadorQa.HipotecarioAlarmaSucesionCopiaSellada, Model.HipotecarioAlarmaSucesionCopiaSellada, "yellow", "icon-legal", null, Model.Filter.ClienteOficinaSelected, Model.Filter.IdUsuario, "col-lg-3", Model.Filter.IdTipoOtro4)
        //    //    @Html.DcvGetIndicadorQaInfo(TipoIndicadorQa.HipotecarioAlarmaCertificacionCargas, Model.HipotecarioAlarmaCertificacionCargas, "blue", "icon-truck", null, Model.Filter.ClienteOficinaSelected, Model.Filter.IdUsuario, "col-lg-3", Model.Filter.IdTipoOtro4)
        //    //    @Html.DcvGetIndicadorQaInfo(TipoIndicadorQa.HipotecarioAlarmaRequerimientoPago, Model.HipotecarioAlarmaRequerimientoPago, "blue", "icon-money", null, Model.Filter.ClienteOficinaSelected, Model.Filter.IdUsuario, "col-lg-3", Model.Filter.IdTipoOtro4)
        //    //    @Html.DcvGetIndicadorQaInfo(TipoIndicadorQa.HipotecarioAlarmaSolicitudSubasta, Model.HipotecarioAlarmaSolicitudSubasta, "blue", "icon-legal", null, Model.Filter.ClienteOficinaSelected, Model.Filter.IdUsuario, "col-lg-3", Model.Filter.IdTipoOtro4)
        //    //    @Html.DcvGetIndicadorQaInfo(TipoIndicadorQa.HipotecarioAlarmaDecretoConvocatoria, Model.HipotecarioAlarmaDecretoConvocatoria, "red", "icon-legal", null, Model.Filter.ClienteOficinaSelected, Model.Filter.IdUsuario, "col-lg-3", Model.Filter.IdTipoOtro4)
        //    //    @Html.DcvGetIndicadorQaInfo(TipoIndicadorQa.HipotecarioAlarmaDecretoAdjudicacion, Model.HipotecarioAlarmaDecretoAdjudicacion, "red", "icon-file", null, Model.Filter.ClienteOficinaSelected, Model.Filter.IdUsuario, "col-lg-3", Model.Filter.IdTipoOtro4)
        //    //    @Html.DcvGetIndicadorQaInfo(TipoIndicadorQa.HipotecarioAlarmaPosesion, Model.HipotecarioAlarmaPosesion, "terques", "icon-bell-alt", null, Model.Filter.ClienteOficinaSelected, Model.Filter.IdUsuario, "col-lg-3", Model.Filter.IdTipoOtro4)
        //    //    @Html.DcvGetIndicadorQaInfo(TipoIndicadorQa.HipotecarioAlarmaTestimonio, Model.HipotecarioAlarmaTestimonio, "terques", "icon-tags", null, Model.Filter.ClienteOficinaSelected, Model.Filter.IdUsuario, "col-lg-3", Model.Filter.IdTipoOtro4)
        //    //</div>

        //    //var guests = primeDbContext.GuestArrivals.FromSqlInterpolated().ToList();

        //    //var guests = FromSqlInterpolated($"GetGuestsForDate '{date}'").ToList();

        //    //await using var connection = Database.GetDbConnection();
        //    //await Database.OpenConnectionAsync();

        //    //var results =
        //    //    await connection
        //    //        .QueryAsync<int>("select id from movies order by id desc");

        //    //return results;
        //}       

        #endregion
    }
}
