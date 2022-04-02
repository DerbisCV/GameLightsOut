using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoOrdinarioCsAutoAdmisionNotificacion")]
    public class ExpedienteEstadoOrdinarioCsAutoAdmisionNotificacion
    {

        #region Constructors

        public ExpedienteEstadoOrdinarioCsAutoAdmisionNotificacion()
        {
        }
        public ExpedienteEstadoOrdinarioCsAutoAdmisionNotificacion(int idExpedienteEstado)
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


        public DateTime? AdmitidaFecha { get; set; }
        public string AdmitidaNoAuto { get; set; }
        public string AdmitidaJuzgado { get; set; }
        public bool Oposicion { get; set; }
        public DateTime? OposicionFecha { get; set; }
        public DateTime? OposicionCelebracionVistaFecha { get; set; }
        public DateTime? OposicionResolucionFecha { get; set; }
        public bool Apelacion { get; set; }
        public int? ApelacionPor { get; set; }
        public DateTime? ApelacionFecha { get; set; }

        #endregion

    }
}
