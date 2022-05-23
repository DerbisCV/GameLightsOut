using System;

namespace Solvtio.Models
{
    public class AlqExpedienteDto
    {
        #region Properties

        public int IdExpediente { get; set; }
        public int Id => IdExpediente;

        public string ReferenciaExternaMACRO { get; set; }
        public string ReferenciaExternaMSGI { get; set; }
        public string NumAuto { get; set; }
        public string ObservacionesMigracion { get; set; }
        public string Cedente { get; set; }
        public string CodigoActivoCedente { get; set; }
        public string PromocionNo { get; set; }
        public string PromocionNombre { get; set; }
        public string TipoProcedimiento { get; set; }

        public decimal? DeudaInicial { get; set; }
        public decimal? DeudaPendiente { get; set; }
        public decimal? DeudaRecuperada { get; set; }
        public decimal? Fianza { get; set; }
        public decimal? GarantiaAdicional { get; set; }
        public decimal? ImporteCostas { get; set; }
        public decimal? ImporteCondonacion { get; set; }

        public DateTime? FechaEstadoActual { get; set; }
        public DateTime? FechaEnvioBurofax { get; set; }
        public DateTime? FechaRecepcionBurofax { get; set; }

        public TipoRecepcionBurofaxMotivo? RecepcionBurofaxMotivo { get; set; }
        public TipoSegmento? Segmento { get; set; }

        public int? IdAbogadoZona { get; set; }
        public int? IdAlqContrato { get; set; }
        public int IdAccionPropuesta { get; set; }
        public int? IdTipoGarantiaAdicional { get; set; }
        public int? IdProcedimientoActual { get; set; }
        public int? IdEstadoDemanda { get; set; }
        public int? IdExpedienteEjc { get; set; }
        public int? IdExpedientePadre { get; set; }
        public int? IdTipoEstadoCliente { get; set; }

        public bool EstaCompleto { get; set; }
        public bool DerivadoDepartamentoConcursal { get; set; }
        public bool ServiciosSociales { get; set; }
        public bool TomadaPosesion { get; set; }

        #endregion

        #region Properties Sucesion Expediente

        public DateTime? SucesionPresentada { get; set; }
        public DateTime? SucesionAcordada { get; set; }
        public DateTime? SucesionCopiaSellada { get; set; }
        public DateTime? SucesionDenegada { get; set; }
        public bool SucesionOposicion { get; set; }
        public DateTime? SucesionRecurrida { get; set; }
        public TipoResultadoApelacion? SucesionResultadoRecuso { get; set; }
        public int? IdSucesionCausaIncidencia { get; set; }        
        public int? IdSucesionEstadoProcesalCliente { get; set; }
        public int? IdSucesionProblemasDetalles { get; set; }

        #endregion
    }
}
