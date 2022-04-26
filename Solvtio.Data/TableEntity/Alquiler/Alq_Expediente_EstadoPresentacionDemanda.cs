using System;

namespace Solvtio.Models
{
    public class Alq_Expediente_EstadoPresentacionDemanda : EstadoPresentacionDemandaBase
    {
        public int ID { get; set; }

        public DateTime? FechaPagoTasas { get; set; }
        public DateTime? FechaPagoTasasAutomaticas { get; set; }

        public int? DocumentoTasasId { get; set; }
        public int? DocumentoPresentacionId { get; set; }
        public int? DocumentoAutoEjecucionId { get; set; }

        public int? AdmitidaDocumentoId { get; set; }
        public string AdmitidaNoAuto { get; set; }
        public string AdmitidaJuzgado { get; set; }
        public DateTime? NoAdmitidaFecha { get; set; }
        public DateTime? NoAdmitidaFechaApelacion { get; set; }
        public bool? NoAdmitidaApelacion { get; set; }
        public int? NoAdmitidaDocumentoId { get; set; }
        public int? NoAdmitidaDocumentoApelacionId { get; set; }

        public string ParalizadoPor { get; set; }

        //public virtual ExpedienteDocumento ExpedienteDocumento { get; set; }
        //public virtual ExpedienteDocumento ExpedienteDocumento1 { get; set; }
        //public virtual ExpedienteDocumento ExpedienteDocumento2 { get; set; }
        //public virtual ExpedienteDocumento ExpedienteDocumento3 { get; set; }
        //public virtual ExpedienteDocumento ExpedienteDocumento4 { get; set; }
        //public virtual ExpedienteDocumento ExpedienteDocumento5 { get; set; }
    }
}
