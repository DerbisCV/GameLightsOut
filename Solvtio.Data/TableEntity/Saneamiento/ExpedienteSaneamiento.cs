using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ExpedienteSaneamiento")]
    public sealed class ExpedienteSaneamiento
    {
        #region Constructors

        public ExpedienteSaneamiento()
        {
            CreateBase();
        }

        public ExpedienteSaneamiento(int idValija)
        {
            CreateBase();
            Expediente = new Expediente(idValija);
            Gnr_Persona = new Gnr_Persona();
        }

        public ExpedienteSaneamiento(int idExpediente, int idDeudorPrincipal)
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
   

        [ForeignKey("Gnr_Persona")]
        public int IdDeudorPrincipal { get; set; }
        public Gnr_Persona Gnr_Persona { get; set; }
                

        //public int? IdExpedienteMn { get; set; }
        //public int? IdExpedienteEjc { get; set; }

        public bool ProcesalesPresentacion { get; set; }
        public bool ProcesalesAdmision { get; set; }
        public bool ProcesalesCertificadoCarga { get; set; }
        public bool ProcesalesRequerimientoPago { get; set; }
        public bool ProcesalesOposicion { get; set; }
        public bool ProcesalesApelacion { get; set; }
        public bool ProcesalesSubasta { get; set; }

        public bool AnomalasArchivadoSinFinalizar { get; set; }
        public bool AnomalasNulidad { get; set; }
        public bool AnomalasSobreseido { get; set; }
        public bool AnomalasNoLocalizado { get; set; }

        public bool SaneamientoTituloCesionRemate { get; set; }
        public bool SaneamientoTituloSolicitudAdjudicacion { get; set; }
        public bool SaneamientoTituloAdjudicacion { get; set; }
        public bool SaneamientoTituloTestimonio { get; set; }
        public bool SaneamientoTituloCertificacionNegativa { get; set; }
        public bool SaneamientoTituloInscripcion { get; set; }

        public bool SaneamientoPosesoriaSolicitudPosesion { get; set; }
        public bool SaneamientoPosesoriaPosesionPositiva { get; set; }
        public bool SaneamientoPosesoriaLanzamientoPostivo { get; set; }


        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public DateTime? FechaNotificacionDemandaConDiasHabiles { get; set; }

        #endregion

    }
}
