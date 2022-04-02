using Solvtio.Common;
using Solvtio.Common;
using Solvtio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solvtio.Models.Common
{
    public static class QbaSolvtioEnum
    {

        #region Utilidades para clientes codigos

        public static bool EsClienteAltamira(this int idCliente)
        {
            var lst = new List<int> { 44, 79, 81, 91, 92 };
            return lst.Contains(idCliente);
        }
        public static bool EsClienteAzzam(this int idCliente)
        {
            return (new List<int> { 83, 115 }).Contains(idCliente);
        }
        public static bool EsClienteSolvia(this int idCliente)
        {
            return (new List<int> { 14, 15, 36, 42, 57, 96  }).Contains(idCliente);
        }
        public static bool EsClienteSintraAltamira(this int idCliente)
        {
            return idCliente == 91;
        }
        public static bool EsClienteVoyagerAltamira(this int idCliente) //VOYAGER- ALTAMIRA
        {
            return idCliente == 79;
        }

        #endregion

        public static bool EsDeFacturacion(this TipoIndicadorQa tipoIndicadorQa)
        {
            return tipoIndicadorQa.GetDescription().Contains("Factura");
        }
        public static bool EsDeNegociacion(this TipoIndicadorQa tipoIndicadorQa)
        {
            var idTipoIndicador = (int)tipoIndicadorQa;
            return idTipoIndicador >= 1300 && idTipoIndicador <= 1399;
        }

        public static string GetColor(this CategoryColor catColor)
        {
            //if (!catColor.HasValue) return String.Empty;

            switch (catColor)
            {
                case CategoryColor.None:
                    return "#FFF";
                case CategoryColor.Green:
                    return "#78CD51";
                case CategoryColor.Blue:
                    return "#58C9F3";
                case CategoryColor.Yellow:
                    return "#F1C500";
                case CategoryColor.Red:
                    return "#FF6C60";
                case CategoryColor.Gray:
                    return "#BEC3C7";
                default:
                    return "#FFF";
            }
        }

        public static HitoFacturacionValue? GetHitoFacturacion(this TipoIndicadorQa indicador)
        {
            return
                indicador == TipoIndicadorQa.FacturaHito1 ? HitoFacturacionValue.Hito1 :
                indicador == TipoIndicadorQa.FacturaHito2 ? HitoFacturacionValue.Hito2 :
                indicador == TipoIndicadorQa.FacturaHito3 ? HitoFacturacionValue.Hito3 :
                indicador == TipoIndicadorQa.FacturaHito4 ? HitoFacturacionValue.Hito4 :
                indicador == TipoIndicadorQa.FacturaHito5 ? HitoFacturacionValue.Hito5 :
                indicador == TipoIndicadorQa.FacturaHito6 ? HitoFacturacionValue.Hito6 :

            #region Ordinario

                indicador == TipoIndicadorQa.OrdinarioFacturasHito1Caixa ? HitoFacturacionValue.OrdinarioHito1 :

            #endregion

            #region OrdinarioCs

                indicador == TipoIndicadorQa.OrdinarioCsFacturasBancoPopularHito1 ? HitoFacturacionValue.OrdinarioCsHito1 :
                indicador == TipoIndicadorQa.OrdinarioCsFacturasBancoPopularHito2
                    || indicador == TipoIndicadorQa.OrdinarioCsFacturasHito2PendienteFinalizar
                    ? HitoFacturacionValue.OrdinarioCsHito2 :

            #endregion

            #region Hipotecario



                indicador == TipoIndicadorQa.HipotecarioFacturaAlisedaNoVeniadoHito1
                    || indicador == TipoIndicadorQa.HipotecarioFacturaAlisedaVeniadoHito1
                    || indicador == TipoIndicadorQa.HipotecarioFacturaSolviaHito1
                    || indicador == TipoIndicadorQa.HipotecarioFacturaSabadellHito1
                    || indicador == TipoIndicadorQa.HipotecarioFacturaAnticipaHito1
                    || indicador == TipoIndicadorQa.HipotecarioFacturaSarebHito1
                    || indicador == TipoIndicadorQa.HipotecarioFacturaPostEjcHito1
                    || indicador == TipoIndicadorQa.HipotecarioFacturaBankiaHito1
                    || indicador == TipoIndicadorQa.HipotecarioFacturaAlisedaNoVeniadoHito1
                    || indicador == TipoIndicadorQa.HipotecarioFacturaAlisedaVeniadoHito1
                    || indicador == TipoIndicadorQa.HipotecarioFacturaAbancaHito1
                    || indicador == TipoIndicadorQa.HipotecarioFacturaVoyagerAltamiraNoVeniadoHito1
                    || indicador == TipoIndicadorQa.HipotecarioFacturaVoyagerAltamiraVeniadoHito1
                    ? HitoFacturacionValue.HipotecarioHito1 :

                indicador == TipoIndicadorQa.HipotecarioFacturaAlisedaNoVeniadoHito2
                    || indicador == TipoIndicadorQa.HipotecarioFacturaAlisedaVeniadoHito2
                    || indicador == TipoIndicadorQa.HipotecarioFacturaSolviaHito2
                    || indicador == TipoIndicadorQa.HipotecarioFacturaSabadellHito2
                    || indicador == TipoIndicadorQa.HipotecarioFacturaAnticipaHito2
                    || indicador == TipoIndicadorQa.HipotecarioFacturaSarebHito2
                    || indicador == TipoIndicadorQa.HipotecarioFacturaBankiaHito2a
                    || indicador == TipoIndicadorQa.HipotecarioFacturaBankiaHito2b
                    || indicador == TipoIndicadorQa.HipotecarioFacturaAbancaHito2
                    || indicador == TipoIndicadorQa.HipotecarioFacturaAlisedaNoVeniadoHito2
                    || indicador == TipoIndicadorQa.HipotecarioFacturaAlisedaVeniadoHito2
                    || indicador == TipoIndicadorQa.HipotecarioFacturaVoyagerAltamiraNoVeniadoHito2
                    ? HitoFacturacionValue.HipotecarioHito2 :

                indicador == TipoIndicadorQa.HipotecarioFacturaSolviaHito3
                    || indicador == TipoIndicadorQa.HipotecarioFacturaSabadellHito3
                    ? HitoFacturacionValue.HipotecarioHito3 :

                indicador == TipoIndicadorQa.HipotecarioFacturaVoyagerAltamiraNoVeniadoHitoFinalizacion
                    || indicador == TipoIndicadorQa.HipotecarioFacturaVoyagerAltamiraVeniadoHitoFinalizacion
                    ? HitoFacturacionValue.HipotecarioHito4 :

            #endregion

            #region Alquiler

                indicador == TipoIndicadorQa.AlquilerFacturaAltamiraHito1 ||
                indicador == TipoIndicadorQa.AlquilerFacturaAhoraAssetManagementHito1 ||
                //indicador == TipoIndicadorQa.AlquilerFacturaLuri6Hito1 ||
                indicador == TipoIndicadorQa.AlquilerFacturaLlogataliaHito1 ||
                indicador == TipoIndicadorQa.AlquilerFacturaAlisedaHito1 ||
                indicador == TipoIndicadorQa.AlquilerFacturaFidereHito1 ||
                indicador == TipoIndicadorQa.AlquilerFacturaMerlinRetailHito1 ||
                indicador == TipoIndicadorQa.AlquilerFacturaAnticipaHito1 ||
                //indicador == TipoIndicadorQa.AlquilerFacturaAnticipaHito1_Finalizado ||
                indicador == TipoIndicadorQa.AlquilerFacturaEjcAnticipaHito1 ||
                indicador == TipoIndicadorQa.AlquilerFacturaAzzamHito1 ||
                indicador == TipoIndicadorQa.AlquilerFacturaEjcAzzamHito1 ||
                indicador == TipoIndicadorQa.AlquilerFacturaHomesHito1 ||
                indicador == TipoIndicadorQa.AlquilerFacturaEjcHomesHito1 ||
                indicador == TipoIndicadorQa.AlquilerFacturaSolviaHotelesHito1
                ? HitoFacturacionValue.AlquilerHito1 :

                indicador == TipoIndicadorQa.AlquilerFacturaLlogataliaHito2 ||
                indicador == TipoIndicadorQa.AlquilerFacturaAlisedaHito2 ||
                indicador == TipoIndicadorQa.AlquilerFacturaFidereHito2 ||
                indicador == TipoIndicadorQa.AlquilerFacturaMerlinRetailHito2 ||
                indicador == TipoIndicadorQa.AlquilerFacturaAnticipaHito2 ||
                indicador == TipoIndicadorQa.AlquilerFacturaAhoraAssetManagementHito2 ||
                //indicador == TipoIndicadorQa.AlquilerFacturaAnticipaHito2_SinVista_0_120 ||
                //indicador == TipoIndicadorQa.AlquilerFacturaAnticipaHito2_ConVista_121_180 ||
                //indicador == TipoIndicadorQa.AlquilerFacturaAnticipaHito2_SinVista_121_180 ||
                //indicador == TipoIndicadorQa.AlquilerFacturaAnticipaHito2_ConVista_181 ||
                //indicador == TipoIndicadorQa.AlquilerFacturaAnticipaHito2_SinVista_181 ||
                indicador == TipoIndicadorQa.AlquilerFacturaAzzamHito2 ||
                indicador == TipoIndicadorQa.AlquilerFacturaHomesHito2 ||
                indicador == TipoIndicadorQa.AlquilerFacturaSolviaHotelesHito2
                ? HitoFacturacionValue.AlquilerHito2 :

                //indicador == TipoIndicadorQa.AlquilerFacturaAnticipaHito3
                //? HitoFacturacionValue.AlquilerHito3 :

                indicador == TipoIndicadorQa.AlquilerFacturaEjcAltamiraHito1
                //indicador == TipoIndicadorQa.AlquilerFacturaEjcLuri4Hito1 ||
                //indicador == TipoIndicadorQa.AlquilerFacturaEjcLuri6Hito1
                || indicador == TipoIndicadorQa.AlquilerFacturaEjcLlogataliaHito1
                || indicador == TipoIndicadorQa.AlquilerFacturaEjcAlisedaHito1
                || indicador == TipoIndicadorQa.AlquilerFacturaEjcFidereHito1
                || indicador == TipoIndicadorQa.AlquilerFacturaEjcMerlinRetailHito1
                || indicador == TipoIndicadorQa.AlquilerFacturaEjcSolviaHotelesHito1
                ? HitoFacturacionValue.EjecutivoPresentacionDemandaVinculadoAlquiler :

            #endregion

            #region Monitorio

                indicador == TipoIndicadorQa.MonitorioFacturaHito1 ? HitoFacturacionValue.MonitorioHito1 :

            #endregion

            #region Conciliacion

                indicador == TipoIndicadorQa.ConciliacionFacturasHito1Caixa ? HitoFacturacionValue.ConciliacionHito1 :

            #endregion

            #region Procura

                indicador == TipoIndicadorQa.ProcuraFacturasHito1 ? HitoFacturacionValue.ProcuraHito1 :

            #endregion

            #region JC

                indicador == TipoIndicadorQa.JcFacturasPendientesHito1 ? HitoFacturacionValue.Hito1 :
                indicador == TipoIndicadorQa.JcFacturasPendientesHito1ConHito2 ? HitoFacturacionValue.Hito1 :
                indicador == TipoIndicadorQa.JcFacturasPendientesHito2 ? HitoFacturacionValue.Hito2 :

            #endregion

            #region mYc

                indicador == TipoIndicadorQa.MyCFacturasPendientesHito1 ? HitoFacturacionValue.Hito1 :
                indicador == TipoIndicadorQa.MyCFacturasAbanca52 ? HitoFacturacionValue.Hito2 :

            #endregion

                (HitoFacturacionValue?)null;
        }

        public static List<KeyValue> GetListTipoFaseEstado(this ExpedienteEstadoTipo estadoTipo)
        {
            switch (estadoTipo)
            {
                #region Hipotecario

                case ExpedienteEstadoTipo.RecepcionExpediente:
                    return GetListTipoFaseEstado(1);

                case ExpedienteEstadoTipo.HipotecarioGeneracionExpediente:
                    break;
                case ExpedienteEstadoTipo.HipotecarioJurisdiccionVoluntaria:
                    return new List<KeyValue>
                    {
                        TipoFaseEstado.Hip0102IncidenciaDocumental.GetKeyValue(),
                        TipoFaseEstado.Hip0104.GetKeyValue(),
                        TipoFaseEstado.Hip10905.GetKeyValue(),
                    };
                case ExpedienteEstadoTipo.HipotecarioPresentacionDemanda:
                    return GetListTipoFaseEstado(3);

                case ExpedienteEstadoTipo.HipotecarioTramitacionSubasta:
                    return new List<KeyValue>
                    {
                        TipoFaseEstado.Hip0301.GetKeyValue(),
                        TipoFaseEstado.Hip0302.GetKeyValue(),

                        TipoFaseEstado.Hip0600.GetKeyValue(),
                        TipoFaseEstado.Hip0601.GetKeyValue(),
                        TipoFaseEstado.Hip0602.GetKeyValue(),
                        TipoFaseEstado.Hip0603.GetKeyValue(),
                        TipoFaseEstado.Hip0604.GetKeyValue(),
                        TipoFaseEstado.Hip0605.GetKeyValue(),
                        TipoFaseEstado.Hip0606.GetKeyValue(),
                        TipoFaseEstado.Hip0607.GetKeyValue(),
                        TipoFaseEstado.Hip0608.GetKeyValue(),
                        TipoFaseEstado.Hip0609.GetKeyValue(),
                        TipoFaseEstado.Hip0610.GetKeyValue(),
                        TipoFaseEstado.Hip0611.GetKeyValue(),
                        TipoFaseEstado.Hip0612.GetKeyValue(),
                        TipoFaseEstado.Hip0613.GetKeyValue(),
                        //TipoFaseEstado.Hip0614.GetKeyValue(),
                        TipoFaseEstado.Hip0615.GetKeyValue(),
                    };
                case ExpedienteEstadoTipo.HipotecarioParalizado:
                    break;
                case ExpedienteEstadoTipo.HipotecarioSubasta:
                    return new List<KeyValue>
                    {
                        TipoFaseEstado.Hip0601.GetKeyValue(),
                        TipoFaseEstado.Hip0602.GetKeyValue(),
                        TipoFaseEstado.Hip0603.GetKeyValue(),
                        TipoFaseEstado.Hip0604.GetKeyValue(),
                        TipoFaseEstado.Hip0605.GetKeyValue(),
                        TipoFaseEstado.Hip0606.GetKeyValue(),
                        TipoFaseEstado.Hip0607.GetKeyValue(),
                        TipoFaseEstado.Hip0608.GetKeyValue(),
                        TipoFaseEstado.Hip0609.GetKeyValue(),
                        TipoFaseEstado.Hip0610.GetKeyValue(),
                        TipoFaseEstado.Hip0611.GetKeyValue(),
                        TipoFaseEstado.Hip0612.GetKeyValue(),
                    };
                case ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien:
                    return new List<KeyValue>
                    {
                        TipoFaseEstado.Hip0701.GetKeyValue(),
                        TipoFaseEstado.Hip0702.GetKeyValue(),
                        TipoFaseEstado.Hip0703.GetKeyValue(),
                        TipoFaseEstado.Hip0704.GetKeyValue(),
                        TipoFaseEstado.Hip0705.GetKeyValue(),
                        TipoFaseEstado.Hip0706.GetKeyValue(),
                        TipoFaseEstado.Hip0707.GetKeyValue(),
                        TipoFaseEstado.Hip0708.GetKeyValue(),
                        TipoFaseEstado.Hip0709.GetKeyValue(),
                        TipoFaseEstado.Hip0710.GetKeyValue(),
                        TipoFaseEstado.Hip0711.GetKeyValue(),
                        TipoFaseEstado.Hip0712.GetKeyValue(),
                        TipoFaseEstado.Hip0713.GetKeyValue(),
                        TipoFaseEstado.Hip0714.GetKeyValue(),
                        TipoFaseEstado.Hip0715.GetKeyValue(),
                        TipoFaseEstado.Hip0716.GetKeyValue(),
                        TipoFaseEstado.Hip0717.GetKeyValue(),
                        TipoFaseEstado.Hip0718.GetKeyValue(),
                        TipoFaseEstado.Hip0719.GetKeyValue(),
                        TipoFaseEstado.Hip0720.GetKeyValue(),
                        TipoFaseEstado.Hip0721.GetKeyValue(),
                    };
                case ExpedienteEstadoTipo.HipotecarioNegociacionPosesion:
                    break;
                case ExpedienteEstadoTipo.HipotecarioFinalizado:
                    return new List<KeyValue>
                    {
                        TipoFaseEstado.Hip0801.GetKeyValue(),
                        TipoFaseEstado.Hip0802.GetKeyValue(),
                        TipoFaseEstado.Hip0803.GetKeyValue(),
                        TipoFaseEstado.Hip0804.GetKeyValue(),
                        TipoFaseEstado.Hip0805.GetKeyValue(),
                    };

                #endregion

                #region Alquiler

                case ExpedienteEstadoTipo.AlquilerRecepcionExpediente:
                    var result = GetListTipoFaseEstado(1);
                    result.Add(TipoFaseEstado.BaseParalizado.GetKeyValue());
                    return result;

                case ExpedienteEstadoTipo.AlquilerGeneracionExpediente:
                    break;
                case ExpedienteEstadoTipo.AlquilerPresentacionDemanda:
                    return new List<KeyValue>
                    {
                        TipoFaseEstado.BaseParalizado.GetKeyValue(),
                    };

                case ExpedienteEstadoTipo.AlquilerTramitacionJuzgado:
                    break;
                case ExpedienteEstadoTipo.AlquilerLanzamiento:
                    break;
                case ExpedienteEstadoTipo.AlquilerAdjudicacionBien:
                    break;
                case ExpedienteEstadoTipo.AlquilerFinalizado:
                    return new List<KeyValue>
                    {
                        TipoFaseEstado.Alquiler7901.GetKeyValue(),
                    };

                case ExpedienteEstadoTipo.AlquilerEnervacion:
                    break;
                case ExpedienteEstadoTipo.AlquilerParalizado:
                    break;

                #endregion

                #region Ejecutivo

                case ExpedienteEstadoTipo.EjecutivoRecepcionExpediente:
                    return GetListTipoFaseEstado(1);
                case ExpedienteEstadoTipo.EjecutivoEnvioDemandaProcurador:
                    break;
                case ExpedienteEstadoTipo.EjecutivoPresentacionDemanda:
                    return GetListTipoFaseEstado(3);
                case ExpedienteEstadoTipo.EjecutivoPresentacionEscrito579:
                    return new List<KeyValue>
                    {
                        TipoFaseEstado.Ejc32501.GetKeyValue(),
                        TipoFaseEstado.Ejc32502.GetKeyValue(),
                        TipoFaseEstado.Ejc32503.GetKeyValue(),
                    };
                case ExpedienteEstadoTipo.EjecutivoAdmisionTramiteEmbargo:
                    break;
                case ExpedienteEstadoTipo.EjecutivoTramiteEmbargo:
                    break;
                case ExpedienteEstadoTipo.EjecutivoEfectividadEmbargo:
                    break;
                case ExpedienteEstadoTipo.EjecutivoSolicitudSubasta:
                    break;
                case ExpedienteEstadoTipo.EjecutivoSubasta:
                    return new List<KeyValue>
                    {
                        TipoFaseEstado.Ejc0501.GetKeyValue(),

                        TipoFaseEstado.Hip0600.GetKeyValue(),
                        TipoFaseEstado.Hip0601.GetKeyValue(),
                        TipoFaseEstado.Hip0602.GetKeyValue(),
                        TipoFaseEstado.Hip0603.GetKeyValue(),
                        TipoFaseEstado.Hip0604.GetKeyValue(),
                        TipoFaseEstado.Hip0605.GetKeyValue(),
                        TipoFaseEstado.Hip0606.GetKeyValue(),
                        TipoFaseEstado.Hip0607.GetKeyValue(),
                        TipoFaseEstado.Hip0608.GetKeyValue(),
                        TipoFaseEstado.Hip0609.GetKeyValue(),
                        TipoFaseEstado.Hip0610.GetKeyValue(),
                        TipoFaseEstado.Hip0611.GetKeyValue(),
                        TipoFaseEstado.Hip0612.GetKeyValue(),
                        TipoFaseEstado.Hip0613.GetKeyValue(),
                        //TipoFaseEstado.Hip0614.GetKeyValue(),
                        TipoFaseEstado.Hip0615.GetKeyValue(),
                    };
                case ExpedienteEstadoTipo.EjecutivoAdjudicacionBien:
                    return new List<KeyValue>
                    {
                        TipoFaseEstado.Hip0701.GetKeyValue(),
                        TipoFaseEstado.Hip0702.GetKeyValue(),
                        TipoFaseEstado.Hip0703.GetKeyValue(),
                        TipoFaseEstado.Hip0704.GetKeyValue(),
                        TipoFaseEstado.Hip0705.GetKeyValue(),
                        TipoFaseEstado.Hip0706.GetKeyValue(),
                        TipoFaseEstado.Hip0707.GetKeyValue(),
                        TipoFaseEstado.Hip0708.GetKeyValue(),
                        TipoFaseEstado.Hip0709.GetKeyValue(),
                        TipoFaseEstado.Hip0710.GetKeyValue(),
                        TipoFaseEstado.Hip0711.GetKeyValue(),
                        TipoFaseEstado.Hip0712.GetKeyValue(),
                        TipoFaseEstado.Hip0713.GetKeyValue(),
                        TipoFaseEstado.Hip0714.GetKeyValue(),
                        TipoFaseEstado.Hip0715.GetKeyValue(),
                        TipoFaseEstado.Hip0716.GetKeyValue(),
                        TipoFaseEstado.Hip0717.GetKeyValue(),
                        TipoFaseEstado.Hip0718.GetKeyValue(),
                        TipoFaseEstado.Hip0719.GetKeyValue(),
                        TipoFaseEstado.Hip0720.GetKeyValue(),
                        TipoFaseEstado.Hip0721.GetKeyValue(),
                    };

                case ExpedienteEstadoTipo.EjecutivoFinalizacion:
                    break;
                //return new List<KeyValue>
                //{
                //    TipoFaseEstado.Ejc39001.GetKeyValue(),
                //    TipoFaseEstado.Ejc39002.GetKeyValue(),
                //    TipoFaseEstado.Ejc39003.GetKeyValue(),
                //    TipoFaseEstado.Ejc39004.GetKeyValue(),
                //};

                #endregion

                #region Ordinario

                case ExpedienteEstadoTipo.OrdinarioRecepcionExpediente:
                    return GetListTipoFaseEstado(1);
                case ExpedienteEstadoTipo.OrdinarioGeneracionExpediente:
                    break;
                case ExpedienteEstadoTipo.OrdinarioPresentacionDemanda:
                    return GetListTipoFaseEstado(3);
                case ExpedienteEstadoTipo.OrdinarioTramitacionJuzgado:
                    break;
                case ExpedienteEstadoTipo.OrdinarioJuicio:
                    break;
                case ExpedienteEstadoTipo.OrdinarioEjecucionSentencia:
                    break;
                case ExpedienteEstadoTipo.OrdinarioAutoAdmisionNotificacion:
                    break;
                case ExpedienteEstadoTipo.OrdinarioProcesoParalizado:
                    break;
                case ExpedienteEstadoTipo.OrdinarioSubasta:
                    break;
                case ExpedienteEstadoTipo.OrdinarioAdjudicacionDelBien:
                    break;
                case ExpedienteEstadoTipo.OrdinarioNegociacionPosesion:
                    break;
                case ExpedienteEstadoTipo.OrdinarioFinalizacion:
                    break;

                #endregion

                #region Ord.Cláusula Suelo

                case ExpedienteEstadoTipo.OrdinarioCsRecepcionExpediente:
                    return new List<KeyValue>
                    {
                        TipoFaseEstado.Ocs0101.GetKeyValue(),
                        TipoFaseEstado.Ocs0103.GetKeyValue(),
                    };
                case ExpedienteEstadoTipo.OrdinarioCsAllanamientoTotal:
                    return new List<KeyValue>
                    {
                        TipoFaseEstado.Ocs1301.GetKeyValue(),
                        TipoFaseEstado.Ocs1302.GetKeyValue(),
                        TipoFaseEstado.Ocs1303.GetKeyValue(),
                    };
                case ExpedienteEstadoTipo.OrdinarioCsAllanamientoParcial:
                    return new List<KeyValue>
                    {
                        TipoFaseEstado.Ocs1401.GetKeyValue(),
                        //TipoFaseEstado.Ocs1401.GetKeyValue(),
                        //TipoFaseEstado.Ocs1401.GetKeyValue(),
                    };
                case ExpedienteEstadoTipo.OrdinarioCsSentencia:
                    return new List<KeyValue>
                    {
                        TipoFaseEstado.Ocs0707.GetKeyValue(),
                        TipoFaseEstado.Ocs0701.GetKeyValue(),
                        TipoFaseEstado.Ocs0702.GetKeyValue(),
                        TipoFaseEstado.Ocs0703.GetKeyValue(),
                        TipoFaseEstado.Ocs0704.GetKeyValue(),
                        TipoFaseEstado.Ocs0705.GetKeyValue(),
                        TipoFaseEstado.Ocs0706.GetKeyValue(),
                        TipoFaseEstado.Ocs0708.GetKeyValue(),
                        TipoFaseEstado.Ocs0709.GetKeyValue(),
                        TipoFaseEstado.Ocs0710.GetKeyValue(),
                    };
                case ExpedienteEstadoTipo.OrdinarioCsAcuerdo:
                    return new List<KeyValue>
                    {
                        TipoFaseEstado.Ocs0105.GetKeyValue(),
                    };

                case ExpedienteEstadoTipo.OrdinarioCsAudienciaPrevia:
                    return new List<KeyValue>
                    {
                        TipoFaseEstado.Ocs0301.GetKeyValue(),
                        TipoFaseEstado.Ocs0102.GetKeyValue(),
                        TipoFaseEstado.Ocs0302.GetKeyValue(),
                    };
                case ExpedienteEstadoTipo.OrdinarioCsJuicio:
                    return new List<KeyValue>
                    {
                        TipoFaseEstado.Ocs0302.GetKeyValue(),
                        TipoFaseEstado.Ocs0106.GetKeyValue(),
                        TipoFaseEstado.Ocs0501.GetKeyValue(),
                    };
                case ExpedienteEstadoTipo.OrdinarioCsProcesoParalizado:
                    return new List<KeyValue>
                    {
                        TipoFaseEstado.Ocs0801.GetKeyValue(),
                        TipoFaseEstado.Ocs0802.GetKeyValue(),
                    };

                case ExpedienteEstadoTipo.OrdinarioCsFinalizacion:
                    return new List<KeyValue>
                    {
                        TipoFaseEstado.Ocs12001.GetKeyValue(),
                        TipoFaseEstado.Ocs12002.GetKeyValue(),
                        TipoFaseEstado.Ocs12003.GetKeyValue(),
                        TipoFaseEstado.Ocs12004.GetKeyValue(),
                        TipoFaseEstado.Ocs12005.GetKeyValue(),
                    };
                case ExpedienteEstadoTipo.OrdinarioCsCsContestacionDemanda:
                    return new List<KeyValue>
                    {
                        TipoFaseEstado.Ocs1401.GetKeyValue(),
                        //TipoFaseEstado.Ocs1401.GetKeyValue(),
                        //TipoFaseEstado.Ocs1401.GetKeyValue(),
                    };
                case ExpedienteEstadoTipo.OrdinarioCsEjecucionSentencia:
                    return new List<KeyValue>
                    {
                        TipoFaseEstado.Ocs0601.GetKeyValue(),
                        TipoFaseEstado.Ocs0602.GetKeyValue(),
                        TipoFaseEstado.Ocs0603.GetKeyValue(),
                        TipoFaseEstado.Ocs0604.GetKeyValue(),
                    };

                #endregion

                #region JV

                case ExpedienteEstadoTipo.JvRecepcionExpediente:
                    return GetListTipoFaseEstado(1);

                #endregion

                #region El Resto

                case ExpedienteEstadoTipo.ConcursalFaseComun:
                    break;
                case ExpedienteEstadoTipo.ConcursalFaseConvenio:
                    break;
                case ExpedienteEstadoTipo.ConcursalFaseLiquidacion:
                    break;

                case ExpedienteEstadoTipo.ConcursalFinalizado:
                    break;


                case ExpedienteEstadoTipo.NegociacionPendienteTelefono:
                    break;
                case ExpedienteEstadoTipo.NegociacionPdteContacto:
                    break;
                case ExpedienteEstadoTipo.NegociacionTelefonoErroneo:
                    break;
                case ExpedienteEstadoTipo.NegociacionEnTramitePdtePropuesta:
                    break;
                case ExpedienteEstadoTipo.NegociacionEnTramiteRehabilitacion:
                    break;
                case ExpedienteEstadoTipo.NegociacionEnTramiteAdecuacion:
                    break;
                case ExpedienteEstadoTipo.NegociacionEnTramiteAdecuacionSostenible:
                    break;
                case ExpedienteEstadoTipo.NegociacionEnTramiteCancelacion:
                    break;
                case ExpedienteEstadoTipo.NegociacionEnTramiteCancelConQuita:
                    break;
                case ExpedienteEstadoTipo.NegociacionEnTramiteVenta:
                    break;
                case ExpedienteEstadoTipo.NegociacionEnTramitePropElevada:
                    break;
                case ExpedienteEstadoTipo.NegociacionEnTramiteDacionPago:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalRehabilitacion:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalAdecuacion:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalAdecuacionSostenible:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalCancelacion:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalCancelConquita:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalVenta:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalDacionenPago:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalInviable:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalDesistidoParal:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalSubasta:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalVendidoaFondo:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalFinalizadoPropuestaDenegada:
                    break;
                case ExpedienteEstadoTipo.NegociacionSucursalFinalizadoPropuestaAceptada:
                    break;
                case ExpedienteEstadoTipo.NegociacionPagoParcial:
                    break;
                case ExpedienteEstadoTipo.NegociacionPagoTotal:
                    break;
                case ExpedienteEstadoTipo.NegociacionCondonacionParcial:
                    break;
                case ExpedienteEstadoTipo.NegociacionCondonacionTotal:
                    break;
                case ExpedienteEstadoTipo.NegociacionDeudaPagadaParcial:
                    break;
                case ExpedienteEstadoTipo.NegociacionDeudaPagadaTotal:
                    break;
                case ExpedienteEstadoTipo.NegociacionEntregadelInmueble:
                    break;
                case ExpedienteEstadoTipo.NegociacionFinalizadoVulnerabilidadSocial:
                    break;
                case ExpedienteEstadoTipo.NegociacionFinalizadoDemanda:
                    break;
                case ExpedienteEstadoTipo.NegociacionFinalizadoInviable:
                    break;
                case ExpedienteEstadoTipo.NegociacionFinalizadoPagoDeuda:
                    break;
                case ExpedienteEstadoTipo.NegociacionFinalizadoFinTiempoNeg:
                    break;




                #endregion

                default:
                    return null;
            }

            return null;
        }

        private static List<KeyValue> GetListTipoFaseEstado(int option)
        {
            if (option == 1) //Recepcion
                return new List<KeyValue>
                {
                    TipoFaseEstado.Hip0101RecepcionRevision.GetKeyValue(),
                    TipoFaseEstado.Hip0102IncidenciaDocumental.GetKeyValue(),
                    TipoFaseEstado.Hip0103PreparacionDemanda.GetKeyValue(),
                    TipoFaseEstado.Hip0104.GetKeyValue(),
                    TipoFaseEstado.Hip0105.GetKeyValue(),
                };
            if (option == 3) //Presentacion Demanda
                return new List<KeyValue>
                {
                    TipoFaseEstado.Hip0201.GetKeyValue(),
                    TipoFaseEstado.Hip0202PresentadaDemanda.GetKeyValue(),
                    TipoFaseEstado.Hip0203RequerimientoPrevio.GetKeyValue(),
                    TipoFaseEstado.Hip0204DemandaNoAdmitida.GetKeyValue(),
                    TipoFaseEstado.Hip0205RecursoReposicionApelacion.GetKeyValue(),
                };

            return null;
        }

        public static List<KeyValue> GetListTipoFaseEstado(this TipoFaseEstadoGrupo tipoFaseEstadoGrupo)
        {
            switch (tipoFaseEstadoGrupo)
            {
                case TipoFaseEstadoGrupo.JurisdiccionVoluntaria:
                    return new List<KeyValue>
                    {
                        TipoFaseEstado.Base5001.GetKeyValue(),
                        TipoFaseEstado.Base5002.GetKeyValue(),
                        TipoFaseEstado.Base5003.GetKeyValue(),
                        TipoFaseEstado.Base5004.GetKeyValue(),
                        TipoFaseEstado.Base5005.GetKeyValue(),
                    };

                default:
                    return null;
            }
        }

        public static string GetDescriptionNegociacionFinalizadaPor(this int? id)
        {
            if (!id.HasValue) return "-";

            using (var db = new ChmSaceContext())
            {
                var caracteristica = db.CaracteristicaBaseSet.FirstOrDefault(x => x.Id == id);
                return caracteristica?.Nombre;
            }

            //switch (id.Value)
            //{
            //    case 1: return "Finalizada por entrega de llaves";
            //    case 2: return "Finalizada por devolución";
            //    case 3: return "Finalización Toma de posesión Anticipada";
            //    case 4: return "Finalización Fallida";
            //    default: return "";
            //}
        }

        public static bool IsNegociacion(this NoteType noteType)
        {
            return (int)noteType >= 50 && (int)noteType <= 59;
        }
        public static bool IsNegociacion(this NoteType? noteType)
        {
            return noteType.HasValue && noteType.Value.IsNegociacion();
        }

        public static bool MustInheritLawyer(this TipoExpedienteEnum tipoExpediente)
        {
            return tipoExpediente == TipoExpedienteEnum.Ejecutivo
                || tipoExpediente == TipoExpedienteEnum.OrdinarioCs
                || tipoExpediente == TipoExpedienteEnum.Ordinario
                || tipoExpediente == TipoExpedienteEnum.Alquiler;
        }

        private static string FormatBold(this string textToShow)
        {
            return $"<b>{textToShow}</b>";
        }

        public static string HtmlGetDescriptionLargeOf(this SlaType slaType)
        {
            switch (slaType)
            {
                case SlaType.HipotecarioPresentacionDemanda:
                    return $"Expedientes que NO tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioPresentacionDemanda.GetDescriptionShort()}</b> y que NO estén en fase <b>Incidencia Documental<b>" +
                           $", o que teniendolo les falte la <b>Fecha de Envio de Demanda al Procururador</b>.";

                case SlaType.EjecutivoPresentacionDemanda:
                    break;
                case SlaType.AlquilerPresentacionDemanda:
                    return $"Expedientes que NO tengan el estado <b>{ExpedienteEstadoTipo.AlquilerPresentacionDemanda.GetDescriptionShort()}</b> y que NO estén en fase <b>Incidencia Documental<b>" +
                           $", o que teniendolo les falte la <b>Fecha de Presentación de Demanda</b>.";

                case SlaType.OrdinarioPresentacionDemanda:
                    break;
                default:
                    break;
            }
            return null;
        }

        public static string HtmlGetDescriptionLargeOf(this TipoIndicadorQa tipoIndicadorQa)
        {
            switch (tipoIndicadorQa)
            {
                #region Hipotecario

                #region Hipotecario Indicadores

                case TipoIndicadorQa.HipotecarioInactivo:
                    return "Expedientes que <b>NO</b> estén en los estados de <b>Finalización o Paralizado</b> y que tengan más de 60 días de inactividad en: <b>Estados (Fecha de Alta), Impulsos, Notas o Expediente.FechaUltimaModificación</b>";
                case TipoIndicadorQa.HipotecarioEnRevisionNoVeniados:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.RecepcionExpediente.GetDescriptionShort()}</b>, que NO sean <b>Veniados</b>, y que no tengan fase o que la fase sea <b>{TipoFaseEstado.Hip0101RecepcionRevision.GetDescription()}</b>.";
                case TipoIndicadorQa.HipotecarioEnRevisionVeniados:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.RecepcionExpediente.GetDescriptionShort()}</b>, que sean <b>Veniados</b>, y que no tengan fase o que la fase sea <b>{TipoFaseEstado.Hip0101RecepcionRevision.GetDescription()}</b>.";

                case TipoIndicadorQa.HipotecarioIncidenciaDocumental:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.RecepcionExpediente.GetDescriptionShort()}</b>" +
                           $", en la fase <b>{TipoFaseEstado.Hip0102IncidenciaDocumental.GetDescription()}</b> o en la fase <b>{TipoFaseEstado.Hip0104.GetDescription()}</b>.";

                case TipoIndicadorQa.HipotecarioPendientePreparacionDemanda:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.RecepcionExpediente.GetDescriptionShort()}</b> en la fase <b>{TipoFaseEstado.Hip0103PreparacionDemanda.GetDescription()}</b>, o en el estado <b>{ExpedienteEstadoTipo.HipotecarioGeneracionExpediente.GetDescriptionShort()}</b>, o en el estado <b>{ExpedienteEstadoTipo.HipotecarioPresentacionDemanda.GetDescriptionShort()}</b> pero les falte la <b>Fecha de Envio al Procurador</b>.";

                case TipoIndicadorQa.HipotecarioPendientePresentacionDemanda:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que esten en los estados <b>{ExpedienteEstadoTipo.RecepcionExpediente.GetDescriptionShort()} o {ExpedienteEstadoTipo.HipotecarioGeneracionExpediente.GetDescriptionShort()}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - O en el estado <b>{ExpedienteEstadoTipo.HipotecarioPresentacionDemanda.GetDescriptionShort()}</b> pero le falte la <b>Fecha de Presentación</b>.</span>";

                case TipoIndicadorQa.HipotecarioJurisdiccionVoluntaria:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioJurisdiccionVoluntaria.GetDescriptionShort()}</b>" +
                           ", y les falte alguna <b>Fecha de Recepción de Escrituras</b> o que no tenga registro de escritura.";

                case TipoIndicadorQa.HipotecarioAutosIncompletoErroneo:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()}</b>, en la fase <b>{TipoFaseEstado.Hip0302.GetDescription()}</b>.";
                case TipoIndicadorQa.HipotecarioPendienteDemandaAdmitida:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()} en las fases de Tramitación</b>" +
                           $", pero les falte <b>Fecha Demanda Admitida</b>" +
                           $" o Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioPresentacionDemanda.GetDescriptionShort()}</b>" +
                           $", que <b>NO</b> tengan la <b>Fecha de Demanda NO Admitida</b> y <b>SI</b> tengan <b>Fecha de Presentación de Demanda</b>.";
                case TipoIndicadorQa.HipotecarioPendienteCertificacionCargas:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()} en las fases de Tramitación</b>, que tengan <b>Fecha Demanda Admitida</b>, pero les falte <b>Fecha de Certificación de Cargas</b>.";
                case TipoIndicadorQa.HipotecarioPendienteRequerimientoPago:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()} en las fases de Tramitación</b>, que tengan <b>Fecha de Certificación de Cargas</b>, pero tengan algún <b>Requerimiento de Pago</b> negativo.";
                case TipoIndicadorQa.HipotecarioPendienteNotificacion:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()} en las fases de Tramitación</b>, que tengan <b>Fecha de Certificación de Cargas</b>, pero NO tengan ningún <b>Requerimiento de Pago</b>.";

                case TipoIndicadorQa.HipotecarioPendienteSolicitarSubasta:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()} en las fases de Tramitación</b>, que tengan <b>Fecha de Certificación de Cargas</b>, que todos los <b>Requerimiento de Pago</b> sean positivos y que no tenga solicitada la subasta o que la solicitud de subasta actual esté suspendida.";

                case TipoIndicadorQa.HipotecarioPendienteConvocatoriaSubasta:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()}</b>, que tengan <b>Fecha de Solicitud de Subasta</b>, pero les falten las fechas: (<b>F. Decreto Subasta</b> y <b>F. Celebración</b>) para la subasta actual.";
                case TipoIndicadorQa.HipotecarioIncidenciaDecretoAjdudicacion:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien.GetDescriptionShort()}</b>" +
                           $", y que en el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()}</b>" +
                           $" se cumplan algunas de las siguientes condiciones: el tipo <b>Cesión = {SubastaCesionType.Pendiente.GetDescription()}</b>" +
                           $" o <b>Consignación = Consignado</b>" +
                           $" o que <b>Indicencia Decreto = Indicencias Decreto</b>" +
                           $" o que tenga marcada la opción <b>Adjudicación a tercero (Finalizar expediente para facturación)</b>.";

                case TipoIndicadorQa.HipotecarioPendienteSubastasSuspendidas:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()} en las fases de Subasta</b> y que la subasta activa esté suspendida.";
                case TipoIndicadorQa.HipotecarioPendienteAdjudicacion:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()} en las fases de Subasta</b> y que tenga <b>F. Sol. Adjudicación</b>.";
                case TipoIndicadorQa.HipotecarioDecretoConvocatoriaSubasta:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()} en las fases de Subasta</b>, que la subasta activa no esté suspendida ni suspendido el decreto de subasta y tenga <b>F. Decreto Subasta</b>, pero que le falte <b>F. Celebración</b>.";
                case TipoIndicadorQa.HipotecarioPendienteSuspensionDecreto:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()} en las fases de Subasta</b>, y que la subasta activa tenga motivo de suspensión de decreto.";

                case TipoIndicadorQa.HipotecarioPendienteTestimonioAdjudicacion:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien.GetDescriptionShort()}</b> y tengan la <b>Fecha de Adjudicación</b>, pero les falte la <b>Fecha de Testimonio</b>. Y que además para el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()}</b> no presente incidencias en <b>Consignación</b> o <b>Indicencia Decreto</b>.";
                case TipoIndicadorQa.HipotecarioPendienteSolicitudPosesion:
                    return "Expedientes que estén en el estado <b>Adjudicación del Bien</b> y tengan la <b>Fecha de Testimonio</b>, pero les falte la <b>Fecha Solicitud de Posesión</b> y la <b>Fecha de Posesión</b>.";

                case TipoIndicadorQa.HipotecarioPendienteLanzamiento:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien.GetDescriptionShort()}</b>, " +
                        $"que tengan <b>F. Testimonio</b> y <b>F.Sol.Posesión</b>, " +
                        $"y que <b>NO</b> tengan Lanzamiento con resultado <b>Positivo</b> o <b>Suspensión por: Reconocido Arrendamiento o Acuerdo Formalizado o Ley 1/2013</b>.";

                case TipoIndicadorQa.HipotecarioPendienteNegociacionPosesion:
                    return "Expedientes que estén en el estado <b>Adjudicación del Bien</b> y <b>NO</b> tengan <b>Gestor</b> en <b>Negociación Contencioso</b>. Solo los expedientes de <b>Bankia</b>(ClienteOficina = Bankia))";

                case TipoIndicadorQa.HipotecarioPendienteTestimoniosInscripcion:
                    return "";

                case TipoIndicadorQa.HipotecarioPendienteAdjudicacionLey12013:
                    return "Expedientes que estén en el estado <b>Adjudicación del Bien</b> y que el resultado de posesión sea <b>Negativa - Prórroga Ley 1/2013</b>.";
                case TipoIndicadorQa.HipotecarioCalificacionNegativa:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien.GetDescriptionShort()}</b>, " +
                        $"que tengan <b>Fecha de Testimonio</b>, " +
                        $"que tengan <b>algún</b> check de <b>Calificación Negativa</b> (Acta situación arrendaticia, Inscripción crédito, etc), " +
                        $"y que <b>NO</b> tengan <b>F. Certif. Insc. Testim.</b>.";
                case TipoIndicadorQa.HipotecarioLiquidacionItp:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien.GetDescriptionShort()}</b>, " +
                        $"que tengan <b>Fecha de Testimonio</b>, " +
                        $"y que <b>NO</b> tengan marcado el <b>Check de Liquidación ITP / IVA</b>.";

                #endregion

                #region Hipotecario Alarmas

                case TipoIndicadorQa.HipotecarioAlarmaIncidentados:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.RecepcionExpediente.GetDescriptionShort()}</b>" +
                        $", en la fase <b>1.2 Incidencia Documental</b> o <b>1.4 Pdte. Instrucciones del cliente</b>" +
                        $" y tengan <b>Fecha</b> con una antigüedad superior a <b>30 días</b>.";
                case TipoIndicadorQa.HipotecarioAlarmaAdmisionDemanda:
                    return $"Expedientes Hipotecarios que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioPresentacionDemanda.GetDescriptionShort()}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO sean <b>Veniados (Heredados)</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Fecha de Demanda NO Admitida</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que SI tengan <b>Fecha de Presentación de Demanda</b> con una antigüedad superior a <b>80 días</b>.</span>";

                    //return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioPresentacionDemanda.GetDescriptionShort()}</b>" +
                    //       $", que NO tengan la <b>Fecha de Demanda NO Admitida</b>" +
                    //       $" y si tengan <b>Fecha de Presentación de Demanda</b> con una antigüedad superior a <b>80 días</b>.";
                case TipoIndicadorQa.HipotecarioAlarmaInadmisionDemanda:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioPresentacionDemanda.GetDescriptionShort()}</b>" +
                           $", que tengan la <b>Fecha de Demanda NO Admitida</b>" +
                           $", y si tengan <b>Fecha de Presentación de Demanda</b> con una antigüedad superior a <b>80 días</b>." +
                           $", y que NO tengan la <b>Fecha de Apelación</b>";
                case TipoIndicadorQa.MonitorioAlarmaSucesionCopiaSellada:
                    return $"Expedientes que NO tengan la <b>Fecha Sucesión Copia Sellada</b>," +
                           $" y si tengan <b>Fecha de Sucesión Presentada</b> con una antigüedad superior a <b>2 días</b>.";
                case TipoIndicadorQa.HipotecarioAlarmaSucesionCopiaSellada:
                    return $"Expedientes Hipotecarios que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que NO estén <b>Finalizados</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Fecha Sucesión Copia Sellada</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que SI tengan <b>Fecha de Sucesión Presentada</b> con una antigüedad superior a <b>2 días</b>.</span>";
                case TipoIndicadorQa.HipotecarioAlarmaCertificacionCargas:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()} en las fases de Tramitación</b>" +
                        $", que NO tengan la <b>Fecha de Certificación de Carga</b>" +
                        $", y si la <b>Fecha de Demanda Admitida</b> con una antiguedad superior a <b>90 días</b>.";
                case TipoIndicadorQa.HipotecarioAlarmaRequerimientoPago:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()} en las fases de Tramitación</b>" +
                        $", que tengan algún <b>Requerimiento de Pago Negativo</b>" +
                        $", y si la <b>Fecha de Demanda Admitida</b> con una antiguedad superior a <b>150 días</b>.";
                case TipoIndicadorQa.HipotecarioAlarmaSolicitudSubasta:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()} en las fases de Tramitación</b>" +
                        $", que NO tengan la <b>Fecha de Solicitud de Subasta</b>" +
                        $", que no haya <b>Oposición</b>" +
                        $", y si tengan la <b>Fecha de Certificación de Carga</b>" +
                        $", y todos los<b> Requerimientos de Pagos sean Positívos</b>" +
                        $", y todos los requerimientos con antigüedad superior a <b>20 días</b>.";
                case TipoIndicadorQa.HipotecarioAlarmaDecretoConvocatoria:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()} en las fases de Subasta</b>" +
                        $", que NO tengan la <b>Fecha de Celebración</b>" +
                        $", y SI tengan la <b>Fecha de Decreto</b> con una antigüedad superior a <b>80 días</b>" +
                        $", y que NO esté suspendido el Decreto.";
                case TipoIndicadorQa.HipotecarioAlarmaDecretoAdjudicacion:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()} en las fases de Subasta</b>" +
                        $", que tengan <b>Fecha de Celebración de Subasta</b> (no suspendida) con una antiguedad superior a <b>80 días</b>.";
                case TipoIndicadorQa.HipotecarioAlarmaPosesion:
                    return "Expedientes que estén en el estado <b>Adjudicación del Bien</b>" +
                        ", que <b>NO</b> tengan cumplimentado ninguno de los check del cuadro inmueble (o que la lista de inmuebles esté vacia)" +
                        ", y que <b>NO</b> tengan vistas de <b>posesiones / lanzamientos</b> con resultado <b>Positivo</b> (o que la lista de vistas esté vacia)" +
                        ", y si la <b>Fecha Decreto Adjudicación</b> con una antigüedad superior a <b>200 días</b>.";
                case TipoIndicadorQa.HipotecarioAlarmaTestimonio:
                    return "Expedientes que estén en el estado <b>Adjudicación del Bien</b>" +
                        ", que NO tengan la <b>Fecha Certif. Insc. Testim.</b>" +
                        ", y si la <b>Fecha de Testimonio</b> con una antiguedad superior a <b>120 días</b>.";

                case TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre01:
                    return $"Expedientes Hipotecarios que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioGeneracionExpediente.GetDescriptionShort()}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tenga <b>Fecha obtención título ejecutivo</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que SI tenga <b>Fecha Solicitud</b> con una antigüedad superior a <b>30 días</b>.</span>";
                case TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre02:
                    return $"Expedientes Hipotecarios que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioGeneracionExpediente.GetDescriptionShort()}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tenga <b>Fecha obtención burofax de 30 días</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que SI tenga <b>Fecha Solicitud</b> con una antigüedad superior a <b>3 días</b>.</span>";
                case TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre03:
                    return $"Expedientes Hipotecarios que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioGeneracionExpediente.GetDescriptionShort()}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tenga <b>Fecha confección y revisión de liquidación de saldo deudor</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que SI tenga <b>Fecha Solicitud</b> con una antigüedad superior a <b>33 días</b>.</span>";
                case TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre04:
                    return $"Expedientes Hipotecarios que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioGeneracionExpediente.GetDescriptionShort()}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tenga <b>Fecha confección, firma y diligenciado del Certificado</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que SI tenga <b>Fecha Recepción</b> con una antigüedad superior a <b>15 días</b>.</span>";
                case TipoIndicadorQa.HipotecarioAlarmaRecepcionSolicitudCierre05:
                    return $"Expedientes Hipotecarios que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioGeneracionExpediente.GetDescriptionShort()}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tenga <b>Fecha obtención burofax de 10 días</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que SI tenga <b>Fecha Solicitud</b> con una antigüedad superior a <b>5 días</b>.</span>";



                case TipoIndicadorQa.EjecutivoAlarmaSucesionCopiaSellada:
                    return $"Expedientes que NO tengan la <b>Fecha Sucesión Copia Sellada</b>," +
                           $" y si tengan <b>Fecha de Sucesión Presentada</b> con una antigüedad superior a <b>2 días</b>.";
                case TipoIndicadorQa.OrdinarioAlarmaSucesionCopiaSellada:
                    return $"Expedientes que NO tengan la <b>Fecha Sucesión Copia Sellada</b>," +
                           $" y si tengan <b>Fecha de Sucesión Presentada</b> con una antigüedad superior a <b>2 días</b>.";


                
                #endregion

                #region Hipotecario Facturas

                case TipoIndicadorQa.HipotecarioFacturaSolviaHito1:
                    return $"Expedientes de <b>Solvia Hipotecario</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioPresentacionDemanda.GetDescriptionShort()}</b>" +
                           $", que NO tengan <b>Factura de tipo Hito 1</b> y si la <b>Fecha de Presentación de Demanda</b>" +
                           $", y que la fecha sea menor o igual que la fecha actual.";
                case TipoIndicadorQa.HipotecarioFacturaSolviaHito2:
                    return $"Expedientes de <b>Solvia Hipotecario</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien.GetDescriptionShort()}</b>" +
                           $", que NO tengan <b>Factura de tipo Hito 2</b> y si la <b>Fecha de Adjudicación</b>" +
                           $", y que la fecha sea menor o igual que la fecha actual.";
                case TipoIndicadorQa.HipotecarioFacturaSolviaHito3:
                    return $"Expedientes de <b>Solvia Hipotecario</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien.GetDescriptionShort()}</b>" +
                           $", que NO tengan <b>Factura de tipo Hito 3</b> y si la <b>Fecha de Posesión</b>" +
                           $", y que la fecha sea menor o igual que la fecha actual" +
                           $". Además el <b>Resultado Posesión</b> debe ser <b>Positivo</b> o <b>Negativa - Reconocido Arrendamiento</b>.";
                case TipoIndicadorQa.HipotecarioFacturaSolviaHito4:
                    return $"Expedientes de <b>Solvia Hipotecario</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioFinalizado.GetDescriptionShort()}</b>" +
                           $", que NO tengan <b>Factura de tipo Hito 4</b> y si la <b>Fecha de Estado</b>" +
                           $", y que la fecha sea menor o igual que la fecha actual";

                case TipoIndicadorQa.HipotecarioFacturaSabadellHito1:
                    return $"Expedientes de <b>Sabadell</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()}</b>" +
                           $", que NO tengan <b>Factura de tipo Hito 1</b> y si la <b>Fecha de Celebración de Subasta</b>" +
                           $", y que la fecha sea menor o igual que la fecha actual y que no esté suspendida.";
                case TipoIndicadorQa.HipotecarioFacturaSabadellHito2:
                    return $"Expedientes de <b>Sabadell</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien.GetDescriptionShort()}</b>" +
                           $", que NO tengan <b>Factura de tipo Hito 2</b>" +
                           $", y SI la <b>Fecha de Certificado Insc.</b> y sea menor o igual que la fecha actual" +
                           $", que también tenga la <b>Fecha de Posesión</b> y sea menor o igual que la fecha actual" +
                           $". Además el <b>Resultado Posesión</b> debe ser uno de los siguientes: (<b>Positivo</b> o <b>Negativa - Prórroga Ley 1/13</b> o <b>Negativa - Reconocido Arrendamiento</b>).";
                case TipoIndicadorQa.HipotecarioFacturaSabadellHito3:
                    return $"Expedientes de <b>Sabadell</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioFinalizado.GetDescriptionShort()}</b>" +
                           $", que NO tengan <b>Factura de tipo Hito 2</b>" +
                           $", y si la <b>Fecha de Estado</b> y sea menor o igual que la fecha actual";

                case TipoIndicadorQa.HipotecarioFacturaAnticipaHito1:
                    return $"Expedientes de <b>Anticipa</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien.GetDescriptionShort()}</b>" +
                           $", que NO tengan <b>Factura de tipo Hito 1</b>" +
                           $", y si la <b>Fecha de Adjudicación</b> y sea menor o igual que la fecha actual.";
                case TipoIndicadorQa.HipotecarioFacturaAnticipaHito2:
                    return $"Expedientes de <b>Anticipa</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien.GetDescriptionShort()}</b>" +
                           $", que NO tengan <b>Factura de tipo Hito 2</b>" +
                           $", y SI la <b>Fecha de Certificado Insc.</b> y sea menor o igual que la fecha actual" +
                           $", que también tenga la <b>Fecha de Posesión</b> y sea menor o igual que la fecha actual" +
                           $". Además el <b>Resultado Posesión</b> debe ser uno de los siguientes: (<b>Positivo</b> o <b>Negativa - Prórroga Ley 1/13</b> o <b>Negativa - Reconocido Arrendamiento</b>).";

                case TipoIndicadorQa.HipotecarioFacturaSarebHito1:
                    return $"Expedientes de <b>Sareb</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien.GetDescriptionShort()}</b>" +
                           $", que NO tengan <b>Factura de tipo Hito 1</b>" +
                           $", y SI la <b>Fecha de Certificado Insc.</b> y sea menor o igual que la fecha actual" +
                           $", que también tenga la <b>Fecha de Posesión</b> y sea menor o igual que la fecha actual" +
                           $". Además el <b>Resultado Posesión</b> debe ser uno de los siguientes: (<b>Positivo</b> o <b>Negativa - Prórroga Ley 1/13</b> o <b>Negativa - Reconocido Arrendamiento</b>).";
                case TipoIndicadorQa.HipotecarioFacturaSarebHito2:
                    return $"Expedientes de <b>Sareb</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioFinalizado.GetDescriptionShort()}</b>" +
                           $", que NO tengan <b>Factura de tipo Hito 2</b>" +
                           $", y que la <b>Fecha de Estado</b> sea menor o igual que la fecha actual.";

                case TipoIndicadorQa.HipotecarioFacturaPostEjcHito1:
                    return $"Expedientes de <b>Post-Ejc Haya y Solvia</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioFinalizado.GetDescriptionShort()}</b>" +
                           $", que NO tengan <b>Factura de tipo Hito 1</b>" +
                           $", y que la <b>Fecha de Estado</b> sea menor o igual que la fecha actual.";

                case TipoIndicadorQa.HipotecarioFacturaBankiaHito1:
                    return $"Expedientes de <b>Bankia</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()}</b>" +
                           $", que NO tengan <b>Factura de tipo Hito 1</b> y si la <b>Fecha de Celebración de Subasta</b>" +
                           $", y que la fecha sea menor o igual que la fecha actual y que no esté suspendida.";
                case TipoIndicadorQa.HipotecarioFacturaBankiaHito2a:
                    return $"Expedientes de <b>Bankia</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien.GetDescriptionShort()}</b>" +
                           $", que NO tengan <b>Factura de tipo Hito 2</b>" +
                           $", y SI la <b>Fecha de Certificado Insc.</b> y sea menor o igual que la fecha actual" +
                           $", que también tenga la <b>Fecha de Posesión</b> y sea menor o igual que la fecha actual" +
                           $". Además el <b>Resultado Posesión</b> debe ser uno de los siguientes: (<b>Positivo</b> o <b>Negativa - Prórroga Ley 1/13</b> o <b>Negativa - Reconocido Arrendamiento</b>).";
                case TipoIndicadorQa.HipotecarioFacturaBankiaHito2b:
                    return $"Expedientes de <b>Bankia</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioFinalizado.GetDescriptionShort()}</b>" +
                           $", que NO tengan <b>Factura de tipo Hito 2</b>" +
                           $", y si la <b>Fecha de Estado</b> y sea menor o igual que la fecha actual.";

                case TipoIndicadorQa.HipotecarioFacturaAlisedaNoVeniadoHito1:
                    return $"Expedientes de <b>Aliseda (No Veniados)</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien.GetDescriptionShort()}</b>" +
                           $", que NO tengan <b>Factura de tipo Hito 1</b>" +
                           $", y que la <b>Fecha de Adjudicación</b> sea menor o igual que la fecha actual." +
                           $" Y que <b>NO</b> tengan marcado <b>Facturacion Completa</b> ni <b>No Facturable</b>.";
                case TipoIndicadorQa.HipotecarioFacturaAlisedaVeniadoHito1:
                    return $"Expedientes de <b>Aliseda (Veniados)</b> que tengan la <b>Fecha de Carga en Cliente</b>" +
                           $", que NO tengan <b>Factura de tipo Hito 1</b>.";
                case TipoIndicadorQa.HipotecarioFacturaAlisedaNoVeniadoHito2:
                    return $"Expedientes de <b>Aliseda (No Veniados)</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien.GetDescriptionShort()}</b>" +
                           $", que NO tengan <b>Factura de tipo Hito 2</b>" +
                           $", y SI la <b>Fecha de Certificado Insc.</b> y sea menor o igual que la fecha actual" +
                           $", que también tenga la <b>Fecha de Posesión</b> y sea menor o igual que la fecha actual" +
                           $". Además el <b>Resultado Posesión</b> debe ser uno de los siguientes: (<b>Positivo</b> o <b>Negativa - Prórroga Ley 1/13</b> o <b>Negativa - Reconocido Arrendamiento</b>).";
                case TipoIndicadorQa.HipotecarioFacturaAlisedaVeniadoHito2:
                    return $"Expedientes de <b>Aliseda (Veniados)</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien.GetDescriptionShort()}</b>" +
                           $", que NO tengan <b>Factura de tipo Hito 2</b>" +
                           $", y SI la <b>Fecha de Certificado Insc.</b> y sea menor o igual que la fecha actual" +
                           $", que también tenga la <b>Fecha de Posesión</b> y sea menor o igual que la fecha actual" +
                           $". Además el <b>Resultado Posesión</b> debe ser uno de los siguientes: (<b>Positivo</b> o <b>Negativa - Prórroga Ley 1/13</b> o <b>Negativa - Reconocido Arrendamiento</b>).";
                case TipoIndicadorQa.HipotecarioFacturaAlisedaNoVeniadoFinalizadosPdteFacturar:
                    return $"Expedientes de <b>Aliseda (No Veniados)</b> que estén <b>Finalizados (Fecha Fin)</b>" +
                           $" y que NO tengan facturados los <b>Hitos 1 y 2</b>" +
                           $", y que sean <b>Facturables</b> y no tengan marcado <b>Facturación Completada</b>.";
                case TipoIndicadorQa.HipotecarioFacturaAlisedaVeniadoFinalizadosPdteFacturar:
                    return $"Expedientes de <b>Aliseda (Veniados)</b> que estén <b>Finalizados (Fecha Fin)</b>" +
                           $" y que NO tengan facturados los <b>Hitos 1 y 2</b>" +
                           $", y que sean <b>Facturables</b> y no tengan marcado <b>Facturación Completada</b>.";

                case TipoIndicadorQa.HipotecarioFacturaAbancaHito1:
                    return $"Expedientes de <b>Abanca</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien.GetDescriptionShort()}</b>" +
                           $", que NO tengan <b>Factura de tipo Hito 1</b>" +
                           $", y que la <b>Fecha de Testimonio</b> sea menor o igual que la fecha actual.";
                case TipoIndicadorQa.HipotecarioFacturaAbancaHito2:
                    return $"Expedientes de <b>Abanca</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien.GetDescriptionShort()}</b>" +
                           $", que NO tengan <b>Factura de tipo Hito 2</b>" +
                           $", y SI la <b>Fecha de Certificado Insc.</b> y sea menor o igual que la fecha actual" +
                           $", que también tenga la <b>Fecha de Posesión</b> y sea menor o igual que la fecha actual" +
                           $". Además el <b>Resultado Posesión</b> debe ser uno de los siguientes: (<b>Positivo</b> o <b>Negativa - Prórroga Ley 1/13</b> o <b>Negativa - Reconocido Arrendamiento</b>).";
                case TipoIndicadorQa.HipotecarioFacturaAbancaHito3:
                    return $"Expedientes de <b>Abanca</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioFinalizado.GetDescriptionShort()}</b>" +
                           $", que NO tengan <b>Factura de tipo Hito 3</b>" +
                           $", y si la <b>Fecha de Estado</b> y sea menor o igual que la fecha actual.";

                case TipoIndicadorQa.HipotecarioFacturaVoyagerAltamiraNoVeniadoHito1:
                    return $"Expedientes de <b>Voyager-Altamira NO Veniados</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioPresentacionDemanda.GetDescriptionShort()}</b>" +
                           $", que <b>NO tengan Factura tipo {HitoFacturacionValue.HipotecarioHito1.GetDescription()}</b>" +
                           $", y si la <b>Fecha de Presentación de Demanda</b>" +
                           $", y que la fecha sea menor o igual que la fecha actual.";
                case TipoIndicadorQa.HipotecarioFacturaVoyagerAltamiraNoVeniadoHito2:
                    return $"Expedientes de <b>Voyager-Altamira NO Veniados</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()}</b>" +
                           $", que <b>NO tengan Factura tipo {HitoFacturacionValue.HipotecarioHito2.GetDescription()}</b>" +
                           $", y si la <b>Fecha de Celebración de Subasta</b>" +
                           $", y que la fecha sea menor o igual que la fecha actual y que no esté suspendida.";
                case TipoIndicadorQa.HipotecarioFacturaVoyagerAltamiraNoVeniadoHitoFinalizacion:
                    return $"Expedientes de <b>Voyager-Altamira NO Veniados</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien.GetDescriptionShort()}</b>" +
                           $", que <b>NO tengan Factura tipo {HitoFacturacionValue.HipotecarioHito4.GetDescription()}</b>" +
                           $", y SI la <b>Fecha de Certificado Insc.</b> y sea menor o igual que la fecha actual" +
                           $", que también tenga la <b>Fecha de Posesión</b> y sea menor o igual que la fecha actual" +
                           $". Además el <b>Resultado Posesión</b> debe ser uno de los siguientes: (<b>Positivo</b> o <b>Negativa - Prórroga Ley 1/13</b> o <b>Negativa - Reconocido Arrendamiento</b>).";


                case TipoIndicadorQa.HipotecarioFacturaVoyagerAltamiraVeniadoHito1:
                    return $"Expedientes de <b>Voyager-Altamira Veniados</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()}</b>" +
                           $", que <b>NO tengan Factura tipo {HitoFacturacionValue.HipotecarioHito1.GetDescription()}</b>" +
                           $", y si la <b>Fecha de Celebración de Subasta</b>" +
                           $", y que la fecha sea menor o igual que la fecha actual y que no esté suspendida.";
                case TipoIndicadorQa.HipotecarioFacturaVoyagerAltamiraVeniadoHitoFinalizacion:
                    return $"Expedientes de <b>Voyager-Altamira Veniados</b> que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien.GetDescriptionShort()}</b>" +
                           $", que <b>NO tengan Factura tipo {HitoFacturacionValue.HipotecarioHito4.GetDescription()}</b>" +
                           $", y SI la <b>Fecha de Certificado Insc.</b> y sea menor o igual que la fecha actual" +
                           $", que también tenga la <b>Fecha de Posesión</b> y sea menor o igual que la fecha actual" +
                           $". Además el <b>Resultado Posesión</b> debe ser uno de los siguientes: (<b>Positivo</b> o <b>Negativa - Prórroga Ley 1/13</b> o <b>Negativa - Reconocido Arrendamiento</b>).";

                case TipoIndicadorQa.HipotecarioFinalizadoSinFactura:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que estén <b>Finalizados</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan (<b>Facturación Completa</b> o <b>No Facturable</b>).</span>";
                case TipoIndicadorQa.AlquilerFinalizadoSinFactura:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que estén <b>Finalizados</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan (<b>Facturación Completa</b> o <b>No Facturable</b>).</span>";
                case TipoIndicadorQa.OrdinarioFinalizadoSinFactura:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que estén <b>Finalizados</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan (<b>Facturación Completa</b> o <b>No Facturable</b>).</span>";
                case TipoIndicadorQa.EjecutivoFinalizadoSinFactura:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que estén <b>Finalizados</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan (<b>Facturación Completa</b> o <b>No Facturable</b>).</span>";

                #endregion

                #region Hipotecario SLA

                case TipoIndicadorQa.HipotecarioSlaPresentacionDemandaBankia:
                    return $"Expedientes de <b>Bankia</b> que NO tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioPresentacionDemanda.GetDescriptionShort()}</b>" +
                           $", o que teniendolo le falte la <b>Fecha de Presentación de Demanda</b>";

                #endregion

                #region Hipotecario Datos

                case TipoIndicadorQa.ExpHipQaDatosSinInmueble:
                    return $"Expedientes hipotecarios activos que no tengan inmuebles y que estén en alguno de los siguientes estados: <b>{ExpedienteEstadoTipo.HipotecarioPresentacionDemanda.GetDescriptionShort()}, {ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()}, {ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien.GetDescriptionShort()}</b>.";
                case TipoIndicadorQa.ExpHipQaDatosSinPartidoJudicial:
                    return "Expedientes hipotecarios activos en el estado trámite o superior sin partido judicial.";
                case TipoIndicadorQa.ExpHipQaDatosSinNoAuto:
                    return $"Expedientes hipotecarios activos en el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()}</b> o superior sin número de auto (Excepto Jurisdicción Voluntaria).";

                case TipoIndicadorQa.ExpHipQaDatosSinFechaDemanda:
                    return $"Expedientes hipotecarios activos (no veniados) en el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()}</b> o superior" +
                        $", y que tengan el estado <b>{ExpedienteEstadoTipo.HipotecarioPresentacionDemanda.GetDescriptionShort()}</b> sin fecha de presentación o sin fecha de envio al procurador.";
                case TipoIndicadorQa.ExpHipQaDatosSinJuzgado:
                    return $"Expedientes hipotecarios activos, " +
                        $"que les falte el Juzgado, " +
                        $"y que estén en el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()}</b> o superior " +
                        $"y distinto de <b>{ExpedienteEstadoTipo.HipotecarioJurisdiccionVoluntaria.GetDescriptionShort()}</b>.";
                case TipoIndicadorQa.ExpHipQaDatosSinDemandaAdmitida:
                    return $"Expedientes hipotecarios activos (no veniados) en el estado <b>{ExpedienteEstadoTipo.HipotecarioTramitacionSubasta.GetDescriptionShort()}</b> o superior" +
                        " sin Fecha de Admisión de Demanda.";
                case TipoIndicadorQa.ExpHipQaDatosAdjudicacionIncompletos:
                    return $"Expedientes hipotecarios activos (no veniados) en el estado <b>{ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien.GetDescriptionShort()}</b>" +
                        ", que <b>SI</b> tengan la <b>F. Sol. Posesión</b>" +
                        ", y que les falte la <b>F. Testimonio</b> o <b>F. Adjudicación</b> o <b>F. Solicitud</b>.";

                #endregion

                #endregion

                #region Conciliacion

                #region Facturas 

                case TipoIndicadorQa.ConciliacionFacturasHito1Caixa:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Caixa</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan el estado <b>Finalizado</b>.</span>";

                #endregion

                #endregion

                #region Alquiler

                #region Alquiler Indicadores

                case TipoIndicadorQa.AlquilerInactivo:
                    return "Expedientes que <b>NO</b> estén en los estados de <b>Finalización o Paralizado</b> y que tengan más de 90 días de inactividad en: <b>Estados (Fecha de Alta), Impulsos, Notas o Expediente.FechaUltimaModificación</b>";
                case TipoIndicadorQa.AlquilerPendientePreparacion:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.RecepcionExpediente.GetDescriptionShort()}</b>	en la fase <b>{TipoFaseEstado.Hip0103PreparacionDemanda.GetDescription()}</b>.";
                case TipoIndicadorQa.AlquilerEnRevision:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.RecepcionExpediente.GetDescriptionShort()}</b>, que no tengan fase o que la fase sea <b>{TipoFaseEstado.Hip0101RecepcionRevision.GetDescription()}</b>.";
                case TipoIndicadorQa.AlquilerPendientePresentacionDemanda:
                    return "";


                case TipoIndicadorQa.AlquilerIncidenciaDocumental:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.AlquilerRecepcionExpediente.GetDescriptionShort()}</b>, en la fase <b>{TipoFaseEstado.Hip0102IncidenciaDocumental.GetDescription()}</b> o en la fase <b>{TipoFaseEstado.Hip0104.GetDescription()}</b>.";

                case TipoIndicadorQa.AlquilerPendienteDemandaAdmitida:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.AlquilerPresentacionDemanda.GetDescriptionShort()}</b>, " +
                           $"que <b>NO</b> tengan la <b>Fecha de Demanda No Admitida</b> y <b>SI</b> tengan <b>Fecha de Presentación de Demanda</b>. " +
                           $"O Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.AlquilerTramitacionJuzgado.GetDescriptionShort()}</b> " +
                           "pero les falte la <b>Fecha Demanda Admitida</b>.";

                case TipoIndicadorQa.AlquilerPendienteOficiosEdictos:
                    return $"Expedientes que estén en el estado {ExpedienteEstadoTipo.AlquilerTramitacionJuzgado.GetDescriptionShort().FormatBold()}" +
                           ", sin el check de Oposición activado, con Fecha de Demanda Admitida" +
                           $", y que alguno de los demandados tenga {"Negativo en el Estado de la Notificación".FormatBold()}.";

                case TipoIndicadorQa.AlquilerRecursosApelacion:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.AlquilerTramitacionJuzgado.GetDescriptionShort()}</b>, que tengan <b>Fecha de Apelación</b> y que NO tengan <b>Resultado de Apelación</b>.";
                case TipoIndicadorQa.AlquilerFacturasPendientes:
                    return "";
                case TipoIndicadorQa.AlquilerPendienteEjecucionDineraria:
                    return "Expedientes <b>Ejecutivos NO Finalizados</b> y que están vinculados a un expediente de <b>Alquiler</b>.";

                case TipoIndicadorQa.AlquilerPendienteEjecucionLanzamiento:
                    return "Expedientes que están en el estado <b>Lanzamiento</b>.";
                case TipoIndicadorQa.AlquilerPendienteTransferirCantidadConsiganada:
                    return "Expedientes que están en el estado <b>Enervación</b>.";
                case TipoIndicadorQa.AlquilerPendienteSolicitarDecretoFin:
                    return $"Expedientes que están en el estado <b>{ExpedienteEstadoTipo.AlquilerTramitacionJuzgado.GetDescriptionShort()}</b>, que tengan <b>Fecha Demanda Admitida</b>, que NO tengan <b>Oposición</b>, y que todos los Deudores tengan <b>Fecha de notificación</b>.";
                case TipoIndicadorQa.AlquilerPendienteMediacion:
                    return "Expedientes NO <b>Finalizados</b>, que tengan <b>Estado Cliente = '2.4	MEDIACION'</b>.";
                case TipoIndicadorQa.AlquilerPendienteExpedienteEjecucion:
                    return "Expedientes que perteneciendo a CLIENTE: <b>ALTAMIRA SANTANDER REAL ESTATE SA, SAREB y LLOGATALIA, S.L.</b>" +
                           " han finalizado el procedimiento jurídico de desahucio" +
                           " y NO tengan expediente de ejecución vinculado" +
                           " y que NO se encuentren en alguno de los siguientes estados de cliente (Parado Cliente, Acción Enervada, Desistido, Acuerdo homologado).";
                case TipoIndicadorQa.AlquilerPendienteDemandaEjecucion:
                    return "Expedientes <b>Ejecutivos</b> en el estado <b>Presentación de Demanda</b>, que NO tienen <b>Fecha de Presentación de Demanda</b> y que están vinculados a un expediente de <b>Alquiler</b>.";
                case TipoIndicadorQa.AlquilerPendienteInstrucciones:
                    return "Expedientes en cualquier estado con subfase <b>Instrucciones Cliente</b>, o en estado <b>Tramite</b> con check <b>Instrucciones Cliente</b>.";
                case TipoIndicadorQa.AlquilerPendienteRevisionEjecutivo:
                    return $"Expedientes <b>Ejecutivos</b> que vienen de <b>Alquiler</b> y que están en el estado <b>{ExpedienteEstadoTipo.EjecutivoRecepcionExpediente.GetDescriptionShort()}</b>.";
                case TipoIndicadorQa.AlquilerDerivadoConcursal:
                    return $"Expedientes con el check <b>Derivado a Dpto. Concursal</b>.";

                case TipoIndicadorQa.AlquilerDecretoFinSinEjecutivo:
                    return $"Expedientes que estén en el estado {ExpedienteEstadoTipo.AlquilerTramitacionJuzgado.GetDescriptionShort().FormatBold()}, " +
                           $"que sean de los clientes de <b>Anticipa</b>, que tengan la <b>Fecha Decreto Fin</b> y <b>NO</b> tengan un <b>Expediente Ejecutivo</b> asociado.";

                #endregion

                #region Alquiler Alarmas

                case TipoIndicadorQa.AlquilerAlarmaPdteFechaResolucionIncidencia:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.AlquilerRecepcionExpediente.GetDescriptionShort()}</b>" +
                           $", con subfase <b>{TipoFaseEstado.Hip0102IncidenciaDocumental.GetDescription()}</b> o <b>{TipoFaseEstado.Hip0105.GetDescription()}</b>" +
                           $", y no tengan <b>Fecha de Resolución Inc. Doc.</b> para las oficinas de los clientes <b>ANTICIPA REAL ESTATE S.L.U, Anticipa-Empire Properties S.L, Anticipa-Empire Real Estate S.L.</b>";

                case TipoIndicadorQa.AlquilerAlarmaPresentacionDemanda:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.AlquilerRecepcionExpediente.GetDescriptionShort()}</b>" +
                           $", con subfase <b>{TipoFaseEstado.Hip0101RecepcionRevision.GetDescription()}</b> o <b>{TipoFaseEstado.Hip0103PreparacionDemanda.GetDescription()}</b>" +
                           $", y con una antigüedad superior a <b>30 días</b> desde <b>Recepción</b> o <b>Fecha de Resolución Inc. Doc.</b> para las oficinas de los clientes <b>SOLVIA, SAREB, SANTANDER Y LLOGATALIA</b>" +
                           $" y <b>7 días</b> para el cliente <b>ANTICIPA</b>.";

                case TipoIndicadorQa.AlquilerAlarmaRecepcionDenuncia:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.AlquilerPresentacionDenuncia.GetDescriptionShort()}</b>" +
                        $", que NO tengan la <b>Fecha de Presentación de Denuncia</b> y SI tengan <b>Fecha de envio al Procurador</b> con una antigüedad superior a <b>3 días</b>.";
                case TipoIndicadorQa.AlquilerAlarmaRecepcionDemandaSellada:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.AlquilerPresentacionDemanda.GetDescriptionShort()}</b>" +
                        $", que NO tengan la <b>Fecha de Presentación de Demanda</b> y SI tengan <b>Fecha de envio al Procurador</b> con una antigüedad superior a <b>3 días</b>.";

                case TipoIndicadorQa.AlquilerAlarmaRecepcionDemandaSelladaOrd:
                    return $"<b>Exp. Ordinarios Tipo Desahucios.</b> que estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioPresentacionDemanda.GetDescriptionShort()}</b>" +
                        $", que NO tengan la <b>Fecha de Presentación de Demanda</b> y SI tengan <b>Fecha de envio al Procurador</b> con una antigüedad superior a <b>3 días</b>.";
                case TipoIndicadorQa.AlquilerAlarmaRecepcionDemandaSelladaEjc:
                    return $"<b>Exp. Ejecutivos Tipo Desahucios.</b> que estén en el estado <b>{ExpedienteEstadoTipo.EjecutivoPresentacionDemanda.GetDescriptionShort()}</b>" +
                        $", que NO tengan la <b>Fecha de Presentación de Demanda</b> y SI tengan <b>Fecha de envio al Procurador</b> con una antigüedad superior a <b>3 días</b>.";
                case TipoIndicadorQa.AlquilerAlarmaRecepcionDemandaSelladaMn:
                    return $"<b>Exp. Monitorios Tipo Desahucios.</b> que estén en el estado <b>{ExpedienteEstadoTipo.MonitorioPresentacionDemanda.GetDescriptionShort()}</b>" +
                        $", que NO tengan la <b>Fecha de Presentación de Demanda</b> y SI tengan <b>Fecha de envio al Procurador</b> con una antigüedad superior a <b>3 días</b>.";

                case TipoIndicadorQa.AlquilerAlarmaDemandaAdmitida:
                    return "Expedientes que estén en el estado <b>Presentación de Demanda</b>, que NO tengan la <b>Fecha No Admitida</b>, que tengan <b>Fecha de Presentación de Demanda</b>, con una antigüedad superior a <b>30 días</b>.";

                case TipoIndicadorQa.AlquilerAlarmaPendienteNotificacion:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.AlquilerTramitacionJuzgado.GetDescriptionShort()}</b>" +
                           ", que NO tengan <b>Oposición</b>" +
                           ", que tengan <b>Fecha de Demanda Admitida</b> con una antigüedad superior a <b>30 días</b>" +
                           ", y que alguno de los Deudores NO tengan la <b>Fecha de Notificación</b>.";
                case TipoIndicadorQa.AlquilerAlarmaPendienteDecretoFin:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.AlquilerTramitacionJuzgado.GetDescriptionShort()}</b>" +
                           ", que tengan <b>Fecha Demanda Admitida</b>, que NO tengan <b>Oposición</b>" +
                           ", y que todos de los Deudores tengan <b>Notificación Positiva</b> o <b>Edictos</b>" +
                           ", y que la antigüedad de la <b>Fecha de Notificación</b> de todos los deudores sea súperior a <b>15 días</b>.";

                case TipoIndicadorQa.AlquilerAlarmaPendienteAjg:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.AlquilerTramitacionJuzgado.GetDescriptionShort()}</b>" +
                           ", con tick de <b>AJG</b>" +
                           ", y que tengan <b>Fecha de Suspensión</b> con una antigüedad superior a <b>45 días</b>.";
                case TipoIndicadorQa.AlquilerAlarmaPendienteAcuerdo:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.AlquilerTramitacionJuzgado.GetDescriptionShort()}</b>" +
                           ", con tick de <b>Pdte. Acuerdo</b>" +
                           ", y que tengan <b>Fecha de Suspensión</b> con una antigüedad superior a <b>15 días</b>.";
                case TipoIndicadorQa.AlquilerAlarmaPendienteInstruccionesCliente:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.AlquilerTramitacionJuzgado.GetDescriptionShort()}</b>" +
                           ", con tick de <b>Instrucciones Cliente</b>" +
                           ", y que tengan <b>Fecha de Suspensión</b> con una antigüedad superior a <b>10 días</b>.";

                case TipoIndicadorQa.AlquilerAlarmaEjecutarDecretoFinSentencia:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.AlquilerTramitacionJuzgado.GetDescriptionShort()}</b>" +
                           ", sin <b>Resultado Sentencia</b>" +
                           ", y con <b>Fecha Decreto Fin</b> o <b>Fecha Sentencia</b> con una antigüedad superior a <b>5 días</b>.";

                case TipoIndicadorQa.AlquilerAlarmaPendienteTomaPosesion:
                    return "Expedientes que NO estén en los estados <b>Enervación</b> o <b>Finalizado</b> (ni tampoco <b>Paralizado</b>), y que desde su recepción tengan una antigüedad superior a <b>180 días</b>.";
                case TipoIndicadorQa.AlquilerAlarmaPendienteEnervacion:
                    return "Expedientes que estén en el estado <b>Enervación</b>, y que la fecha de creación del estado tengan una antigüedad superior a <b>20 días</b>.";

                case TipoIndicadorQa.AlquilerAlarmaImpulsoPendienteAplicativoCliente:
                    return "Expedientes de los clientes (<b>Solvia, Anticipa</b>), con algún impulso que <b>NO</b> tiene marcado el check <b>Aplicativo Cliente</b>.";

                #endregion

                #region Facturas 

                case TipoIndicadorQa.AlquilerFacturaAltamiraHito1:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Altamira</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan (<b>Facturación Completa</b> o <b>No Facturable</b>).</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan estado <b>Finalizado</b>.</span>";
                case TipoIndicadorQa.AlquilerFacturaEjcAltamiraHito1:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Altamira</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan (<b>Facturación Completa</b> o <b>No Facturable</b>).</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean <b>Exp. Ejecutivos Tipo Desahucios</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan estado <b>Presentación Demanda</b> y definida <b>Fecha de Presentación</b>.</span>";

                #region Alq - Llogatalia

                case TipoIndicadorQa.AlquilerFacturaLlogataliaHito1:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Llogatalia</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Demanda Presentada</b>.</span>";
                case TipoIndicadorQa.AlquilerFacturaLlogataliaHito2:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Llogatalia</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 2</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Lanzamiento Positivo</b> o <b>Finalizado - Entrega Posesión</b>.</span>";
                case TipoIndicadorQa.AlquilerFacturaEjcLlogataliaHito1:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Llogatalia</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean <b>Exp. Ejecutivos Tipo Desahucios</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 1</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Demanda Presentada</b>.</span>";
                case TipoIndicadorQa.AlquilerFacturaPdteLlogatalia:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Llogatalia</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean <b>Exp. de Alquiler o Ejecutivos Tipo Desahucios</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Fecha Fin (Finalizados)</b>.</span>";

                #endregion

                #region Alq - Aliseda Alquileres

                case TipoIndicadorQa.AlquilerFacturaAlisedaHito1:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Aliseda</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Demanda Presentada</b> o <b>Denuncia Presentada</b>.</span>";
                case TipoIndicadorQa.AlquilerFacturaAlisedaHito2:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Aliseda</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 2</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Lanzamiento Positivo</b> o <b>Finalizado - Entrega Posesión</b>.</span>";
                case TipoIndicadorQa.AlquilerFacturaEjcAlisedaHito1:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Aliseda</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean <b>Exp. Ejecutivos Tipo Desahucios</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 1</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Demanda Presentada</b>.</span>";
                case TipoIndicadorQa.AlquilerFacturaPdteAliseda:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Aliseda</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean <b>Exp. de Alquiler o Ejecutivos Tipo Desahucios</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Fecha Fin (Finalizados)</b>.</span>";

                #endregion

                #region Alq - Ahora Asset Management

                case TipoIndicadorQa.AlquilerFacturaAhoraAssetManagementHito1:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Ahora Asset Management</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Demanda Presentada</b> o <b>Denuncia Presentada</b>.</span>";
                case TipoIndicadorQa.AlquilerFacturaAhoraAssetManagementHito2:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Ahora Asset Management</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 2</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que esten <b>Finalizados</b>.</span>";
                //           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Lanzamiento Positivo</b> o <b>Finalizado - Entrega Posesión</b>.</span>";

                #endregion

                #region Alq - Fidere

                case TipoIndicadorQa.AlquilerFacturaFidereHito1:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Fidere Quasar</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Demanda Presentada</b>.</span>";
                case TipoIndicadorQa.AlquilerFacturaFidereHito2:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Fidere Quasar</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 2</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Lanzamiento Positivo</b> o <b>Finalizado - Entrega Posesión</b>.</span>";
                case TipoIndicadorQa.AlquilerFacturaEjcFidereHito1:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Fidere Quasar</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean <b>Exp. Ejecutivos Tipo Desahucios</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 1</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Demanda Presentada</b>.</span>";
                case TipoIndicadorQa.AlquilerFacturaPdteFidere:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Fidere Quasar</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean <b>Exp. de Alquiler o Ejecutivos Tipo Desahucios</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Fecha Fin (Finalizados)</b>.</span>";

                #endregion

                #region Alq - MerlinRetail

                case TipoIndicadorQa.AlquilerFacturaMerlinRetailHito1:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Merlin Retail</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Demanda Presentada</b>.</span>";
                case TipoIndicadorQa.AlquilerFacturaMerlinRetailHito2:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Merlin Retail</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 2</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Lanzamiento Positivo</b> o <b>Finalizado - Entrega Posesión</b>.</span>";
                case TipoIndicadorQa.AlquilerFacturaEjcMerlinRetailHito1:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Merlin Retail</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean <b>Exp. Ejecutivos Tipo Desahucios</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 1</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Demanda Presentada</b>.</span>";
                case TipoIndicadorQa.AlquilerFacturaPdteMerlinRetail:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Merlin Retail</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean <b>Exp. de Alquiler o Ejecutivos Tipo Desahucios</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Fecha Fin (Finalizados)</b>.</span>";

                #endregion

                #region Alq - SolviaHoteles

                case TipoIndicadorQa.AlquilerFacturaSolviaHotelesHito1:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Solvia Hoteles</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Demanda Presentada</b>.</span>";
                case TipoIndicadorQa.AlquilerFacturaSolviaHotelesHito2:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Solvia Hoteles</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 2</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Lanzamiento Positivo</b> o <b>Finalizado - Entrega Posesión</b>.</span>";
                case TipoIndicadorQa.AlquilerFacturaEjcSolviaHotelesHito1:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Solvia Hoteles</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean <b>Exp. Ejecutivos Tipo Desahucios</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 1</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Demanda Presentada</b>.</span>";
                case TipoIndicadorQa.AlquilerFacturaPdteSolviaHoteles:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Solvia Hoteles</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean <b>Exp. de Alquiler o Ejecutivos Tipo Desahucios</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Fecha Fin (Finalizados)</b>.</span>";

                #endregion

                #region Alq - Azzam

                case TipoIndicadorQa.AlquilerFacturaAzzamHito1:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Azzam</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Demanda Presentada</b> o <b>Denuncia Presentada</b>.</span>";
                case TipoIndicadorQa.AlquilerFacturaAzzamHito2:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Azzam</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 2</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Lanzamiento Positivo</b> o <b>Finalizado</b>.</span>";
                case TipoIndicadorQa.AlquilerFacturaEjcAzzamHito1:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Azzam</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean <b>Exp. Ejecutivos Tipo Desahucios</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Demanda Presentada</b>.</span>";

                #endregion

                #region Alq - Homes

                case TipoIndicadorQa.AlquilerFacturaHomesHito1:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>BÁSICO HOMES GESTION</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Demanda Presentada</b> o <b>Denuncia Presentada</b>.</span>";
                case TipoIndicadorQa.AlquilerFacturaHomesHito2:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>BÁSICO HOMES GESTION</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 2</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Lanzamiento Positivo</b> o <b>Finalizado</b>.</span>";
                case TipoIndicadorQa.AlquilerFacturaEjcHomesHito1:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>BÁSICO HOMES GESTION</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean <b>Exp. Ejecutivos Tipo Desahucios</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Demanda Presentada</b>.</span>";

                #endregion

                #region Alq - Anticipa

                case TipoIndicadorQa.AlquilerFacturaAnticipaHito1:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Anticipa</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan (<b>Facturación Completa</b> o <b>No Facturable</b>).</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan estado <b>Presentación Demanda</b> y definida la <b>Fecha Presentación</b>.</span>";

                case TipoIndicadorQa.AlquilerFacturaAnticipaHito2:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Anticipa</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan (<b>Facturación Completa</b> o <b>No Facturable</b>).</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que SI tengan <b>Factura Hito 1</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 2</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan estado <b>Finalizado</b>.</span>";

                case TipoIndicadorQa.AlquilerFacturaEjcAnticipaHito1:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Anticipa</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 1</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan (<b>Facturación Completa</b> o <b>No Facturable</b>).</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan estado <b>Presentación Demanda</b> y definida la <b>Fecha Presentación</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean procedimientos <b>Ejecutivos</b> del área <b>Desahucios</b>.</span>";



                //case TipoIndicadorQa.AlquilerFacturaAnticipaHito1_Finalizado:
                //    return $"Expedientes que cumplan las siguientes condiciones:" +
                //           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Anticipa</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Facturación Completa</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que esté <b>Finalizado</b>.</span>";
                //case TipoIndicadorQa.AlquilerFacturaAnticipaHito3:
                //    return $"Expedientes que cumplan las siguientes condiciones:" +
                //           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Anticipa</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 3</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Facturación Completa</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que tengan estado <b>Enervación</b>.</span>";
                //case TipoIndicadorQa.AlquilerFacturaAnticipaHito2_ConVista_0_120:
                //    return $"Expedientes que cumplan las siguientes condiciones:" +
                //           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Anticipa</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Facturación Completa</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 2</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que tengan estado <b>Presentación Demanda</b> y definida la <b>Fecha Presentación</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que tengan el estado <b>Posesión y Lanzamiento</b> o <b>Finalizado</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Vista de Lanzamiento con resultado positivo</b> o <b>Estado 'Posesión y Lanzamiento' con 'F. Rec. Posesión' definida</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que tengan vista de tipo <b>Tramite - Celebración de Vista</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que hayan transcurrido <b>menos de 120 días</b> desde la <b>Fecha de Presentación Demanda hasta Estado Lanzamiento F. Rec. Posesión</b> o desde <b>Fecha de Presentación Demanda hasta Fecha de Lanzamiento Positivo</b>.</span>";
                //case TipoIndicadorQa.AlquilerFacturaAnticipaHito2_SinVista_0_120:
                //    return $"Expedientes que cumplan las siguientes condiciones:" +
                //           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Anticipa</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Facturación Completa</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 2</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que tengan estado <b>Presentación Demanda</b> y definida la <b>Fecha Presentación</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que tengan el estado <b>Posesión y Lanzamiento</b> o <b>Finalizado</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Vista de Lanzamiento con resultado positivo</b> o <b>Estado 'Posesión y Lanzamiento' con 'F. Rec. Posesión' definida</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que NO tengan vista de tipo <b>Tramite - Celebración de Vista</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que hayan transcurrido <b>menos de 120 días</b> desde la <b>Fecha de Presentación Demanda hasta Estado Lanzamiento F. Rec. Posesión</b> o desde <b>Fecha de Presentación Demanda hasta Fecha de Lanzamiento Positivo</b>.</span>";

                //case TipoIndicadorQa.AlquilerFacturaAnticipaHito2_ConVista_121_180:
                //    return $"Expedientes que cumplan las siguientes condiciones:" +
                //           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Anticipa</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Facturación Completa</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 2</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que tengan estado <b>Presentación Demanda</b> y definida la <b>Fecha Presentación</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que tengan el estado <b>Posesión y Lanzamiento</b> o <b>Finalizado</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Vista de Lanzamiento con resultado positivo</b> o <b>Estado 'Posesión y Lanzamiento' con 'F. Rec. Posesión' definida</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que tengan vista de tipo <b>Tramite - Celebración de Vista</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que hayan transcurrido <b>entre 121 y 180 días</b> desde la <b>Fecha de Presentación Demanda hasta Estado Lanzamiento F. Rec. Posesión</b> o desde <b>Fecha de Presentación Demanda hasta Fecha de Lanzamiento Positivo</b>.</span>";
                //case TipoIndicadorQa.AlquilerFacturaAnticipaHito2_SinVista_121_180:
                //    return $"Expedientes que cumplan las siguientes condiciones:" +
                //           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Anticipa</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Facturación Completa</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 2</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que tengan estado <b>Presentación Demanda</b> y definida la <b>Fecha Presentación</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que tengan el estado <b>Posesión y Lanzamiento</b> o <b>Finalizado</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Vista de Lanzamiento con resultado positivo</b> o <b>Estado 'Posesión y Lanzamiento' con 'F. Rec. Posesión' definida</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que NO tengan vista de tipo <b>Tramite - Celebración de Vista</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que hayan transcurrido <b>entre 121 y 180 días</b> desde la <b>Fecha de Presentación Demanda hasta Estado Lanzamiento F. Rec. Posesión</b> o desde <b>Fecha de Presentación Demanda hasta Fecha de Lanzamiento Positivo</b>.</span>";
                //case TipoIndicadorQa.AlquilerFacturaAnticipaHito2_ConVista_181:
                //    return $"Expedientes que cumplan las siguientes condiciones:" +
                //           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Anticipa</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Facturación Completa</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 2</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que tengan estado <b>Presentación Demanda</b> y definida la <b>Fecha Presentación</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que tengan el estado <b>Posesión y Lanzamiento</b> o <b>Finalizado</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Vista de Lanzamiento con resultado positivo</b> o <b>Estado 'Posesión y Lanzamiento' con 'F. Rec. Posesión' definida</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que tengan vista de tipo <b>Tramite - Celebración de Vista</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que hayan transcurrido <b>más de 180 días</b> desde la <b>Fecha de Presentación Demanda hasta Estado Lanzamiento F. Rec. Posesión</b> o desde <b>Fecha de Presentación Demanda hasta Fecha de Lanzamiento Positivo</b>.</span>";
                //case TipoIndicadorQa.AlquilerFacturaAnticipaHito2_SinVista_181:
                //    return $"Expedientes que cumplan las siguientes condiciones:" +
                //           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Anticipa</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Facturación Completa</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 2</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que tengan estado <b>Presentación Demanda</b> y definida la <b>Fecha Presentación</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que tengan el estado <b>Posesión y Lanzamiento</b> o <b>Finalizado</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Vista de Lanzamiento con resultado positivo</b> o <b>Estado 'Posesión y Lanzamiento' con 'F. Rec. Posesión' definida</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que NO tengan vista de tipo <b>Tramite - Celebración de Vista</b>.</span>" +
                //           $"<br/><span class='qba-paddingL20'> - Que hayan transcurrido <b>más de 180 días</b> desde la <b>Fecha de Presentación Demanda hasta Estado Lanzamiento F. Rec. Posesión</b> o desde <b>Fecha de Presentación Demanda hasta Fecha de Lanzamiento Positivo</b>.</span>";


                #endregion

                case TipoIndicadorQa.AlquilerFacturasHito1:
                    return "Expedientes de Alquiler que tengan <b>Fecha de Presentación de Demanda</b> y no tengan Factura con el hito <b>Alquiler – Presentación Demanda</b>.";

                case TipoIndicadorQa.AlquilerFacturasHito2:
                    return "Expedientes de Alquiler que estén <b>Finalizados</b> y no tengan Factura con el hito <b>Alquiler – Finalizado</b>.";

                #endregion

                #endregion

                #region Negociación

                #region Negociación Indicadores

                case TipoIndicadorQa.NegociacionPrecontenciosoPendienteAsignar:
                    return "Expedientes Hipotecarios, Ejecutivos y Ordinarios que estén en el estado <b>Recepción de Expediente</b> y que NO tengan asignado el <b>Gestor</b> (Solo para el cliente: Bankia).";

                case TipoIndicadorQa.NegociacionPrecontencioso:
                    return $"Expedientes Hipotecarios, Ejecutivos y Ordinarios de la Oficina 'ACINSA (BANKIA S.A.)'. " +
                        $"Que SI tengan un Gestor Asociado (Precontencioso); " +
                        $"Que NO tenga valor en 'Precontencioso - FechaFin';" +
                        $"Que sean de tipo Ordinario o Ejecutivo o Hipotecario;" +
                        $"Que su estado sea distinto de “Finalizado”";

                case TipoIndicadorQa.NegociacionAlquilerPrecontencioso:
                    return $"Expedientes de Alquiler que estén en el estado <b>Recepción de Expediente</b>," +
                        $" que <b>Tipo Area = Negociaciones</b>" +
                        $" y que SI tengan asignado el <b>Gestor</b>.";
                case TipoIndicadorQa.NegociacionAlquilerPrecontenciosoPendienteAsignar:
                    return $"Expedientes de Alquiler que estén en el estado <b>Recepción de Expediente</b>," +
                        $" que <b>Tipo Area = Negociaciones</b>" +
                        $" y que NO tengan asignado el <b>Gestor</b>.";
                case TipoIndicadorQa.NegociacionAlquilerContencioso:
                    return $"Expedientes de Alquiler que estén en el estado <b>{ExpedienteEstadoTipo.AlquilerLanzamiento.GetDescriptionShort()}</b> " +
                        $"y que SI tengan asignado el <b>Gestor</b> " +
                        $"(Solo para los clientes: Sabadel, Proyecto Empire Real Estate, Empire Properties Spain).";
                case TipoIndicadorQa.NegociacionAlquilerContenciosoPendienteAsignar:
                    return $"Expedientes de Alquiler que estén en el estado <b>{ExpedienteEstadoTipo.AlquilerLanzamiento.GetDescriptionShort()}</b> " +
                        $"y que NO tengan asignado el <b>Gestor</b> " +
                        $"(Solo para los clientes: Sabadel, Proyecto Empire Real Estate, Empire Properties Spain).";


                case TipoIndicadorQa.NegociacionContencioso:
                    return "Expedientes <b>Hipotecarios</b> de <b>Bankia</b> que SI tengan asignado el <b>Gestor</b> y no estén <b>Finalizados</b>.";
                case TipoIndicadorQa.NegociacionContenciosoPendienteAsignar:
                    return "Expedientes <b>Hipotecarios</b> de <b>Bankia</b> que estén en el estado <b>Adjudicación del Bien</b> y que NO tengan asignado el <b>Gestor</b>.";
                case TipoIndicadorQa.NegociacionContenciosoFechaTestimonio:
                    return "Expedientes <b>Hipotecarios</b> de <b>Bankia</b> que estén en el estado <b>Adjudicación del Bien</b>, que tengan <b>F. Testimonio</b>, y que <b>SI</b> tengan asignado el <b>Gestor</b>.";


                case TipoIndicadorQa.NegociacionTpa:
                    return "Expedientes de TPA que <b>SI</b> tengan asignado el <b>Gestor</b> y les falte la <b>Fecha Fin de Contencioso</b>.";

                case TipoIndicadorQa.NegociacionTpaPendienteAsignar:
                    return "Expedientes de Toma de Posesión Anticipada (TPA) que NO tengan asignado el <b>Gestor</b>.";

                case TipoIndicadorQa.NegociacionPrecontenciosoFinalizada:
                    return "Expedientes que tienen rellena la <b>Fecha de Fin</b> del área Precontencioso de la Negociación.";
                case TipoIndicadorQa.NegociacionContenciosoFinalizada:
                    return "Expedientes que tienen rellena la <b>Fecha de Fin</b> del área Contencioso de la Negociación.";

                #endregion

                #region Negociación - Alarmas

                case TipoIndicadorQa.NegociacionAlarmaExpiradoTiempoNegAlquiler:
                    return $"Expedientes de <b>Alquiler</b> que estén en el estado <b>{ExpedienteEstadoTipo.AlquilerRecepcionExpediente.GetDescriptionShort()}</b>" +
                           ", que en <b>Negociación - Precontencioso</b> NO tengan <b>Fecha Fin</b>" +
                           ", y que tengan <b>Fecha del Estado</b> con una antigüedad superior a <b>30 días</b>.";

                case TipoIndicadorQa.NegociacionAlarmaExpiradoTiempoNegPrecontencioso:
                    return $"Expedientes (<b>Excluyendo los de Alquiler</b>) que estén en estado <b>Recepción de Expediente</b>" +
                           ", que en <b>Negociación - Precontencioso</b> NO tengan <b>Fecha Fin</b>" +
                           ", y que tengan <b>Fecha del Estado</b> con una antigüedad superior a <b>30 días</b>.";

                #endregion

                #endregion

                #region Ejecutivo

                #region Ejecutivo Indicadores

                case TipoIndicadorQa.EjecutivoInactivo:
                    return "Expedientes que <b>NO</b> estén en los estados de <b>Finalización o Paralizado</b> y que tengan más de 90 días de inactividad en: <b>Estados (Fecha de Alta), Impulsos, Notas o Expediente.FechaUltimaModificación</b>";
                case TipoIndicadorQa.EjecutivoPendientePreparacionDemanda:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.EjecutivoRecepcionExpediente.GetDescriptionShort()}</b> en la fase <b>{TipoFaseEstado.Hip0103PreparacionDemanda.GetDescription()}</b>, o en el estado <b>{ExpedienteEstadoTipo.EjecutivoPresentacionDemanda.GetDescriptionShort()}</b> pero les falte la <b>Fecha de Envio al Procurador</b>.";
                case TipoIndicadorQa.EjecutivoIncidenciaDocumental:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.RecepcionExpediente.GetDescriptionShort()}</b>" +
                           $", en la fase <b>{TipoFaseEstado.Hip0102IncidenciaDocumental.GetDescription()}</b> o en la fase <b>{TipoFaseEstado.Hip0104.GetDescription()}</b>.";
                case TipoIndicadorQa.EjecutivoPendienteDemandaAdmitida:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.EjecutivoPresentacionDemanda.GetDescriptionShort()}</b>" +
                           $", que <b>NO</b> tengan <b>Fecha de Demanda NO Admitida</b>" +
                           $" y <b>SI</b> tengan <b>Fecha de Presentación de Demanda</b>" +
                           $"; O Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.EjecutivoAdmisionTramiteEmbargo.GetDescriptionShort()}</b>" +
                           $" y que <b>NO</b> tengan <b>Fecha Demanda Admitida</b>.";
                case TipoIndicadorQa.EjecutivoConOposicion:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.EjecutivoAdmisionTramiteEmbargo.GetDescriptionShort()}</b>, y que alguno de los intervinientes hayan presentado <b>Oposición</b>.";
                case TipoIndicadorQa.EjecutivoPendienteRequerimientoPago:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.EjecutivoAdmisionTramiteEmbargo.GetDescriptionShort()}</b>" +
                           $", y que tengan algún <b>Requerimiento de Pago</b> negativo.";
                case TipoIndicadorQa.EjecutivoPendienteSolicitarSubasta:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.EjecutivoSubasta.GetDescriptionShort()}</b>" +
                           $", y que NO tengan nunguna <b>Subasta</b>.";
                case TipoIndicadorQa.EjecutivoDecretoConvocatoriaSubasta:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.EjecutivoSubasta.GetDescriptionShort()}</b>" +
                           ", que la subasta activa no esté suspendida ni suspendido el decreto de subasta y tenga <b>F. Decreto Subasta</b>" +
                           ", pero que le falte <b>F. Celebración</b>.";
                case TipoIndicadorQa.EjecutivoPendienteSubastasSuspendidas:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.EjecutivoSubasta.GetDescriptionShort()}</b>" +
                           $" y que la subasta activa esté suspendida.";
                case TipoIndicadorQa.EjecutivoPendienteAdjudicacion:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.EjecutivoSubasta.GetDescriptionShort()}</b>" +
                           $" y que tenga <b>F. Sol. Adjudicación</b>.";



                case TipoIndicadorQa.EjecutivoPendienteTestimonioAdjudicacion:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.EjecutivoAdjudicacionBien.GetDescriptionShort()}</b>" +
                           ", y que tengan la <b>Fecha de Adjudicación</b>" +
                           " pero les falte la <b>Fecha de Testimonio</b>.";
                case TipoIndicadorQa.EjecutivoPendienteSolicitudPosesion:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.EjecutivoAdjudicacionBien.GetDescriptionShort()}</b>" +
                           ", y que tengan la <b>Fecha de Testimonio</b>" +
                           " pero les falte la <b>Fecha de Posesión</b>.";
                case TipoIndicadorQa.EjecutivoPendienteLanzamiento:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.EjecutivoAdjudicacionBien.GetDescriptionShort()}</b>" +
                           ", y que tengan la <b>Fecha de Posesión</b>" +
                           " pero les falte la <b>Fecha de Lanzamiento</b>.";

                case TipoIndicadorQa.EjecutivoProrrogaEmbargo:
                    return $"Inmuebles de Expedientes Ejecutivos que tengan <b>F. Inscripción de Embargo</b> o <b>F. Solicitud Prorroga de Embargo</b>" +
                           $", y que no tengan <b>F. Instrucciones de NO Prorroga de Embargo</b>.";

                case TipoIndicadorQa.EjecutivoPendienteAvaluo:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.EjecutivoEfectividadEmbargo.GetDescriptionShort()}</b>" +
                           ", y que alguno de los deudores tengan algún <b>Bien Inmueble</b>" +
                           ", y que el mismo tenga marcada la casilla <b>Procede Avalúo</b>" +
                           ", y no tenga dato en <b>Tasación Subasta</b>.";

                #endregion

                #region Ejecutivo Alarmas 

                case TipoIndicadorQa.EjecutivoAlarmaRecepcionDemandaSellada:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.EjecutivoPresentacionDemanda.GetDescriptionShort()}</b>" +
                           $", que NO tengan <b>Fecha de Presentación</b>" +
                           $" y SI tengan <b>Fecha de Envío Demanda al Procurador</b> con una antigüedad superior a <b>3 días</b>.";
                case TipoIndicadorQa.EjecutivoAlarmaAdmisionDemanda:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.EjecutivoPresentacionDemanda.GetDescriptionShort()}</b>" +
                           $", que NO tengan la <b>Fecha de Demanda NO Admitida</b>" +
                           $" y SI tengan <b>Fecha de Presentación</b> con una antigüedad superior a <b>90 días</b>.";
                case TipoIndicadorQa.EjecutivoAlarmaRequerimientoPago:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.EjecutivoAdmisionTramiteEmbargo.GetDescriptionShort()}</b>" +
                           ", que tengan algún <b>Requerimiento de Pago</b> negativo" +
                           ", y que la <b>Fecha de Demanda Admitida</b> tenga una antigüedad superior a <b>90 días</b>.";
                case TipoIndicadorQa.EjecutivoAlarmaAveriguacionPatrimonial:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.EjecutivoAdmisionTramiteEmbargo.GetDescriptionShort()}</b>" +
                           ", que tengan <b>Averiguación Patrimonial</b> para todos los deudores" +
                           ", y que alguna de las <b>Fechas de Averiguación Patrimonial</b> tenga una antigüedad superior a <b>180 días</b>.";
                case TipoIndicadorQa.EjecutivoAlarmaMejoraEmbargo:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.EjecutivoAdmisionTramiteEmbargo.GetDescriptionShort()}</b>" +
                           ", que tengan <b>Averiguación Patrimonial</b> para todos los deudores" +
                           ", y que alguna de las <b>Fechas de Averiguación Patrimonial</b> tenga una antigüedad superior a <b>90 días</b>.";
                case TipoIndicadorQa.EjecutivoAlarmaDecretoEmbargo:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.EjecutivoAdmisionTramiteEmbargo.GetDescriptionShort()}</b>" +
                           ", que tengan <b>Mejora de Embargo</b> para todos los deudores" +
                           ", y que alguna de las <b>Fechas de Mejora de Embargo</b> tenga una antigüedad superior a <b>90 días</b>.";

                case TipoIndicadorQa.EjecutivoAlarmaProrrogaEmbargo:
                    return $"Inmuebles de Expedientes Ejecutivos que <b>NO</b> tengan <b>F. Instrucciones de NO Prorroga de Embargo</b>" +
                           $", y que tengan <b>F. Inscripción de Embargo</b> o <b>F. Solicitud Prorroga de Embargo</b>" +
                           $" con una antigüedad superior a <b>3.5 años</b>.";

                #endregion

                #endregion

                #region Ordinario

                #region Ordinario Indicadores

                case TipoIndicadorQa.OrdinarioInactivo:
                    return "Expedientes que <b>NO</b> estén en los estados de <b>Finalización o Paralizado</b> y que tengan más de 90 días de inactividad en: <b>Estados (Fecha de Alta), Impulsos, Notas o Expediente.FechaUltimaModificación</b>";
                case TipoIndicadorQa.OrdinarioIncidenciaDocumental:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioRecepcionExpediente.GetDescriptionShort()}</b>, en la fase <b>{TipoFaseEstado.Hip0102IncidenciaDocumental.GetDescription()}</b> o en la fase <b>{TipoFaseEstado.Hip0104.GetDescription()}</b>.";



                case TipoIndicadorQa.OrdinarioPendientePreparacionDemanda:
                    return $"Expedientes que: " +
                        $"1. Estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioRecepcionExpediente.GetDescriptionShort()}</b>, en la fase <b>{TipoFaseEstado.Hip0103PreparacionDemanda.GetDescription()}</b> o " +
                        $"2. Estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioPresentacionDemanda.GetDescriptionShort()}</b>, pero les falte la <b>Fecha de Envio Procurador</b>.";
                case TipoIndicadorQa.OrdinarioPendienteDecretoAdmision:
                    return $"Expedientes que: " +
                        $"1. Estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioPresentacionDemanda.GetDescriptionShort()}</b>, que <b>NO</b> tengan <b>Fecha de Demanda NO Admitida</b> y <b>SI</b> tengan <b>Fecha de Presentación de Demanda</b> o " +
                        $"2. Estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioAutoAdmisionNotificacion.GetDescriptionShort()}</b>, y que <b>NO</b> tengan <b>Fecha de Demanda Admitida</b>.";
                case TipoIndicadorQa.OrdinarioAudienciaPrevia:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioTramitacionJuzgado.GetDescriptionShort()}</b>, y que tenan <b>Fecha de Audiencia Previa</b>.";
                case TipoIndicadorQa.OrdinarioJuicio:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioJuicio.GetDescriptionShort()}</b>, y que tenan <b>Fecha de Juicio</b>.";

                case TipoIndicadorQa.OrdinarioSentencia:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioSentencia.GetDescriptionShort()}</b>, y que tenan <b>Fecha de Sentencia</b>.";
                case TipoIndicadorQa.OrdinarioRecursoApelacion:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioSentencia.GetDescriptionShort()}</b>, y que tenan <b>Fecha de Apelación</b>.";
                case TipoIndicadorQa.OrdinarioCasacionInfraccionProcesal:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioSentencia.GetDescriptionShort()}</b>, y que tenan <b>Fecha Infracción Procesal</b>.";

                case TipoIndicadorQa.OrdinarioEjecucionSentencia:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioFinalizacion.GetDescriptionShort()}</b>," +
                        $" y en la subfase <b>Ejecución de Sentencia</b>.";

                case TipoIndicadorQa.OrdinarioPendienteFirmezaSentenciaEstimatoria:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioSentencia.GetDescriptionShort()}</b>, " +
                        $"que tengan <b>Fecha de Sentencia</b>, que el resultado sea: <b>Estimatoria</b> y que <b>NO</b> tengan <b>Fecha de Firmeza de Sententecia</b>.";

                #endregion

                #region Ordinario - Alarmas

                case TipoIndicadorQa.OrdinarioAlarmaPdteDemanda:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioRecepcionExpediente.GetDescriptionShort()}</b>, con una antigüedad superior a <b>30 días</b>.";

                case TipoIndicadorQa.OrdinarioAlarmaDecretoAdmision:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioTramitacionJuzgado.GetDescriptionShort()}</b>, " +
                        $"y que tenan <b>Fecha de Presentación</b> con una antigüedad superior a <b>30 días</b>.";

                case TipoIndicadorQa.OrdinarioAlarmaEmplazamientoPositivo:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioTramitacionJuzgado.GetDescriptionShort()}</b>, " +
                        $"y que tenan algún <b>Emplazamiento Positivo</b> con una antigüedad superior a <b>20 días</b>.";

                case TipoIndicadorQa.OrdinarioAlarmaEmplazamientoNegativo:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioTramitacionJuzgado.GetDescriptionShort()}</b>, " +
                        $"y que tenan algún <b>Emplazamiento Negativo</b> con una antigüedad superior a <b>30 días</b>.";

                case TipoIndicadorQa.OrdinarioAlarmaAudienciaPrevia:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioTramitacionJuzgado.GetDescriptionShort()}</b>, " +
                        $"y que tenan algún <b>Emplazamiento Negativo</b> con una antigüedad superior a <b>30 días</b>, " +
                        $"y que tenan <b>Fecha de Audiencia Previa</b>.";

                case TipoIndicadorQa.OrdinarioAlarmaJuicio:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioTramitacionJuzgado.GetDescriptionShort()}</b>, " +
                        $"y que tenan <b>Fecha de Audiencia Previa</b> con una antigüedad superior a <b>60 días</b>.";

                case TipoIndicadorQa.OrdinarioAlarmaSentencia:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioJuicio.GetDescriptionShort()}</b>, " +
                        $"y que tenan <b>Fecha de Juicio</b> con una antigüedad superior a <b>30 días</b>.";

                case TipoIndicadorQa.OrdinarioAlarmaPdteSentencia:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioSentencia.GetDescriptionShort()}</b>, " +
                        $"y que tenan <b>Fecha de Firmeza Sentencia:</b> con una antigüedad superior a <b>30 días</b>.";

                case TipoIndicadorQa.OrdinarioAlarmaRecepcionDemandaSellada:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioPresentacionDemanda.GetDescriptionShort()}</b>, " +
                        $"que NO tengan <b>Fecha de Presentación</b> " +
                        $"y si la <b>Fecha de Envío Demanda al Procurador</b> con una antiguedad superior a <b>3 días</b>.";


                #endregion

                #region Facturas 

                case TipoIndicadorQa.OrdinarioFacturasHito1Caixa:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean del cliente <b>Caixa</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de tipo <b>Desahucios</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan el estado <b>Sentencia</b> o <b>Finalizado</b>.</span>";

                #endregion

                #endregion

                #region OrdinarioCs - Facturas

                case TipoIndicadorQa.OrdinarioCsFacturasBancoPopularHito1:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de la oficina <b>Banco Popular</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 1</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Fecha de Allanamiento</b>.</span>";

                case TipoIndicadorQa.OrdinarioCsFacturasBancoPopularHito2:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de la oficina <b>Banco Popular</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 2</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioCsFinalizacion.GetDescriptionShort()}</b>.</span>";

                case TipoIndicadorQa.OrdinarioCsFacturasHito2PendienteFinalizar:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                        $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 2</b>.</span>" +
                        $"<br/><span class='qba-paddingL20'> - Que estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioCsSentencia.GetDescriptionShort()}</b>.</span>" +
                        //$"<br/><span class='qba-paddingL20'> - Que <b>NO</b> tenga <b>Recurso Apelación</b>.</span>" +
                        $"<br/><span class='qba-paddingL20'> - Que <b>SI</b> tenga <b>Fecha de Sentencia</b> con una antigüedad superior a <b>30 días</b>.</span>";

                #endregion

                #region OrdinarioCs Alarmas

                case TipoIndicadorQa.OrdinarioCsAlarmaVencimientoAllanamiento:
                    return $"Expedientes que estén en estado <b>{ExpedienteEstadoTipo.OrdinarioCsRecepcionExpediente.GetDescriptionShort()}</b>" +
                           $", que la Subfase del estado sea <b>distinta</b> de <b>{TipoFaseEstado.Ocs0101.GetDescription()}</b>" +
                           $", que <b>NO</b> tengan <b>Fecha de Allanamiento</b>" +
                           $", y <b>SI</b> tengan <b>Fecha Notificación Demanda</b> con una antigüedad superior a <b>13 días</b>.";

                case TipoIndicadorQa.OrdinarioCsAlarmaPendienteCopiaSelladaAllanamiento:
                    return $"Expedientes que <b>NO</b> estén en estado <b>{ExpedienteEstadoTipo.OrdinarioCsFinalizacion.GetDescriptionShort()} o {ExpedienteEstadoTipo.OrdinarioCsProcesoParalizado.GetDescriptionShort()}</b>" +
                           $", que <b>NO</b> tengan <b>Fecha de Copia Sellada de Allanamiento</b>, y <b>SI</b> tengan <b>Fecha de Allanamiento</b> con una antigüedad superior a <b>3 días</b>.";

                case TipoIndicadorQa.OrdinarioCsAlarmaSentencia:
                    return $"Expedientes que tengan <b>Fecha de la Copia Sellada Allanamiento</b> con una antigüedad superior a <b>90 días</b>" +
                           $", y que NO tengan el estado <b>{ExpedienteEstadoTipo.OrdinarioCsSentencia.GetDescriptionShort()}</b>.";

                case TipoIndicadorQa.OrdinarioCsAlarmaPendienteFinalizacion:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.OrdinarioCsSentencia.GetDescriptionShort()}</b>" +
                            $", que <b>NO</b> se encuentren en las subfases “traslado de costas e intereses” “impugnación” “Decreto aprobación costas / intereses” “Apelación” “Oposición a la Apelación”" +
                            $" y <b>SI</b> tenga <b>Fecha de Sentencia</b> con una antigüedad superior a <b>40 días</b>.";

                case TipoIndicadorQa.OrdinarioCsAlarmaSentenciaSinCostasAbonadas:
                    return $"Expedientes que estén en estado <b>{ExpedienteEstadoTipo.OrdinarioCsSentencia.GetDescriptionShort()}</b>" +
                           $", que la Subfase del estado sea <b>{TipoFaseEstado.Ocs0705.GetDescription()}</b>" +
                           $", que <b>NO</b> tenga marcada la casilla de <b>Costas Abonadas</b>" +
                           $", y que la <b>Fecha del Estado</b> tenga una antigüedad superior a <b>15 días</b>.";

                #endregion

                #region TPA

                #region TPA - Indicadores / Facturas

                case TipoIndicadorQa.TpaFacturasPendientesHito1:
                    return $"Expedientes que NO tengan <b>Factura Hito 1</b> y <b>SI</b> tengan la <b>Fecha de Contactado</b>.";
                case TipoIndicadorQa.TpaFacturasPendientesHito2:
                    return $"Expedientes que NO tengan <b>Factura Hito 2</b> y el <b>Finalizada por</b> de contencioso sea: <b>Finalización Toma de posesión Anticipada</b>.";

                #endregion

                #region TPA - Alarmas
                #endregion

                #endregion

                #region JC

                #region JC - Indicadores / Facturas

                case TipoIndicadorQa.JcFacturasPendientesHito1:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 1</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Fecha Facturable H1</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan (<b>Facturación Completa</b> o <b>No Facturable</b>).</span>";

                case TipoIndicadorQa.JcFacturasPendientesHito1ConHito2:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 1</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan (<b>Factura de otro tipo (H2, H3...)</b>).</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan (<b>Facturación Completa</b> o <b>No Facturable</b>).</span>";

                case TipoIndicadorQa.JcFacturasPendientesHito2:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 2</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Fecha Facturable H2</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan (<b>Facturación Completa</b> o <b>No Facturable</b>).</span>";

                #endregion

                #region TPA - Alarmas
                #endregion

                #endregion

                #region Concursal (ReI, MyC)

                #region Concursal - Facturas

                case TipoIndicadorQa.MyCFacturasPendientesHito1:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura Hito 1</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Fecha Facturable H1</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan (<b>Facturación Completa</b> o <b>No Facturable</b>).</span>";

                #endregion

                #region Concursal - Alarmas

                case TipoIndicadorQa.ConcursoAlarmaCumplidoHito01:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de tipo <b>{TipoExpedienteEnum.Concurso}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan hito de tipo <b>1</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que aún no cumplimentaran la propiedad <b>Facturar</b>.</span>";

                case TipoIndicadorQa.ConcursoAlarmaCumplidoHito57:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de tipo <b>{TipoExpedienteEnum.Concurso}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan hito de tipo <b>57</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que aún no cumplimentaran la propiedad <b>Facturar</b>.</span>";

                case TipoIndicadorQa.ConcursoAlarmaCumplidoHito14_18:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de tipo <b>{TipoExpedienteEnum.Concurso}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan hito <b>14</b> con una antiguedad de <b>18 meses</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que aún no cumplimentaran la propiedad <b>Facturar</b>.</span>";

                case TipoIndicadorQa.ConcursoAlarmaCumplidoHito14_48:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de tipo <b>{TipoExpedienteEnum.Concurso}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan hito <b>14</b> con una antiguedad de <b>48 meses</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que aún no cumplimentaran la propiedad <b>Facturar</b>.</span>";

                case TipoIndicadorQa.ConcursoAlarmaCumplidoHito73:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de tipo <b>{TipoExpedienteEnum.Concurso}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan hito de tipo <b>73</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que aún no cumplimentaran la propiedad <b>Facturar</b>.</span>";

                case TipoIndicadorQa.ConcursoAlarmaCumplidoHito74:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de tipo <b>{TipoExpedienteEnum.Concurso}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan hito de tipo <b>74</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que aún no cumplimentaran la propiedad <b>Facturar</b>.</span>";

                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_01:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de tipo <b>{TipoExpedienteEnum.Concurso}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan hito de tipo <b>1</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Con fecha de hito inferior a la actual.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que aún no cumplimentaran la propiedad <b>Facturar</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de las oficinas (<b>8, 419, 751, 571, 574, 586, 883, 920</b>).</span>";

                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_57:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de tipo <b>{TipoExpedienteEnum.Concurso}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan hito de tipo <b>57</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Con fecha de hito inferior a la actual.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que aún no cumplimentaran la propiedad <b>Facturar</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de las oficinas (<b>8, 571</b>).</span>";

                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_14_18m:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de tipo <b>{TipoExpedienteEnum.Concurso}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan hito de tipo <b>14</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Con fecha de hito atiguedad superior a 18 meses.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que aún no cumplimentaran la propiedad <b>Facturar</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de la oficina (<b>8</b>).</span>";

                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_14_48m:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de tipo <b>{TipoExpedienteEnum.Concurso}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan hito de tipo <b>14</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Con fecha de hito atiguedad superior a 48 meses.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que aún no cumplimentaran la propiedad <b>Facturar</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de la oficina (<b>8</b>).</span>";

                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_74:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de tipo <b>{TipoExpedienteEnum.Concurso}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan hito de tipo <b>74</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Con fecha de hito inferior a la actual.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que aún no cumplimentaran la propiedad <b>Facturar</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de las oficinas (<b>8, 419, 751, 571, 574, 1, 883, 920</b>).</span>";

                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_78:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de tipo <b>{TipoExpedienteEnum.Concurso}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan hito de tipo <b>78</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Con fecha de hito inferior a la actual.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que aún no cumplimentaran la propiedad <b>Facturar</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de la oficina (<b>8</b>).</span>";

                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_79:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de tipo <b>{TipoExpedienteEnum.Concurso}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan hito de tipo <b>79</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Con fecha de hito inferior a la actual.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que aún no cumplimentaran la propiedad <b>Facturar</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de la oficina (<b>8</b>).</span>";

                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_73:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de tipo <b>{TipoExpedienteEnum.Concurso}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan hito de tipo <b>73</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Con fecha de hito inferior a la actual.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que aún no cumplimentaran la propiedad <b>Facturar</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de la oficina (<b>8</b>).</span>";

                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_52:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de tipo <b>{TipoExpedienteEnum.Concurso}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan hito de tipo <b>52</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Con fecha de hito inferior a la actual.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que aún no cumplimentaran la propiedad <b>Facturar</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de la oficina (<b>8</b>).</span>";

                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_54:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de tipo <b>{TipoExpedienteEnum.Concurso}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan hito de tipo <b>54</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Con fecha de hito inferior a la actual.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que aún no cumplimentaran la propiedad <b>Facturar</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de la oficina (<b>8</b>).</span>";

                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_55:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de tipo <b>{TipoExpedienteEnum.Concurso}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan hito de tipo <b>55</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Con fecha de hito inferior a la actual.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que aún no cumplimentaran la propiedad <b>Facturar</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de la oficina (<b>8</b>).</span>";

                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_56:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de tipo <b>{TipoExpedienteEnum.Concurso}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan hito de tipo <b>56</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Con fecha de hito inferior a la actual.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que aún no cumplimentaran la propiedad <b>Facturar</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de la oficina (<b>8</b>).</span>";

                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_63:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de tipo <b>{TipoExpedienteEnum.Concurso}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan hito de tipo <b>63</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Con fecha de hito inferior a la actual.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que aún no cumplimentaran la propiedad <b>Facturar</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de la oficina (<b>8</b>).</span>";

                case TipoIndicadorQa.ConcursoAlarmaProcedeFacturacion_64:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de tipo <b>{TipoExpedienteEnum.Concurso}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan hito de tipo <b>64</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Con fecha de hito inferior a la actual.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que aún no cumplimentaran la propiedad <b>Facturar</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de la oficina (<b>8</b>).</span>";

                #endregion

                #endregion

                #region JV

                #region JV - Indicadores

                //case TipoIndicadorQa.TpaFacturasPendientesHito1:
                //    return $"Expedientes que NO tengan <b>Factura Hito 1</b> y <b>SI</b> tengan la <b>Fecha de Contactado</b>.";
                //case TipoIndicadorQa.TpaFacturasPendientesHito2:
                //    return $"Expedientes que NO tengan <b>Factura Hito 2</b> y el <b>Finalizada por</b> de contencioso sea: <b>Finalización Toma de posesión Anticipada</b>.";

                #endregion

                #region JV - Alarmas

                case TipoIndicadorQa.JvAlarmaPdteAdmision:
                    return $"Expedientes con alguna <b>Escritura</b> en la que haya pasado 30 días desde la <b>F.Envío Procurador</b> y que <b>NO</b> tengan <b>Fecha de Admisión</b>.";
                case TipoIndicadorQa.JvAlarmaPdteLibradoMandamiento:
                    return $"Expedientes con alguna <b>Escritura</b> en la que haya pasado 45 días desde la <b>F. Auto Librado Mandamiento</b>.";
                case TipoIndicadorQa.JvAlarmaPdteNotificacion:
                    return $"Expedientes con alguna <b>Escritura</b> en la que haya pasado 30 días desde la <b>F. Admisión</b> y que <b>NO</b> tengan <b>Fecha de Notificación</b>.";
                case TipoIndicadorQa.JvAlarmaPdteRecepcionEscritura:
                    return $"Expedientes con alguna <b>Escritura</b> en la que haya pasado 30 días desde la <b>F. Librado Mandamiento</b> y que <b>NO</b> tengan <b>Fecha de Recepción</b>.";
                case TipoIndicadorQa.JvAlarmaRecepcionDemandaSellada:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.JvPresentacionDemanda.GetDescriptionShort()}</b>, que NO tengan <b>Fecha de Presentación</b> y si la <b>Fecha de Envío Demanda al Procurador</b> con una antiguedad superior a <b>3 días</b>.";


                #endregion

                #endregion

                #region Monitorio

                #region Monitorio - Indicadores

                case TipoIndicadorQa.MonitorioPdteExpVerbal:
                    return $"Expedientes que: Estén en el estado <b>{ExpedienteEstadoTipo.MonitorioTramitacionJuzgado.GetDescriptionShort()}</b>, con <b>Fecha Traslado Oposición</b>, con <b>Imp. Admisión < 6000€</b>, y que aún no tengan creado un Expediente Verbal Relacionado (Tampoco Ord. o Ejc.).";
                case TipoIndicadorQa.MonitorioPdteExpOrdinario:
                    return $"Expedientes que: Estén en el estado <b>{ExpedienteEstadoTipo.MonitorioTramitacionJuzgado.GetDescriptionShort()}</b>, con <b>Fecha Traslado Oposición</b>, con <b>Imp. Admisión >= 6000€</b>, y que aún no tengan creado un Expediente Ordinario Relacionado (Tampoco Verbal. o Ejc.).";
                case TipoIndicadorQa.MonitorioPdteExpEjecutivo:
                    return $"Expedientes que: Estén en el estado <b>{ExpedienteEstadoTipo.MonitorioTramitacionJuzgado.GetDescriptionShort()}</b>, con <b>Fecha Decreto Archivo</b>, <b>Sin Pago / Sin Oposición</b>, y que aún no tengan creado un Expediente Ejecutivo Relacionado (Tampoco Ord. o Verbal).";

                #endregion

                #region Monitorio - Alarmas

                case TipoIndicadorQa.MonitorioAlarmaRecepcionDemandaSellada:
                    return $"Expedientes que estén en el estado <b>{ExpedienteEstadoTipo.MonitorioPresentacionDemanda.GetDescriptionShort()}</b>, " +
                        $"que NO tengan <b>Fecha de Presentación</b> " +
                        $"y si la <b>Fecha de Envío Demanda al Procurador</b> con una antiguedad superior a <b>3 días</b>.";

                #endregion

                #region Facturas 

                case TipoIndicadorQa.MonitorioFacturaHito1:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de tipo <b>Monitorio</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan <b>Fecha Fin (Finalizados)</b>.</span>";

                #endregion

                #endregion

                #region Real Estate

                case TipoIndicadorQa.RealEstateResidencial:
                    return $"Inmuebles que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan un expediente de tipo <b>{TipoExpedienteEnum.Hipotecario} o {TipoExpedienteEnum.Concurso.GetDescription()}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que el expediente no esté finalizado.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan tipología <b>Residencial</b>.</span>";

                case TipoIndicadorQa.RealEstateTerciarios:
                    return $"Inmuebles que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan un expediente de tipo <b>{TipoExpedienteEnum.Hipotecario} o {TipoExpedienteEnum.Concurso.GetDescription()}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que el expediente no esté finalizado.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan tipología <b>Terciarios</b>.</span>";
                case TipoIndicadorQa.RealEstateDotacional:
                    return $"Inmuebles que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan un expediente de tipo <b>{TipoExpedienteEnum.Hipotecario} o {TipoExpedienteEnum.Concurso.GetDescription()}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que el expediente no esté finalizado.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan tipología <b>Dotacional</b>.</span>";
                case TipoIndicadorQa.RealEstateSuelos:
                    return $"Inmuebles que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan un expediente de tipo <b>{TipoExpedienteEnum.Hipotecario} o {TipoExpedienteEnum.Concurso.GetDescription()}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que el expediente no esté finalizado.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan tipología <b>Suelos</b>.</span>";

                case TipoIndicadorQa.RealEstateNpls:
                    return $"Inmuebles que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan un expediente de tipo <b>{TipoExpedienteEnum.Hipotecario}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO esten en los estados (<b>Adjudicación</b> o <b>Finalizados</b>).</span>";
                case TipoIndicadorQa.RealEstateReos:
                    return $"Inmuebles que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan un expediente de tipo <b>{TipoExpedienteEnum.Hipotecario}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que esten en el estadoo (<b>Adjudicación</b> o <b>Finalizados</b>).</span>";
                case TipoIndicadorQa.RealEstateConcursos:
                    return $"Inmuebles que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que tengan un expediente de tipo <b>{TipoExpedienteEnum.Concurso.GetDescription()}</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO esten <b>Finalizados</b>.</span>";

                #endregion

                #region MD - MultiDivisa

                #region MultiDivisa Indicadores

                case TipoIndicadorQa.MultiDivisaPendienteContacto:
                    return $"Expedientes <b>Multidivisa</b> que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que estén en el Estado Negociación <b>NO CONTACTADO</b>.</span>";
                case TipoIndicadorQa.MultiDivisaContactoEnNegociacion:
                    return $"Expedientes <b>Multidivisa</b> que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que estén en el Estado Negociación <b>EN NEGOCIACIÓN</b>.</span>";
                case TipoIndicadorQa.MultiDivisaContactoConAcuerdo:
                    return $"Expedientes <b>Multidivisa</b> que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que estén en el Estado Negociación <b>ACEPTADO</b>.</span>";

                case TipoIndicadorQa.MultiDivisaFinalizadoConExito:
                    return  $"Expedientes <b>Multidivisa</b> que cumplan las siguientes condiciones:" +
                            $"<br/><span class='qba-paddingL20'> - Que estén <b>FINALIZADOS</b>.</span>" +
                            $"<br/><span class='qba-paddingL20'> - Que estén en el Estado Negociación <b>FIRMADO</b>.</span>";

                case TipoIndicadorQa.MultiDivisaFinalizadoLocalizado:
                    return $"Expedientes <b>Multidivisa</b> que cumplan las siguientes condiciones:" +
                            $"<br/><span class='qba-paddingL20'> - Que estén <b>FINALIZADOS</b>.</span>" +
                            $"<br/><span class='qba-paddingL20'> - Que estén en el Estado Negociación <b>RECHAZADO</b>.</span>";

                case TipoIndicadorQa.MultiDivisaFinalizadoNoLocalizado:
                    return $"Expedientes <b>Multidivisa</b> que cumplan las siguientes condiciones:" +
                            $"<br/><span class='qba-paddingL20'> - Que estén <b>FINALIZADOS</b>.</span>" +
                            $"<br/><span class='qba-paddingL20'> - Que estén en el Estado Negociación <b>NO CONTACTADO</b>.</span>";

                case TipoIndicadorQa.MultiDivisaFinalizadoExcluido:
                    return $"Expedientes <b>Multidivisa</b> que cumplan las siguientes condiciones:" +
                            $"<br/><span class='qba-paddingL20'> - Que estén <b>FINALIZADOS</b>.</span>" +
                            $"<br/><span class='qba-paddingL20'> - Que estén en el Estado Negociación <b>EXCLUIDO</b> o <b>EXCLUIDO POR CLIENTE</b>.</span>";

                #endregion

                #endregion

                #region Procura

                #region Procura Facturas

                case TipoIndicadorQa.ProcuraFacturasHito1:
                    return $"Expedientes que cumplan las siguientes condiciones:" +
                           $"<br/><span class='qba-paddingL20'> - Que sean de tipo <b>Procura</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Factura</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que sean <b>Facturables</b>.</span>" +
                           $"<br/><span class='qba-paddingL20'> - Que NO tengan <b>Facturación Completa</b>.</span>";

                #endregion

                #endregion

                default: return null;
            }
        }

        public static string HtmlGetAlarmaIndicatorOf(this TipoIndicadorQa tipoIndicadorQa, bool showAlarma)
        {
            if (!showAlarma) return string.Empty;

            var sb = new StringBuilder();
            sb.AppendLine("<div class='col-lg-6'>");
            sb.AppendFormat("  <i class='icon-flag text-danger'></i> <label>{0}</label>", tipoIndicadorQa.GetDescription());
            sb.AppendFormat("  <p class='small'>{0}</p>", tipoIndicadorQa.HtmlGetDescriptionLargeOf());
            sb.AppendLine("</div>");

            return sb.ToString();
        }

        public static string HtmlGetIndicadorQaHelpBlock(this TipoIndicadorQa tipoIndicadorQa, string classBlock = "weather")
        {
            var sb = new StringBuilder();
            sb.AppendLine("<div class='help-block col-lg-6'>");
            sb.AppendFormat("  <b class='{0}'><i class='icon-ok'></i> {1}</b>:", classBlock, tipoIndicadorQa.GetDescription());
            sb.AppendFormat("  <span>{0}</span>", tipoIndicadorQa.HtmlGetDescriptionLargeOf());
            sb.AppendLine("</div>");

            return sb.ToString();
        }


        public static bool IsFinish(this TipoIndicadorQa? tipoIndicadorQa, TipoExpedienteEnum tipoExpediente)
        {
            if (!tipoIndicadorQa.HasValue) return false;

            if (tipoExpediente == TipoExpedienteEnum.Hipotecario)
                return tipoIndicadorQa == TipoIndicadorQa.HipotecarioFacturaBankiaHito2b
                    || tipoIndicadorQa == TipoIndicadorQa.HipotecarioFacturaBankiaHito2a;

            return false;
        }
    }
}
