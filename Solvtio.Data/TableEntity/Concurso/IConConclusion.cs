using System;

namespace Solvtio.Models
{
    public interface IConConclusion
    {
        DateTime? ConclusionFechaSolicitud { get; set; }
        DateTime? ConclusionFechaOposicion { get; set; }
        DateTime? ConclusionFechaRendicionCuentas { get; set; }
        DateTime? ConclusionFechaOposicionRendicionCuentas { get; set; }
        DateTime? ConclusionFechaAuto { get; set; }


        void RefreshConclusion(IConConclusion modelBase);

    }
}