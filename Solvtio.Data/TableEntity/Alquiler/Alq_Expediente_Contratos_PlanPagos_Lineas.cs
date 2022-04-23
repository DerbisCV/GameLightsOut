using System;

namespace Solvtio.Models
{
    public partial class Alq_Expediente_Contratos_PlanPagos_Lineas
    {
        public int ID { get; set; }
        public int? IdContrato { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public decimal? AmortizacionDeuda { get; set; }
        public decimal? RentaMes { get; set; }
        public bool? Satisfecho { get; set; }
        public DateTime? FechaNotificacion { get; set; }
        public decimal? DeudaPendiente { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string UsuarioSatisfecho { get; set; }
        public DateTime? FechaSatisfecho { get; set; }
        public virtual Alq_Expediente_Contrato Alq_Expediente_Contratos { get; set; }
    }
}
