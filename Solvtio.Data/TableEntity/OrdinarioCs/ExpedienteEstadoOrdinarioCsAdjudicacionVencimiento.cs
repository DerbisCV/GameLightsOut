using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoOrdinarioCsAdjudicacionVencimiento")]
    public partial class ExpedienteEstadoOrdinarioCsAdjudicacionVencimiento
    {
        #region Constructors

        public ExpedienteEstadoOrdinarioCsAdjudicacionVencimiento() { }
        public ExpedienteEstadoOrdinarioCsAdjudicacionVencimiento(int idExpedienteEstado)
        {
            IdExpedienteEstado = idExpedienteEstado;
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int IdExpedienteEstado { get; set; }
        [ForeignKey("IdExpedienteEstado")]
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public DateTime Fecha { get; set; }
        public bool Ejecutado { get; set; }
        public string Observaciones { get; set; }

        #endregion



    }
}
