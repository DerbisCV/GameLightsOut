using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("AreaNegocio")]
    public class AreaNegocio : INombre
    {
        #region Constructors

        public AreaNegocio()
        {
            CreateBase();
        }
        public AreaNegocio(int id, string name)
        {
            CreateBase();

            IdAreaNegocio = id;
            Nombre = name;
            Usuario = "";
        }

        private void CreateBase()
        {
            ObjetivoEntradasAnual = 0;
            FechaAlta = DateTime.Now;
            Activo = true;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdAreaNegocio { get; set; }

        public string Nombre { get; set; }
        public int ObjetivoEntradasAnual { get; set; }


        public string Usuario { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaAlta { get; set; }

        #endregion

        #region Properties virtual ICollection

        public virtual ICollection<ClienteObjetivo> ClienteObjetivoSet { get; set; }

        //public virtual ICollection<Gnr_Abogado> AbogadoSet { get; set; }
        //public virtual ICollection<Gnr_TipoEstado> TipoEstadoSet { get; set; }
        //public virtual ICollection<ExpedienteVencimiento> ExpedienteVencimientoSet { get; set; }

        #endregion

        #region Properties ReadOnly & NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion


        #region Methods

        internal void RefreshBy(AreaNegocio model)
        {
            Nombre = model.Nombre;
            ObjetivoEntradasAnual = model.ObjetivoEntradasAnual;
            Usuario = model.Usuario;
            Activo = model.Activo;
        }

        #endregion
    }
}
