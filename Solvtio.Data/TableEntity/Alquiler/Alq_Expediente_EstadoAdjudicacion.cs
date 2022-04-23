using System;

namespace Solvtio.Models
{
    public partial class Alq_Expediente_EstadoAdjudicacion
    {
        public int IdExpedienteEstado { get; set; }
        public DateTime? FechaAdjudicacion { get; set; }
        public bool LiquidacionITP { get; set; }
        public DateTime? FechaLiquidacionITP { get; set; }
        public DateTime? FechaCertificadoInscripcion { get; set; }
        public DateTime? FechaDiligenciaPosesion { get; set; }
        public bool FormaPacifica { get; set; }
        public bool Inquilinos { get; set; }
        public bool Ocupantes { get; set; }
        public DateTime? FechaLanzamiento { get; set; }
        public DateTime? FechaEntregaLLaves { get; set; }
        public bool ContratoAlquiler { get; set; }
        public bool Defectos { get; set; }
        public bool Subsanado { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }
    }
}
