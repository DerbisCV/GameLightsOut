using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public partial class Con_ExpedienteCredito
    {
        public Con_ExpedienteCredito()
        {
            Con_ExpedienteCreditoCalificacion = new List<Con_ExpedienteCreditoCalificacion>();
            Con_ExpedienteCreditoGarantiaAvalista = new List<Con_ExpedienteCreditoGarantiaAvalista>();
            Con_ExpedienteCreditoGarantiaInmuebles = new List<Con_ExpedienteCreditoGarantiaInmuebles>();
            Con_ExpedienteCreditoGarantiaOtros = new List<Con_ExpedienteCreditoGarantiaOtros>();
        }

        public int IdExpedienteCredito { get; set; }
        public int IdExpediente { get; set; }
        public string NoCuentaPrestamo { get; set; }
        public string Concepto { get; set; }
        public string NoReferencia { get; set; }
        public decimal? Importe { get; set; }
        public decimal? ImporteReconocidoProvisional { get; set; }
        public decimal? CuantiaReconocidoDefinitivo { get; set; }
        public decimal ImporteIntereses { get; set; }
        public decimal ImportePrincipal { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }
        public virtual ICollection<Con_ExpedienteCreditoCalificacion> Con_ExpedienteCreditoCalificacion { get; set; }
        public virtual ICollection<Con_ExpedienteCreditoGarantiaAvalista> Con_ExpedienteCreditoGarantiaAvalista { get; set; }
        public virtual ICollection<Con_ExpedienteCreditoGarantiaInmuebles> Con_ExpedienteCreditoGarantiaInmuebles { get; set; }
        public virtual ICollection<Con_ExpedienteCreditoGarantiaOtros> Con_ExpedienteCreditoGarantiaOtros { get; set; }
    }
}
