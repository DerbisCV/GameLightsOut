using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ExpedienteJurisdiccionVoluntaria")]
    public class ExpedienteJurisdiccionVoluntaria : IExpedienteEstado
    {
        #region Constructors

        public ExpedienteJurisdiccionVoluntaria()
        {
            CreateBase();
        }

        public ExpedienteJurisdiccionVoluntaria(int idExpediente, string usuario)
        {
            CreateBase();
            IdExpediente = idExpediente;
            Usuario = usuario;
        }

        private void CreateBase()
        {
            FechaAlta = DateTime.Now;
            Fecha = DateTime.Today;
            Situacion = TipoSituacionEstado.NoIniciado;
        }

        #endregion

        #region Properties

        [Key, ForeignKey("Expediente")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int IdExpediente { get; set; }
        public Expediente Expediente { get; set; }


        public DateTime Fecha { get; set; }
        public int? IdAbogado { get; set; }
        [ForeignKey("IdAbogado")]
        public virtual Gnr_Abogado Abogado { get; set; }
        public TipoFaseEstado? FaseEstado { get; set; }
        public TipoSituacionEstado? Situacion { get; set; }

        public string Observacion { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAlta { get; set; }

        public DateTime? FechaEnvioProcurador { get; set; }
        public DateTime? FechaPresentacion { get; set; }


        public DateTime? AdmisionFecha { get; set; }
        public string AdmisionNoAuto { get; set; }
        public int? IdJuzgado { get; set; }
        [ForeignKey("IdJuzgado")]
        public virtual Juzgado Juzgado { get; set; }
        public DateTime? AdmisionNoAdmitidaFecha { get; set; }
        public bool AdmisionApelacion { get; set; }
        public DateTime? AdmisionApelacionFecha { get; set; }
        public DateTime? AdmisionApelacionResultadoFecha { get; set; }
        public TipoResultadoApelacion? AdmisionApelacionResultado { get; set; }

        public DateTime? CitacionFechaComparecencia { get; set; }
        public PositivoNegativoType? CitacionNotificacion { get; set; }
        public PositivoNegativoType? CitacionAveriguacionDomiciliaria { get; set; }
        public PositivoNegativoType? CitacionEdictos { get; set; }
        public bool CitacionTrasladoMinisterioFiscal { get; set; }


        public DateTime? MandamientoFechaAutoLibrar { get; set; }
        public DateTime? MandamientoFechaLibrado { get; set; }
        public PositivoNegativoType? MandamientoNotificacion { get; set; }
        public PositivoNegativoType? MandamientoAveriguacionDomiciliaria { get; set; }
        public PositivoNegativoType? MandamientoEdictos { get; set; }
        public DateTime? FechaRecepcionEscritura { get; set; }
        public DateTime? FechaRecepcionMandamiento { get; set; }

        #endregion

        #region Properties ReadOnly
        #endregion

        //public virtual ICollection<ExpedienteAccion> ExpedienteAccions { get; set; }
        //public virtual ICollection<Hip_ExpedienteGarantia> Hip_ExpedienteGarantia { get; set; }
    }
}
