using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoPrelitigioRecepcion")]
    public class ExpedienteEstadoPrelitigioRecepcion : EstadoRecepcionBase, IExpedienteEstadoChild
    {
        #region Constructors

        public ExpedienteEstadoPrelitigioRecepcion()
        {
        }
        public ExpedienteEstadoPrelitigioRecepcion(int idExpedienteEstado)
        {
            IdExpedienteEstado = idExpedienteEstado;
        }

        #endregion

        #region Properties

        //[Key]
        //[ForeignKey("ExpedienteEstado")]
        //public int IdExpedienteEstado { get; set; }

        public int IdExpediente { get; set; }


        #endregion

        #region Methods

        internal void RefreshBy(ExpedienteEstadoPrelitigioRecepcion estadoBase)
        {
            FechaResolucionIncidenciaDocumental = estadoBase.FechaResolucionIncidenciaDocumental;
        }

        #endregion
    }
}
