using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteOrdinario")]
    public class ExpedienteOrdinario
    {
        #region Constructors

        public ExpedienteOrdinario()
        {
            CreateBase();
        }

        public ExpedienteOrdinario(int? idValija)
        {
            CreateBase();
            Expediente = idValija.HasValue ? new Expediente(idValija.Value) : new Expediente();
            Gnr_Persona = new Gnr_Persona();
        }

        public ExpedienteOrdinario(int idExpediente, int idDeudorPrincipal)
        {
            IdExpediente = idExpediente;
            IdDeudorPrincipal = idDeudorPrincipal;
        }
        public ExpedienteOrdinario(int idExpediente, int? idDeudorPrincipal)
        {
            IdExpediente = idExpediente;
            if (idDeudorPrincipal.HasValue)
                IdDeudorPrincipal = idDeudorPrincipal.Value;
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

        public int? IdExpedienteEjc { get; set; }
        [ForeignKey("IdExpedienteEjc")]
        public Ejc_Expediente ExpedienteEjecutivo { get; set; }

        public int? IdExpedienteHip { get; set; }
        public int? IdExpedienteMn { get; set; }

        [ForeignKey("Gnr_Persona")]
        public int IdDeudorPrincipal { get; set; }
        public Gnr_Persona Gnr_Persona { get; set; }

        public DateTime? FechaFacturaHito1 { get; set; }
        public DateTime? FechaFacturaHito2 { get; set; }

        public bool SomosDemandados { get; set; }
        public bool MasDeUnaClausula { get; set; }
        public decimal? ImporteRecuperado { get; set; }

        public DateTime? ApelacionEjecutanteFechaInterposicion { get; set; }
        public DateTime? ApelacionEjecutanteFechaImpugnacion { get; set; }

        public int? IdTipo { get; set; }
        [ForeignKey("IdTipo")]
        public virtual CaracteristicaBase Tipo { get; set; }

        #endregion

        #region Methods

        internal void Refresh(ExpedienteOrdinario modelBase)
        {
            FechaFacturaHito1 = modelBase.FechaFacturaHito1;
            FechaFacturaHito2 = modelBase.FechaFacturaHito2;
            SomosDemandados = modelBase.SomosDemandados;
            MasDeUnaClausula = modelBase.MasDeUnaClausula;
            ImporteRecuperado = modelBase.ImporteRecuperado;

            ApelacionEjecutanteFechaInterposicion = modelBase.ApelacionEjecutanteFechaInterposicion;
            ApelacionEjecutanteFechaImpugnacion = modelBase.ApelacionEjecutanteFechaImpugnacion;
            IdTipo = modelBase.IdTipo;
        }

        #endregion

    }
}
