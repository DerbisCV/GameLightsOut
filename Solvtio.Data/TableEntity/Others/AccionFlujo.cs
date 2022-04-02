namespace Solvtio.Models
{
    public partial class AccionFlujo
    {
        public int IdAccionFlujo { get; set; }
        public int IdAccionOrigen { get; set; }
        public int IdAccionDestino { get; set; }
        public virtual TipoAccion TipoAccion { get; set; }
    }
}
