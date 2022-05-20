using Solvtio.Common;
using Solvtio.Data.Models.Dtos;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public class ModelExpedienteEdit : ModelExpediente
    {
        #region Properties

        public string Referencia2 { get; set; }
        public string ReferenciaReoco { get; set; }
        public string Nic { get; set; }
        public string ReferenciaJudicial { get; set; }
        public string RefKmaleon { get; set; }
        public int IdTipoExpediente { get; set; }
        public int IdTipoArea { get; set; }
        public int IdClienteOficina { get; set; }
        public int? IdAbogado { get; set; }
        public int? IdProcurador { get; set; }
        public int? IdPagador { get; set; }

        public DateTime? FechaCierre { get; set; }
        public DateTime? Archivado { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime? FinPrevisto { get; set; }

        //public string Usuario { get; set; }
        //public string Observaciones { get; set; }
        public decimal? DeudaFinal { get; set; }
        public int? IdExpedienteNegociacion { get; set; }
        public int? IdExpedienteFather { get; set; }
        public int? IdExpedienteSon { get; set; }
        public int? IdExpedienteBrother { get; set; }
        //public int? IdTipoEstadoLast { get; set; }
        //public virtual Gnr_TipoEstado ExpedienteEstadoLastTipo { get; set; }
        public int? IdEstadoLast { get; set; }
        //public virtual ExpedienteEstado ExpedienteEstadoLast { get; set; }
        public int? IdExpedienteFaseClienteLast { get; set; }
        public int? IdExpedienteSubastaLast { get; set; }
        //public virtual ExpedienteSubasta ExpedienteSubastaLast { get; set; }
        public int? IdDeudorPrincipal { get; set; }
        //public virtual Gnr_Persona Gnr_Persona { get; set; }
        public int? IdAreaNegocio { get; set; }
        //public virtual AreaNegocio AreaNegocio { get; set; }
        public string NoAuto { get; set; }
        public int? IdJuzgado { get; set; }
        //public virtual Juzgado Juzgado { get; set; }
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
        //public virtual CaracteristicaBase VeniadoHitoFacturacion { get; set; }
        public bool EsRelevante { get; set; }
        public bool EsConfidencial { get; set; }
        public bool InactivoInterno { get; set; }
        public bool EsNofacturable { get; set; }
        public bool FacturacionCompleta { get; set; }
        public DateTime? FechaCargaAppCliente { get; set; }
        public decimal? ImportePreFactura { get; set; } //Readonly
        public int? IdCartera { get; set; }
        //public virtual Cartera Cartera { get; set; }
        public DateTime? SucesionPresentada { get; set; }
        public DateTime? SucesionAcordada { get; set; }
        public DateTime? SucesionCopiaSellada { get; set; }

        public DateTime? SucesionDenegada { get; set; }

        public bool SucesionOposicion { get; set; }


        public DateTime? SucesionRecurrida { get; set; }
        public TipoResultadoApelacion? SucesionResultadoRecuso { get; set; }


        public int? IdSucesionCausaIncidencia { get; set; }
        //public virtual CaracteristicaBase SucesionCausaIncidencia { get; set; }

        public int? IdSucesionEstadoProcesalCliente { get; set; }
        //public virtual CaracteristicaBase SucesionEstadoProcesalCliente { get; set; }

        public int? IdSucesionProblemasDetalles { get; set; }
        //public virtual CaracteristicaBase SucesionProblemasDetalles { get; set; }

        //public int? ValoracionJuzgado { get; set; }
        //public int? ValoracionProcurador { get; set; }
        //public int? ValoracionAdministrador { get; set; }
        //public int? ValoracionAbogado { get; set; }
        //public int? ValoracionCliente { get; set; }

        public string Origen { get; set; }

        public int? IdAccionPropuesta { get; set; }
        //public virtual Gnr_ListasValores_Valores AccionPropuesta { get; set; }

        public int? IdSubTipoProcedimiento { get; set; }
        //public virtual CaracteristicaBase SubTipoProcedimiento { get; set; }

        public string ContratoRef { get; set; }
        public bool ServicioIntegral { get; set; }

        #endregion
    }

    public class ModelExpediente
    {
        #region Constructors
        public ModelExpediente()
        {
        }

        public ModelExpediente(Expediente exp)
        {
            //	this.IdExpediente = exp.IdExpediente;
            //	this.NoExpediente = exp.NoExpediente;
            //	this.ReferenciaExterna = exp.ReferenciaExterna;
            //	this.TipoExpediente = (TipoExpedienteEnum)exp.IdTipoExpediente;
            //	this.ClienteOficina = new ModelClienteOficina(exp.Gnr_ClienteOficina);
            //	this.DeudorPrincipal = new ModelPersona(exp.ExpedienteDeudors.FirstOrDefault()); //DeudorPrincipal;
            //	this.FechaAlta = exp.FechaAlta;
            //	this.Importe = new ModelMoney(exp.DeudaFinal);
            //	this.EstadoActual = new ModelEstado(exp.EstadoActual);
            //	this.Procurador = new ModelPersona(exp.Gnr_Procurador);
        }

        #endregion

        #region Properties

        [Key]
        public int IdExpediente { get; set; }
        public string NoExpediente { get; set; }
        public string ReferenciaExterna { get; set; }
        public string NoAuto { get; set; }

        public DateTime? Inicio { get; set; }
        public DateTime? Fin { get; set; }
        public DateTime? FechaAlta { get; set; }

        public decimal? DeudaFinal { get; set; }

        public int? IdEstadoLast { get; set; }
        public EstadoDtoMin Estado { get; set; }

        public DtoIdNombre Deudor { get; set; }
        public DtoIdNombre Abogado { get; set; }
        public DtoIdNombre Oficina { get; set; }
        public DtoIdNombre TipoExpediente { get; set; }
        public DtoIdNombre Juzgado { get; set; }

        #endregion

        #region Properties ReadOnly
        //private int? _subastasSenaladasTotal;
        //public int SubastasSenaladasTotal
        //{
        //    get
        //    {
        //        if (!_subastasSenaladasTotal.HasValue)
        //            _subastasSenaladasTotal = this.LstResumenMes.Sum(x => x.SubastasSenaladas);

        //        return _subastasSenaladasTotal.Value;
        //    }
        //}
        #endregion
    }

    [NotMapped]
    public class ModelExpedienteToKpi : ModelExpediente
    {
        public int IdTipoExpediente { get; set; }
        ////[ForeignKey("IdClienteOficina")]
        //[NotMapped]
        //public Gnr_ClienteOficina Gnr_ClienteOficina { get; set; }

        public int? ExpedienteEstadoLastId { get; set; }
        public int? ExpedienteEstadoLastIdTipoEstado { get; set; }
        public int? ExpedienteEstadoLastIdTipoSubFaseEstado { get; set; }
        public DateTime? ExpedienteEstadoLastFecha { get; set; }
        //public int? ExpedienteEstadoLast { get; set; }        

    }

    public class ExpedienteHipDto
    {
        #region Constructors
        public ExpedienteHipDto()
        {
        }

        public ExpedienteHipDto(Hip_Expediente exp)
        {
            IdExpediente = exp.IdExpediente;
            IdRevisionJudicial = exp.IdRevisionJudicial;

            //public int? IdLibertadArredanticia { get; set; }
            //public int? IdEstadoVenia { get; set; }
            //public int? IdExpedienteEjc { get; set; }
            //public int? IdExpedienteOrd { get; set; }
            //public int? IdExpedienteJV { get; set; }
            //public int? AutoSobreseimientoIdMotivo { get; set; }
            //public int? AutoSobreseimientoIdEstado { get; set; }
            //public int? AutoSobreseimientoIdApelacionPor { get; set; }
            //public int? AutoSobreseimientoIdResultadoApelacion { get; set; }
            //public int? OcupantesResultado { get; set; }
            //public int? OposicionResultado { get; set; }
            //public int? ApelacionPor { get; set; }
            //public int? ApelacionResultado { get; set; }
        }

        #endregion

        #region Properties

        public int IdExpediente { get; set; }
        public int? IdRevisionJudicial { get; set; }
        public int? IdLibertadArredanticia { get; set; }
        public int? IdEstadoVenia { get; set; }
        public int? IdExpedienteEjc { get; set; }
        public int? IdExpedienteOrd { get; set; }
        public int? IdExpedienteJV { get; set; }
        public int? AutoSobreseimientoIdMotivo { get; set; }
        public int? AutoSobreseimientoIdEstado { get; set; }
        public int? AutoSobreseimientoIdApelacionPor { get; set; }
        public int? AutoSobreseimientoIdResultadoApelacion { get; set; }
        public int? OcupantesResultado { get; set; }
        public int? OposicionResultado { get; set; }
        public int? ApelacionPor { get; set; }
        public int? ApelacionResultado { get; set; }

        public DateTime? FechaPosesionPositivaInmuebles { get; set; }
        public DateTime? FechaVeniaAdmitida { get; set; }
        public DateTime? AutoSobreseimientoFechaApelacion { get; set; }
        public DateTime? OcupantesFechaCelebracionVista { get; set; }
        public DateTime? OcupantesFechaResolucion { get; set; }
        public DateTime? OposicionFecha { get; set; }
        public DateTime? OposicionVistaFecha { get; set; }
        public DateTime? OposicionResolucionFecha { get; set; }
        public DateTime? Apelacion { get; set; }
        public DateTime? ApelacionResultadoFecha { get; set; }
        public DateTime? ApelacionEjecutanteFechaInterposicion { get; set; }
        public DateTime? ApelacionEjecutanteFechaImpugnacion { get; set; }

        public decimal? ImporteAdmision { get; set; } // Is from Expediente
        public decimal? DeudaPrincipal { get; set; }
        public decimal? DeudaIntRemuneratorios { get; set; }
        public decimal? DeudaIntDemora { get; set; }
        public decimal? DeudaComisionesGastos { get; set; }
        public decimal? DeudaIntDemoraCalculados { get; set; }
        public decimal? DeudaMinutaLetrado { get; set; }
        public decimal? DeudaMinutaProcurador { get; set; }
        public decimal? DeudaTasaJudicial { get; set; }
        public decimal? CostasPresupuestadas { get; set; }

        public bool EsTitulizado { get; set; }
        public bool MayorCuantia { get; set; }
        public bool FacturaIntegral { get; set; }
        public bool AutoSobreseimientoFinalizado { get; set; }
        public bool Ocupantes { get; set; }
        public bool Oposicion { get; set; }

        #endregion

        #region Properties ReadOnly
        #endregion
    }
}
