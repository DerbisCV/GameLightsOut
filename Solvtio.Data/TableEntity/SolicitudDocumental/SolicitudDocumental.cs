using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("SolicitudDocumental")]
    public partial class SolicitudDocumental
    {
        #region Constructors

        public SolicitudDocumental()
        {
            Fecha = DateTime.Today;
        }
        public SolicitudDocumental(Expediente expediente) : this()
        {
            if (expediente == null) return;

            IdAbogado = expediente.IdAbogado;
            IdCliente = expediente.Gnr_ClienteOficina.IdCliente;
            NoExpediente = expediente.NoExpediente;
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSolicitudDocumental { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Fecha { get; set; }

        public int? IdAbogado { get; set; }
        [ForeignKey("IdAbogado")]
        public virtual Gnr_Abogado Abogado { get; set; }

        public int? IdCliente { get; set; }
        [ForeignKey("IdCliente")]
        public virtual Gnr_Cliente Cliente { get; set; }

        public string NoExpediente { get; set; }
        public string Documento { get; set; }
        public string Registro { get; set; }
        public decimal? Importe { get; set; }
        public decimal? ImporteRepercusion { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        [NotMapped]
        public Expediente Expediente { get; set; }

        [NotMapped]
        public Departamento Departamento { get; set; }

        #endregion

        #region Methods

        internal void Refresh(SolicitudDocumental modelBase)
        {
            Fecha = modelBase.Fecha;
            IdAbogado = modelBase.IdAbogado;
            IdCliente = modelBase.IdCliente;
            NoExpediente = modelBase.NoExpediente;
            Documento = modelBase.Documento;
            Registro = modelBase.Registro;
            Importe = modelBase.Importe;
            ImporteRepercusion = modelBase.ImporteRepercusion;

            //NoPedido = modelBase.NoPedido;
            //ActaAceptacion = modelBase.ActaAceptacion;
            //FechaFacturaEnvio = modelBase.FechaFacturaEnvio;
            //FechaFacturaCobro = modelBase.FechaFacturaCobro;
            //IdTipoNotificacion = modelBase.IdTipoNotificacion;
            //IdTipoProcedimiento = modelBase.IdTipoProcedimiento;
        }

        #endregion
    }
}
