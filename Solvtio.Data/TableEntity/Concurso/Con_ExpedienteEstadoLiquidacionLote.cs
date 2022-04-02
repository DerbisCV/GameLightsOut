using System;

namespace Solvtio.Models
{
    public partial class Con_ExpedienteEstadoLiquidacionLote
    {
        public int IdLote { get; set; }
        public int ExpedienteEstadoId { get; set; }
        public string Lote { get; set; }
        public string Referencia { get; set; }
        public DateTime? FechaSubasta { get; set; }
        public string Propiedad { get; set; }
        public decimal? ImporteAdjudicacion { get; set; }
        public decimal? ImporteDeudaRemanente { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }
    }
}
