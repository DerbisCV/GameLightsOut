using System.ComponentModel;

namespace Solvtio.Models
{  
    public enum TipoExpedienteEnum
	{
		[Description("Todos")]
		Todos = 0,
		[Description("HP")]
        Hipotecario = 1,
		[Description("Monitorio")]
		Monitorio = 2,
		[Description("EJ")]
		Ejecutivo = 3,
		[Description("CyM")]
		Concurso = 4,
		[Description("ALQ")]
		Alquiler = 5,
		[Description("Hipotecario Mayor Cuantía")]
		HipotecarioMayorCuantia = 6,
		[Description("Cambiario")]
		Cambiario = 7,
		[Description("Verbal")]
		Verbal = 8,
		//[Description("Ordinarios")]
		//Ordinarios = 9,
		[Description("Administrativos")]
		Administrativos = 10,
		[Description("Penal")]
		Penal = 11,
		[Description("Laboral")]
		Laboral = 12,
		[Description("NEG")]
		Negociacion = 13,
        [Description("ORD")]
        Ordinario = 14,
        [Description("CS")]
        OrdinarioCs = 15,
	    [Description("TPA")]
	    TomaPosesionAnticipada = 16,
        [Description("JV")]
        JurisdiccionVoluntaria = 17,

        [Description("INM")]
        Inmobiliaria = 18,
        [Description("RSC")]
        ResponsabilidadSocialCorporativa = 19,
        [Description("CIV")]
        Civil = 20,
        [Description("FSC")]
        Fiscal = 21,

        [Description("Saneamiento Reos")]
        Saneamiento = 22,       

        [Description("Conciliación")]
        Conciliacion = 23,

        [Description("Jura de Cuentas")]
        JuraCuenta = 24,


        [Description("Mercantil / Inmobiliario")]
        MercantilInmobiliario = 25,
        [Description("DDL")]
        Ddl = 26,
        [Description("Contencioso Administrativo")]
        ContenciosoAdministrativo = 27,
        [Description("Contencioso Administrativo Ordinario")]
        ContenciosoAdministrativoOrdinario = 28,
        [Description("MD")]
        MultiDivisa = 29,
        [Description("PRC")]
        Procura = 30,
        SCNE = 31,
        Bastanteo = 32,
        Testamentario = 33,
        [Description("TPT")]
        TPN = 34,

        [Description("PLTG")]
        Prelitigio = 35,
    }

    public enum TipoKpi
    {
        [Description("Alarma")]
        Alarma = 1,
        Factura = 2,
    }

    public enum ContactadoTipo
    {
        [Description("No contactado")]
        NoContactado = 1,
        Detectiv = 2,
        Cliente = 3,
        [Description("Chávarri Abogados")]
        ChavarriAbogados = 4,
    }


    public enum ExpedienteEstadoTipo
	{
		[Description("Recepción de Expediente")]
		RecepcionExpediente = 1,

		#region Hipotecario

		[Description("Hipotecario - Recepción Solicitudes Cierre")]
		HipotecarioGeneracionExpediente = 2,
		[Description("Hipotecario - Presentación Demanda")]
		HipotecarioPresentacionDemanda = 3,
		[Description("Hipotecario - Tramitación / Subasta")]
		HipotecarioTramitacionSubasta = 4,
		[Description("Hipotecario - Proceso Paralizado")]
		HipotecarioParalizado = 5,
		[Description("Hipotecario - Subasta")]
		HipotecarioSubasta = 6,
		[Description("Hipotecario - Adjudicación")]
		HipotecarioAdjudicacionDelBien = 7,

	    [Description("Jurisdicción Voluntaria")]
        HipotecarioJurisdiccionVoluntaria = 109,

        [Description("Hipotecario - Negociación Posesión")]
		HipotecarioNegociacionPosesion = 11175,

		[Description("Hipotecario - Finalizado")]
		HipotecarioFinalizado = 8,

		#endregion

		#region Concursal

		[Description("Concursal - Fase Común")]
		ConcursalFaseComun = 41,
		[Description("Concursal - Fase Convenio")]
		ConcursalFaseConvenio = 42,
		[Description("Concursal - Fase Liquidación")]
		ConcursalFaseLiquidacion = 43,
		//[Description("Concursal - Fase Calificación")]
		//ConcursalFaseCalificacion = 44,
		[Description("Concursal - Finalizado")]
		ConcursalFinalizado = 45,

		#endregion

		#region Alquiler

		[Description("Alquiler - Recepción de Expediente")]
		AlquilerRecepcionExpediente = 73,
		[Description("Alquiler - Generación de Expediente")]
		AlquilerGeneracionExpediente = 74,
		[Description("Alquiler - Presentación Demanda")]
		AlquilerPresentacionDemanda = 75,
		[Description("Alquiler - Tramitación Juzgado")]
		AlquilerTramitacionJuzgado = 76,
		[Description("Alquiler - Ejecución Posesión")] //Alquiler - Posesión y Lanzamiento
        AlquilerLanzamiento = 77,
		[Description("Alquiler - Adjudicación del Bien (OBSOLETO)")]
		AlquilerAdjudicacionBien = 78,
		[Description("Alquiler - Finalizado")]
		AlquilerFinalizado = 79,

        [Description("Alquiler - Enervación")]
        AlquilerEnervacion = 5100,
        [Description("Alquiler - Proceso Paralizado")]
        AlquilerParalizado = 5101,

        [Description("Alquiler - Presentación Denuncia")]
        AlquilerPresentacionDenuncia = 5131,
        [Description("Alquiler - Tramitación Denuncia")]
        AlquilerTramitacionDenuncia = 5132,




        #endregion

        #region Ejecutivo

