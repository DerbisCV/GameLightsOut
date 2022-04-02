using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("Hito")]
    public class Hito : INombre
    {
        #region Constructors

        public Hito()
        {
        }
        public Hito(int idHito, string hito)
        {
            IdHito = idHito;
            Nombre = hito;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdHito { get; set; }

        public string Nombre { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion
    }
}
