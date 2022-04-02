using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class Con_TipoIncidente
    {
        public Con_TipoIncidente()
        {
            Con_ExpedienteIncidente = new List<Con_ExpedienteIncidente>();
        }

        public int IdTipoIncidente { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public virtual ICollection<Con_ExpedienteIncidente> Con_ExpedienteIncidente { get; set; }
    }
}
