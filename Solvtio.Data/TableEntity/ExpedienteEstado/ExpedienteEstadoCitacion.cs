using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoCitacion")]
    public class ExpedienteEstadoCitacion
    {
        #region Constructors

        public ExpedienteEstadoCitacion() { }
        public ExpedienteEstadoCitacion(int idExpedienteEstado)
        {
            IdExpedienteEstado = idExpedienteEstado;
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int IdExpedienteEstado { get; set; }
        [ForeignKey("IdExpedienteEstado")]
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public DateTime Fecha { get; set; }
        public bool Positivo { get; set; }
        public string CitadoNombre { get; set; }
        public int? CitadoCategoria { get; set; }

        #endregion

        #region Properties ReadOnly

        public string CitadoCategoriaName =>
            !CitadoCategoria.HasValue ? "" : 
            CitadoCategoria == 1 ? "Perito" : 
            CitadoCategoria == 2 ? "Testigo" : 
            CitadoCategoria == 3 ? "Apoderado" : 
            "¿?";

        #endregion
    }
}
