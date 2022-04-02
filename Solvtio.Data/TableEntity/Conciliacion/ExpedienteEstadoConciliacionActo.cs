using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoConciliacionActo")]
    public class ExpedienteEstadoConciliacionActo
    {
        #region Constructors

        public ExpedienteEstadoConciliacionActo()
        {
        }
        public ExpedienteEstadoConciliacionActo(int idExpedienteEstado)
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

        public DateTime? FechaAdmision { get; set; }
        public DateTime? FechaSenalamiento { get; set; }
        public DateTime? FechaResolucion { get; set; }
        public bool ResolucionConAvenencia { get; set; }

        internal void RefreshBy(ExpedienteEstadoConciliacionActo model)
        {
            FechaAdmision = model.FechaAdmision;
            FechaSenalamiento = model.FechaSenalamiento;
            FechaResolucion = model.FechaResolucion;
            ResolucionConAvenencia = model.ResolucionConAvenencia;
        }

        //public bool EnervacionJudicial { get; set; }
        //public bool DesestimientoJudicial { get; set; }
        //public bool PorAcuerdo { get; set; }
        //public bool ParalizacionInstCliente { get; set; }
        //public bool Mediacion { get; set; }
        //public bool CondonacionSinProceso { get; set; }
        //public bool Facturable { get; set; }
        //public bool Precontencioso { get; set; }
        //public bool SentenciaEstimatoria { get; set; }

        #endregion

    }
}
