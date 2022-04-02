using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public partial class Hip_ExpedienteEstadoAdjudicacion
	{
		#region Properties Before EF Migration

		public int ExpedienteEstadoId { get; set; }
        public DateTime? FechaAdjudicacion { get; set; }
        public bool LiquidacionITP { get; set; }
        public DateTime? FechaLiquidacionITP { get; set; }
        public DateTime? FechaCertificadoInscripcion { get; set; }
        public DateTime? FechaDiligenciaPosesion { get; set; }
        public bool Inquilinos { get; set; }
        public DateTime? FechaLanzamiento { get; set; }
        public DateTime? FechaEntregaLLaves { get; set; }
        public bool Defectos { get; set; }
        public bool Subsanado { get; set; }
        public DateTime? FechaSubsanado { get; set; }
        public bool FormaPacifica { get; set; }
        public bool Ocupantes { get; set; }
        public DateTime? FechaVista { get; set; }
        public bool ContratoAlquiler { get; set; }
        public DateTime? FechaTestimonio { get; set; }
        public string Nota { get; set; }
        public string ObservacionesCertificadoInscripcion { get; set; }
        public DateTime? FechaSolicitudPosesion { get; set; }
        public bool TituloJustificanteOcupacion { get; set; }
        public bool DocumentacionOriginalRecibida { get; set; }
        public string ObservacionesDocumentacionOriginal { get; set; }
        public int? ResultadoPosesion { get; set; }
       
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

	    public int? DocumentoCertificadoInscripcionId { get; set; }
	    public int? DocumentoDiligenciaPosesionId { get; set; }
	    public int? DocumentoLiquidacionITPId { get; set; }
	    public int? DocumentoActaAdjudicacionId { get; set; }
	    public int? DocumentoEntregaLLavesId { get; set; }
	    public int? DocumentoTestimonioDecretoId { get; set; }
	    public int? DocumentoOcupantesId { get; set; }
	    public int? DocumentoVistaOcupantesId { get; set; }
	    public int? DocumentoSolicitudLanzamientoId { get; set; }

        #endregion

        #region Properties New

        public bool Apelacion { get; set; }
		public int? ApelacionPor { get; set; }
		public DateTime? ApelacionFecha { get; set; }
		public int? ApelacionResultado { get; set; }

        public DateTime? CalificacionNegativaFecha { get; set; }
        public bool CalificacionNegativaActaSituacionArrendaticia { get; set; }
        public bool CalificacionNegativaInscripcionCredito { get; set; }
        public bool CalificacionNegativaOtro { get; set; }
        public string CalificacionNegativaOtroObservacion { get; set; }
        public bool CalificacionNegativaOmisionImputacionPagos654 { get; set; }
        public bool CalificacionNegativaDefectosImpultacion654 { get; set; }
        public bool CalificacionNegativaIndenciaImportesAdjudicacion { get; set; }
        public bool CalificacionNegativaExcesoResponsabilidadHip { get; set; }
        public bool CalificacionNegativaDefectosNotificaciones { get; set; }
        public bool CalificacionNegativaCargasPrevias { get; set; }
        public bool CalificacionNegativaInstanciasConfusionDerechos { get; set; }
        public bool CalificacionNegativaCargasUrbanisticas { get; set; }
        public bool CalificacionNegativaLimitacionesLibreDisposición { get; set; }
        public bool CalificacionNegativaIbisPendientes { get; set; }
        public bool CalificacionNegativaDeudasComunidadPropietario { get; set; }
        public bool CalificacionNegativaDerechosTanteoRetracto { get; set; }
        public bool CalificacionNegativaDefectosMandamientosCancelacion { get; set; }
        public bool CalificacionNegativaPteCancelacionNotaMarginal { get; set; }


        public DateTime? ActaArrendaticiaFechaSolicitud { get; set; }
        public DateTime? ActaArrendaticiaFechaRecepcion { get; set; }
        public DateTime? ActaArrendaticiaFechaEnvioProcurador { get; set; }
        public string ActaArrendaticiaReclamacion { get; set; }
        public string ActaArrendaticiaObservaciones { get; set; }

        public DateTime? InscripcionCreditoFechaSolicitud { get; set; }
        public DateTime? InscripcionCreditoFechaRecepcion { get; set; }
        public DateTime? InscripcionCreditoFechaEnvioProcurador { get; set; }
        public string InscripcionCreditoReclamacion { get; set; }
        public string InscripcionCreditoObservaciones { get; set; }
        public bool InscripcionCreditoReciboOriginal { get; set; }
        public bool InscripcionCreditoReciboCopiaSimple { get; set; }

        //public int? IdIncidencia { get; set; }
        //[ForeignKey("IdIncidencia")]
        //public virtual CaracteristicaBase Incidencia { get; set; }

        //public int? IdIncidenciaProcesal { get; set; }
        //[ForeignKey("IdIncidenciaProcesal")]
        //public virtual CaracteristicaBase IncidenciaProcesal { get; set; }

        //public DateTime? IncidenciaProcesalFechaResolucion { get; set; }

        #endregion

        #region Properties NotMapped

        [NotMapped]
	    public Impulso Impulso { get; set; }

        #endregion

        #region Properties ReadOnly

	    public string ResultadoPosesionName => !ResultadoPosesion.HasValue ? ""
	        : ResultadoPosesion.Equals(1) ? "Positiva"
	        : ResultadoPosesion.Equals(2) ? "Negativa - Prórroga Ley 1/13"
	        : ResultadoPosesion.Equals(3) ? "Negativa - Reconocido Arrendamiento"
	        : ResultadoPosesion.Equals(4) ? "Suspendida (instrucciones gestores)"
	        : ResultadoPosesion.Equals(5) ? "Negativa"
            : "";

        #endregion

        #region Methods

        internal void RefreshBy(Hip_ExpedienteEstadoAdjudicacion model)
        {
            ActaArrendaticiaFechaSolicitud = model.ActaArrendaticiaFechaSolicitud;
            ActaArrendaticiaFechaRecepcion = model.ActaArrendaticiaFechaRecepcion;
            ActaArrendaticiaFechaEnvioProcurador = model.ActaArrendaticiaFechaEnvioProcurador;
            ActaArrendaticiaReclamacion = model.ActaArrendaticiaReclamacion;
            ActaArrendaticiaObservaciones = model.ActaArrendaticiaObservaciones;

            //Apelacion = model.Apelacion;
            //ApelacionFecha = model.ApelacionFecha;
            //ApelacionPor = model.ApelacionPor;
            //ApelacionResultado = model.ApelacionResultado;

            FechaAdjudicacion = model.FechaAdjudicacion;
            FechaTestimonio = model.FechaTestimonio;
            LiquidacionITP = model.LiquidacionITP;
            FechaLiquidacionITP = model.FechaLiquidacionITP;
            FechaCertificadoInscripcion = model.FechaCertificadoInscripcion;
            ObservacionesCertificadoInscripcion = model.ObservacionesCertificadoInscripcion;
            FechaSolicitudPosesion = model.FechaSolicitudPosesion;
            DocumentacionOriginalRecibida = model.DocumentacionOriginalRecibida;
            ObservacionesDocumentacionOriginal = model.ObservacionesDocumentacionOriginal;
            //IdIncidencia = model.IdIncidencia;

            InscripcionCreditoFechaSolicitud = model.InscripcionCreditoFechaSolicitud;
            InscripcionCreditoFechaRecepcion = model.InscripcionCreditoFechaRecepcion;
            InscripcionCreditoFechaEnvioProcurador = model.InscripcionCreditoFechaEnvioProcurador;
            InscripcionCreditoReclamacion = model.InscripcionCreditoReclamacion;
            InscripcionCreditoReciboOriginal = model.InscripcionCreditoReciboOriginal;
            InscripcionCreditoReciboCopiaSimple = model.InscripcionCreditoReciboCopiaSimple;
            InscripcionCreditoObservaciones = model.InscripcionCreditoObservaciones;

            CalificacionNegativaFecha = model.CalificacionNegativaFecha;
            CalificacionNegativaActaSituacionArrendaticia = model.CalificacionNegativaActaSituacionArrendaticia;
            CalificacionNegativaInscripcionCredito = model.CalificacionNegativaInscripcionCredito;
            CalificacionNegativaOmisionImputacionPagos654 = model.CalificacionNegativaOmisionImputacionPagos654;
            CalificacionNegativaDefectosImpultacion654 = model.CalificacionNegativaDefectosImpultacion654;
            CalificacionNegativaIndenciaImportesAdjudicacion = model.CalificacionNegativaIndenciaImportesAdjudicacion;
            CalificacionNegativaExcesoResponsabilidadHip = model.CalificacionNegativaExcesoResponsabilidadHip;
            CalificacionNegativaDefectosNotificaciones = model.CalificacionNegativaDefectosNotificaciones;
            CalificacionNegativaCargasPrevias = model.CalificacionNegativaCargasPrevias;
            CalificacionNegativaInstanciasConfusionDerechos = model.CalificacionNegativaInstanciasConfusionDerechos;
            CalificacionNegativaCargasUrbanisticas = model.CalificacionNegativaCargasUrbanisticas;
            CalificacionNegativaLimitacionesLibreDisposición = model.CalificacionNegativaLimitacionesLibreDisposición;
            CalificacionNegativaIbisPendientes = model.CalificacionNegativaIbisPendientes;
            CalificacionNegativaDeudasComunidadPropietario = model.CalificacionNegativaDeudasComunidadPropietario;
            CalificacionNegativaDerechosTanteoRetracto = model.CalificacionNegativaDerechosTanteoRetracto;
            CalificacionNegativaDefectosMandamientosCancelacion = model.CalificacionNegativaDefectosMandamientosCancelacion;
            CalificacionNegativaPteCancelacionNotaMarginal = model.CalificacionNegativaPteCancelacionNotaMarginal;
            CalificacionNegativaOtro = model.CalificacionNegativaOtro;
            CalificacionNegativaOtroObservacion = model.CalificacionNegativaOtroObservacion;
         }

        #endregion

    }
}
