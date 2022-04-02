using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoOrdinarioCsAllanamientoTotal")]
    public class ExpedienteEstadoOrdinarioCsAllanamientoTotal
    {
        #region Constructors

        public ExpedienteEstadoOrdinarioCsAllanamientoTotal()
        {
        }
        public ExpedienteEstadoOrdinarioCsAllanamientoTotal(int idExpedienteEstado)
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

        //public DateTime? FechaSolicitudConsignacionBancaria { get; set; }
        //public DateTime? FechaRecepcionConsignacionBancaria { get; set; }
        //public string JuzgadoCuentaCorriente { get; set; }

        //public DateTime? FechaPresentacionEscAllanamiento { get; set; }
        //public DateTime? SentenciaFecha { get; set; }
        //public int? SentenciaResultadoId { get; set; }        

        //public bool Apelacion { get; set; }
        //public DateTime? ApelacionFecha { get; set; }
        //public int? ApelacionResultadoId { get; set; }
        //public int? ApelacionPorId { get; set; }

        #endregion

        #region Properties Readonly

        #endregion

    }
}
