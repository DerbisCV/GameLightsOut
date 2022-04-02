using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteDeudorInmueble")]
    public class ExpedienteDeudorInmueble : InmuebleBase
    {
        #region Constructor

        public ExpedienteDeudorInmueble()
        {
        }
        public ExpedienteDeudorInmueble(ExpedienteDeudor expDeudor)
        {
            IdExpedienteDeudor = expDeudor.IdExpedienteDeudor;
            IdExpediente = expDeudor.IdExpediente;      
        }

        #endregion

        #region Properties ExpedienteDeudorBase

        //[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }


        public int IdExpedienteDeudor { get; set; }
        [ForeignKey("IdExpedienteDeudor")]
        public virtual ExpedienteDeudor ExpedienteDeudor { get; set; }

        public int IdExpediente { get; set; }

        #endregion

        #region Properties


        #endregion

        #region Properties Readonly


        #endregion

        //public string NoMueble { get; set; }
        //public string Tipo { get; set; }
        //public string Registro { get; set; }
        //public string LetraEmbargo { get; set; }
        //public string Descripcion { get; set; }

    }
}
