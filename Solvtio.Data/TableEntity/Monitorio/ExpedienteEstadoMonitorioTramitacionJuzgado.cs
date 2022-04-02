using Solvtio.Models.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoMonitorioTramitacionJuzgado")]
    public class ExpedienteEstadoMonitorioTramitacionJuzgado
    {
        #region Constructors

        public ExpedienteEstadoMonitorioTramitacionJuzgado()
        {
            createBase();
        }

        private void createBase()
        {
            //TipoDecretoArchivo = Model.TipoDecretoArchivo.Pago;
        }

        public ExpedienteEstadoMonitorioTramitacionJuzgado(int idExpedienteEstado)
        {
            createBase();
            IdExpedienteEstado = idExpedienteEstado;
        }

        #endregion

        #region Properties

        [Key]
        [ForeignKey("ExpedienteEstado")]
        public int IdExpedienteEstado { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }
        public int IdExpediente { get; set; }

        //public DateTime? ContestacionDemandaFecha { get; set; }
        //public int? ContestacionDemandaReconvencion { get; set; }
        //public DateTime? ContestacionDemandaReconvencionFecha { get; set; }
        //public DateTime? ContestacionDecretoEmplazamientoReconvencionFecha { get; set; }
        //public DateTime? AudienciaPreviaFecha { get; set; }
        //public int? AudienciaPreviaResultadoId { get; set; }
        public DateTime? RequerimientoPagoFecha { get; set; }
        public bool? RequerimientoPagoPositivo { get; set; }     
        public DateTime? AdmitidaFecha { get; set; }
        public DateTime? FechaAutoSubsanado { get; set; }
        //public bool AdmitidaVerbal { get; set; }
        //public bool AdmitidaMonitorio { get; set; }
        public decimal? ImporteAdmision { get; set; }


        public TipoDecretoArchivo? TipoDecretoArchivo { get; set; }
        public DateTime? DecretoArchivoFecha { get; set; }
        public DateTime? TrasladoOposicionFecha { get; set; }


        #endregion

        #region Properties Readonly
        #endregion

    }
}
