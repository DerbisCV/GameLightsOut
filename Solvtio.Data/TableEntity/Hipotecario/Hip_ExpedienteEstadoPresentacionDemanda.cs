using System;

namespace Solvtio.Models
{
    public class HipExpedienteEstadoPresentacionDemanda : EstadoPresentacionDemandaBase
    {

        #region Properties
        //public int IdExpedienteEstado { get; set; }
        //public virtual ExpedienteEstado ExpedienteEstado { get; set; }
        //public DateTime? FechaEnvioProcurador { get; set; }
        //public DateTime? FechaPresentacion { get; set; }

        public DateTime? FechaPagoTasas { get; set; }

        public int? DocumentoTasasId { get; set; }
        public int? DocumentoPresentacionId { get; set; }
        public int? DocumentoAutoEjecucionId { get; set; }
        public DateTime? AdmitidaFecha { get; set; }
        public int? AdmitidaDocumentoId { get; set; }
        public string AdmitidaNoAuto { get; set; }
        public string AdmitidaJuzgado { get; set; }
        public DateTime? NoAdmitidaFecha { get; set; }
        public DateTime? NoAdmitidaFechaApelacion { get; set; }
        public bool NoAdmitidaApelacion { get; set; }
        public int? NoAdmitidaDocumentoId { get; set; }
        public int? NoAdmitidaDocumentoApelacionId { get; set; }

        public DateTime? NoAdmitidaFechaResultadoApelacion { get; set; }
        public int? NoAdmitidaResultadoApelacionId { get; set; }

        //Old Properties (DeleteMe)
        public DateTime? FechaAutoSubsanado { get; set; }

        #endregion

        #region Documentos

        public virtual ExpedienteDocumento ExpedienteDocumento { get; set; }
        public virtual ExpedienteDocumento ExpedienteDocumento1 { get; set; }
        public virtual ExpedienteDocumento ExpedienteDocumento2 { get; set; }
        public virtual ExpedienteDocumento ExpedienteDocumento3 { get; set; }
        public virtual ExpedienteDocumento ExpedienteDocumento4 { get; set; }

        #endregion

        #region Properties Readonly

        #endregion

        #region Methods

        internal void RefreshBy(Ejc_ExpedienteEstadoPresentacionDemanda model)
        {
            FechaPagoTasas = model.FechaPagoTasas;
            FechaEnvioProcurador = model.FechaEnvioProcurador;
            FechaPresentacion = model.FechaPresentacion;
            NoAdmitidaApelacion = model.NoAdmitidaApelacion;
            NoAdmitidaFecha = model.NoAdmitidaFecha;
            NoAdmitidaFechaApelacion = model.NoAdmitidaFechaApelacion;

            NoAdmitidaFechaResultadoApelacion = model.NoAdmitidaFechaResultadoApelacion;
            NoAdmitidaResultadoApelacionId = model.NoAdmitidaResultadoApelacionId;
        }

        internal void RefreshBy(HipExpedienteEstadoPresentacionDemanda model)
        {
            FechaPagoTasas = model.FechaPagoTasas;
            FechaEnvioProcurador = model.FechaEnvioProcurador;
            FechaPresentacion = model.FechaPresentacion;
            NoAdmitidaApelacion = model.NoAdmitidaApelacion;
            NoAdmitidaFecha = model.NoAdmitidaFecha;
            NoAdmitidaFechaApelacion = model.NoAdmitidaFechaApelacion;

            NoAdmitidaFechaResultadoApelacion = model.NoAdmitidaFechaResultadoApelacion;
            NoAdmitidaResultadoApelacionId = model.NoAdmitidaResultadoApelacionId;
        }     

        #endregion

    }
}
