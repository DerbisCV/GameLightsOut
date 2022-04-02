using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("UsuarioExperiencia")]
    public class UsuarioExperiencia
    {
        #region Constructors

        public UsuarioExperiencia() { }
        public UsuarioExperiencia(bool esInterna)
        {
            Interna = esInterna;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuarioExperiencia { get; set; }

        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        public string Puesto { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }       
        public string Motivo { get; set; }
        public bool Interna { get; set; }
        public string Empresa { get; set; }

        #endregion
        
        #region Properties ReadOnly

        public int TotalAnios => FechaInicio.HasValue && FechaFin.HasValue ? (FechaFin.Value - FechaInicio.Value).Days/364 : 0;

        #endregion


    }
}
