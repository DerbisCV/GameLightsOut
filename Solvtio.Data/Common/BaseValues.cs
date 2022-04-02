using Solvtio.Common;
using Solvtio.Models;
using Solvtio.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvtio.Models
{
    public class BaseValues : AuditableMin
    {
        #region Constantes TipoVista / TipoDeudor

        internal const int IdTipoVistaHipPosesion = 13;
        internal const int IdTipoVistaHipLanzamiento = 12;
        internal const int IdTipoVistaAlqLanzamiento = 37;
        internal const int IdTipoVistaAlqTramiteCelebracionVista = 39;

        internal const int IdTipoDeudorAdmConcursal = 22;

        #endregion

        #region Constantes AreaNegocio

        internal const int AREANEGOCIO_RECUPERACIONES = 1;
        internal const int AREANEGOCIO_ALQUILER = 2;
        internal const int AREANEGOCIO_CyM = 3;
        internal const int AREANEGOCIO_LEGAL = 4;
        internal const int AREANEGOCIO_PROCURA = 5;

        #endregion

        #region Constantes 

        internal const int IdTipoExpedienteHipotecario = (int)TipoExpedienteEnum.Hipotecario;
        internal const int IdTipoExpedienteEjecutivo = (int)TipoExpedienteEnum.Ejecutivo;
        internal const int IdTipoExpedienteAlquiler = (int)TipoExpedienteEnum.Alquiler;
        internal const int IdTipoExpedienteOrdinario = (int)TipoExpedienteEnum.Ordinario;
        internal const int IdTipoExpedienteOrdinarioCs = (int)TipoExpedienteEnum.OrdinarioCs;
        internal const int IdTipoExpedienteTpa = (int)TipoExpedienteEnum.TomaPosesionAnticipada;
        internal const int IdTipoExpedienteJv = (int)TipoExpedienteEnum.JurisdiccionVoluntaria;
        internal const int IdTipoExpedienteMonitorio = (int)TipoExpedienteEnum.Monitorio;
        internal const int IdTipoExpedienteVerbal = (int)TipoExpedienteEnum.Verbal;
        internal const int IdTipoExpedienteSaneamiento = (int)TipoExpedienteEnum.Saneamiento;
        internal const int IdTipoExpedientePenal = (int)TipoExpedienteEnum.Penal;
        internal const int IdTipoExpedienteConcurso = (int)TipoExpedienteEnum.Concurso;
        internal const int IdTipoExpedienteConciliacion = (int)TipoExpedienteEnum.Conciliacion;
        internal const int IdTipoExpedienteJuraCuenta = (int)TipoExpedienteEnum.JuraCuenta;
        internal const int IdTipoExpedienteFiscal = (int)TipoExpedienteEnum.Fiscal;
        internal const int IdTipoExpedienteMultiDivisa = (int)TipoExpedienteEnum.MultiDivisa;
        internal const int IdTipoExpedienteProcura = (int)TipoExpedienteEnum.Procura;
        internal const int IdTipoExpedienteScne = (int)TipoExpedienteEnum.SCNE;
        internal const int IdTipoExpedienteBastanteo = (int)TipoExpedienteEnum.Bastanteo;
        internal const int IdTipoExpedientePrelitigio = (int)TipoExpedienteEnum.Prelitigio;
        internal const int IdTipoExpedienteTestamentario = (int)TipoExpedienteEnum.Testamentario;
        internal const int IdTipoExpedienteTpn = (int)TipoExpedienteEnum.TPN;

        internal const int IdTipoExpedienteCivil = (int)TipoExpedienteEnum.Civil;
        internal const int IdTipoExpedienteMercantilInmobiliario = (int)TipoExpedienteEnum.MercantilInmobiliario;
        internal const int IdTipoExpedienteDdl = (int)TipoExpedienteEnum.Ddl;
        internal const int IdTipoExpedienteContenciosoAdministrativo = (int)TipoExpedienteEnum.ContenciosoAdministrativo;
        internal const int IdTipoExpedienteContenciosoAdministrativoOrdinario = (int)TipoExpedienteEnum.ContenciosoAdministrativoOrdinario;
        internal const int IdTipoExpedienteCambiario = (int)TipoExpedienteEnum.Cambiario;

        internal const int IdTipologiaInmuebleResidencial = 220;
        internal const int IdTipologiaInmuebleTerciario = 221;
        internal const int IdTipologiaInmuebleDotacional = 222;
        internal const int IdTipologiaInmuebleSuelos = 223;

        internal const int IdTipoEstadoRecepcionExpediente = (int)ExpedienteEstadoTipo.RecepcionExpediente;
        internal const int IdTipoEstadoHipGeneracionExpediente =        (int)ExpedienteEstadoTipo.HipotecarioGeneracionExpediente;
        internal const int IdTipoEstadoHipRecepcionSolicitudCierre =    (int)ExpedienteEstadoTipo.HipotecarioGeneracionExpediente;
        internal const int IdTipoEstadoHipTramitacionSubasta = (int)ExpedienteEstadoTipo.HipotecarioTramitacionSubasta;
        internal const int IdTipoEstadoHipJurisdiccionVoluntaria = (int)ExpedienteEstadoTipo.HipotecarioJurisdiccionVoluntaria;
        internal const int IdTipoEstadoHipPresentDemanda = (int)ExpedienteEstadoTipo.HipotecarioPresentacionDemanda;
        internal const int IdTipoEstadoHipTramitJuzgado = (int)ExpedienteEstadoTipo.HipotecarioTramitacionSubasta;
        internal const int IdTipoEstadoHipSubasta = (int)ExpedienteEstadoTipo.HipotecarioSubasta;
        internal const int IdTipoEstadoHipAdjudicacion = (int)ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien;
        internal const int IdTipoEstadoHipNegociacionPosesion = (int)ExpedienteEstadoTipo.HipotecarioNegociacionPosesion;
        internal const int IdTipoEstadoHipFinalizado = (int)ExpedienteEstadoTipo.HipotecarioFinalizado;

        internal const int IdTipoEstadoAlqRecepcionExpediente = (int)ExpedienteEstadoTipo.AlquilerRecepcionExpediente;
        internal const int IdTipoEstadoAlqPresentDemanda = (int)ExpedienteEstadoTipo.AlquilerPresentacionDemanda;
        internal const int IdTipoEstadoAlqPresentDenuncia = (int)ExpedienteEstadoTipo.AlquilerPresentacionDenuncia;
        internal const int IdTipoEstadoAlqTramitJuzgado = (int)ExpedienteEstadoTipo.AlquilerTramitacionJuzgado;
        internal const int IdTipoEstadoAlqLanzamiento = (int)ExpedienteEstadoTipo.AlquilerLanzamiento;
        internal const int IdTipoEstadoAlqEnervacion = (int)ExpedienteEstadoTipo.AlquilerEnervacion;
        internal const int IdTipoEstadoAlqFinalizado = (int)ExpedienteEstadoTipo.AlquilerFinalizado;

        internal const int IdTipoEstadoEjcRecepcion = (int)ExpedienteEstadoTipo.EjecutivoRecepcionExpediente;
        internal const int IdTipoEstadoEjcEnvioDemandaProcurador = (int)ExpedienteEstadoTipo.EjecutivoEnvioDemandaProcurador;
        internal const int IdTipoEstadoEjcPresentDemanda = (int)ExpedienteEstadoTipo.EjecutivoPresentacionDemanda;
        internal const int IdTipoEstadoEjcAdmisionTramiteEmbatgo = (int)ExpedienteEstadoTipo.EjecutivoAdmisionTramiteEmbargo;
        internal const int IdTipoEstadoEjcTramiteEmbargo = (int)ExpedienteEstadoTipo.EjecutivoTramiteEmbargo;
        internal const int IdTipoEstadoEjcEfectividadEmbargo = (int)ExpedienteEstadoTipo.EjecutivoEfectividadEmbargo;
        internal const int IdTipoEstadoEjcSolicitudSubasta = (int)ExpedienteEstadoTipo.EjecutivoSolicitudSubasta;
        internal const int IdTipoEstadoEjcSubasta = (int)ExpedienteEstadoTipo.EjecutivoSubasta;
        internal const int IdTipoEstadoEjcAdjudicacion = (int)ExpedienteEstadoTipo.EjecutivoAdjudicacionBien;
        internal const int IdTipoEstadoEjcParalizado = (int)ExpedienteEstadoTipo.EjecutivoParalizado;
        internal const int IdTipoEstadoEjcFinalizacion = (int)ExpedienteEstadoTipo.EjecutivoFinalizacion;


        internal const int IdTipoEstadoOrdRecepcionExpediente = (int)ExpedienteEstadoTipo.OrdinarioRecepcionExpediente;
        internal const int IdTipoEstadoOrdFinalizacion = (int)ExpedienteEstadoTipo.OrdinarioFinalizacion;
        internal const int IdTipoEstadoOrdPresentacionDemanda = (int)ExpedienteEstadoTipo.OrdinarioPresentacionDemanda;
        internal const int IdTipoEstadoOrdTramitacionJuzgado = (int)ExpedienteEstadoTipo.OrdinarioTramitacionJuzgado;
        internal const int IdTipoEstadoOrdAutoAdmisionNotificacion = (int)ExpedienteEstadoTipo.OrdinarioAutoAdmisionNotificacion;
        internal const int IdTipoEstadoOrdJuicio = (int)ExpedienteEstadoTipo.OrdinarioJuicio;
        internal const int IdTipoEstadoOrdSentencia = (int)ExpedienteEstadoTipo.OrdinarioSentencia;
        internal const int IdTipoEstadoOrdEjecucionSentencia = (int)ExpedienteEstadoTipo.OrdinarioEjecucionSentencia;

        internal const int IdTipoEstadoOrdCsRecepcionExpediente = (int)ExpedienteEstadoTipo.OrdinarioCsRecepcionExpediente;
        internal const int IdTipoEstadoOrdCsSentencia = (int)ExpedienteEstadoTipo.OrdinarioCsSentencia;
        internal const int IdTipoEstadoOrdCsFinalizacion = (int)ExpedienteEstadoTipo.OrdinarioCsFinalizacion;

        internal const int IdTipoEstadoTpaFinalizado = (int)ExpedienteEstadoTipo.TpaFinalizado;

        internal const int IdTipoEstadoMnRecepcionExpediente = (int)ExpedienteEstadoTipo.MonitorioRecepcionExpediente;
        internal const int IdTipoEstadoMnPresentDemanda = (int)ExpedienteEstadoTipo.MonitorioPresentacionDemanda;
        internal const int IdTipoEstadoMnTramitJuzgado = (int)ExpedienteEstadoTipo.MonitorioTramitacionJuzgado;
        internal const int IdTipoEstadoMnFinalizado = (int)ExpedienteEstadoTipo.MonitorioFinalizacion;

        internal const int IdTipoEstadoJvRecepcionExpediente = (int)ExpedienteEstadoTipo.JvRecepcionExpediente;
        internal const int IdTipoEstadoJvPresentDemanda = (int)ExpedienteEstadoTipo.JvPresentacionDemanda;
        internal const int IdTipoEstadoJvFinalizado = (int)ExpedienteEstadoTipo.JvFinalizado;

        internal const int IdTipoEstadoConRecepcionExpediente = (int)ExpedienteEstadoTipo.ConcursalFaseComun;
        internal const int IdTipoEstadoConFinalizado = (int)ExpedienteEstadoTipo.ConcursalFinalizado;

        internal const int IdTipoEstadoCclRecepcionExpediente = (int)ExpedienteEstadoTipo.ConciliacionRecepcionExpediente;
        internal const int IdTipoEstadoCclActo = (int)ExpedienteEstadoTipo.ConciliacionActo;
        internal const int IdTipoEstadoCclFinalizado = (int)ExpedienteEstadoTipo.ConciliacionFinalizacion;

        internal const int IdTipoEstadoScneFinalizacion = (int)ExpedienteEstadoTipo.ScneFinalizacion;

        internal const int IdDivisionRecuperaciones = 1;
        internal const int IdDivisionAlquiler = 2;
        internal const int IdDivisionLitigacion = 3;
        internal const int IdDivisionPenal = 4;
        internal const int IdDivisionConcursal = 5;
        internal const int IdDivisionFiscal = 6;
        internal const int IdDivisionRealEstate = 7;
        internal const int IdDivisionFundaciones = 8;

        internal const int IdTipoContratoEmpleado1 = 237;
        internal const int IdTipoContratoEmpleado2 = 238;
        internal const int IdTipoContratoEmpleado3 = 239;
        internal const int IdTipoContratoEmpleado4 = 240;

        //internal const int IdDivision = ;
        //internal const int IdDivision = ;

        #region SubFaseEstado

        internal const int IdTipoSubFaseEstadoEjecucionSentencia = 800;
        internal const int IdTipoSubFaseEstadoHipTramitacionSubasta606 = 1010606;

        #endregion

        //internal const int IdClienteOficinaSolviaHipotecario = 429;  

        internal const int IdTipoAreaDesahucios = 3;
        internal const int IdTipoAreaNegociaciones = 10;

        internal const int IdClienteSabadell = 1;
        internal const int IdClienteBankia = 5;
        internal const int IdClienteAliseda = 58;
        internal const int IdClienteAlisedaAlquileres = 87;
        internal const int IdClienteAhoraAssetManagement = 126;
        internal const int IdClienteSolvia = 14;
        internal const int IdClienteAnticipa = 62;
        internal const int IdClienteAnticipaQuasar = 82;
        internal const int IdClienteSareb = 27;
        internal const int IdClienteSarebHr = 138;
        internal const int IdClienteAbanca = 41;
        internal const int IdClienteFidere = 88;
        internal const int IdClienteMerlinRetail = 60;
        internal const int IdClienteSolviaHoteles = 42;
        internal const int IdClienteAzzam = 83;
        internal const int IdClienteHomes = 129;
        internal const int IdClienteServihabitatGreen = 139;
        internal const int IdClienteServihabitat = 140;
        internal const int IdClienteBasicoHomesGestion = 129;
        internal const int IdClienteDas = 134;

        internal const int IdClienteOficinaAnticipa = 424;
        internal const int IdClienteOficinaSabadel = 1;
        internal const int IdClienteOficinaAcinsaBankia = 8;
        internal const int IdClienteProyectoEmpireRealEstate = 61;
        internal const int IdClienteEmpirePropertiesSpain = 70;
        internal const int IdOficinaBancoPopular = 439;
        internal const int IdClienteAltamiraSantander = 44;
        internal const int IdClienteAltamiraBackOffice = 81; //ALTAMIRA BACK OFFICE
        internal const int IdClienteHayaRealEstateEgeo = 80; // HAYA REAL ESTATE- EGEO
        internal const int IdClienteLlogatalia = 54;
        internal const int IdClienteLuri4 = 55;
        internal const int IdClienteLuri6 = 56;
        internal const int IdClienteOficinaHayaPostEjecucion = 433; //HAYA POST-EJECUCION
        internal const int IdClienteOficinaSolviaPostEjecucion = 432; //SOLVIA POST-EJECUCIÓN
        internal const int IdClienteCaixa = 109;
        internal const int IdClienteIng = 75;

        internal const int IdClienteCrmTarsso = 77;
        internal const int IdClienteCrmIberus = 142;

        internal List<int> LstAlqClientes = new List<int> { IdClienteOficinaSabadel, IdClienteProyectoEmpireRealEstate, IdClienteEmpirePropertiesSpain };
        internal List<int> LstOficinasSabadel = new List<int> { 1, 2 };
        internal List<int> LstOficinasSolvia = new List<int> { 409, 429 };
        internal List<int> LstOficinasAnticipa = new List<int> { 424, 437, 438 };
        internal List<int> LstOficinasSareb = new List<int> { 25, 385, 409, 416, 417, 427, 430 };
        internal List<int> LstHipOficinasPostEjc = new List<int> { 432, 433 };
        internal List<int> LstHipOficinasBankia = new List<int> { 8, 342 };
        internal List<int> LstHipOficinasAliseda = new List<int> { 37 };
        internal List<int> LstHipOficinasAbanca = new List<int> { 40 };
        internal List<int> LstOficinasSantander = new List<int> { 314, 316, 320, 330, 331, 333, 335, 336, 338, 344, 375, 378, 381, 384, 435, 436 };
        internal List<int> LstOficinasLlogatalia = new List<int> { 350 };
        internal List<int> LstHipOficinasVoyagerAltamira = new List<int> { 502 };

        internal DateTime FechaActualMenos1277 = DateTime.Now.AddDays(-1277);

        #endregion

        #region Constantes Subfases

        internal const int TipoFaseEstadoHip0101RecepcionRevision = 1010101;
        internal const int TipoFaseEstadoHip0102IncidenciaDocumental = 1010102;
        internal const int TipoFaseEstadoHip0103PreparacionDemanda = 1010103;
        internal const int TipoFaseEstadoHip0104 = 1010104;
        internal const int TipoFaseEstadoHip0105 = 1010105;



        internal const int TipoFaseEstadoHip0201 = 1010201;
        internal const int TipoFaseEstadoHip0202PresentadaDemanda = 1010202;
        internal const int TipoFaseEstadoHip0203RequerimientoPrevio = 1010203;
        internal const int TipoFaseEstadoHip0204DemandaNoAdmitida = 1010204;
        internal const int TipoFaseEstadoHip0205RecursoReposicionApelacion = 1010205;
        internal const int TipoFaseEstadoHip0301 = 1010301;

        internal const int TipoFaseEstadoHip0302 = 1010302;

        internal const int TipoFaseEstadoHip0600 = 1010600;

        internal const int TipoFaseEstadoHip0601 = 1010601;

        internal const int TipoFaseEstadoHip0602 = 1010602;

        internal const int TipoFaseEstadoHip0603 = 1010603;

        internal const int TipoFaseEstadoHip0604 = 1010604;

        internal const int TipoFaseEstadoHip0605 = 1010605;

        internal const int TipoFaseEstadoHip0606 = 1010606;

        internal const int TipoFaseEstadoHip0607 = 1010607;

        internal const int TipoFaseEstadoHip0608 = 1010608;

        internal const int TipoFaseEstadoHip0609 = 1010609;

        internal const int TipoFaseEstadoHip0610 = 1010610;

        internal const int TipoFaseEstadoHip0611 = 1010611;

        internal const int TipoFaseEstadoHip0612 = 1010612;

        internal const int TipoFaseEstadoHip0613 = 1010613;

        internal const int TipoFaseEstadoHip0614 = 1010614;

        internal const int TipoFaseEstadoHip0615 = 1010615;


        internal const int TipoFaseEstadoHip0701 = 1010701;

        internal const int TipoFaseEstadoHip0702 = 1010702;

        internal const int TipoFaseEstadoHip0703 = 101073;

        internal const int TipoFaseEstadoHip0704 = 1010704;

        internal const int TipoFaseEstadoHip0705 = 1010705;

        internal const int TipoFaseEstadoHip0706 = 1010706;

        internal const int TipoFaseEstadoHip0707 = 1010707;

        internal const int TipoFaseEstadoHip0708 = 1010708;

        internal const int TipoFaseEstadoHip0709 = 1010709;

        internal const int TipoFaseEstadoHip0710 = 1010710;

        internal const int TipoFaseEstadoHip0711 = 1010711;

        internal const int TipoFaseEstadoHip0712 = 1010712;

        internal const int TipoFaseEstadoHip0713 = 1010713;

        internal const int TipoFaseEstadoHip0714 = 1010714;

        internal const int TipoFaseEstadoHip0715 = 1010715;

        internal const int TipoFaseEstadoHip0716 = 1010716;

        internal const int TipoFaseEstadoHip0717 = 1010717;

        internal const int TipoFaseEstadoHip0718 = 1010718;

        internal const int TipoFaseEstadoHip0719 = 1010719;

        internal const int TipoFaseEstadoHip0720 = 1010720;

        internal const int TipoFaseEstadoHip0721 = 1010721;


        internal const int TipoFaseEstadoHip0801 = 1010801;
        internal const int TipoFaseEstadoHip0802 = 1010802;
        internal const int TipoFaseEstadoHip0803 = 1010803;
        internal const int TipoFaseEstadoHip0804 = 1010804;
        internal const int TipoFaseEstadoHip0805 = 1010805;
        internal const int TipoFaseEstadoHip10905 = 1010905;




        internal const int TipoFaseEstadoOcs0101 = 1510101;
        internal const int TipoFaseEstadoOcs0102 = 1510102;
        internal const int TipoFaseEstadoOcs0103 = 1510103;
        internal const int TipoFaseEstadoOcs0105 = 1510105;
        internal const int TipoFaseEstadoOcs0106 = 1510106;
        internal const int TipoFaseEstadoOcs0301 = 1500301;
        internal const int TipoFaseEstadoOcs0302 = 1500302;
        internal const int TipoFaseEstadoOcs0501 = 1500501;
        internal const int TipoFaseEstadoOcs0601 = 150601;
        internal const int TipoFaseEstadoOcs0602 = 150602;
        internal const int TipoFaseEstadoOcs0603 = 150603;
        internal const int TipoFaseEstadoOcs0604 = 150604;
        internal const int TipoFaseEstadoOcs1301 = 1510301;
        internal const int TipoFaseEstadoOcs1302 = 1510302;
        internal const int TipoFaseEstadoOcs1303 = 1510303;
        internal const int TipoFaseEstadoOcs1401 = 151401;
        internal const int TipoFaseEstadoOcs0707 = 150707;
        internal const int TipoFaseEstadoOcs0701 = 150701;
        internal const int TipoFaseEstadoOcs0702 = 150702;
        internal const int TipoFaseEstadoOcs0703 = 150703;
        internal const int TipoFaseEstadoOcs0704 = 150704;
        internal const int TipoFaseEstadoOcs0705 = 150705;
        internal const int TipoFaseEstadoOcs0706 = 150706;
        internal const int TipoFaseEstadoOcs0708 = 150708;
        internal const int TipoFaseEstadoOcs0709 = 150709;
        internal const int TipoFaseEstadoOcs0710 = 150710;


        #endregion

        #region Constantes CaracteristicaBase

        #region CaracteristicaBase - Exp-VeniadoHitoFacturacio

        internal const int IdExpVeniadoHitoFacturacionHipTomaPosesionLanzamiento = 112;
        internal const int IdExpVeniadoHitoFacturacionHipDecretoAdjudicacion = 113;
        internal const int IdExpVeniadoHitoFacturacionHipDecretoConvocatoriaSubasta = 114;
        internal const int IdExpVeniadoHitoFacturacionHipRequerimientoCertificacionCargas = 115;
        internal const int IdExpVeniadoHitoFacturacionHipAutoDespachoEjecucion = 116;
        internal const int IdExpVeniadoHitoFacturacionHipPresentacionDemanda = 117;
        internal const int IdExpVeniadoHitoFacturacionHipExpSinIniciarReclamacionJudicial = 118;

        #endregion

        #endregion

        #region IdAccionPropuesta

        internal const int IdAccionPropuestaDelitoLeveUsurpacion = 29;

        #endregion

        #region asdas

        internal List<int> LstClienteAlqAnticipa = new List<int> { 62, 71, 82, 105, 106, 107 };

        internal List<Tuple<decimal, decimal, decimal>> LstEscalaBaseSabadel = new List<Tuple<decimal, decimal, decimal>>
            {
                new Tuple<decimal, decimal, decimal>(300, 42, 126),
                new Tuple<decimal, decimal, decimal>(600, 36, 234),
                new Tuple<decimal, decimal, decimal>(1200, 30, 414),
                new Tuple<decimal, decimal, decimal>(3000, 22, 810),
                new Tuple<decimal, decimal, decimal>(4000, 20, 1010),
                new Tuple<decimal, decimal, decimal>(6000, 18, 1370),
                new Tuple<decimal, decimal, decimal>(12000, 17, 2390),
                new Tuple<decimal, decimal, decimal>(18000, 16, 3350),
                new Tuple<decimal, decimal, decimal>(24000, 12, 4070),
                new Tuple<decimal, decimal, decimal>(30000, 11, 4730),
                new Tuple<decimal, decimal, decimal>(40000, 10, 5730),
                new Tuple<decimal, decimal, decimal>(50000, 9, 6630),
                new Tuple<decimal, decimal, decimal>(60000, 8, 7430),
                new Tuple<decimal, decimal, decimal>(120000, 7, 11630),
                new Tuple<decimal, decimal, decimal>(300000, 6.5M, 23330),
                new Tuple<decimal, decimal, decimal>(600000, 5, 38330),
                new Tuple<decimal, decimal, decimal>(1200000, 2.5M, 53330),
                new Tuple<decimal, decimal, decimal>(1800000, 2, 65330),
                new Tuple<decimal, decimal, decimal>(2500000, 1.75M, 77580),
                new Tuple<decimal, decimal, decimal>(3500000, 1.5M, 92580)
            };

        #endregion

        #region IdTipoHitoProcesalConcursal52

        internal const int ID_TIPO_HITO_PROCESAL_CONCURSAL_52 = 34;
        internal const int IdTipoHitoProcesal_01 = 3569;

        internal const int IdTipoHitoProcesal_57 = 3590;
        internal const int IdTipoHitoProcesal_14 = 11;
        internal const int IdTipoHitoProcesal_73 = 3612;
        internal const int IdTipoHitoProcesal_74 = 3614;
        internal const int IdTipoHitoProcesal_78 = 3604;
        internal const int IdTipoHitoProcesal_79 = 3628;
        internal const int IdTipoHitoProcesal_52 = 34;
        internal const int IdTipoHitoProcesal_54 = 345;
        internal const int IdTipoHitoProcesal_55 = 3589;
        internal const int IdTipoHitoProcesal_56 = 3613;
        internal const int IdTipoHitoProcesal_63 = 28;
        internal const int IdTipoHitoProcesal_64 = 29;

        #endregion

        #region MD - EstadoNegociacion

        internal const int IdEstadoNegocRechazado = 350;
        internal const int IdEstadoNegocAceptado = 351;
        internal const int IdEstadoNegocFirmado = 352;
        internal const int IdEstadoNegocNoContactado = 353;
        internal const int IdEstadoNegocEnNegociacion = 354;
        internal const int IdEstadoNegocExcluido = 767;
        internal const int IdEstadoNegocParalizado = 773;
        internal const int IdEstadoNegocExcluidoPorCliente = 887;

        #endregion

    }

    public static class SolvtioValue
    {
        #region Security

        public const int IdRolInvitado = 1;
        public const int IdRolAdministrador = 2;
        public const int IdRolRecursosHumanos = 10;

        public const int IdDepartamentoDirGeneral = 20;

        #endregion        
    }
}
