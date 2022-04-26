using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoContenciosoAdministrativoRecepcion")]
    public class ExpedienteEstadoContenciosoAdministrativoRecepcion : EstadoRecepcionBase, IExpedienteEstadoChild
    {
        #region Constructors

        public ExpedienteEstadoContenciosoAdministrativoRecepcion()
        {
        }
        public ExpedienteEstadoContenciosoAdministrativoRecepcion(int idExpedienteEstado)
        {
            IdExpedienteEstado = idExpedienteEstado;
        }

        #endregion

        #region Properties

        //[Key]
        //[ForeignKey("ExpedienteEstado")]
        //public int IdExpedienteEstado { get; set; }

        public int IdExpediente { get; set; }

        //public bool PendienteDocumentacion { get; set; }
        //public bool BurofaxFiadores { get; set; }
        //public bool PagosACuenta { get; set; }
        //public string ParalizadoPor { get; set; }

        #endregion

        #region Methods

        internal void Refresh(ExpedienteEstadoContenciosoAdministrativoRecepcion model)
        {
            FechaResolucionIncidenciaDocumental = model.FechaResolucionIncidenciaDocumental;
            //entidad.PendienteDocumentacion = model.PendienteDocumentacion;
            //entidad.BurofaxFiadores = model.BurofaxFiadores;
            //entidad.PagosACuenta = model.PagosACuenta;
            //entidad.ParalizadoPor = model.ParalizadoPor;
        }

        #endregion
    }
}
