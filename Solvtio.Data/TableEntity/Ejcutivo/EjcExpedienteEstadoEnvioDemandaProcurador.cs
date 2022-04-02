using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("EjcExpedienteEstadoEnvioDemandaProcurador")]
    public class EjcExpedienteEstadoEnvioDemandaProcurador
    {
        #region Constructors

        public EjcExpedienteEstadoEnvioDemandaProcurador()
        {
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("ExpedienteEstado")]
        public int IdExpedienteEstado { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public int IdExpediente { get; set; }
        public DateTime? FechaPagoTasas { get; set; }
        public DateTime? FechaEnvioProcurador { get; set; }
      
        #endregion

    }
}
