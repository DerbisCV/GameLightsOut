using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoTestamentarioRecepcion")]
    public class ExpedienteEstadoTestamentarioRecepcion : EstadoRecepcionBase, IExpedienteEstadoChild
    {
        #region Constructors

        public ExpedienteEstadoTestamentarioRecepcion()
        {
        }
        public ExpedienteEstadoTestamentarioRecepcion(int idExpedienteEstado)
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

        internal void RefreshBy(ExpedienteEstadoTestamentarioRecepcion estadoBase)
        {
            FechaResolucionIncidenciaDocumental = estadoBase.FechaResolucionIncidenciaDocumental;
        }

        #endregion
    }
}
