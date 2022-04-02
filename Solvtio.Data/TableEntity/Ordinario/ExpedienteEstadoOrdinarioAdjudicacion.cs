using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoOrdinarioAdjudicacion")]
    public class ExpedienteEstadoOrdinarioAdjudicacion
    {
        #region Constructors

        public ExpedienteEstadoOrdinarioAdjudicacion()
        {
        }
        public ExpedienteEstadoOrdinarioAdjudicacion(int idExpedienteEstado)
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


        public DateTime? FechaAdjudicacion { get; set; }
        public int? DocumentoActaAdjudicacionId { get; set; }
        public bool LiquidacionITP { get; set; }
        public DateTime? FechaLiquidacionITP { get; set; }
        public int? DocumentoLiquidacionITPId { get; set; }
        public DateTime? FechaCertificadoInscripcion { get; set; }
        public int? DocumentoCertificadoInscripcionId { get; set; }
        public DateTime? FechaDiligenciaPosesion { get; set; }
        public int? DocumentoDiligenciaPosesionId { get; set; }
        public bool Inquilinos { get; set; }
        public DateTime? FechaLanzamiento { get; set; }
        public int? DocumentoSolicitudLanzamientoId { get; set; }
        public DateTime? FechaEntregaLLaves { get; set; }
        public int? DocumentoEntregaLLavesId { get; set; }
        public bool Defectos { get; set; }
        public bool Subsanado { get; set; }
        public DateTime? FechaSubsanado { get; set; }
        public bool FormaPacifica { get; set; }

        public bool Ocupantes { get; set; }

        public DateTime? FechaVista { get; set; }
        public bool ContratoAlquiler { get; set; }
        public DateTime? FechaTestimonio { get; set; }
        public int? DocumentoTestimonioDecretoId { get; set; }
        public int? DocumentoOcupantesId { get; set; }
        public int? DocumentoVistaOcupantesId { get; set; }
        public string Nota { get; set; }
        public string ObservacionesCertificadoInscripcion { get; set; }
        public DateTime? FechaSolicitudPosesion { get; set; }
        public bool TituloJustificanteOcupacion { get; set; }
        public bool DocumentacionOriginalRecibida { get; set; }
        public string ObservacionesDocumentacionOriginal { get; set; }
        public int? ResultadoPosesion { get; set; }
          
		

	    public bool Oposicion { get; set; }
		public int? OposicionResultado { get; set; }
		public DateTime? OposicionFecha { get; set; }
		public DateTime? OposicionVistaFecha { get; set; }
		public DateTime? OposicionResolucionFecha { get; set; }
		public bool Apelacion { get; set; }
		public int? ApelacionPor { get; set; }
		public DateTime? ApelacionFecha { get; set; }
		public int? ApelacionResultado { get; set; }

	    #endregion
	}
}
