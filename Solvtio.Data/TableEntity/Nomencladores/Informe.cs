using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("Informe")]
    public class Informe : INombre
    {
        #region Constructors

        public Informe()
        {
            FechaAlta = DateTime.Now;
            Activo = true;
        }
        public Informe(string name) : this()
        {
            Nombre = name;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdInforme { get; set; }

        public string Nombre { get; set; }
        public string Descripción { get; set; }
        public string Categoria { get; set; }
        public string Url { get; set; }
        public int Orden { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaAlta { get; set; }

        internal void RefreshBy(Informe model)
        {
            Nombre = model.Nombre;
            Descripción = model.Descripción;
            Categoria = model.Categoria;
            Url = model.Url;
            Activo = model.Activo;
        }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion
    }
}
