using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoJurisdiccionVoluntaria")]
    public class ExpedienteEstadoJurisdiccionVoluntaria : IEstadoRecepcionBase //IExpedienteEstadoChild
    {
        #region Constructors

        public ExpedienteEstadoJurisdiccionVoluntaria()
        {
            CreateBase();
        }

        public ExpedienteEstadoJurisdiccionVoluntaria(int idExpediente)
        {
            CreateBase();
            IdExpediente = idExpediente;
        }

        private void CreateBase()
        {
            //FechaAlta = DateTime.Now;
            //Fecha = DateTime.Today;
            //Situacion = TipoSituacionEstado.NoIniciado;
        }

        #endregion

        #region Properties

        [Key, ForeignKey("ExpedienteEstado")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int IdExpedienteEstado { get; set; }
        public ExpedienteEstado ExpedienteEstado { get; set; }

        public int IdExpediente { get; set; }

        public DateTime? FechaResolucionIncidenciaDocumental { get; set; }

        public DateTime? FechaEnvioProcurador { get; set; }
        public DateTime? FechaPresentacion { get; set; }

        public DateTime? AdmisionFecha { get; set; }
        //public string AdmisionNoAuto { get; set; }
        //public int? IdJuzgado { get; set; }
        //[ForeignKey("IdJuzgado")]
        //public virtual Juzgado Juzgado { get; set; }
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
        public DateTime? FechaRecepcionEscritura { get; set; }
        public DateTime? FechaRecepcionMandamiento { get; set; }

        //public DateTime? FechaEnvioProcurador { get; set; }
        //public DateTime? FechaPresentacion { get; set; }
        public DateTime? FechaExpedicion { get; set; }
        public DateTime? FechaRecepcion { get; set; }

        #endregion

        #region Properties ReadOnly
        #endregion

        //public virtual ICollection<ExpedienteAccion> ExpedienteAccions { get; set; }
        //public virtual ICollection<Hip_ExpedienteGarantia> Hip_ExpedienteGarantia { get; set; }

    }
}
