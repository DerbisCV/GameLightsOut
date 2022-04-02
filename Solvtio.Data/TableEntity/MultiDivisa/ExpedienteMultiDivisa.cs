using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;


namespace Solvtio.Models
{
    [Table("ExpedienteMultiDivisa")]
    public partial class ExpedienteMultiDivisa
    {
        #region Constructors

        public ExpedienteMultiDivisa()
        {
            CreateBase();
        }

        public ExpedienteMultiDivisa(int idValija)
        {
            CreateBase();
            Expediente = new Expediente(idValija);
            Gnr_Persona = new Gnr_Persona();
        }

        public ExpedienteMultiDivisa(int idExpediente, int idDeudorPrincipal)
        {
            IdExpediente = idExpediente;
            IdDeudorPrincipal = idDeudorPrincipal;
        }

        private void CreateBase()
        {
            //Gnr_Persona = new Gnr_Persona();
            //Expediente = new Expediente();
        }

        #endregion

        #region Properties

        [Key, ForeignKey("Expediente")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int IdExpediente { get; set; }
        public Expediente Expediente { get; set; }
   

        [ForeignKey("Gnr_Persona")]
        public int IdDeudorPrincipal { get; set; }
        public Gnr_Persona Gnr_Persona { get; set; }

        public string Sjpi { get; set; }
        public DateTime? SjpiFecha { get; set; }
        public DateTime? FechaVotacion { get; set; }
        public DateTime? FechaDocumentacionRecibida { get; set; }

        public DateTime? FechaAsignacion { get; set; }
        public DateTime? FechaVencimientoInicial { get; set; }
        public DateTime? FechaVencimientoNegociacionTotal { get; set; }

        public string AbogadoBk { get; set; }
        public string Perfil { get; set; }
        public int NoCambiosDivisa { get; set; }
        public int NoCambiosDivisaSinEuro { get; set; }

        public decimal PerdidaEstimada { get; set; }
        public decimal PerdidaEstimadaConPorcentaje { get; set; }
        public decimal AhorroPerdidaNegociacion { get; set; }

        public int? IdCategoria { get; set; }
        [ForeignKey("IdCategoria")]
        public virtual CaracteristicaBase Categoria { get; set; }

        public int? IdSituacion { get; set; }
        [ForeignKey("IdSituacion")]
        public virtual CaracteristicaBase Situacion { get; set; }

        public int? IdFinalizadoPor { get; set; }
        [ForeignKey("IdFinalizadoPor")]
        public virtual CaracteristicaBase FinalizadoPor { get; set; }

        public virtual DateTime? FechaEstadoNegociacion { get; set; }

        public int? IdGestor { get; set; }
        [ForeignKey("IdGestor")]
        public virtual Usuario Gestor { get; set; }


        public string Organizacion { get; set; }
        public string Provincia { get; set; }
        public string Sentencia { get; set; }

        //public int? IdExpedienteEjc { get; set; }
        //public bool SomosDemandados { get; set; }

        public string Np { get; set; }
        public string Ciudad { get; set; }
        public string Proc { get; set; }
        public string NoApelacion { get; set; }

        public bool QuiereNegociar { get; set; }
        public bool QuiereEfectivo { get; set; }
        public bool Cambio1erEur { get; set; }

        public DateTime? FechaNotificacion { get; set; }
        public DateTime? FechaHmd { get; set; }
        public DateTime? FechaRecepcionDocumentacion { get; set; }

        public decimal? CapitalInicial { get; set; }
        public decimal? DeudaActual { get; set; }
        public decimal? Perdida { get; set; }
        public decimal? NegociacionPorciento { get; set; }
        public decimal? Costas { get; set; }
        public decimal? EfectivoSolicitado { get; set; }

        public string NoRemesa { get; set; }

        public TipoSiNo? ContactoEfectivo { get; set; }


        public bool Cancelada { get; set; }
        public DateTime? CanceladaFecha { get; set; }
        public bool Impagos { get; set; }
        public decimal? Ltv { get; set; }

        public decimal? CuantiaDemanda { get; set; }
        public decimal? NegociacionPorcientoMenor { get; set; }
        public string Observaciones { get; set; }

        #endregion

        #region Properties ReadOnly

        public decimal? PerdidaEstimadaNegociacionPorciento => PerdidaEstimada * (NegociacionPorciento ?? 0) / 100;
        public decimal? PerdidaEstimadaNegociacionPorcientoMenor => PerdidaEstimada * (NegociacionPorcientoMenor ?? 0) / 100;

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public DateTime? FechaNotificacionDemandaConDiasHabiles { get; set; }

        #endregion

        #region Methods

        internal void Refresh(ExpedienteMultiDivisa modelBase)
        {
            // la fecha vmto. Inicial tendría que ser una fórmula de más 5 días a la F. Asignación y Vmto. Negociación tendría que ser formula de más 13 días a la F. Asignación.
            if (modelBase.FechaAsignacion.HasValue)
            {
                if (!modelBase.FechaVencimientoInicial.HasValue)
                    modelBase.FechaVencimientoInicial = modelBase.FechaAsignacion.Value.AddDaysHabiles(5);
                if (!modelBase.FechaVencimientoNegociacionTotal.HasValue)
                    modelBase.FechaVencimientoNegociacionTotal = modelBase.FechaAsignacion.Value.AddDaysHabiles(13);
            }

            Sjpi = modelBase.Sjpi;
            SjpiFecha = modelBase.SjpiFecha;
            FechaVotacion = modelBase.FechaVotacion;
            FechaDocumentacionRecibida = modelBase.FechaDocumentacionRecibida;
            AbogadoBk = modelBase.AbogadoBk;
            Perfil = modelBase.Perfil;
            NoCambiosDivisa = modelBase.NoCambiosDivisa;
            NoCambiosDivisaSinEuro = modelBase.NoCambiosDivisaSinEuro;
            PerdidaEstimada = modelBase.PerdidaEstimada;
            PerdidaEstimadaConPorcentaje = modelBase.PerdidaEstimadaNegociacionPorciento ?? 0; //modelBase.PerdidaEstimadaConPorcentaje;
            AhorroPerdidaNegociacion = modelBase.AhorroPerdidaNegociacion;
            IdCategoria = modelBase.IdCategoria;
            IdGestor = modelBase.IdGestor;

            FechaAsignacion = modelBase.FechaAsignacion;
            FechaVencimientoInicial = modelBase.FechaVencimientoInicial;
            FechaVencimientoNegociacionTotal = modelBase.FechaVencimientoNegociacionTotal;
            IdSituacion = modelBase.IdSituacion;
            IdFinalizadoPor = modelBase.IdFinalizadoPor;
            FechaEstadoNegociacion = modelBase.FechaEstadoNegociacion;
            Organizacion = modelBase.Organizacion;
            Provincia = modelBase.Provincia;
            Sentencia = modelBase.Sentencia;
            Np = modelBase.Np;
            Ciudad = modelBase.Ciudad;
            Proc = modelBase.Proc;
            NoApelacion = modelBase.NoApelacion;
            QuiereNegociar = modelBase.QuiereNegociar;
            QuiereEfectivo = modelBase.QuiereEfectivo;
            Cambio1erEur = modelBase.Cambio1erEur;
            FechaNotificacion = modelBase.FechaNotificacion;
            FechaHmd = modelBase.FechaHmd;
            FechaRecepcionDocumentacion = modelBase.FechaRecepcionDocumentacion;
            CapitalInicial = modelBase.CapitalInicial;
            DeudaActual = modelBase.DeudaActual;
            Perdida = modelBase.Perdida;
            NegociacionPorciento = modelBase.NegociacionPorciento;
            Costas = modelBase.Costas;
            EfectivoSolicitado = modelBase.EfectivoSolicitado;
            NoRemesa = modelBase.NoRemesa;
            ContactoEfectivo = modelBase.ContactoEfectivo;
            Cancelada = modelBase.Cancelada;
            CanceladaFecha = modelBase.CanceladaFecha;
            Impagos = modelBase.Impagos;
            Ltv = modelBase.Ltv;
            CuantiaDemanda = modelBase.CuantiaDemanda;
            NegociacionPorcientoMenor = modelBase.NegociacionPorcientoMenor;
            Observaciones = modelBase.Observaciones;
        }

        #endregion
    }
}
