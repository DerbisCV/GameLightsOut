using Solvtio.Models.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ConcursalGarantiaOtra")]
    public partial class ConcursalGarantiaOtra
    {
        #region Constructors

        public ConcursalGarantiaOtra() { }
        public ConcursalGarantiaOtra(int idExpediente)
        {
            IdExpediente = idExpediente;
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdGarantiaOtra { get; set; }

        [NotMapped]
        public int IdExpediente { get; set; }
        //[ForeignKey("IdExpediente")]
        //public virtual Expediente Expediente { get; set; }

        public int IdExpedienteContrato { get; set; }
        [ForeignKey("IdExpedienteContrato")]
        public virtual ExpedienteContrato ExpedienteContrato { get; set; }


        //public string NoContrato { get; set; }

        public string NoLote { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public string Observaciones { get; set; }

        //public decimal? ImporteSubasta { get; set; }

        #endregion

        #region Properties Readonly

        //public decimal MasaPasivoTotal => (MasaPasivoPrivilegioEspecialTotal ?? 0) + (MasaPasivoPrivilegioGeneralTotal ?? 0) + (MasaPasivoOrdinarioTotal ?? 0) + (MasaPasivoSubordinadoTotal ?? 0);
        //public decimal MasaPasivoCliente => (MasaPasivoPrivilegioEspecialCliente ?? 0) + (MasaPasivoPrivilegioGeneralCliente ?? 0) + (MasaPasivoOrdinarioCliente ?? 0) + (MasaPasivoSubordinadoCliente ?? 0);

        //public decimal ContingenteTotal => (ContingentePrivilegioEspecialTotal ?? 0) + (ContingentePrivilegioGeneralTotal ?? 0) + (ContingenteOrdinarioTotal ?? 0) + (ContingenteSubordinadoTotal ?? 0);
        //public decimal ContingenteCliente => (ContingentePrivilegioEspecialCliente ?? 0) + (ContingentePrivilegioGeneralCliente ?? 0) + (ContingenteOrdinarioCliente ?? 0) + (ContingenteSubordinadoCliente ?? 0);

        #endregion
    }
}
