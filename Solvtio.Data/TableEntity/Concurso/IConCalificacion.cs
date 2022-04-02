using System;

namespace Solvtio.Models
{
    public interface IConCalificacion
    {
        DateTime? CalificacionFechaApertura { get; set; }
        DateTime? CalificacionFechaPersonacion { get; set; }
        DateTime? CalificacionFechaVista { get; set; }
        DateTime? CalificacionFechaSentencia { get; set; }

        int? CalificacionACId { get; set; }
        int? CalificacionFiscalId { get; set; }
        int? CalificacionDefinitivaId { get; set; }

        bool CalificacionPersonacion { get; set; }

        void RefreshClasificacion(IConCalificacion modelBase);

    }
}