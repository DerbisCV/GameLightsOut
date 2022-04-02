using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class TipoCalificacionCreditoTiempo
    {
        public TipoCalificacionCreditoTiempo()
        {
            Con_ExpedienteCreditoCalificacion = new List<Con_ExpedienteCreditoCalificacion>();
        }

        public int IdTipoCalificacionCreditoTiempo { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Con_ExpedienteCreditoCalificacion> Con_ExpedienteCreditoCalificacion { get; set; }
    }
}
