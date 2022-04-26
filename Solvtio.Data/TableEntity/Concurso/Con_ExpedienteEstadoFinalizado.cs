using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public partial class Con_ExpedienteEstadoFinalizado
    {
        public int ExpedienteEstadoId { get; set; }
        [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public DateTime? FechaFinalizacion { get; set; }
        public int? IdMotivo { get; set; }

        public int? DocumentoAutoConclusionId { get; set; }
        //public virtual ExpedienteDocumento ExpedienteDocumento { get; set; }

    }
}
