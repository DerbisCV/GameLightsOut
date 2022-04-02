using System;

namespace Solvtio.Models
{
    public partial class View_5
    {
        public int IdExpediente { get; set; }
        public string NoExpediente { get; set; }
        public string ReferenciaExterna { get; set; }
        public int IdTipoExpediente { get; set; }
        public int IdClienteOficina { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaCierre { get; set; }
        public decimal? DeudaFinal { get; set; }
        public int? IdTipoEstadoLast { get; set; }
        public string Descripcion { get; set; }
        public int IdTipoEstado { get; set; }
    }
}
