using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ContratoFacturaCondicion")]
    public class ContratoFacturaCondicion
    {
        #region Constructors

        public ContratoFacturaCondicion(){ CreateBase(); }
        public ContratoFacturaCondicion(int idContratoFactura)
        {
            CreateBase();
            IdContratoFactura = idContratoFactura;
        }
        public ContratoFacturaCondicion(ContratoFacturaCondicion modelBase)
        {
            CreateBase();
            IdContratoFactura = modelBase.IdContratoFactura;
            Refresh(modelBase);
            //IdHito1 = modelBase.IdHito1;
        }

        private void CreateBase()
        {
            //TipoCondicion = TipoCondicionFacturacion.Simple;
            //Fecha = FechaAlta = DateTime.Now;
            //Activo = true;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdContratoFacturaCondicion { get; set; }

        public int IdContratoFactura { get; set; }
        [ForeignKey("IdContratoFactura")]
        public virtual ContratoFactura ContratoFactura { get; set; }

        //[DefaultValue(1)]
        //public TipoCondicionFacturacion TipoCondicion { get; set; }

        public int IdHito1 { get; set; }
        [ForeignKey("IdHito1")]
        public virtual Hito Hito1 { get; set; }
        public TipoSiNo? Hito1Resultado { get; set; }

        //Condicional OR
        public int? IdHito2 { get; set; }
        [ForeignKey("IdHito2")]
        public virtual Hito Hito2 { get; set; }
        public TipoSiNo? Hito2Resultado { get; set; }

        //Condicional OR
        public int? IdHito3 { get; set; }
        [ForeignKey("IdHito3")]
        public virtual Hito Hito3 { get; set; }
        public TipoSiNo? Hito3Resultado { get; set; }

        public int DiasDesde { get; set; }
        public int DiasHasta { get; set; }

        #endregion

        #region Properties virtual ICollection

        //public virtual ICollection<NotificacionMailAttachment> NotificacionMailAttachmentSet { get; set; }

        #endregion

        #region Properties ReadOnly

        public string CondicionHtml1 => Hito1 == null ? "" : $"Que <b>{Hito1Resultado.ToString()}</b> tenga <b>{Hito1.Nombre}</b>";
        public string CondicionHtml2 => Hito2 == null ? "" : $"Que <b>{Hito2Resultado.ToString()}</b> tenga <b>{Hito2.Nombre}</b>";
        public string CondicionHtml3 => Hito3 == null ? "" : $"Que <b>{Hito3Resultado.ToString()}</b> tenga <b>{Hito3.Nombre}</b>";

        public string CondicionHtmlTipoSimple => 
            CondicionHtml1 +
            (string.IsNullOrWhiteSpace(CondicionHtml2) ? "" : $" O {CondicionHtml2}") +
            (string.IsNullOrWhiteSpace(CondicionHtml3) ? "" : $" O {CondicionHtml3}");

        public string CondicionHtmlTipoTiempo => $"Desde <b>{Hito1.Nombre}</b> hasta <b>{Hito2.Nombre}</b> => Dias: [{DiasDesde} - {DiasHasta}]";

        public string CondicionHtmlAll => Hito1Resultado.HasValue ? CondicionHtmlTipoSimple : CondicionHtmlTipoTiempo;

        public bool HasValue => IdHito1 > 0; // && Hito1Resultado.HasValue;

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

        internal void Refresh(ContratoFacturaCondicion model)
        {
            IdHito1 = model.IdHito1;
            IdHito2 = model.IdHito2;
            IdHito3 = model.IdHito3;

            Hito1Resultado = model.Hito1Resultado;
            Hito2Resultado = model.Hito2Resultado;
            Hito3Resultado = model.Hito3Resultado;

            DiasDesde = model.DiasDesde;
            DiasHasta = model.DiasHasta;
        }

        #endregion

    }




}
