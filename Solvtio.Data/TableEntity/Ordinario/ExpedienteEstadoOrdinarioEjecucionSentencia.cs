using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoOrdinarioEjecucionSentencia")]
    public class ExpedienteEstadoOrdinarioEjecucionSentencia
    {
        #region Constructors

        public ExpedienteEstadoOrdinarioEjecucionSentencia()
        {
        }
        public ExpedienteEstadoOrdinarioEjecucionSentencia(int idExpedienteEstado)
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


        public DateTime? PresentacionDemandaFechaPresentacion { get; set; }
        public DateTime? PresentacionDemandaFechaPagoTasas { get; set; }
        public DateTime? PresentacionDemandaFechaEnvioProcurador { get; set; }

        public DateTime? NoAdmitidaFecha { get; set; }
        public DateTime? NoAdmitidaFechaApelacion { get; set; }
        public DateTime? NoAdmitidaFechaResultadoApelacion { get; set; }
        public bool NoAdmitidaApelacion { get; set; }
        public int? NoAdmitidaResultadoApelacionId { get; set; }

        #endregion
    }
}
