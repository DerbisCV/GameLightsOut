namespace Solvtio.Models
{
    public partial class Gnr_PersonaExpediente
    {
        public int IdPersonaExpediente { get; set; }
        public int IdPersona { get; set; }
        public int IdTipoPersona { get; set; }
        public int IdExpediente { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public System.DateTime FechaBaja { get; set; }
        public virtual Gnr_Persona Gnr_Persona { get; set; }
        public virtual Gnr_TipoPersona Gnr_TipoPersona { get; set; }
    }
}
