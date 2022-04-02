using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ExpedienteOrdinarioCs")]
    public class ExpedienteOrdinarioCs
    {
        #region Constructors

        public ExpedienteOrdinarioCs()
        {
            CreateBase();
        }

        public ExpedienteOrdinarioCs(int idValija)
        {
            CreateBase();
            Expediente = new Expediente(idValija);
            Gnr_Persona = new Gnr_Persona();
        }

        public ExpedienteOrdinarioCs(int idExpediente, int idDeudorPrincipal)
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

        public int? IdExpedienteHip { get; set; }
        //[ForeignKey("IdExpedienteHip")]
        //public virtual Hip_Expediente ExpedienteHipotecario { get; set; }

        [ForeignKey("Gnr_Persona")]
        public int IdDeudorPrincipal { get; set; }
        public Gnr_Persona Gnr_Persona { get; set; }
        //public DateTime? FechaFacturaHito1 { get; set; }
        //public DateTime? FechaFacturaHito2 { get; set; }
        public bool SomosDemandados { get; set; }
        public bool DemandaExtemporanea { get; set; }

        public DateTime? AllanamientoFecha { get; set; }
        public DateTime? FechaNotificacionDemanda { get; set; }
        public DateTime? FechaNotificacionDemandaConDiasHabiles { get; set; }
        public decimal? ImporteClausulaSuelo { get; set; }
        public decimal? ImporteGastosFormalizacion { get; set; }
        public bool ImporteIndeterminado { get; set; }
        public bool FacturaProcurador { get; set; }
        public int MotivoDemandaId { get; set; }
        public TotalParcialType? IndicacionRespuestaDemandaBanco { get; set; }
        public DateTime? FechaInterposicionDemanda { get; set; }
        public string LetradoCliente { get; set; }
        public DateTime? FechaAllanamientoCopiaSellada { get; set; }

        public bool ReclamacionPrevia { get; set; }
        public bool ReclamacionJudicialRdi { get; set; }
        public bool ContestacionRdi { get; set; }
        public string GestorClienteMail { get; set; }

        #region Allanamiento 

        public bool AllanamientoAbonoAportado { get; set; }
        public bool AllanamientoAbonoAportadoConPosterioridad { get; set; }

        public bool AllanamientoCuadroAportado { get; set; }
        public bool AllanamientoCuadroAportadoConPosterioridad { get; set; }
        public bool AllanamientoAbonoInteresesLegales { get; set; }
        

        #endregion

        #region TipologiaGastosReclamados 

        public bool TipologiaGastoReclamadoNotarial { get; set; }
        public bool TipologiaGastoReclamadoItpAdj { get; set; }
        public bool TipologiaGastoReclamadoTasacion { get; set; }
        public bool TipologiaGastoReclamadoRegistro { get; set; }
        public bool TipologiaGastoReclamadoGestoria { get; set; }
        public bool TipologiaGastoReclamadoOtros { get; set; }

        #endregion

        #endregion

        #region Properties ReadOnly

        internal Period Agosto => FechaNotificacionDemanda.HasValue ? 
            new Period(
                new DateTime(FechaNotificacionDemanda.Value.Year, 8, 1),
                new DateTime(FechaNotificacionDemanda.Value.Year, 8, 31)) : 
            null;

        public DateTime? FechaVencimientoPlazoLimite => FechaNotificacionDemandaConDiasHabiles; // FechaNotificacionDemanda?.AddDaysHabiles(20, Agosto);
        public DateTime? FechaVencimientoPlazo => AllanamientoFecha.HasValue ? null : FechaVencimientoPlazoLimite;
        public int? DiasParaVencimiento => FechaNotificacionDemanda.HasValue && FechaVencimientoPlazo.HasValue ? 
            DateTime.Now >= FechaVencimientoPlazo.Value ? 0 : DateTime.Now.Date.GetDaysBetweenDates(FechaVencimientoPlazo.Value) : 
            (int?)null;

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public DateTime? FechaNotificacionDemandaConDiasHabiles { get; set; }

        #endregion
    }
}
