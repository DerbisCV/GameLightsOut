using Solvtio.Common;
using Solvtio.Models.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using Solvtio.Models;

namespace Solvtio.Models
{
    public class Expediente : BaseValues //AuditableMin
    {
        #region Constructors

        public Expediente()
        {
            CreateBase();
            IdClienteOficina = 913;
        }

        public Expediente(int idValija)
        {
            CreateBase();
            IdValija = idValija;
        }

        public Expediente(TipoExpedienteEnum tipoExp, string userName)
        {
            CreateBase();

            IdTipoExpediente = (int)tipoExp;
            Usuario = userName;

            if (tipoExp == TipoExpedienteEnum.Ddl) ExpedienteDdl = new ExpedienteDdl();
        }

        public Expediente(Hip_Hipoteca hipoteca)
        {
            CreateBase();

            //IdValija = hipoteca.IdValija;
            DeudaFinal = hipoteca.DeudaCierreFijacion;
            ReferenciaExterna = hipoteca.ReferenciaExterna;
            IdTipoArea = hipoteca.IdTipoArea;
            //IdTipoExpediente = hipoteca.Gnr_Valija.IdTipoExpediente;
            //IdClienteOficina = hipoteca.Gnr_Valija.IdClienteOficina;
            Usuario = hipoteca.Usuario ?? "";
            Observaciones = hipoteca.Observaciones;
        }

        //TipoExpedienteEnum tipoExpediente
        public Expediente(ExpedienteEscritura escritura, TipoExpedienteEnum tipoExp, string userName)
        {
            CreateBase();
            IdTipoExpediente = (int)tipoExp;
            Usuario = userName;

            ClonarDatos(escritura.Expediente);
            Inicio = DateTime.Now;
        }

        public Expediente(Expediente expedientePadre, string userName)
        {
            CreateBase();
            IdTipoExpediente = expedientePadre.IdTipoExpediente;

            ClonarDatos(expedientePadre);
            Inicio = DateTime.Now;
            NoAuto = "";
            Usuario = userName;
        }

        private void CreateBase()
        {
            NoExpediente = "";
            Inicio = DateTime.Today;
            FechaAlta = DateTime.Now;
            FechaModificacion = DateTime.Now;
            FechaCierre = DateTime.Now;
            IdAbogado = 0;

            ExpedienteDeudors = new List<ExpedienteDeudor>();
            ExpedienteEstadoes = new List<ExpedienteEstado>();

            Con_ExpedienteAdministrador = new List<Con_ExpedienteAdministrador>();
            Con_ExpedienteCredito = new List<Con_ExpedienteCredito>();
            Con_ExpedienteIncidente = new List<Con_ExpedienteIncidente>();
            //ExpedienteDocumentoes = new List<ExpedienteDocumento>();
            ExpedienteAcreedores = new List<ExpedienteAcreedore>();
            ExpedienteAlertas = new List<ExpedienteAlerta>();

            FacturaSet = new List<ExpedienteFactura>();
            ExpedienteGastoes = new List<ExpedienteGasto>();
            ExpedienteIngresoes = new List<ExpedienteIngreso>();
            ExpedienteVistas = new List<ExpedienteVista>();
            Hip_Inmueble = new List<Hip_Inmueble>();

            ValoracionJuzgado = ValoracionProcurador = ValoracionAdministrador = ValoracionAbogado = ValoracionCliente = 0;
            IdTipoArea = 1;
        }

        public void ClonarDatos(Expediente expBase)
        {
            IdValija = expBase.IdValija;

            ReferenciaExterna = expBase.ReferenciaExterna;
            IdTipoArea = expBase.IdTipoArea;
            IdClienteOficina = expBase.IdClienteOficina;
            FechaCargaAppCliente = expBase.FechaCargaAppCliente;
            NoAuto = expBase.NoAuto;
            DeudaFinal = expBase.DeudaFinal;
            FechaCierre = expBase.FechaCierre;
            IdAbogado = expBase.IdAbogado;
            IdPartidoJudicial = expBase.IdPartidoJudicial;
            IdProcurador = expBase.IdProcurador;
            IdJuzgado = expBase.IdJuzgado;
            IdCartera = expBase.IdCartera;

            SucesionAcordada = expBase.SucesionAcordada;
            SucesionPresentada = expBase.SucesionPresentada;
            SucesionCopiaSellada = expBase.SucesionCopiaSellada;
            SucesionOposicion = expBase.SucesionOposicion;
            SucesionRecurrida = expBase.SucesionRecurrida;
            SucesionResultadoRecuso = expBase.SucesionResultadoRecuso;
            IdSucesionCausaIncidencia = expBase.IdSucesionCausaIncidencia;
            IdSucesionEstadoProcesalCliente = expBase.IdSucesionEstadoProcesalCliente;
            IdSucesionProblemasDetalles = expBase.IdSucesionProblemasDetalles;

            EsHeredado = expBase.EsHeredado;
            EsNofacturable = expBase.EsNofacturable;

            Usuario = expBase.Usuario ?? "";
            Observaciones = expBase.Observaciones;
        }

        #endregion

        #region Properties

        public int IdExpediente { get; set; }
        public int? IdValija { get; set; }

        [Index]
        public string NoExpediente { get; set; }
        public string ReferenciaExterna { get; set; }
        public string Referencia2 { get; set; }
        public string ReferenciaReoco { get; set; }
        public string Nic { get; set; }
        public string ReferenciaJudicial { get; set; }
        public string RefKmaleon { get; set; }

        [Index]
        public int IdTipoExpediente { get; set; }
        
