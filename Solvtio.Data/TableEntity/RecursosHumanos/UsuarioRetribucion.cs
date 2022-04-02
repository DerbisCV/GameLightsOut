using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Solvtio.Models
{
    [Table("UsuarioRetribucion")]
    public class UsuarioRetribucion
    {
        #region Constructors

        public UsuarioRetribucion() { }

        #endregion

        #region Properties

        [Key]
        public int IdUsuarioRetribucion { get; set; }

        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        public decimal Salario { get; set; }
        public decimal Complementos { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }

        #endregion

    }
}