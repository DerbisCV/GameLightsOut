using System.ComponentModel;

namespace Solvtio.Models
{

    //public enum TipoIndicadorQa
    //{
    //    #region Hipotecario

    //    #region Hipotecario - Indicadores

    //    [Description("Hipotecario - Pendiente Preparación de Demanda")]
    //    HipotecarioPendientePreparacionDemanda = 101,
    //    //[Description("Hipotecario - Pendiente Auto de Admisión")]
    //    //HipotecarioPendienteAutoAdmision = 102,
    //    [Description("Hipotecario - Pendiente Demanda Admitida")]
    //    HipotecarioPendienteDemandaAdmitida = 102,
    //    [Description("Hipotecario - Pendiente Certificación de Cargas")]
    //    HipotecarioPendienteCertificacionCargas = 103,
    //    [Description("Hipotecario - Pendiente Notificación")]
    //    HipotecarioPendienteNotificacion = 104,
    //    [Description("Hipotecario - Pendiente Solicitar Subasta")]
    //    HipotecarioPendienteSolicitarSubasta = 105,
    //    [Description("Hipotecario - Pendiente Convocatoria Subasta")]
    //    HipotecarioPendienteConvocatoriaSubasta = 106,
    //    [Description("Hipotecario - Pendiente Presentación de Demanda")]
    //    HipotecarioPendientePresentacionDemanda = 107,
    //    [Description("Hipotecario - Pendiente Adjudicación")]
    //    HipotecarioPendienteAdjudicacion = 108,
    //    [Description("Hipotecario - Pendiente Testimonio Adjudicación")]
    //    HipotecarioPendienteTestimonioAdjudicacion = 109,
    //    [Description("Hipotecario - Pendiente Solicitud Posesión")]
    //    HipotecarioPendienteSolicitudPosesion = 110,
    //    [Description("Hipotecario - Pendiente Lanzamiento")]
    //    HipotecarioPendienteLanzamiento = 111,
    //    [Description("Hipotecario - Pendiente Negociación Posesión")]
    //    HipotecarioPendienteNegociacionPosesion = 112,
    //    [Description("Hipotecario - Pendiente Requerimiento de Pago")]
    //    HipotecarioPendienteRequerimientoPago = 113,
    //    [Description("Hipotecario - Testimonios Pendiente Inscripción")]
    //    HipotecarioPendienteTestimoniosInscripcion = 114,
    //    [Description("Hipotecario - Suspensión Decreto")]
    //    HipotecarioPendienteSuspensionDecreto = 115,
    //    [Description("Hipotecario - Subastas Suspendidas")]
    //    HipotecarioPendienteSubastasSuspendidas = 116,
    //    [Description("Hipotecario - Ley 1/2013")]
    //    HipotecarioPendienteAdjudicacionLey12013 = 117,
    //    //[Description("Hipotecario - Notificaciones sin Tramitar")]
    //    //HipotecarioNotificacionesSinTramitar = 118,
    //    [Description("Hipotecario - Decreto Convocatoria Subasta")]
    //    HipotecarioDecretoConvocatoriaSubasta = 119,
    //    [Description("Hipotecario - Incidencias Decretos Ajdudicación")]
    //    HipotecarioIncidenciaDecretoAjdudicacion = 120,
    //    [Description("Hipotecario - Jurisdicción Voluntaria")]
    //    HipotecarioJurisdiccionVoluntaria = 121,
    //    [Description("Hipotecario - Autos Pendientes de Subsanación")]
    //    HipotecarioAutosIncompletoErroneo = 122,
    //    [Description("Hipotecario - Expedientes Inactivos")]
    //    HipotecarioInactivo = 123,
    //    [Description("Hipotecario - Expedientes Incidentados")]
    //    HipotecarioIncidenciaDocumental = 124,
    //    [Description("Hipotecario - Expedientes en Revisión No Veniados")]
    //    HipotecarioEnRevisionNoVeniados = 125,
    //    [Description("Hipotecario - Expedientes en Revisión Veniados")]
    //    HipotecarioEnRevisionVeniados = 126,
    //    [Description("Hipotecario - Calificación Negativa")]
    //    HipotecarioCalificacionNegativa = 127,
    //    [Description("Hipotecario - Liquidación ITP")]
    //    HipotecarioLiquidacionItp = 128,

    //    [Description("Hipotecario - Testimonio Pdte. Inscripción")]
    //    HipTestimonioPdteInscripcion = 129,

    //    #endregion

    //    #region Hipotecario - Alarmas

    //    [Description("Hipotecario - KPI - Expedientes Incidentados")]
    //    HipotecarioAlarmaIncidentados = 161,
    //    [Description("Hipotecario - KPI - Admisión de Demanda")]
    //    HipotecarioAlarmaAdmisionDemanda = 151,
    //    [Description("Hipotecario - KPI - Inadmisión de Demanda")]
    //    HipotecarioAlarmaInadmisionDemanda = 165,
    //    [Description("Hipotecario - KPI - Certificación de Cargas")]
    //    HipotecarioAlarmaCertificacionCargas = 152,
    //    [Description("Hipotecario - KPI - Requerimiento de Pago")]
    //    HipotecarioAlarmaRequerimientoPago = 153,
    //    [Description("Hipotecario - KPI - Solicitud de Subasta")]
    //    HipotecarioAlarmaSolicitudSubasta = 154,
    //    [Description("Hipotecario - KPI - Decreto de Convocatoria")]
    //    HipotecarioAlarmaDecretoConvocatoria = 163,
    //    [Description("Hipotecario - KPI - Decreto de Adjudicación")]
    //    HipotecarioAlarmaDecretoAdjudicacion = 156,
    //    [Description("Hipotecario - KPI - Posesión")]
    //    HipotecarioAlarmaPosesion = 158,
    //    [Description("Hipotecario - KPI - Testimonio Pdte. Inscripción")]
    //    HipotecarioAlarmaTestimonio = 157,
    //    [Description("Hip - KPI - Sucesión Copia Sellada")]
    //    HipotecarioAlarmaSucesionCopiaSellada = 100101,

    //    [Description("SLA - Solic.Cierre - Título ejecutivo")]
    //    HipotecarioAlarmaRecepcionSolicitudCierre01 = 100201,
    //    [Description("SLA - Solic.Cierre - Burofax 1")]
    //    HipotecarioAlarmaRecepcionSolicitudCierre02 = 100202,
    //    [Description("SLA - Solic.Cierre - Liquidación Saldo")]
    //    HipotecarioAlarmaRecepcionSolicitudCierre03 = 100203,
    //    [Description("SLA - Solic.Cierre - Firma Certificado")]
    //    HipotecarioAlarmaRecepcionSolicitudCierre04 = 100204,
    //    [Description("SLA - Solic.Cierre - Burofax 2")]
    //    HipotecarioAlarmaRecepcionSolicitudCierre05 = 100205,




    //    //[Description("Hipotecario - KPI - Convocatoria de Subasta")]
    //    //HipotecarioAlarmaConvocatoriaSubasta = 155,
    //    //[Description("Hipotecario - KPI - Lanzamiento")]
    //    //HipotecarioAlarmaLanzamiento = 159,
    //    //[Description("Hipotecario - KPI - Resolución de Apelación")]
    //    //HipotecarioAlarmaResolucionApelacion = 160,        
    //    //[Description("Hipotecario - KPI - Pdte. Solicitud Adjudicación")]
    //    //HipotecarioAlarmaSolicitudAdjudicacion = 162,        
    //    //[Description("Hipotecario - KPI - Pdte. Recepción de Demanda Sellada")]
    //    //HipotecarioAlarmaRecepcionDemandaSellada = 164,

    //    #endregion

    //    #region Hipotecario - Facturas

    //    [Description("Hito 1 (En prueba)")]
    //    FacturaHito1 = 1,
    //    [Description("Hito 2 (En prueba)")]
    //    FacturaHito2 = 2,
    //    [Description("Hito 3 (En prueba)")]
    //    FacturaHito3 = 3,
    //    [Description("Hito 4 (En prueba)")]
    //    FacturaHito4 = 4,
    //    [Description("Hito 5 (En prueba)")]
    //    FacturaHito5 = 5,
    //    [Description("Hito 6 (En prueba)")]
    //    FacturaHito6 = 6,

    //    //[Description("Alq - Hito 1 (En prueba)")]
    //    //FacturaHito1Alq = 51,
    //    //[Description("Alq - Hito 2 (En prueba)")]
    //    //FacturaHito2Alq = 52,
    //    //[Description("Alq - Hito 3 (En prueba)")]
    //    //FacturaHito3Alq = 53,
    //    //[Description("Alq - Hito 4 (En prueba)")]
    //    //FacturaHito4Alq = 54,
    //    //[Description("Alq - Hito 5 (En prueba)")]
    //    //FacturaHito5Alq = 55,
    //    //[Description("Alq - Hito 6 (En prueba)")]
    //    //FacturaHito6Alq = 56,



    //    [Description("Hip - Factura - Sabadell - Cierre de Subasta")]
    //    HipotecarioFacturaSabadellHito1 = 101001,
    //    [Description("Hip - Factura - Sabadell - Testimonio Inscrito + Posesión")]
    //    HipotecarioFacturaSabadellHito2 = 101002,
    //    [Description("Hip - Factura - Sabadell - Motivos de Finalización")]
    //    HipotecarioFacturaSabadellHito3 = 101003,
    //    [Description("Hip - Factura - Sabadell - Paralizados")]
    //    HipotecarioFacturaSabadellHito4 = 101004,

    //    [Description("Hip - Factura - Solvia - Presentación de Demanda")]
    //    HipotecarioFacturaSolviaHito1 = 102001,
    //    [Description("Hip - Factura - Solvia - Decreto de Adjudicación")]
    //    HipotecarioFacturaSolviaHito2 = 102002,
    //    [Description("Hip - Factura - Solvia - Fecha Toma Posesión ")]
    //    HipotecarioFacturaSolviaHito3 = 102003,
    //    [Description("Hip - Factura - Solvia - Otros")]
    //    HipotecarioFacturaSolviaHito4 = 102004,

    //    [Description("Hip - Factura - Anticipa - Decreto de Adjudicación")]
    //    HipotecarioFacturaAnticipaHito1 = 103001,
    //    [Description("Hip - Factura - Anticipa - Testimonio Inscrito + Posesión")]
    //    HipotecarioFacturaAnticipaHito2 = 103002,
    //    [Description("Hip - Factura - Anticipa - Otros")]
    //    HipotecarioFacturaAnticipaHito3 = 103003,

    //    [Description("Hip - Factura - Sareb - Testimonio Inscrito + Posesión")]
    //    HipotecarioFacturaSarebHito1 = 104001,
    //    [Description("Hip - Factura - Sareb - Finalización")]
    //    HipotecarioFacturaSarebHito2 = 104002,
    //    [Description("Hip - Factura - Sareb - Otros")]
    //    HipotecarioFacturaSarebHito3 = 104003,

    //    [Description("Hip - Factura - Post-Ejc - Finalización")]
    //    HipotecarioFacturaPostEjcHito1 = 105001,

    //    [Description("Hip - Factura - Bankia - Cierre de Subasta")]
    //    HipotecarioFacturaBankiaHito1 = 106001,
    //    [Description("Hip - Factura - Bankia - Testimonio Inscrito + Posesión")]
    //    HipotecarioFacturaBankiaHito2a = 106002,
    //    [Description("Hip - Factura - Bankia - Finalización")]
    //    HipotecarioFacturaBankiaHito2b = 106003,

    //    [Description("Hip - Fact - Aliseda No Veniado - Decreto Adjudicación")]
    //    HipotecarioFacturaAlisedaNoVeniadoHito1 = 107001,
    //    [Description("Hip - Fact - Aliseda No Veniado - Testimonio Inscrito + Posesión")]
    //    HipotecarioFacturaAlisedaNoVeniadoHito2 = 107002,
    //    [Description("Hip - Fact - Aliseda No Veniado - Finalizados Pdte. Facturar")]
    //    HipotecarioFacturaAlisedaNoVeniadoFinalizadosPdteFacturar = 107003,

