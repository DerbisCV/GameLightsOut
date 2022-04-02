using Solvtio.Models.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ConcursalConvenioDesglosePago")]
    public partial class ConcursalConvenioDesglosePago
    {
        #region Constructors

        public ConcursalConvenioDesglosePago() { Realizado = false; }
        public ConcursalConvenioDesglosePago(int idConcursalConvenioDesglose)
        {
            IdConcursalConvenioDesglose = idConcursalConvenioDesglose;
            Realizado = false;
        }
        
        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdConvenioDesglosePago { get; set; }

        public int IdConcursalConvenioDesglose { get; set; }
        [ForeignKey("IdConcursalConvenioDesglose")]
        public virtual ConcursalConvenioDesglose ConcursalConvenioDesglose { get; set; }

        public decimal? Porciento { get; set; }
        public decimal? Importe { get; set; }
        public bool Realizado { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaPagoPrevista { get; set; }

        #endregion

        #region Properties Readonly

        //public decimal ContingenteTotal => (ContingentePrivilegioEspecialTotal ?? 0) + (ContingentePrivilegioGeneralTotal ?? 0) + (ContingenteOrdinarioTotal ?? 0) + (ContingenteSubordinadoTotal ?? 0);
        //public decimal ContingenteCliente => (ContingentePrivilegioEspecialCliente ?? 0) + (ContingentePrivilegioGeneralCliente ?? 0) + (ContingenteOrdinarioCliente ?? 0) + (ContingenteSubordinadoCliente ?? 0);

        #endregion
    }
}