        [Description("Recepción de Expediente y Revisión")]
		EjecutivoRecepcionExpediente = 31,
        [Description("Ejecutivo - Envío demanda al procurador (Obsoleto)")]
        EjecutivoEnvioDemandaProcurador = 315,
        [Description("Ejecutivo - Presentación Demanda")]
		EjecutivoPresentacionDemanda = 32,
	    [Description("Ejecutivo - Presentación Escrito 579")] //Ejecutivo - Presentación Escrito de continuación 579
        EjecutivoPresentacionEscrito579 = 325,
        [Description("Ejecutivo - Admisión / Trámite de Embargo")]
		EjecutivoAdmisionTramiteEmbargo = 33, //EjecutivoAdmisionTramiteEmbargo
        [Description("Ejecutivo - Trámite de Embargo")]
		EjecutivoTramiteEmbargo = 34,
		[Description("Ejecutivo - Efectividad de Embargo")]
		EjecutivoEfectividadEmbargo = 35,
		[Description("Ejecutivo - Solicitud de Subasta")]
		EjecutivoSolicitudSubasta = 36,
		[Description("Ejecutivo - Subasta")]
		EjecutivoSubasta = 37,
		[Description("Ejecutivo - Adjudicación del Bien")]
		EjecutivoAdjudicacionBien = 38,
	    [Description("Ejecutivo - Proceso Paralizado")]
	    EjecutivoParalizado = 385,
        [Description("Ejecutivo - Finalización del Proceso Jurídico")]
		EjecutivoFinalizacion = 39,

		#endregion

		#region Negociacion

        [Description("0. Negociación - Pendiente Teléfono")]
		NegociacionPendienteTelefono = 47,
		[Description("1. Negociación.Pdte Contacto")]
		NegociacionPdteContacto = 48,
		[Description("2. Negociación.Teléfono Erróneo")]
		NegociacionTelefonoErroneo = 49,

		[Description("3.1. Negociación.En Trámite - Pdte Propuesta")]
		NegociacionEnTramitePdtePropuesta = 50,
		[Description("3.2. Negociación.En Trámite - Rehabilitación")]
		NegociacionEnTramiteRehabilitacion = 51,
		[Description("3.3. Negociación.En Trámite - Adecuación")]
		NegociacionEnTramiteAdecuacion = 52,
		[Description("3.4. Negociación.En Trámite-Adecuación Sostenible")]
		NegociacionEnTramiteAdecuacionSostenible = 53,
		[Description("3.5. Negociación.En Trámite-Cancelación")]
		NegociacionEnTramiteCancelacion = 54,
		[Description("3.6. Negociación.En Trámite Cancel. con quita")]
		NegociacionEnTramiteCancelConQuita = 55,
		[Description("3.7. Negociación.En Trámite - Venta")]
		NegociacionEnTramiteVenta = 56,
		[Description("3.8. Negociación.En Trámite Prop. Elevada/Est.")]
		NegociacionEnTramitePropElevada = 57,
		[Description("3.9. Negociación.En Trámite - Dación en Pago")]
		NegociacionEnTramiteDacionPago = 58,

        [Description("4.1. Negociación. Sucursal-Rehabilitación")]
		NegociacionSucursalRehabilitacion = 59,
		[Description("4.2. Negociación.Sucursal - Adecuación")]
		NegociacionSucursalAdecuacion = 60,
		[Description("4.3. Negociación.Sucursal-Adecuación Sostenible")]
		NegociacionSucursalAdecuacionSostenible = 61,
		[Description("4.4. Negociación.Sucursal-Cancelación")]
		NegociacionSucursalCancelacion = 62,
		[Description("4.5. Negociación.Sucursal Cancel. con quita")]
		NegociacionSucursalCancelConquita = 63,
		[Description("4.6. Negociación.Sucursal - Venta")]
		NegociacionSucursalVenta = 64,
		[Description("4.7. Negociación.Sucursal - Dación en Pago")]
		NegociacionSucursalDacionenPago = 65,

        [Description("5.1. Negociación.Finalizado - Inviable")]
		NegociacionSucursalInviable = 66,
		[Description("5.2. Negociación.Finalizado-Desistido/Paral.")]
		NegociacionSucursalDesistidoParal = 67,
		[Description("5.3. Negociación.Finalizado-Subasta")]
		NegociacionSucursalSubasta = 68,
		[Description("5.4. Negociación.Finalizado - Vendido a Fondo")]
		NegociacionSucursalVendidoaFondo = 69,
		[Description("5.5. Negociación. Finalizado-Propuesta Denegada")]
		NegociacionSucursalFinalizadoPropuestaDenegada = 70,
		[Description("5.6. Negociación.Finalizado-Propuesta Aceptada")]
		NegociacionSucursalFinalizadoPropuestaAceptada = 71,

		[Description("6.1. F. Neg. Pago Parcial")]
		NegociacionPagoParcial = 80,
		[Description("6.2. F. Neg. Pago Total")]
		NegociacionPagoTotal = 81,
		[Description("6.3. F. Neg. Condonación Parcial")]
		NegociacionCondonacionParcial = 82,
		[Description("6.3. F. Neg. Condonación Total")]
		NegociacionCondonacionTotal = 83,
		[Description("6.4. F. Neg. Deuda Pagada Parcial")]
		NegociacionDeudaPagadaParcial = 84,
		[Description("6.5. F. Neg. Deuda Pagada Total")]
		NegociacionDeudaPagadaTotal = 85,
		[Description("6.6. F. Neg. Entrega del Inmueble")]
		NegociacionEntregadelInmueble = 86,
		[Description("6.7. F. Neg. Finalizado Vulnerabilidad Social")]
		NegociacionFinalizadoVulnerabilidadSocial = 87,
		[Description("6.8. F. Neg. Finalizado Demanda")]
		NegociacionFinalizadoDemanda = 88,
		[Description("6.9. F. Neg. Finalizado Inviable")]
		NegociacionFinalizadoInviable = 89,

