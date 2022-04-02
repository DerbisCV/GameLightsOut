using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("GrupoUsuario")]
    public class GrupoUsuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdGrupoUsuario { get; set; }

        public int? IdGrupo { get; set; }
        [ForeignKey("IdGrupo")]
        public virtual Grupo Grupo { get; set; }
        //public virtual ICollection<Grupo> Grupo { get; set; }

        public int? IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }
        //public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
