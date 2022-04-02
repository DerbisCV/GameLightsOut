namespace Solvtio.Models
{
    public partial class Ejc_ExpedienteEstadoFinalizacion
    {
        public int IdExpedienteEstado { get; set; }
        public int IdExpediente { get; set; }
        public int? IdMotivo { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }
        public virtual Gnr_TipoEstadoMotivo Gnr_TipoEstadoMotivo { get; set; }
    }
}
