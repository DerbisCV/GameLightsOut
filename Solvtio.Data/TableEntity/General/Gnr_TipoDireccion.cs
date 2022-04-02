using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class Gnr_TipoDireccion
    {
        public Gnr_TipoDireccion()
        {
            Gnr_PersonaDireccion = new List<Gnr_PersonaDireccion>();
        }

        public int IdTipoDireccion { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Gnr_PersonaDireccion> Gnr_PersonaDireccion { get; set; }
    }
}
