using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("Actuacion")]
    public class Actuacion : ActuacionBase
    {
        #region Constructors

        public Actuacion(){ CreateBase(); }
        public Actuacion(string observaciones, string usuario)
        {
            CreateBase();
            Observaciones = observaciones;
            Usuario = usuario;
        }
        public Actuacion(int idExpediente, string usuario)
        {
            CreateBase();
            IdExpediente = idExpediente;
            Usuario = usuario;
        }

        private void CreateBase()
        {
            Fecha = DateTime.Today;
            TipoActuacion = TipoActuacion.None;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdActuacion { get; set; }
        public TipoActuacion TipoActuacion { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion
    }

}
