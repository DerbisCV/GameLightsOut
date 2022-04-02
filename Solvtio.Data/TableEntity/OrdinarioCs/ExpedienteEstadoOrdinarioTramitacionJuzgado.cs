using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoOrdinarioCsTramitacionJuzgado")]
    public class ExpedienteEstadoOrdinarioCsTramitacionJuzgado
    {
        #region Constructors

        public ExpedienteEstadoOrdinarioCsTramitacionJuzgado()
        {
        }
        public ExpedienteEstadoOrdinarioCsTramitacionJuzgado(int idExpedienteEstado)
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


        public DateTime? ContestacionDemandaFecha { get; set; }
        public int? ContestacionDemandaReconvencion { get; set; }
        public DateTime? ContestacionDemandaReconvencionFecha { get; set; }
        public DateTime? AudienciaPreviaFecha { get; set; }
        public int? AudienciaPreviaResultadoId { get; set; }
        public DateTime? RequerimientoPagoFecha { get; set; }
        public bool? RequerimientoPagoPositivo { get; set; }
        
        public DateTime? AdmitidaFecha { get; set; }
        public string AdmitidaNoAuto { get; set; }


        

        public int? IdJuzgado { get; set; }
        [ForeignKey("IdJuzgado")]
        public virtual Juzgado Juzgado { get; set; }



        public bool AdmitidaVerbal { get; set; }
        public bool AdmitidaOrdinarioCs { get; set; }
        public decimal? ImporteAdmision { get; set; }

        #endregion

        #region Properties Readonly

        public string AdmitidaJuzgado => Juzgado == null ? "" : Juzgado.Nombre;

        #endregion

    }
}
