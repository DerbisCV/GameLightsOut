namespace Solvtio.Models
{
    public partial class Con_ExpedienteAdministrador
    {
        public int IdAdministrador { get; set; }
        public int IdExpediente { get; set; }
        public int IdPersona { get; set; }
        public int IdTipoAdministrador { get; set; }
        public virtual Expediente Expediente { get; set; }
        public virtual Gnr_Persona Gnr_Persona { get; set; }
    }
}
