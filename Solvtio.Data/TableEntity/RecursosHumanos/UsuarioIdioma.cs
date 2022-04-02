using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Solvtio.Models
{
    [Table("UsuarioIdioma")]
    public class UsuarioIdioma
    {
        #region Constructors

        public UsuarioIdioma() { }

        #endregion

        #region Properties

        [Key]
        public int IdUsuarioIdioma { get; set; }

        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        public string Idioma { get; set; }
        public string Nivel { get; set; }
        public string Certificacion { get; set; }

        #endregion

    }
}