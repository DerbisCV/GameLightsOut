using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoOrdinarioCsAudienciaPrevia")]
    public class ExpedienteEstadoOrdinarioCsAudienciaPrevia
    {
        #region Constructors

        public ExpedienteEstadoOrdinarioCsAudienciaPrevia()
        {
        }
        public ExpedienteEstadoOrdinarioCsAudienciaPrevia(int idExpedienteEstado)
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

        public DateTime? Fecha { get; set; }    
        public int? ResultadoId { get; set; }

        #endregion

        #region Properties Readonly

        #endregion

    }
}