		[Description("7.0. F. Neg. Finalizado Pago de Deuda")]
		NegociacionFinalizadoPagoDeuda = 90,
		[Description("7.1. F.Neg. Finalizado Fin Tiempo Neg.")]
		NegociacionFinalizadoFinTiempoNeg = 91,
	    [Description("7.3 F. Neg Finalizado por Instrucciones")]
        NegociacionFinalizadoInstrucciones = 93,
	    [Description("7.4 Neg. Finalizada Prop. Elevada Sucursal")]
	    NegociacionFinalizadoPropElevadaSucursal = 94,
	    [Description("7.5 Neg. Finalizada Sucursal")]
        NegociacionFinalizadoSucursal = 95,
        [Description("7.6. F.Neg. Finalizado Ilocalizable")]
        NegociacionFinalizadoIlocalizable = 96,
	    [Description("7.7 F. Neg. Finalizado TPA")]
	    NegociacionFinalizadoTpa = 97,
	    [Description("7.8 F. Neg. No Acepta")]
        NegociacionFinalizadoNoAcepta = 98,

        #endregion

        #region Ordinario

        [Description("Ordinario - Recepción de Expediente")]
        OrdinarioRecepcionExpediente = 1401,
        [Description("Ordinario - Generación Expediente")]
        OrdinarioGeneracionExpediente = 1402,
        [Description("Ordinario - Presentación Demanda")]
        OrdinarioPresentacionDemanda = 1403,
        [Description("Ordinario - Tramitación en el Juzgado")]
        OrdinarioTramitacionJuzgado = 1404,
        [Description("Ordinario - Juicio")]
        OrdinarioJuicio = 1405,

	    [Description("Ordinario - Sentencia")]
        OrdinarioSentencia = 1413,

        [Description("Ordinario - Ejecución de Sentencia")]
        OrdinarioEjecucionSentencia = 1406,
        [Description("Ordinario - Auto de Admisión / Notificaciones")]
        OrdinarioAutoAdmisionNotificacion = 1407,
        [Description("Ordinario - Proceso Paralizado")]
        OrdinarioProcesoParalizado = 1408,
        [Description("Ordinario - Subasta")]
        OrdinarioSubasta = 1409,
        [Description("Ordinario - Adjudicación")]
        OrdinarioAdjudicacionDelBien = 1410,
        [Description("Ordinario - Negociación Posesión")]
        OrdinarioNegociacionPosesion = 1411,
        [Description("Ordinario - Finalización Proceso Jurídico")]
        OrdinarioFinalizacion = 1412,

        #endregion

        #region OrdinarioCs 

        [Description("Cláusula Suelo - Recepción de Expediente")]
        OrdinarioCsRecepcionExpediente = 1501,

        [Description("Cláusula Suelo - Audiencia Previa")]
        OrdinarioCsAudienciaPrevia = 1503,

        [Description("Cláusula Suelo - Juicio")]
        OrdinarioCsJuicio = 1505,

        [Description("Cláusula Suelo - Ejecución de Sentencia")]
        OrdinarioCsEjecucionSentencia = 1506,

        [Description("Cláusula Suelo - Sentencia")]
	    OrdinarioCsSentencia = 1507,

        [Description("Cláusula Suelo - Proceso Paralizado")]
        OrdinarioCsProcesoParalizado = 1508,

	    [Description("Cláusula Suelo - Acuerdo")]
        OrdinarioCsAcuerdo = 1510,

        [Description("Cláusula Suelo - Finalización Proceso Jurídico")]
        OrdinarioCsFinalizacion = 1512,
        [Description("Cláusula Suelo - Allanamiento Total")]
        OrdinarioCsAllanamientoTotal = 1513,
        [Description("Cláusula Suelo - Allanamiento Parcial")]
        OrdinarioCsAllanamientoParcial= 1514,

        [Description("Cláusula Suelo - Contestación Demanda")]
        OrdinarioCsCsContestacionDemanda = 1515,

        #endregion

        #region TomaPosesionAnticipada

        [Description("TPA - Recepción de Expediente")]
	    TpaRecepcionExpediente = 1601,
	    [Description("TPA - Finalizado")]
	    TpaFinalizado = 1608,

        #endregion

        #region JV

        [Description("JV - Recepción de Expediente")]
        JvRecepcionExpediente = 1701,
        [Description("JV - Presentación Demanda")]
        JvPresentacionDemanda = 1703,
        [Description("JV - Finalizado")]
        JvFinalizado = 1708,

        #endregion

        #region Monitorio

        [Description("MN - Recepción de Expediente")]
        MonitorioRecepcionExpediente = 201,
        [Description("MN - Presentación Demanda")]
        MonitorioPresentacionDemanda = 203,
        [Description("MN - Tramitación en el Juzgado")]
        MonitorioTramitacionJuzgado = 204,
        [Description("MN - Finalización Proceso Jurídico")]
        MonitorioFinalizacion = 208,

        #endregion

        #region Verbal

        [Description("VB - Recepción de Expediente")]
        VerbalRecepcionExpediente = 801,
        [Description("VB - Presentación Demanda")]
        VerbalPresentacionDemanda = 803,
        [Description("VB - Tramitación en el Juzgado")]
        VerbalTramitacionJuzgado = 804,
        [Description("VB - Finalización Proceso Jurídico")]
        VerbalFinalizacion = 808,

        #endregion

        #region Saneamiento

