using System.ComponentModel;

namespace Solvtio.Models
{
    public enum TipoDocumento
    {
        #region Hipotecario
        [Description("No lo se")]
        NoLoSe = 1,
        #endregion

        #region Alquiler

        #region Alquiler - Presentaci�n de Demanda
        [Description("Alquiler - Tasas Pagadas")]
        AlqDemandaTasasPagadas = -541,
        [Description("Alquiler - Presentaci�n Demanda")]
        AlqLanzamientoPresentacionDemanda = -542,
        [Description("Alquiler - No Admisi�n")]
        AlqLanzamientoNoAdmision = -543,
        [Description("Alquiler - Apelaci�n")]
        AlqLanzamientoApelacion = -544,
        [Description("Alquiler - Auto Ejecuci�n")]
        AlqLanzamientoAutoEjecucion = -545,
        #endregion

        #region Alquiler - Tramitacion Proceso Juzgado

        [Description("Alquiler - Ocupantes")]
        AlqJuz_Ocupantes = 561,
        [Description("Alquiler - Decreto Admisi�n")]
        AlqJuz_DecretoAdmision = 562,
        #endregion

        #region Alquiler - Lanzamiento
        [Description("Alquiler - 1ra Celebraci�n")]
        AlqLanzamiento_1raCelebracion = 571,
        [Description("Alquiler - 2da Celebraci�n")]
        AlqLanzamiento_2daCelebracion = 572,
        [Description("Alquiler - Acta")]
        AlqLanzamiento_Acta = 573,
        [Description("Alquiler - Lanzamiento Oposici�n")]
        AlqLanzamiento_Oposicion = 574,
        [Description("Alquiler - Lanzamiento Oposici�n Vista")]
        AlqLanzamiento_OposicionVista = -575,
        [Description("Alquiler - Lanzamiento Oposici�n Resoluci�n")]
        AlqLanzamiento_OposicionResolucion = 576,
        #endregion

        #endregion

        #region Ejecutivo

        #region Ejecutivo - Demanda
        [Description("Ejecutivo - Demanda - Tasas Pagadas")]
        EjcDemanda_TasasPagadas = 321,
        [Description("Ejecutivo - Demanda - Presentaci�n Demanda")]
        EjcDemanda_PresentacionDemanda = 322,
        [Description("Ejecutivo - Demanda - No Admisi�n")]
        EjcDemanda_NoAdmision = 323,
        [Description("Ejecutivo - Demanda - Apelaci�n")]
        EjcDemanda_Apelacion = 324,
        #endregion

        #region Notificaci�n / Tr�mite Embargo
        [Description("Ejecutivo - Notificaci�n - Auto Ejecuci�n")]
        EjcNotificacion_AutoEjecucion = 331,
        [Description("Ejecutivo - Notificaci�n - Oposici�n")]
        EjcNotificacion_Oposicion = 332,
        [Description("Ejecutivo - Notificaci�n - Oposici�n Vista")]
        EjcNotificacion_OposicionVista = 333,
        [Description("Ejecutivo - Notificaci�n - Oposici�n Resoluci�n")]
        EjcNotificacion_OposicionResolucion = 334,
        [Description("Ejecutivo - Notificaci�n - Requerimiento Pago")]
        EjcNotificacion_RequerimientoPago = 335,

        [Description("Ejecutivo - Tr�mite Embargo - Averiguaci�n")]
        EjcTramiteEmbargo_Averiguacion = 341,
        [Description("Ejecutivo - Tr�mite Embargo - Decreto Embargo")]
        EjcTramiteEmbargo_DecretoEmbargo = 342,
        #endregion

        #region Sol. Subasta / Subasta
        [Description("Ejecutivo - Sol. Subasta - Solicitud")]
        EjcSolSubasta_Solicitud = 361,

        [Description("Ejecutivo - Subasta - 1� Celebraci�n")]
        EjcSubasta_Celebracion1 = 371,
        [Description("Ejecutivo - Subasta - 2� Celebraci�n")]
        EjcSubasta_Celebracion2 = 372,
        [Description("Ejecutivo - Subasta - Acta")]
        EjcSubasta_Acta = 373,
        [Description("Ejecutivo - Subasta - Mandamiento Pago")]
        EjcSubasta_MandamientoPago = 374,
        [Description("Ejecutivo - Subasta - Cesi�n Remate")]
        EjcSubasta_CesionRemate = 375,
        [Description("Ejecutivo - Subasta - Liquidaci�n Inter�ses")]
        EjcSubasta_LiquidacionIntereses = 376,
        [Description("Ejecutivo - Subasta - Oposici�n")]
        EjcSubasta_Oposicion = 377,
        [Description("Ejecutivo - Subasta - Oposici�n Vista")]
        EjcSubasta_OposicionVista = 378,
        [Description("Ejecutivo - Subasta - Oposici�n Resoluci�n")]
        EjcSubasta_OposicionResolucion = 379,
        #endregion

        #region Adjudicaci�n
        [Description("Ejecutivo - Adjudicaci�n - Decreto")]
        EjcAdjudicacion_Decreto = 381,
        [Description("Ejecutivo - Adjudicaci�n - Testimonio")]
        EjcAdjudicacion_Testimonio = 382,
        [Description("Ejecutivo - Adjudicaci�n - ITP")]
        EjcAdjudicacion_ITP = 383,
        [Description("Ejecutivo - Adjudicaci�n - Inscripci�n")]
        EjcAdjudicacion_Inscripcion = 384,
        [Description("Ejecutivo - Adjudicaci�n - Posesi�n")]
        EjcAdjudicacion_Posesion = 385,
        [Description("Ejecutivo - Adjudicaci�n - Do")]
        EjcAdjudicacion_Do = 386,
        [Description("Ejecutivo - Adjudicaci�n - Ocupantes Vista")]
        EjcAdjudicacion_OcupantesVista = 387,
        [Description("Ejecutivo - Adjudicaci�n - Ocupantes")]
        EjcAdjudicacion_Ocupantes = 388,
        #endregion

        #endregion

    }
}