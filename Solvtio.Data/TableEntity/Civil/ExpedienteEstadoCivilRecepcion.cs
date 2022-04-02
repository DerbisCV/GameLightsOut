using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoCivilRecepcion")]
    public class ExpedienteEstadoCivilRecepcion : EstadoRecepcionBase, IExpedienteEstadoChild
    {
        #region Constructors

        public ExpedienteEstadoCivilRecepcion()
        {
        }
        public ExpedienteEstadoCivilRecepcion(int idExpedienteEstado)
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
