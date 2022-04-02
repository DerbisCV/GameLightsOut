using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ExpedienteMonitorio")]
    public sealed class ExpedienteMonitorio
    {
        #region Constructors

        public ExpedienteMonitorio()
        {
            CreateBase();
        }

        public ExpedienteMonitorio(int idValija)
        {
            CreateBase();
            Expediente = new Expediente(idValija);
            Gnr_Persona = new Gnr_Persona();
        }

        public ExpedienteMonitorio(int idExpediente, int idDeudorPrincipal)
        {
            CreateBase();
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
                

        public int? IdExpedienteHip { get; set; }
        public int? IdExpedienteEjc { get; set; }
        public int? IdExpedienteVb { get; set; }
        public int? IdExpedienteOrd { get; set; }
        
        public bool SomosDemandados { get; set; }

        public decimal? ImporteRecuperado { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public DateTime? FechaNotificacionDemandaConDiasHabiles { get; set; }

        #endregion

        #region Methods

        internal void Refresh(ExpedienteMonitorio modelBase)
        {
            SomosDemandados = modelBase.SomosDemandados;
            ImporteRecuperado = modelBase.ImporteRecuperado;
        }

        #endregion
    }
}
