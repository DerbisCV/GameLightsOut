using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ContratoFactura")]
    public class ContratoFactura
    {
        #region Constructors

        public ContratoFactura(){ CreateBase(); }
        public ContratoFactura(int idCliente, int idtipoExpediente)
        {
            CreateBase();
            IdCliente = idCliente;
            IdTipoExpediente = idtipoExpediente;
        }

        private void CreateBase()
        {
            Fecha = FechaAlta = DateTime.Now;
            Activo = true;
            BaseImposibleImporte = BaseImposiblePorciento = 0;
            TipoCondicion = TipoCondicionFacturacion.Simple;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdContratoFactura { get; set; }

        public int IdCliente { get; set; }
        [ForeignKey("IdCliente")]
        public virtual Gnr_Cliente Cliente { get; set; }

        public int IdTipoExpediente { get; set; }
        [ForeignKey("IdTipoExpediente")]
        public virtual Gnr_TipoExpediente TipoExpediente { get; set; }

        public HitoFacturacionValue? HitoFacturacion { get; set; }

        public decimal BaseImposibleImporte { get; set; }
        public decimal BaseImposiblePorciento { get; set; }

        [DefaultValue(1)]
        public TipoCondicionFacturacion TipoCondicion { get; set; }


        public DateTime Fecha { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Usuario { get; set; }
        public bool Activo { get; set; }


        #endregion

        #region Properties virtual ICollection

        public virtual ICollection<ContratoFacturaCondicion> ContratoFacturaCondicionSet { get; set; }

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
        internal void Refresh(ContratoFactura model)
        {
            IdTipoExpediente = model.IdTipoExpediente;
            HitoFacturacion = model.HitoFacturacion;
            BaseImposibleImporte = model.BaseImposibleImporte;
            BaseImposiblePorciento = model.BaseImposiblePorciento;
            Fecha = model.Fecha;
            Activo = model.Activo;
            TipoCondicion = model.TipoCondicion;
        }

        #endregion

    }




}
