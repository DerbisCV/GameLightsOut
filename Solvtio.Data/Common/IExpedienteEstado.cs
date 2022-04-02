using System;
using System.ComponentModel.DataAnnotations;
using Solvtio.Models;

namespace Solvtio.Models
{
    public interface IExpedienteEstadoOld
    {
        [Required]
        int IdExpediente { get; set; }
        Expediente Expediente { get; set; }

        DateTime Fecha { get; set; }
        int? IdAbogado { get; set; }
        Gnr_Abogado Abogado { get; set; }
        TipoFaseEstado? FaseEstado { get; set; }

        string Observacion { get; set; }
        string Usuario { get; set; }
        DateTime FechaAlta { get; set; }
    }

}
