using System;

namespace Solvtio.Models
{
    public partial class Alq_Expediente_Contratos_Deuda_Lineas
    {
        public int ID { get; set; }
        public int? IdContrato { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? BaseImponible { get; set; }
        public decimal? IVA { get; set; }
        public decimal? Retencion { get; set; }
        public decimal? TotalRenta { get; set; }
        public decimal? Abonado { get; set; }
        public decimal? Debido { get; set; }
        public decimal? PorcentajeIVA { get; set; }
        public virtual Alq_Expediente_Contrato Alq_Expediente_Contratos { get; set; }
    }
}
