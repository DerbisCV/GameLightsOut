namespace Solvtio.Models
{
    public partial class Hip_ExpedienteGarantia
    {
        public int IdExpedienteGarantia { get; set; }
        public int IdExpediente { get; set; }
        public string Descripcion { get; set; }
        public virtual Hip_Expediente Hip_Expediente { get; set; }
    }
}
