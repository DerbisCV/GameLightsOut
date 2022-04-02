using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Solvtio.Models
{
    [Table("UsuarioInformatica")]
    public class UsuarioInformatica
    {
        #region Constructors

        public UsuarioInformatica() { }

        #endregion

        #region Properties

        [Key]
        public int IdUsuarioInformatica { get; set; }

        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        public string PlataformaHerramienta { get; set; }
        public string Nivel { get; set; }

        #endregion

    }
}