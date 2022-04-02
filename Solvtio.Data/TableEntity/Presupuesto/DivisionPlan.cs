using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("DivisionPlan")]
    public class DivisionPlan
    {
        #region Constructors

        public DivisionPlan()
        {
            CreateBase();
        }
        //public DivisionPlan(string name)
        //{
        //    Nombre = name;
        //    Usuario = "";
        //}

        private void CreateBase()
        {
            FechaAlta = DateTime.Now;
        }


        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDivisionPlan { get; set; }

        public int IdDivision { get; set; }
        [ForeignKey("IdDivision")]
        public virtual Division Division { get; set; }

        public int Anio { get; set; }
        public int EntradaExpediente { get; set; }
        public decimal Facturacion { get; set; }

        public string Usuario { get; set; }
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

