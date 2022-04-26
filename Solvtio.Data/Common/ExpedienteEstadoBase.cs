using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public class ExpedienteEstadoBase
    {
        public int IdExpedienteEstado { get; set; }
        [ForeignKey("IdExpedienteEstado")]
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }
    }
}
