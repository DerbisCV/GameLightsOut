using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("HitoFacturacion")]
    public class HitoFacturacion : INombre
    {
        #region Constructors

        public HitoFacturacion()
        {
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdHitoFacturacion { get; set; }

        public string Nombre { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties virtual ICollection

        public virtual ICollection<ExpedienteFactura> ExpedienteFacturaSet { get; set; }

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion
    }
}
