using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("Hip_ExpedienteEstadoTramitacionJuzgado")]
    public class HipExpedienteEstadoTramitacionSubasta : IExpedienteEstadoSubasta
    {
        #region Constructor

        //IdExpediente = model.IdExpediente
        public HipExpedienteEstadoTramitacionSubasta()
        {
            PostSubastaCesion = SubastaCesionType.Pendiente;
        }

        public HipExpedienteEstadoTramitacionSubasta(int idExpediente)
        {
            IdExpediente = idExpediente;
            PostSubastaCesion = SubastaCesionType.Pendiente;
        }

        #endregion

        #region Properties Tramitacion

        public int ExpedienteEstadoId { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public DateTime? FechaCertificacionCargas { get; set; }
        public int? DocumentoCertificacionCargasId { get; set; }

        public bool Oposicion { get; set; }
        public DateTime? OposicionFecha { get; set; }
        public int? OposicionDocumentoId { get; set; }
        public DateTime? OposicionVistaFecha { get; set; }
        public int? OposicionVistaDocumentoId { get; set; }
        public DateTime? OposicionResolucionFecha { get; set; }
        public int? OposicionResolucionDocumentoId { get; set; }

        public DateTime? RequerimientoPagoFecha { get; set; }
        public bool? RequerimientoPagoPositivo { get; set; }
        public int? RequerimientoPagoDocumentoId { get; set; }
        public int? RequerimientoPagoDocumentoSolEdictoId { get; set; }

        public DateTime? AdmitidaFecha { get; set; }
        public string AdmitidaNoAuto { get; set; }
        public DateTime? FechaAutoSubsanado { get; set; }

        public int? AdmitidaDocumentoId { get; set; }
        public DateTime? FechaSolicitudSubasta { get; set; }
        public int? DocumentoSolicitudSubastaId { get; set; }
        public bool Apelacion { get; set; }
        public DateTime? ApelacionFecha { get; set; }
        public DateTime? ApelacionResultadoFecha { get; set; }
        public int? ApelacionPor { get; set; }
        public int? OposicionResultado { get; set; }
        public int? ApelacionResultado { get; set; }
        public decimal? ImporteAdmision { get; set; }

        //public int? IdIncidenciaProcesal { get; set; }
        //[ForeignKey("IdIncidenciaProcesal")]
        //public virtual CaracteristicaBase IncidenciaProcesal { get; set; }

        //public DateTime? IncidenciaProcesalFechaResolucion { get; set; }

        #endregion

        #region Properties IExpedienteEstadoSubasta

        public bool? SubastaElectronicaPuja { get; set; }
        public decimal? SubastaElectronicaImportePuja { get; set; }
        public DateTime? SubastaElectronicaFechaFinMejoraPuja { get; set; }

        #endregion


        #region Properties SubastaElectronica

        public int IdExpediente { get; set; }
        public int? IdAbogadoSubasta { get; set; }

        [ForeignKey("IdAbogadoSubasta")]
        public virtual Gnr_Abogado AbogadoSubasta { get; set; }

        public string ObservacionesSubasta { get; set; }

        public DateTime? SubastaElectronicaFechaDecretoSubasta { get; set; }


        public DateTime? SubastaElectronicaEdictoFecha { get; set; }
        public bool SubastaElectronicaEdictoConDefecto { get; set; }
        public bool SubastaElectronicaEdictoTasaDisponible { get; set; }


        public int? SubastaElectronicaMotivoSuspensionDecretoSubastaId { get; set; }
        public int? SubastaElectronicaMotivoSuspensionId { get; set; }


        public bool SubastaElectronicaSuspensionDecretoSubasta { get; set; }

        public bool SubastaElectronicaFestivoFinDeSemana { get; set; }

        #endregion

        #region Properties PostSubasta

        public DateTime? PostSubastaFechaSolicitudAdjudicacion { get; set; }
        public DateTime? PostSubastaFechaEnvioInstruccionesProcurador { get; set; }
        public DateTime? PostSubastaFechaActaSubasta { get; set; }
        public DateTime? PostSubastaFechaActaSubastaPagoCesionRemate { get; set; }

        public bool PostSubastaIva { get; set; }
        public bool PostSubastaPostores { get; set; }
        public bool PostSubastaAdjudicacionTercero { get; set; }
        public bool PostSubastaImpugnacionIntereses { get; set; }
        public bool PostSubastaImpugnacionCostas { get; set; }

        public decimal? PostSubastaImporteSolicitudAdjudicacion { get; set; }
        public decimal? PostSubastaLiquidacionIntereses { get; set; }
        public decimal? PostSubastaTasacionCostes { get; set; }
        public decimal? PostSubastaDecretoIntereses { get; set; }
        public decimal? PostSubastaDecretoCostas { get; set; }
        public decimal? PostSubastaDecisionPociento { get; set; }
        public decimal? PostSubastaImporteAdjudicacion { get; set; }

        [Display(Name = "Cesión")]
        public SubastaCesionType? PostSubastaCesion { get; set; }

        //public string PostSubastaCesionDescripcion { get; set; }
        //public bool PostSubastaIncidenciaDecretoAdjudicacion { get; set; }
        //public bool PostSubastaConsignar { get; set; }
        //public bool PostSubastaConsignacion { get; set; }

        public int? IdPostSubastaEstadoConsignacion { get; set; }
        public int? IdPostSubastaEstadoIndicenciaDecreto { get; set; }

        #endregion

        #region Properties SubastaOrdinaria

        public DateTime? SubastaOrdinariaFechaCelebracionSubasta1 { get; set; }
        public DateTime? SubastaOrdinariaFechaCelebracionSubasta2 { get; set; }

        public bool SubastaOrdinariaSubastaSuspension1 { get; set; }
        public bool SubastaOrdinariaSubastaSuspension2 { get; set; }

        public string SubastaOrdinariaMotivoSuspension { get; set; }
        public string SubastaOrdinariaAutorizado { get; set; }

        #endregion

        #region Properties Computed

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? SubastaOrdinariaFechaCelebracionSubasta21
        {
            get { return SubastaOrdinariaFechaCelebracionSubasta2 ?? SubastaOrdinariaFechaCelebracionSubasta1; }
            private set { } //Just need this here to trick EF
        }

        #endregion

        #region Properties ReadOnly

        public string OposicionName => GetResultadoName(OposicionResultado);

        public string ApelacionResultadoName => GetResultadoName(ApelacionResultado);

        public int? OposicionResolucionDias => 
            !OposicionFecha.HasValue || !OposicionResolucionFecha.HasValue ? (int?)null :
            OposicionFecha.Value.GetDaysBetweenDates(OposicionResolucionFecha.Value);

        public int? ApelacionResultadoDias =>
            !ApelacionFecha.HasValue || !ApelacionResultadoFecha.HasValue ? (int?)null :
                ApelacionFecha.Value.GetDaysBetweenDates(ApelacionResultadoFecha.Value);

        private string GetResultadoName(int? apelacionResultado)
        {
            return !ApelacionResultado.HasValue ? "" :
                ApelacionResultado == 0 ? "No" :
                ApelacionResultado == 1 ? "Estimatoria" :
                ApelacionResultado == 2 ? "Parcial" :
                ApelacionResultado == 3 ? "Desestimatoria" :
                "¿?";
        }

        #endregion

        #region Methods

        internal void RefreshBy(HipExpedienteEstadoTramitacionSubasta model)
        {
            AdmitidaFecha = model.AdmitidaFecha;
            ImporteAdmision = model.ImporteAdmision;
            FechaCertificacionCargas = model.FechaCertificacionCargas;
            FechaAutoSubsanado = model.FechaAutoSubsanado;
            OposicionResultado = model.OposicionResultado;
            OposicionFecha = model.OposicionFecha;
            OposicionVistaFecha = model.OposicionVistaFecha;
            OposicionResolucionFecha = model.OposicionResolucionFecha;

            Apelacion = model.Apelacion;
            ApelacionFecha = model.ApelacionFecha;
            ApelacionPor = model.ApelacionPor;
            ApelacionResultado = model.ApelacionResultado;
            ApelacionResultadoFecha = model.ApelacionResultadoFecha;

            SubastaElectronicaPuja = model.SubastaElectronicaPuja;
            SubastaElectronicaImportePuja = model.SubastaElectronicaImportePuja;
            SubastaElectronicaFechaFinMejoraPuja = model.SubastaElectronicaFechaFinMejoraPuja;
            PostSubastaFechaSolicitudAdjudicacion = model.PostSubastaFechaSolicitudAdjudicacion;
            PostSubastaImporteSolicitudAdjudicacion = model.PostSubastaImporteSolicitudAdjudicacion;
            PostSubastaIva = model.PostSubastaIva;
            PostSubastaPostores = model.PostSubastaPostores;
            PostSubastaAdjudicacionTercero = model.PostSubastaAdjudicacionTercero;
            PostSubastaLiquidacionIntereses = model.PostSubastaLiquidacionIntereses;
            PostSubastaTasacionCostes = model.PostSubastaTasacionCostes;
            PostSubastaImpugnacionIntereses = model.PostSubastaImpugnacionIntereses;
            PostSubastaImpugnacionCostas = model.PostSubastaImpugnacionCostas;
            PostSubastaDecretoIntereses = model.PostSubastaDecretoIntereses;
            PostSubastaDecretoCostas = model.PostSubastaDecretoCostas;
            PostSubastaDecisionPociento = model.PostSubastaDecisionPociento;
            PostSubastaImporteAdjudicacion = model.PostSubastaImporteAdjudicacion;
            PostSubastaFechaEnvioInstruccionesProcurador = model.PostSubastaFechaEnvioInstruccionesProcurador;
            PostSubastaFechaActaSubasta = model.PostSubastaFechaActaSubasta;
            PostSubastaCesion = model.PostSubastaCesion;
            IdPostSubastaEstadoConsignacion = model.IdPostSubastaEstadoConsignacion;
            IdPostSubastaEstadoIndicenciaDecreto = model.IdPostSubastaEstadoIndicenciaDecreto;
            SubastaOrdinariaFechaCelebracionSubasta1 = model.SubastaOrdinariaFechaCelebracionSubasta1;
            SubastaOrdinariaFechaCelebracionSubasta2 = model.SubastaOrdinariaFechaCelebracionSubasta2;
            SubastaOrdinariaSubastaSuspension1 = model.SubastaOrdinariaSubastaSuspension1;
            SubastaOrdinariaFechaCelebracionSubasta2 = model.SubastaOrdinariaFechaCelebracionSubasta2;
            SubastaOrdinariaFechaCelebracionSubasta1 = model.SubastaOrdinariaFechaCelebracionSubasta1;
            SubastaOrdinariaMotivoSuspension = model.SubastaOrdinariaMotivoSuspension;
            SubastaOrdinariaAutorizado = model.SubastaOrdinariaAutorizado;

            PostSubastaFechaActaSubastaPagoCesionRemate = model.PostSubastaFechaActaSubastaPagoCesionRemate;
        }

        #endregion

    }
}