    //    [Description("Hip - Fact - Aliseda Veniado - Carga Cliente")]
    //    HipotecarioFacturaAlisedaVeniadoHito1 = 107011,
    //    [Description("Hip - Fact - Aliseda Veniado - Testimonio Inscrito + Posesión")]
    //    HipotecarioFacturaAlisedaVeniadoHito2 = 107012,
    //    [Description("Hip - Fact - Aliseda Veniado - Finalizados Pdte. Facturar")]
    //    HipotecarioFacturaAlisedaVeniadoFinalizadosPdteFacturar = 107013,

    //    [Description("Hip - Factura - Abanca - Testimonio de Adjudicación")]
    //    HipotecarioFacturaAbancaHito1 = 108001,
    //    [Description("Hip - Factura - Abanca - Testimonio Inscrito + Posesión")]
    //    HipotecarioFacturaAbancaHito2 = 108002,
    //    [Description("Hip - Factura - Abanca - Finalización")]
    //    HipotecarioFacturaAbancaHito3 = 108003,


    //    [Description("Hip - Fact - Voyager-Altamira No Veniado - Presentación Demanda")]
    //    HipotecarioFacturaVoyagerAltamiraNoVeniadoHito1 = 109001,
    //    [Description("Hip - Fact - VoyagerAltamira No Veniado - Cierre Subasta")]
    //    HipotecarioFacturaVoyagerAltamiraNoVeniadoHito2 = 109002,
    //    [Description("Hip - Fact - VoyagerAltamira No Veniado - Finalización")]
    //    HipotecarioFacturaVoyagerAltamiraNoVeniadoHitoFinalizacion = 109003,

    //    [Description("Hip - Fact - VoyagerAltamira Veniado - Cierre Subasta")]
    //    HipotecarioFacturaVoyagerAltamiraVeniadoHito1 = 109011,
    //    //[Description("Hip - Fact - VoyagerAltamira Veniado - Testimonio Inscrito + Posesión")]
    //    //HipotecarioFacturaVoyagerAltamiraVeniadoHito2 = 109012,
    //    [Description("Hip - Fact - VoyagerAltamira Veniado - Finalización")]
    //    HipotecarioFacturaVoyagerAltamiraVeniadoHitoFinalizacion = 109013,


    //    [Description("Hip - Finalizado Sin Factura")]
    //    HipotecarioFinalizadoSinFactura = 108088,
    //    [Description("Alq - Finalizado Sin Factura")]
    //    AlquilerFinalizadoSinFactura = 508088,
    //    [Description("Ord - Finalizado Sin Factura")]
    //    OrdinarioFinalizadoSinFactura = 148088,
    //    [Description("Ejc - Finalizado Sin Factura")]
    //    EjecutivoFinalizadoSinFactura = 308088,

    //    #endregion

    //    #region Hipotecario - SLA

    //    HipotecarioSlaPresentacionDemandaBankia = 101502,

    //    #endregion

    //    #region Hipotecario - QaDatos

    //    [Description("Hipotecario - Expedientes sin inmuebles")]
    //    ExpHipQaDatosSinInmueble = 1010801,
    //    [Description("Hipotecario - Expedientes sin fecha de demanda")]
    //    ExpHipQaDatosSinFechaDemanda = 1010802,
    //    [Description("Hipotecario - Expedientes sin partido judicial")]
    //    ExpHipQaDatosSinPartidoJudicial = 1010803,
    //    [Description("Hipotecario - Expedientes sin No.Auto")]
    //    ExpHipQaDatosSinNoAuto = 1010804,

    //    [Description("Hipotecario - Expedientes sin juzgado")]
    //    ExpHipQaDatosSinJuzgado = 1010805,
    //    [Description("Hipotecario - Expedientes sin Demanda Admitida")]
    //    ExpHipQaDatosSinDemandaAdmitida = 1010806,
    //    [Description("Hipotecario - Expedientes Adjudicación Incompletos")]
    //    ExpHipQaDatosAdjudicacionIncompletos = 1010807,

    //    #endregion

    //    #endregion

    //    #region Alquiler

    //    #region Alquiler - Indicadores

    //    [Description("Alquiler - Pendiente Presentación Demanda")]
    //    AlquilerPendientePresentacionDemanda = 501,
    //    [Description("Alquiler - Pendiente Demanda Admitida")]
    //    AlquilerPendienteDemandaAdmitida = 502,
    //    [Description("Alquiler - Recursos de Apelación")]
    //    AlquilerRecursosApelacion = 503, //
    //    [Description("Alquiler - Ejecución Dineraria")]
    //    AlquilerPendienteEjecucionDineraria = 504,
    //    [Description("Alquiler - Pendiente Ejecución Lanzamiento")]
    //    AlquilerPendienteEjecucionLanzamiento = 505,
    //    [Description("Alquiler - Pendiente Transferir Cantidad Consiganada")]
    //    AlquilerPendienteTransferirCantidadConsiganada = 506,
    //    [Description("Alquiler - Pendiente Expediente Ejecución")]
    //    AlquilerPendienteExpedienteEjecucion = 507,
    //    [Description("Alquiler - Pendiente Demanda Ejecución")]
    //    AlquilerPendienteDemandaEjecucion = 508,
    //    [Description("Alquiler - Pdte. Solicitar Decreto Fin")]
    //    AlquilerPendienteSolicitarDecretoFin = 509,
    //    [Description("Alquiler - Pendiente Mediación")]
    //    AlquilerPendienteMediacion = 510,
    //    [Description("Alquiler - Pendiente Preparación Demanda")]
    //    AlquilerPendientePreparacion = 511,

    //    [Description("Alquiler - Expedientes Inactivos")]
    //    AlquilerInactivo = 512,

    //    [Description("Alquiler - Facturas Pendientes")]
    //    AlquilerFacturasPendientes = 513,
    //    [Description("Alquiler - Expedientes Incidentados")]
    //    AlquilerIncidenciaDocumental = 514,
    //    [Description("Alquiler - Pdte. Oficios/Edictos")]
    //    AlquilerPendienteOficiosEdictos = 515,
    //    [Description("Alquiler - Expedientes en Revisión")]
    //    AlquilerEnRevision = 516,
    //    [Description("Alquiler - Pendiente Instrucciones")]
    //    AlquilerPendienteInstrucciones = 517,
    //    [Description("Alquiler - Pte. Revisión Ejecutivo")]
    //    AlquilerPendienteRevisionEjecutivo = 518,
    //    [Description("Alquiler - Derivado a Concursal")]
    //    AlquilerDerivadoConcursal = 519,

    //    [Description("Alquiler - Decreto Fin Sin Exp. Ejec.")]
    //    AlquilerDecretoFinSinEjecutivo = 520,

    //    #endregion

    //    #region Alquiler - Alarmas

    //    [Description("Alquiler - KPI - Presentación de Demanda")]
    //    AlquilerAlarmaPresentacionDemanda = 551,
    //    [Description("Alquiler - KPI - Demanda Admitida")]
    //    AlquilerAlarmaDemandaAdmitida = 552,
    //    [Description("Alquiler - KPI - Pdte. de Notificación")]
    //    AlquilerAlarmaPendienteNotificacion = 553,
    //    [Description("Alquiler - KPI - Pdte. Decreto de Fin")]
    //    AlquilerAlarmaPendienteDecretoFin = 554,
    //    [Description("Alquiler - KPI - Pdte. Toma de Posesión")]
    //    AlquilerAlarmaPendienteTomaPosesion = 555,
    //    [Description("Alquiler - KPI - Pdte. Enervación")]
    //    AlquilerAlarmaPendienteEnervacion = 556,
    //    [Description("Alquiler - KPI - Pdte. Recepción de Demanda Sellada")]
    //    AlquilerAlarmaRecepcionDemandaSellada = 557,
    //    [Description("Alquiler - KPI - Pdte. AJG")]
    //    AlquilerAlarmaPendienteAjg = 558,
    //    [Description("Alquiler - KPI - Pdte. Acuerdo")]
    //    AlquilerAlarmaPendienteAcuerdo = 559,
    //    [Description("Alquiler - KPI - Pdte. Instrucciones Cliente")]
    //    AlquilerAlarmaPendienteInstruccionesCliente = 560,

    //    [Description("Alquiler - KPI - Pdte. Resolución Incidencia")]
    //    AlquilerAlarmaPdteFechaResolucionIncidencia = 561,
    //    [Description("Alquiler - KPI - Ejecutar Decreto Fin y Sentencia")]
    //    AlquilerAlarmaEjecutarDecretoFinSentencia = 562,

    //    [Description("Alquiler - KPI - Impulso Pdte. Aplc. Cliente")]
    //    AlquilerAlarmaImpulsoPendienteAplicativoCliente = 5050,

    //    [Description("Alquiler - KPI - Pdte. Recepción de Demanda (Ord)")]
    //    AlquilerAlarmaRecepcionDemandaSelladaOrd = 5051,
    //    [Description("Alquiler - KPI - Pdte. Recepción de Demanda (Ejc)")]
    //    AlquilerAlarmaRecepcionDemandaSelladaEjc = 5052,
    //    [Description("Alquiler - KPI - Pdte. Recepción de Demanda (MN)")]
    //    AlquilerAlarmaRecepcionDemandaSelladaMn = 5053,
    //    [Description("Alquiler - KPI - Pdte. Recepción de Denuncia")]
    //    AlquilerAlarmaRecepcionDenuncia = 5054,

    //    #endregion

    //    #region Alquiler - Facturas

    //    [Description("Alq - Factura - Hito Presentación Demanda")]
    //    AlquilerFacturasHito1 = 50301,
    //    [Description("Alq - Factura - Hito Finalizado")]
    //    AlquilerFacturasHito2 = 50302,

    //    [Description("Alq - Factura - Altamira H1")] //Hitos de Altamira Santander un solo hito a la finalización por posesión o por Enervación Judicial o por Sentencia estimatoria (crear este check en finalización de alquileres que no está)
    //    AlquilerFacturaAltamiraHito1 = 501001,
    //    [Description("Ejc - Factura - Altamira H1")]
    //    AlquilerFacturaEjcAltamiraHito1 = 501006,
    //    //[Description("Alq - Factura - Luri 4 H1")]
    //    //AlquilerFacturaLuri4Hito1 = 502004,
    //    //[Description("Alq - Factura - Luri 6 H1")]
    //    //AlquilerFacturaLuri6Hito1 = 502005,
    //    //[Description("Ejc - Factura - Luri 4 H1")]
    //    //AlquilerFacturaEjcLuri4Hito1 = 502007,
    //    //[Description("Ejc - Factura - Luri 6 H1")]
    //    //AlquilerFacturaEjcLuri6Hito1 = 502008,
    //    //[Description("Alq - Factura - Pdte Altamira/Luri")]
    //    //AlquilerFacturaPdteAltamiraLuri46 = 502009,

    //    #region Llogatalia

    //    [Description("Alq - Factura - Llogatalia H1")]
    //    AlquilerFacturaLlogataliaHito1 = 502001,
    //    [Description("Alq - Factura - Llogatalia H2")]
    //    AlquilerFacturaLlogataliaHito2 = 502010,
    //    [Description("Ejc - Factura - Llogatalia H1")]
    //    AlquilerFacturaEjcLlogataliaHito1 = 502011,
    //    [Description("Alq - Factura - Pdte Llogatalia")]
    //    AlquilerFacturaPdteLlogatalia = 502012,

    //    #endregion

    //    #region Aliseda

    //    [Description("Alq - Factura - Aliseda H1")]
    //    AlquilerFacturaAlisedaHito1 = 502013,
    //    [Description("Alq - Factura - Aliseda H2")]
    //    AlquilerFacturaAlisedaHito2 = 502014,
    //    [Description("Ejc - Factura - Aliseda H1")]
    //    AlquilerFacturaEjcAlisedaHito1 = 502015,
    //    [Description("Alq - Factura - Pdte Aliseda")]
    //    AlquilerFacturaPdteAliseda = 502016,

    //    #endregion

    //    #region Fidere

    //    [Description("Alq - Factura - Fidere H1")]
    //    AlquilerFacturaFidereHito1 = 502017,
    //    [Description("Alq - Factura - Fidere H2")]
    //    AlquilerFacturaFidereHito2 = 502018,
    //    [Description("Ejc - Factura - Fidere H1")]
    //    AlquilerFacturaEjcFidereHito1 = 502019,
    //    [Description("Alq - Factura - Pdte Fidere")]
    //    AlquilerFacturaPdteFidere = 502020,

