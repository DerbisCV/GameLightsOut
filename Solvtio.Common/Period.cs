using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Solvtio.Common
{
    public class Period
    {
        #region Constructors 

        public Period() { }
        public Period(DateTime inicio, DateTime fin)
        {
            FechaInicio = inicio;
            FechaFin = fin;
        }
        public Period(DateTime dateRef, PeriodType periodType)
        {
            switch (periodType)
            {
                case PeriodType.Mensual:
                    FechaInicio = dateRef.GetDateIniOfMonth();
                    FechaFin = dateRef.GetDateEndOfMonth();
                    return;
                case PeriodType.Trimestral:
                    FechaInicio = new DateTime(dateRef.Year, dateRef.Month, 1).GetDateIniOfMonth();
                    FechaFin = FechaInicio.Value.AddDays(70).GetDateEndOfMonth();
                    return;
                case PeriodType.Anual:
                    FechaInicio = dateRef.GetDateIniOfMonth();
                    FechaFin = dateRef.AddDays(364).GetDateEndOfMonth();
                    return;
                default:
                    throw new ArgumentOutOfRangeException(nameof(periodType), periodType, null);
            }
        }

        public Period(int year, PeriodType periodType)
        {
            switch (periodType)
            {
                //case PeriodType.Mensual:
                //    FechaInicio = dateRef.GetDateIniOfMonth();
                //    FechaFin = dateRef.GetDateEndOfMonth();
                //    return;
                //case PeriodType.Trimestral:
                //    FechaInicio = new DateTime(dateRef.Year, dateRef.Month, 1).GetDateIniOfMonth();
                //    FechaFin = FechaInicio.Value.AddDays(70).GetDateEndOfMonth();
                //    return;
                case PeriodType.Anual:
                    FechaInicio = new DateTime(year, 1, 1).GetDateIniOfMonth();
                    FechaFin = new DateTime(year, 12, 31).GetDateEndOfMonth();
                    return;
                default:
                    throw new ArgumentOutOfRangeException(nameof(periodType), periodType, null);
            }
        }

        #endregion

        #region Properties

        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{FechaInicio.ToShortDateString()} - {FechaFin.ToShortDateString()}";
        }

        public bool Contain(DateTime fechaToAnalize)
        {
            return fechaToAnalize.IsDateBetween(this);
        }

        public List<DateTime> GetDaysInPeriod()
        {
            if (!FechaInicio.HasValue || !FechaFin.HasValue || FechaFin < FechaInicio) return new List<DateTime>();
            if (FechaFin == FechaInicio) return new List<DateTime> { FechaInicio.Value.Date };

            var result = new List<DateTime>();
            var fechaRef = FechaInicio.Value.Date;
            while (FechaFin >= fechaRef)
            {
                result.Add(fechaRef);
                fechaRef = fechaRef.AddDays(1);
            }
            return result;
        }

        #endregion

    }

}
