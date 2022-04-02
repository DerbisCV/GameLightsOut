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

        #region Alquiler - Presentación de Demanda
        [Description("Alquiler - Tasas Pagadas")]
        AlqDemandaTasasPagadas = -541,
        [Description("Alquiler - Presentación Demanda")]
        AlqLanzamientoPresentacionDemanda = -542,
        [Description("Alquiler - No Admisión")]
        AlqLanzamientoNoAdmision = -543,
        [Description("Alquiler - Apelación")]
        AlqLanzamientoApelacion = -544,
        [Description("Alquiler - Auto Ejecución")]
        AlqLanzamientoAutoEjecucion = -545,
        #endregion

        #region Alquiler - Tramitacion Proceso Juzgado

        [Description("Alquiler - Ocupantes")]
        AlqJuz_Ocupantes = 561,
        [Description("Alquiler - Decreto Admisión")]
        AlqJuz_DecretoAdmision = 562,
        #endregion

        #region Alquiler - Lanzamiento
        [Description("Alquiler - 1ra Celebración")]
        AlqLanzamiento_1raCelebracion = 571,
        [Description("Alquiler - 2da Celebración")]
        AlqLanzamiento_2daCelebracion = 572,
        [Description("Alquiler - Acta")]
        AlqLanzamiento_Acta = 573,
        [Description("Alquiler - Lanzamiento Oposición")]
        AlqLanzamiento_Oposicion = 574,
        [Description("Alquiler - Lanzamiento Oposición Vista")]
        AlqLanzamiento_OposicionVista = -575,
        [Description("Alquiler - Lanzamiento Oposición Resolución")]
        AlqLanzamiento_OposicionResolucion = 576,
        #endregion

        #endregion

        #region Ejecutivo

        #region Ejecutivo - Demanda
        [Description("Ejecutivo - Demanda - Tasas Pagadas")]
        EjcDemanda_TasasPagadas = 321,
        [Description("Ejecutivo - Demanda - Presentación Demanda")]
        EjcDemanda_PresentacionDemanda = 322,
        [Description("Ejecutivo - Demanda - No Admisión")]
        EjcDemanda_NoAdmision = 323,
        [Description("Ejecutivo - Demanda - Apelación")]
        EjcDemanda_Apelacion = 324,
        #endregion

        #region Notificación / Trámite Embargo
        [Description("Ejecutivo - Notificación - Auto Ejecución")]
        EjcNotificacion_AutoEjecucion = 331,
        [Description("Ejecutivo - Notificación - Oposición")]
        EjcNotificacion_Oposicion = 332,
        [Description("Ejecutivo - Notificación - Oposición Vista")]
        EjcNotificacion_OposicionVista = 333,
        [Description("Ejecutivo - Notificación - Oposición Resolución")]
        EjcNotificacion_OposicionResolucion = 334,
        [Description("Ejecutivo - Notificación - Requerimiento Pago")]
        EjcNotificacion_RequerimientoPago = 335,

        [Description("Ejecutivo - Trámite Embargo - Averiguación")]
        EjcTramiteEmbargo_Averiguacion = 341,
        [Description("Ejecutivo - Trámite Embargo - Decreto Embargo")]
        EjcTramiteEmbargo_DecretoEmbargo = 342,
        #endregion

        #region Sol. Subasta / Subasta
        [Description("Ejecutivo - Sol. Subasta - Solicitud")]
        EjcSolSubasta_Solicitud = 361,

        [Description("Ejecutivo - Subasta - 1ª Celebración")]
        EjcSubasta_Celebracion1 = 371,
        [Description("Ejecutivo - Subasta - 2ª Celebración")]
        EjcSubasta_Celebracion2 = 372,
        [Description("Ejecutivo - Subasta - Acta")]
        EjcSubasta_Acta = 373,
        [Description("Ejecutivo - Subasta - Mandamiento Pago")]
        EjcSubasta_MandamientoPago = 374,
        [Description("Ejecutivo - Subasta - Cesión Remate")]
        EjcSubasta_CesionRemate = 375,
        [Description("Ejecutivo - Subasta - Liquidación Interéses")]
        EjcSubasta_LiquidacionIntereses = 376,
        [Description("Ejecutivo - Subasta - Oposición")]
        EjcSubasta_Oposicion = 377,
        [Description("Ejecutivo - Subasta - Oposición Vista")]
        EjcSubasta_OposicionVista = 378,
        [Description("Ejecutivo - Subasta - Oposición Resolución")]
        EjcSubasta_OposicionResolucion = 379,
        #endregion

        #region Adjudicación
        [Description("Ejecutivo - Adjudicación - Decreto")]
        EjcAdjudicacion_Decreto = 381,
        [Description("Ejecutivo - Adjudicación - Testimonio")]
        EjcAdjudicacion_Testimonio = 382,
        [Description("Ejecutivo - Adjudicación - ITP")]
        EjcAdjudicacion_ITP = 383,
        [Description("Ejecutivo - Adjudicación - Inscripción")]
        EjcAdjudicacion_Inscripcion = 384,
        [Description("Ejecutivo - Adjudicación - Posesión")]
        EjcAdjudicacion_Posesion = 385,
        [Description("Ejecutivo - Adjudicación - Do")]
        EjcAdjudicacion_Do = 386,
        [Description("Ejecutivo - Adjudicación - Ocupantes Vista")]
        EjcAdjudicacion_OcupantesVista = 387,
        [Description("Ejecutivo - Adjudicación - Ocupantes")]
        EjcAdjudicacion_Ocupantes = 388,
        #endregion

        #endregion

    }
}