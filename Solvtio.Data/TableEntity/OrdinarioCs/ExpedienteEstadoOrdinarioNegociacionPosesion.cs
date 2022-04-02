using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoOrdinarioCsNegociacionPosesion")]
    public class ExpedienteEstadoOrdinarioCsNegociacionPosesion
    {
        #region Constructors

        public ExpedienteEstadoOrdinarioCsNegociacionPosesion()
        {
        }
        public ExpedienteEstadoOrdinarioCsNegociacionPosesion(int idExpedienteEstado)
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



        public string DatosContacto { get; set; }
        public string Incidencias { get; set; }
        public int? NegociacionFinalizadaPor { get; set; }
        public DateTime? FechaPropuestaEnviada { get; set; }
        public DateTime? FechaPropuestaAceptada { get; set; }
        public DateTime? FechaCartaPagoEnviada { get; set; }
        public DateTime? FechaCartaPagoFirmada { get; set; }
        public DateTime? FechaCartaPagoEnviadaAlProcurador { get; set; }

        public DateTime? FechaFirma { get; set; }
        public DateTime? FechaPresentacionJuzgado { get; set; }
        public DateTime? FechaEnvioFacturacion { get; set; }
        public DateTime? FechaPepaDenegada { get; set; }
        public DateTime? FechaPepaCancelada { get; set; }
        public bool DiligenciaPosesion { get; set; }

        #endregion

        #region Properties Not Mapped

        [NotMapped]
		public DateTime? EstadoAdjudicacionFechaLanzamiento { set; get; }

		#endregion
	}
}
