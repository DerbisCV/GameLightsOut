using System;
using System.ComponentModel.DataAnnotations;

namespace Solvtio.Models
{
    public interface IExpedienteEstadoChild
    {
        [Required]
        int IdExpedienteEstado { get; set; }
        ExpedienteEstado ExpedienteEstado { get; set; }
        int IdExpediente { get; set; }
    }

    public interface IEstadoRecepcionBase
    {
        //[Required]
        //int IdExpedienteEstado { get; set; }
        ExpedienteEstado ExpedienteEstado { get; set; }
        DateTime? FechaResolucionIncidenciaDocumental { get; set; }
        //int IdExpediente { get; set; }
    }
}
