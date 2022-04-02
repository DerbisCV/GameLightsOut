using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("Holiday")]
    public class Holiday
    {
        #region Constructors

        public Holiday(){}
        public Holiday(DateTime date)
        {
            Fecha = date;
        }

        #endregion

        #region Properties

        [Key]
        public DateTime Fecha { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion
    }
}
