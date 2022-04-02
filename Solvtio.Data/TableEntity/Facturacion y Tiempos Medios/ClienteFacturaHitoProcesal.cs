using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ClienteFacturaHitoProcesal")]
    public class ClienteFacturaHitoProcesal
    {
        #region Constructors

        public ClienteFacturaHitoProcesal(){ CreateBase(); }
        public ClienteFacturaHitoProcesal(int idCliente, int idTipoHitoProcesal, HitoFacturacionValue hitoFacturacion, decimal importe)
        {
            CreateBase();
            IdCliente = idCliente;
            IdTipoHitoProcesal = idTipoHitoProcesal;
            HitoFacturacion = hitoFacturacion;
            ImporteBase1 = importe;
        }

        private void CreateBase()
        {
            FechaAlta = DateTime.Now;
            Activo = true;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int IdCliente { get; set; }
        [ForeignKey("IdCliente")]
        public virtual Gnr_Cliente Cliente { get; set; }

        public HitoFacturacionValue HitoFacturacion { get; set; }

        public int IdTipoHitoProcesal { get; set; }
        [ForeignKey("IdTipoHitoProcesal")]
        public virtual TipoHitoProcesal TipoHitoProcesal { get; set; }

        public decimal ImporteBase1 { get; set; }

        public string Nota { get; set; }

        public DateTime FechaAlta { get; set; }
        public string Usuario { get; set; }
        public bool Activo { get; set; }
        
        #endregion

        #region Properties virtual ICollection

        //public virtual ICollection<ClienteFacturaHitoCondicion> ClienteFacturaHitoCondicionSet { get; set; }

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
        //internal void Refresh(ClienteFacturaHito model)
        //{
        //    IdTipoExpediente = model.IdTipoExpediente;
        //    HitoFacturacion = model.HitoFacturacion;
        //    BaseImposibleImporte = model.BaseImposibleImporte;
        //    BaseImposiblePorciento = model.BaseImposiblePorciento;
        //    Fecha = model.Fecha;
        //    Activo = model.Activo;
        //    TipoCondicion = model.TipoCondicion;
        //}

        #endregion

    }




}
