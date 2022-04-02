using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoOrdinarioCsSentencia")]
    public class ExpedienteEstadoOrdinarioCsSentencia
    {
        #region Constructors

        public ExpedienteEstadoOrdinarioCsSentencia()
        {
        }
        public ExpedienteEstadoOrdinarioCsSentencia(int idExpediente)
        {
            IdExpediente = idExpediente;
        }

        #endregion

        #region Properties

        [Key]
        [ForeignKey("ExpedienteEstado")]
        public int IdExpedienteEstado { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public int IdExpediente { get; set; }

        public bool SentenciaConCostas { get; set; }
        public DateTime? SentenciaFecha { get; set; }
        public int? SentenciaResultadoId { get; set; }

        public bool Apelacion { get; set; }
        public DateTime? ApelacionFecha { get; set; }
        public int? ApelacionResultadoId { get; set; }
        public int? ApelacionPorId { get; set; }

        public decimal? InteresLiquidacion { get; set; }
        public decimal? InteresDecreto { get; set; }
        public decimal? CostasTasacion { get; set; }
        public decimal? CostasDecreto { get; set; }
        public bool CostasAbonadas { get; set; }

        #endregion
    }
}
