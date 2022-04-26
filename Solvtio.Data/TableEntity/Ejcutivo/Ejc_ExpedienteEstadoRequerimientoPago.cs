using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public class Ejc_ExpedienteEstadoRequerimientoPago : ExpedienteEstadoRequerimientoPagoBase
    {
        public int IdExpedienteEstadoRequerimientoPago { get; set; }

        public int IdExpedienteEstado { get; set; }
        [ForeignKey("IdExpedienteEstado")]
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }


        public int? IdDocumentoRequerimientoPago { get; set; }
        //public virtual ExpedienteDocumento ExpedienteDocumentoRequerimientoPago { get; set; }
    }

}
