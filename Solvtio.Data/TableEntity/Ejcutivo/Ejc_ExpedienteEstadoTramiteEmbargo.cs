using System;

namespace Solvtio.Models
{
    public class Ejc_ExpedienteEstadoTramiteEmbargo
    {
        public int IdExpedienteEstado { get; set; }
        public int IdExpediente { get; set; }
        public DateTime? FechaAveriguacion { get; set; }
        public bool AveriguacionBienesInmuebles { get; set; }
        public bool AveriguacionBienesMuebles { get; set; }
        public bool AveriguacionBienesSalarios { get; set; }
        public bool AveriguacionBienesSaldosRetenciones { get; set; }
        public DateTime? FechaDecretoEmbargo { get; set; }
        public bool DecretoEmbargoBienesInmuebles { get; set; }
        public bool DecretoEmbargoBienesMuebles { get; set; }
        public bool DecretoEmbargoBienesSalarios { get; set; }
        public bool DecretoEmbargoBienesSaldosRetenciones { get; set; }
        public int? IdDocumentoAveriguacion { get; set; }
        public int? IdDocumentoDecretoEmbargo { get; set; }

        public virtual ExpedienteEstado ExpedienteEstado { get; set; }
		//public virtual ExpedienteDocumento ExpedienteDocumentoAveriguacion { get; set; }
		//public virtual ExpedienteDocumento ExpedienteDocumentoDecretoEmbargo { get; set; }
    }
}
