namespace Solvtio.Models
{
    public partial class ExpedienteIngreso
    {
        public int IdExpedienteIngreso { get; set; }
        public int IdExpediente { get; set; }
        public System.DateTime Fecha { get; set; }
        public decimal Importe { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public virtual Expediente Expediente { get; set; }
    }
}
