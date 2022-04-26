using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ExpedienteEscritura")]
    public class ExpedienteEscritura
    {
        #region Constructors

        public ExpedienteEscritura(){ CreateBase(); }
        public ExpedienteEscritura(int idExpediente)
        {
            CreateBase();
            IdExpediente = idExpediente;
        }
        public ExpedienteEscritura(Expediente expediente)
        {
            CreateBase();
            IdExpediente = expediente.IdExpediente;
            Expediente = expediente;
        }

        private void CreateBase()
        {
            Fecha = DateTime.Today;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedienteEscritura { get; set; }

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }
        

        public DateTime Fecha { get; set; }
        public string NoProtocolo { get; set; }
        public string Notario { get; set; }
        public string Colegio { get; set; }

        //public DateTime? FechaExpedicion { get; set; }
        //public DateTime? FechaRecepcion { get; set; }
        //public DateTime? FechaEnvioProcurador { get; set; }
        //public DateTime? FechaPresentacion { get; set; }



        public DateTime? AdmisionFecha { get; set; }
        public DateTime? AdmisionNoAdmitidaFecha { get; set; }
        public bool AdmisionApelacion { get; set; }
        public DateTime? AdmisionApelacionFecha { get; set; }
        public DateTime? AdmisionApelacionResultadoFecha { get; set; }
        public TipoResultadoApelacion? AdmisionApelacionResultado { get; set; }
        public string AdmisionComparecencia { get; set; }



        public PositivoNegativoType? CitacionNotificacion { get; set; }
        public PositivoNegativoType? CitacionAveriguacionDomiciliaria { get; set; }
        public PositivoNegativoType? CitacionEdictos { get; set; }
        public bool CitacionTrasladoMinisterioFiscal { get; set; }
        public DateTime? NotificacionFechaVistaJurisdiccionVoluntaria { get; set; }

        public DateTime? MandamientoFechaAutoLibrar { get; set; }
        public DateTime? MandamientoFechaLibrado { get; set; }
        public PositivoNegativoType? MandamientoNotificacion { get; set; }
        public PositivoNegativoType? MandamientoAveriguacionDomiciliaria { get; set; }
        public PositivoNegativoType? MandamientoEdictos { get; set; }

        public bool Desistimiento { get; set; }

        public int? IdExpedienteRef { get; set; }
        [ForeignKey("IdExpedienteRef")]
        public Expediente ExpedienteRef { get; set; }

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
    }
}
