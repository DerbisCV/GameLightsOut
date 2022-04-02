using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelListExpedienteDeudor
    {
        public ModelListExpedienteDeudor() {}
        public ModelListExpedienteDeudor(int idExpediente)
        {
            IdExpediente = idExpediente;
        }

        public int IdExpediente { get; }
        public Expediente Expediente { get; set; }
        public List<ExpedienteDeudor> LstExpedienteDeudor { get; set; }
    }
}