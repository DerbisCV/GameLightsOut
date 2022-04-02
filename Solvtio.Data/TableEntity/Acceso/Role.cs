using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public partial class Role
    {
        #region Constructors

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRole { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Usuario> UsuarioSet { get; set; }
        public virtual ICollection<RolePage> RolePageSet { get; set; }

        #endregion

        #region Properties Readonly

        public bool IsGestorInmueble => IdRole == (int)RoleType.GestorInmueble;

        #endregion
    }
}
