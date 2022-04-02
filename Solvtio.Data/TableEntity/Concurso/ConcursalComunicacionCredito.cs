using Solvtio.Models.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ConcursalComunicacionCredito")]
    public partial class ConcursalComunicacionCredito
    {
        #region Constructors

        public ConcursalComunicacionCredito() { }
        public ConcursalComunicacionCredito(int idExpediente, int? idExpedientePrestamo = null)
        {
            IdExpediente = idExpediente;
            IdExpedientePrestamo = idExpedientePrestamo;
        }
        public ConcursalComunicacionCredito(ExpedientePrestamo expPrestamo)
        {
            IdExpediente = expPrestamo.IdExpediente;
            IdExpedientePrestamo = expPrestamo.IdExpedientePrestamo;
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdComunicacionCredito { get; set; }

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public string Tipo { get; set; }
        public string NoContrato { get; set; }

        public bool Litigio { get; set; }

        public decimal? DeudaCalculada { get; set; }
        public decimal? DeudaInsinuada { get; set; }
        public decimal? DeudaReconocida { get; set; }

        public int? IdExpedientePrestamo { get; set; }
        [ForeignKey("IdExpedientePrestamo")]
        public virtual ExpedientePrestamo ExpedientePrestamo { get; set; }

        public int? IdClasificacionCalculada { get; set; }
        [ForeignKey("IdClasificacionCalculada")]
        public virtual CaracteristicaBase ClasificacionCalculada { get; set; }

        public int? IdClasificacionInsinuada { get; set; }
        [ForeignKey("IdClasificacionInsinuada")]
        public virtual CaracteristicaBase ClasificacionInsinuada { get; set; }

        public int? IdClasificacionReconocida { get; set; }
        [ForeignKey("IdClasificacionReconocida")]
        public virtual CaracteristicaBase ClasificacionReconocida { get; set; }

        public bool Cedido { get; set; }

        public decimal? PendienteDeCobro { get; set; }

        #endregion

        #region Properties Readonly

        //public decimal MasaPasivoTotal => (MasaPasivoPrivilegioEspecialTotal ?? 0) + (MasaPasivoPrivilegioGeneralTotal ?? 0) + (MasaPasivoOrdinarioTotal ?? 0) + (MasaPasivoSubordinadoTotal ?? 0);
        //public decimal MasaPasivoCliente => (MasaPasivoPrivilegioEspecialCliente ?? 0) + (MasaPasivoPrivilegioGeneralCliente ?? 0) + (MasaPasivoOrdinarioCliente ?? 0) + (MasaPasivoSubordinadoCliente ?? 0);

        //public decimal ContingenteTotal => (ContingentePrivilegioEspecialTotal ?? 0) + (ContingentePrivilegioGeneralTotal ?? 0) + (ContingenteOrdinarioTotal ?? 0) + (ContingenteSubordinadoTotal ?? 0);
        //public decimal ContingenteCliente => (ContingentePrivilegioEspecialCliente ?? 0) + (ContingentePrivilegioGeneralCliente ?? 0) + (ContingenteOrdinarioCliente ?? 0) + (ContingenteSubordinadoCliente ?? 0);

        #endregion
    }
}
