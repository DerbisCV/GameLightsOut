using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoOrdinarioRecepcion")]
    public class ExpedienteEstadoOrdinarioRecepcion : EstadoRecepcionBase, IExpedienteEstadoChild
    {
        #region Constructors

        public ExpedienteEstadoOrdinarioRecepcion()
        {
        }
        public ExpedienteEstadoOrdinarioRecepcion(int idExpedienteEstado)
        {
            IdExpedienteEstado = idExpedienteEstado;
        }

        #endregion

        #region Properties

        //[Key]
        //[ForeignKey("ExpedienteEstado")]
        //public int IdExpedienteEstado { get; set; }
        //public virtual ExpedienteEstado ExpedienteEstado { get; set; }
        //public DateTime? FechaResolucionIncidenciaDocumental { get; set; }

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
