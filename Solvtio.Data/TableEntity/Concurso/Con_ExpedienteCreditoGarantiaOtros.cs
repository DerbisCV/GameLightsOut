using System;

namespace Solvtio.Models
{
    public partial class Con_ExpedienteCreditoGarantiaOtros
    {
        public int IdExpedienteCreditoGarantiaOtros { get; set; }
        public int IdExpedienteCredito { get; set; }
        public string Descripcion { get; set; }
        public string Lote { get; set; }
        public decimal? ImporteSubasta { get; set; }
        public decimal? ImporteAdjudicacion { get; set; }
        public bool Adjudicado { get; set; }
        public DateTime? FechaAdjudicacion { get; set; }
        public virtual Con_ExpedienteCredito Con_ExpedienteCredito { get; set; }
    }
}
