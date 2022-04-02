using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class Hip_TipoSubasta
    {
        public Hip_TipoSubasta()
        {
            Hip_ExpedienteEstadoSubasta = new List<Hip_ExpedienteEstadoSubasta>();
        }

        public int IdTipoSubasta { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public virtual ICollection<Hip_ExpedienteEstadoSubasta> Hip_ExpedienteEstadoSubasta { get; set; }
    }
}
