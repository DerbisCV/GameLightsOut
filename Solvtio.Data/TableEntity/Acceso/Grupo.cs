using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("Grupo")]
    public class Grupo : INombre
    {
        #region Constructors

        public Grupo()
        {
            CreateBase();
        }
        private void CreateBase()
        {
            FechaAlta = DateTime.Now;
            Activo = true;
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdGrupo { get; set; }
        //public int? IdGrupoUsuario { get; set; }
        //public virtual GrupoUsuario GrupoUsuario { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool Activo { get; set; }

        #endregion

        #region Properties ICollection

        public virtual ICollection<GrupoUsuario> GrupoUsuarioSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion
    }
}
