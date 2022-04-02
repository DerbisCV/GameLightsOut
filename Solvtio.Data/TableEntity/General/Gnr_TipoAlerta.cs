using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class Gnr_TipoAlerta
    {
        public Gnr_TipoAlerta()
        {
            ExpedienteAlertas = new List<ExpedienteAlerta>();
        }

        public int IdTipoAlerta { get; set; }
        public string Nombre { get; set; }
        public string Grupo { get; set; }
        public virtual ICollection<ExpedienteAlerta> ExpedienteAlertas { get; set; }
    }
}