    //    #endregion

    //    #region MerlinRetail

    //    [Description("Alq - Factura - Merlin Retail H1")]
    //    AlquilerFacturaMerlinRetailHito1 = 502021,
    //    [Description("Alq - Factura - Merlin Retail H2")]
    //    AlquilerFacturaMerlinRetailHito2 = 502022,
    //    [Description("Ejc - Factura - Merlin Retail H1")]
    //    AlquilerFacturaEjcMerlinRetailHito1 = 502023,
    //    [Description("Alq - Factura - Pdte Merlin Retail")]
    //    AlquilerFacturaPdteMerlinRetail = 502024,

    //    #endregion

    //    #region Solvia Hoteles

    //    [Description("Alq - Factura - Solvia Hoteles H1")]
    //    AlquilerFacturaSolviaHotelesHito1,
    //    [Description("Alq - Factura - Solvia Hoteles H2")]
    //    AlquilerFacturaSolviaHotelesHito2,
    //    [Description("Ejc - Factura - Solvia Hoteles H1")]
    //    AlquilerFacturaEjcSolviaHotelesHito1,
    //    [Description("Alq - Factura - Pdte Solvia Hoteles")]
    //    AlquilerFacturaPdteSolviaHoteles,

    //    #endregion

    //    #region Azzam / Homes

    //    [Description("Alq - Factura - Azzam H1")]
    //    AlquilerFacturaAzzamHito1,
    //    [Description("Alq - Factura - Azzam H2")]
    //    AlquilerFacturaAzzamHito2,
    //    [Description("Ejc - Factura - Azzam H1")]
    //    AlquilerFacturaEjcAzzamHito1,


    //    [Description("Alq - Factura - Homes H1")]
    //    AlquilerFacturaHomesHito1,
    //    [Description("Alq - Factura - Homes H2")]
    //    AlquilerFacturaHomesHito2,
    //    [Description("Ejc - Factura - Homes H1")]
    //    AlquilerFacturaEjcHomesHito1,

    //    #endregion

    //    #region Anticipa

    //    [Description("Alq - Factura - Anticipa H1")]
    //    AlquilerFacturaAnticipaHito1,
    //    [Description("Alq - Factura - Anticipa H2")]
    //    AlquilerFacturaAnticipaHito2,
    //    [Description("Ejc - Factura - Anticipa H1")]
    //    AlquilerFacturaEjcAnticipaHito1,

    //    #endregion

    //    #region Ahora Asset Management

    //    [Description("Alq - Factura - Ahora AM H1")]
    //    AlquilerFacturaAhoraAssetManagementHito1,
    //    [Description("Alq - Factura - Ahora AM H2")]
    //    AlquilerFacturaAhoraAssetManagementHito2,

    //    #endregion

    //    #endregion

    //    #endregion

    //    #region Concursal (ReI, MyC)

    //    #region Concursal - Indicadores

    //    #endregion

    //    #region Concursal - Alarmas

    //    [Description("MyC - KPI - Hito 1 Pdte. Facturar")]
    //    ConcursoAlarmaCumplidoHito01 = 40051,

    //    [Description("MyC - KPI - Hito 57 Pdte. Facturar")]
    //    ConcursoAlarmaCumplidoHito57 = 40052,

    //    [Description("MyC - KPI - Hito 14 Facturar (18 meses)")]
    //    ConcursoAlarmaCumplidoHito14_18 = 40053,
    //    [Description("MyC - KPI - Hito 14 Facturar (48 meses)")]
    //    ConcursoAlarmaCumplidoHito14_48 = 40054,

    //    [Description("MyC - KPI - Hito 73 Pdte. Facturar")]
    //    ConcursoAlarmaCumplidoHito73 = 40055,

    //    [Description("MyC - KPI - Hito 74 Pdte. Facturar")]
    //    ConcursoAlarmaCumplidoHito74 = 40056,

    //    [Description("MyC - KPI - ¿Procede facturación parte fija? (Hito 01)")]
    //    ConcursoAlarmaProcedeFacturacion_01 = 40057,
    //    [Description("MyC - KPI - ¿Procede facturación parte fija? (Hito 57)")]
    //    ConcursoAlarmaProcedeFacturacion_57 = 40058,
    //    [Description("MyC - KPI - ¿Procede facturación parte fija? (Hito 14: 18 meses)")]
    //    ConcursoAlarmaProcedeFacturacion_14_18m = 40059,
    //    [Description("MyC - KPI - ¿Procede facturación parte fija? (Hito 14: 48 meses)")]
    //    ConcursoAlarmaProcedeFacturacion_14_48m = 40060,
    //    [Description("MyC - KPI - ¿Procede facturación parte fija? (Hito 74)")]
    //    ConcursoAlarmaProcedeFacturacion_74 = 40061,
    //    [Description("MyC - KPI - ¿Procede facturación parte fija? (Hito 78)")]
    //    ConcursoAlarmaProcedeFacturacion_78 = 40062,
    //    [Description("MyC - KPI - ¿Procede facturación parte fija? (Hito 79)")]
    //    ConcursoAlarmaProcedeFacturacion_79 = 40063,

    //    [Description("MyC - KPI - Facturación Hito 73")]
    //    ConcursoAlarmaProcedeFacturacion_73 = 40064,
    //    [Description("MyC - KPI - Facturación Hito 52")]
    //    ConcursoAlarmaProcedeFacturacion_52 = 40065,
    //    [Description("MyC - KPI - Facturación Hito 54")]
    //    ConcursoAlarmaProcedeFacturacion_54 = 40066,
    //    [Description("MyC - KPI - Facturación Hito 55")]
    //    ConcursoAlarmaProcedeFacturacion_55 = 40067,
    //    [Description("MyC - KPI - Facturación Hito 56")]
    //    ConcursoAlarmaProcedeFacturacion_56 = 40068,
    //    [Description("MyC - KPI - Facturación Hito 63")]
    //    ConcursoAlarmaProcedeFacturacion_63 = 40069,
    //    [Description("MyC - KPI - Facturación Hito 64")]
    //    ConcursoAlarmaProcedeFacturacion_64 = 40070,

    //    #endregion

    //    #region Concursal - Facturas

    //    //[Description("MyC - Facturas Pendientes Hito 1")]
    //    //JcFacturasPendientesHito1 = 24011,
    //    //[Description("MyC - Facturas Sin H1 y con H2")]
    //    //JcFacturasPendientesHito1ConHito2 = 24012,

    //    [Description("MyC - Facturas Pendientes Hito Fin")]
    //    MyCFacturasPendientesHito1 = 40001,

    //    [Description("MyC - Facturas Abanca Hito 52")]
    //    MyCFacturasAbanca52 = 404152,

    //    #endregion

    //    #endregion

    //    #region Ejecutivo

    //    #region Ejecutivo - Indicadores

    //    [Description("Ejecutivo - Pdte. Preparación Demanda")]
    //    EjecutivoPendientePreparacionDemanda = 301,
    //    [Description("Ejecutivo - Pdte. Demanda Admitida")]
    //    EjecutivoPendienteDemandaAdmitida = 302,
    //    [Description("Ejecutivo - Con Oposición")]
    //    EjecutivoConOposicion = 303,
    //    [Description("Ejecutivo - Expedientes Incidentados")]
    //    EjecutivoIncidenciaDocumental = 304,
    //    [Description("Ejecutivo - Expedientes Inactivos")]
    //    EjecutivoInactivo = 305,
    //    //[Description("Hipotecario - Pdte. Demanda Admitida")]
    //    //EjecutivoPendienteDemandaAdmitida = 102,

    //    //[Description("Ejecutivo - Pdte. Notificación")]
    //    //EjecutivoPendienteNotificacion = 304,
    //    [Description("Ejecutivo - Pdte. Solicitar Subasta")]
    //    EjecutivoPendienteSolicitarSubasta = 308,
    //    //[Description("Ejecutivo - Pdte. Convocatoria Subasta")]
    //    //EjecutivoPendienteConvocatoriaSubasta = 306,
    //    //[Description("Ejecutivo - Pdte. Acta de Subasta")]
    //    //EjecutivoPendienteActaSubasta = 307,
    //    [Description("Ejecutivo - Pdte. Adjudicación")]
    //    EjecutivoPendienteAdjudicacion = 331,
    //    [Description("Ejecutivo - Pdte. Testimonio Adjudicación")]
    //    EjecutivoPendienteTestimonioAdjudicacion = 309,
    //    [Description("Ejecutivo - Pdte. Solicitud Posesión")]
    //    EjecutivoPendienteSolicitudPosesion = 310,
    //    [Description("Ejecutivo - Pdte. Lanzamiento")]
    //    EjecutivoPendienteLanzamiento = 311,
    //    //[Description("Ejecutivo - Pdte. Negociación Posesión")]
    //    //EjecutivoPendienteNegociacionPosesion = 312,
    //    [Description("Ejecutivo - Pdte. Requerimiento de Pago")]
    //    EjecutivoPendienteRequerimientoPago = 313,
    //    //[Description("Ejecutivo - Testimonios Pendiente Inscripción")]
    //    //EjecutivoPendienteTestimoniosInscripcion = 314,
    //    //[Description("Ejecutivo - Suspensión Decreto")]
    //    //EjecutivoPendienteSuspensionDecreto = 315,
    //    [Description("Ejecutivo - Subastas Suspendidas")]
    //    EjecutivoPendienteSubastasSuspendidas = 316,

    //    //[Description("Ejecutivo - Ley 1/2013")]
    //    //EjecutivoPendienteAdjudicacionLey12013 = 317,
    //    //[Description("Ejecutivo - Notificaciones sin Tramitar")]
    //    //EjecutivoNotificacionesSinTramitar = 318,
    //    [Description("Ejecutivo - Decreto Convocatoria Subasta")]
    //    EjecutivoDecretoConvocatoriaSubasta = 319,

    //    //[Description("Ejecutivo - Incidencias Decretos Ajdudicación")]
    //    //EjecutivoIncidenciaDecretoAjdudicacion = 320,
    //    //[Description("Ejecutivo - Jurisdicción Voluntaria")]
    //    //EjecutivoJurisdiccionVoluntaria = 321,
    //    //[Description("Ejecutivo - Autos Pendientes de Subsanación")]
    //    //EjecutivoAutosIncompletoErroneo = 322,
    //    //[Description("Ejecutivo - Expedientes Inactivos")]
    //    //EjecutivoInactivo = 323,
    //    //[Description("Ejecutivo - Expedientes Incidentados")]
    //    //EjecutivoIncidenciaDocumental = 324,
    //    //[Description("Ejecutivo - Expedientes en Revisión No Veniados")]
    //    //EjecutivoEnRevisionNoVeniados = 325,

    //    [Description("Ejecutivo - Prórroga de embargo")]
    //    EjecutivoProrrogaEmbargo = 341,

    //    [Description("Ejecutivo - Pendiente de Avalúo")]
    //    EjecutivoPendienteAvaluo = 342,

    //    #endregion

    //    #region Ejecutivo - Alarmas

    //    [Description("Ejecutivo - KPI - Pdte. Recepción de Demanda Sellada")]
    //    EjecutivoAlarmaRecepcionDemandaSellada = 351,
    //    [Description("Ejecutivo - KPI - Admisión Demanda")]
    //    EjecutivoAlarmaAdmisionDemanda = 352,

    //    //[Description("Ejecutivo - KPI - Pdte. Recepción de Demanda Sellada")]
    //    //EjecutivoAlarmaRecepcionDemandaSellada = 354,

    //    [Description("Ejecutivo - KPI - Requerimiento de Pago")]
    //    EjecutivoAlarmaRequerimientoPago = 355,
    //    [Description("Ejecutivo - KPI - Averiguación Patrimonial")]
    //    EjecutivoAlarmaAveriguacionPatrimonial = 356,
    //    [Description("Ejecutivo - KPI - Mejora de Embargo")]
    //    EjecutivoAlarmaMejoraEmbargo = 357,
    //    [Description("Ejecutivo - KPI - Decreto de Embargo")]
    //    EjecutivoAlarmaDecretoEmbargo = 358,

    //    [Description("Ejecutivo - KPI - Prórroga de embargo")]
    //    EjecutivoAlarmaProrrogaEmbargo = 359,

