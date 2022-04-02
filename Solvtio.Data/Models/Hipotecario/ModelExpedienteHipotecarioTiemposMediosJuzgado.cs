using Solvtio.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvtio.Models
{
    public class ModelExpedienteHipotecarioTiemposMediosJuzgado
    {
        #region Constructors

        public ModelExpedienteHipotecarioTiemposMediosJuzgado()
        {
        }
        public ModelExpedienteHipotecarioTiemposMediosJuzgado(int idJuzgado, List<ModelExpedienteHipotecarioTiemposMedios> lstTiemposMedios)
        {
            LstTiemposMediosJuzgado = lstTiemposMedios
                .Where(x => x.Juzgado != null && x.Juzgado.IdJuzgado == idJuzgado)
                .ToList();
            if (LstTiemposMediosJuzgado.IsEmpty()) return;

            Juzgado = LstTiemposMediosJuzgado[0].Juzgado;
            var lstTiemposMediosJuzgadoConCelebracionSubasta = LstTiemposMediosJuzgado
                .Where(x => x.FechaSubastaCelebracion.HasValue && x.FechaDemandaAdmision.HasValue).ToList();
            if (lstTiemposMediosJuzgadoConCelebracionSubasta.IsNotEmpty())
                PromedioDiasDemandaAdmitidaHastaCelebracionSubasta = lstTiemposMediosJuzgadoConCelebracionSubasta.Average(x => x.FechaDemandaAdmision.Value.GetDaysBetweenDates(x.FechaSubastaCelebracion.Value));

            var lstTiemposMediosJuzgadoConAdjudicacion = lstTiemposMediosJuzgadoConCelebracionSubasta
               .Where(x => x.FechaSubastaCelebracion.HasValue && x.FechaAdjudicacionDecreto.HasValue).ToList();
            if (lstTiemposMediosJuzgadoConAdjudicacion.IsNotEmpty())
                PromedioDiasSubastaCelebracionHastaAdjudicacionDecreto = lstTiemposMediosJuzgadoConAdjudicacion.Average(x => x.FechaSubastaCelebracion.Value.GetDaysBetweenDates(x.FechaAdjudicacionDecreto.Value));

        }

        #endregion

        #region Properties

        public Juzgado Juzgado { get; set; }
        public List<ModelExpedienteHipotecarioTiemposMedios> LstTiemposMediosJuzgado { get; set; }

        public double? PromedioDiasDemandaAdmitidaHastaCelebracionSubasta { get; set; }
        public double? PromedioDiasSubastaCelebracionHastaAdjudicacionDecreto { get; set; }





        #endregion

        #region Properties ReadOnly

        //public int? DiasHastaDemandaPresentacion => GetCountDias(FechaRecepcion, FechaDemandaPresentacion);


        #endregion

        #region Methods

        //public int? GetCountDias(DateTime? fecha1, DateTime? fecha2)
        //{
        //    if (!fecha1.HasValue || !fecha2.HasValue || fecha1.Value > fecha2.Value) return null;
        //    fecha1 = fecha1.Value.Date;
        //    fecha2 = fecha2.Value.Date;

        //    return fecha1.Value == fecha2.Value ? 0 :
        //        fecha1.Value.GetDaysBetweenDates(fecha2.Value);
        //}

        #endregion
    }

}
