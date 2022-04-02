namespace Solvtio.Models
{
    public class ModelDashboardQa
    {
        #region Constructor

        public ModelDashboardQa()
        {
            CreateBase();
        }
        public ModelDashboardQa(TipoExpedienteEnum tipoExpediente)
        {
            CreateBase();
            Filter.IdTipoExpediente = (int)tipoExpediente;
            Filter.TipoExpedienteSelected = tipoExpediente;
        }
        public ModelDashboardQa(ModelFilterBase filter)
        {
            CreateBase();
            Filter = filter;
            if (Filter.IdTipoExpediente.HasValue)
                Filter.TipoExpedienteSelected = (TipoExpedienteEnum)Filter.IdTipoExpediente.Value;
        }

        private void CreateBase()
        {
            Filter = new ModelFilterBase();
        }

        #endregion

        public ModelFilterBase Filter { get; set; }

        #region Properties Hipotecario

        public int Hip_HipotecasPendientes { get; set; }
        public int Hip_EnEstado1o2 { get; set; }

        public int? HipotecarioPendientePreparacionDemanda { get; set; }
        public int? HipotecarioPendientePresentacionDemanda { get; set; }

        public int Hip_EnTramitacionJuzgadoConCertificacionCargas { get; set; }
        public int Hip_EnTramitacionJuzgadoConCertificacionCargasYRequerimientoPago { get; set; }

        public int HipotecarioPendienteSolicitarSubasta { get; set; }
        public int HipotecarioPendienteConvocatoriaSubasta { get; set; }

        //public int HipotecarioPendienteActaSubasta { get; set; }
        public int HipotecarioPendienteAdjudicacion { get; set; }
        public int HipotecarioPendienteNegociacionPosesion { get; set; }
        public int HipotecarioPendienteTestimonioAdjudicacion { get; set; }
        public int HipotecarioPendienteSolicitudPosesion { get; set; }
        public int? HipotecarioPendienteLanzamiento { get; set; }
        public int HipTestimonioPdteInscripcion { get; set; }

        public int HipotecarioPendienteSuspensionDecreto { get; set; }
        public int HipotecarioPendienteSubastasSuspendidas { get; set; }
        public int HipotecarioPendienteAdjudicacionLey12013 { get; set; }
        public int? HipotecarioCalificacionNegativa { get; set; }
        public int? HipotecarioLiquidacionItp { get; set; }
        public int HipotecarioDecretoConvocatoriaSubasta { get; set; }
        public int HipotecarioPendienteDemandaAdmitida { get; set; }
        public int HipotecarioPendienteCertificacionCargas { get; set; }
        public int HipotecarioPendienteRequerimientoPago { get; set; }
        public int HipotecarioPendienteNotificacion { get; set; }
        public int? HipotecarioIncidenciaDecretoAjdudicacion { get; set; }
        public int HipotecarioJurisdiccionVoluntaria { get; set; }
        public int HipotecarioAutosIncompletoErroneo { get; set; }
        public int? HipotecarioInactivo { get; set; }
        public int HipotecarioIncidenciaDocumental { get; set; }
        public int HipotecarioEnRevisionNoVeniados { get; set; }

        public int HipotecarioEnRevisionVeniados { get; set; }
        //public int Hipotecario { get; set; }
        //public int Hipotecario { get; set; }
        //public int Hipotecario { get; set; }
        //public int Hipotecario { get; set; }

        #endregion

        #region Ejecutivo

        public int? EjecutivoInactivo { get; set; }
        public int? EjecutivoPendientePreparacionDemanda { get; set; }
        public int? EjecutivoPendienteDemandaAdmitida { get; set; }
        public int EjecutivoConOposicion { get; set; }
        public int EjecutivoIncidenciaDocumental { get; set; }
        public int EjecutivoPendienteTestimonioAdjudicacion { get; set; }
        public int EjecutivoPendienteRequerimientoPago { get; set; }
        public int EjecutivoPendienteSolicitarSubasta { get; set; }
        public int EjecutivoPendienteSolicitudPosesion { get; set; }
        public int EjecutivoPendienteLanzamiento { get; set; }
        public int EjecutivoDecretoConvocatoriaSubasta { get; set; }
        public int EjecutivoPendienteSubastasSuspendidas { get; set; }
        public int EjecutivoPendienteAdjudicacion { get; set; }
        public int? EjecutivoProrrogaEmbargo { get; set; }

        public int? EjecutivoPendienteAvaluo { get; set; }
        //public int? Ejecutivo { get; set; }
        //public int? Ejecutivo { get; set; }
        //public int? Ejecutivo { get; set; }
        //public int? Ejecutivo { get; set; }
        //public int? Ejecutivo { get; set; }


        #endregion

        #region Properties Alquiler

        public int AlquilerInactivo { get; set; }
        public int? AlquilerPendienteDemandaAdmitida { get; set; }
        public int AlquilerRecursosApelacion { get; set; }
        public int AlquilerPendienteOficiosEdictos { get; set; }
        public int AlquilerPendienteEjecucionDineraria { get; set; }
        public int AlquilerIncidenciaDocumental { get; set; }
        public int AlquilerPendienteEjecucionLanzamiento { get; set; }
        public int AlquilerPendienteTransferirCantidadConsiganada { get; set; }
        public int AlquilerPendienteExpedienteEjecucion { get; set; }
        public int AlquilerPendienteDemandaEjecucion { get; set; }
        public int AlquilerPendienteSolicitarDecretoFin { get; set; }
        public int AlquilerPendienteMediacion { get; set; }
        public int? AlquilerPendientePreparacion { get; set; }
        public int? AlquilerEnRevision { get; set; }
        public int? AlquilerPendienteInstrucciones { get; set; }
        public int? AlquilerPendienteRevisionEjecutivo { get; set; }
        public int? AlquilerDerivadoConcursal { get; set; }
        public int? AlquilerDecretoFinSinEjecutivo { get; set; }

        #endregion

        #region Properties Negociacion

        public int NegociacionPrecontencioso { get; set; }
        public int NegociacionPrecontenciosoPendienteAsignar { get; set; }

        public int? NegociacionAlquilerPrecontencioso { get; set; }
        public int? NegociacionAlquilerPrecontenciosoPendienteAsignar { get; set; }
        public int? NegociacionAlquilerContencioso { get; set; }
        public int? NegociacionAlquilerContenciosoPendienteAsignar { get; set; }



        public int NegociacionContencioso { get; set; }
        public int? NegociacionContenciosoPendienteAsignar { get; set; }
        public int? NegociacionContenciosoFechaTestimonio { get; set; }

        public int NegociacionTpa { get; set; }
        public int NegociacionTpaPendienteAsignar { get; set; }
        public int NegociacionPrecontenciosoFinalizada { get; set; }
        public int NegociacionContenciosoFinalizada { get; set; }
        #endregion

        #region Properties Ordinario

        public int? OrdinarioInactivo { get; set; }
        public int? OrdinarioIncidenciaDocumental { get; set; }

        public int? OrdinarioPendientePreparacionDemanda { get; set; }
        public int? OrdinarioPendienteDecretoAdmision { get; set; }
        public int? OrdinarioAudienciaPrevia { get; set; }
        public int? OrdinarioJuicio { get; set; }
        public int? OrdinarioSentencia { get; set; }
        public int? OrdinarioRecursoApelacion { get; set; }
        public int? OrdinarioCasacionInfraccionProcesal { get; set; }
        public int? OrdinarioEjecucionSentencia { get; set; }
        public int? OrdinarioPendienteFirmezaSentenciaEstimatoria { get; set; }


        //public int Ordinario { get; set; }
        //public int Ordinario { get; set; }
        //public int Ordinario { get; set; }
        //public int Ordinario { get; set; }

        #endregion

        #region Properties Ordinario Cláusula Suelo

        //public int? OrdinarioCsFacturasBancoPopularHito1 { get; set; }

        #endregion


        #region Properties Monitorio

        public int? MonitorioPdteExpVerbal { get; set; }
        public int? MonitorioPdteExpOrdinario { get; set; }
        public int? MonitorioPdteExpEjecutivo { get; set; }

        #endregion

        #region Real Estate

        public int? RealEstateResidencial { get; set; }
        public int? RealEstateTerciarios { get; set; }
        public int? RealEstateDotacional { get; set; }
        public int? RealEstateSuelos { get; set; }

        public int? RealEstateNpls { get; set; }
        public int? RealEstateReos { get; set; }
        public int? RealEstateConcursos { get; set; }

        #endregion

        #region MultiDivisa

        public int? MultiDivisaPendienteContacto { get; set; }
        public int? MultiDivisaContactoEnNegociacion { get; set; }
        public int? MultiDivisaContactoConAcuerdo { get; set; }
        public int? MultiDivisaFinalizadoConExito { get; set; }
        public int? MultiDivisaFinalizadoLocalizado { get; set; }
        public int? MultiDivisaFinalizadoNoLocalizado { get; set; }
        public int? MultiDivisaFinalizadoExcluido { get; set; }

        #endregion

        #region Properties ReadOnly
        public int Hip_PdteNotificacionCalc
        {
            get
            {
                return Hip_EnTramitacionJuzgadoConCertificacionCargas - Hip_EnTramitacionJuzgadoConCertificacionCargasYRequerimientoPago;
            }
        }
        #endregion
    }
}
