using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public partial class Con_ExpedienteEstadoLiquidacion : IConConclusion, IConCalificacion
    {
        #region Properties

        public int ExpedienteEstadoId { get; set; }
        public DateTime? FechaApertura { get; set; }
        public bool PlanLiquidacion { get; set; }

        public bool Alegaciones { get; set; }
        public string Duracion { get; set; }
        public int? IdResultado { get; set; }

        public DateTime? FechaPlanLiquidacion { get; set; }
        public string SentenciaAprobandoConvenio { get; set; }
        public DateTime? FechaImpugnacion { get; set; }
        public int? DocumentoPlanLiquidacionId { get; set; }
        public int? DocumentoImpugnacionId { get; set; }
        public int? DocumentoAutoJuezId { get; set; }
        public int? DocumentoEdictoSubastaId { get; set; }
        public DateTime? FechaAprobacionPlanLiquidacion { get; set; }

        public DateTime? ConclusionFechaSolicitud { get; set; }
        public DateTime? ConclusionFechaOposicion { get; set; }
        public DateTime? ConclusionFechaRendicionCuentas { get; set; }
        public DateTime? ConclusionFechaOposicionRendicionCuentas { get; set; }
        public DateTime? ConclusionFechaAuto { get; set; }

        public virtual ExpedienteDocumento ExpedienteDocumento { get; set; }
        public virtual ExpedienteDocumento ExpedienteDocumento1 { get; set; }
        public virtual ExpedienteDocumento ExpedienteDocumento2 { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public DateTime? CalificacionFechaApertura { get; set; }
        public DateTime? CalificacionFechaPersonacion { get; set; }
        public DateTime? CalificacionFechaVista { get; set; }
        public DateTime? CalificacionFechaSentencia { get; set; }
        public bool CalificacionPersonacion { get; set; }

        public int? CalificacionACId { get; set; }
        [ForeignKey("CalificacionACId")]
        public virtual Con_TipoCalificacion CalificacionAC { get; set; }

        public int? CalificacionFiscalId { get; set; }
        [ForeignKey("CalificacionFiscalId")]
        public virtual Con_TipoCalificacion CalificacionFiscal { get; set; }

        public int? CalificacionDefinitivaId { get; set; }
        [ForeignKey("CalificacionDefinitivaId")]
        public virtual Con_TipoCalificacion CalificacionDefinitiva { get; set; }

        public string PlanCondiciones { get; set; }

        #endregion

        #region Methods

        public void Refresh(Con_ExpedienteEstadoLiquidacion model)
        {
            FechaApertura = model.FechaApertura;
            FechaPlanLiquidacion = model.FechaPlanLiquidacion;
            FechaAprobacionPlanLiquidacion = model.FechaAprobacionPlanLiquidacion;
            PlanLiquidacion = model.PlanLiquidacion;
            Alegaciones = model.Alegaciones;
            Duracion = model.Duracion;
            IdResultado = model.IdResultado;
            SentenciaAprobandoConvenio = model.SentenciaAprobandoConvenio;
            FechaImpugnacion = model.FechaImpugnacion;
            PlanCondiciones = model.PlanCondiciones;

            RefreshClasificacion(model);
            RefreshConclusion(model);
        }

        public void RefreshConclusion(IConConclusion modelBase)
        {
            ConclusionFechaSolicitud = modelBase.ConclusionFechaSolicitud;
            ConclusionFechaOposicion = modelBase.ConclusionFechaOposicion;
            ConclusionFechaRendicionCuentas = modelBase.ConclusionFechaRendicionCuentas;
            ConclusionFechaOposicionRendicionCuentas = modelBase.ConclusionFechaOposicionRendicionCuentas;
            ConclusionFechaAuto = modelBase.ConclusionFechaAuto;
        }

        public void RefreshClasificacion(IConCalificacion modelBase)
        {
            CalificacionFechaApertura = modelBase.CalificacionFechaApertura;
            CalificacionFechaPersonacion = modelBase.CalificacionFechaPersonacion;
            CalificacionFechaVista = modelBase.CalificacionFechaVista;
            CalificacionFechaSentencia = modelBase.CalificacionFechaSentencia;
            CalificacionPersonacion = modelBase.CalificacionPersonacion;

            CalificacionACId = modelBase.CalificacionACId;
            CalificacionFiscalId = modelBase.CalificacionFiscalId;
            CalificacionDefinitivaId = modelBase.CalificacionDefinitivaId;            
        }

        #endregion
    }
}
