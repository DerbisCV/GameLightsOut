using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class Gnr_TipoDeudor : IDescripcion
    {
        public Gnr_TipoDeudor()
        {
            Con_ExpedienteCreditoGarantiaAvalista = new List<Con_ExpedienteCreditoGarantiaAvalista>();
            ExpedienteDeudors = new List<ExpedienteDeudor>();
        }

        public int IdTipoDeudor { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionDemanda { get; set; }
        public bool Activo { get; set; }
        public int? IdTipoExpediente { get; set; }
        public virtual ICollection<Con_ExpedienteCreditoGarantiaAvalista> Con_ExpedienteCreditoGarantiaAvalista { get; set; }
        public virtual ICollection<ExpedienteDeudor> ExpedienteDeudors { get; set; }
        public virtual Gnr_TipoExpediente Gnr_TipoExpediente { get; set; }

        public int Id => IdTipoDeudor;
        public string NombreParaDemanda => string.IsNullOrEmpty(DescripcionDemanda) ? Descripcion : DescripcionDemanda;
    }
}