    //    [Description("Ejc - KPI - Sucesión Copia Sellada")]
    //    EjecutivoAlarmaSucesionCopiaSellada = 360,

    //    #endregion

    //    #endregion

    //    #region Negociacion - Indicadores (13)

    //    [Description("TPA Pendiente Asignar")]
    //    NegociacionTpaPendienteAsignar = 1301,
    //    [Description("TPA")]
    //    NegociacionTpa = 1302,

    //    TpaFallidas = 1303,
    //    PropuestaAceptada = 1304,
    //    PropuestaDenegada = 1305,
    //    PagoDeuda = 1306,
    //    EntregaInmueble = 1307,
    //    Inviables = 1308,
    //    Ilocalizable = 1309,

    //    [Description("Alquiler Precontencioso")]
    //    NegociacionAlquilerPrecontencioso = 1333,
    //    [Description("Alquiler Precontencioso Pendiente Asignar")]
    //    NegociacionAlquilerPrecontenciosoPendienteAsignar = 1323,

    //    [Description("Precontencioso")]
    //    NegociacionPrecontencioso = 1331,
    //    [Description("Precontencioso Pendiente Asignar")]
    //    NegociacionPrecontenciosoPendienteAsignar = 1321,

    //    [Description("Contencioso")]
    //    NegociacionContencioso = 1332,
    //    [Description("Contencioso Pendiente Asignar")]
    //    NegociacionContenciosoPendienteAsignar = 1322,
    //    [Description("Contencioso con F. Testimonio")]
    //    NegociacionContenciosoFechaTestimonio = 1338,

    //    [Description("Precontencioso Finalizado")]
    //    NegociacionPrecontenciosoFinalizada = 1334,
    //    [Description("Contencioso Finalizado")]
    //    NegociacionContenciosoFinalizada = 1335,

    //    [Description("Alquiler Contencioso")]
    //    NegociacionAlquilerContencioso = 1336,
    //    [Description("Alquiler Contencioso Pendiente Asignar")]
    //    NegociacionAlquilerContenciosoPendienteAsignar = 1337,

    //    #endregion

    //    #region Negociacion - Alarmas

    //    [Description("Negociación - KPI - Expirado Tiempo Negociación de Alquiler")]
    //    NegociacionAlarmaExpiradoTiempoNegAlquiler = 1351,
    //    [Description("Negociación - KPI - Expirado Tiempo Negociación Precontencioso")]
    //    NegociacionAlarmaExpiradoTiempoNegPrecontencioso = 1352,


    //    #endregion

    //    #region Ordinario

    //    #region Ordinario - Indicadores

    //    [Description("Ordinario - Expedientes Inactivos")]
    //    OrdinarioInactivo = 1401,
    //    [Description("Ordinario - Expedientes Incidentados")]
    //    OrdinarioIncidenciaDocumental = 1424,
    //    [Description("Ordinario - Pdte. Preparación Demanda")]
    //    OrdinarioPendientePreparacionDemanda = 1403,
    //    [Description("Ordinario - Pdte. Decreto de Admisión")]
    //    OrdinarioPendienteDecretoAdmision = 1404,
    //    [Description("Ordinario - Audiencia Previa")]
    //    OrdinarioAudienciaPrevia = 1405,
    //    [Description("Ordinario - Juicio")]
    //    OrdinarioJuicio = 1406,
    //    [Description("Ordinario - Sentencia")]
    //    OrdinarioSentencia = 1407,
    //    [Description("Ordinario - Recursos de Apelación")]
    //    OrdinarioRecursoApelacion = 1408,
    //    [Description("Ordinario - Casación por Infracción Procesal")]
    //    OrdinarioCasacionInfraccionProcesal = 1409,
    //    [Description("Ordinario - Ejecución Sentencia")]
    //    OrdinarioEjecucionSentencia = 1410,
    //    [Description("Ordinario - Pdte. Firmeza Sent. Estimatoria")]
    //    OrdinarioPendienteFirmezaSentenciaEstimatoria = 1411,

    //    #endregion

    //    #region Ordinario - Alarmas

    //    [Description("Ord- KPI - Pendiante Demanda")]
    //    OrdinarioAlarmaPdteDemanda = 1451,
    //    [Description("Ord- KPI - Decreto Admisión")]
    //    OrdinarioAlarmaDecretoAdmision = 1452,
    //    [Description("Ord- KPI - Emplazamiento Positivo")]
    //    OrdinarioAlarmaEmplazamientoPositivo = 1453,
    //    [Description("Ord- KPI - Emplazamiento Negativo / Rebeldia")]
    //    OrdinarioAlarmaEmplazamientoNegativo = 1454,
    //    [Description("Ord- KPI - Audiencia Previa")]
    //    OrdinarioAlarmaAudienciaPrevia = 1455,
    //    [Description("Ord- KPI - Juicio")]
    //    OrdinarioAlarmaJuicio = 1456,
    //    [Description("Ord- KPI - Sentencia")]
    //    OrdinarioAlarmaSentencia = 1457,
    //    [Description("Ord- KPI - Pdte. Sentencia")]
    //    OrdinarioAlarmaPdteSentencia = 1458,
    //    [Description("Ord- KPI - Pdte. Recepción de Demanda Sellada")]
    //    OrdinarioAlarmaRecepcionDemandaSellada = 1459,


    //    [Description("Ord - KPI - Sucesión Copia Sellada")]
    //    OrdinarioAlarmaSucesionCopiaSellada = 1460,



    //    #endregion

    //    #region Ordinario - Facturas

    //    [Description("Ord - Factura - Hito 1 (Caixa)")]
    //    OrdinarioFacturasHito1Caixa = 1430101,

    //    #endregion

    //    #endregion

    //    #region OrdinarioCs

    //    #region OrdinarioCs - Indicadores / Facturas

    //    [Description("Cláusula Suelo - Facturas Banco Popular Hito 1")]
    //    OrdinarioCsFacturasBancoPopularHito1 = 150131,
    //    [Description("Cláusula Suelo - Facturas Banco Popular Hito 2")]
    //    OrdinarioCsFacturasBancoPopularHito2 = 150132,
    //    [Description("Cláusula Suelo - Facturas Hito 2 (Pendiente Finalizar)")]
    //    OrdinarioCsFacturasHito2PendienteFinalizar = 150133,

    //    #endregion

    //    #region OrdinarioCs - Alarmas

    //    [Description("Cláusula Suelo - KPI - Vencimiento Allanamiento")]
    //    OrdinarioCsAlarmaVencimientoAllanamiento = 1551,

    //    [Description("Cláusula Suelo - KPI - Pdte. Copia Sellada Allanamiento")]
    //    OrdinarioCsAlarmaPendienteCopiaSelladaAllanamiento = 1556,
    //    [Description("Cláusula Suelo - KPI - Sentencia")]
    //    OrdinarioCsAlarmaSentencia = 1557,
    //    [Description("Cláusula Suelo - KPI - Costas No Abonadas")]
    //    OrdinarioCsAlarmaSentenciaSinCostasAbonadas = 1558,


    //    [Description("Cláusula Suelo - KPI - Pendiente Finalización")]
    //    OrdinarioCsAlarmaPendienteFinalizacion = 1592,

    //    #endregion


    //    #region JV - Alarmas 

    //    [Description("JV - KPI - Pendiente Admisión")]
    //    JvAlarmaPdteAdmision = 1751,
    //    [Description("JV - KPI - Pendiente Notificación")]
    //    JvAlarmaPdteNotificacion = 1752,
    //    [Description("JV - KPI - Librado Mandamiento")]
    //    JvAlarmaPdteLibradoMandamiento = 1753,
    //    [Description("JV - KPI - Pdte. Recepción de  Escritura")]
    //    JvAlarmaPdteRecepcionEscritura = 1754,

    //    [Description("JV - KPI - Pdte. Recepción de Demanda Sellada")]
    //    JvAlarmaRecepcionDemandaSellada = 1755,

    //    #endregion


    //    #endregion

    //    #region TPA

    //    #region TPA - Indicadores / Facturas

    //    [Description("TPA - Facturas Pendientes Hito 1")]
    //    TpaFacturasPendientesHito1 = 16011,
    //    [Description("TPA - Facturas Pendientes Hito 2")]
    //    TpaFacturasPendientesHito2 = 16012,

    //    #endregion

    //    #region TPA - Alarmas

    //    //[Description("Cláusula Suelo - KPI - Vencimiento Allanamiento")]
    //    //OrdinarioCsAlarmaVencimientoAllanamiento = 1551,

    //    //[Description("Cláusula Suelo - KPI - Pdte. Copia Sellada Allanamiento")]
    //    //OrdinarioCsAlarmaPendienteCopiaSelladaAllanamiento = 1556,

    //    #endregion

    //    #endregion

    //    #region JC

    //    #region JC - Indicadores / Facturas

    //    [Description("JC - Facturas Pendientes Hito 1")]
    //    JcFacturasPendientesHito1 = 24011,
    //    [Description("JC - Facturas Sin H1 y con H2")]
    //    JcFacturasPendientesHito1ConHito2 = 24012,
    //    [Description("JC - Facturas Pendientes Hito 2")]
    //    JcFacturasPendientesHito2 = 24013,

    //    //[Description("JC - Facturas Pendientes Hito 2")]
    //    //JcFacturasPendientesHito2 = 24012,

    //    #endregion

    //    #region JC - Alarmas

    //    //[Description("Cláusula Suelo - KPI - Vencimiento Allanamiento")]
    //    //OrdinarioCsAlarmaVencimientoAllanamiento = 1551,

    //    //[Description("Cláusula Suelo - KPI - Pdte. Copia Sellada Allanamiento")]
    //    //OrdinarioCsAlarmaPendienteCopiaSelladaAllanamiento = 1556,

    //    #endregion

    //    #endregion

    //    #region Monitorio Monitorio

    //    #region Monitorio - Indicadores

    //    [Description("MN - Pdte. Exp. Verbal")]
    //    MonitorioPdteExpVerbal = 20001,
    //    [Description("MN - Pdte. Exp. Ordinario")]
    //    MonitorioPdteExpOrdinario = 20002,
    //    [Description("MN - Pdte. Exp. Ejecutivo")]
    //    MonitorioPdteExpEjecutivo = 20003,

    //    #endregion

    //    #region Monitorio - Alarmas

    //    [Description("MN - KPI - Pdte. Recepción de Demanda Sellada")]
    //    MonitorioAlarmaRecepcionDemandaSellada = 20051,

    //    [Description("MN - KPI - Sucesión Copia Sellada")]
    //    MonitorioAlarmaSucesionCopiaSellada = 20052,

    //    #endregion

    //    #region Monitorio - Facturas

    //    [Description("MN - Factura - H1")]
    //    MonitorioFacturaHito1 = 200101,

    //    #endregion

    //    #endregion

    //    #region Real Estate

    //    [Description("Real Estate - Residencial")]
    //    RealEstateResidencial = 8801,
    //    [Description("Real Estate - Terciarios")]
    //    RealEstateTerciarios = 8802,
    //    [Description("Real Estate - Dotacional")]
    //    RealEstateDotacional = 8803,
    //    [Description("Real Estate - Suelos")]
    //    RealEstateSuelos = 8804,
    //    [Description("Real Estate - NPLs")]
    //    RealEstateNpls = 8805,
    //    [Description("Real Estate - REOS")]
    //    RealEstateReos = 8806,
    //    [Description("Real Estate - Concursos")]
    //    RealEstateConcursos = 8807,

    //    #endregion

    //    #region Conciliacion

    //    #region Conciliacion - Facturas

    //    [Description("Ccl - Factura - Hito 1")]
    //    ConciliacionFacturasHito1 = 23301,

    //    [Description("Ccl - Factura - Hito 1 (Caixa)")]
    //    ConciliacionFacturasHito1Caixa = 2330101,

    //    #endregion

    //    #endregion

    //    #region MultiDivisa

    //    #region MultiDivisa - Indicadores

    //    [Description("MultiDivisa - Pendiente Contacto")]
    //    MultiDivisaPendienteContacto = 29101,
    //    [Description("MultiDivisa - Contacto en Negociación")]
    //    MultiDivisaContactoEnNegociacion = 29102,
    //    [Description("MultiDivisa - Contacto con Acuerdo")]
    //    MultiDivisaContactoConAcuerdo = 29103,


