using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoOrdinarioCsRecepcion")]
    public class ExpedienteEstadoOrdinarioCsRecepcion
    {
        #region Constructors

        public ExpedienteEstadoOrdinarioCsRecepcion()
        {
        }
        public ExpedienteEstadoOrdinarioCsRecepcion(int idExpedienteEstado)
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

        //public bool ReclamacionPrevia { get; set; }

        //public bool ReclamacionJudicialRDI { get; set; }

        //public bool ContestacionRDI { get; set; }

        public DateTime? FechaSolicitudConsignacionBancaria { get; set; }
        public DateTime? FechaRecepcionConsignacionBancaria { get; set; }
        public string JuzgadoCuentaCorriente { get; set; }

        public DateTime? FechaSolicitudRecalculo { get; set; }
        public DateTime? FechaRecepcionRecalculo { get; set; }
        public DateTime? FechaSolicitudDocumentacionAdicional { get; set; }


        #endregion

        #region Properties ReadOnly

        public bool NoneMilestone => !FechaSolicitudConsignacionBancaria.HasValue && !FechaSolicitudRecalculo.HasValue && !FechaRecepcionRecalculo.HasValue && !FechaRecepcionConsignacionBancaria.HasValue;
        public bool SolicitadaDocumentacion => FechaSolicitudConsignacionBancaria.HasValue && FechaSolicitudRecalculo.HasValue;
        public bool EnviadoEscritoConDocumentacion => SolicitadaDocumentacion && FechaRecepcionRecalculo.HasValue && FechaRecepcionConsignacionBancaria.HasValue;

        #endregion

    }
}
