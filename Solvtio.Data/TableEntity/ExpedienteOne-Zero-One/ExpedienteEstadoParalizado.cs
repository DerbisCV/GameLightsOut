using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoParalizado")]
    public class ExpedienteEstadoParalizado
    {
        #region Constructors

        public ExpedienteEstadoParalizado() { }
        public ExpedienteEstadoParalizado(int idExpediente)
        {
            IdExpediente = idExpediente;
            //IdExpedienteEstado = idExpedienteEstado;
        }

        #endregion

        #region Properties

        [Key, ForeignKey("ExpedienteEstado")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int IdExpedienteEstado { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }


        public int IdExpediente { get; set; }


        public int? IdMotivo { get; set; }
        [ForeignKey("IdMotivo")]
        public virtual Gnr_TipoEstadoMotivo Motivo { get; set; }

        #endregion

    }
}
