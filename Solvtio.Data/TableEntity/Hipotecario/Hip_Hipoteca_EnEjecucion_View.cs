using System;

namespace Solvtio.Models
{
    public partial class Hip_Hipoteca_EnEjecucion_View
    {
        public int IdHipoteca { get; set; }
        public int IdValija { get; set; }
        public int? IdExpediente { get; set; }
        public int? IdPeriodicidad { get; set; }
        public int? IdTipoReferenciaHipotecaria { get; set; }
        public int? IdPartidoJudicial { get; set; }
        public int? IdPersona { get; set; }
        public int IdTipoArea { get; set; }
        public int? IdJuzgado { get; set; }
        public string OficinaNoCuenta { get; set; }
        public string NoCuentaPrestamo { get; set; }
        public int NoHipoteca { get; set; }
        public decimal DeudaCierreFijacion { get; set; }
        public decimal? PrestamoCapital { get; set; }
        public DateTime? FechaCierre { get; set; }
        public DateTime? DemandaFecha { get; set; }
        public bool Ejecutar { get; set; }
        public string ReferenciaExterna { get; set; }
        public string EntidadOrigen { get; set; }
        public string Deudor { get; set; }
    }
}
