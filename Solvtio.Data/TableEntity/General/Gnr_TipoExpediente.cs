using Solvtio.Common;
using Solvtio.Models.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("Gnr_TipoExpediente")]
    public partial class Gnr_TipoExpediente : IDescripcion
    {
        #region Constructors

        public Gnr_TipoExpediente()
        {
            Expedientes = new List<Expediente>();
            Gnr_ClienteOficina = new List<Gnr_ClienteOficina>();
            Gnr_TipoDeudor = new List<Gnr_TipoDeudor>();
            Gnr_TipoEstado = new List<Gnr_TipoEstado>();
            Gnr_TipoExpedienteDocumento = new List<Gnr_TipoExpedienteDocumento>();
            Gnr_Valija = new List<Gnr_Valija>();
            TipoExpedienteAccions = new List<TipoExpedienteAccion>();
            TipoVistas = new List<TipoVista>();
        }

        public Gnr_TipoExpediente(TipoExpedienteEnum tipoExpediente)
        {
            IdTipoExpediente = (int)tipoExpediente;
            Abreviado = tipoExpediente.ToString().GetLeft(4);
            Descripcion = tipoExpediente.GetDescription();
            Activo = true;
        }

        #endregion

        #region Properties

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //[Required]
        public int IdTipoExpediente { get; set; }

        public string Abreviado { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }

        #endregion

        #region Properties Virtual

        public virtual ICollection<Expediente> Expedientes { get; set; }
        public virtual ICollection<Gnr_ClienteOficina> Gnr_ClienteOficina { get; set; }
        public virtual ICollection<Gnr_TipoDeudor> Gnr_TipoDeudor { get; set; }
        public virtual ICollection<Gnr_TipoEstado> Gnr_TipoEstado { get; set; }
        public virtual ICollection<Gnr_TipoExpedienteDocumento> Gnr_TipoExpedienteDocumento { get; set; }
        public virtual ICollection<Gnr_Valija> Gnr_Valija { get; set; }
        public virtual ICollection<TipoExpedienteAccion> TipoExpedienteAccions { get; set; }
        public virtual ICollection<TipoVista> TipoVistas { get; set; }

        #endregion
    }
}
