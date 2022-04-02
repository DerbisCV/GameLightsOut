using System;

namespace Solvtio.Models
{
    public partial class vAlq_InformeTotalP
    {
        public int IdExpediente { get; set; }
        public string NoExpediente { get; set; }
        public string ReferenciaExternaMSGI { get; set; }
        public string ReferenciaExternaMACRO { get; set; }
        public string Arrendador { get; set; }
        public string TipoPropietario { get; set; }
        public string NAU { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public decimal? DeudaInicial { get; set; }
        public decimal? DeudaPendiente { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaEstado { get; set; }
        public string NIF { get; set; }
        public string NombreDeudor { get; set; }
        public string DomicilioNotificacion { get; set; }
        public int? IdProcurador { get; set; }
        public string Procurador { get; set; }
    }
}