    //    [Description("MultiDivisa - Finalizado con éxito")]
    //    MultiDivisaFinalizadoConExito = 29104,
    //    [Description("MultiDivisa - Finalizado Localizado sin acuerdo")]
    //    MultiDivisaFinalizadoLocalizado = 29105,
    //    [Description("MultiDivisa - Finalizado No localizado")]
    //    MultiDivisaFinalizadoNoLocalizado = 29106,
    //    [Description("MultiDivisa - Finalizado Excluidos")]
    //    MultiDivisaFinalizadoExcluido = 29107,

    //    #endregion


    //    #region MultiDivisa - Facturas

    //    //[Description("Ccl - Factura - Hito 1")]
    //    //MultiDivisaFacturasHito1 = 29301,

    //    //[Description("Ccl - Factura - Hito 1 (Caixa)")]
    //    //MultiDivisaFacturasHito1Caixa = 2930101,

    //    #endregion

    //    #endregion

    //    #region Procura

    //    #region Procura - Indicadores

    //    //[Description("Procura - Pendiente Contacto")]
    //    //ProcuraPendienteContacto = 30101,
    //    //[Description("Procura - Contacto en Negociación")]
    //    //ProcuraContactoEnNegociacion = 30102,
    //    //[Description("Procura - Contacto con Acuerdo")]
    //    //ProcuraContactoConAcuerdo = 30103,


    //    //[Description("Procura - Finalizado con éxito")]
    //    //ProcuraFinalizadoConExito = 30104,
    //    //[Description("Procura - Finalizado Localizado sin acuerdo")]
    //    //ProcuraFinalizadoLocalizado = 30105,
    //    //[Description("Procura - Finalizado No localizado")]
    //    //ProcuraFinalizadoNoLocalizado = 30106,
    //    //[Description("Procura - Finalizado Excluidos")]
    //    //ProcuraFinalizadoExcluido = 30107,

    //    #endregion

    //    #region Procura - Facturas

    //    [Description("PRC - Factura - Hito 1")]
    //    ProcuraFacturasHito1 = 30301,

    //    //[Description("Ccl - Factura - Hito 1 (Caixa)")]
    //    //ProcuraFacturasHito1Caixa = 3030101,

    //    #endregion

    //    #endregion

    //    #region Generico o Persona

    //    [Description("Exp. Activos")]
    //    ExpedientesActivos,
    //    [Description("Alarmas")]
    //    AlarmasActivos,

    //    [Description("Facturas")]
    //    FacturasActivos,
    //    [Description("Vistas")]
    //    VistasActivos,
    //    [Description("Vencimientos")]
    //    VencimientosActivos,
    //    [Description("Notificaciones")]
    //    TotalNotificacionesActivos,


    //    #endregion
    //}
    
    //public enum BurofaxType
    //{
    //    Burofax30 = 30,
    //    Burofax10 = 10
    //}

    //public enum TipoRiesgoFuga
    //{
    //    Escaso = 1,
    //    Medio = 2,
    //    Elevado = 3,
    //}

    //public enum TipoAprobacion
    //{
    //    Rechazado,
    //    Aprobado
    //}

    //public enum TipoActivo
    //{
    //    [Description("Único")]
    //    Unico,
    //    [Description("Promoción")]
    //    Promocion
    //}

    //public enum TipoTpnTnt
    //{
    //    [Description("TPT")]
    //    TPN,
    //    TNT
    //}

    //public enum TipoEstadoEvaluacionEmpleado
    //{
    //    Inicial = 0,
    //    [Description("Autoevaluación Iniciada")]
    //    AutoEvaluacionIniciada = 1,
    //    [Description("Autoevaluación Finalizada")]
    //    AutoEvaluacionFinalizada = 2,

    //    [Description("Evaluación Iniciada")]
    //    EvaluacionIniciada = 6,
    //    [Description("Evaluación Finalizada")]
    //    EvaluacionFinalizada = 7,

    //    Cerrada = 10,
    //}

    //public enum TipoResultadoEvaluacionCompetencia
    //{
    //    [Description("No lo demuestra (1)")]
    //    Voluntario = 1,
    //    [Description("A veces (2)")]
    //    AVeces = 2,
    //    [Description("Estándar (3)")]
    //    Estandar = 3,
    //    [Description("Supera expectativas (4)")]
    //    SuperaExpectativas = 4,
    //    [Description("Extraordinario (5)")]
    //    Extraordinario = 5,
    //}

    //public enum TipoResultadoObjetivo
    //{
    //    [Description("Entre 0-25 % (1)")]
    //    Entre0y25 = 1,
    //    [Description("Entre 25-50 % (2)")]
    //    Entre25y50 = 2,
    //    [Description("Entre 50-75 % (3)")]
    //    Entre50y75 = 3,
    //    [Description("Entre 75-100 % (4)")]
    //    Entre75y100 = 4,
    //    [Description("Más de 100 % (5)")]
    //    Entre100y = 5,
    //}

    //public enum TipoEmpleado
    //{
    //    Empleado = 1,
    //    Externo = 8,
    //    Responsables = 11,
    //    Director = 15,
    //    Directivo = 16,
    //}

    //public enum TipoAreaNegocio
    //{
    //    Recuperaciones = 1,
    //    //[Description("Voluntario Abreviado")]
    //    //Alq = 2,
    //    [Description("Litigación")]
    //    Litigacion = 3,
    //    Penal = 4,
    //    Concursal = 5,
    //    Fiscal = 6,
    //}

    //public enum TipoProcedimientoConcursal
    //{
    //    [Description("Voluntario Ordinario")]
    //    Voluntario = 1,
    //    [Description("Voluntario Abreviado")]
    //    VoluntarioAveriado = 11,
    //    [Description("Necesario Ordinario")]
    //    Necesario = 2,
    //    [Description("Necesario Abreviado")]
    //    NecesarioAveriado = 21,

    //    [Description("Concurso Consecutivo")]
    //    ConcursoConsecutivo = 25,
    //}

    //public enum TipoCalificacionConcursal
    //{
    //    [Description("Fortuito")]
    //    Fortuito = 1,
    //    [Description("Culpable")]
    //    Culpable = 2,
    //}

    //public enum TipoFlagInmueble
    //{
    //    Si = 1,
    //    No = 2,
    //    Posible = 3
    //}
    //public enum TipoSiNo
    //{
    //    Si = 1,
    //    No = 2,
    //}

    //public enum TipoCondicionFacturacion
    //{
    //    Simple = 1,
    //    Temporal = 2,
    //}

    //public enum TipoDdl
    //{
    //    [Description("REO")]
    //    Reo = 1,
    //    [Description("NPL")]
    //    Npl = 2,
    //    [Description("MIXTA")]
    //    Mixta = 3,
    //}

    //public enum TipoVencimiento
    //{
    //    Vencimiento = 1,
    //    [Description("Gestión")]
    //    Gestion = 2
    //}

    //public enum TipoAccionDecreto
    //{
    //    Impugnar,
    //    Pagar
    //}

    //public enum ExpCivilTipoAsunto
    //{
    //    Civil = 1,
    //    [Description("Mercantil")]
    //    Mercantil = 2
    //}

    //public enum PrestamoGarantiaType
    //{
    //    [Description("Garantía Inmobiliaria")]
    //    GarantiaInmobiliaria = 1,
    //    [Description("Garantía Personal")]
    //    GarantiaPersonal = 2,
    //    [Description("Otras Garantías")]
    //    Otra = 3
    //}

    //public enum SubastaCesionType
    //{
    //    [Description("Pendiente formalizar cesión")]
    //    Pendiente = 0,
    //    [Description("Formalizada cesión a tercero")]
    //    Tercero = 1,
    //    [Description("Formalizada cesión a fondo")]
    //    Fondo = 2
    //}

    //public enum SubastaType
    //{
    //    [Description("Ordinaria")]
    //    Ordinaria = 1,
    //    [Description("Electrónica")]
    //    Electronica = 2
    //}

    //public enum ToastType
    //{
    //    Error,
    //    Info,
    //    Success,
    //    Warning
    //}

    //public enum TipoSexo
    //{
    //    Hombre = 1,
    //    Mujer = 2
    //}

    //public enum CategoryColor
    //{
    //    [Description("-")]
    //    None,
    //    [Description("Verde – Enviado escrito sin doc")]
    //    Green,
    //    [Description("Azul – Enviado escrito con doc")]
    //    Blue,
    //    [Description("Amarillo -Solicitada documentación")]
    //    Yellow,
    //    [Description("Rojo")]
    //    Red,
    //    [Description("Gris - Sin hito de recepción")]
    //    Gray
    //}

    //public enum TipoSemaforo
    //{
    //    [Description("Verde")]
    //    Green,
    //    [Description("Amarillo")]
    //    Yellow,
    //    [Description("Rojo")]
    //    Red,
    //    [Description("Gris")]
    //    Gray
    //}

    //public enum TotalParcialType
    //{
    //    [Description("Total")]
    //    Total = 1,
    //    [Description("Parcial")]
    //    Parcial = 2
    //}

    //public enum PositivoNegativoType
    //{
    //    Positivo = 1,
    //    Negativo = 0
    //}

    //public enum TipoFaseEstadoGrupo
    //{
    //    [Description("Jurisdicción Voluntaria")]
    //    JurisdiccionVoluntaria = 10150,
    //}

    //public enum TipoSituacionEstado
    //{
    //    [Description("Sin inicializar")]
    //    NoIniciado = 0,
    //    [Description("En Ejecución")]
    //    Ejecucion = 1,
    //    [Description("Completado")]
    //    Completado = 7,
    //}

    //public enum ActionLogType
    //{
    //    #region Generics

    //    [Description("Inicio de Sesión")]
    //    InicioSesion = 1,

    //    [Description("Crear Valija")]
    //    ValijaCreate = 11,
    //    [Description("Guardar Valija")]
    //    ValijaSave = 12,
    //    //[Description("Eliminar Valija")]
    //    //ValijaDelete = 13,


    //    [Description("Crear Estado")]
    //    EstadoCreate = 14,
    //    //[Description("Guardar Estado")]
    //    //EstadoSave = 15,
    //    [Description("Eliminar Estado")]
    //    EstadoDelete = 16,

    //    #endregion

    //    [Description("Prelitigio - Estado - Recepción")]
    //    PrelitigioEstadoRecepcion = 3501,
    //    [Description("Prelitigio - Estado - Finalizado")]
    //    PrelitigioEstadoFinalizado = 3508,

    //    #region Hipotecario

    //    [Description("Crear Expediente")]
    //    ExpedienteCreate = 101,
    //    [Description("Guardar Expediente")]
    //    ExpedienteSave = 102,

    //    [Description("Hipotecario - Estado - Recepción")]
    //    HipotecarioEstadoRecepcion = 111,
    //    [Description("Hipotecario - Estado - Generación")]
    //    HipotecarioEstadoGeneracion = 112,
    //    [Description("Hipotecario - Estado - Presentación Demanda")]
    //    HipotecarioEstadoPresentacionDemanda = 113,
    //    [Description("Hipotecario - Estado - Tramitación Juzgado")]
    //    HipotecarioEstadoTramitacionJuzgado = 114,
    //    [Description("Hipotecario - Estado - Proceso Paralizado")]
    //    HipotecarioEstadoParalizado = 115,
    //    [Description("Hipotecario - Estado - Subasta")]
    //    HipotecarioEstadoSubasta = 116,
    //    [Description("Hipotecario - Estado - Adjudicación")]
    //    HipotecarioEstadoAdjudicacionDelBien = 117,

    //    [Description("Hipotecario - Estado - Negociación Posesión")]
    //    HipotecarioEstadoNegociacionPosesion = 118,

    //    [Description("Hipotecario - Estado - Jurisdicción Voluntaria")]
    //    HipotecarioEstadoJurisdiccionVoluntaria = 109,


    //    [Description("Hipotecario - Estado - Finalizado")]
    //    HipotecarioEstadoFinalizado = 119,

    //    [Description("Vincular Expediente")]
    //    ExpedienteVincular = 7700,
    //    [Description("Desvincular Expediente")]
    //    ExpedienteDesvincular = 7701,

    //    #endregion
    //}

