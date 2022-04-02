using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Solvtio.Models
{
    [Table("UsuarioEvaluacion")]
    public class UsuarioEvaluacion
    {
        #region Constructors

        public UsuarioEvaluacion() { }

        #endregion

        #region Properties

        [Key]
        public int IdUsuarioEvaluacion { get; set; }

        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        public string TipoEvaluacion { get; set; }
        public DateTime? Fecha { get; set; }
        public string Calificacion { get; set; }

        #endregion

    }
}