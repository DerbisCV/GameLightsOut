using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public partial class AlqExpedienteEstadoEnervacion
    {
        #region Constructors
        public AlqExpedienteEstadoEnervacion()
        {
            //this.Alq_Expediente_EstadoTramitaJuzgado_Actuaciones = new List<Alq_Expediente_EstadoTramitaJuzgado_Actuacion>();
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("ExpedienteEstado")]
        public int IdExpedienteEstado { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public decimal? DeudaActualizada { get; set; }

        #endregion

        #region Properties Readonly

        #endregion

        #region Properties virtual ICollection

        //public virtual ICollection<Alq_Expediente_EstadoTramitaJuzgado_Actuacion> Alq_Expediente_EstadoTramitaJuzgado_Actuaciones { get; set; }
 
        #endregion

    }
}
