using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoOrdinarioCsAcuerdo")]
    public class ExpedienteEstadoOrdinarioCsAcuerdo
    {
        #region Constructors

        public ExpedienteEstadoOrdinarioCsAcuerdo()
        {
        }
        public ExpedienteEstadoOrdinarioCsAcuerdo(int idExpediente)
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

        //public DateTime? FechaPresentacionEscrito { get; set; }
        public int? IdTipoSolucion { get; set; }
        public decimal? AcuerdoImporte { get; set; }
        public DateTime? AcuerdoFechaCopiaSellada { get; set; }
        #endregion
    }
}