    //public enum TramitacionJuzgadoSentenciaResultado
    //{
    //    //[Description("-")]
    //    //None = 0,
    //    [Description("Estimatoria")]
    //    Estimatoria = 1,
    //    [Description("Desestimatoria")]
    //    Desestimatoria = 2,
    //    [Description("Parcial")]
    //    Parcial = 3,

    //    [Description("Absolutoria")]
    //    Absolutoria = 4,
    //    [Description("Condenatoria")]
    //    Condenatoria = 5,
    //}

    //public enum TipoResultadoApelacion
    //{
    //    [Description("No")]
    //    No = 0,
    //    [Description("Estimatoria")]
    //    Estimatoria = 1,
    //    [Description("Parcial")]
    //    Parcial = 2,
    //    [Description("Desestimatoria")]
    //    Desestimatoria = 3
    //}

    //public enum TipoRecepcionBurofaxMotivo
    //{
    //    [Description("Recepción ok")]
    //    RecepcionOk = 1,
    //    [Description("Dejan Aviso")]
    //    DejanAviso = 2,
    //    [Description("Rehusado")]
    //    Rehusado = 3,
    //    [Description("Destinatario Desconocido")]
    //    DestinatarioDesconocido = 4,
    //    [Description("Dirección Incorrecta")]
    //    DireccionIncorrecta = 5
    //}

    ////public enum TipoSegmento
    ////{
    ////    Retail = 1,
    ////    Profesional = 2,
    ////    Suelo = 3,
    ////    Terciario = 4,
    ////    [Description("Alq. Social")]
    ////    AlqSocial = 5,
    ////}

    //public enum TipoVistaEnum
    //{
    //    #region Common



    //    #endregion

    //    #region Hipotecario

    //    [Description("Vista Oposición Ejecución")]
    //    HipotecarioVistaOposicionEjecucion = 1,
    //    [Description("Hipotecario - Vista Ocupantes")]
    //    HipotecarioVistaOcupantes = 3,
    //    [Description("Hipotecario - Lanzamiento")]
    //    HipotecarioLanzamiento = 12,
    //    [Description("Hipotecario - Posesión")]
    //    HipotecarioPosesion = 13,
    //    [Description("Hipotecario - Vista de Jurisdicción Voluntaria")]
    //    HipotecarioVistaJurisdiccionVoluntaria = 33,

    //    #endregion

    //    #region Alquiler

    //    [Description("Alquiler - Lanzamiento")]
    //    AlquilerLanzamiento = 37,
    //    [Description("Alquiler - Lanzamiento Inicial")]
    //    AlquilerLanzamientoInicial = 38,

    //    [Description("Alquiler - Vista Ocupantes")]
    //    AlquilerVistaOcupantes = 35,

    //    #endregion

    //    #region Negociacion

    //    [Description("Negociación - Entrega de Inmueble Precontencioso")]
    //    NegociacionEntregaInmueblePrecontencioso = 29,
    //    [Description("Negociación - Entrega de Inmueble Contencioso")]
    //    NegociacionEntregaInmuebleContencioso = 30,

    //    #endregion

    //    #region Ordinario

    //    [Description("Ordinario - Audiencia Previa")]
    //    OrdinarioVistaAudienciaPrevia = 27,

    //    [Description("Ordinario - Juicio")]
    //    OrdinarioJuicio = 28,

    //    #endregion

    //    #region Clausula Suelo

    //    [Description("Cláusula Suelo - Allanamiento Vencimiento")]
    //    OrdinarioCsVencimientoAllanamiento = 34,

    //    [Description("Cláusula Suelo - Allanamiento Presentado")]
    //    OrdinarioCsAllanamientoPresentado = 36,

    //    [Description("Cláusula Suelo - Vista Audiencia Previa")]
    //    OrdinarioCsVistaAudienciaPrevia = 43,

    //    #endregion

    //    #region Conciliacion

    //    [Description("Vista Conciliación Señalamiento")]
    //    ConciliacionVistaSenalamiento = 57,

    //    #endregion

    //    [Description("Vista Oposición Ejecución")]
    //    VistaOposicionEjecucion = 15,





    //}


    //public enum DeudorTipo
    //{
    //    [Description("Deudor Principal")]
    //    DeudorPrincipal = 1,
    //    [Description("Avalista")]
    //    Avalista = 2,
    //    [Description("Hipotecante")]
    //    Hipotecante = 3,
    //    [Description("3er Poseedor")]
    //    TercerPoseedor = 4,
    //    [Description("Prestatario")]
    //    Prestatario = 6,
    //    [Description("Beneficiario")]
    //    Beneficiario = 8,
    //    [Description("Codeudor Principal")]
    //    CodeudorPrincipal = 9
    //}

    //public enum AdministradorTipo
    //{
    //    [Description("Concursal")]
    //    Concursal = 1,
    //    [Description("Social")]
    //    Social = 2
    //}

    //public enum MonthType
    //{
    //    Enero = 1,
    //    Febrero = 2,
    //    Marzo = 3,
    //    Abril = 4,
    //    Mayo = 5,
    //    Junio = 6,
    //    Julio = 7,
    //    Agosto = 8,
    //    Septiembre = 9,
    //    Octubre = 10,
    //    Noviembre = 11,
    //    Diciembre = 12
    //}

    //public enum ReportType
    //{
    //    ExpedienteVistas = 11,

    //    AlquilerTasasTramites = 51,
    //    AlquilerVistas = 52,
    //    AlquilerLanzamientos = 53
    //}

    //public enum TipoBienEmbargo
    //{
    //    Saldos = 1,
    //    Salarios = 2,
    //    Muebles = 3,
    //    Inmuebles = 4
    //}

    //public enum IndicadorResultadoType
    //{
    //    #region Hipotecario + Comunes

    //    [Description("Expedientes Nuevos")]
    //    ExpedienteNuevo = 10001,

    //    [Description("Demandas Creadas")]
    //    DemandaCreada = 10201,
    //    [Description("Demandas Presentadas")]
    //    DemandaPresentada = 10202,
    //    [Description("Demandas Admitidas")]
    //    DemandaAdmitida = 10203,

    //    [Description("Vistas")]
    //    Vistas = 1041,
    //    [Description("Vistas Suspendidas")]
    //    VistasSuspendidas = 1042,

    //    [Description("Posesiones")]
    //    Posesiones = 1071,
    //    [Description("Posesiones Positivas")]
    //    PosesionesPositivas = 1072,
    //    [Description("Posesiones Negativas")]
    //    PosesionesNegativas = 1073,
    //    [Description("Posesiones Suspendidas")]
    //    PosesionesSuspendidas = 1074,

    //    [Description("Lanzamientos")]
    //    Lanzamientos = 1081,
    //    [Description("Lanzamientos Positivos")]
    //    LanzamientosPositivos = 1082,
    //    [Description("Lanzamientos Negativos")]
    //    LanzamientosNegativos = 1083,
    //    [Description("Lanzamientos Suspendidos")]
    //    LanzamientosSuspendidos = 1084,

    //    [Description("Sub. Señaladas")]
    //    SubastaSenialada = 10501,
    //    [Description("Sub. Suspendidas")]
    //    SubastaSuspendida = 10502,
    //    [Description("Sub. Realizadas")]
    //    SubastaRealizada = 10503,
    //    [Description("Dec. Convocatoria")]
    //    SubastaDecretoConvocatoria = 10504,
    //    [Description("Subastas Solicitadas")]
    //    SubastaSolicitada = 10505,
    //    [Description("Impulso Subasta Reiterada")]
    //    ImpulsoSubastaReiterada = 10506,
    //    [Description("Notificación Decreto")]
    //    SubastaNotificacionDecreto = 10507,
    //    [Description("Informe Subasta")]
    //    SubastaInforme = 10508,

    //    [Description("Dec. Adjudicación")]
    //    AdjudicacionDecreto = 10601,
    //    [Description("Testim. Adjudicación")]
    //    AdjudicacionTestimonio = 10602,

    //    [Description("Finalizados")]
    //    Finalizado = 1091,

    //    #endregion

    //    #region Ejecutivo

    //    [Description("Expedientes Nuevos")]
    //    EjcExpedienteNuevo = 30001,

    //    [Description("Demandas Presentadas")]
    //    EjcDemandaPresentada = 30202,

    //    [Description("Admisión / Tramite de Embargo")]
    //    EjcAdmisionTramite = 30301,

    //    [Description("Decreto Convocatoria")]
    //    EjcSubastaDecretoConvocatoria = 30401,
    //    [Description("Decreto Adjudicación")]
    //    EjcDecretoAdjudicacion = 30402,
    //    [Description("Testimonios de Decretos")]
    //    EjcAdjudicacionTestimonio = 30403,
    //    [Description("Posesiones")]
    //    EjcAdjudicacionPosesion = 30404,
    //    [Description("Lanzamientos")]
    //    EjcAdjudicacionLanzamiento = 30405,

    //    [Description("Embargos Saldos")]
    //    EjcEfectividadEmbargoDeudorSaldo = 30511,
    //    [Description("Embargos Salarios")]
    //    EjcEfectividadEmbargoDeudorSalario = 30512,
    //    [Description("Embargos Muebles")]
    //    EjcEfectividadEmbargoDeudorMueble = 30513,
    //    [Description("Embargos Inmuebles")]
    //    EjcEfectividadEmbargoDeudorSInmueble = 30514,

    //    [Description("Finalizados")]
    //    EjcFinalizado = 30901,

    //    #endregion

    //    #region Alquiler

    //    [Description("Expedientes Nuevos")]
    //    AlqExpedienteNuevo = 50001,
    //    [Description("Expedientes Finalizados")]
    //    AlqExpedienteFinalizado = 50901,

    //    [Description("Alq. Demandas Presentadas")]
    //    AlqDemandaPresentada = 50202,
    //    [Description("Alq. Demandas Admitidas")]
    //    AlqDemandaAdmitida = 50203,

    //    [Description("Alq. Vistas")]
    //    AlqVistas = 50401,
    //    [Description("Alq. Vistas Suspendidas")]
    //    AlqVistasSuspendidas = 50402,

    //    [Description("Alq. Lanzamientos")]
    //    AlqLanzamientos = 50801,
    //    [Description("Alq. Lanzam. Positivos")]
    //    AlqLanzamientosPositivos = 50802,
    //    [Description("Alq. Lanzam. Negativos")]
    //    AlqLanzamientosNegativos = 50803,
    //    [Description("Alq. Lanzam. Suspendidos")]
    //    AlqLanzamientosSuspendidos = 50804,

    //    #endregion

    //    #region Ordinario

    //    [Description("Expedientes Nuevos")]
    //    OrdExpedienteNuevo = 140001,
    //    [Description("Expedientes Finalizados")]
    //    OrdExpedienteFinalizado = 140901,

    //    #endregion

    //    #region OrdinarioCs

    //    [Description("Expedientes Nuevos")]
    //    CsExpedienteNuevo = 150001,
    //    [Description("Expedientes Finalizados")]
    //    CsExpedienteFinalizado = 150901,

    //    #endregion

    //    #region JurisdiccionVoluntaria

    //    [Description("Expedientes Nuevos")]
    //    JvExpedienteNuevo = 170001,
    //    [Description("Expedientes Finalizados")]
    //    JvExpedienteFinalizado = 170901,

    //    #endregion

    //}



    //public enum HitoFacturacionValue
    //{
    //    [Description("Suplido")]
    //    Suplido = 0,

    //    [Description("Hito 1")]
    //    Hito1 = 1,
    //    [Description("Hito 2")]
    //    Hito2 = 2,
    //    [Description("Hito 3")]
    //    Hito3 = 3,
    //    [Description("Hito 4")]
    //    Hito4 = 4,
    //    [Description("Hito 5")]
    //    Hito5 = 5,
    //    [Description("Hito 6")]
    //    Hito6 = 6,


    //    #region Hipotecario

    //    [Description("Hipotecario - Hito 1")]
    //    HipotecarioHito1 = 101,
    //    [Description("Hipotecario - Hito 2")]
    //    HipotecarioHito2 = 102,
    //    [Description("Hipotecario - Hito 3")]
    //    HipotecarioHito3 = 103,
    //    [Description("Hipotecario - Hito 4 (Finalización)")]
    //    HipotecarioHito4 = 104,

    //    #endregion

    //    #region Monitorio

    //    [Description("Monitorio - Hito 1")]
    //    MonitorioHito1 = 201,

    //    #endregion

