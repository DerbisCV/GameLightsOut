using Solvtio.Models.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public class ExpedienteEstado : IExpedienteEstado
    {
        #region Constructors

        public ExpedienteEstado()
        {
            CreateBase();
            Con_ExpedienteEstadoLiquidacionLote = new List<Con_ExpedienteEstadoLiquidacionLote>();
            Ejc_ExpedienteEstadoRequerimientoPago = new List<Ejc_ExpedienteEstadoRequerimientoPago>();
            Hip_ExpedienteEstadoProcesoParalizado = new List<Hip_ExpedienteEstadoProcesoParalizado>();
            Hip_ExpedienteEstadoDatoRequerimiento = new List<Hip_ExpedienteEstadoDatoRequerimiento>();
        }

        public ExpedienteEstado(Expediente expediente)
        {
            CreateBase();
            Expediente = expediente;
            IdExpediente = expediente.IdExpediente;
        }

        public ExpedienteEstado(ExpedienteEstadoTipo tipoExpEstado, string usuario)
        {
            CreateBase();
            IdTipoEstado = (int)tipoExpEstado;
            Usuario = usuario;

            CreateEntityByType(tipoExpEstado);
        }

        private void CreateBase()
        {
            Observacion = "";
            Fecha = FechaAlta = DateTime.Now;
            FechaModificado = DateTime.Now;
        }

        private void CreateEntityByType(ExpedienteEstadoTipo tipoExpEstado)
        {
            switch (tipoExpEstado)
            {
                #region Hipotecarios

                case ExpedienteEstadoTipo.RecepcionExpediente:
                    Hip_ExpedienteEstadoRecepcion = new HipExpedienteEstadoRecepcion();
                    break;
                case ExpedienteEstadoTipo.HipotecarioGeneracionExpediente:
                    HipExpedienteEstadoGeneracion = new HipExpedienteEstadoGeneracion();
                    break;
                case ExpedienteEstadoTipo.HipotecarioPresentacionDemanda:
                    Hip_ExpedienteEstadoPresentacionDemanda = new HipExpedienteEstadoPresentacionDemanda();
                    break;
                case ExpedienteEstadoTipo.HipotecarioTramitacionSubasta:
                    break;
                case ExpedienteEstadoTipo.HipotecarioParalizado:
                    break;
                case ExpedienteEstadoTipo.HipotecarioSubasta:
                    break;
                case ExpedienteEstadoTipo.HipotecarioFinalizado:
                    break;
                case ExpedienteEstadoTipo.AlquilerRecepcionExpediente:
                    break;
                case ExpedienteEstadoTipo.AlquilerGeneracionExpediente:
                    break;
                case ExpedienteEstadoTipo.AlquilerPresentacionDemanda:
                    break;
                case ExpedienteEstadoTipo.AlquilerTramitacionJuzgado:
                    break;
                case ExpedienteEstadoTipo.AlquilerLanzamiento:
                    break;
                case ExpedienteEstadoTipo.AlquilerAdjudicacionBien:
                    break;
                case ExpedienteEstadoTipo.AlquilerFinalizado:
                    break;
                case ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien:
                    break;
                case ExpedienteEstadoTipo.HipotecarioNegociacionPosesion:
                    break;

                #endregion

                #region Ejecutivo

                case ExpedienteEstadoTipo.EjecutivoRecepcionExpediente:
                    Ejc_ExpedienteEstadoRecepcion = new Ejc_ExpedienteEstadoRecepcion();
                    break;

                case ExpedienteEstadoTipo.EjecutivoEnvioDemandaProcurador:
                    EjcExpedienteEstadoEnvioDemandaProcurador = new EjcExpedienteEstadoEnvioDemandaProcurador();
                    break;
                case ExpedienteEstadoTipo.EjecutivoPresentacionDemanda:
                    Ejc_ExpedienteEstadoPresentacionDemanda = new Ejc_ExpedienteEstadoPresentacionDemanda();
                    break;
                case ExpedienteEstadoTipo.EjecutivoAdmisionTramiteEmbargo:
                    break;
                case ExpedienteEstadoTipo.EjecutivoTramiteEmbargo:
                    break;
                case ExpedienteEstadoTipo.EjecutivoEfectividadEmbargo:
                    break;
                case ExpedienteEstadoTipo.EjecutivoSolicitudSubasta:
                    break;
                case ExpedienteEstadoTipo.EjecutivoSubasta:
                    break;
                case ExpedienteEstadoTipo.EjecutivoAdjudicacionBien:
                    break;
                case ExpedienteEstadoTipo.EjecutivoFinalizacion:
                    break;

                #endregion

                #region Ordinario

                case ExpedienteEstadoTipo.OrdinarioRecepcionExpediente:
                    ExpedienteEstadoOrdinarioRecepcion = new ExpedienteEstadoOrdinarioRecepcion();
                    break;
                case ExpedienteEstadoTipo.OrdinarioPresentacionDemanda:
                    ExpedienteEstadoOrdinarioPresentacionDemanda = new ExpedienteEstadoOrdinarioPresentacionDemanda();
                    break;
                case ExpedienteEstadoTipo.OrdinarioGeneracionExpediente:
                    break;
                case ExpedienteEstadoTipo.OrdinarioTramitacionJuzgado:
                    break;
                case ExpedienteEstadoTipo.OrdinarioJuicio:
                    break;
                case ExpedienteEstadoTipo.OrdinarioEjecucionSentencia:
                    break;
                case ExpedienteEstadoTipo.OrdinarioAutoAdmisionNotificacion:
                    break;
                case ExpedienteEstadoTipo.OrdinarioProcesoParalizado:
                    break;
                case ExpedienteEstadoTipo.OrdinarioSubasta:
                    break;
                case ExpedienteEstadoTipo.OrdinarioAdjudicacionDelBien:
                    break;
                case ExpedienteEstadoTipo.OrdinarioNegociacionPosesion:
                    break;
                case ExpedienteEstadoTipo.OrdinarioFinalizacion:
                    break;

                #endregion

                #region OrdinarioCs

                case ExpedienteEstadoTipo.OrdinarioCsRecepcionExpediente:
                    ExpedienteEstadoOrdinarioCsRecepcion = new ExpedienteEstadoOrdinarioCsRecepcion();
                    break;
                //case ExpedienteEstadoTipo.OrdinarioCsGeneracionExpediente:
                //    break;
                case ExpedienteEstadoTipo.OrdinarioCsAudienciaPrevia:
                    ExpedienteEstadoOrdinarioCsPresentacionDemanda = new ExpedienteEstadoOrdinarioCsAudienciaPrevia();
                    break;
                //case ExpedienteEstadoTipo.OrdinarioCsTramitacionJuzgado:
                //    break;
                case ExpedienteEstadoTipo.OrdinarioCsJuicio:
                    break;
                //case ExpedienteEstadoTipo.OrdinarioCsEjecucionSentencia:
                //    break;
                //case ExpedienteEstadoTipo.OrdinarioCsAutoAdmisionNotificacion:
                //    break;
                case ExpedienteEstadoTipo.OrdinarioCsProcesoParalizado:
                    break;
                //case ExpedienteEstadoTipo.OrdinarioCsSubasta:
                //    break;
                //case ExpedienteEstadoTipo.OrdinarioCsAdjudicacionDelBien:
                //    break;
                //case ExpedienteEstadoTipo.OrdinarioCsNegociacionPosesion:
                //    break;
                case ExpedienteEstadoTipo.OrdinarioCsFinalizacion:
                    break;

                #endregion

                #region Neg

                case ExpedienteEstadoTipo.NegociacionPendienteTelefono:
                    break;
                case ExpedienteEstadoTipo.NegociacionPdteContacto:
                    break;
                case ExpedienteEstadoTipo.NegociacionTelefonoErroneo:
                    break;
                case ExpedienteEstadoTipo.NegociacionEnTramitePdtePropuesta:
                    break;
                case ExpedienteEstadoTipo.NegociacionEnTramiteRehabilitacion:
                    break;
                case ExpedienteEstadoTipo.NegociacionEnTramiteAdecuacion:
                    break;
                case ExpedienteEstadoTipo.NegociacionEnTramiteAdecuacionSostenible:
                    break;
                case ExpedienteEstadoTipo.NegociacionEnTramiteCancelacion:
                    break;
                case ExpedienteEstadoTipo.NegociacionEnTramiteCancelConQuita:
                    break;
                case ExpedienteEstadoTipo.NegociacionEnTramiteVenta:
                    break;
                case ExpedienteEstadoTipo.NegociacionEnTramitePropElevada:
                    break;
                case ExpedienteEstadoTipo.NegociacionEnTramiteDacionPago:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalRehabilitacion:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalAdecuacion:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalAdecuacionSostenible:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalCancelacion:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalCancelConquita:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalVenta:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalDacionenPago:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalInviable:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalDesistidoParal:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalSubasta:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalVendidoaFondo:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalFinalizadoPropuestaDenegada:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalFinalizadoPropuestaAceptada:
                    break;
                case ExpedienteEstadoTipo.NegociacionPagoParcial:
                    break;
                case ExpedienteEstadoTipo.NegociacionPagoTotal:
                    break;
                case ExpedienteEstadoTipo.NegociacionCondonacionParcial:
                    break;
                case ExpedienteEstadoTipo.NegociacionCondonacionTotal:
                    break;
                case ExpedienteEstadoTipo.NegociacionDeudaPagadaParcial:
                    break;
                case ExpedienteEstadoTipo.NegociacionDeudaPagadaTotal:
                    break;
                case ExpedienteEstadoTipo.NegociacionEntregadelInmueble:
                    break;
                case ExpedienteEstadoTipo.NegociacionFinalizadoVulnerabilidadSocial:
                    break;
                case ExpedienteEstadoTipo.NegociacionFinalizadoDemanda:
                    break;
                case ExpedienteEstadoTipo.NegociacionFinalizadoInviable:
                    break;
                case ExpedienteEstadoTipo.NegociacionFinalizadoPagoDeuda:
                    break;
                case ExpedienteEstadoTipo.NegociacionFinalizadoFinTiempoNeg:
                    break;

                #endregion

                #region Alquiler

                case ExpedienteEstadoTipo.AlquilerEnervacion:
                    break;
                case ExpedienteEstadoTipo.AlquilerParalizado:
                    break;

                #endregion

                #region Concursal

                //case ExpedienteEstadoTipo.ConcursalFaseComun:
                //    break;
                //case ExpedienteEstadoTipo.ConcursalFaseConvenio:
                //    break;
                //case ExpedienteEstadoTipo.ConcursalFaseLiquidacion:
                //    break;
                //case ExpedienteEstadoTipo.ConcursalFaseCalificacion:
                //    break;

                case ExpedienteEstadoTipo.ConcursalFaseComun:
                    if (Con_ExpedienteEstadoComun == null)
                        Con_ExpedienteEstadoComun = new Con_ExpedienteEstadoComun();
                    break;
                case ExpedienteEstadoTipo.ConcursalFaseConvenio:
                    if (Con_ExpedienteEstadoConvenio == null)
                        Con_ExpedienteEstadoConvenio = new Con_ExpedienteEstadoConvenio();
                    break;

                case ExpedienteEstadoTipo.ConcursalFaseLiquidacion:
                    if (Con_ExpedienteEstadoLiquidacion == null)
                        Con_ExpedienteEstadoLiquidacion = new Con_ExpedienteEstadoLiquidacion();
                    break;
                case ExpedienteEstadoTipo.ConcursalFinalizado:
                    if (Con_ExpedienteEstadoFinalizado == null)
                        Con_ExpedienteEstadoFinalizado = new Con_ExpedienteEstadoFinalizado();
                    break;

                #endregion

                #region TPA

                case ExpedienteEstadoTipo.TpaRecepcionExpediente:
                    break;
                case ExpedienteEstadoTipo.TpaFinalizado:
                    break;

                #endregion

                #region JV

                case ExpedienteEstadoTipo.JvRecepcionExpediente:
                    JvExpedienteEstadoRecepcion = new JvExpedienteEstadoRecepcion();
                    break;
                case ExpedienteEstadoTipo.JvPresentacionDemanda:
                    JvExpedienteEstadoPresentacionDemanda = new JvExpedienteEstadoPresentacionDemanda();
                    break;

                case ExpedienteEstadoTipo.JvFinalizado:
                    break;

                #endregion

                #region Monitorio

                case ExpedienteEstadoTipo.MonitorioRecepcionExpediente:
                    ExpedienteEstadoMonitorioRecepcion = new ExpedienteEstadoMonitorioRecepcion();
                    break;
                case ExpedienteEstadoTipo.MonitorioPresentacionDemanda:
                    ExpedienteEstadoMonitorioPresentacionDemanda = new ExpedienteEstadoMonitorioPresentacionDemanda();
                    break;

                case ExpedienteEstadoTipo.MonitorioFinalizacion:
                    break;

                #endregion

                #region Verbal

                case ExpedienteEstadoTipo.VerbalRecepcionExpediente:
                    ExpedienteEstadoVerbalRecepcion = new ExpedienteEstadoVerbalRecepcion();
                    break;
                case ExpedienteEstadoTipo.VerbalPresentacionDemanda:
                    ExpedienteEstadoVerbalPresentacionDemanda = new ExpedienteEstadoVerbalPresentacionDemanda();
                    break;

                case ExpedienteEstadoTipo.VerbalFinalizacion:
                    break;

                #endregion

                #region Saneamiento

                case ExpedienteEstadoTipo.SaneamientoRecepcionExpediente:
                    ExpedienteEstadoSaneamientoRecepcion = new ExpedienteEstadoSaneamientoRecepcion();
                    break;
                //case ExpedienteEstadoTipo.SaneamientoPresentacionDemanda:
                //    ExpedienteEstadoSaneamientoPresentacionDemanda = new ExpedienteEstadoSaneamientoPresentacionDemanda();
                //    break;

                case ExpedienteEstadoTipo.SaneamientoFinalizacion:
                    ExpedienteEstadoSaneamientoFinalizacion = new ExpedienteEstadoSaneamientoFinalizacion();
                    break;

                #endregion

                #region Penal

                case ExpedienteEstadoTipo.PenalRecepcionExpediente:
                    ExpedienteEstadoPenalRecepcion = new ExpedienteEstadoPenalRecepcion();
                    break;

                case ExpedienteEstadoTipo.PenalFinalizacion:
                    ExpedienteEstadoPenalFinalizacion = new ExpedienteEstadoPenalFinalizacion();
                    break;

                case ExpedienteEstadoTipo.PenalInstruccion:
                    ExpedienteEstadoPenal = new ExpedienteEstadoPenal();
                    break;

                case ExpedienteEstadoTipo.PenalIntermedio:
                    ExpedienteEstadoPenal = new ExpedienteEstadoPenal();
                    break;
                case ExpedienteEstadoTipo.PenalJuicio:
                    break;
                case ExpedienteEstadoTipo.PenalRecurso:
                    ExpedienteEstadoPenal = new ExpedienteEstadoPenal();
                    break;
                case ExpedienteEstadoTipo.PenalSentencia:
                    ExpedienteEstadoPenal = new ExpedienteEstadoPenal();
                    break;
                case ExpedienteEstadoTipo.PenalEjecucion:
                    ExpedienteEstadoPenal = new ExpedienteEstadoPenal();
                    break;
                case ExpedienteEstadoTipo.PenalExpedientePenitenciario:
                    ExpedienteEstadoPenal = new ExpedienteEstadoPenal();
                    break;

                #endregion

                #region Fiscal

                case ExpedienteEstadoTipo.FiscalRecepcionExpediente:
                    ExpedienteEstadoFiscalRecepcion = new ExpedienteEstadoFiscalRecepcion();
                    break;

                case ExpedienteEstadoTipo.FiscalFinalizacion:
                    ExpedienteEstadoFiscalFinalizacion = new ExpedienteEstadoFiscalFinalizacion();
                    break;

                #endregion

                #region Conciliacion

                case ExpedienteEstadoTipo.ConciliacionRecepcionExpediente:
                    ExpedienteEstadoConciliacionRecepcion = new ExpedienteEstadoConciliacionRecepcion();
                    break;
                //case ExpedienteEstadoTipo.ConciliacionPresentacionDemanda:
                //    ExpedienteEstadoConciliacionPresentacionDemanda = new ExpedienteEstadoConciliacionPresentacionDemanda();
                //    break;

                case ExpedienteEstadoTipo.ConciliacionFinalizacion:
                    ExpedienteEstadoConciliacionFinalizacion = new ExpedienteEstadoConciliacionFinalizacion();
                    break;

                #endregion

                #region JuraCuenta

                case ExpedienteEstadoTipo.JuraCuentaRecepcionExpediente:
                    ExpedienteEstadoJuraCuentaRecepcion = new ExpedienteEstadoJuraCuentaRecepcion();
                    break;

                case ExpedienteEstadoTipo.JuraCuentaFinalizacion:
                    ExpedienteEstadoJuraCuentaFinalizacion = new ExpedienteEstadoJuraCuentaFinalizacion();
                    break;

                case ExpedienteEstadoTipo.JuraCuentaTramitacion:
                    ExpedienteEstadoJuraCuentaTramitacion = new ExpedienteEstadoJuraCuentaTramitacion();
                    break;

                #endregion

                #region Civil

                case ExpedienteEstadoTipo.CivilRecepcionExpediente:
                    ExpedienteEstadoCivilRecepcion = new ExpedienteEstadoCivilRecepcion();
                    break;
                //case ExpedienteEstadoTipo.CivilPresentacionDemanda:
                //    ExpedienteEstadoCivilPresentacionDemanda = new ExpedienteEstadoCivilPresentacionDemanda();
                //    break;

                case ExpedienteEstadoTipo.CivilFinalizacion:
                    ExpedienteEstadoCivilFinalizacion = new ExpedienteEstadoCivilFinalizacion();
                    break;

                #endregion

                #region MercantilInmobiliario

                case ExpedienteEstadoTipo.MercantilInmobiliarioRecepcionExpediente:
                    ExpedienteEstadoMercantilInmobiliarioRecepcion = new ExpedienteEstadoMercantilInmobiliarioRecepcion();
                    break;

                case ExpedienteEstadoTipo.MercantilInmobiliarioFinalizacion:
                    ExpedienteEstadoMercantilInmobiliarioFinalizacion = new ExpedienteEstadoMercantilInmobiliarioFinalizacion();
                    break;

                #endregion

                #region Ddl

                case ExpedienteEstadoTipo.DdlRecepcionExpediente:
                    ExpedienteEstadoDdlRecepcion = new ExpedienteEstadoDdlRecepcion();
                    break;

                case ExpedienteEstadoTipo.DdlFinalizacion:
                    ExpedienteEstadoDdlFinalizacion = new ExpedienteEstadoDdlFinalizacion();
                    break;

                #endregion

                #region ContenciosoAdministrativo

                case ExpedienteEstadoTipo.ContenciosoAdministrativoRecepcionExpediente:
                    ExpedienteEstadoContenciosoAdministrativoRecepcion = new ExpedienteEstadoContenciosoAdministrativoRecepcion();
                    break;

                case ExpedienteEstadoTipo.ContenciosoAdministrativoFinalizacion:
                    ExpedienteEstadoContenciosoAdministrativoFinalizacion = new ExpedienteEstadoContenciosoAdministrativoFinalizacion();
                    break;

                #endregion

                #region ContenciosoOrdinario

                case ExpedienteEstadoTipo.ContenciosoOrdinarioRecepcionExpediente:
                    ExpedienteEstadoContenciosoOrdinarioRecepcion = new ExpedienteEstadoContenciosoOrdinarioRecepcion();
                    break;

                case ExpedienteEstadoTipo.ContenciosoOrdinarioFinalizacion:
                    ExpedienteEstadoContenciosoOrdinarioFinalizacion = new ExpedienteEstadoContenciosoOrdinarioFinalizacion();
                    break;

                #endregion

                #region Cambiario

                case ExpedienteEstadoTipo.CambiarioRecepcionExpediente:
                    ExpedienteEstadoCambiarioRecepcion = new ExpedienteEstadoCambiarioRecepcion();
                    break;

                case ExpedienteEstadoTipo.CambiarioFinalizacion:
                    ExpedienteEstadoCambiarioFinalizacion = new ExpedienteEstadoCambiarioFinalizacion();
                    break;

                #endregion

                #region Verbal

                case ExpedienteEstadoTipo.MultiDivisaRecepcionExpediente:
                    ExpedienteEstadoMDRecepcion = new ExpedienteEstadoMDRecepcion();
                    break;
                //case ExpedienteEstadoTipo.MultiDivisaPresentacionDemanda:
                //    ExpedienteEstadoMultiDivisaPresentacionDemanda = new ExpedienteEstadoMultiDivisaPresentacionDemanda();
                //    break;

                case ExpedienteEstadoTipo.MultiDivisaFinalizacion:
                    break;

                #endregion

                #region Scne (Nothing)

                case ExpedienteEstadoTipo.ScneRecepcionExpediente:
                    break;
                case ExpedienteEstadoTipo.ScneFinalizacion:
                    break;

                #endregion

                #region Bastanteo

                case ExpedienteEstadoTipo.BastanteoRecepcionExpediente:
                    ExpedienteEstadoBastanteoRecepcion = new ExpedienteEstadoBastanteoRecepcion();
                    break;

                case ExpedienteEstadoTipo.BastanteoFinalizacion:
                    ExpedienteEstadoBastanteoFinalizacion = new ExpedienteEstadoBastanteoFinalizacion();
                    break;

                #endregion

                #region Prelitigio

                case ExpedienteEstadoTipo.PrelitigioRecepcionExpediente:
                    ExpedienteEstadoPrelitigioRecepcion = new ExpedienteEstadoPrelitigioRecepcion();
                    break;

                case ExpedienteEstadoTipo.PrelitigioFinalizacion:
                    ExpedienteEstadoPrelitigioFinalizacion = new ExpedienteEstadoPrelitigioFinalizacion();
                    break;

                #endregion

                #region Testamentario

                case ExpedienteEstadoTipo.TestamentarioRecepcionExpediente:
                    ExpedienteEstadoTestamentarioRecepcion = new ExpedienteEstadoTestamentarioRecepcion();
                    break;

                case ExpedienteEstadoTipo.TestamentarioFinalizacion:
                    ExpedienteEstadoTestamentarioFinalizacion = new ExpedienteEstadoTestamentarioFinalizacion();
                    break;

                #endregion

                #region Tpn

                case ExpedienteEstadoTipo.TpnRecepcionExpediente:
                    ExpedienteEstadoTpnRecepcion = new ExpedienteEstadoTpnRecepcion();
                    break;

                case ExpedienteEstadoTipo.TpnFinalizacion:
                    ExpedienteEstadoTpnFinalizacion = new ExpedienteEstadoTpnFinalizacion();
                    break;

                #endregion

                default:
                    throw new ArgumentOutOfRangeException("tipoExpEstado");
            }
        }

        public string FaseEstadoGetDescription()
        {
            if (!IdTipoSubFaseEstado.HasValue) return string.Empty;

            try
            {
                return TipoSubFaseEstado.Nombre;
            }
            catch { return "¿?"; }
        }

        #endregion

        #region Properties

        public int ExpedienteEstadoId { get; set; }

        [Index("IX_ExpedienteFecha", 1)]
        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }
        

        [Index("IX_IdTipoEstadoAndIdAbogado", 1)]
        [Index]
        public int IdTipoEstado { get; set; }
        [ForeignKey("IdTipoEstado")]
        public virtual Gnr_TipoEstado Gnr_TipoEstado { get; set; }

        [Index("IX_ExpedienteFecha", 2)]
        public DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public string Usuario { get; set; }

        public DateTime FechaAlta { get; set; }
        public DateTime? FechaModificado { get; set; }

        public DateTime? FechaFin { get; set; }

        [Index("IX_EstadoIdSiguiente")]
        public int? ExpedienteEstadoIdSiguiente { get; set; }

        [Index("IX_IdTipoEstadoAndIdAbogado", 2)]
        public int? IdAbogado { get; set; }
        //[ForeignKey("IdAbogado")]
        //public virtual Gnr_Abogado Abogado { get; set; }

        public int? IdAbogado2 { get; set; }
        //
        //public virtual Gnr_Abogado Abogado2 { get; set; }

        public TipoFaseEstado? FaseEstado { get; set; }

        public int? IdTipoSubFaseEstado { get; set; }
        [ForeignKey("IdTipoSubFaseEstado")]
        public virtual TipoSubFaseEstado TipoSubFaseEstado { get; set; }

        public int? IdTipoSubFaseCliente { get; set; }
        [ForeignKey("IdTipoSubFaseCliente")]
        public virtual CaracteristicaBase TipoSubFaseCliente { get; set; }

        public int? IdTipoIncidenciaEstado { get; set; }
        [ForeignKey("IdTipoIncidenciaEstado")]
        public virtual TipoIncidenciaEstado TipoIncidenciaEstado { get; set; }

        public DateTime? IncidenciaFechaResolucion { get; set; }

        public int TimeWorkedMinutes { get; set; }

        #endregion

        #region  virtual

        #region ExpedienteEstado Comun

        public virtual ICollection<ExpedienteEstadoCitacion> ExpedienteEstadoCitacionSet { get; set; }
        //public virtual ICollection<ExpedienteParalizado> ExpedienteParalizadoSet { get; set; }

        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoParalizado ExpedienteEstadoParalizado { get; set; }

        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoJurisdiccionVoluntaria ExpedienteEstadoJurisdiccionVoluntaria { get; set; }

        #endregion

        #region Hip_ExpedienteEstado

        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual HipExpedienteEstadoRecepcion Hip_ExpedienteEstadoRecepcion { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual HipExpedienteEstadoGeneracion HipExpedienteEstadoGeneracion { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual Hip_ExpedienteEstadoAdjudicacion Hip_ExpedienteEstadoAdjudicacion { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual HipExpedienteEstadoPresentacionDemanda Hip_ExpedienteEstadoPresentacionDemanda { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual HipExpedienteEstadoTramitacionSubasta HipExpedienteEstadoTramitacionSubasta { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual Hip_ExpedienteEstadoFinalizacion Hip_ExpedienteEstadoFinalizacion { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual Hip_ExpedienteEstadoNegociacionPosesion Hip_ExpedienteEstadoNegociacionPosesion { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual Hip_ExpedienteEstadoSubasta Hip_ExpedienteEstadoSubasta { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ICollection<Hip_ExpedienteEstadoAdjudicacionVencimiento> Hip_ExpedienteEstadoAdjudicacionVencimientoSet { get; set; }

        #endregion

        #region ExpedienteEstadoOrdinario

        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioRecepcion ExpedienteEstadoOrdinarioRecepcion { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioPresentacionDemanda ExpedienteEstadoOrdinarioPresentacionDemanda { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioTramitacionJuzgado ExpedienteEstadoOrdinarioTramitacionJuzgado { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioProcesoParalizado ExpedienteEstadoOrdinarioProcesoParalizado { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioSubasta ExpedienteEstadoOrdinarioSubasta { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioAdjudicacion ExpedienteEstadoOrdinarioAdjudicacion { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioNegociacionPosesion ExpedienteEstadoOrdinarioNegociacionPosesion { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioFinalizacion ExpedienteEstadoOrdinarioFinalizacion { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioJuicio ExpedienteEstadoOrdinarioJuicio { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioAutoAdmisionNotificacion ExpedienteEstadoOrdinarioAutoAdmisionNotificacion { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioEjecucionSentencia ExpedienteEstadoOrdinarioEjecucionSentencia { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioSentencia ExpedienteEstadoOrdinarioSentencia { get; set; }
        //

        #endregion

        #region ExpedienteEstadoOrdinarioCs 

        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioCsRecepcion ExpedienteEstadoOrdinarioCsRecepcion { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioCsAudienciaPrevia ExpedienteEstadoOrdinarioCsPresentacionDemanda { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioCsTramitacionJuzgado ExpedienteEstadoOrdinarioCsTramitacionJuzgado { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioCsProcesoParalizado ExpedienteEstadoOrdinarioCsProcesoParalizado { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioCsSubasta ExpedienteEstadoOrdinarioCsSubasta { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioCsAdjudicacion ExpedienteEstadoOrdinarioCsAdjudicacion { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioCsNegociacionPosesion ExpedienteEstadoOrdinarioCsNegociacionPosesion { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioCsFinalizacion ExpedienteEstadoOrdinarioCsFinalizacion { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioCsJuicio ExpedienteEstadoOrdinarioCsJuicio { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioCsAutoAdmisionNotificacion ExpedienteEstadoOrdinarioCsAutoAdmisionNotificacion { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioCsEjecucionSentencia ExpedienteEstadoOrdinarioCsEjecucionSentencia { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioCsSentencia ExpedienteEstadoOrdinarioCsSentencia { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioCsAllanamientoTotal ExpedienteEstadoOrdinarioCsAllanamientoTotal { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioCsAllanamientoParcial ExpedienteEstadoOrdinarioCsAllanamientoParcial { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioCsAcuerdo ExpedienteEstadoOrdinarioCsAcuerdo { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoOrdinarioCsContestacionDemanda ExpedienteEstadoOrdinarioCsContestacionDemanda { get; set; }

        #endregion

        #region ExpedienteEstadoEjecutivo

        public virtual Ejc_ExpedienteEstadoAdjudicacion Ejc_ExpedienteEstadoAdjudicacion { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual Ejc_ExpedienteEstadoEfectividadEmbargo Ejc_ExpedienteEstadoEfectividadEmbargo { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual Ejc_ExpedienteEstadoFinalizacion Ejc_ExpedienteEstadoFinalizacion { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual Ejc_ExpedienteEstadoNotificacion Ejc_ExpedienteEstadoNotificacion { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual Ejc_ExpedienteEstadoPresentacionDemanda Ejc_ExpedienteEstadoPresentacionDemanda { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual Ejc_ExpedienteEstadoRecepcion Ejc_ExpedienteEstadoRecepcion { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual Ejc_ExpedienteEstadoSolicitudSubasta Ejc_ExpedienteEstadoSolicitudSubasta { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual Ejc_ExpedienteEstadoSubasta Ejc_ExpedienteEstadoSubasta { get; set; }
        // // [ForeignKey("ExpedienteEstadoId")]
        public virtual Ejc_ExpedienteEstadoTramiteEmbargo Ejc_ExpedienteEstadoTramiteEmbargo { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual EjcExpedienteEstadoEnvioDemandaProcurador EjcExpedienteEstadoEnvioDemandaProcurador { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual EjcExpedienteEstadoPresentacionEscrito579 EjcExpedienteEstadoPresentacionEscrito579 { get; set; }

        #endregion

        #region JV

        // [ForeignKey("ExpedienteEstadoId")]
        public virtual JvExpedienteEstadoRecepcion JvExpedienteEstadoRecepcion { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual JvExpedienteEstadoPresentacionDemanda JvExpedienteEstadoPresentacionDemanda { get; set; }

        #endregion

        #region ExpedienteEstadoMonitorio

        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoMonitorioRecepcion ExpedienteEstadoMonitorioRecepcion { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoMonitorioPresentacionDemanda ExpedienteEstadoMonitorioPresentacionDemanda { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoMonitorioTramitacionJuzgado ExpedienteEstadoMonitorioTramitacionJuzgado { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoMonitorioFinalizacion ExpedienteEstadoMonitorioFinalizacion { get; set; }

        #endregion

        #region ExpedienteEstadoVerbal

        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoVerbalRecepcion ExpedienteEstadoVerbalRecepcion { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoVerbalPresentacionDemanda ExpedienteEstadoVerbalPresentacionDemanda { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoVerbalTramitacionJuzgado ExpedienteEstadoVerbalTramitacionJuzgado { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoVerbalFinalizacion ExpedienteEstadoVerbalFinalizacion { get; set; }

        #endregion

        #region ExpedienteEstadoSaneamiento

        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoSaneamientoRecepcion ExpedienteEstadoSaneamientoRecepcion { get; set; }
        //public virtual ExpedienteEstadoSaneamientoPresentacionDemanda ExpedienteEstadoSaneamientoPresentacionDemanda { get; set; }
        //public virtual ExpedienteEstadoSaneamientoTramitacionJuzgado ExpedienteEstadoSaneamientoTramitacionJuzgado { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoSaneamientoFinalizacion ExpedienteEstadoSaneamientoFinalizacion { get; set; }

        #endregion

        #region ExpedienteEstadoCivil

        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoCivilRecepcion ExpedienteEstadoCivilRecepcion { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoCivilFinalizacion ExpedienteEstadoCivilFinalizacion { get; set; }

        #endregion

        #region ExpedienteEstadoPenal

        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoPenalRecepcion ExpedienteEstadoPenalRecepcion { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoPenalFinalizacion ExpedienteEstadoPenalFinalizacion { get; set; }
        
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoPenal ExpedienteEstadoPenal { get; set; }

        #endregion

        #region Alquiler 

        // [ForeignKey("ExpedienteEstadoId")]
        public virtual Alq_Expediente_EstadoAdjudicacion Alq_Expediente_EstadoAdjudicacion { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual Alq_Expediente_EstadoFinalizacion Alq_Expediente_EstadoFinalizacion { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual Alq_Expediente_EstadoLanzamiento Alq_Expediente_EstadoLanzamiento { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual Alq_Expediente_EstadoPresentacionDemanda Alq_Expediente_EstadoPresentacionDemanda { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual Alq_Expediente_EstadoRecepcion Alq_Expediente_EstadoRecepcion { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual Alq_Expediente_EstadoTramitaJuzgado Alq_Expediente_EstadoTramitaJuzgado { get; set; }
        //// [ForeignKey("ExpedienteEstadoId")]
        public virtual AlqExpedienteEstadoEnervacion AlqExpedienteEstadoEnervacion { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual AlqExpedienteEstadoProcesoParalizado AlqExpedienteEstadoProcesoParalizado { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual AlqExpedienteEstadoPresentacionDenuncia AlqExpedienteEstadoPresentacionDenuncia { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual AlqExpedienteEstadoTramitacionDenuncia AlqExpedienteEstadoTramitacionDenuncia { get; set; }

        #endregion

        #region Concursal

        // [ForeignKey("ExpedienteEstadoId")]
        public virtual Con_ExpedienteEstadoComun Con_ExpedienteEstadoComun { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual Con_ExpedienteEstadoConvenio Con_ExpedienteEstadoConvenio { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual Con_ExpedienteEstadoFinalizado Con_ExpedienteEstadoFinalizado { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual Con_ExpedienteEstadoLiquidacion Con_ExpedienteEstadoLiquidacion { get; set; }

        #endregion

        #region Conciliacion

        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoConciliacionRecepcion ExpedienteEstadoConciliacionRecepcion { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoConciliacionFinalizacion ExpedienteEstadoConciliacionFinalizacion { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoConciliacionActo ExpedienteEstadoConciliacionActo { get; set; }

        #endregion

        #region JuraCuenta

        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoJuraCuentaRecepcion ExpedienteEstadoJuraCuentaRecepcion { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoJuraCuentaFinalizacion ExpedienteEstadoJuraCuentaFinalizacion { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoJuraCuentaTramitacion ExpedienteEstadoJuraCuentaTramitacion { get; set; }

        #endregion

        #region MercantilInmobiliario

        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoMercantilInmobiliarioRecepcion ExpedienteEstadoMercantilInmobiliarioRecepcion { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoMercantilInmobiliarioFinalizacion ExpedienteEstadoMercantilInmobiliarioFinalizacion { get; set; }

        #endregion

        #region Ddl

        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoDdlRecepcion ExpedienteEstadoDdlRecepcion { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoDdlFinalizacion ExpedienteEstadoDdlFinalizacion { get; set; }

        #endregion

        #region ContenciosoAdministrativo

        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoContenciosoAdministrativoRecepcion ExpedienteEstadoContenciosoAdministrativoRecepcion { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoContenciosoAdministrativoFinalizacion ExpedienteEstadoContenciosoAdministrativoFinalizacion { get; set; }

        #endregion

        #region ContenciosoOrdinario

        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoContenciosoOrdinarioRecepcion ExpedienteEstadoContenciosoOrdinarioRecepcion { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoContenciosoOrdinarioFinalizacion ExpedienteEstadoContenciosoOrdinarioFinalizacion { get; set; }

        #endregion

        #region Cambiario

        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoCambiarioRecepcion ExpedienteEstadoCambiarioRecepcion { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoCambiarioFinalizacion ExpedienteEstadoCambiarioFinalizacion { get; set; }

        #endregion

        #region Fiscal

        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoFiscalRecepcion ExpedienteEstadoFiscalRecepcion { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoFiscalFinalizacion ExpedienteEstadoFiscalFinalizacion { get; set; }

        #endregion

        #region ExpedienteEstadoMultiDivisa

        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoMDRecepcion ExpedienteEstadoMDRecepcion { get; set; }

        //public virtual ExpedienteEstadoMultiDivisaPresentacionDemanda ExpedienteEstadoMultiDivisaPresentacionDemanda { get; set; }
        //public virtual ExpedienteEstadoMultiDivisaTramitacionJuzgado ExpedienteEstadoMultiDivisaTramitacionJuzgado { get; set; }
        //public virtual ExpedienteEstadoMultiDivisaFinalizacion ExpedienteEstadoMultiDivisaFinalizacion { get; set; }

        #endregion

        #region Bastanteo

        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoBastanteoRecepcion ExpedienteEstadoBastanteoRecepcion { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoBastanteoFinalizacion ExpedienteEstadoBastanteoFinalizacion { get; set; }

        #endregion

        #region Prelitigio

        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoPrelitigioRecepcion ExpedienteEstadoPrelitigioRecepcion { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoPrelitigioFinalizacion ExpedienteEstadoPrelitigioFinalizacion { get; set; }

        #endregion

        #region Testamentario

        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoTestamentarioRecepcion ExpedienteEstadoTestamentarioRecepcion { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoTestamentarioFinalizacion ExpedienteEstadoTestamentarioFinalizacion { get; set; }

        #endregion

        #region Tpn

        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoTpnRecepcion ExpedienteEstadoTpnRecepcion { get; set; }
        // [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstadoTpnFinalizacion ExpedienteEstadoTpnFinalizacion { get; set; }

        #endregion

        #endregion

        #region  virtual ICollection<T>

        public virtual ICollection<Con_ExpedienteEstadoLiquidacionLote> Con_ExpedienteEstadoLiquidacionLote { get; set; }
        public virtual ICollection<Ejc_ExpedienteEstadoRequerimientoPago> Ejc_ExpedienteEstadoRequerimientoPago { get; set; }
        public virtual ICollection<Hip_ExpedienteEstadoProcesoParalizado> Hip_ExpedienteEstadoProcesoParalizado { get; set; }
        public virtual ICollection<Hip_ExpedienteEstadoDatoRequerimiento> Hip_ExpedienteEstadoDatoRequerimiento { get; set; }
        //public virtual ICollection<Auto> AutoSet { get; set; }


        public virtual ICollection<AlqExpedienteEstadoEnervacionPago> AlqExpedienteEstadoEnervacionPagoSet { get; set; }
        public virtual ICollection<ExpedienteEstadoAbogadoHistorico> ExpedienteEstadoAbogadoHistoricoSet { get; set; }
        public virtual ICollection<ExpedienteNota> ExpedienteNotaSet { get; set; }

        public virtual ICollection<LogEstadoSubfase> LogEstadoSubfaseSet { get; set; }

        #endregion

        #region Properties NotMapped

        [NotMapped]
        public string Nota { get; set; }
        [NotMapped]
        public string NotaUsuario { get; set; }

        [NotMapped]
        public DateTime? DateTimeInitWork { get; set; }

        #endregion

        #region Properties ReadOnly

        public string ClientePhaseCoded =>
            IdTipoSubFaseEstado.HasValue && !string.IsNullOrWhiteSpace(TipoSubFaseEstado?.ClientePhaseCoded) ? 
            TipoSubFaseEstado?.ClientePhaseCoded :
            Gnr_TipoEstado.ClientePhaseCoded;

        public bool IsEndOrPause => Gnr_TipoEstado != null && (Gnr_TipoEstado.Fin || Gnr_TipoEstado.Paralizado);
        //public Gnr_Abogado AbogadoActual => IdTipoSubFaseEstado.HasValue && IdTipoSubFaseEstado.OnHipSubasta() ? Abogado2 : Abogado;
        public int? IdAbogadoActual => IdTipoSubFaseEstado.HasValue && IdTipoSubFaseEstado.OnHipSubasta() ? IdAbogado2 : IdAbogado;

        public bool HasAbogado => IdAbogadoActual.HasValue;
        public ExpedienteEstadoTipo TipoEstadoValue => (ExpedienteEstadoTipo)IdTipoEstado;

        public DateTime? DemandaFechaPresentacion =>
            TipoEstadoValue == ExpedienteEstadoTipo.HipotecarioPresentacionDemanda && Hip_ExpedienteEstadoPresentacionDemanda != null ? Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion :
            TipoEstadoValue == ExpedienteEstadoTipo.AlquilerPresentacionDemanda && Alq_Expediente_EstadoPresentacionDemanda != null ? Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion :
            TipoEstadoValue == ExpedienteEstadoTipo.EjecutivoPresentacionDemanda && Ejc_ExpedienteEstadoPresentacionDemanda != null ? Ejc_ExpedienteEstadoPresentacionDemanda.FechaPresentacion :
            TipoEstadoValue == ExpedienteEstadoTipo.OrdinarioPresentacionDemanda && ExpedienteEstadoOrdinarioPresentacionDemanda != null ? ExpedienteEstadoOrdinarioPresentacionDemanda.FechaPresentacion :
            null;

        private TipoExpedienteEnum? _tipoExpediente;
        //[NotMapped]
        public TipoExpedienteEnum TipoExpedienteEnum
        {
            get
            {
                if (!_tipoExpediente.HasValue)
                {
                    if (Expediente != null) _tipoExpediente = (TipoExpedienteEnum)Expediente.IdTipoExpediente;
                    //_tipoExpediente = Expediente != null
                    //    ? (TipoExpedienteEnum)Expediente.IdTipoExpediente
                    //    : SrvGeneral.GetTipoExpedienteByIdExpediente(IdExpediente); //TipoExpedienteEnum.Hipotecario;
                }

                return _tipoExpediente.Value;
                //(TipoExpedienteEnum)Model.Expediente.IdTipoExpediente;			    
            }
            //set { _tipoExpediente = value; }
        }

        #endregion

        #region Methods

        internal void RefreshBy(ExpedienteEstado model)
        {
            if (IdTipoSubFaseEstado != model.IdTipoSubFaseEstado)
                AddLogEstadoSubfase(model);

            //2020 04 16
            if (IdTipoSubFaseEstado != model.IdTipoSubFaseEstado)
            {
                if (ExpedienteEstadoAbogadoHistoricoSet == null) ExpedienteEstadoAbogadoHistoricoSet = new List<ExpedienteEstadoAbogadoHistorico>();
                ExpedienteEstadoAbogadoHistoricoSet.Add(new ExpedienteEstadoAbogadoHistorico(this, model.IdTipoSubFaseEstado, model.Usuario));
            }

            #region Actualizar Datos

            Fecha = model.Fecha;
            if (!string.IsNullOrWhiteSpace(model.Nota))
                Observacion = model.Nota;

            IdTipoSubFaseCliente = model.IdTipoSubFaseCliente;
            IdTipoSubFaseEstado = model.IdTipoSubFaseEstado;
            IdTipoIncidenciaEstado = model.IdTipoIncidenciaEstado;
            IncidenciaFechaResolucion = model.IncidenciaFechaResolucion;
            Nota = model.Nota;
            NotaUsuario = model.NotaUsuario;
            DateTimeInitWork = model.DateTimeInitWork;
            if (!string.IsNullOrWhiteSpace(model.Usuario) && string.IsNullOrWhiteSpace(Usuario))
                Usuario = model.Usuario;

            FechaModificado = DateTime.Now;

            #endregion

            #region Actualizar Subfases automaticamente

            if (model.Alq_Expediente_EstadoPresentacionDemanda != null && Alq_Expediente_EstadoPresentacionDemanda != null)
            {
                if (model.Alq_Expediente_EstadoPresentacionDemanda.FechaEnvioProcurador.HasValue && !Alq_Expediente_EstadoPresentacionDemanda.FechaEnvioProcurador.HasValue)
                    IdTipoSubFaseEstado = 75002;
                else if (model.Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue && !Alq_Expediente_EstadoPresentacionDemanda.FechaPresentacion.HasValue)
                    IdTipoSubFaseEstado = 75003;
                else if (model.Alq_Expediente_EstadoPresentacionDemanda.NoAdmitidaFecha.HasValue && !Alq_Expediente_EstadoPresentacionDemanda.NoAdmitidaFecha.HasValue)
                    IdTipoSubFaseEstado = 75004;
                else if (model.Alq_Expediente_EstadoPresentacionDemanda.NoAdmitidaFechaApelacion.HasValue && !Alq_Expediente_EstadoPresentacionDemanda.NoAdmitidaFechaApelacion.HasValue)
                    IdTipoSubFaseEstado = 75005;
            }
            if (model.Alq_Expediente_EstadoTramitaJuzgado != null)
            {
                if (model.Alq_Expediente_EstadoTramitaJuzgado.AdmitidaFecha.HasValue && !Alq_Expediente_EstadoTramitaJuzgado.AdmitidaFecha.HasValue)
                    IdTipoSubFaseEstado = 76002;
                //else if (model.Alq_Expediente_EstadoTramitaJuzgado.FechaPresentacion.HasValue && !Alq_Expediente_EstadoTramitaJuzgado.FechaPresentacion.HasValue)
                //    IdTipoSubFaseEstado = 76003;
                else if (model.Alq_Expediente_EstadoTramitaJuzgado.OposicionFecha.HasValue && !Alq_Expediente_EstadoTramitaJuzgado.OposicionFecha.HasValue)
                    IdTipoSubFaseEstado = 76004;
                else if (model.Alq_Expediente_EstadoTramitaJuzgado.OposicionFechaDecretoFin.HasValue && !Alq_Expediente_EstadoTramitaJuzgado.OposicionFechaDecretoFin.HasValue)
                    IdTipoSubFaseEstado = 76005;

                else if (model.Alq_Expediente_EstadoTramitaJuzgado.FechaVistaOcupantes.HasValue && !Alq_Expediente_EstadoTramitaJuzgado.FechaVistaOcupantes.HasValue)
                    IdTipoSubFaseEstado = 76006;
                else if (model.Alq_Expediente_EstadoTramitaJuzgado.OposicionFechaSentencia.HasValue && !Alq_Expediente_EstadoTramitaJuzgado.OposicionFechaSentencia.HasValue)
                    IdTipoSubFaseEstado = 76007;
                else if (model.Alq_Expediente_EstadoTramitaJuzgado.SuspensionFecha.HasValue && !Alq_Expediente_EstadoTramitaJuzgado.SuspensionFecha.HasValue)
                    IdTipoSubFaseEstado = 76008;

                else if (model.Alq_Expediente_EstadoTramitaJuzgado.OposicionFechaRecursoApelacion.HasValue && !Alq_Expediente_EstadoTramitaJuzgado.OposicionFechaRecursoApelacion.HasValue)
                    IdTipoSubFaseEstado = 76009;
                else if (model.Alq_Expediente_EstadoTramitaJuzgado.ApelacionFecha.HasValue && !Alq_Expediente_EstadoTramitaJuzgado.ApelacionFecha.HasValue)
                    IdTipoSubFaseEstado = 76010;
                //else if (model.Alq_Expediente_EstadoTramitaJuzgado.OposicionFechaDecretoFin.HasValue && !Alq_Expediente_EstadoTramitaJuzgado.OposicionFechaDecretoFin.HasValue)
                //    IdTipoSubFaseEstado = 76005;
                //else if (model.Alq_Expediente_EstadoTramitaJuzgado.OposicionFechaDecretoFin.HasValue && !Alq_Expediente_EstadoTramitaJuzgado.OposicionFechaDecretoFin.HasValue)
                //    IdTipoSubFaseEstado = 76005;
            }

            if (model.Alq_Expediente_EstadoLanzamiento != null)
            {
                if (model.Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue && !Alq_Expediente_EstadoLanzamiento.PosesionFechaRecepcion.HasValue)
                    IdTipoSubFaseEstado = 77004;
            }

            #endregion

            #region Actualizar Tiempo de Trabajo

            if (model.DateTimeInitWork.HasValue)
                TimeWorkedMinutes = TimeWorkedMinutes + Math.Max(1, (int)DateTime.Now.Subtract(model.DateTimeInitWork.Value).TotalMinutes);

            #endregion
        }

        private void AddLogEstadoSubfase(ExpedienteEstado model)
        {
            var logEstadoSubfase = new LogEstadoSubfase(ExpedienteEstadoId, model);

            if (LogEstadoSubfaseSet == null)
                LogEstadoSubfaseSet = new List<LogEstadoSubfase>();

            LogEstadoSubfaseSet.Add(logEstadoSubfase);
        }

        internal void RefreshByTipoSubFase(AlqExpedienteEstadoTramitacionDenuncia tramitacionDenuncia)
        {
            if (tramitacionDenuncia == null) return;

            if (tramitacionDenuncia.AdmitidaFecha.HasValue && !AlqExpedienteEstadoTramitacionDenuncia.AdmitidaFecha.HasValue)
                IdTipoSubFaseEstado = 5132002;
            if (tramitacionDenuncia.DiligenciaPreviaFechaAutoApertura.HasValue && !AlqExpedienteEstadoTramitacionDenuncia.DiligenciaPreviaFechaAutoApertura.HasValue)
                IdTipoSubFaseEstado = 5132003;
            if (tramitacionDenuncia.DiligenciaPreviaOficioFechaRecepcion.HasValue && !AlqExpedienteEstadoTramitacionDenuncia.DiligenciaPreviaOficioFechaRecepcion.HasValue)
                IdTipoSubFaseEstado = 5132004;
            if (tramitacionDenuncia.FechaEscritoDefensa.HasValue && !AlqExpedienteEstadoTramitacionDenuncia.FechaEscritoDefensa.HasValue)
                IdTipoSubFaseEstado = 5132006;
            if (tramitacionDenuncia.SuspensionFecha.HasValue && !AlqExpedienteEstadoTramitacionDenuncia.SuspensionFecha.HasValue)
                IdTipoSubFaseEstado = 5132008;
            if (tramitacionDenuncia.FechaSentencia1.HasValue && !AlqExpedienteEstadoTramitacionDenuncia.FechaSentencia1.HasValue)
                IdTipoSubFaseEstado = 5132009;
            if (tramitacionDenuncia.FechaRecursoApelacion.HasValue && !AlqExpedienteEstadoTramitacionDenuncia.FechaRecursoApelacion.HasValue)
                IdTipoSubFaseEstado = 5132012;
            if (tramitacionDenuncia.ApelacionFecha.HasValue && !AlqExpedienteEstadoTramitacionDenuncia.ApelacionFecha.HasValue)
                IdTipoSubFaseEstado = 5132013;
        }


        public bool IsNecesaryInsertHistoricoEstadoAbogado(ExpedienteEstado estadoNew)
        {
            if (estadoNew == null) return false;

            return IdAbogado != estadoNew.IdAbogado || IdTipoSubFaseEstado != estadoNew.IdTipoSubFaseEstado;
        }

        #endregion

    }
}
