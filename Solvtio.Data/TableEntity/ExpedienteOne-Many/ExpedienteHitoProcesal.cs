using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ExpedienteHitoProcesal")]
    public class ExpedienteHitoProcesal
    {
        #region Constructors

        public ExpedienteHitoProcesal(){ CreateBase(); }
        public ExpedienteHitoProcesal(int idExpediente, SlaType hito, DateTime fInicio, int targetMin, int targetMax)
        {
            CreateBase();
            IdExpediente = idExpediente;
            HitoProcesalType = hito;
            FechaInicio = fInicio;
            FechaYellow = fInicio.AddDays(targetMin);
            FechaVencimiento = fInicio.AddDays(targetMax);
        }

        private void CreateBase()
        {
            HitoProcesalType = SlaType.HipotecarioPresentacionDemanda;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedienteHitoProcesal { get; set; }

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public SlaType HitoProcesalType { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaYellow { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime? FechaFinReal { get; set; }
        public DateTime? FechaCancelacion { get; set; }

        #endregion

        #region Properties virtual ICollection

        //public virtual ICollection<NotificacionMailAttachment> NotificacionMailAttachmentSet { get; set; }

        #endregion

        #region Properties ReadOnly

        public DateTime FechaFin => FechaFinReal ?? DateTime.Today;

        public string Estado => 
            FechaFinReal.HasValue ? "Cerrado" :
            FechaCancelacion.HasValue ? "Cancelado" :
            "En progreso";
        public int TotalDiasTranscurridos => FechaFin < FechaInicio ? 0 : FechaInicio.GetDaysBetweenDates(FechaFin);
        public int TotalDiasVencimiento => FechaVencimiento < FechaInicio ? 0 : FechaInicio.GetDaysBetweenDates(FechaVencimiento);
        public int TotalDiasRestantes => (FechaVencimiento < FechaFin ? -1 : 1) * FechaFin.GetDaysBetweenDates(FechaVencimiento);

        public int PercentTranscurridos => TotalDiasVencimiento > 0 ? 100 * TotalDiasTranscurridos / TotalDiasVencimiento : 0;

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{FechaInicio.ToShortDateString()}-{FechaFin.ToShortDateString()} ({TotalDiasTranscurridos} días) [Vcmto]: {FechaVencimiento.ToShortDateString()}.";
        }

        internal void RefreshFinRealCancelacion(ExpedienteEstado expedienteEstado, DateTime? fechaFinReal1, DateTime? fechaFinReal2)
        {
            RefreshFinRealCancelacion(fechaFinReal1 ?? fechaFinReal2, expedienteEstado);
        }
        internal void RefreshFinRealCancelacion(DateTime? fechaFinReal, ExpedienteEstado expedienteEstado)
        {
            FechaFinReal = fechaFinReal;

            if (FechaFinReal.HasValue)
                FechaCancelacion = null;
            else if (Expediente.Fin.HasValue)
                FechaCancelacion = Expediente.Fin;
            else if (expedienteEstado?.IdTipoSubFaseEstado == 1010102 || expedienteEstado?.IdTipoSubFaseEstado == 1010104 || expedienteEstado?.IdTipoSubFaseEstado == 731010104)
                FechaCancelacion = DateTime.Now;
            else
                FechaCancelacion = null;
        }

        #endregion

    }
}
