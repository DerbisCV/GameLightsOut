using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvtio.Models.HitoTiempoMedio
{
    public class ModelHitoTiempoMedioDetail
    {
        public ModelHitoTiempoMedioDetail(DateTime? expInicio, DateTime? fechaRealHito, TipoHitoProcesalTiempoMedio tipoHitoProcesalTiempoMedio, int diasTotalesHastaFin, bool usarTiempo2 = false)
        {
            UsarTiempo2 = usarTiempo2;
            FechaRealHito = expInicio > fechaRealHito ? expInicio : fechaRealHito;
            TipoHitoProcesalTiempoMedio = tipoHitoProcesalTiempoMedio;
            DiasTotalesExpedienteHastaFin = diasTotalesHastaFin;
        }

        public bool UsarTiempo2 { get; set; }
        public DateTime? FechaRealHito { get; set; }
        public TipoHitoProcesalTiempoMedio TipoHitoProcesalTiempoMedio { get; set; }
        public int DiasTotalesExpedienteHastaFin { get; set; }

        public int DiasHastaFin => DiasTotalesExpedienteHastaFin - (UsarTiempo2 ? TipoHitoProcesalTiempoMedio.Tiempo2 : TipoHitoProcesalTiempoMedio.Tiempo1);

        public DateTime? FechaFinPrevista => FechaRealHito.HasValue ? FechaRealHito.Value.AddDays(DiasHastaFin) : (DateTime?)null;
    }
}
