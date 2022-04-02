using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteContratoRecuperacion")]
    public partial class ExpedienteContratoRecuperacion
    {
        #region Constructors

        public ExpedienteContratoRecuperacion() { }
        //public ExpedienteContratoRecuperacion(int idExpediente, int? idExpedientePrestamo = null)
        //{
        //    IdExpediente = idExpediente;
        //    IdExpedientePrestamo = idExpedientePrestamo;
        //}
        //public ExpedienteContratoRecuperacion(ExpedientePrestamo expPrestamo)
        //{
        //    IdExpediente = expPrestamo.IdExpediente;
        //    IdExpedientePrestamo = expPrestamo.IdExpedientePrestamo;
        //}

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedienteContratoRecuperacion { get; set; }

        public int IdExpedienteContrato { get; set; }
        [ForeignKey("IdExpedienteContrato")]
        public virtual ExpedienteContrato ExpedienteContrato { get; set; }

        public int? IdEstrategia { get; set; }
        [ForeignKey("IdEstrategia")]
        public virtual CaracteristicaBase Estrategia { get; set; }

        public decimal ImporteRecuperado { get; set; }

        public DateTime? Fecha { get; set; }

        #endregion

        #region Properties Readonly

        //public decimal Diferencia => DeudaInsinuada - DeudaReconocida;
        //public bool Litigio => Diferencia > 0;

        //public decimal ContingenteTotal => (ContingentePrivilegioEspecialTotal ?? 0) + (ContingentePrivilegioGeneralTotal ?? 0) + (ContingenteOrdinarioTotal ?? 0) + (ContingenteSubordinadoTotal ?? 0);
        //public decimal ContingenteCliente => (ContingentePrivilegioEspecialCliente ?? 0) + (ContingentePrivilegioGeneralCliente ?? 0) + (ContingenteOrdinarioCliente ?? 0) + (ContingenteSubordinadoCliente ?? 0);

        #endregion

        #region Methods

        internal void Refresh(ExpedienteContratoRecuperacion modelBase)
        {
            IdEstrategia = modelBase.IdEstrategia;
            ImporteRecuperado = modelBase.ImporteRecuperado;
            Fecha = modelBase.Fecha;
        }

        #endregion
    }
}
