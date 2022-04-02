using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ServicioBufete")]
    public class ServicioBufete : INombre
    {
        #region Constructors

        public ServicioBufete()
        {
            CreateBase();
        }

        public ServicioBufete(string name)
        {
            CreateBase();
            Nombre = name;
        }

        private void CreateBase()
        {
            Activo = true;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdServicioBufete { get; set; }

        public string Nombre { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<ClienteServicioBufete> ClienteServicioBufeteSet { get; set; }
        public virtual ICollection<TareaServicioBufete> TareaServicioBufeteSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public DateTime? FechaNotificacionDemandaConDiasHabiles { get; set; }

        #endregion
    }
}
