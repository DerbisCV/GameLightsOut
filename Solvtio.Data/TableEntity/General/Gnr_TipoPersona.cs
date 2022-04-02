using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class Gnr_TipoPersona
    {
        public Gnr_TipoPersona()
        {
            Gnr_PersonaExpediente = new List<Gnr_PersonaExpediente>();
        }

        public int IdTipoPersona { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Gnr_PersonaExpediente> Gnr_PersonaExpediente { get; set; }
    }
}
