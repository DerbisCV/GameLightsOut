using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public class Hip_ExpedienteEstadoFinalizacion
    {
        public int ExpedienteEstadoId { get; set; }
        [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public bool PagoDeuda { get; set; }
        public bool DacionPago { get; set; }
        public bool EstimacionOposicion { get; set; }
        public bool Devuelto { get; set; }
        public bool Llaves { get; set; }

        public int? IdMotivo { get; set; }
        public virtual Gnr_TipoEstadoMotivo Gnr_TipoEstadoMotivo { get; set; }
    }
}
