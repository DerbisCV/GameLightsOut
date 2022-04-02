namespace Solvtio.Models
{
    public partial class ExpedienteAcreedore
    {
        public int IdExpAcreedor { get; set; }
        public int? IdExpediente { get; set; }
        public int IdPersona { get; set; }
        public int IdTipoAcreedor { get; set; }
        public virtual Expediente Expediente { get; set; }
        public virtual Gnr_Persona Gnr_Persona { get; set; }
    }
}
