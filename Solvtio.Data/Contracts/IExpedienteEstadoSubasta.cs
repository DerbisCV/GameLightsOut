using System;

namespace Solvtio.Models
{
    public interface IExpedienteEstadoSubasta
    {
        bool? SubastaElectronicaPuja { get; set; }
        decimal? SubastaElectronicaImportePuja { get; set; }
        DateTime? SubastaElectronicaFechaFinMejoraPuja { get; set; }



    }
}
