using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoBastanteoRecepcion")]
    public class ExpedienteEstadoBastanteoRecepcion : EstadoRecepcionBase, IExpedienteEstadoChild
    {
        #region Constructors

        public ExpedienteEstadoBastanteoRecepcion()
        {
        }
        public ExpedienteEstadoBastanteoRecepcion(int idExpedienteEstado)
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

        internal void RefreshBy(ExpedienteEstadoBastanteoRecepcion estadoBase)
        {
            FechaResolucionIncidenciaDocumental = estadoBase.FechaResolucionIncidenciaDocumental;
        }

        #endregion
    }
}
