using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoOrdinarioCsAllanamientoParcial")]
    public class ExpedienteEstadoOrdinarioCsAllanamientoParcial
    {
        #region Constructors

        public ExpedienteEstadoOrdinarioCsAllanamientoParcial()
        {
        }
        public ExpedienteEstadoOrdinarioCsAllanamientoParcial(int idExpedienteEstado)
        {
            IdExpedienteEstado = idExpedienteEstado;
        }

        #endregion

        #region Properties

        [Key]
        [ForeignKey("ExpedienteEstado")]
        public int IdExpedienteEstado { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }
        public int IdExpediente { get; set; }

        public DateTime? FechaSolicitudConsignacionBancaria { get; set; }
        public DateTime? FechaRecepcionConsignacionBancaria { get; set; }
        public string JuzgadoCuentaCorriente { get; set; }

        public DateTime? FechaContestacionDemanda { get; set; }
        public DateTime? FechaRecalculoCuantiaPeticion { get; set; }
        public DateTime? FechaRecalculoCuantiaRecepcion { get; set; }
        public DateTime? FechaPericialPeticion { get; set; }
        public DateTime? FechaPericialRecepcion { get; set; }

        public bool Apelacion { get; set; }
        public DateTime? ApelacionFecha { get; set; }
        public int? ApelacionResultadoId { get; set; }
        public int? ApelacionPorId { get; set; }

        public bool? PeticionVistaDemandado { get; set; }
        public bool? PeticionVistaDemandante { get; set; }
        public bool? ResolucionVistaJuzgado { get; set; }

        #endregion

        #region Properties Readonly

        #endregion

    }
}
