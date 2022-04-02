using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class Hip_TipoPeriodicidad
    {
        public Hip_TipoPeriodicidad()
        {
            PropuestaComercials = new List<PropuestaComercial>();
        }

        public int IdPeriodicidad { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<PropuestaComercial> PropuestaComercials { get; set; }
    }
}
