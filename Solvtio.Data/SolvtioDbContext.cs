using Microsoft.EntityFrameworkCore;
using Solvtio.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Configuration;

using Solvtio.Models.Mapping;
using System.Linq;
using System.Data.Entity.ModelConfiguration;


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
        public DbSet<Alq_Expediente> Alq_Expedientes { get; set; }
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

        public DbSet<Expediente> Expedientes { get; set; }
        public DbSet<ExpedienteAccion> ExpedienteAccions { get; set; }
        public DbSet<ExpedienteAcreedore> ExpedienteAcreedores { get; set; }
        public DbSet<ExpedienteAlerta> ExpedienteAlertas { get; set; }
        public DbSet<ExpedienteDeudor> ExpedienteDeudors { get; set; }
        //public DbSet<ExpedienteDocumento> ExpedienteDocumentoes { get; set; }
        public DbSet<ExpedienteEstado> ExpedienteEstadoes { get; set; }
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
            //modelBuilder
            //    .Entity<LightsOutSetting>()
            //    .HasData(new LightsOutSetting("BoardSize", "5"));

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

            modelBuilder.Entity<Pagador>()
                .HasMany(p => p.ClienteSet)
                .WithMany(c => c.Pagadores)
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
    }
}
