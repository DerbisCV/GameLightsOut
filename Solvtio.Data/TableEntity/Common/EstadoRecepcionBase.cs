using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{

    public class EstadoRecepcionBase : IEstadoRecepcionBase
    {

        public int IdExpedienteEstado { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }
        public DateTime? FechaResolucionIncidenciaDocumental { get; set; }
    }


    public class EstadoBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("ExpedienteEstado")]
        public int IdExpedienteEstado { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }
    }
}
