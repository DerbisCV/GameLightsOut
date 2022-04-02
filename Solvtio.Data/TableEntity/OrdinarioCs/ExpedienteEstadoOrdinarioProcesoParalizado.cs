using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoOrdinarioCsProcesoParalizado")]
    public class ExpedienteEstadoOrdinarioCsProcesoParalizado
    {
        #region Constructors

        public ExpedienteEstadoOrdinarioCsProcesoParalizado()
        {
        }
        public ExpedienteEstadoOrdinarioCsProcesoParalizado(int idExpedienteEstado)
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

        public DateTime? FechaParalizado { get; set; }
        public decimal? ImporteParalizado { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Motivo")]
        public int? IdMotivo { get; set; }
        public virtual Gnr_TipoEstadoMotivo Motivo { get; set; }

        #endregion
    }
}
