using Solvtio.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Solvtio.Models
{
    [Table("ExpedienteContrato")]
    public class ExpedienteContrato
    {
        #region Constructors

        public ExpedienteContrato()
        {
            CreateBase();
        }

        public ExpedienteContrato(int idExpediente)
        {
            CreateBase();
            IdExpediente = idExpediente;
        }
        public ExpedienteContrato(int idExpediente, DateTime? fecha, string noContrato)
        {
            CreateBase();

            IdExpediente = idExpediente;
            Fecha = fecha;
            NoContrato = noContrato;
        }

        private void CreateBase()
        {
            IdEntidadGestora = 1;
            //Fecha = DateTime.Now;
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedienteContrato { get; set; }

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public DateTime? Fecha { get; set; }
        public string NoContrato { get; set; }
        public string EntidadOrigen { get; set; }

        public bool Cedido { get; set; }

        public int? IdEntidadGestora { get; set; }
        [ForeignKey("IdEntidadGestora")]
        public virtual EntidadGestora EntidadGestora { get; set; }

        public decimal CuantiaTotal { get; set; } // Retirado por concursal (04/01/2019)
        public decimal DeudaInsinuada { get; set; }
        public decimal DeudaReconocida { get; set; }

        //public decimal ImporteRecuperado { get; set; }

        //public int? IdEstrategia { get; set; }
        //[ForeignKey("IdEstrategia")]
        //public virtual CaracteristicaBase Estrategia { get; set; }

        public string Observaciones { get; set; }


        public string TipoIntervencion { get; set; }
        public string Clasificacion { get; set; }
        public bool VencimientoAnticipado { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaVencimiento { get; set; }

        #endregion

        #region One 2 Many 

        public virtual ICollection<ExpedienteContratoDeudaDesglose> ExpedienteContratoDeudaDesgloseSet { get; set; }
        public virtual ICollection<ConcursalGarantiaOtra> ConcursalGarantiaOtraSet { get; set; }
        public virtual ICollection<ExpedienteDeudor> ExpedienteDeudorSet { get; set; }
        public virtual ICollection<ExpedienteContratoRecuperacion> ExpedienteContratoRecuperacionSet { get; set; }

        #endregion

        #region Properties Readonly

        public decimal Diferencia => DeudaInsinuada - DeudaReconocida;
        public bool Litigio => Diferencia > 0;

        public decimal SumImporteRecuperado => ExpedienteContratoRecuperacionSet.IsEmpty() ? 0 : ExpedienteContratoRecuperacionSet.Sum(x => x.ImporteRecuperado);

        #endregion

        #region Properties NotMapped

        [NotMapped]
        public List<InmuebleContrato> LstFincaContrato { get; set; }

        [NotMapped]
        public int CantidadInmuebles { get; set; }

        #endregion

        #region Methods

        public void Refresh(ExpedienteContrato model)
        {
            Fecha = model.Fecha;
            NoContrato = model.NoContrato;
            EntidadOrigen = model.EntidadOrigen;
            IdEntidadGestora = model.IdEntidadGestora;
            Observaciones = model.Observaciones;
            Cedido = model.Cedido;
            TipoIntervencion = model.TipoIntervencion;
            Clasificacion = model.Clasificacion;
            VencimientoAnticipado = model.VencimientoAnticipado;
            FechaVencimiento = model.FechaVencimiento;
            //IdEstrategia = model.IdEstrategia;
            //ImporteRecuperado = model.ImporteRecuperado;
        }

        #endregion
    }
}