        [Description("SAN - Recepción de Expediente")]
        SaneamientoRecepcionExpediente = 2201,
        //[Description("VB - Presentación Demanda")]
        //SaneamientoPresentacionDemanda = 2203,
        //[Description("VB - Tramitación en el Juzgado")]
        //SaneamientoTramitacionJuzgado = 2204,
        [Description("SAN - Finalización Proceso Jurídico")]
        SaneamientoFinalizacion = 2208,

        #endregion

        #region Penal

        [Description("PNL - Recepción de Expediente")]
        PenalRecepcionExpediente = 1101,

        [Description("PNL - Instrucción")]
        PenalInstruccion = 1102,
        [Description("PNL - Intermedio")]
        PenalIntermedio = 1103,
        [Description("PNL - Juicio")]
        PenalJuicio = 1104,
        [Description("PNL - Recurso")]
        PenalRecurso = 1105,
        [Description("PNL - Sentencia")]
        PenalSentencia = 1106,
        [Description("PNL - Ejecución")]
        PenalEjecucion = 1107,
        [Description("PNL - Expediente Penitenciario")]
        PenalExpedientePenitenciario = 1109,

        [Description("PNL - Finalización Proceso Jurídico")]
        PenalFinalizacion = 1108,

        #endregion

        #region Fiscal

        [Description("FSC - Recepción de Expediente")]
        FiscalRecepcionExpediente = 2101,

        [Description("FSC - Finalización Proceso Jurídico")]
        FiscalFinalizacion = 2108,

        #endregion


        #region Conciliacion

        [Description("CCL - Recepción de Expediente")]
        ConciliacionRecepcionExpediente = 2301,
        [Description("CCL - Acto Conciliación")]
        ConciliacionActo = 2302,
        //[Description("CIV - Tramitación en el Juzgado")]
        //ConciliacionTramitacionJuzgado = 2004,
        [Description("CCL - Finalización Proceso Jurídico")]
        ConciliacionFinalizacion = 2308,

        #endregion

        #region JuraCuenta

        [Description("JC - Recepción de Expediente")]
        JuraCuentaRecepcionExpediente = 2401,
        [Description("JC - Tramitación")]
        JuraCuentaTramitacion = 2402,
        [Description("JC - Finalización")]
        JuraCuentaFinalizacion = 2408,

        #endregion

        #region Civil

        [Description("CIV - Recepción de Expediente")]
        CivilRecepcionExpediente = 2001,
        //[Description("CIV - Presentación Demanda")]
        //CivilPresentacionDemanda = 2003,
        //[Description("CIV - Tramitación en el Juzgado")]
        //CivilTramitacionJuzgado = 2004,
        [Description("CIV - Finalización Proceso Jurídico")]
        CivilFinalizacion = 2008,

        #endregion

        #region MercantilInmobiliario

        [Description("MI - Recepción de Expediente")]
        MercantilInmobiliarioRecepcionExpediente = 2501,
        //[Description("CIV - Presentación Demanda")]
        //MercantilInmobiliarioPresentacionDemanda = 2003,
        //[Description("CIV - Tramitación en el Juzgado")]
        //MercantilInmobiliarioTramitacionJuzgado = 2004,
        [Description("MI - Finalización")]
        MercantilInmobiliarioFinalizacion = 2508,

        #endregion

        #region Ddl

        [Description("DDL - Recepción de Expediente")]
        DdlRecepcionExpediente = 2601,
        [Description("DDL - Finalización")]
        DdlFinalizacion = 2608,

        #endregion

        #region ContenciosoAdministrativo

        [Description("CA - Recepción de Expediente")]
        ContenciosoAdministrativoRecepcionExpediente = 2701,
        [Description("CA - Finalización")]
        ContenciosoAdministrativoFinalizacion = 2708,

        #endregion

        #region ContenciosoOrdinario

        [Description("CAO - Recepción de Expediente")]
        ContenciosoOrdinarioRecepcionExpediente = 2801,
        [Description("CAO - Finalización")]
        ContenciosoOrdinarioFinalizacion = 2808,

        #endregion

        #region Cambiario

        [Description("CAMB - Recepción de Expediente")]
        CambiarioRecepcionExpediente = 701,
        //[Description("CIV - Presentación Demanda")]
        //CambiarioPresentacionDemanda = 2003,
        //[Description("CIV - Tramitación en el Juzgado")]
        //CambiarioTramitacionJuzgado = 2004,
        [Description("CAMB - Finalización")]
        CambiarioFinalizacion = 708,

        #endregion

        #region MultiDivisa

        [Description("MD - Recepción de Expediente")]
        MultiDivisaRecepcionExpediente = 2901,
        //[Description("MD - Presentación Demanda")]
        //MultiDivisaPresentacionDemanda = 2903,
        //[Description("MD - Tramitación en el Juzgado")]
        //MultiDivisaTramitacionJuzgado = 2904,
        [Description("MD - Finalización Proceso Jurídico")]
        MultiDivisaFinalizacion = 2908,

        #endregion

        #region Procura

        [Description("PRC - Recepción de Expediente")]
        ProcuraRecepcionExpediente = 3001,
        //[Description("MD - Presentación Demanda")]
        //ProcuraPresentacionDemanda = 2903,
        //[Description("MD - Tramitación en el Juzgado")]
        //ProcuraTramitacionJuzgado = 2904,
        [Description("PRC - Finalización Proceso Jurídico")]
        ProcuraFinalizacion = 3008,

        #endregion

        #region Scne

        [Description("SCNE - Recepción de Expediente")]
        ScneRecepcionExpediente = 3101,
        [Description("SCNE - Finalización")]
        ScneFinalizacion = 3108,

