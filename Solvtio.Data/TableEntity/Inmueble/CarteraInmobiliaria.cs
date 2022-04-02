using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("CarteraInmobiliaria")]
    public class CarteraInmobiliaria : INombre
    {
        #region Constructors

        public CarteraInmobiliaria(){ CreateBase(); }
        public CarteraInmobiliaria(string nombre, string usuario)
        {
            CreateBase();
            Nombre = nombre;
            Usuario = usuario;
        }

        private void CreateBase()
        {
            Fecha = DateTime.Today;
            FechaAlta = DateTime.Now;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCartera { get; set; }


        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaAlta { get; set; }

        #endregion

        #region Properties virtual ICollection

        public virtual ICollection<CarteraInmueble> CarteraInmuebleSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{Fecha.ToShortDateString()}: {Nombre}.";
        }

        #endregion

    }
}
