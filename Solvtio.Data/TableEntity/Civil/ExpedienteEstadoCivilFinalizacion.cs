using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoCivilFinalizacion")]
    public class ExpedienteEstadoCivilFinalizacion
    {
        #region Constructors

        public ExpedienteEstadoCivilFinalizacion()
        {
        }
        public ExpedienteEstadoCivilFinalizacion(int idExpedienteEstado)
        {
            IdExpedienteEstado = idExpedienteEstado;
        }

        #endregion

        #region Properties

        [Key]
        [ForeignKey("ExpedienteEstado")]
        public int IdExpedienteEstado { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }
        public int IdExpediente { get; set; }

        //public bool PagoDeuda { get; set; }
        //public bool EntregaPosesion { get; set; }
        //public bool DesestimacionDemanda { get; set; }
        //public bool Llaves { get; set; }
        //public bool EnervacionJudicial { get; set; }
        //public bool DesestimientoJudicial { get; set; }
        //public bool PorAcuerdo { get; set; }
        //public bool ParalizacionInstCliente { get; set; }
        //public bool Mediacion { get; set; }
        //public bool CondonacionSinProceso { get; set; }
        //public bool Facturable { get; set; }
        //public bool Precontencioso { get; set; }
        //public bool SentenciaEstimatoria { get; set; }

        #endregion

    }
}
