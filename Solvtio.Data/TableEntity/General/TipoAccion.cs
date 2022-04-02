using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class TipoAccion
    {
        public TipoAccion()
        {
            AccionFlujoes = new List<AccionFlujo>();
            ExpedienteAccions = new List<ExpedienteAccion>();
            TipoExpedienteAccions = new List<TipoExpedienteAccion>();
        }

        public int IdTipoAccion { get; set; }
        public string Descripcion { get; set; }
        public int IdTipoEstado { get; set; }
        public bool Inactivo { get; set; }
        public virtual ICollection<AccionFlujo> AccionFlujoes { get; set; }
        public virtual ICollection<ExpedienteAccion> ExpedienteAccions { get; set; }
        public virtual ICollection<TipoExpedienteAccion> TipoExpedienteAccions { get; set; }
    }
}
