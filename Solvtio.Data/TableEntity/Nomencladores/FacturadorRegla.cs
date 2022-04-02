using Solvtio.Models.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("FacturadorRegla")]
    public class FacturadorRegla
    {
        #region Constructors

        public FacturadorRegla()
        {
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFacturadorRegla { get; set; }

        public int IdCliente { get; set; }
        [ForeignKey("IdCliente")]
        public virtual Gnr_Cliente Cliente { get; set; }

        public int? IdClienteOficina { get; set; }
        [ForeignKey("IdClienteOficina")]
        public virtual Gnr_ClienteOficina ClienteOficina { get; set; }

        public TipoExpedienteEnum TipoExpediente { get; set; }
        public string ContratoRef { get; set; }

        #endregion

        #region Properties virtual ICollection

        //public virtual ICollection<Gnr_ClienteOficina> ClienteOficinaSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion
    }
}
