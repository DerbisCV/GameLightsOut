using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class Con_TipoFase : IDescripcion
    {
        public Con_TipoFase()
        {
            Con_ExpedienteIncidente = new List<Con_ExpedienteIncidente>();
        }

        public int IdFase { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Con_ExpedienteIncidente> Con_ExpedienteIncidente { get; set; }

        public int Id => IdFase;
    }
}
