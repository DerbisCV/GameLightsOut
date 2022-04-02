namespace Solvtio.Models
{
    public partial class ExpedienteAccion
    {
        public int IdExpedienteAccion { get; set; }
        public int IdExpediente { get; set; }
        public System.DateTime Fecha { get; set; }
        public int IdTipoAccion { get; set; }
        public string Observacion { get; set; }
        public string Usuario { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public virtual Hip_Expediente Hip_Expediente { get; set; }
        public virtual TipoAccion TipoAccion { get; set; }
    }
}
