using Solvtio.Models.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("UsuarioRole")]
    public class UsuarioRole
    {
        #region Constructors

        public UsuarioRole() { }
        public UsuarioRole(int idRoleType)
        {
            RoleType = (RoleType)idRoleType;
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuarioRole { get; set; }

        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        public RoleType RoleType { get; set; }

        #endregion

        #region Properties Readonly

        public int RoleTypeInt => (int)RoleType;

        #endregion

        //public int? IdGrupo { get; set; }
        //[ForeignKey("IdGrupo")]
        //public virtual Grupo Grupo { get; set; }
        //public virtual ICollection<Grupo> Grupo { get; set; }
        //public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
