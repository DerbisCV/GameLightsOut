using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public class ActuacionBase
    {
        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public string Observaciones { get; set; }

        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
    }
}
