using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteAcuerdo")]
    public class ExpedienteAcuerdo
    {
        #region Constructors

        public ExpedienteAcuerdo() { CreateBase(); }
        public ExpedienteAcuerdo(int idExpediente, string tipoAcuerdo, string usuario)
        {
            CreateBase();
            IdExpediente = idExpediente;
            TipoAcuerdo = tipoAcuerdo;
            Usuario = usuario;
        }

        private void CreateBase()
        {
            FechaPropuesta = DateTime.Today;
            FechaAlta = DateTime.Now;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedienteAcuerdo { get; set; }

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public DateTime FechaPropuesta { get; set; }
        public DateTime? FechaPreacuerdo { get; set; }
        public DateTime? FechaAcuerdo { get; set; }
        public string Acuerdo { get; set; }
        public string TipoAcuerdo { get; set; }
        public bool EnviadoAbogado { get; set; }
        public bool EnviadoCliente { get; set; }
        public bool EnviadoPreacuerdo { get; set; }
        public bool Aceptado { get; set; }
        public int? IdResultado { get; set; }
        [ForeignKey("IdResultado")]
        public virtual CaracteristicaBase Resultado { get; set; }
        public decimal? Importe { get; set; }
        public decimal? ImportePerdidaEstimada { get; set; }
        public decimal? ImporteAhorro { get; set; }
        public decimal? ImporteCostas { get; set; }
        public decimal? PorcientoAcordado { get; set; }
        public decimal? ImporteGastosHipotecarios { get; set; }
        public decimal? ImporteGastosEfectivo { get; set; }
        public decimal? ImporteMaximoAutorizado { get; set; }
        public DateTime? FechaCalculoSolicitud { get; set; }
        public DateTime? FechaCalculoRecibido { get; set; }
        public DateTime? FechaAutorizacionPropuestaSolicitud { get; set; }
        public DateTime? FechaAutorizacionPropuesta { get; set; }
        public string Nota { get; set; }


        public string Usuario { get; set; }
        public DateTime FechaAlta { get; set; }

        #endregion

        #region Properties virtual ICollection

        //public virtual ICollection<NotificacionMailAttachment> NotificacionMailAttachmentSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{FechaPropuesta.ToShortDateString()}: {TipoAcuerdo} | {Acuerdo}";
        }

        public void RefreshBy(ExpedienteAcuerdo model)
        {
            FechaPropuesta = model.FechaPropuesta;
            FechaPreacuerdo = model.FechaPreacuerdo;
            FechaAcuerdo = model.FechaAcuerdo;
            Acuerdo = model.Acuerdo;
            TipoAcuerdo = model.TipoAcuerdo;            
            EnviadoAbogado = model.EnviadoAbogado;
            EnviadoCliente = model.EnviadoCliente;
            EnviadoPreacuerdo = model.EnviadoPreacuerdo;
            Aceptado = model.Aceptado;
            IdResultado = model.IdResultado;
            Importe = model.Importe;
            ImportePerdidaEstimada = model.ImportePerdidaEstimada;
            //ImporteAhorro = (model.Importe ?? 0) - (model.ImportePerdidaEstimada ?? 0);
            ImporteAhorro = (model.ImportePerdidaEstimada ?? 0) - (model.Importe ?? 0);
            ImporteCostas = model.ImporteCostas;
            ImporteGastosHipotecarios = model.ImporteGastosHipotecarios;
            ImporteGastosEfectivo = model.ImporteGastosEfectivo;
            ImporteMaximoAutorizado = model.ImporteMaximoAutorizado;
            FechaCalculoSolicitud = model.FechaCalculoSolicitud;
            FechaCalculoRecibido = model.FechaCalculoRecibido;
            FechaAutorizacionPropuestaSolicitud = model.FechaAutorizacionPropuestaSolicitud;
            FechaAutorizacionPropuesta = model.FechaAutorizacionPropuesta;

            PorcientoAcordado = model.PorcientoAcordado;
            Nota = model.Nota;
        }

        #endregion

    }
}
