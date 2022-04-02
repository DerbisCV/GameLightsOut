using Solvtio.Models.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ConcursalConvenioDesglose")]
    public partial class ConcursalConvenioDesglose
    {
        #region Constructors

        public ConcursalConvenioDesglose() { }
        public ConcursalConvenioDesglose(int idExpediente)
        {
            IdExpediente = idExpediente;
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdConvenioDesglose { get; set; }

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public string Clasificacion { get; set; }
        public decimal? DeudaReconocida { get; set; }
        public decimal? QuitaPorciento { get; set; }
        public int? CarenciaAnios { get; set; }
        public int? EsperaAnios { get; set; }
        public string TipoPago { get; set; }
        public decimal? ImporteACobrar { get; set; }
        public decimal? ImporteCuota { get; set; }
        public decimal? ImporteTotalPagado { get; set; }

        public TipoAdherido? EfectoConvenio { get; set; }
        public bool PagoInmediato { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaSentencia { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaUltimoPago { get; set; }

        //public decimal? Pago1Porciento { get; set; }
        //public decimal? Pago2Porciento { get; set; }
        //public decimal? Pago3Porciento { get; set; }
        //public decimal? Pago4Porciento { get; set; }
        //public decimal? Pago5Porciento { get; set; }
        //public decimal? Pago6Porciento { get; set; }
        //public decimal? Pago7Porciento { get; set; }
        //public decimal? Pago8Porciento { get; set; }
        //public decimal? Pago9Porciento { get; set; }
        //public decimal? Pago10Porciento { get; set; }

        //public decimal? Pago1Importe { get; set; }
        //public decimal? Pago2Importe { get; set; }
        //public decimal? Pago3Importe { get; set; }
        //public decimal? Pago4Importe { get; set; }
        //public decimal? Pago5Importe { get; set; }
        //public decimal? Pago6Importe { get; set; }
        //public decimal? Pago7Importe { get; set; }
        //public decimal? Pago8Importe { get; set; }
        //public decimal? Pago9Importe { get; set; }
        //public decimal? Pago10Importe { get; set; }

        public virtual ICollection<ConcursalConvenioDesglosePago> ConcursalConvenioDesglosePagoSet { get; set; }

        #endregion

        #region Properties Readonly

        //public decimal PeriodoPagoPorcientoTotal => (Pago1Porciento ?? 0) + (Pago2Porciento ?? 0) + (Pago3Porciento ?? 0) + (Pago4Porciento ?? 0) + (Pago5Porciento ?? 0) + 
        //    (Pago6Porciento ?? 0) + (Pago7Porciento ?? 0) + (Pago8Porciento ?? 0) + (Pago9Porciento ?? 0) + (Pago10Porciento ?? 0);
        //public decimal PeriodoPagoImporteTotal => (Pago1Importe ?? 0) + (Pago2Importe ?? 0) + (Pago3Importe ?? 0) + (Pago4Importe ?? 0) + (Pago5Importe ?? 0) + 
        //    (Pago6Importe ?? 0) + (Pago7Importe ?? 0) + (Pago8Importe ?? 0) + (Pago9Importe ?? 0) + (Pago10Importe ?? 0);

    
        #endregion
    }
}
