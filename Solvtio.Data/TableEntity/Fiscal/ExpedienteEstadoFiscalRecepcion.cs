using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoFiscalRecepcion")]
    public class ExpedienteEstadoFiscalRecepcion : EstadoRecepcionBase, IExpedienteEstadoChild
    {
        #region Constructors

        public ExpedienteEstadoFiscalRecepcion()
        {
        }
        public ExpedienteEstadoFiscalRecepcion(int idExpedienteEstado)
        {
            IdExpedienteEstado = idExpedienteEstado;
        }

        #endregion

        #region Properties

        [Key]
        [ForeignKey("ExpedienteEstado")]
        public int IdExpedienteEstado { get; set; }

        public int IdExpediente { get; set; }


        #endregion

        #region Methods

        internal void RefreshBy(ExpedienteEstadoFiscalRecepcion estadoBase)
        {
            FechaResolucionIncidenciaDocumental = estadoBase.FechaResolucionIncidenciaDocumental;
        }

        #endregion
    }
}
