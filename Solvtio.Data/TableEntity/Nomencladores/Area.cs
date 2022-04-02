using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("Area")]
    public class Area : INombre
    {
        #region Constructors

        public Area()
        {
            CreateBase();
        }
        public Area(string name)
        {
            Nombre = name;
            Usuario = "";
        }

        private void CreateBase()
        {
            FechaAlta = DateTime.Now;
            Activo = true;
        }


        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdArea { get; set; }

        public string Nombre { get; set; }

        public string Usuario { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaAlta { get; set; }

        #endregion

        #region Properties virtual ICollection

        public virtual ICollection<Gnr_Abogado> AbogadoSet { get; set; }
        public virtual ICollection<Gnr_TipoEstado> TipoEstadoSet { get; set; }
        public virtual ICollection<ExpedienteVencimiento> ExpedienteVencimientoSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion
    }
}
