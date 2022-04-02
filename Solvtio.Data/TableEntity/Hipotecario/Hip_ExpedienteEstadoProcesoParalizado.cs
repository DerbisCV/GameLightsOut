using System;

namespace Solvtio.Models
{
    public class Hip_ExpedienteEstadoProcesoParalizado
    {
        public int IdExpedienteEstadoParalizado { get; set; }
        public int ExpedienteEstadoId { get; set; }
        public DateTime? FechaParalizado { get; set; }
        public decimal? ImporteParalizado { get; set; }
        public string Observaciones { get; set; }
        public int? IdMotivo { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }
        public virtual Gnr_TipoEstadoMotivo Gnr_TipoEstadoMotivo { get; set; }
    }
}
