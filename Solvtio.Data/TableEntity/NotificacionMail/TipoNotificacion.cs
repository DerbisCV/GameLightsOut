using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public partial class TipoNotificacion : INombre
    {
        #region Constructors

        public TipoNotificacion() { }
        public TipoNotificacion(string clase, string subClase, string nombre)
        {
            Nombre = nombre;
            Clase = clase;
            SubClase = subClase;
            Activo = true;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoNotificacion { get; set; }
        public string Nombre { get; set; }
        public string Clase { get; set; }
        public string SubClase { get; set; }
        public bool Activo { get; set; }

        #endregion

        #region Properties Readonly

        public string NombreCompleto
        {
            get
            {
                return string.Format("{0}{1} {2}",
                    Clase,
                    string.IsNullOrWhiteSpace(SubClase) ? "" : "-" + SubClase,
                    Nombre
                    );
            }
        }

        #endregion
    }
}
