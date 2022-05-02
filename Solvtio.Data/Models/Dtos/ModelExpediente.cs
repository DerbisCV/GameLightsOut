using Solvtio.Common;
using System;

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

        public int IdExpediente { get; set; }
        public string NoExpediente { get; set; }
        public string ReferenciaExterna { get; set; }
        public TipoExpedienteEnum TipoExpediente { get; set; }
        //public ModelClienteOficina ClienteOficina { get; set; }
        //public ModelPersona DeudorPrincipal { get; set; }
        //public DateTime FechaAlta { get; set; }
        //public ModelMoney Importe { get; set; }
        //public ModelTipoEstado TipoEstadoActual { get; set; }
        public string ClienteOficina { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fin { get; set; }

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
}
