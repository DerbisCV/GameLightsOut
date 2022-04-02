using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteMueble")]
    public class ExpedienteMueble
    {
        #region Constructors

        public ExpedienteMueble()
        {
        }
        public ExpedienteMueble(int idExpediente)
        {
            IdExpediente = IdExpediente;      
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedienteMueble { get; set; }

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public string NoMueble { get; set; }
        public string Tipo { get; set; }
        public string Registro { get; set; }
        public string LetraEmbargo { get; set; }
        public string Descripcion { get; set; }

        #endregion
    }
}
