using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoOrdinarioFinalizacion")]
    public class ExpedienteEstadoOrdinarioFinalizacion
    {
        #region Constructors

        public ExpedienteEstadoOrdinarioFinalizacion()
        {
        }
        public ExpedienteEstadoOrdinarioFinalizacion(int idExpedienteEstado)
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
        
        public bool PagoDeuda { get; set; }
        public bool DacionPago { get; set; }
        public bool EstimacionOposicion { get; set; }
        public bool Devuelto { get; set; }
        public bool Llaves { get; set; }

        [ForeignKey("Motivo")]
        public int? IdMotivo { get; set; }
        public virtual Gnr_TipoEstadoMotivo Motivo { get; set; }

        #endregion

    }
}
