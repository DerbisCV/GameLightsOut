using Solvtio.Models.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ClienteTipoExpedienteConfiguracion")]
    public partial class ClienteTipoExpedienteConfiguracion
    {
        #region Constructors

        public ClienteTipoExpedienteConfiguracion() { }
        public ClienteTipoExpedienteConfiguracion(int idCliente) : this()
        {
            IdCliente = idCliente;
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdClienteTipoExpedienteConfiguracion { get; set; }

        public int IdCliente { get; set; }
        [ForeignKey("IdCliente")]
        public virtual Gnr_Cliente Cliente { get; set; }

        public TipoExpedienteEnum TipoExpediente { get; set; }

        public int? IdResponsableCliente { get; set; }
        [ForeignKey("IdResponsableCliente")]
        public virtual Gnr_Abogado ResponsableCliente { get; set; }

        public int? IdResponsableClienteCuenta { get; set; }
        [ForeignKey("IdResponsableClienteCuenta")]
        public virtual Gnr_Abogado ResponsableClienteCuenta { get; set; }

        public int? IdAplicativoCliente { get; set; }
        [ForeignKey("IdAplicativoCliente")]
        public virtual CaracteristicaBase AplicativoCliente { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        #endregion

        #region Methods

        internal void Refresh(ClienteTipoExpedienteConfiguracion modelBase)
        {
            IdCliente = modelBase.IdCliente;
            TipoExpediente = modelBase.TipoExpediente;
            IdResponsableCliente = modelBase.IdResponsableCliente;
            IdResponsableClienteCuenta = modelBase.IdResponsableClienteCuenta;
            IdAplicativoCliente = modelBase.IdAplicativoCliente;
        }

        #endregion
    }
}