        #endregion

        #region Bastanteo

        [Description("Bastanteo - Recepción de Expediente")]
        BastanteoRecepcionExpediente = 3201,
        [Description("Bastanteo - Finalización")]
        BastanteoFinalizacion = 3208,

        #endregion

        #region Testamentario

        [Description("Testamentario - Recepción de Expediente")]
        TestamentarioRecepcionExpediente = 3301,
        [Description("Testamentario - Finalización")]
        TestamentarioFinalizacion = 3308,

        #endregion

        #region Tpn

        [Description("TPT - Recepción de Expediente")]
        TpnRecepcionExpediente = 3401,
        [Description("TPT - Finalización")]
        TpnFinalizacion = 3408,

        #endregion

        #region Prelitigio

        [Description("Prelitigio - Recepción de Expediente")]
        PrelitigioRecepcionExpediente = 3501,
        [Description("Prelitigio - Finalización")]
        PrelitigioFinalizacion = 3508,

        #endregion
    }

    public enum TipoFaseEstado
    {
        #region Base o Comun

        [Description("Presentación Expediente")]
        Base5001 = 1005001,
        [Description("Admisión")]
        Base5002 = 1005002,
        [Description("Citación")]
        Base5003 = 1005003,
        [Description("Auto Librar Mandamiento")]
        Base5004 = 1005004,
        [Description("Fin de Jurisdicción Voluntaria")]
        Base5005 = 1005005,

        [Description("Paralizado")]
        BaseParalizado = 1001001,

        #endregion

        #region Hipotecario

        [Description("1.1 Recepción y Revisión Expediente")]
        Hip0101RecepcionRevision = 1010101,
        [Description("1.2 Incidencia Documental")]
        Hip0102IncidenciaDocumental = 1010102,
        [Description("1.3 Preparación Demanda")]
        Hip0103PreparacionDemanda = 1010103,
        [Description("1.4 Pdte. Instrucciones del cliente")]
        Hip0104 = 1010104,
        [Description("1.5 Pdte. Poderes Procurador")]
        Hip0105 = 1010105,

        [Description("2.1 Envió Demanda A Procurador")]
        Hip0201 = 1010201,
        [Description("2.2 Presentada Demanda")]
        Hip0202PresentadaDemanda = 1010202,
        [Description("2.3 Requerimiento Previo")]
        Hip0203RequerimientoPrevio = 1010203,
        [Description("2.4 Demanda No Admitida")]
        Hip0204DemandaNoAdmitida = 1010204,
        [Description("2.5 Recurso Reposición/Apelación")]
        Hip0205RecursoReposicionApelacion = 1010205,

        [Description("3.1 Tramitación en el Juzgado")]
        Hip0301 = 1010301,
        [Description("3.2 Auto Incompleto/Erróneo")]
        Hip0302 = 1010302,

        [Description("6.0 Subasta")]
        Hip0600 = 1010600,
        [Description("6.1 Decreto convocatoria de subasta")]
        Hip0601 = 1010601,
        [Description("6.2 Subasta suspendida")]
        Hip0602 = 1010602,
        [Description("6.3 Fin de puja")]
        Hip0603 = 1010603,
        [Description("6.4 Solicitada adjudicación")]
        Hip0604 = 1010604,
        [Description("6.5 Traslado TC/LI")]
        Hip0605 = 1010605,
        [Description("6.6 Impgnación TC/LI")]
        Hip0606 = 1010606,
        [Description("6.7 Decreto aprobación TC/LI")]
        Hip0607 = 1010607,
        [Description("6.8 Pte. de consig. sobrante")]
        Hip0608 = 1010608,
        [Description("6.9 Pte. de reintrego sobrante")]
        Hip0609 = 1010609,
        [Description("6.10 Decreto de distribución sobrante")]
        Hip0610 = 1010610,
        [Description("6.11 Cesion remate")]
        Hip0611 = 1010611,
        [Description("6.12 Decreto remte / decreto adjudicicación")]
        Hip0612 = 1010612,
        [Description("6.13 Alegaciones sobre suspensión")]
        Hip0613 = 1010613,
        [Description("6.14 Reiteración de Subasta")]
        Hip0614 = 1010614,
        [Description("6.15 Pdte. Decreto Adjudicicación")]
        Hip0615 = 1010615,

        [Description("Solicitada Posesión / lanzamiento")]
        Hip0701 = 1010701,
        [Description("Acordada Posesión / lanzamiento")]
        Hip0702 = 1010702,
        [Description("Señalada Posesión / lanzamiento")]
        Hip0703 = 101073,
        [Description("Posesión +")]
        Hip0704 = 1010704,
        [Description("Sol Ley 1/2013")]
        Hip0705 = 1010705,
        [Description("Susp Ley 1/2013")]
        Hip0706 = 1010706,
        [Description("Req ocupante títulos just ocupación")]
        Hip0707 = 1010707,
        [Description("Presentado títulos justifiquen ocupación")]
        Hip0708 = 1010708,
        [Description("Sol vista 661")]
        Hip0709 = 1010709,
        [Description("Señalada vista 661")]
        Hip0710 = 1010710,
        [Description("Reconocido arrendamiento")]
        Hip0711 = 1010711,
        [Description("Suspendido por instrucciones de los gestores")]
        Hip0712 = 1010712,
        [Description("Decreto defectuoso")]
        Hip0713 = 1010713,
        [Description("Pte. sobrante")]
        Hip0714 = 1010714,
        [Description("Sol testimonio del decreto")]
        Hip0715 = 1010715,
        [Description("Expedido testimonio del decreto")]
        Hip0716 = 1010716,
        [Description("Calificación + (Testimonio inscrito)")]
        Hip0717 = 1010717,
        [Description("Calificación -: Solicitada adición")]
        Hip0718 = 1010718,
        [Description("Calificación -: Acordada adición")]
        Hip0719 = 1010719,
        [Description("Calificación -: ASA & INSCR")]
        Hip0720 = 1010720,
        [Description("Calificación -")]
        Hip0721 = 1010721,

