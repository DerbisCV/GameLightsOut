using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoTpnRecepcion")]
    public class ExpedienteEstadoTpnRecepcion : EstadoRecepcionBase, IExpedienteEstadoChild
    {
        #region Constructors

        public ExpedienteEstadoTpnRecepcion()
        {
        }
        public ExpedienteEstadoTpnRecepcion(int idExpedienteEstado)
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

        internal void RefreshBy(ExpedienteEstadoTpnRecepcion estadoBase)
        {
            FechaResolucionIncidenciaDocumental = estadoBase.FechaResolucionIncidenciaDocumental;
        }

        #endregion
    }
}
