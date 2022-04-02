using System;

namespace Solvtio.Models
{
    public partial class View_1
    {
        public int IdExpediente { get; set; }
        public int IdValija { get; set; }
        public string NoExpediente { get; set; }
        public string ReferenciaExterna { get; set; }
        public string Descripcion { get; set; }
        public int IdClienteOficina { get; set; }
        public string Nombre { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public DateTime? FechaCierre { get; set; }
        public decimal? DeudaFinal { get; set; }
        public int? IdTipoEstadoLast { get; set; }
        public string Expr1 { get; set; }
        public int IdTipoExpediente { get; set; }
        public string Observaciones { get; set; }
    }
}