    //    #region Conciliacion

    //    [Description("Conciliación - Hito 1")]
    //    ConciliacionHito1 = 2301,

    //    #endregion

    //    #region Alquiler

    //    [Description("Alquiler - Presentación de Demanda")]
    //    AlquilerPresentacionDemanda = 501,
    //    [Description("Alquiler - Finalizado")]
    //    AlquilerFinalizado = 502,
    //    [Description("Alquiler - Precontencioso")]
    //    AlquilerPrecontencioso = 503,

    //    [Description("Alquiler - Carga Cliente")]
    //    AlquilerCargaCliente = 504,
    //    [Description("Alquiler - Vista con Oposición")]
    //    AlquilerVistaConOposicion = 505,
    //    [Description("Alquiler - Lanzamiento")]
    //    AlquilerLanzamiento = 506,
    //    [Description("Alquiler - Recuperar Deuda (Ejecutivo)")]
    //    AlquilerRecuperarDedudaEjecutivo = 507,
    //    [Description("Alquiler - Finalizado (Complemento)")]
    //    AlquilerFinalizadoComplemento = 508,

    //    [Description("Alquiler - Hito 1")]
    //    AlquilerHito1 = 511,
    //    [Description("Alquiler - Hito 2")]
    //    AlquilerHito2 = 512,
    //    [Description("Alquiler - Hito 3")]
    //    AlquilerHito3 = 513,

    //    #endregion

    //    #region Ordinario

    //    [Description("Ordinario - Hito 1")]
    //    OrdinarioHito1 = 1401,
    //    [Description("Ordinario - Hito 2")]
    //    OrdinarioHito2 = 1402,

    //    #endregion

    //    #region OrdinarioCs

    //    [Description("Cláusula Suelo - Hito 1")]
    //    OrdinarioCsHito1 = 1501,
    //    [Description("Cláusula Suelo - Hito 2")]
    //    OrdinarioCsHito2 = 1502,

    //    #endregion

    //    #region Ejecutivo

    //    [Description("Ejecutivo - Hito 2")]
    //    EjecutivoFinalizado = 301,
    //    [Description("Ejecutivo - Hito 1")]
    //    EjecutivoPresentacionDemandaVinculadoAlquiler = 302,

    //    #endregion

    //    #region TPA

    //    [Description("TPA - Hito 1")]
    //    TpaHito1 = 1601,
    //    [Description("TPA - Hito 2")]
    //    TpaHito2 = 1602,

    //    #endregion

    //    #region Procura

    //    [Description("Procura - Hito 1")]
    //    ProcuraHito1 = 3001,

    //    #endregion

    //    [Description("Otro")]
    //    Otro = 999,
    //}

    //public enum TipoAreaGestion
    //{
    //    [Description("Área Gestores")]
    //    AreaGestores = 1,
    //    [Description("Área Demandas")]
    //    AreaDemandas = 2,
    //    [Description("Área Trámite")]
    //    AreaTramite = 3,

    //    [Description("Área Subasta")]
    //    AreaSubasta = 4,
    //    [Description("Área Posesiones")]
    //    AreaPosesiones = 5,
    //    [Description("Área Negociación")]
    //    AreaNegociacion = 6,
    //}

    //public enum RoleType
    //{
    //    Invitado = 1,
    //    Administrador = 2,
    //    Director = 3,
    //    [Description("Jefe Área")]
    //    JefeArea = 4,
    //    Abogado = 5,
    //    Datos = 6,
    //    Finanzas = 7,
    //    Cliente = 8,
    //    Gestor = 9,
    //    [Description("Recursos Humanos")]
    //    RecursosHumanos = 10,
    //    Concursal = 40,
    //    [Description("Gestor de Inmuebles")]
    //    GestorInmueble = 41,
    //    [Description("Solo Lectura")]
    //    UserReadOnly = 81
    //}

    //public enum CalendarType
    //{
    //    [Description("Solicitud Adjudicación Limite")]
    //    SolicitudAdjudicacionLimite = 1
    //}

    ////public enum NoteType
    ////{
    ////    [Description("-")]
    ////    None = 0,

    ////    [Description("Llamada del contrario")]
    ////    LlamadaDemandadoChavarri = 31,
    ////    [Description("Llamada al demandado")]
    ////    LlamadaChavarriDemandado = 32,
    ////    [Description("Instrucciones de cliente")]
    ////    InstruccionesCliente = 33,
    ////    [Description("Consulta de cliente")]
    ////    ConsultaCliente = 34,
    ////    [Description("Datos de contacto del demandado")]
    ////    DatosContactoDemandado = 35,
    ////    [Description("Datos de contacto del letrado contrario")]
    ////    DatosContactoLetradoContrario = 36,

    ////    [Description("ReI - Antecedentes a la asignación")]
    ////    ReiAntecedentes = 401,
    ////    [Description("ReI - Hitos procesales")]
    ////    ReiHitos = 402,
    ////    [Description("ReI - Estrategia")]
    ////    ReiEstrategia = 403,
    ////    [Description("ReI - Fase común")]
    ////    ReiFaseComun = 404,
    ////    [Description("ReI - Fase Convenio")]
    ////    ReiFaseConvenio = 405,
    ////    [Description("ReI - Fase de Liquidación")]
    ////    ReiFaseLiquidacion = 406,
    ////    [Description("ReI - Propuesta Convenio o Plan de Litigación")]
    ////    ReiPropuestaConvenio = 407,

    ////    [Description("Negociación - Localización Deudor")]
    ////    NegociacionLocalizacionDeudor = 51,
    ////    [Description("Negociación - Interesado Propuesta")]
    ////    NegociacionInteresadoPropuesta = 52,
    ////    [Description("Negociación - Interesado Quita")]
    ////    NegociacionInteresadoQuita = 53,
    ////    [Description("Negociación - Acepta Propuesta")]
    ////    NegociacionAceptaPropuesta = 54,

    ////    [Description("Llamada al Titular")]
    ////    LlamadaTitular = 2901,
    ////    [Description("Llamada al Abogado")]
    ////    LlamadaAbogado = 2902,
    ////    [Description("Llamada del Titular")]
    ////    LlamadaDelTitular = 2903,
    ////    [Description("Llamada del Abogado")]
    ////    LlamadaDelAbogado = 2904,


    ////    [Description("Observación del Estado")]
    ////    Estado = 81,

    ////    Otras = 99
    ////}

    //public enum TipoNotaInmueble
    //{
    //    [Description("Nota")]
    //    Nota = 1,
    //    [Description("Acción Comercial")]
    //    AccionComercial = 2,
    //}

    //public enum SlaType
    //{
    //    [Description("Hipotecario - Presentación Demanda")]
    //    HipotecarioPresentacionDemanda = 101,

    //    [Description("Ejecutivo - Presentación Demanda")]
    //    EjecutivoPresentacionDemanda = 301,
    //    [Description("Alquiler - Presentación Demanda")]
    //    AlquilerPresentacionDemanda = 501,
    //    [Description("Ordinario - Presentación Demanda")]
    //    OrdinarioPresentacionDemanda = 1401,

    //    [Description("Jv - Presentación Demanda")]
    //    JvPresentacionDemanda = 1701,
    //}

    //public enum TipoImpulso
    //{
    //    [Description("-")]
    //    None = 0,
    //    [Description("Auto de admisión")]
    //    AutoAdmision = 1,
    //    [Description("Certificación de cargas")]
    //    CertificacionCargas = 2,
    //    [Description("Requerimiento de pago")]
    //    RequerimientoPago = 3,
    //    [Description("Solicitud de subasta")]
    //    SolicitudSubasta = 4,
    //    [Description("Pdte. Notificación Decreto Subasta")]
    //    NotificacionDecretoConvocatoria = 5,
    //    [Description("Pdte. Edicto")]
    //    Edicto = 6,
    //    [Description("Pdte. Tasa")]
    //    Tasa = 7,
    //    [Description("Pdte. Autorización Pago Tasa")]
    //    AutorizacionPagoTasa = 8,
    //    [Description("Pdte. Pago Tasa")]
    //    PagoTasa = 9,
    //    [Description("Pdte. Nueva Tasa")]
    //    NuevaTasa = 10,
    //    [Description("Solicitar adjudicación")]
    //    SolicitarAdjudicacion = 11,
    //    [Description("Trasd int / cost")]
    //    TrasdIntCost = 12,
    //    [Description("Decreto aprobación int y costas")]
    //    DecretoAprobacionIntCostas = 13,
    //    [Description("Pdte. consignar sobrante")]
    //    PteConsignarSobrante = 14,
    //    [Description("Pdte. reintegro sobrante")]
    //    PteReintegroSobrante = 15,
    //    [Description("Cesión remate")]
    //    CesiónRemate = 16,
    //    [Description("Decreto adjudicación")]
    //    DecretoAdjudicacion = 17,
    //    [Description("Testimonio decreto adjudicación")]
    //    TestimonioDecretoAdjudicacion = 18,
    //    [Description("Inscripción testimonio")]
    //    InscripcionTestimonio = 19,
    //    [Description("Señalamiento posesión")]
    //    SenalamientoPosesion = 20,
    //    [Description("Pdte. Apertura")]
    //    PdteApertura = 21,
    //    [Description("Pdte. de convocatoria de subasta")]
    //    PdteConvocatoriaSubasta = 22,
    //    [Description("Jurisdicción Voluntaria")]
    //    JurisdiccionVoluntaria = 23,
    //    [Description("Adición Mandamiento")]
    //    AdicionMandamiento = 24,
    //    [Description("Reiteración de Subasta")]
    //    ReiteracionSubasta = 25,

    //    [Description("Pendiente requerir deudor/tercer poseedor")]
    //    PdteRequerirDeudor = 31,
    //    [Description("Pendiente notificar fiador")]
    //    PdteNotificarFiador = 32,
    //    [Description("Pendiente subsanar / adición calificación negativa certificación cargas")]
    //    PdteSubsanarCalificacionNegativaCertificacionCargas = 33,
    //    [Description("Pdte. acreditar fallecimiento deudor y continuar contra herencia yacente")]
    //    PdteAcreditarFallecimientoDeudor = 34,
    //    [Description("Pendiente alcen suspensión por justicia gratuita")]
    //    PdteSuspensionJusticiaGratuita = 35,
    //    [Description("Pdte. determinen si un bien está afecto al desarrollo actividad concurso")]
    //    PdteBienAfectoActividadConcurso = 36,
    //    [Description("Solicitada aclaración/subsanación de una resolución")]
    //    SolicitadaAclaracionResolucion = 37,
    //    [Description("Realizadas alegaciones pendientes de resolver")]
    //    RealizadasAlegacionesPdteResolver = 38,
    //    [Description("Pendiente respuesta VPO")]
    //    PdteRespuestaVpo = 39,
    //    [Description("Pdt. señalen vista. op. o resuelvan op., nulidad, impug., reposición o rev., susp. por preju. civil-penal-conc.(1ª Inst.)")]
    //    PdteVistaOposicionNulidadOtros = 40,
    //    [Description("Pdt. resuelvan o señalen apelación, casación, infracción de ley, amparo o queja (2ª inst.)")]
    //    PdteResuelvanApelacionCasacionOtros = 41,
    //    [Description("Pendiente resolución incidente ocupantes")]
    //    PdteResolucionIncidenteOcupantes = 42,
    //    [Description("Pendiente instrucciones cliente")]
    //    PdteInstruccionesCliente = 43,

    //    #region Hipotecarios

    //    [Description("Pdte. señalamiento posesión / lanzamiento")]
    //    PdteSenalamientoPosesionLanzamiento = 44,

    //    #endregion

    //    #region Alquiler

