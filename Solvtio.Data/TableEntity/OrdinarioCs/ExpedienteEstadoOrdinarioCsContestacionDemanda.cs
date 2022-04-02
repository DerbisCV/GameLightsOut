using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoOrdinarioCsContestacionDemanda")]
    public class ExpedienteEstadoOrdinarioCsContestacionDemanda
    {
        #region Constructors

        public ExpedienteEstadoOrdinarioCsContestacionDemanda()
        {
        }
        public ExpedienteEstadoOrdinarioCsContestacionDemanda(int idExpedienteEstado)
        {
            IdExpedienteEstado = idExpedienteEstado;
        }

        #endregion

        #region Properties

        [Key]
        [ForeignKey("ExpedienteEstado")]
        public int IdExpedienteEstado { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public int IdExpediente { get; set; }


        public DateTime? DemandaAdmitidaFecha { get; set; }
        public decimal? DemandaAdmitidaImporte { get; set; }
        public bool DemandaAdmitidaVerbal { get; set; }
        public bool DemandaAdmitidaOrdinario { get; set; }

 
        public DateTime? ContestacionDemandaFecha { get; set; }
        public int? ContestacionDemandaReconvencion { get; set; }
        public DateTime? ContestacionDemandaReconvencionFecha { get; set; }
        public DateTime? ContestacionDecretoEmplazamientoReconvencionFecha { get; set; }


        #endregion
    }
}
