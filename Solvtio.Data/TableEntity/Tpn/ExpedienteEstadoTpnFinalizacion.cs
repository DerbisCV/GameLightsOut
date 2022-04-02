using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoTpnFinalizacion")]
    public class ExpedienteEstadoTpnFinalizacion
    {
        #region Constructors

        public ExpedienteEstadoTpnFinalizacion()
        {
        }
        public ExpedienteEstadoTpnFinalizacion(int idExpedienteEstado)
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

        [ForeignKey("Motivo")]
        public int? IdMotivo { get; set; }
        public virtual Gnr_TipoEstadoMotivo Motivo { get; set; }

        #endregion

        #region Methods

        internal void RefreshBy(ExpedienteEstadoTpnFinalizacion estadoBase)
        {
            IdMotivo = estadoBase.IdMotivo;
        }

        #endregion

    }
}
