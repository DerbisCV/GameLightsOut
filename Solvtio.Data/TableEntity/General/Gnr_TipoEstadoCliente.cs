using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class Gnr_TipoEstadoCliente
    {
        public Gnr_TipoEstadoCliente()
        {
            Alq_Expediente = new List<Alq_Expediente>();
        }

        public int IdTipoEstadoCliente { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public virtual ICollection<Alq_Expediente> Alq_Expediente { get; set; }
    }
}
