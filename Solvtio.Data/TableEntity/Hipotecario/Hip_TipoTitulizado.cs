using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class Hip_TipoTitulizado
    {
        public Hip_TipoTitulizado()
        {
            Hip_ExpedienteEstadoSubasta = new List<Hip_ExpedienteEstadoSubasta>();
        }

        public int IdTipoTitulizado { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Hip_ExpedienteEstadoSubasta> Hip_ExpedienteEstadoSubasta { get; set; }
    }
}
