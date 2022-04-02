using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ComunidadAutonoma")]
    public class ComunidadAutonoma : INombre
    {
        #region Constructors

        public ComunidadAutonoma(){}
        public ComunidadAutonoma(int id, string name)
        {
            IdComunidadAutonoma = id;
            Nombre = name;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdComunidadAutonoma { get; set; }

        public string Nombre { get; set; }
        public string NameCorrectToMap { get; set; }

        #endregion

        #region Properties virtual ICollection

        public virtual ICollection<Provincia> ProvinciaSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion
    }
}
