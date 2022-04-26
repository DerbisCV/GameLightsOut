using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class Gnr_TipoExpedienteDocumento
    {
        public Gnr_TipoExpedienteDocumento()
        {
            //ExpedienteDocumentoes = new List<ExpedienteDocumento>();
        }

        public int IdTipoDocumento { get; set; }
        public string Descripcion { get; set; }
        public bool Inactivo { get; set; }
        public int? IdTipoExpediente { get; set; }
        //public virtual ICollection<ExpedienteDocumento> ExpedienteDocumentoes { get; set; }
        public virtual Gnr_TipoExpediente Gnr_TipoExpediente { get; set; }
    }
}
