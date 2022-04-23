using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public partial class AlqExpedienteEstadoProcesoParalizado
    {
        #region Constructors
        public AlqExpedienteEstadoProcesoParalizado()
        {
            //this.Alq_Expediente_EstadoTramitaJuzgado_Actuaciones = new List<Alq_Expediente_EstadoTramitaJuzgado_Actuacion>();
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("ExpedienteEstado")]
        public int IdExpedienteEstado { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public int? IdMotivo { get; set; }
        [ForeignKey("IdMotivo")]
        public virtual Gnr_TipoEstadoMotivo Gnr_TipoEstadoMotivo { get; set; }

        public string Observaciones { get; set; }

        #endregion

        #region Properties Readonly

        #endregion

        #region Properties virtual ICollection

        //public virtual ICollection<Alq_Expediente_EstadoTramitaJuzgado_Actuacion> Alq_Expediente_EstadoTramitaJuzgado_Actuaciones { get; set; }

        #endregion

    }
}
