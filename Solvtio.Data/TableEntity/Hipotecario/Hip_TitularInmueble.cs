using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public partial class Hip_TitularInmueble
    {
        #region Constructors

        public Hip_TitularInmueble() { }
        public Hip_TitularInmueble(Hip_TitularInmueble titularOrigen)
        {
            IdDeudor = titularOrigen.IdDeudor;
            PropiedadPorciento = titularOrigen.PropiedadPorciento;
            IdTipoPropiedad = titularOrigen.IdTipoPropiedad;
            Observaciones = titularOrigen.Observaciones;
        }

        #endregion

        #region Properties

        public int IdTitularInmueble { get; set; }
        public int IdInmueble { get; set; }
        public virtual Hip_Inmueble Hip_Inmueble { get; set; }
        public int IdDeudor { get; set; }
        public virtual Gnr_Persona Gnr_Persona { get; set; }
        public string Observaciones { get; set; }

        public int? IdTipoPropiedad { get; set; }
        [ForeignKey("IdTipoPropiedad")]
        public virtual CaracteristicaBase TipoPropiedad { get; set; }

        public decimal? PropiedadPorciento { get; set; }

        #endregion

        public void RefresfBy(Hip_TitularInmueble modelBase)
        {
            PropiedadPorciento = modelBase.PropiedadPorciento;
            IdTipoPropiedad = modelBase.IdTipoPropiedad;
            Observaciones = modelBase.Observaciones;
        }

    }
}
