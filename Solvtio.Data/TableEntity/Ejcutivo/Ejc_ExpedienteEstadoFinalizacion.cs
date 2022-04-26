using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public partial class Ejc_ExpedienteEstadoFinalizacion
    {
        public int IdExpedienteEstado { get; set; }
        [ForeignKey("IdExpedienteEstado")]
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }       
        
        public int IdExpediente { get; set; }
        
        public int? IdMotivo { get; set; }
        [ForeignKey("IdMotivo")]
        public virtual Gnr_TipoEstadoMotivo Gnr_TipoEstadoMotivo { get; set; }
    }
}