        [Description("1. Escrito de desistimiento ")]
        Hip0801 = 1010801,
        [Description("2. Escrito de Satisfacción Extraprocesal")]
        Hip0802 = 1010802,
        [Description("3. Decreto de Archivo y terminación del procedimiento.")]
        Hip0803 = 1010803,
        [Description("4. Pendiente tramitación mandamientos de cancelación de la nota marginal.")]
        Hip0804 = 1010804,
        [Description("5. Pendiente desglose.")]
        Hip0805 = 1010805,

        [Description("Fin Jurisdicción Voluntaria")]
        Hip10905 = 1010905,

        //[Description("Hipotecario - Generación Expediente")]
        //HipotecarioGeneracionExpediente = 2,
        //[Description("Hipotecario - Presentación Demanda")]
        //HipotecarioPresentacionDemanda = 3,
        //[Description("Hipotecario - Tramitación en el Juzgado")]
        //HipotecarioTramitacionJuzgado = 4,
        //[Description("Hipotecario - Proceso Paralizado")]
        //HipotecarioParalizado = 5,
        //[Description("Hipotecario - Subasta")]
        //HipotecarioSubasta = 6,
        //[Description("Hipotecario - Adjudicación")]
        //HipotecarioAdjudicacionDelBien = 7,

        //[Description("Hipotecario - Negociación Posesión")]
        //HipotecarioNegociacionPosesion = 11175,

        //[Description("Hipotecario - Finalizado")]
        //HipotecarioFinalizado = 8,

        #endregion

        #region Concursal

        //[Description("Concursal - Fase Común")]
        //ConcursalFaseComun = 41,
        //[Description("Concursal - Fase Convenio")]
        //ConcursalFaseConvenio = 42,
        //[Description("Concursal - Fase Liquidación")]
        //ConcursalFaseLiquidacion = 43,
        //[Description("Concursal - Fase Calificación")]
        //ConcursalFaseCalificacion = 44,
        //[Description("Concursal - Finalizado")]
        //ConcursalFinalizado = 45,

        #endregion

        #region Alquiler

        [Description("Reclamación cantidad post posesión")]
        Alquiler7901 = 507901,

        //[Description("Alquiler - Generación de Expediente")]
        //AlquilerGeneracionExpediente = 74,
        //[Description("Alquiler - Presentación Demanda")]
        //AlquilerPresentacionDemanda = 75,
        //[Description("Alquiler - Tramitación Juzgado")]
        //AlquilerTramitacionJuzgado = 76,
        //[Description("Alquiler - Lanzamiento")]
        //AlquilerLanzamiento = 77,
        //[Description("Alquiler - Adjudicación del Bien (OBSOLETO)")]
        //AlquilerAdjudicacionBien = 78,
        //[Description("Alquiler - Finalizado")]
        //AlquilerFinalizado = 79,
        //[Description("Alquiler - Enervación")]
        //AlquilerEnervacion = 5100,
        //[Description("Alquiler - Proceso Paralizado")]
        //AlquilerParalizado = 5101,

        #endregion

        #region Ejecutivo

        //[Description("Ejecutivo - Recepción Expediente")]
        //EjecutivoRecepcionExpediente = 31,
        //[Description("Ejecutivo - Envío demanda al procurador")]
        //EjecutivoEnvioDemandaProcurador = 315,
        //[Description("Ejecutivo - Presentación Demanda")]
        //EjecutivoPresentacionDemanda = 32,
        //[Description("Ejecutivo - Admisión / Trámite de Embargo")]
        //EjecutivoNotificacion = 33,
        //[Description("Ejecutivo - Trámite de Embargo")]
        //EjecutivoTramiteEmbargo = 34,
        //[Description("Ejecutivo - Efectividad de Embargo")]
        //EjecutivoEfectividadEmbargo = 35,
        //[Description("Ejecutivo - Solicitus de Subasta")]
        //EjecutivoSolicitudSubasta = 36,
        //[Description("Ejecutivo - Subasta")]
        //EjecutivoSubasta = 37,

        [Description("5.1 Solicitud de Subasta")]
        Ejc0501 = 3010501,

        [Description("Envío escrito procurador")]
        Ejc32501 = 30132501,
        [Description("Presentado escrito")]
        Ejc32502 = 30132502,
        [Description("Escrito no admitido")]
        Ejc32503 = 30132503,

        [Description("Acuerdo")]
        Ejc39001 = 30139001,
        [Description("Carencia sobrevenida")]
        Ejc39002 = 30139002,
        [Description("Desistimiento actor")]
        Ejc39003 = 30139003,
        [Description("Sentencia firme")]
        Ejc39004 = 30139004,

        #endregion

        #region Negociacion

        //[Description("Negociación - Pendiente Teléfono")]
        //NegociacionPendienteTelefono = 47,
        //[Description("1. Negociación.Pdte Contacto")]
        //NegociacionPdteContacto = 48,
        //[Description("2. Negociación.Teléfono Erróneo")]
        //NegociacionTelefonoErroneo = 49,

