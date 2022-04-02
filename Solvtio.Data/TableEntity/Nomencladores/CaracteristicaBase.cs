using System;
using Solvtio.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Solvtio.Models
{
    [Table("CaracteristicaBase")]
    public class CaracteristicaBase : INombre
    {
        #region Constructors

        public CaracteristicaBase()
        {
            CreateBase();
        }
        public CaracteristicaBase(string name, string grupo, string codigoReferencia = null)
        {
            CreateBase();

            int orden = codigoReferencia.ToIntegerOrDefault(0);
            Nombre = name;
            Grupo = grupo;
            Codigo = codigoReferencia;
            Orden = orden;
        }
        public CaracteristicaBase(string name, string grupo, string codigoReferencia, int orden)
        {
            CreateBase();

            Nombre = name;
            Grupo = grupo;
            Codigo = codigoReferencia;
            Orden = orden;
        }
        public CaracteristicaBase(string grupo, int orden, string name)
        {
            CreateBase();

            Nombre = name;
            Grupo = grupo;
            Codigo = orden.ToString();
            Orden = orden;
        }

        private void CreateBase()
        {
            FechaAlta = DateTime.Now;
            Activo = true;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Grupo { get; set; }
        public string Codigo { get; set; }
        public int Orden { get; set; }

        public bool Activo { get; set; }
        public DateTime FechaAlta { get; set; }

        #endregion

        #region Properties virtual ICollection

        public virtual ICollection<Hip_TipoInmueble> HipTipoInmuebleSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion
    }
}
