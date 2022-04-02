using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class AlertaSupervisor
    {
        public AlertaSupervisor()
        {
            AlertaDestinatarios = new List<AlertaDestinatario>();
            ExpedienteAlertas = new List<ExpedienteAlerta>();
            Gnr_Cliente = new List<Gnr_Cliente>();
        }

        public int IdPersona { get; set; }
        public string Departamento { get; set; }
        public bool EsEjecutivo { get; set; }
        public virtual ICollection<AlertaDestinatario> AlertaDestinatarios { get; set; }
        public virtual Gnr_Persona Gnr_Persona { get; set; }
        public virtual ICollection<ExpedienteAlerta> ExpedienteAlertas { get; set; }
        public virtual ICollection<Gnr_Cliente> Gnr_Cliente { get; set; }
    }
}
