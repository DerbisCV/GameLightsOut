using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class TipoVista : INombre
    {
        #region Constructors

        public TipoVista()
        {
            ExpedienteVistas = new List<ExpedienteVista>();
        }

        public TipoVista(int idTipoExp, string grupo, string clasificacion, string nombre)
        {
            IdTipoExpediente = idTipoExp;
            Grupo = grupo;
            Clasificacion = clasificacion;
            Nombre = nombre;
        }

        #endregion

        #region Properties

        public int IdTipoVista { get; set; }
        public string Nombre { get; set; }
        public string Clasificacion { get; set; }
        public int IdTipoExpediente { get; set; }
        public string Grupo { get; set; }
        public virtual ICollection<ExpedienteVista> ExpedienteVistas { get; set; }
        public virtual Gnr_TipoExpediente Gnr_TipoExpediente { get; set; }

        #endregion

    }
}
