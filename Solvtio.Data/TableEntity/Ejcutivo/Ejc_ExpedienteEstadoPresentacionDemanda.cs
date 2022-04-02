using System;

namespace Solvtio.Models
{
    public class Ejc_ExpedienteEstadoPresentacionDemanda : EstadoPresentacionDemandaBase
    {
        #region Properties

        public int IdExpediente { get; set; }

        public DateTime? NoAdmitidaFecha { get; set; }
        public DateTime? NoAdmitidaFechaApelacion { get; set; }
        public bool NoAdmitidaApelacion { get; set; }
        public DateTime? NoAdmitidaFechaResultadoApelacion { get; set; }
        public int? NoAdmitidaResultadoApelacionId { get; set; }

        public int? DocumentoTasasId { get; set; }
        public int? DocumentoPresentacionId { get; set; }
        public int? NoAdmitidaDocumentoId { get; set; }
        public int? NoAdmitidaDocumentoApelacionId { get; set; }

        public DateTime? FechaPagoTasas { get; set; }

        #endregion

        #region Methods

        internal void RefreshBy(ExpedienteEstadoMonitorioPresentacionDemanda estadoPresentacionDemanda)
        {
            FechaPagoTasas = estadoPresentacionDemanda.FechaPagoTasas;
            FechaEnvioProcurador = estadoPresentacionDemanda.FechaEnvioProcurador;
            FechaPresentacion = estadoPresentacionDemanda.FechaPresentacion;
            NoAdmitidaApelacion = estadoPresentacionDemanda.NoAdmitidaApelacion;
            NoAdmitidaFecha = estadoPresentacionDemanda.NoAdmitidaFecha;
            NoAdmitidaFechaApelacion = estadoPresentacionDemanda.NoAdmitidaFechaApelacion;
        }

        #endregion
    }
}
