using System;

namespace Solvtio.Models
{
    public interface IExpedienteEstadoSubastaOld
    {
        bool? SubastaElectronicaPuja { get; set; }
        decimal? SubastaElectronicaImportePuja { get; set; }
        DateTime? SubastaElectronicaFechaFinMejoraPuja { get; set; }



    }
}
