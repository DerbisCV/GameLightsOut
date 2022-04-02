using Solvtio.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Solvtio.Models
{
    [Table("TipoAreaNotificacion")]
    public partial class TipoAreaNotificacion : INombre
    {
        #region Constructors

        public TipoAreaNotificacion() { }
        public TipoAreaNotificacion(string nombre)
        {
            Nombre = nombre;
            Activo = true;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoAreaNotificacion { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }

        #endregion

        #region Properties One 2 Many

        public virtual ICollection<NotificacionMail> NotificacionMailSet { get; set; }
        public virtual ICollection<Usuario> UsuarioSet { get; set; }

        #endregion


        #region Properties Readonly

        private Usuario _jefeArea;
        public Usuario JefeArea
        {
            get
            {
                if (_jefeArea == null && UsuarioSet.IsNotEmpty())
                    _jefeArea = UsuarioSet.FirstOrDefault(x => x.EsJefeArea);

                return _jefeArea;
            }
        }

        #endregion
    }
}
