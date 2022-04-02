using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class Con_TipoCalificacionTiempo
    {
        public Con_TipoCalificacionTiempo()
        {
            Con_ExpedienteCreditoCalificacion = new List<Con_ExpedienteCreditoCalificacion>();
        }

        public int IdTipoCalificacion { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Con_ExpedienteCreditoCalificacion> Con_ExpedienteCreditoCalificacion { get; set; }
    }
}
