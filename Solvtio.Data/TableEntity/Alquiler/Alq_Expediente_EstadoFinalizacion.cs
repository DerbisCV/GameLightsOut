using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public partial class Alq_Expediente_EstadoFinalizacion
    {
        #region Properties

        public int IdExpedienteEstado { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public bool PagoDeuda { get; set; }
        public bool EntregaPosesion { get; set; }
        public bool DesestimacionDemanda { get; set; }
        
        public bool Llaves { get; set; }
        public bool EnervacionJudicial { get; set; }
        public bool DesestimientoJudicial { get; set; }
        public bool PorAcuerdo { get; set; }
        public bool ParalizacionInstCliente { get; set; }
        public bool Mediacion { get; set; }
        public bool CondonacionSinProceso { get; set; }
		public bool Facturable { get; set; }
		public bool Precontencioso { get; set; }
        public bool SentenciaEstimatoria { get; set; }

        public bool Archivo { get; set; }
        public bool ArchivoProvisional { get; set; }
        public bool CesionVenia { get; set; }
        //public bool? TomadaPosesion { get; set; }

        public int? IdMotivo { get; set; }
        [ForeignKey("IdMotivo")]
        public virtual Gnr_TipoEstadoMotivo Motivo { get; set; }


        #endregion
    }
}
