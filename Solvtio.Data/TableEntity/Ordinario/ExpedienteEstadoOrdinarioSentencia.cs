using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoOrdinarioSentencia")]
    public class ExpedienteEstadoOrdinarioSentencia : IExpedienteEstadoChild
    {
        #region Constructors

        public ExpedienteEstadoOrdinarioSentencia()
        {
            CreateBase();
        }

        public ExpedienteEstadoOrdinarioSentencia(int idExpediente)
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

        public DateTime? SentenciaFecha { get; set; }
        public DateTime? SentenciaFirmezaFecha { get; set; }
        public int? SentenciaResultado { get; set; }

        public DateTime? ApelacionFecha { get; set; }
        public int? ApelacionPor { get; set; }
        public int? ApelacionResultado { get; set; }

        public DateTime? InfraccionProcesalFecha { get; set; }
        public int? InfraccionProcesalPor { get; set; }
        public int? InfraccionProcesalResultado { get; set; }

        public DateTime? CasacionFecha { get; set; }
        public int? CasacionPor { get; set; }
        public int? CasacionResultado { get; set; }

        #endregion

        #region Properties ReadOnly
        #endregion

    }
}
