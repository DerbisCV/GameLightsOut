using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public class Ejc_ExpedienteEstadoEfectividadEmbargo
    {
        #region Properties

        public int IdExpedienteEstado { get; set; }
        [ForeignKey("IdExpedienteEstado")]
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }       
        public int IdExpediente { get; set; }
        public bool BienesInmuebles { get; set; }
        public bool BienesMuebles { get; set; }
        public bool BienesSalarios { get; set; }
        public bool BienesSaldosRetenciones { get; set; }


        #endregion

        #region Properties NotMapped

        [NotMapped]
        public decimal? DeudaPendiente { get; set; }

        [NotMapped]
        public decimal? TotalEmbargado { get; set; }

        #endregion

        #region Properties ReadOnly

        //public decimal? TotalEmbargado => (ExpedienteEstado.Expediente.Ejc_Expediente.AdmitidaDeudaReclamada ?? 0) - (DeudaPendiente ?? 0);

        #endregion
    }
}
