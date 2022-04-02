using System;

namespace Solvtio.Models
{
    public partial class Ejc_ExpedienteEstadoSolicitudSubasta
    {
        public int IdExpedienteEstado { get; set; }
        public int IdExpediente { get; set; }
        public DateTime? FechaSolicitudSubasta { get; set; }
        public int? IdDocumentoSolicitudSubasta { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }
		public virtual ExpedienteDocumento ExpedienteDocumentoSolicitudSubasta { get; set; }
    }
}
