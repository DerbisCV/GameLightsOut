using Solvtio.Models.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteContratoDeudaDesglose")]
    public partial class ExpedienteContratoDeudaDesglose
    {
        #region Constructors

        public ExpedienteContratoDeudaDesglose() { }
        //public ExpedienteContratoDeudaDesglose(int idExpediente, int? idExpedientePrestamo = null)
        //{
        //    IdExpediente = idExpediente;
        //    IdExpedientePrestamo = idExpedientePrestamo;
        //}
        //public ExpedienteContratoDeudaDesglose(ExpedientePrestamo expPrestamo)
        //{
        //    IdExpediente = expPrestamo.IdExpediente;
        //    IdExpedientePrestamo = expPrestamo.IdExpedientePrestamo;
        //}

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedienteContratoDeudaDesglose { get; set; }

        public int IdExpedienteContrato { get; set; }
        [ForeignKey("IdExpedienteContrato")]
        public virtual ExpedienteContrato ExpedienteContrato { get; set; }

        public int? IdTipoInsinuada { get; set; }
        [ForeignKey("IdTipoInsinuada")]
        public virtual CaracteristicaBase TipoInsinuada { get; set; }

        public int? IdTipoReconocida { get; set; }
        [ForeignKey("IdTipoReconocida")]
        public virtual CaracteristicaBase TipoReconocida { get; set; }

        public decimal DeudaInsinuada { get; set; }
        public decimal DeudaReconocida { get; set; }





        //public int? IdTipo { get; set; }
        //[ForeignKey("IdTipo")]
        //public virtual CaracteristicaBase Tipo { get; set; }


        #endregion

        #region Properties Readonly

        public decimal Diferencia => DeudaInsinuada - DeudaReconocida;
        public bool Litigio => Diferencia > 0;

        //public decimal ContingenteTotal => (ContingentePrivilegioEspecialTotal ?? 0) + (ContingentePrivilegioGeneralTotal ?? 0) + (ContingenteOrdinarioTotal ?? 0) + (ContingenteSubordinadoTotal ?? 0);
        //public decimal ContingenteCliente => (ContingentePrivilegioEspecialCliente ?? 0) + (ContingentePrivilegioGeneralCliente ?? 0) + (ContingenteOrdinarioCliente ?? 0) + (ContingenteSubordinadoCliente ?? 0);

        #endregion
    }
}