    //    [Description("Alq - Admisión a trámite demanda")]
    //    Alquiler001 = 50001,
    //    [Description("Alq - Pdte. resolución sb requerimientos Juzgado")]
    //    Alquiler002 = 50002,
    //    [Description("Alq - Pdte. resolución sb aclaración o subsanación decreto de admisión")]
    //    Alquiler003 = 50003,
    //    [Description("Alq - Notificación demandado ")]
    //    Alquiler004 = 50004,
    //    [Description("Alq - Notificación positiva")]
    //    Alquiler005 = 50005,
    //    [Description("Alq - Notificación negativa")]
    //    Alquiler006 = 50006,
    //    [Description("Alq -Averiguación domiciliaria ")]
    //    Alquiler007 = 50007,
    //    [Description("Alq - Pdte. decreto de fin de procedimiento")]
    //    Alquiler008 = 50008,
    //    [Description("Alq - Pdte. Reanudación procedimiento")]
    //    Alquiler009 = 50009,
    //    [Description("Alq - Suspensión procedimiento")]
    //    Alquiler010 = 50010,
    //    [Description("Alq - Resolución AJG")]
    //    Alquiler011 = 50011,
    //    [Description("Alq - Auto homologando acuerdo")]
    //    Alquiler012 = 50012,
    //    [Description("Alq - Decreto de enervación")]
    //    Alquiler013 = 50013,
    //    [Description("Alq - Transferencia de cantidades consignadas")]
    //    Alquiler014 = 50014,
    //    [Description("Alq - Pdte. notificación de Sentencia demandado")]
    //    Alquiler015 = 50015,
    //    [Description("Alq - Pdte. Sentencia")]
    //    Alquiler016 = 50016,
    //    [Description("Alq - Pdte nuevo señalamiento vista")]
    //    Alquiler017 = 50017,
    //    [Description("Alq - Pdte señalamiento lanzamiento")]
    //    Alquiler018 = 50018,
    //    [Description("Alq - Pdte. nuevo señalamiento lanzamiento")]
    //    Alquiler019 = 50019,

    //    [Description("Alq - Pdte. diligencia de lanzamiento")]
    //    Alquiler020 = 50020,
    //    [Description("Alq - Pdte admisión a trámite de demanda de ejec. lanza")]
    //    Alquiler021 = 50021,

    //    #endregion

    //    #region ClausulaSuelo

    //    [Description("CS - Impulso Documentación/Cuadro amortización/abono")]
    //    ClausulaSueloDocumentacion = 1501,
    //    [Description("CS - Impulso Audiencia Previa")]
    //    ClausulaSueloAudienciaPrevia = 1502,
    //    [Description("CS - Impulso Juicio")]
    //    ClausulaSueloJuicio = 1503,
    //    [Description("CS - Impulso Sentencia")]
    //    ClausulaSueloSentencia = 1504,
    //    [Description("CS - Impulso Tasación de costas")]
    //    ClausulaSueloTasacionCostas = 1505,

    //    #endregion

    //    Otros = 99901,
    //}

    //public enum TipoActuacion
    //{
    //    [Description("-")]
    //    None = 0,

    //    [Description("Escritos alegaciones")]
    //    EscritoAlegaciones = 10101,
    //    [Description("Cumplimientos de Requerimientos")]
    //    Cumplimientoequerimiento = 10102,
    //    [Description("Recurso de Reposición")]
    //    RecursoReposicion = 10103,
    //    [Description("Recurso de Revisión")]
    //    RecursoRevision = 10104,
    //    [Description("Recurso de Aclaración")]
    //    RecursoAclaracion = 10105,
    //    [Description("Solicitud decreto intereses y costas")]
    //    SolicitudDecretoInteresesCostas = 10106,
    //    [Description("Averiguación domiciliaria")]
    //    AveriguacionDomiciliaria = 10107,
    //    [Description("Averiguación patrimonial")]
    //    AveriguacionPatrimonial = 10108,

    //    [Description("Recurso apelación")]
    //    RecursoApelacion = 10111,
    //    [Description("Incidente nulidad actuaciones")]
    //    IncidenteNulidadActuaciones = 10112,
    //    [Description("Incidente tasación costas")]
    //    IncidenteTasacionCostas = 10113,
    //    [Description("Incidente nulidad intereses")]
    //    IncidenteNulidadIntereses = 10114,
    //    [Description("Terceria mejor derecho/dominio")]
    //    TerceriaMejorDerechoDominio = 10115,

    //    [Description("Escrito evacuando requerimiento previo")] EscritoEvacuandoRequerimientoPrevio,
    //    [Description("Escrito conformidad con la enervación")] Escritoconformidadconlaenervacion,
    //    [Description("Escrito solicitando averiguacion domiciliaria")] Escritosolicitandoaveriguaciondomiciliaria,
    //    [Description("Escrito solicitando publicación edicto")] Escritosolicitandopublicacionedicto,
    //    [Description("Escrito habilitacion horas inhabiles	 ")] Escritohabilitacionhorasinhabiles,
    //    [Description("Escrito de manifestaciones")] Escritodemanifestaciones,
    //    [Description("Escrito oficio Polici")] EscritooficioPolicia,
    //    [Description("Escrito oficio Servicios Sociales")] EscritooficioServiciosSociales,
    //    [Description("Escrito de archivo del procedimiento")] Escritodearchivodelprocedimiento,
    //    [Description("Escrito de desistimiento")] Escritodedesistimiento,
    //    [Description("Recurso de apelación")] Recursodeapelacion,
    //    [Description("Personación ante la AP")] PersonacionantelaAP,
    //    [Description("Impugnación recurso de apelación")] Impugnacionrecursodeapelacion,
    //    [Description("Recurso de reposición")] Recursodereposicion,
    //    [Description("Impugnación recurso de reposición")] Impugnacionrecursodereposicion,
    //    [Description("Recurso de revisión")] Recursoderevision,
    //    [Description("Impugnación recurso de revisión")] Impugnacionrecursoderevision,
    //    [Description("Demanda de ejecución/Ejecutoria Penal")] DemandadeejecucionEjecutoriaPenal,
    //    [Description("Escrito de averiguacion patrimonial")] Escritodeaveriguacionpatrimonial,
    //    [Description("Escrito de mejora de embargo")] Escritodemejoradeembargo,
    //    [Description("Escrito de archivo de la ejecución")] Escritodearchivodelaejecucion,
    //    [Description("Demanda de ejecución provisional/ejecutoria provisional")] DemandadeejecucionprovisionalEjecutoriaprovisional,
    //    [Description("Presentación Recurso de Casación")] PresentacionRecursodeCasacion,
    //    [Description("Oposición Recurso de Casación")] OposicionRecursodeCasacion,
    //    [Description("Escrito nulidad de actuaciones")] Escritonulidaddeactuaciones,
    //    [Description("Escrito de aclaración de sentencia")] Escritodeaclaraciondesentencia,
    //    [Description("Escrito de subrogación/personación")] EscritodesubrogacionPersonacion,
    //    [Description("Escrito solicitando firmeza sentencia")] Escritosolicitandofirmezasentencia,
    //    [Description("Escrito ejecución de lanzamiento")] Escritoejecuciondelanzamiento,
    //    [Description("Preparación instructa")] Preparacioninstructa,
    //    [Description("Escrito de contestación a la demanda")] Escritodecontestacionalademanda,
    //    [Description("Escrito de acuerdo conjunto")] Escritodeacuerdoconjunto,
    //    [Description("Escrito solicitando suspensión procedimiento")] Escritosolicitandosuspensionprocedimiento,
    //    [Description("Escrito solicitando reanudación del procedimiento")] Escritosolicitandoreanudaciondelprocedimiento,
    //    [Description("Escrito solicitando embargo de bienes")] Escritosolicitandoembargodebienes,
    //    [Description("Escrito se transfieran cuantías a CC cliente")] EscritosetransfierancuantíasaCCcliente,
    //    [Description("Escrito aclaración cuantía")] Escritoaclaracioncuantía,
    //    [Description("Escrito oposición admisión recurso apelación/extraordinario infracción procesal")] EscritooposicionadmisionrecursoapelacionExtraordinarioinfraccionprocesal,
    //    [Description("Escrito aclaración domicilio")] Escritoaclaraciondomicilio,
    //    [Description("Escrito solicitando notificación por edictos")] Escritosolicitandonotificacionporedictos,
    //    [Description("Escrito si/no pertinencia vista")] EscritoPertinenciaVista,
    //    [Description("Escrito solicitando se libre exhorto")] Escritosolicitandoselibreexhorto,
    //    [Description("Escrito de allanamiento")] Escritodeallanamiento,
    //    [Description("Escrito solicitando se cite a la Fuerza Pública en calidad de testigos")] EscritosolicitandosecitealaFuerzaPúblicaencalidaddetestigos,
    //    [Description("Escrito solicitando medidas cautelares")] Escritosolicitandomedidascautelares,
    //    [Description("Escrito solicitando venia a favor de Tarsso")] EscritosolicitandoveniaafavordeTarsso,
    //    [Description("Escrito solicitando interrogatorio por videoconferencia")] Escritosolicitandointerrogatorioporvideoconferencia,
    //    [Description("Escrito solicitando se requieran documento legibles")] Escritosolicitandoserequierandocumentolegibles,
    //    [Description("Escrito solicitando se expida nuevo mandamiento de pago por caducidad/extravío")] EscritosolicitandoseexpidanuevomandamientodepagoporcaducidadExtravío,
    //    [Description("Escrito oposición de la ejecución")] Escritooposiciondelaejecucion,
    //    [Description("Escrito impugnación oposición a la")] Escritoimpugnacionoposicionala,
    //    [Description("Ejecución")] Ejecucion,


    //    [Description("Oposición recurso de apelación")] OposicionRecursoApelacion,
    //    [Description("Impugnación recurso de apelación")] ImpugnacionRecursoApelacion,
    //    [Description("Oposición recurso extraordinario por infracción procesal")] OposicionRecursoExtraordinarioInfraccionProcesal,
    //    [Description("Escrito solicitando homologación judicial")] EscritoSolicitandoHomologacionJudicial,
    //    [Description("Escrito solicitando nueva fecha de lanzamiento")] EscritoSolicitandoNuevaFechaLanzamiento,
    //    [Description("Escrito solicitando la suspensión del lanzamiento")] EscritoSolicitandoSuspensionLanzamiento,



    //}

    //public enum TipoMediacion
    //{
    //    [Description("-")]
    //    None = 0,
    //    [Description("Mediación – Social")]
    //    Social = 1,
    //    [Description("Mediación – Mercado")]
    //    Mercado = 2,
    //    [Description("Mediación – Sareb")]
    //    Sareb = 3,
    //    [Description("Pase a Mercado")]
    //    PaseMercado = 4,
    //}

    //public enum Areas
    //{
    //    Administracion = 1,
    //    ClausulaSuelo = 2,
    //    Datos = 3,
    //    Demanda = 4,
    //    FuncionNegociadora = 5,
    //    GestorCarteraAlquiler = 6,
    //    GestorCarteraHipotecario = 7,
    //    Internacional = 8,
    //    Posesiones = 9,
    //    Subastas = 10,
    //    Tramite = 11
    //}

    //public enum EstadoMail
    //{
    //    Pendiente = 1,
    //    [Description("Finalizado")]
    //    Tramitado = 2
    //}

    //public enum TipoAdherido
    //{
    //    [Description("No Adherido")]
    //    NoAdherido = 0,
    //    [Description("Adherido")]
    //    Adherido = 1,
    //}

    //public enum InmuebleOrigen
    //{
    //    [Description("Gestión Inmobiliaria")]
    //    GestionInmobiliaria = 1,
    //    [Description("Gestión Solvtio")]
    //    GestionSolvtio = 2,
    //}

    //public enum TipoEstadoPropuesta
    //{
    //    Borrador = 0,
    //    [Description("Enviada")]
    //    Enviada = 3,
    //    [Description("Aceptada")]
    //    Aceptada = 9
    //}

    //public enum EstadoTiket
    //{
    //    Nuevo = 0,
    //    [Description("Activo")]
    //    Activo = 1,
    //    [Description("Resuelto")]
    //    Resuelto = 2
    //}

    //public enum TipoHitoSegunFechaEstado
    //{
    //    //[Description("Presentación de Demanda")]
    //    //HipDemandaPresentacion,
    //    [Description("Admisión Demanda")]
    //    HipDemandaAdmision,
    //    [Description("Certificación de Cargas")]
    //    HipCertificacionCarga,
    //    [Description("Req. Pago +")]
    //    HipReqPagoPositivo,
    //    [Description("Dec. Subasta")]
    //    HipSubastaDecreto,
    //    [Description("Celebración Subasta")]
    //    HipSubastaCelebracion,
    //    [Description("Adjudicación")]
    //    HipAdjudicacion,
    //}

    //public enum TipoProveedor
    //{
    //    Proveedor,
    //    Colaborador,
    //}

}
