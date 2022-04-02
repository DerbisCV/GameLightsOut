using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Solvtio.Models
{
    [Table("UsuarioAreasDominio")]
    public class UsuarioAreasDominio
    {
        #region Constructors

        public UsuarioAreasDominio() { }

        #endregion

        #region Properties

        [Key]
        public int IdUsuarioAreasDominio { get; set; }

        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        public string Area { get; set; }
        public string Descripcion { get; set; }

        #endregion

    }
}