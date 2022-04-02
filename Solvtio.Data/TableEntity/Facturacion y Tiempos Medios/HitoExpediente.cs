using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("HitoExpediente")]
    public class HitoExpediente
    {
        #region Constructors

        public HitoExpediente(){ CreateBase(); }
        public HitoExpediente(int idExpediente, int idHito, DateTime fecha, string usuario, decimal? importe = null)
        {
            CreateBase();
            IdExpediente = idExpediente;
            IdHito = idHito;
            Fecha = fecha;
            Usuario = usuario;
            Importe = importe;
        }

        private void CreateBase()
        {
            Fecha = FechaAlta = DateTime.Now;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdHitoExpediente { get; set; }

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public int IdHito { get; set; }
        [ForeignKey("IdHito")]
        public virtual Hito Hito { get; set; }

        public DateTime Fecha { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Usuario { get; set; }
        public decimal? Importe { get; set; }

        #endregion

        #region Properties virtual ICollection

        //public virtual ICollection<NotificacionMailAttachment> NotificacionMailAttachmentSet { get; set; }

        #endregion

        #region Properties ReadOnly

        //public DateTime FechaFin => FechaFinReal ?? DateTime.Today;

        //public string Estado => 
        //    FechaFinReal.HasValue ? "Cerrado" :
        //    FechaCancelacion.HasValue ? "Cancelado" :
        //    "En progreso";
        //public int TotalDiasTranscurridos => FechaFin < FechaInicio ? 0 : FechaInicio.GetDaysBetweenDates(FechaFin);
        //public int TotalDiasVencimiento => FechaVencimiento < FechaInicio ? 0 : FechaInicio.GetDaysBetweenDates(FechaVencimiento);
        //public int TotalDiasRestantes => (FechaVencimiento < FechaFin ? -1 : 1) * FechaFin.GetDaysBetweenDates(FechaVencimiento);

        //public int PercentTranscurridos => TotalDiasVencimiento > 0 ? 100 * TotalDiasTranscurridos / TotalDiasVencimiento : 0;

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion

        #region Methods

        //public override string ToString()
        //{
        //    return $"{FechaInicio.ToShortDateString()}-{FechaFin.ToShortDateString()} ({TotalDiasTranscurridos} días) [Vcmto]: {FechaVencimiento.ToShortDateString()}.";
        //}

        //internal void RefreshFinRealCancelacion(ExpedienteEstado expedienteEstado, DateTime? fechaFinReal1, DateTime? fechaFinReal2)
        //{
        //    RefreshFinRealCancelacion(fechaFinReal1 ?? fechaFinReal2, expedienteEstado);
        //}
        //internal void RefreshFinRealCancelacion(DateTime? fechaFinReal, ExpedienteEstado expedienteEstado)
        //{
        //    FechaFinReal = fechaFinReal;

        //    if (FechaFinReal.HasValue)
        //        FechaCancelacion = null;
        //    else if (Expediente.Fin.HasValue)
        //        FechaCancelacion = Expediente.Fin;
        //    else if (expedienteEstado?.IdTipoSubFaseEstado == 1010102 || expedienteEstado?.IdTipoSubFaseEstado == 1010104 || expedienteEstado?.IdTipoSubFaseEstado == 731010104)
        //        FechaCancelacion = DateTime.Now;
        //    else
        //        FechaCancelacion = null;
        //}

        #endregion

    }
}
