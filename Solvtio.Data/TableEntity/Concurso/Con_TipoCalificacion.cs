using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class Con_TipoCalificacion
    {
        public Con_TipoCalificacion()
        {
            Con_ExpedienteCreditoCalificacion = new List<Con_ExpedienteCreditoCalificacion>();
            //Con_ExpedienteEstadoCalificacion = new List<Con_ExpedienteEstadoCalificacion>();
            //Con_ExpedienteEstadoCalificacion1 = new List<Con_ExpedienteEstadoCalificacion>();
            //Con_ExpedienteEstadoCalificacion2 = new List<Con_ExpedienteEstadoCalificacion>();
        }

        public int IdTipoCalificacion { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Con_ExpedienteCreditoCalificacion> Con_ExpedienteCreditoCalificacion { get; set; }
        //public virtual ICollection<Con_ExpedienteEstadoCalificacion> Con_ExpedienteEstadoCalificacion { get; set; }
        //public virtual ICollection<Con_ExpedienteEstadoCalificacion> Con_ExpedienteEstadoCalificacion1 { get; set; }
        //public virtual ICollection<Con_ExpedienteEstadoCalificacion> Con_ExpedienteEstadoCalificacion2 { get; set; }
    }
}
