using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public partial class Hip_TipoInmueble : IDescripcion
    {
        #region Constructors

        public Hip_TipoInmueble()
        {
            Con_ExpedienteCreditoGarantiaInmuebles = new List<Con_ExpedienteCreditoGarantiaInmuebles>();
            Hip_Inmueble = new List<Hip_Inmueble>();
        }

        #endregion

        #region Properties

        public int IdTipoInmueble { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }

        public int? IdTipologia { get; set; }
        [ForeignKey("IdTipologia")]
        public virtual CaracteristicaBase Tipologia { get; set; }

        public int Id => IdTipoInmueble;

        #endregion

        #region Properties One Many

        public virtual ICollection<Con_ExpedienteCreditoGarantiaInmuebles> Con_ExpedienteCreditoGarantiaInmuebles { get; set; }
        public virtual ICollection<Hip_Inmueble> Hip_Inmueble { get; set; }

        #endregion

        
    }
}
