using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoOrdinarioCsEjecucionSentencia")]
    public class ExpedienteEstadoOrdinarioCsEjecucionSentencia
    {
        #region Constructors

        public ExpedienteEstadoOrdinarioCsEjecucionSentencia()
        {
        }
        public ExpedienteEstadoOrdinarioCsEjecucionSentencia(int idExpedienteEstado)
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

        #region Demanda NO Admitida

        public DateTime? NoAdmitidaFecha { get; set; }
        public DateTime? NoAdmitidaFechaApelacion { get; set; }
        public DateTime? NoAdmitidaFechaResultadoApelacion { get; set; }
        public bool NoAdmitidaApelacion { get; set; }
        public int? NoAdmitidaResultadoApelacionId { get; set; }

        #endregion

        #region Demanda Admitida

        public DateTime? DemandaAdmitidaFecha { get; set; }
        public string DemandaAdmitidaNoAuto { get; set; }
        public decimal DemandaAdmitidaDeudaReclamada { get; set; }

        #endregion

        #region Cumplimiento Ejecucion

        public DateTime? CumplimientoEjecucionFechaCopiaSellada { get; set; }
        public bool CumplimientoEjecucionAportadoCuadro { get; set; }
        public bool CumplimientoEjecucionAportadoAbono { get; set; }
        public bool CumplimientoEjecucionEliminacionClausula { get; set; }

        #endregion

        #region Oposicion

        public bool Oposicion { get; set; }
        public DateTime? OposicionFecha { get; set; }
        public DateTime? OposicionFechaCelebracionVista { get; set; }
        public DateTime? OposicionFechaResolucion { get; set; }
        public bool Apelacion { get; set; }
        public DateTime? ApelacionFecha { get; set; }
        public int? ApelacionPor { get; set; }
        public int? ApelacionResultado { get; set; }

        #endregion

        #endregion
    }
}