        //[Description("3.1. Negociación.En Trámite - Pdte Propuesta")]
        //NegociacionEnTramitePdtePropuesta = 50,
        //[Description("3.2. Negociación.En Trámite - Rehabilitación")]
        //NegociacionEnTramiteRehabilitacion = 51,
        //[Description("3.3. Negociación.En Trámite - Adecuación")]
        //NegociacionEnTramiteAdecuacion = 52,
        //[Description("3.4. Negociación.En Trámite-Adecuación Sostenible")]
        //NegociacionEnTramiteAdecuacionSostenible = 53,
        //[Description("3.5. Negociación.En Trámite-Cancelación")]
        //NegociacionEnTramiteCancelacion = 54,
        //[Description("3.6. Negociación.En Trámite Cancel. con quita")]
        //NegociacionEnTramiteCancelConQuita = 55,
        //[Description("3.7. Negociación.En Trámite - Venta")]
        //NegociacionEnTramiteVenta = 56,
        //[Description("3.8. Negociación.En Trámite Prop. Elevada/Est.")]
        //NegociacionEnTramitePropElevada = 57,
        //[Description("3.9. Negociación.En Trámite - Dación en Pago")]
        //NegociacionEnTramiteDacionPago = 58,
        //[Description("4.1. Negociación. Sucursal-Rehabilitación")]
        //NegociacionSucursalRehabilitacion = 59,
        //[Description("4.2. Negociación.Sucursal - Adecuación")]
        //NegociacionSucursalAdecuacion = 60,
        //[Description("4.3. Negociación.Sucursal-Adecuación Sostenible")]
        //NegociacionSucursalAdecuacionSostenible = 61,
        //[Description("4.4. Negociación.Sucursal-Cancelación")]
        //NegociacionSucursalCancelacion = 62,
        //[Description("4.5. Negociación.Sucursal Cancel. con quita")]
        //NegociacionSucursalCancelConquita = 63,
        //[Description("4.6. Negociación.Sucursal - Venta")]
        //NegociacionSucursalVenta = 64,
        //[Description("4.7. Negociación.Sucursal - Dación en Pago")]
        //NegociacionSucursalDacionenPago = 65,
        //[Description("5.1. Negociación.Finalizado - Inviable")]
        //NegociacionSucursalInviable = 66,
        //[Description("5.2. Negociación.Finalizado-Desistido/Paral.")]
        //NegociacionSucursalDesistidoParal = 67,
        //[Description("5.3. Negociación.Finalizado-Subasta")]
        //NegociacionSucursalSubasta = 68,
        //[Description("5.4. Negociación.Finalizado - Vendido a Fondo")]
        //NegociacionSucursalVendidoaFondo = 69,
        //[Description("5.5. Negociación. Finalizado-Propuesta Denegada")]
        //NegociacionSucursalFinalizadoPropuestaDenegada = 70,
        //[Description("5.6. Negociación.Finalizado-Propuesta Aceptada")]
        //NegociacionSucursalFinalizadoPropuestaAceptada = 71,
        //[Description("6.1. F. Neg. Pago Parcial")]
        //NegociacionPagoParcial = 80,
        //[Description("6.2. F. Neg. Pago Total")]
        //NegociacionPagoTotal = 81,
        //[Description("6.3. F. Neg. Condonación Parcial")]
        //NegociacionCondonacionParcial = 82,
        //[Description("6.3. F. Neg. Condonación Total")]
        //NegociacionCondonacionTotal = 83,
        //[Description("6.4. F. Neg. Deuda Pagada Parcial")]
        //NegociacionDeudaPagadaParcial = 84,
        //[Description("6.5. F. Neg. Deuda Pagada Total")]
        //NegociacionDeudaPagadaTotal = 85,
        //[Description("6.6. F. Neg. Entrega del Inmueble")]
        //NegociacionEntregadelInmueble = 86,
        //[Description("6.7. F. Neg. Finalizado Vulnerabilidad Social")]
        //NegociacionFinalizadoVulnerabilidadSocial = 87,
        //[Description("6.8. F. Neg. Finalizado Demanda")]
        //NegociacionFinalizadoDemanda = 88,
        //[Description("6.9. F. Neg. Finalizado Inviable")]
        //NegociacionFinalizadoInviable = 89,
        //[Description("7.0. F. Neg. Finalizado Pago de Deuda")]
        //NegociacionFinalizadoPagoDeuda = 90,
        //[Description("7.1. F.Neg. Finalizado Fin Tiempo Neg.")]
        //NegociacionFinalizadoFinTiempoNeg = 91,

        #endregion

        #region Ordinario

        //[Description("Ordinario - Recepción de Expediente")]
        //OrdinarioRecepcionExpediente = 1401,
        //[Description("Ordinario - Generación Expediente")]
        //OrdinarioGeneracionExpediente = 1402,
        //[Description("Ordinario - Presentación Demanda")]
        //OrdinarioPresentacionDemanda = 1403,
        //[Description("Ordinario - Tramitación en el Juzgado")]
        //OrdinarioTramitacionJuzgado = 1404,
        //[Description("Ordinario - Juicio")]
        //OrdinarioJuicio = 1405,
        //[Description("Ordinario - Ejecución de Sentencia")]
        //OrdinarioEjecucionSentencia = 1406,
        //[Description("Ordinario - Auto de Admisión / Notificaciones")]
        //OrdinarioAutoAdmisionNotificacion = 1407,
        //[Description("Ordinario - Proceso Paralizado")]
        //OrdinarioProcesoParalizado = 1408,
        //[Description("Ordinario - Subasta")]
        //OrdinarioSubasta = 1409,
        //[Description("Ordinario - Adjudicación")]
        //OrdinarioAdjudicacionDelBien = 1410,
        //[Description("Ordinario - Negociación Posesión")]
        //OrdinarioNegociacionPosesion = 1411,
        //[Description("Ordinario - Finalización Proceso Jurídico")]
        //OrdinarioFinalizacion = 1412,

        #endregion

