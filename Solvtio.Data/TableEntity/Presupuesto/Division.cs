using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("Division")]
    public class Division : INombre
    {
        #region Constructors

        public Division()
        {
            CreateBase();
        }
        public Division(string name)
        {
            CreateBase();
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
        public int IdDivision { get; set; }

        public string Nombre { get; set; }

        public string Usuario { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaAlta { get; set; }

        #endregion

        #region Properties virtual ICollection

        public virtual ICollection<DivisionPlan> DivisionPlanSet { get; set; }
        public virtual ICollection<DivisionReal> DivisionRealSet { get; set; }
        public virtual ICollection<FichaNegocio> FichaNegocioSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion
    }
}

