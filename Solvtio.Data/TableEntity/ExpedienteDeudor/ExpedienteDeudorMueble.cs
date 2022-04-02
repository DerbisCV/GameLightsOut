using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteDeudorMueble")]
    public class ExpedienteDeudorMueble : ExpedienteDeudorBase
    {
        public ExpedienteDeudorMueble()
        {
        }
        public ExpedienteDeudorMueble(ExpedienteDeudor expDeudor)
        {
            IdExpedienteDeudor = expDeudor.IdExpedienteDeudor;
            IdExpediente = expDeudor.IdExpediente;      
        }

        public string NoMueble { get; set; }
        public string Tipo { get; set; }
        public string Registro { get; set; }
        public string LetraEmbargo { get; set; }
        public string Descripcion { get; set; }

    }
}
