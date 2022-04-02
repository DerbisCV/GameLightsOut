using System;

namespace Solvtio.Models
{
    public partial class ExpedienteAlerta
    {
        public int IdAlerta { get; set; }
        public int IdExpediente { get; set; }
        public int IdTipoAlerta { get; set; }
        public System.DateTime FechaAviso { get; set; }
        public string Descripcion { get; set; }
        public int IdDestinatario { get; set; }
        public int IdSupervidor { get; set; }
        public bool Activo { get; set; }
        public DateTime? FechaActivacion { get; set; }
        public DateTime? FechaDesactivacion { get; set; }
        public DateTime? FechaCorreoEnviado { get; set; }
        public string CC { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public virtual AlertaDestinatario AlertaDestinatario { get; set; }
        public virtual AlertaSupervisor AlertaSupervisor { get; set; }
        public virtual Expediente Expediente { get; set; }
        public virtual Gnr_TipoAlerta Gnr_TipoAlerta { get; set; }
    }
}
