using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteVerbal")]
    public sealed class ExpedienteVerbal
    {
        #region Constructors

        public ExpedienteVerbal()
        {
            CreateBase();
        }

        public ExpedienteVerbal(int idValija)
        {
            CreateBase();
            Expediente = new Expediente(idValija);
            Gnr_Persona = new Gnr_Persona();
        }

        public ExpedienteVerbal(int idExpediente, int idDeudorPrincipal)
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


        public int? IdExpedienteMn { get; set; }
        //public int? IdExpedienteEjc { get; set; }
        //public bool SomosDemandados { get; set; }
        public decimal? ImporteRecuperado { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public DateTime? FechaNotificacionDemandaConDiasHabiles { get; set; }

        #endregion


        #region Methods

        internal void Refresh(ExpedienteVerbal modelBase)
        {
            ImporteRecuperado = modelBase.ImporteRecuperado;
        }

        #endregion
    }
}
