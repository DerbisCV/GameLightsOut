using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public class InmuebleBase : IDescripcion
    {

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdInmueble { get; set; }

        public int IdTipoInmueble { get; set; }
        public bool EsHabitual { get; set; }
        public bool EstaVacia { get; set; }
        public decimal Superficie { get; set; }
        public string Referencia { get; set; }
        public string Descripcion { get; set; }
        public decimal PrestamoCapital { get; set; }

        public decimal? ImporteAdjudicado { get; set; }

        #endregion

        #region Properties Readonly

        public int Id => IdInmueble;

        #endregion


    }
}