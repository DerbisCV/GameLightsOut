using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoPenalRecepcion")]
    public class ExpedienteEstadoPenalRecepcion : EstadoRecepcionBase, IExpedienteEstadoChild
    {
        #region Constructors

        public ExpedienteEstadoPenalRecepcion()
        {
        }
        public ExpedienteEstadoPenalRecepcion(int idExpedienteEstado)
        {
            IdExpedienteEstado = idExpedienteEstado;
        }

        #endregion

        #region Properties

        [Key]
        [ForeignKey("ExpedienteEstado")]
        public int IdExpedienteEstado { get; set; }

        public int IdExpediente { get; set; }


        //public bool PendienteDocumentacion { get; set; }
        //public bool BurofaxFiadores { get; set; }
        //public bool PagosACuenta { get; set; }
        //public string ParalizadoPor { get; set; }

        #endregion
    }
}
