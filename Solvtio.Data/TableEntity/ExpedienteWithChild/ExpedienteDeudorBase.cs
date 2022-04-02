using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public class ExpedienteDeudorBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        public int IdExpedienteDeudor { get; set; }
        [ForeignKey("IdExpedienteDeudor")]
        public virtual ExpedienteDeudor ExpedienteDeudor { get; set; }

        public int IdExpediente { get; set; }

    }
}
