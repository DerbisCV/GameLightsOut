using Solvtio.Models.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteCobro")]
    public class ExpedienteCobro : Auditable
    {
        #region Constructors

        public ExpedienteCobro()
        {
            CreatedDate = UpdatedDate = DateTime.Now;
            Fecha = DateTime.Today;
        }

        public ExpedienteCobro(int idExpediente) : this()
        {
            IdExpediente = idExpediente;
        }
        public ExpedienteCobro(int idExpediente, DateTime? fecha) : this()
        {
            IdExpediente = idExpediente;
            Fecha = fecha;
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedienteCobro { get; set; }

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Fecha { get; set; }

        //public int? IdTipo { get; set; }
        //[ForeignKey("IdTipo")]
        //public virtual CaracteristicaBase Tipo { get; set; }

        public decimal Importe { get; set; }
        public string Referencia { get; set; }
        public string Nota { get; set; }

        //public bool EnviadoFacturar { get; set; }
        //public string NoFactura { get; set; }
        //[DataType(DataType.Date)]
        //public DateTime? FechaFactura { get; set; }
        //public bool Pagado { get; set; }

        #endregion

        #region One 2 Many 

        #endregion

        #region Properties Readonly

        public override bool IsNew => IdExpedienteCobro < 1;

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public List<InmuebleContrato> LstFincaContrato { get; set; }

        //[NotMapped]
        //public int CantidadInmuebles { get; set; }

        #endregion

        public void RefreshBy(ExpedienteCobro model)
        {
            Fecha = model.Fecha;
            //IdTipo = model.IdTipo;
            Importe = model.Importe;
            Nota = model.Nota;
            Referencia = model.Referencia;
            //NoFactura = model.NoFactura;
            //Pagado = model.Pagado; 
            //FechaFactura = model.FechaFactura;
        }
    }
}
