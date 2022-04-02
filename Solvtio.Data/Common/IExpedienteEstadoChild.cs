using Solvtio.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace Solvtio.Models
{
    public interface IExpedienteEstadoChildOld
    {
        [Required]
        int IdExpedienteEstado { get; set; }
        ExpedienteEstado ExpedienteEstado { get; set; }
        int IdExpediente { get; set; }
    }

    public interface IEstadoRecepcionBaseOld
    {
        //[Required]
        //int IdExpedienteEstado { get; set; }
        ExpedienteEstado ExpedienteEstado { get; set; }
        DateTime? FechaResolucionIncidenciaDocumental { get; set; }
        //int IdExpediente { get; set; }
    }
}
