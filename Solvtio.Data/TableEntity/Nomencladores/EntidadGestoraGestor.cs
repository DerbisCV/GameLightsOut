using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("EntidadGestoraGestor")]
    public class EntidadGestoraGestor : INombre
    {
        #region Constructors

        public EntidadGestoraGestor()
        {
            CreateBase();
        }
        public EntidadGestoraGestor(int idEntidadGestora)
        {
            CreateBase();
            IdEntidadGestora = idEntidadGestora;
        }
        public EntidadGestoraGestor(int idEntidadGestora, string gestorNombre)
        {
            CreateBase();
            IdEntidadGestora = idEntidadGestora;
            Nombre = gestorNombre;
        }

        private void CreateBase()
        {
            FechaAlta = DateTime.Now;
            Activo = true;
            Usuario = "";
        }


        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEntidadGestoraGestor { get; set; }

        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Telefono2 { get; set; }
        //public string Cliente { get; set; }
        public string Email { get; set; }

        public int IdEntidadGestora { get; set; }
        [ForeignKey("IdEntidadGestora")]
        public virtual EntidadGestora EntidadGestora { get; set; }

        public string Usuario { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaAlta { get; set; }

        #endregion

        #region Properties virtual ICollection

        //public virtual ICollection<Gnr_Abogado> AbogadoSet { get; set; }
        //public virtual ICollection<Gnr_TipoEstado> TipoEstadoSet { get; set; }
        //public virtual ICollection<ExpedienteVencimiento> ExpedienteVencimientoSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion
    }
}
