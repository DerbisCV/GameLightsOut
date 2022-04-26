using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoMonitorioRecepcion")]
    public class ExpedienteEstadoMonitorioRecepcion : EstadoRecepcionBase, IExpedienteEstadoChild
    {
        #region Constructors

        public ExpedienteEstadoMonitorioRecepcion()
        {
        }
        public ExpedienteEstadoMonitorioRecepcion(int idExpedienteEstado)
        {
            IdExpedienteEstado = idExpedienteEstado;
        }

        #endregion

        #region Properties

        //[Key]
        //[ForeignKey("ExpedienteEstado")]
        //public int IdExpedienteEstado { get; set; }

        public int IdExpediente { get; set; }

        public bool TituloEjecutivo { get; set; }
        public bool TituloInscrito { get; set; }
        public bool RevisionCargas { get; set; }
        public bool BurofaxesEnviados { get; set; }
        public bool BurofaxesFiadores { get; set; }
        public bool PagosCuenta { get; set; }
        public bool CantidadesConsignar { get; set; }
        public bool NotaSimple { get; set; }

        #endregion
    }
}
