using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ExpedienteJV")]
    public class ExpedienteJV
    {
        #region Constructors

        public ExpedienteJV()
        {
            CreateBase();
        }

        public ExpedienteJV(int idValija)
        {
            CreateBase();
            Expediente = new Expediente(idValija);
            Gnr_Persona = new Gnr_Persona();
        }

        public ExpedienteJV(int idExpediente, int idDeudorPrincipal)
        {
            IdExpediente = idExpediente;
            IdDeudorPrincipal = idDeudorPrincipal;
        }

        private void CreateBase()
        {
            //Gnr_Persona = new Gnr_Persona();
            //Expediente = new Expediente();
        }

        #endregion

        #region Properties

        [Key, ForeignKey("Expediente")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int IdExpediente { get; set; }
        public Expediente Expediente { get; set; }

        public DateTime? FechaResolucionIncidenciaDocumental { get; set; }

        public int? IdExpedienteHip { get; set; }
        //[ForeignKey("IdExpedienteHip")]
        //public virtual Hip_Expediente ExpedienteHipotecario { get; set; }

        [ForeignKey("Gnr_Persona")]
        public int IdDeudorPrincipal { get; set; }
        public Gnr_Persona Gnr_Persona { get; set; }

        public DateTime? FechaEnvioProcurador { get; set; }
        public DateTime? FechaPresentacion { get; set; }
        public DateTime? FechaExpedicion { get; set; }
        public DateTime? FechaRecepcion { get; set; }



        public DateTime? AdmisionFecha { get; set; }
        public DateTime? AdmisionNoAdmitidaFecha { get; set; }
        public bool AdmisionApelacion { get; set; }
        public DateTime? AdmisionApelacionFecha { get; set; }
        public DateTime? AdmisionApelacionResultadoFecha { get; set; }
        public TipoResultadoApelacion? AdmisionApelacionResultado { get; set; }
        public string AdmisionComparecencia { get; set; }

        public DateTime? MandamientoFechaAutoLibrar { get; set; }
        public DateTime? MandamientoFechaLibrado { get; set; }
        public PositivoNegativoType? MandamientoNotificacion { get; set; }
        public PositivoNegativoType? MandamientoAveriguacionDomiciliaria { get; set; }
        public PositivoNegativoType? MandamientoEdictos { get; set; }

        public PositivoNegativoType? CitacionNotificacion { get; set; }
        public PositivoNegativoType? CitacionAveriguacionDomiciliaria { get; set; }
        public PositivoNegativoType? CitacionEdictos { get; set; }
        public bool CitacionTrasladoMinisterioFiscal { get; set; }
        public DateTime? NotificacionFechaVistaJurisdiccionVoluntaria { get; set; }


        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public DateTime? FechaNotificacionDemandaConDiasHabiles { get; set; }

        #endregion
    }
}
