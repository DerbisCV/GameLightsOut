using System;

namespace Solvtio.Models
{
    public partial class Ejc_ExpedienteEstadoAdjudicacion
    {
        #region Properties

        public int IdExpedienteEstado { get; set; }
        public int IdExpediente { get; set; }
        public DateTime? FechaAdjudicacion { get; set; }
        public DateTime? FechaPosesion { get; set; }
        public DateTime? FechaTestimonio { get; set; }
        public DateTime? FechaLanzamiento { get; set; }
        public DateTime? FechaLiquidacionITP { get; set; }
        public DateTime? FechaEntregaLLaves { get; set; }
        public DateTime? FechaInscripcionAdjudicacion { get; set; }
        public bool FormaPacifica { get; set; }
        public bool Defectos { get; set; }
        public bool Inquilinos { get; set; }
        public bool Subsanado { get; set; }
        public bool Ocupantes { get; set; }
        public bool LiquidacionITP { get; set; }
        public bool ContratoAlquiler { get; set; }
        public int? IdDocumentoDecretoAdjudicacion { get; set; }
        public int? IdDocumentoTestimonio { get; set; }
        public int? IdDocumentoITP { get; set; }
        public int? IdDocumentoInscripcion { get; set; }
        public int? IdDocumentoPosesion { get; set; }
        public int? IdDocumentoOcupantes { get; set; }
        public int? IdDocumentoOcupantesVista { get; set; }

        public virtual ExpedienteEstado ExpedienteEstado { get; set; }
        public virtual ExpedienteDocumento ExpedienteDocumentoDecretoAdjudicacion { get; set; }
        public virtual ExpedienteDocumento ExpedienteDocumentoTestimonio { get; set; }
        public virtual ExpedienteDocumento ExpedienteDocumentoITP { get; set; }
        public virtual ExpedienteDocumento ExpedienteDocumentoInscripcion { get; set; }
        public virtual ExpedienteDocumento ExpedienteDocumentoPosesion { get; set; }
        public virtual ExpedienteDocumento ExpedienteDocumentoOcupantesVista { get; set; }
        public virtual ExpedienteDocumento ExpedienteDocumentoOcupantes { get; set; }

        #endregion

        #region Properties New

        public DateTime? ActaArrendaticiaFechaSolicitud { get; set; }
        public DateTime? ActaArrendaticiaFechaRecepcion { get; set; }
        public DateTime? ActaArrendaticiaFechaEnvioProcurador { get; set; }
        public string ActaArrendaticiaReclamacion { get; set; }
        public string ActaArrendaticiaObservaciones { get; set; }

        public DateTime? FechaCertificadoInscripcion { get; set; }
        public string ObservacionesCertificadoInscripcion { get; set; }
        public DateTime? FechaSolicitudPosesion { get; set; }
        public string ObservacionesDocumentacionOriginal { get; set; }
        public bool DocumentacionOriginalRecibida { get; set; }


        public DateTime? InscripcionCreditoFechaSolicitud { get; set; }
        public DateTime? InscripcionCreditoFechaRecepcion { get; set; }
        public DateTime? InscripcionCreditoFechaEnvioProcurador { get; set; }
        public string InscripcionCreditoReclamacion { get; set; }
        public string InscripcionCreditoObservaciones { get; set; }
        public bool InscripcionCreditoReciboOriginal { get; set; }
        public bool InscripcionCreditoReciboCopiaSimple { get; set; }


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

        #endregion

    }
}
