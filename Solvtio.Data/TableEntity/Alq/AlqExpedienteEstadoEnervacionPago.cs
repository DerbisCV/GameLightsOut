using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
	public class AlqExpedienteEstadoEnervacionPago
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int IdExpedienteEstado { get; set; }
        [ForeignKey("IdExpedienteEstado")]
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public DateTime? Fecha { get; set; }
        public string Observaciones { get; set; }


        public int IdTipoPagoEnervacion { get; set; }
        [ForeignKey("IdTipoPagoEnervacion")]
        public virtual Gnr_ListasValores_Valores TipoPagoEnervacion { get; set; }

    }
}
