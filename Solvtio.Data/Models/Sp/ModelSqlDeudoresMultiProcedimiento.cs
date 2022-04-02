using Solvtio.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solvtio.Models
{

    public class ModelSqlDeudoresMultiProcedimiento
    {
        public int IdPersona { get; set; }
        public int TotalExp { get; set; }
        public string NoDocumento { get; set; }
        public string NombreApellidos { get; set; }
        public string NoExpediente { get; set; }
        public string ReferenciaExterna { get; set; }
        public string Tipo { get; set; }
        public string NoAuto { get; set; }
        public string Juzgado { get; set; }
        public string Oficina { get; set; }
        public string Cliente { get; set; }
        public string Estado { get; set; }
        public string Fase { get; set; }

        public DateTime? Inicio { get; set; }
        public DateTime? Fin { get; set; }

        public decimal? DeudaFinal { get; set; }

        public int IdClienteOficina { get; set; }
        public int IdCliente { get; set; }
        public int IdTipoExpediente { get; set; }
        public int IdExpediente { get; set; }
    }

    public class ModelSqlAlqInfoCliente
    {
        public string Cedente { get; set; }
        public string TipoProcedimiento { get; set; }
        public bool ServiciosSociales { get; set; }
        public string TipoInmueble { get; set; }
        public string AccionPropuesta { get; set; }
        public DateTime? FechaPropuesta { get; set; }
        public string DecisionSareb { get; set; }
        public string FechaDecisionSareb { get; set; }
        public string CodigoActivoCedente { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public string Direccion { get; set; }
        public string ReferenciaCatastral { get; set; }
        public string ReferenciaExternaMACRO { get; set; }
        public int? IdAlqContrato { get; set; }
        public string Arrend_1_Doc { get; set; }
        public string Arrendatario1 { get; set; }
        public string Arrend_1_Tel { get; set; }
        public DateTime? FechaContrato { get; set; }
        public decimal? DeudaInicial { get; set; }
        public decimal? RentaInicial { get; set; }
        public string FechaAntiguedadDeuda { get; set; }
        public decimal? Fianza { get; set; }
        public string TipoGarantiaAdicional { get; set; }
        public decimal? GarantiaAdicional { get; set; }
        public string AbogadoExpediente { get; set; }
        public string AbogadoEstado { get; set; }
        public string Procurador { get; set; }
        public string NoAuto { get; set; }
        public string Juzgado { get; set; }
        public string FechaOrigenIncidencia { get; set; }
        public string AsucionDeCostes { get; set; }
        public string ProcedimientoActual { get; set; }
        public string EstadoDemanda { get; set; }
        public decimal? DeudaReclamada { get; set; }
        public DateTime? FechaPresentacionDemanda { get; set; }
        public DateTime? FechaVista { get; set; }
        public DateTime? FechaEstadoLanzamiento { get; set; }
        public DateTime? UltimoLanzamiento { get; set; }
        public bool? TomadaPosesion { get; set; }
        public DateTime? FechaSentencia1raInstancia { get; set; }
        public DateTime? FechaRecurso { get; set; }
        public DateTime? FechaSentencia2daInstancia { get; set; }
        public DateTime? FechaAdmisionDemanda { get; set; }
        public string Observaciones { get; set; }
        public decimal? DeudaRecuperada { get; set; }
        public decimal? ImporteCostas { get; set; }
        public decimal? ImporteCondonacion { get; set; }
        public string InformacionMediador { get; set; }
        public string RentaPropuesta { get; set; }
        public string EstadoVivienda { get; set; }
        public string ClienteOficina { get; set; }
        public string Cliente { get; set; }
        public string NoExpediente { get; set; }
        public string ReferenciaExterna { get; set; }
        public string EstadoActual { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public string SubFase { get; set; }
        public string SuspensionObservaciones { get; set; }
        public string MotivoSuspension { get; set; }
        public DateTime? FechaEnvioBurofax { get; set; }
        public DateTime? FechaRecepcionBurofax { get; set; }
        public int? IdExpEjecutivoVinculado { get; set; }
        public string IdentifCliente { get; set; }
        public int? Segmento { get; set; }
        public DateTime? FechaPresentaciondenuncia { get; set; }
        public DateTime? FechaDenunciaAdmitida { get; set; }

        public bool Veniado { get; set; }
        public DateTime? SucesionPresentada { get; set; }
        public DateTime? SucesionCopiaSellada { get; set; }
        public DateTime? SucesionAcordada { get; set; }
        public DateTime? SucesionDenegada { get; set; }
        public string CausaIncidencia { get; set; }
        public bool SucesionOposicion { get; set; }
        public DateTime? SucesionRecurrida { get; set; }
        public string ResultadoRecuso { get; set; }
        public string ProvinciaJuzgado { get; set; }
        public string Pagador { get; set; }
        public string ContratoRef { get; set; }
        public bool ServicioIntegral { get; set; }
        public int? IdCliente { get; set; }
        public string AbogadoZona { get; set; }
        public string PartidoJudicial { get; set; }
        public string Cartera { get; set; }
        public decimal? ImporteDemanda { get; set; }

        public DateTime? OposicionFecha { get; set; }
        public DateTime? OposicionFechaDecretoFin { get; set; }

        public string IncidenciaEstadoRecepcion { get; set; }

        public string EstadoNota { get; set; }
        public int IdExpediente { get; set; }
    }




}
