using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class Gnr_TipoTratamiento
    {
        public Gnr_TipoTratamiento()
        {
            Gnr_Persona = new List<Gnr_Persona>();
        }

        public int IdTratamiento { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Gnr_Persona> Gnr_Persona { get; set; }
    }
}
