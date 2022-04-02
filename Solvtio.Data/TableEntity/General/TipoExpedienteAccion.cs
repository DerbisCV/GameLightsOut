namespace Solvtio.Models
{
    public partial class TipoExpedienteAccion
    {
        public int IdTipoExpedienteAccion { get; set; }
        public int IdTipoExpediente { get; set; }
        public int IdTipoAccion { get; set; }
        public virtual Gnr_TipoExpediente Gnr_TipoExpediente { get; set; }
        public virtual TipoAccion TipoAccion { get; set; }
    }
}
