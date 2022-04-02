using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class Gnr_TipoTelefono
    {
        public Gnr_TipoTelefono()
        {
            Gnr_PersonaTelefono = new List<Gnr_PersonaTelefono>();
        }

        public int IdTipoTelefono { get; set; }
        public string Abreviacion { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public virtual ICollection<Gnr_PersonaTelefono> Gnr_PersonaTelefono { get; set; }
    }
}
