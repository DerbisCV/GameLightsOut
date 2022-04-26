using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class AlertaDestinatario
    {
        public AlertaDestinatario()
        {
            //ExpedienteAlertas = new List<ExpedienteAlerta>();
        }

        public int IdPersona { get; set; }
        public int IdSupervisor { get; set; }
        public bool IsAdmin { get; set; }
        //public virtual AlertaSupervisor AlertaSupervisor { get; set; }
        //public virtual Gnr_Persona Gnr_Persona { get; set; }
        //public virtual ICollection<ExpedienteAlerta> ExpedienteAlertas { get; set; }
    }
}
