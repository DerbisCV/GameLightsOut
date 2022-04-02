using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class Gnr_TipoIdentidad
    {
        public Gnr_TipoIdentidad()
        {
            Gnr_Cliente = new List<Gnr_Cliente>();
            Gnr_Persona = new List<Gnr_Persona>();
        }

        public int IdTipoIdentidad { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Gnr_Cliente> Gnr_Cliente { get; set; }
        public virtual ICollection<Gnr_Persona> Gnr_Persona { get; set; }
    }
}
