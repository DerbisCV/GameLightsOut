using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{

    public class EstadoRecepcionBase : IEstadoRecepcionBase
    {

        //[ForeignKey("ExpedienteEstado")]
        [Key]
        public int IdExpedienteEstado { get; set; }
        [ForeignKey("IdExpedienteEstado")]
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }
        
        public DateTime? FechaResolucionIncidenciaDocumental { get; set; }
    }


    public class EstadoBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int IdExpedienteEstado { get; set; }
          [ForeignKey("IdExpedienteEstado")]      
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }
    }
}
