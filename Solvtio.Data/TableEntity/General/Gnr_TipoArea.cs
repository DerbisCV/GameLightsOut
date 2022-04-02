using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class Gnr_TipoArea : INombre
    {
        public Gnr_TipoArea()
        {
            Expedientes = new List<Expediente>();
        }

        public int IdTipoArea { get; set; }
        public string Nombre { get; set; }
		public bool Inactivo { get; set; }

        public virtual ICollection<Expediente> Expedientes { get; set; }
    }
}
