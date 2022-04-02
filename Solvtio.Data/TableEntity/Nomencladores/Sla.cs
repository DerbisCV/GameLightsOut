using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("Sla")]
    public class Sla : INombre
    {
        #region Constructors

        public Sla()
        {
            CreateBase();
        }
        public Sla(string name)
        {
            CreateBase();
            Nombre = name;
        }

        private void CreateBase()
        {
            FechaAlta = DateTime.Now;
            Activo = true;
        }


        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdSla { get; set; }

        public string Nombre { get; set; }

        public bool Activo { get; set; }
        public DateTime FechaAlta { get; set; }

        #endregion

        #region Properties virtual ICollection

        public virtual ICollection<SlaOficina> SlaOficinaSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion
    }
}