        #region OrdinarioCs

        [Description("Acuerdo previo a contestación")]
        Ocs0101 = 1510101,
        [Description("Acuerdo")]
        Ocs0102 = 1510102,
        [Description("Solicitud suspensión")]
        Ocs0103 = 1510103,

        [Description("Pendiente archivo")]
        Ocs0105 = 1510105,
        [Description("Pendiente citación")]
        Ocs0106 = 1510106,

        [Description("Pendiente señalamiento juicio")]
        Ocs0301 = 1500301,
        [Description("Pendiente sentencia")]
        Ocs0302 = 1500302,

        [Description("Suspensión juicio/pendiente nuevo señalamiento")]
        Ocs0501 = 1500501,

        [Description("Demanda de ejecución presentada")]
        Ocs0601 = 150601,
        [Description("Admisión de la ejecución")]
        Ocs0602 = 150602,
        [Description("Oposición a la ejecución")]
        Ocs0603 = 150603,
        [Description("Cumplimiento de ejecución")]
        Ocs0604 = 150604,


        [Description("Pendiente de Escrito")]
        Ocs1301 = 1510301,
        [Description("Pendiente Sentencia")]
        Ocs1302 = 1510302,
        [Description("Pendiente Apelación")]
        Ocs1303 = 1510303,

        [Description("Pendiente de señalamiento AP")]
        Ocs1401 = 151401,

        [Description("Sentencia con costas")]
        Ocs0707 = 150707,
        [Description("Sentencia sin costas")]
        Ocs0701 = 150701,
        [Description("Acuerdo pago costas")]
        Ocs0702 = 150702,
        [Description("Traslado de costas e intereses")]
        Ocs0703 = 150703,
        [Description("Impugnación")]
        Ocs0704 = 150704,
        [Description("Decreto aprobación costas / intereses")]
        Ocs0705 = 150705,
        [Description("Pago Judicial")]
        Ocs0706 = 150706,
        [Description("Apelación")]
        Ocs0708 = 150708,
        [Description("Oposición a la Apelación")]
        Ocs0709 = 150709,
        [Description("Sentencia Audiencia Provincial")]
        Ocs0710 = 150710,




        [Description("Suspensión mutuo acuerdo")]
        Ocs0801 = 150801,
        [Description("Suspensión vía RDL")]
        Ocs0802 = 150802,

        [Description("Acuerdo")]
        Ocs12001 = 1512001,
        [Description("Carencia sobrevenida")]
        Ocs12002 = 1512002,
        [Description("Desistimiento actor")]
        Ocs12003 = 1512003,
        [Description("Sentencia firme")]
        Ocs12004 = 1512004,
        [Description("Sentencia firme/pago judicial")]
        Ocs12005 = 1512005,


        //[Description("OrdinarioCs - Recepción de Expediente")]
        //OrdinarioCsRecepcionExpediente = 1501,
        //[Description("OrdinarioCs - Generación Expediente")]
        //OrdinarioCsGeneracionExpediente = 1502,
        //[Description("OrdinarioCs - Presentación Demanda")]
        //OrdinarioCsPresentacionDemanda = 1503,
        //[Description("OrdinarioCs - Tramitación en el Juzgado")]
        //OrdinarioCsTramitacionJuzgado = 1504,
        //[Description("OrdinarioCs - Juicio")]
        //OrdinarioCsJuicio = 1505,
        //[Description("OrdinarioCs - Ejecución de Sentencia")]
        //OrdinarioCsEjecucionSentencia = 1506,
        //[Description("OrdinarioCs - Auto de Admisión / Notificaciones")]
        //OrdinarioCsAutoAdmisionNotificacion = 1507,
        //[Description("OrdinarioCs - Proceso Paralizado")]
        //OrdinarioCsProcesoParalizado = 1508,
        //[Description("OrdinarioCs - Subasta")]
        //OrdinarioCsSubasta = 1509,
        //[Description("OrdinarioCs - Adjudicación")]
        //OrdinarioCsAdjudicacionDelBien = 1510,
        //[Description("OrdinarioCs - Negociación Posesión")]
        //OrdinarioCsNegociacionPosesion = 1511,
        //[Description("OrdinarioCs - Finalización Proceso Jurídico")]
        //OrdinarioCsFinalizacion = 1512,

        #endregion

        #region Conciliacion

        [Description("Señalamiento Vista")]
        Conciliacion0201 = 230201,

        [Description("Celebración Vista")]
        Conciliacion0202 = 230202,

        [Description("Suspendida Vista")]
        Conciliacion0203 = 230203,

        //[Description("Alquiler - Generación de Expediente")]
        //AlquilerGeneracionExpediente = 74,
        //[Description("Alquiler - Presentación Demanda")]
        //AlquilerPresentacionDemanda = 75,
        //[Description("Alquiler - Tramitación Juzgado")]
        //AlquilerTramitacionJuzgado = 76,
        //[Description("Alquiler - Lanzamiento")]
        //AlquilerLanzamiento = 77,
        //[Description("Alquiler - Adjudicación del Bien (OBSOLETO)")]
        //AlquilerAdjudicacionBien = 78,
        //[Description("Alquiler - Finalizado")]
        //AlquilerFinalizado = 79,
        //[Description("Alquiler - Enervación")]
        //AlquilerEnervacion = 5100,
        //[Description("Alquiler - Proceso Paralizado")]
        //AlquilerParalizado = 5101,

        #endregion
    }

    public enum TipoDecretoArchivo
    {
        [Description("Pago")]
        Pago = 1,
        [Description("Sin Pago / Sin Oposición")]
        SinPago = 2,
        [Description("Traslado Oposición")]
        TrasladoOposicion = 3,
    }

}
