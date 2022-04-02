using System;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ExpedienteDeudorSalarioSaldo")]
    public class ExpedienteDeudorSalarioSaldo : ExpedienteDeudorBase
    {
        public ExpedienteDeudorSalarioSaldo()
        {
        }

        public ExpedienteDeudorSalarioSaldo(ExpedienteDeudor expDeudor, TipoBienEmbargo tipoBienEmbargo)
        {
            IdExpedienteDeudor = expDeudor.IdExpedienteDeudor;
            IdExpediente = expDeudor.IdExpediente;
            Tipo = tipoBienEmbargo;
            Fecha = DateTime.Now;
        }

        public TipoBienEmbargo Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public string Entidad { get; set; }
        public decimal? Importe { get; set; }
    }
}

