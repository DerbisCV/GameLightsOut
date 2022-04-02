using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Solvtio.Models
{
    [Table("UsuarioFormacion")]
    public class UsuarioFormacion
    {
        #region Constructors

        public UsuarioFormacion() { }
        public UsuarioFormacion(bool esInterna)
        {
            Interna = esInterna;
        }

        #endregion

        #region Properties

        [Key]
        public int IdUsuarioFormacion { get; set; }

        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        public string Curso { get; set; }
        public string Centro { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Titulo { get; set; }
        public bool Interna { get; set; }

        #endregion

    }
}