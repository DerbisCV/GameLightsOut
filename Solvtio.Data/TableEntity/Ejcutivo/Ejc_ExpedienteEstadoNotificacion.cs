using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public class Ejc_ExpedienteEstadoNotificacion
    {
        public int IdExpedienteEstado { get; set; }
        [ForeignKey("IdExpedienteEstado")]
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public int IdExpediente { get; set; }
        public DateTime? AdmitidaFecha { get; set; }
        public string AdmitidaNoAuto { get; set; }
        public DateTime? FechaAutoSubsanado { get; set; }
        public decimal? AdmitidaDeudaReclamada { get; set; }
        public bool DemandaAdmitidaConDefecto { get; set; }
        public bool Oposicion { get; set; }
        public DateTime? OposicionFecha { get; set; }
        public DateTime? OposicionFechaVista { get; set; }
        public DateTime? OposicionFechaResolucion { get; set; }
        public int? IdDocumentoAutoEjecucion { get; set; }
        public int? IdDocumentoOposicion { get; set; }
        public int? IdDocumentoOposicionVista { get; set; }
        public int? IdDocumentoOposicionResolucion { get; set; }
        public bool Apelacion { get; set; }
        public DateTime? ApelacionFecha { get; set; }
        public int? ApelacionPor { get; set; }

        
        //public virtual ExpedienteDocumento ExpedienteDocumentoOposicion { get; set; }
        //public virtual ExpedienteDocumento ExpedienteDocumentoOposicionVista { get; set; }
        //public virtual ExpedienteDocumento ExpedienteDocumentoOposicionResolucion { get; set; }
        //public virtual ExpedienteDocumento ExpedienteDocumentoAutoEjecucion { get; set; }

    }
}
