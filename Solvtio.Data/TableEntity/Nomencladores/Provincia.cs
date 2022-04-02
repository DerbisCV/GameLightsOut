using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("Provincia")]
    public class Provincia : INombre
    {
        #region Constructors

        public Provincia(){}

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdProvincia { get; set; }

        public string Nombre { get; set; }
        public string NameCorrectToMap { get; set; }

        public int? IdComunidadAutonoma { get; set; }
        [ForeignKey("IdComunidadAutonoma")]
        public virtual ComunidadAutonoma ComunidadAutonoma { get; set; }

        public int IdMunicipioPrincipal { get; set; }

        #endregion

        #region Properties virtual ICollection

        public virtual ICollection<Municipio> MunicipioSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion
    }
}