        public int IdTipoArea { get; set; }
        [Index]
        public int IdClienteOficina { get; set; }
        public int? IdProcurador { get; set; }
        public DateTime? FechaCierre { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fin { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Archivado { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string Usuario { get; set; }
        public string Observaciones { get; set; }
        public decimal? DeudaFinal { get; set; }

        public int? IdExpedienteNegociacion { get; set; }
        //[ForeignKey("IdExpedienteNegociacion")]
        //public virtual ExpedienteNegociacion ExpedienteNegociacion { get; set; }

        public int? IdExpedienteFather { get; set; }
        public int? IdExpedienteSon { get; set; }
        public int? IdExpedienteBrother { get; set; }

        //public int? IdExpedienteClonPadre { get; set; }
        //public int? IdExpedienteClonHijo { get; set; }


        [Index]
        public int? IdTipoEstadoLast { get; set; }
        [ForeignKey("IdTipoEstadoLast")]
        public virtual Gnr_TipoEstado ExpedienteEstadoLastTipo { get; set; }

        [Index]
        public int? IdEstadoLast { get; set; }
        //[ForeignKey("IdEstadoLast")]
        [NotMapped]
        public virtual ExpedienteEstado ExpedienteEstadoLast { get; set; }

        [Index]
        public int? IdExpedienteFaseClienteLast { get; set; }
        //[ForeignKey("IdExpedienteFaseClienteLast")]
        //public virtual ExpedienteFaseCliente ExpedienteFaseClienteLast { get; set; }

        public int? IdExpedienteSubastaLast { get; set; }
        //[ForeignKey("IdExpedienteSubastaLast")]
        [NotMapped]
        public virtual ExpedienteSubasta ExpedienteSubastaLast { get; set; }

        public int? IdDeudorPrincipal { get; set; }
        [ForeignKey("IdDeudorPrincipal")]
        public virtual Gnr_Persona Gnr_Persona { get; set; }

        public int? IdAreaNegocio { get; set; }
        [ForeignKey("IdAreaNegocio")]
        public virtual AreaNegocio AreaNegocio { get; set; }

        public string NoAuto { get; set; }

        public int? IdJuzgado { get; set; }
        [ForeignKey("IdJuzgado")]
        public virtual Juzgado Juzgado { get; set; }

        public int? IdPartidoJudicial { get; set; }
        public decimal? ImporteAdmision { get; set; } //Readonly

        public DateTime? FechaHitoInicio { get; set; }
        public DateTime? FechaHitoFin { get; set; }
        public DateTime? FechaHito1 { get; set; }
        public DateTime? FechaHito2 { get; set; }
        public DateTime? FechaHito3 { get; set; }
        public string AvisoImportante { get; set; }
        public string GestorCliente { get; set; }
        public bool Paralizado { get; set; }

        public bool EsHeredado { get; set; }
        public int? IdVeniadoHitoFacturacion { get; set; }
        [ForeignKey("IdVeniadoHitoFacturacion")]
        public virtual CaracteristicaBase VeniadoHitoFacturacion { get; set; }


        public bool EsRelevante { get; set; }
        public bool EsConfidencial { get; set; }
        public bool InactivoInterno { get; set; }

        public bool EsNofacturable { get; set; }
        public bool FacturacionCompleta { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaCargaAppCliente { get; set; }

        public decimal? ImportePreFactura { get; set; } //Readonly

        public int? IdCartera { get; set; }
        [ForeignKey("IdCartera")]
        public virtual Cartera Cartera { get; set; }

        [DataType(DataType.Date)]
        public DateTime? SucesionPresentada { get; set; }
        [DataType(DataType.Date)]
        public DateTime? SucesionAcordada { get; set; }
        [DataType(DataType.Date)]
        public DateTime? SucesionCopiaSellada { get; set; }
        [DataType(DataType.Date)]
        public DateTime? SucesionDenegada { get; set; }

        public bool SucesionOposicion { get; set; }

        [DataType(DataType.Date)]
        public DateTime? SucesionRecurrida { get; set; }
        public TipoResultadoApelacion? SucesionResultadoRecuso { get; set; }

        //            *Sucesión Recurrida(fecha)
        //* Resultado Recuso Estimatorio/ Desestimatorio.

        public int? IdSucesionCausaIncidencia { get; set; }
        [ForeignKey("IdSucesionCausaIncidencia")]
        public virtual CaracteristicaBase SucesionCausaIncidencia { get; set; }

        public int? IdSucesionEstadoProcesalCliente { get; set; }
        [ForeignKey("IdSucesionEstadoProcesalCliente")]
        public virtual CaracteristicaBase SucesionEstadoProcesalCliente { get; set; }

        public int? IdSucesionProblemasDetalles { get; set; }
        [ForeignKey("IdSucesionProblemasDetalles")]
        public virtual CaracteristicaBase SucesionProblemasDetalles { get; set; }

        public int? ValoracionJuzgado { get; set; }
        public int? ValoracionProcurador { get; set; }
        public int? ValoracionAdministrador { get; set; }
        public int? ValoracionAbogado { get; set; }
        public int? ValoracionCliente { get; set; }

        public string Origen { get; set; }

        public int? IdAccionPropuesta { get; set; }
        [ForeignKey("IdAccionPropuesta")]
        public virtual Gnr_ListasValores_Valores AccionPropuesta { get; set; }

        public int? IdSubTipoProcedimiento { get; set; }
        [ForeignKey("IdSubTipoProcedimiento")]
        public virtual CaracteristicaBase SubTipoProcedimiento { get; set; }

        public string ContratoRef { get; set; }
        public bool ServicioIntegral { get; set; }

        #endregion

        #region Properties Semicalculables (Fechas Previstas, Facturables, etc)

        public decimal? ImpFacturableH1 { get; set; }
        public decimal? ImpFacturableH2 { get; set; }
        public decimal? ImpFacturableH3 { get; set; }
        public decimal? ImpFacturableH4 { get; set; }
        public decimal? ImpFacturableH5 { get; set; }
        public decimal? ImpFacturableH6 { get; set; }
        public decimal? ImpFacturableExtrajudicial { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaFacturableH1 { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaFacturableH2 { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaFacturableH3 { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaFacturableH4 { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaFacturableH5 { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaFacturableH6 { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaPrevistaH1 { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaPrevistaH2 { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaPrevistaH3 { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaPrevistaH4 { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaPrevistaH5 { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaPrevistaH6 { get; set; }

        public DateTime? FinPrevisto { get; set; }

        #endregion

        #region Expedientes Tipo

        // [ForeignKey("IdExpediente")]
        public virtual Hip_Expediente Hip_Expediente { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual Alq_Expediente Alq_Expediente { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual Con_Expediente Con_Expediente { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual Ejc_Expediente Ejc_Expediente { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual Mnt_Expediente Mnt_Expediente { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedienteMultiDivisa ExpedienteMultiDivisa { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedienteJurisdiccionVoluntaria ExpedienteJurisdiccionVoluntaria { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedienteJV ExpedienteJV { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedienteInscripcionCredito ExpedienteInscripcionCredito { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedienteOrdinario ExpedienteOrdinario { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedienteOrdinarioCs ExpedienteOrdinarioCs { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedienteMonitorio ExpedienteMonitorio { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedienteVerbal ExpedienteVerbal { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedienteSaneamiento ExpedienteSaneamiento { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedientePenal ExpedientePenal { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedienteFiscal ExpedienteFiscal { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedienteConciliacion ExpedienteConciliacion { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedienteJuraCuenta ExpedienteJuraCuenta { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedienteCivil ExpedienteCivil { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedienteMercantilInmobiliario ExpedienteMercantilInmobiliario { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedienteDdl ExpedienteDdl { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedienteContenciosoAdministrativo ExpedienteContenciosoAdministrativo { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedienteContenciosoOrdinario ExpedienteContenciosoOrdinario { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedienteCambiario ExpedienteCambiario { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedienteProcura ExpedienteProcura { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedienteScne ExpedienteScne { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedienteBastanteo ExpedienteBastanteo { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedienteTestamentario ExpedienteTestamentario { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedienteTpn ExpedienteTpn { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual ExpedientePrelitigio ExpedientePrelitigio { get; set; }
        // [ForeignKey("IdExpediente")]
        public virtual Neg_Gestion Neg_Gestion { get; set; }

        #endregion

        #region Properties Virtual

        public int? IdPagador { get; set; }
        [ForeignKey("IdPagador")]
        public virtual Pagador Pagador { get; set; }

        //public virtual ICollection<ExpedienteNegociacion> ExpedienteNegociacionSet { get; set; }


        public int? IdAbogado { get; set; }
        [ForeignKey("IdAbogado")]
        public virtual Gnr_Abogado Gnr_Abogado { get; set; }
        [ForeignKey("IdClienteOficina")]
        public virtual Gnr_ClienteOficina Gnr_ClienteOficina { get; set; }
        [ForeignKey("IdProcurador")]
        public virtual Gnr_Procurador Gnr_Procurador { get; set; }
        //public virtual Gnr_Valija Gnr_Valija { get; set; }
        [ForeignKey("IdPartidoJudicial")]
        public virtual PartidoJudicial Hip_PartidoJudicial { get; set; }
        [ForeignKey("IdTipoArea")]
        public virtual Gnr_TipoArea Gnr_TipoArea { get; set; }
        [ForeignKey("IdTipoExpediente")]
        public virtual Gnr_TipoExpediente Gnr_TipoExpediente { get; set; }

        #endregion

        #region One 2 Many

        public virtual ICollection<Con_ExpedienteAdministrador> Con_ExpedienteAdministrador { get; set; }
        public virtual ICollection<Con_ExpedienteCredito> Con_ExpedienteCredito { get; set; }
        public virtual ICollection<Con_ExpedienteIncidente> Con_ExpedienteIncidente { get; set; }
        //public virtual ICollection<ExpedienteDocumento> ExpedienteDocumentoes { get; set; }
        public virtual ICollection<ExpedienteAcreedore> ExpedienteAcreedores { get; set; }
        public virtual ICollection<ExpedienteAlerta> ExpedienteAlertas { get; set; }
        public virtual ICollection<ExpedienteDeudor> ExpedienteDeudors { get; set; }
        public virtual ICollection<ExpedienteEstado> ExpedienteEstadoes { get; set; }
        public virtual ICollection<ExpedienteFactura> FacturaSet { get; set; }
        public virtual ICollection<ExpedienteGastoSuplido> ExpedienteGastoSuplidoSet { get; set; }
        public virtual ICollection<ExpedienteCobro> ExpedienteCobroSet { get; set; }
        public virtual ICollection<ExpedienteGasto> ExpedienteGastoes { get; set; }
        public virtual ICollection<ExpedienteIngreso> ExpedienteIngresoes { get; set; }
        public virtual ICollection<ExpedienteVista> ExpedienteVistas { get; set; }
        public virtual ICollection<Hip_Hipoteca> Hip_Hipoteca { get; set; }
        public virtual ICollection<Hip_Inmueble> Hip_Inmueble { get; set; }
        public virtual ICollection<Asset> AssetSet { get; set; }

        public virtual ICollection<NotificacionMail> NotificacionMailSet { get; set; }
        public virtual ICollection<ExpedienteNota> ExpedienteNotaSet { get; set; }
        public virtual ICollection<ExpedienteHito> ExpedienteHitoSet { get; set; }

        public virtual ICollection<Impulso> ImpulsoSet { get; set; }
        public virtual ICollection<Actuacion> ActuacionSet { get; set; }
        public virtual ICollection<Mediacion> MediacionSet { get; set; }

        //public virtual ICollection<ExpedienteEscritura> ExpedienteEscrituraSet { get; set; }
        public virtual ICollection<ExpedienteSubasta> ExpedienteSubastaSet { get; set; }
        public virtual ICollection<ExpedienteHitoProcesal> ExpedienteHitoProcesalSet { get; set; }
        public virtual ICollection<ExpedienteVencimiento> ExpedienteVencimientoSet { get; set; }
        public virtual ICollection<ExpedienteParalizado> ExpedienteParalizadoSet { get; set; }

        public virtual ICollection<ExpedienteSalarioSaldo> ExpedienteSalarioSaldoSet { get; set; }

        public virtual ICollection<ConcursalComunicacionCredito> ConcursalComunicacionCreditoSet { get; set; }
        //public virtual ICollection<ConcursalGarantiaOtra> ConcursalGarantiaOtraSet { get; set; }  
        public virtual ICollection<ConcursalConvenioDesglose> ConcursalConvenioDesgloseSet { get; set; }
        public virtual ICollection<ExpedientePrestamo> ExpedientePrestamoSet { get; set; }
        public virtual ICollection<ExpedienteContrato> ExpedienteContratoSet { get; set; }
        public virtual ICollection<ExpedienteHora> ExpedienteHoraSet { get; set; }
        public virtual ICollection<ExpedientePropuesta> ExpedientePropuestaSet { get; set; }

        public virtual ICollection<ExpedienteAbogado> ExpedienteAbogadoSet { get; set; }
        public virtual ICollection<ExpedienteCliente> ExpedienteClienteSet { get; set; }
        public virtual ICollection<ExpedienteAcuerdo> ExpedienteAcuerdoSet { get; set; }
        public virtual ICollection<ExpedienteRecursoReposicion> ExpedienteRecursoReposicionSet { get; set; }

        public virtual ICollection<ExpedienteFaseCliente> ExpedienteFaseClienteSet { get; set; }

        public virtual ICollection<ExpedienteTituloEjecutivo> ExpedienteTituloEjecutivoSet { get; set; }


        #endregion

        #region Properties NotMapped

        [NotMapped]
        public ExpedienteFaseCliente ExpedienteFaseCliente { get; set; }

        [NotMapped]
        public ExpedienteFaseCliente ExpedienteFaseClienteAnterior { get; set; }

        [NotMapped]
        public ModelAlarma ModelAlarma { get; set; }

        [NotMapped]
        public int TimeWorkedMinutes { get; set; }

        [NotMapped]
        public ExpedienteNota NotaLast { get; set; }

        [NotMapped]
        public string NotasAll { get; set; }

        [NotMapped]
        public LogEstadoSubfase LogEstadoSubfaseLast { get; set; }


        [NotMapped]
        public ExpedienteNota NotaEstadoLast { get; set; }

        public ExpedienteNota NotaEstadoLastCalculada => ExpedienteNotaSet?.OrderByDescending(x => x.Fecha).FirstOrDefault();

        [NotMapped]
        public ExpedienteHito HitoLast { get; set; }

        [NotMapped]
        public ExpedienteParalizado ParalizadoLast { get; set; }

        [NotMapped]
        public int? ProbabilidadFacturacion { get; set; }

        [NotMapped]
        public List<Expediente> LstExpedienteChildren { get; set; }

        [NotMapped]
        public string Error { get; set; }

        [NotMapped]
        public bool ConflictoInteres { get; set; }

        //[NotMapped]
        //public Hip_Inmueble Inmueble { get; set; }
        public Hip_Inmueble Inmueble => Hip_Inmueble.FirstOrDefault();

        //[NotMapped]
        //public ExpedienteDeudor Deudor1 { get; set; }
        public ExpedienteDeudor Deudor1 => ExpedienteDeudors.FirstOrDefault();
        //[NotMapped]
        //public ExpedienteDeudor Deudor2 { get; set; }
        public ExpedienteDeudor Deudor2 => Deudor1 == null ? null : ExpedienteDeudors.FirstOrDefault(x => x.IdExpedienteDeudor != Deudor1.IdExpedienteDeudor);

        [NotMapped]
        public ModelNota ModelNota { get; set; }

        [NotMapped]
        public RoleType? RoleType { get; set; }

        [NotMapped]
        public ModelSituacion ModelSituacion { get; set; }

        #endregion

        #region Properties ReadOnly

        public ExpedienteNota ExpedienteNotaLast => ExpedienteNotaSet.IsEmpty() ? null : ExpedienteNotaSet.OrderByDescending(x => x.Fecha).FirstOrDefault();
        //public bool Archivado => Fin.HasValue && Fin.Value.CompareTo(DateTime.Today.AddDays(-180)) < 0;

        //public ExpedienteAcuerdo ExpedienteAcuerdoLast => ExpedienteAcuerdoSet.IsEmpty() ? null : ExpedienteAcuerdoSet.OrderByDescending(x => x.FechaPropuesta).FirstOrDefault();

        public string Npl_Reo =>
            IdTipoExpediente == 1 && Fin.HasValue ? "REO" :
            IdTipoExpediente == 1 && ExpedienteEstadoLast.IdTipoEstado == IdTipoEstadoHipAdjudicacion ? "REO" :
            IdTipoExpediente == 1 ? "NPL" :
            "-";

        public string AreaNegocioName =>
            IdTipoArea == 3 || (new int[] { 5, 15 }).Contains(IdTipoExpediente) ? "ALQUILER" :
            (new int[] { 11, 25, 20 }).Contains(IdTipoExpediente) ? "LEGAL" :
            (new int[] { 4 }).Contains(IdTipoExpediente) ? "REI" :
            (new int[] { 30 }).Contains(IdTipoExpediente) ? "PROCURA" :
            (new int[] { 1, 3, 14, 17, 8, 2, 22, 24, 16, 29 }).Contains(IdTipoExpediente) ? "RECUPERACIONES" :
            "¿?";

        public bool HaveHitoFacturacion1 => FacturaSet.Any(x => x.HitoFacturacion == HitoFacturacionValue.Hito1 || x.HitoFacturacion == HitoFacturacionValue.HipotecarioHito1 || x.HitoFacturacion == HitoFacturacionValue.AlquilerHito1);
        public bool HaveHitoFacturacion2 => FacturaSet.Any(x => x.HitoFacturacion == HitoFacturacionValue.Hito2 || x.HitoFacturacion == HitoFacturacionValue.HipotecarioHito2 || x.HitoFacturacion == HitoFacturacionValue.AlquilerHito2);
        public bool HaveHitoFacturacion3 => FacturaSet.Any(x => x.HitoFacturacion == HitoFacturacionValue.Hito3 || x.HitoFacturacion == HitoFacturacionValue.HipotecarioHito3 || x.HitoFacturacion == HitoFacturacionValue.AlquilerHito3);

        public bool HaveHitoFacturacion4 => FacturaSet.Any(x => x.HitoFacturacion == HitoFacturacionValue.Hito4);
        public bool HaveHitoFacturacion5 => FacturaSet.Any(x => x.HitoFacturacion == HitoFacturacionValue.Hito5);
        public bool HaveHitoFacturacion6 => FacturaSet.Any(x => x.HitoFacturacion == HitoFacturacionValue.Hito6);


        private DateTime? _fechaPresentacionDemanda;
        public DateTime? FechaPresentacionDemanda
        {
            get
            {
                if (!_fechaPresentacionDemanda.HasValue)
                {
                    ExpedienteEstado estadoPresDemanda;
                    switch (TipoExpediente)
                    {
                        case TipoExpedienteEnum.Hipotecario:
                            estadoPresDemanda = ExpedienteEstadoes.OrderByDescending(x => x.Fecha).FirstOrDefault(x => x.IdTipoEstado == IdTipoEstadoHipPresentDemanda);
                            _fechaPresentacionDemanda = estadoPresDemanda?.Hip_ExpedienteEstadoPresentacionDemanda?.FechaPresentacion;
                            break;

                        case TipoExpedienteEnum.Alquiler:
                            estadoPresDemanda = ExpedienteEstadoes.OrderByDescending(x => x.Fecha).FirstOrDefault(x => x.IdTipoEstado == IdTipoEstadoAlqPresentDemanda);
                            _fechaPresentacionDemanda = estadoPresDemanda?.Alq_Expediente_EstadoPresentacionDemanda?.FechaPresentacion;
                            break;

                        case TipoExpedienteEnum.Ejecutivo:
                            estadoPresDemanda = ExpedienteEstadoes.OrderByDescending(x => x.Fecha).FirstOrDefault(x => x.IdTipoEstado == IdTipoEstadoEjcPresentDemanda);
                            _fechaPresentacionDemanda = estadoPresDemanda?.Ejc_ExpedienteEstadoPresentacionDemanda?.FechaPresentacion;
                            break;

                        case TipoExpedienteEnum.Ordinario:
                            estadoPresDemanda = ExpedienteEstadoes.OrderByDescending(x => x.Fecha).FirstOrDefault(x => x.IdTipoEstado == IdTipoEstadoOrdPresentacionDemanda);
                            _fechaPresentacionDemanda = estadoPresDemanda?.ExpedienteEstadoOrdinarioPresentacionDemanda?.FechaPresentacion;
                            break;

                        case TipoExpedienteEnum.OrdinarioCs:
                            break;

                        default:
                            break;
                    }
                }

                return _fechaPresentacionDemanda;
            }
        }

        private DateTime? _fechaDemandaEnvioProcurador;
        public DateTime? FechaDemandaEnvioProcurador
        {
            get
            {
                if (!_fechaDemandaEnvioProcurador.HasValue)
                {
                    ExpedienteEstado estadoPresDemanda;
                    switch (TipoExpediente)
                    {
                        case TipoExpedienteEnum.Hipotecario:
                            estadoPresDemanda = ExpedienteEstadoes.OrderByDescending(x => x.Fecha).FirstOrDefault(x => x.IdTipoEstado == IdTipoEstadoHipPresentDemanda);
                            _fechaDemandaEnvioProcurador = estadoPresDemanda?.Hip_ExpedienteEstadoPresentacionDemanda?.FechaEnvioProcurador;
                            break;

                        case TipoExpedienteEnum.Alquiler:
                            estadoPresDemanda = ExpedienteEstadoes.OrderByDescending(x => x.Fecha).FirstOrDefault(x => x.IdTipoEstado == IdTipoEstadoAlqPresentDemanda);
                            _fechaDemandaEnvioProcurador = estadoPresDemanda?.Alq_Expediente_EstadoPresentacionDemanda?.FechaEnvioProcurador;
                            break;

                        case TipoExpedienteEnum.Ejecutivo:
                            estadoPresDemanda = ExpedienteEstadoes.OrderByDescending(x => x.Fecha).FirstOrDefault(x => x.IdTipoEstado == IdTipoEstadoEjcPresentDemanda);
                            _fechaDemandaEnvioProcurador = estadoPresDemanda?.Ejc_ExpedienteEstadoPresentacionDemanda?.FechaEnvioProcurador;
                            break;

                        case TipoExpedienteEnum.Ordinario:
                            estadoPresDemanda = ExpedienteEstadoes.OrderByDescending(x => x.Fecha).FirstOrDefault(x => x.IdTipoEstado == IdTipoEstadoOrdPresentacionDemanda);
                            _fechaDemandaEnvioProcurador = estadoPresDemanda?.ExpedienteEstadoOrdinarioPresentacionDemanda?.FechaEnvioProcurador;
                            break;

                        case TipoExpedienteEnum.JurisdiccionVoluntaria:
                            estadoPresDemanda = ExpedienteEstadoes.OrderByDescending(x => x.Fecha).FirstOrDefault(x => x.IdTipoEstado == IdTipoEstadoJvPresentDemanda);
                            _fechaDemandaEnvioProcurador = estadoPresDemanda?.JvExpedienteEstadoPresentacionDemanda?.FechaEnvioProcurador;
                            break;

                        case TipoExpedienteEnum.OrdinarioCs:
                            break;

                        default:
                            break;
                    }
                }

                return _fechaDemandaEnvioProcurador;
            }
        }

        public Impulso ImpulsoLast => ImpulsoSet?.OrderBy(x => x.Fecha).ThenBy(x => x.IdImpulso).LastOrDefault();

        public bool HasPosesionPositiva =>
            ExpedienteVistas == null ? false :
            ExpedienteVistas.Any(x => x.TipoVistaEnum == TipoVistaEnum.HipotecarioPosesion && x.Resultado == PositivoNegativoType.Positivo);


        public bool HasClausulaSuelo => TipoExpediente == TipoExpedienteEnum.OrdinarioCs && ExpedienteOrdinarioCs != null;
        public bool HasClausulaSueloRecepcion => HasClausulaSuelo
            && ExpedienteEstadoLast != null && ExpedienteEstadoLast.TipoEstadoValue == ExpedienteEstadoTipo.OrdinarioCsRecepcionExpediente
            && ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsRecepcion != null;

        public CategoryColor CategoryColor =>
            !HasClausulaSuelo ? CategoryColor.None :
            HasClausulaSueloRecepcion && ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsRecepcion.EnviadoEscritoConDocumentacion && ExpedienteOrdinarioCs.FechaAllanamientoCopiaSellada.HasValue ? CategoryColor.Blue :
            HasClausulaSueloRecepcion && ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsRecepcion.SolicitadaDocumentacion && ExpedienteOrdinarioCs.FechaAllanamientoCopiaSellada.HasValue ? CategoryColor.Green :
            HasClausulaSueloRecepcion && ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsRecepcion.SolicitadaDocumentacion && !ExpedienteOrdinarioCs.FechaAllanamientoCopiaSellada.HasValue ? CategoryColor.Yellow :
            HasClausulaSueloRecepcion && ExpedienteEstadoLast.ExpedienteEstadoOrdinarioCsRecepcion.NoneMilestone && !ExpedienteOrdinarioCs.FechaAllanamientoCopiaSellada.HasValue ? CategoryColor.Gray :
            CategoryColor.None;

        private TipoExpedienteEnum? _tipoExpediente;
        public TipoExpedienteEnum TipoExpediente
        {
            get
            {
                if (!_tipoExpediente.HasValue)
                    _tipoExpediente = (TipoExpedienteEnum)(IdTipoExpediente);

                return _tipoExpediente.Value;
            }
        }

        private ExpedienteEstadoTipo? _tipoEstadoValue;
        public ExpedienteEstadoTipo? TipoEstadoValue
        {
            get
            {
                if (!_tipoEstadoValue.HasValue)
                    _tipoEstadoValue = (ExpedienteEstadoTipo?)(IdTipoEstadoLast);

                return _tipoEstadoValue;
            }
        }

        //private ExpedienteNegociacion _negociacion;
        ///// <summary>
        ///// Old (Mejor usar la propiedad ExpedienteNegociacion)
        ///// </summary>
        //public ExpedienteNegociacion Negociacion
        //{
        //    get
        //    {
        //        return _negociacion ?? (_negociacion = ExpedienteNegociacion);
        //    }
        //    set
        //    {
        //        _negociacion = value;
        //    }
        //}


        //public bool NegociacionEnCurso => ExpedienteNegociacion != null && (
        //        (ExpedienteNegociacion.PrecontenciosoFechaInicio.HasValue && !ExpedienteNegociacion.PrecontenciosoFechaFin.HasValue)
        //        ||
        //        (ExpedienteNegociacion.ContenciosoFechaInicio.HasValue && !ExpedienteNegociacion.ContenciosoFechaFin.HasValue)
        //    );

        public string DeudoresTitulo =>
            TipoExpediente == TipoExpedienteEnum.Alquiler ? "Titulares" :
            TipoExpediente == TipoExpedienteEnum.OrdinarioCs ? "Demandantes" :
            TipoExpediente == TipoExpedienteEnum.Concurso ? "Concursados" :
            TipoExpediente == TipoExpedienteEnum.Civil ? "Contrarios" :
            TipoExpediente == TipoExpedienteEnum.Penal ? "Contrarios" :
            TipoExpediente == TipoExpedienteEnum.Conciliacion ? "Demandados" :
            "Deudores";
        public bool DeudoresIsPosibleCrud =>
            TipoExpediente == TipoExpedienteEnum.Hipotecario
            || TipoExpediente == TipoExpedienteEnum.Concurso
            || TipoExpediente == TipoExpedienteEnum.Conciliacion
            || TipoExpediente == TipoExpedienteEnum.Ordinario
            || TipoExpediente == TipoExpedienteEnum.OrdinarioCs
            || TipoExpediente == TipoExpedienteEnum.Ejecutivo
            || TipoExpediente == TipoExpedienteEnum.Monitorio
            || TipoExpediente == TipoExpedienteEnum.Verbal
            || TipoExpediente == TipoExpedienteEnum.TomaPosesionAnticipada
            || TipoExpediente == TipoExpedienteEnum.JurisdiccionVoluntaria
            || TipoExpediente == TipoExpedienteEnum.Prelitigio
            || TipoExpediente == TipoExpedienteEnum.Alquiler;
        public bool CalendarioShow =>
            TipoExpediente == TipoExpedienteEnum.Hipotecario ||
            TipoExpediente == TipoExpedienteEnum.Ejecutivo ||
            TipoExpediente == TipoExpedienteEnum.Concurso ||
            TipoExpediente == TipoExpedienteEnum.TomaPosesionAnticipada ||
            TipoExpediente == TipoExpedienteEnum.Ordinario ||
            TipoExpediente == TipoExpedienteEnum.OrdinarioCs ||
            TipoExpediente == TipoExpedienteEnum.Alquiler ||
            TipoExpediente == TipoExpedienteEnum.Saneamiento ||
            TipoExpediente == TipoExpedienteEnum.Monitorio ||
            TipoExpediente == TipoExpedienteEnum.Penal ||
            TipoExpediente == TipoExpedienteEnum.Conciliacion ||
            TipoExpediente == TipoExpedienteEnum.JurisdiccionVoluntaria;
        public bool ShowInmuebles =>
            TipoExpediente != TipoExpedienteEnum.Verbal
            && TipoExpediente != TipoExpedienteEnum.JurisdiccionVoluntaria
            && TipoExpediente != TipoExpedienteEnum.Penal
            && TipoExpediente != TipoExpedienteEnum.JuraCuenta
            && TipoExpediente != TipoExpedienteEnum.Conciliacion
            && TipoExpediente != TipoExpedienteEnum.Civil;
        public bool ShowHipotecas =>
            TipoExpediente == TipoExpedienteEnum.Hipotecario
            || TipoExpediente == TipoExpedienteEnum.Ordinario;
        public bool ShowHoras =>
            TipoExpediente == TipoExpedienteEnum.Civil
            || TipoExpediente == TipoExpedienteEnum.Penal
            || TipoExpediente == TipoExpedienteEnum.JuraCuenta
            || TipoExpediente == TipoExpedienteEnum.Hipotecario;


        private Hip_Hipoteca _hioptecaEnEjecucion;
        public Hip_Hipoteca HipotecaEnEjecucion
        {
            get
            {
                if (_hioptecaEnEjecucion == null)
                {
                    if (Hip_Hipoteca.IsNotEmpty())
                        _hioptecaEnEjecucion = Hip_Hipoteca.FirstOrDefault(x => x.Ejecutar);
                    if (_hioptecaEnEjecucion == null)
                        _hioptecaEnEjecucion = Hip_Hipoteca.FirstOrDefault();
                }

                return _hioptecaEnEjecucion;
            }
        }

        #region ExpedienteEstado ...

        #region Alquiler

        private ExpedienteEstado _estadoAlquilerPresentacionDemanda;
        public ExpedienteEstado EstadoAlquilerPresentacionDemanda
        {
            get
            {
                if (_estadoAlquilerPresentacionDemanda == null)
                    _estadoAlquilerPresentacionDemanda = ExpedienteEstadoes.FirstOrDefault(x => x.IdTipoEstado == IdTipoEstadoAlqPresentDemanda);

                return _estadoAlquilerPresentacionDemanda;
            }
        }

        private ExpedienteEstado _estadoAlquilerTramitacionJuzgado;
        public ExpedienteEstado EstadoAlquilerTramitacionJuzgado
        {
            get
            {
                if (_estadoAlquilerTramitacionJuzgado == null)
                    _estadoAlquilerTramitacionJuzgado = ExpedienteEstadoes.FirstOrDefault(x => x.IdTipoEstado == IdTipoEstadoAlqTramitJuzgado);

                return _estadoAlquilerTramitacionJuzgado;
            }
        }

        private ExpedienteEstado _estadoAlquilerLanzamiento;
        public ExpedienteEstado EstadoAlquilerLanzamiento
        {
            get
            {
                if (_estadoAlquilerLanzamiento == null)
                    _estadoAlquilerLanzamiento = ExpedienteEstadoes.FirstOrDefault(x => x.IdTipoEstado == IdTipoEstadoAlqLanzamiento);

                return _estadoAlquilerLanzamiento;
            }
        }

        #endregion

        private ExpedienteEstado _estadoRecepcionExpediente;
        public ExpedienteEstado EstadoRecepcionExpediente
        {
            get
            {
                if (_estadoRecepcionExpediente == null)
                    _estadoRecepcionExpediente = ExpedienteEstadoes.FirstOrDefault(x => x.IdTipoEstado == 1);

                return _estadoRecepcionExpediente;
            }
        }

        private ExpedienteEstado _estadoRecepcion;
        public ExpedienteEstado EstadoRecepcion
        {
            get
            {
                if (_estadoRecepcion == null)
                    _estadoRecepcion = ExpedienteEstadoes.FirstOrDefault(x => x.Gnr_TipoEstado.Inicio);

                return _estadoRecepcion;
            }
        }

        //[NotMapped]
        //public string TipoEstadoLastName { get; set; }
        public string TipoEstadoLastName => ExpedienteEstadoLastTipo == null ? "" : ExpedienteEstadoLastTipo.Descripcion;
        public ExpedienteEstado EstadoActual => ExpedienteEstadoLast;

        public void ResetValoracion()
        {
            if (!ValoracionJuzgado.HasValue) ValoracionJuzgado = 0;
            if (!ValoracionProcurador.HasValue) ValoracionProcurador = 0;
            if (!ValoracionAdministrador.HasValue) ValoracionAdministrador = 0;
            if (!ValoracionAbogado.HasValue) ValoracionAbogado = 0;
            if (!ValoracionCliente.HasValue) ValoracionCliente = 0;
        }

        //private ExpedienteEstado _estadoActual;

        //public ExpedienteEstado EstadoActual
        //{
        //    get
        //    {
        //        if (_estadoActual == null)
        //            _estadoActual = ExpedienteEstadoes.OrderBy(x => x.Fecha).LastOrDefault();

        //        return _estadoActual;
        //    }
        //}


        //Hip presentacion demanda
        private ExpedienteEstado _estadoPresentacionDemanda;

        public ExpedienteEstado EstadoPresentacionDemanda
        {
            get
            {
                if (_estadoPresentacionDemanda == null)
                    _estadoPresentacionDemanda =
                        ExpedienteEstadoes.OrderBy(x => x.Fecha).LastOrDefault(x => x.Hip_ExpedienteEstadoPresentacionDemanda != null);

                return _estadoPresentacionDemanda;
            }
        }


        //Hip procedimientojuzgado
        private ExpedienteEstado _estadoProcedimientoJuzgado;

        public ExpedienteEstado EstadoProcedimientoJuzgado
        {
            get
            {
                if (_estadoProcedimientoJuzgado == null)
                    _estadoProcedimientoJuzgado =
                        ExpedienteEstadoes.OrderBy(x => x.Fecha)
                            .LastOrDefault(x => x.HipExpedienteEstadoTramitacionSubasta != null);

                return _estadoProcedimientoJuzgado;
            }
        }


        //Hip subasta
        private ExpedienteEstado _estadoSubasta;

        public ExpedienteEstado EstadoSubasta
        {
            get
            {
                if (_estadoSubasta == null)
                    _estadoSubasta =
                        ExpedienteEstadoes.OrderBy(x => x.Fecha).LastOrDefault(x => x.Hip_ExpedienteEstadoSubasta != null);

                return _estadoSubasta;
            }
        }


        //Hip adjudicacion del bien
        private ExpedienteEstado _estadoAdjudicacionDelBien;

        public ExpedienteEstado EstadoAdjudicacionDelBien
        {
            get
            {
                if (_estadoAdjudicacionDelBien == null)
                    _estadoAdjudicacionDelBien =
                        ExpedienteEstadoes.OrderBy(x => x.Fecha).LastOrDefault(x => x.Hip_ExpedienteEstadoAdjudicacion != null);

                return _estadoAdjudicacionDelBien;
            }
        }

        //Hip Dato Requerimiento
        private ExpedienteEstado _estadoDatoRequerimiento;

        public ExpedienteEstado EstadoDatoRequerimiento
        {
            get
            {
                if (_estadoDatoRequerimiento == null)
                    _estadoDatoRequerimiento =
                        ExpedienteEstadoes.OrderBy(x => x.Fecha).LastOrDefault(x => x.Hip_ExpedienteEstadoDatoRequerimiento != null);

                return _estadoDatoRequerimiento;
            }
        }


        //Con convenio
        private ExpedienteEstado _estadoConcursalFaseConvenio;

        public ExpedienteEstado EstadoConcursalFaseConvenio
        {
            get
            {
                if (_estadoConcursalFaseConvenio == null)
                    _estadoConcursalFaseConvenio =
                        ExpedienteEstadoes.LastOrDefault(x => x.Con_ExpedienteEstadoConvenio != null);

                return _estadoConcursalFaseConvenio;
            }
        }



        //Con comun
        private ExpedienteEstado _estadoConcursalFaseComun;
        public ExpedienteEstado EstadoConcursalFaseComun
        {
            get
            {
                if (_estadoConcursalFaseComun == null)
                    _estadoConcursalFaseComun =
                        ExpedienteEstadoes.LastOrDefault(x => x.Con_ExpedienteEstadoComun != null);

                return _estadoConcursalFaseComun;
            }
        }



        //Con finalizado
        private ExpedienteEstado _estadoConcursalFaseFinalizado;
        public ExpedienteEstado EstadoConcursalFaseFinalizado
        {
            get
            {
                if (_estadoConcursalFaseFinalizado == null)
                    _estadoConcursalFaseFinalizado =
                        ExpedienteEstadoes.LastOrDefault(x => x.Con_ExpedienteEstadoFinalizado != null);

                return _estadoConcursalFaseFinalizado;
            }
        }

        //Con calificacion
        //private ExpedienteEstado _estadoConcursalFaseCalificacion;
        //public ExpedienteEstado EstadoConcursalFaseCalificacion
        //{
        //    get
        //    {
        //        if (_estadoConcursalFaseCalificacion == null)
        //            _estadoConcursalFaseCalificacion =
        //                ExpedienteEstadoes.LastOrDefault(x => x.Con_ExpedienteEstadoCalificacion != null);

        //        return _estadoConcursalFaseCalificacion;
        //    }
        //}

        private ExpedienteEstado _estadoConcursalFaseLiquidacion;
        public ExpedienteEstado EstadoConcursalFaseLiquidacion
        {
            get
            {
                if (_estadoConcursalFaseLiquidacion == null)
                    _estadoConcursalFaseLiquidacion =
                        ExpedienteEstadoes.LastOrDefault(x => x.Con_ExpedienteEstadoLiquidacion != null);

                return _estadoConcursalFaseLiquidacion;
            }
        }

        public ExpedienteTituloEjecutivo TituloEjecutivoLast =>
            ExpedienteTituloEjecutivoSet.IsEmpty() ? null :
            ExpedienteTituloEjecutivoSet.OrderByDescending(x => x.FechaSolicitud).FirstOrDefault();

        #endregion

        private string _procuradorNombreCompleto;
        public string ProcuradorNombreCompleto
        {
            get
            {

                if (string.IsNullOrWhiteSpace(_procuradorNombreCompleto)
                    && (HipotecaEnEjecucion != null))
                {
                    if (HipotecaEnEjecucion.Gnr_Persona.Gnr_Procurador != null)
                    {
                        _procuradorNombreCompleto = HipotecaEnEjecucion.Gnr_Persona.Gnr_Procurador.NombreCompleto;

                    }
                    else
                    {
                        _procuradorNombreCompleto = "Pendiente Por Asignar";
                    }
                }



                return _procuradorNombreCompleto;
            }
        }

        //Obsoleto (En el futuro deberiamos eliminarlo)
        public string JuzgadoName => Juzgado == null ? "" : Juzgado.Nombre;
        public string ProcuradorName => Gnr_Procurador?.Gnr_Persona == null ? "" : Gnr_Procurador.Gnr_Persona.NombreApellidos;
        public string AbogadoName => Gnr_Abogado?.Persona == null ? "" : Gnr_Abogado.Persona.NombreApellidos;

        #region Deudor Principal

        private ExpedienteDeudor _deudorPrincipal;
        public ExpedienteDeudor DeudorPrincipal
        {
            get
            {
                if (_deudorPrincipal == null)
                {
                    _deudorPrincipal = ExpedienteDeudors.FirstOrDefault(x => x.IdTipoDeudor == 1);
                    if (_deudorPrincipal == null) _deudorPrincipal = ExpedienteDeudors.FirstOrDefault();
                }

                return _deudorPrincipal;
            }
        }

        public ExpedienteDeudor DeudorAdministradorConcursal => ExpedienteDeudors.FirstOrDefault(x => x.IdTipoDeudor == 22);

        public string DeudorPrincipalNombreApellidos => DeudorPrincipal?.Gnr_Persona?.NombreApellidos;

        public ExpedienteAcuerdo ExpedienteAcuerdoLast => ExpedienteAcuerdoSet.OrderByDescending(x => x.FechaPropuesta).FirstOrDefault();

        #endregion

        #region Hip_Inmueble / InmuebleFirst

        private Hip_Inmueble _inmuebleFirst;

        public Hip_Inmueble InmuebleFirst
        {
            get
            {
                if (_inmuebleFirst == null)
                    _inmuebleFirst = Hip_Inmueble.FirstOrDefault();

                return _inmuebleFirst;
            }
        }

        public ExpedienteContrato ExpedienteContratoFirst => ExpedienteContratoSet.FirstOrDefault();

        public decimal? InmueblePrestamoCapital => Hip_Inmueble.IsEmpty() ? (decimal?)null : Hip_Inmueble.Sum(x => x.PrestamoCapital);

        public decimal? InmuebleTipoSubasta => Hip_Inmueble.IsEmpty() ? (decimal?)null : Hip_Inmueble.Sum(x => x.TipoSubasta);

        #endregion

        #region Vistas

        private ExpedienteVista _ultimaVista;

        public ExpedienteVista UltimaVistaCalculada
        {
            get
            {
                if (_ultimaVista == null)
                    _ultimaVista = ExpedienteVistas.OrderByDescending(x => x.IdExpedienteVista).FirstOrDefault();

                return _ultimaVista;
            }
        }

        private ExpedienteVista _ultimaVistaLanzamiento;

        public ExpedienteVista UltimaVistaLanzamientoCalculada
        {
            get
            {
                if (_ultimaVistaLanzamiento == null)
                    _ultimaVistaLanzamiento = ExpedienteVistas
                        .Where(y => y.IdTipoVista == 37)
                        .OrderByDescending(x => x.IdExpedienteVista)
                        .FirstOrDefault();

                return _ultimaVistaLanzamiento;
            }
        }

        private ExpedienteVista _ultimaVistaDistintaLanzamiento;

        public ExpedienteVista UltimaVistaDistintaLanzamientoCalculada
        {
            get
            {
                if (_ultimaVistaDistintaLanzamiento == null)
                    _ultimaVistaDistintaLanzamiento = ExpedienteVistas
                        .Where(y => y.IdTipoVista != 37)
                        .OrderByDescending(x => x.IdExpedienteVista)
                        .FirstOrDefault();

                return _ultimaVistaDistintaLanzamiento;
            }
        }

        #endregion

        #region Estados

        private ExpedienteEstado _presentacionDemanda;

        public ExpedienteEstado EstadoPresentacionDemandaCalculada
        {
            get
            {

                if (_presentacionDemanda == null)
                {
                    var lstEstadosPD = new List<int> { IdTipoEstadoHipPresentDemanda, IdTipoEstadoAlqPresentDemanda };
                    _presentacionDemanda = ExpedienteEstadoes
                       .Where(x => lstEstadosPD.Contains(x.IdTipoEstado))
                       .OrderByDescending(x => x.Fecha)
                       .FirstOrDefault();
                }

                return _presentacionDemanda;
            }
        }

        private ExpedienteEstado _presentacionDenuncia;
        public ExpedienteEstado EstadoPresentacionDenunciaCalculada
        {
            get
            {

                if (_presentacionDenuncia == null)
                {
                    var lstEstadosPD = new List<int> { IdTipoEstadoAlqPresentDenuncia };
                    _presentacionDenuncia = ExpedienteEstadoes
                       .Where(x => lstEstadosPD.Contains(x.IdTipoEstado))
                       .OrderByDescending(x => x.Fecha)
                       .FirstOrDefault();
                }

                return _presentacionDenuncia;
            }
        }

        private ExpedienteEstado _estadoLanzamiento;

        public ExpedienteEstado EstadoLanzamientoCalculada
        {
            get
            {

                if (_estadoLanzamiento == null)
                {
                    var lstEstados = new List<int> { IdTipoEstadoAlqLanzamiento };
                    _estadoLanzamiento = ExpedienteEstadoes
                       .Where(x => lstEstados.Contains(x.IdTipoEstado))
                       .OrderByDescending(x => x.Fecha)
                       .FirstOrDefault();
                }

                return _estadoLanzamiento;
            }
        }

        #endregion


        private string _anotaciones;
        public string Anotaciones
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_anotaciones))
                {
                    var sb = new StringBuilder();
                    foreach (var nota in ExpedienteNotaSet)
                        sb.AppendLine(nota.ToString());

                    _anotaciones = sb.ToString();
                }

                return _anotaciones;
            }
        }

        private string _vencimientosSinEjecutar;
        public string VencimientosSinEjecutar
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_vencimientosSinEjecutar))
                {
                    var sb = new StringBuilder();
                    foreach (var vencimiento in ExpedienteVencimientoSet.Where(x => !x.Ejecutado && x.TipoVencimiento == TipoVencimiento.Vencimiento))
                        sb.AppendLine(vencimiento.ToString());

                    _vencimientosSinEjecutar = sb.ToString();
                }

                return _vencimientosSinEjecutar;
            }
        }

        public int? IdAreaNegocioReadOnly =>
            IdTipoArea == 3 || (new List<int> { IdTipoExpedienteAlquiler, IdTipoExpedienteOrdinarioCs }).Contains(IdTipoExpediente) ? AREANEGOCIO_ALQUILER :
            IdTipoExpediente == IdTipoExpedienteConcurso ? AREANEGOCIO_CyM :
            (new List<int> { 11, 25, 20 }).Contains(IdTipoExpediente) ? AREANEGOCIO_LEGAL :
            (new List<int> { 1, 3, 14, 17, 8, 2, 22, 24, 16 }).Contains(IdTipoExpediente) ? AREANEGOCIO_RECUPERACIONES :
            (int?)null;

        public int? TotalDaysBetweenH1AndH2 => FechaFacturableH1.HasValue && FechaFacturableH2.HasValue ? FechaFacturableH1.Value.GetDaysBetweenDates(FechaFacturableH2.Value) : (int?)null;
        public int? TotalDaysBetweenH1AndH3 => FechaFacturableH1.HasValue && FechaFacturableH3.HasValue ? FechaFacturableH1.Value.GetDaysBetweenDates(FechaFacturableH3.Value) : (int?)null;

        public bool Veniado => EsHeredado;

        #endregion

        #region Methods

        public static Expediente GetExpedienteSingle(int idExpediente, ChmSaceContext ctx)
        {
            Expediente result = null;
            result = ctx.Expedientes.FirstOrDefault(c => c.IdExpediente.Equals(idExpediente));
            return result;
        }

        public string ValidateToDemanda()
        {
            var error = string.Empty;

            if (HipotecaEnEjecucion == null)
                error += "Error: El expediente no tiene ninguna hipoteca marcada para ejecutar.<br>";
            if (string.IsNullOrEmpty(HipotecaEnEjecucion.Registro))
                error += "Error - Hipoteca: Introduzca Registro de la Propiedad.<br>";
            if (HipotecaEnEjecucion.Hip_HipotecaDatoEscritura == null || HipotecaEnEjecucion.Hip_HipotecaDatoEscritura.Count() == 0)
                error += "Error - Hipoteca: Debe introducir los siguientes datos de la escritura: fecha de la escritura, el notario, el colegio del notario y el protocolo de la hipoteca en ejecución.<br>";
            if (string.IsNullOrEmpty(HipotecaEnEjecucion.NotarioFijacion) ||
                string.IsNullOrEmpty(HipotecaEnEjecucion.ColegioNotarioFijacion))
                error += "Error - Hipoteca: Debe introducir el notario y colegio de fijación.<br>";
            if (!HipotecaEnEjecucion.PrestamoCapital.HasValue)
                error += "Error - Hipoteca: Debe introducir el capital del prestamo.<br>";
            if (!HipotecaEnEjecucion.FechaPrimeraCuotaImpagada.HasValue || !HipotecaEnEjecucion.FechaCierre.HasValue)
                error += "Error - Hipoteca: Debe introducir la fecha de la ultima cuota pagada y la fecha de cierre.<br>";

            if (!HipotecaEnEjecucion.DemandaFecha.HasValue) error += "Error - Debe especificar la fecha de la demanda (Hipoteca.DemandaFecha).";
            if (!HipotecaEnEjecucion.FechaCierre.HasValue) error += "Error - Debe especificar la fecha de cierre (Hipoteca.FechaCierre).";
            if (!HipotecaEnEjecucion.FechaActaFijacion.HasValue) error += "Error - Debe especificar la fecha del Acta de Fijación (Hipoteca.FechaActaFijacion).";

            return error;
        }

        internal void ActualizarHitos()
        {
            #region Actualizar hitos (FechaHitoInicio - FechaHitoFin)

            var estado = ExpedienteEstadoes.FirstOrDefault(x => x.Gnr_TipoEstado.Inicio);
            FechaHitoInicio = estado?.Fecha; //estado?.FechaAlta.GetMinDateTime(estado.FechaFin);

            estado = ExpedienteEstadoes.FirstOrDefault(x => x.Gnr_TipoEstado.Fin);
            FechaHitoFin = estado?.Fecha; //estado?.FechaAlta.GetMinDateTime(estado.Fecha);
            Fin = estado?.Fecha;

            #endregion

            #region Actualizar hitos (FechaHito1 - FechaHito2 - FechaHito3)

            estado = ExpedienteEstadoes.FirstOrDefault(x => x.Gnr_TipoEstado.Hito1);
            FechaHito1 = estado?.Fecha; //estado?.FechaAlta.GetMinDateTime(estado.Fecha);

            estado = ExpedienteEstadoes.FirstOrDefault(x => x.Gnr_TipoEstado.Hito2);
            FechaHito2 = estado?.Fecha; //estado?.FechaAlta.GetMinDateTime(estado.Fecha);

            estado = ExpedienteEstadoes.FirstOrDefault(x => x.Gnr_TipoEstado.Hito3);
            FechaHito3 = estado?.Fecha; //estado?.FechaAlta.GetMinDateTime(estado.Fecha);

            #endregion
        }

        public string GetTimeWorked()
        {
            return TimeSpan.FromMinutes(TimeWorkedMinutes).ToString(@"hh\:mm");


            //if (ExpedienteEstadoes.IsEmpty()) return null;
            //var totalMin = ExpedienteEstadoes.Sum(x => x.TimeWorkedMinutes);
            //return TimeSpan.FromMinutes(totalMin).ToString(@"hh\:mm");
        }

        public List<ModelEtapa> GetEtapas()
        {
            var result = new List<ModelEtapa>();

            switch (TipoExpediente)
            {
                case TipoExpedienteEnum.Hipotecario:

                    var etapa1 = new ModelEtapa(1, "Recepción", ExpedienteEstadoes.FirstOrDefault(x => x.IdTipoEstado == 1));
                    var etapa2 = new ModelEtapa(2, "Demanda", ExpedienteEstadoes.FirstOrDefault(x => x.IdTipoEstado == 3));
                    var etapa3 = new ModelEtapa(3, "Tramite Jzgdo.", ExpedienteEstadoes.FirstOrDefault(x => x.IdTipoEstado == 4));
                    var etapa4 = new ModelEtapa(4, "Subasta", ExpedienteEstadoes.FirstOrDefault(x => x.IdTipoEstado == 4));
                    var etapa5 = new ModelEtapa(5, "Adjudicación", ExpedienteEstadoes.FirstOrDefault(x => x.IdTipoEstado == 7));

                    if (ExpedienteEstadoLast?.TipoEstadoValue == ExpedienteEstadoTipo.HipotecarioTramitacionSubasta && !etapa3.Fin.HasValue)
                    {
                        etapa4.Inicio = ExpedienteSubastaLast == null ? (DateTime?)null : ExpedienteSubastaLast.FechaSolicitud;
                        etapa3.Fin = etapa4.Inicio;
                    }

                    result.Add(etapa1);
                    result.Add(etapa2);
                    result.Add(etapa3);
                    result.Add(etapa4);
                    result.Add(etapa5);

                    return result;
                //case TipoExpedienteEnum.Monitorio:
                //    break;
                //case TipoExpedienteEnum.Ejecutivo:
                //    break;
                //case TipoExpedienteEnum.Concurso:
                //    break;
                //case TipoExpedienteEnum.Alquiler:
                //    break;
                //case TipoExpedienteEnum.HipotecarioMayorCuantia:
                //    break;
                //case TipoExpedienteEnum.Cambiario:
                //    break;
                //case TipoExpedienteEnum.Verbales:
                //    break;
                //case TipoExpedienteEnum.Administrativos:
                //    break;
                //case TipoExpedienteEnum.Penal:
                //    break;
                //case TipoExpedienteEnum.Laboral:
                //    break;
                //case TipoExpedienteEnum.Negociacion:
                //    break;
                //case TipoExpedienteEnum.Ordinario:
                //    break;
                case TipoExpedienteEnum.OrdinarioCs:
                    if (ExpedienteEstadoes.Any(x => x.IdTipoEstado == 1513)) // Allanamiento Total
                    {
                        #region Allanamiento Total

                        result.Add(new ModelEtapa(1, "Recepción", ExpedienteEstadoes.FirstOrDefault(x => x.IdTipoEstado == 1501)));
                        result.Add(new ModelEtapa(2, "Allanamiento Total", ExpedienteEstadoes.FirstOrDefault(x => x.IdTipoEstado == 1513)));
                        result.Add(new ModelEtapa(3, "Sentencia", ExpedienteEstadoes.FirstOrDefault(x => x.IdTipoEstado == 1507)));

                        #endregion
                    }
                    else if (ExpedienteEstadoes.Any(x => x.IdTipoEstado == 1514)) // Allanamiento Parcial
                    {
                        #region Allanamiento Parcial

                        result.Add(new ModelEtapa(1, "Recepción", ExpedienteEstadoes.FirstOrDefault(x => x.IdTipoEstado == 1501)));
                        result.Add(new ModelEtapa(2, "Allanamiento Parcial", ExpedienteEstadoes.FirstOrDefault(x => x.IdTipoEstado == 1514)));
                        result.Add(new ModelEtapa(3, "Audiencia Previa", ExpedienteEstadoes.FirstOrDefault(x => x.IdTipoEstado == 1503)));
                        result.Add(new ModelEtapa(4, "Juicio", ExpedienteEstadoes.FirstOrDefault(x => x.IdTipoEstado == 1505)));
                        result.Add(new ModelEtapa(5, "Sentencia", ExpedienteEstadoes.FirstOrDefault(x => x.IdTipoEstado == 1507)));

                        #endregion
                    }
                    else // Acuerdo
                    {
                        #region Acuerdo

                        result.Add(new ModelEtapa(1, "Recepción", ExpedienteEstadoes.FirstOrDefault(x => x.IdTipoEstado == 1501)));
                        result.Add(new ModelEtapa(2, "Acuerdo", ExpedienteEstadoes.FirstOrDefault(x => x.IdTipoEstado == 1510)));
                        result.Add(new ModelEtapa(3, "Fin", ExpedienteEstadoes.FirstOrDefault(x => x.IdTipoEstado == 1512)));

                        #endregion
                    }
                    return result;

                //case TipoExpedienteEnum.TomaPosesionAnticipada:
                //    break;
                //case TipoExpedienteEnum.JurisdiccionVoluntaria:
                //    break;
                default:
                    return result;
            }
        }

        public void RefreshBy(Expediente model)
        {
            ReferenciaExterna = model.ReferenciaExterna;
            Referencia2 = model.Referencia2;
            Nic = model.Nic;
            FechaCierre = model.FechaCierre;
            IdTipoArea = model.IdTipoArea;
            DeudaFinal = model.DeudaFinal;
            NoAuto = model.NoAuto;
            IdAbogado = model.IdAbogado;
            IdPartidoJudicial = model.IdPartidoJudicial;
            IdProcurador = model.IdProcurador;
            IdClienteOficina = model.IdClienteOficina;
            IdPagador = model.IdPagador;
            IdJuzgado = model.IdJuzgado;
            FechaModificacion = DateTime.Now;
            AvisoImportante = model.AvisoImportante;
            EsHeredado = model.EsHeredado;
            IdVeniadoHitoFacturacion = model.IdVeniadoHitoFacturacion;
            EsNofacturable = model.EsNofacturable;
            FacturacionCompleta = model.FacturacionCompleta;
            FechaCargaAppCliente = model.FechaCargaAppCliente;
            IdCartera = model.IdCartera;
            SucesionPresentada = model.SucesionPresentada;
            SucesionAcordada = model.SucesionAcordada;
            SucesionCopiaSellada = model.SucesionCopiaSellada;
            SucesionOposicion = model.SucesionOposicion;
            SucesionDenegada = model.SucesionDenegada;
            IdSucesionCausaIncidencia = model.IdSucesionCausaIncidencia;
            IdSucesionEstadoProcesalCliente = model.IdSucesionEstadoProcesalCliente;
            IdSucesionProblemasDetalles = model.IdSucesionProblemasDetalles;
            SucesionRecurrida = model.SucesionRecurrida;
            SucesionResultadoRecuso = model.SucesionResultadoRecuso;
            ValoracionAdministrador = model.ValoracionAdministrador;
            ValoracionJuzgado = model.ValoracionJuzgado;
            ValoracionProcurador = model.ValoracionProcurador;
            ValoracionAbogado = model.ValoracionAbogado;
            ValoracionCliente = model.ValoracionCliente;
            EsRelevante = model.EsRelevante;
            EsConfidencial = model.EsConfidencial;
            InactivoInterno = model.InactivoInterno;
            GestorCliente = model.GestorCliente;
            IdAccionPropuesta = model.IdAccionPropuesta;
            IdAreaNegocio = IdAreaNegocioReadOnly;
            ImpFacturableExtrajudicial = model.ImpFacturableExtrajudicial;

            if (IdTipoExpediente == 4) //Consursal CyM
                ImpFacturableH6 = model.ImpFacturableH6;

            ReferenciaReoco = model.ReferenciaReoco;
            ServicioIntegral = model.ServicioIntegral;
            ReferenciaJudicial = model.ReferenciaJudicial;
            IdSubTipoProcedimiento = model.IdSubTipoProcedimiento;
        }

        #endregion
    }

    public class ModelEtapa
    {
        public ModelEtapa() { }
        public ModelEtapa(int orden, string name, ExpedienteEstado estado)
        {
            Orden = orden;
            Nombre = name;
            if (estado != null)
            {
                Inicio = estado.Fecha;
                Fin = estado.FechaFin;
            }
        }

        public int Orden { get; set; }
        public string Nombre { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fin { get; set; }
    }

    public class ModelNota
    {
        public int ContactoTipo1 { get; set; }
        public int ContactoTipo2 { get; set; }
        public int ContactoTipo3 { get; set; }
        public int ContactoTipo4 { get; set; }
    }

    public class ModelSituacion
    {
        public DateTime? HipFechaDemandaPresentacion { get; set; }
        public DateTime? HipFechaDemandaAdmision { get; set; }
        public DateTime? HipFechaReqPositivoAndCertifCarga { get; set; }
        public DateTime? HipFechaSubastaDecreto { get; set; }
        public DateTime? HipFechaSubastaCelebracion { get; set; }
        public DateTime? HipFechaAdjudicacion { get; set; }



        public DateTime? HipFechaCertificacionCarga { get; set; }

        public DateTime? HipFechaReqPagoPositivo { get; set; }


        public string Situacion =>
            HipFechaAdjudicacion.HasValue ? "Adjudicado" :
            HipFechaSubastaCelebracion.HasValue && !HipFechaAdjudicacion.HasValue ? "Pdte. Adjudicación" :
            HipFechaSubastaDecreto.HasValue && !HipFechaSubastaCelebracion.HasValue ? "Pdte. Cierre Subasta" :
            HipFechaReqPositivoAndCertifCarga.HasValue && !HipFechaSubastaDecreto.HasValue ? "Pdte. Dec. Subasta" :
            HipFechaDemandaAdmision.HasValue && !HipFechaReqPositivoAndCertifCarga.HasValue ? "Pdte. Req.+ / Cert.Catga" :
            HipFechaDemandaPresentacion.HasValue && !HipFechaDemandaAdmision.HasValue ? "Pdte. Admisión Demanda" :
            "Otro";

        public DateTime? FechaBase =>
            Situacion == "Pdte. Admisión Demanda" ? HipFechaDemandaPresentacion :
            Situacion == "Pdte. Req.+ / Cert.Catga" ? HipFechaDemandaAdmision :
            Situacion == "Pdte. Dec. Subasta" ? HipFechaReqPositivoAndCertifCarga :
            Situacion == "Pdte. Cierre Subasta" ? HipFechaSubastaDecreto :
            Situacion == "Pdte. Adjudicación" ? HipFechaSubastaCelebracion :
            null;

        public int DaysCount => FechaBase.GetTotalDays();
        public int DaysCountFP => FechaBase.GetTotalDays() - (Situacion == "Pdte. Req.+ / Cert.Catga" ? 180 : 90);

        public string SituacionPLazo => DaysCountFP > 0 ? "FP" : "EP";

        public ModelSituacionHito Hito1 { get; set; }
        public ModelSituacionHito Hito2 { get; set; }
        public ModelSituacionHito Hito3 { get; set; }
        public ModelSituacionHito Hito4 { get; set; }
        public ModelSituacionHito Hito5 { get; set; }
        public ModelSituacionHito Hito6 { get; set; }

        internal void RefreshAllHito()
        {
            Hito1 = buildModelSituacionHito(TipoHitoSegunFechaEstado.HipDemandaAdmision, HipFechaDemandaPresentacion, HipFechaDemandaAdmision);
            Hito2 = buildModelSituacionHito(TipoHitoSegunFechaEstado.HipCertificacionCarga, HipFechaDemandaAdmision, HipFechaCertificacionCarga);
            Hito3 = buildModelSituacionHito(TipoHitoSegunFechaEstado.HipReqPagoPositivo, HipFechaDemandaAdmision, HipFechaReqPagoPositivo);
            Hito4 = buildModelSituacionHito(TipoHitoSegunFechaEstado.HipSubastaDecreto, HipFechaReqPagoPositivo, HipFechaSubastaDecreto);
            Hito5 = buildModelSituacionHito(TipoHitoSegunFechaEstado.HipSubastaCelebracion, HipFechaSubastaDecreto, HipFechaSubastaCelebracion);
            Hito6 = buildModelSituacionHito(TipoHitoSegunFechaEstado.HipAdjudicacion, HipFechaSubastaCelebracion, HipFechaAdjudicacion);
        }

        private ModelSituacionHito buildModelSituacionHito(TipoHitoSegunFechaEstado tipoHito, DateTime? fechaInicio, DateTime? fechaFin)
        {
            if (!fechaInicio.HasValue || !fechaFin.HasValue) return null;

            return new ModelSituacionHito(tipoHito, fechaInicio.Value, fechaFin.Value);
        }
    }

    public class ModelSituacionHito
    {
        public ModelSituacionHito() { }

        public ModelSituacionHito(TipoHitoSegunFechaEstado tipoHito, DateTime inicio, DateTime fin)
        {
            Hito = tipoHito;
            Inicio = inicio;
            Fin = fin;
        }

        public TipoHitoSegunFechaEstado Hito { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime? Fin { get; set; }

        public int? TotalDays => Fin.HasValue ? Inicio.GetDaysBetweenDates(Fin.Value) : (int?)null;
    }
}
