namespace Solvtio.Models
{
    public partial class Gnr_PersonaTelefono
    {
        public int IdPersonaTelefono { get; set; }
        public int IdPersona { get; set; }
        public string Telefono { get; set; }
        public int IdTipoTelefono { get; set; }
        public virtual Gnr_Persona Gnr_Persona { get; set; }
        public virtual Gnr_TipoTelefono Gnr_TipoTelefono { get; set; }
    }
}
