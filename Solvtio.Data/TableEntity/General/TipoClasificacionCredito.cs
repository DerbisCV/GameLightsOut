using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class TipoClasificacionCredito
    {
        public TipoClasificacionCredito()
        {
            Con_ExpedienteCreditoCalificacion = new List<Con_ExpedienteCreditoCalificacion>();
        }

        public int IdTipoCalificacionCredito { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Con_ExpedienteCreditoCalificacion> Con_ExpedienteCreditoCalificacion { get; set; }
    }
}
