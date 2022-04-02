using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ExpedienteContenciosoOrdinario")]
    public sealed class ExpedienteContenciosoOrdinario
    {
        #region Constructors

        public ExpedienteContenciosoOrdinario()
        {
            CreateBase();
        }

        public ExpedienteContenciosoOrdinario(int idValija)
        {
            CreateBase();
            Expediente = new Expediente(idValija);
            Gnr_Persona = new Gnr_Persona();
        }

        public ExpedienteContenciosoOrdinario(int idExpediente, int idDeudorPrincipal)
        {
            IdExpediente = idExpediente;
            IdDeudorPrincipal = idDeudorPrincipal;
        }

        private void CreateBase()
        {
            //TipoAsunto = ExpContenciosoOrdinarioTipoAsunto.ContenciosoOrdinario;
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
                

        //public int? IdExpedienteMn { get; set; }
        //public int? IdExpedienteEjc { get; set; }

        //public ExpContenciosoOrdinarioTipoAsunto TipoAsunto { get; set; }
        //public string ContrarioAbogado { get; set; }
        //public string Juez { get; set; }
      

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public DateTime? FechaNotificacionDemandaConDiasHabiles { get; set; }

        #endregion

    }
}
