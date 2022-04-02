using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoOrdinarioCsJuicio")]
    public class ExpedienteEstadoOrdinarioCsJuicio
    {
        #region Constructors

        public ExpedienteEstadoOrdinarioCsJuicio()
        {
        }
        public ExpedienteEstadoOrdinarioCsJuicio(int idExpedienteEstado)
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


        public DateTime? JuicioFecha { get; set; }
        public DateTime? SentenciaFecha { get; set; }
        public int? SentenciaResultadoId { get; set; }
        //public bool Apelacion { get; set; }
        //public DateTime? ApelacionFecha { get; set; }
        //public int? ApelacionPor { get; set; }
        //public int? ApelacionResultadoId { get; set; }

	    #endregion
	}
}
