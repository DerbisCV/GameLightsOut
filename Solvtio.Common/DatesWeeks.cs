using System;
using System.Collections.Generic;
using System.Linq;

namespace Solvtio.Common
{
    public static class DatesWeeks
    {
        public static DateTime GetDateIni(int anio, int mes, int semana)
        {
            if (semana == 1) return new DateTime(anio, mes, 1);

            int week = 1;
            var fechaInicio = new DateTime(anio, mes, 1);
            var fecha = new DateTime(anio, mes, 2);

            for (int i = 0; i < 31; i++)
            {
                if (week == semana)
                    return fecha;

                if (fecha.DayOfWeek == DayOfWeek.Sunday) week++;
                fecha = fechaInicio.AddDays(i);
            }

            return fecha;
        }

        public static DateTime GetMonday(this DateTime date)
        {
            var fecha = date;
            while (true)
            {
                if (fecha.DayOfWeek == DayOfWeek.Monday) return fecha;
                fecha = fecha.AddDays(-1);
            }
        }

        public static DateTime GetDateEnd(int anio, int mes, int semana)
        {
            var fecha = GetDateIni(anio, mes, semana + 1);
            return fecha.AddDays(-1);
        }

        public static DateTime GetDateEndOfMonth(int anio, int mes)
        {
            var fechaInicio = GetDateIni(anio, mes, 1);
            return fechaInicio.AddMonths(1).AddMinutes(-1);
            //return fechaInicio.GetDateEndOfMonth();
        }

        public static DateTime GetDateEndOfMonth(this DateTime date)
        {
            return GetDateEndOfMonth(date.Year, date.Month);
        }

        public static DateTime GetDateIniOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        public static DateTime GetEndOfDay(this DateTime value)
        {
            var result = value.Date.AddHours(23).AddMinutes(59);
            return result;
        }

        public static bool IsDateInMonth(this DateTime? date, int year, int month)
        {
            if (!date.HasValue) return false;

            return date.Value.Year == year &&
                date.Value.Month == month;
        }

        public static bool IsDateInDay(this DateTime? date, int year, int month, int day)
        {
            return date.IsDateInMonth(year, month) &&
                date.Value.Day == day;
        }

        public static bool IsWeekEnd(this DateTime? date)
        {
            if (!date.HasValue) return false;

            return date.Value.IsWeekEnd();
        }
        public static bool IsWeekEnd(this DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        }

        public static DateTime? AddDaysHabiles(this DateTime? date, int countDays)
        {
            return date?.AddDaysHabiles(countDays);
        }
        public static DateTime? AddDaysHabiles(this DateTime? date, int countDays, List<DateTime> lstDiasFestivos)
        {
            return date?.AddDaysHabiles(countDays, lstDiasFestivos);
        }
        public static DateTime AddDaysHabiles(this DateTime date, int countDays, Period periodToExclude = null)
        {
            return date.AddDaysHabiles(countDays, periodToExclude?.GetDaysInPeriod());
        }
        public static DateTime AddDaysHabiles(this DateTime date, int countDays, List<DateTime> lstDiasFestivos)
        {
            var result = date;
            if (countDays > 0)
            {
                while (countDays > 0)
                {
                    result = result.AddDays(1);
                    if (!result.IsWeekEnd() && !result.IsDateBetween(lstDiasFestivos))
                        countDays--;
                }
            }
            else
            {
                while (countDays < 0)
                {
                    result = result.AddDays(-1);
                    if (!result.IsWeekEnd() && !result.IsDateBetween(lstDiasFestivos))
                        countDays++;
                }
            }

            return result;
        }

        public static int GetDaysBetweenDates(this DateTime firstDate, DateTime secondDate)
        {
            return firstDate < secondDate ?
                secondDate.Subtract(firstDate).Days :
                firstDate.Subtract(secondDate).Days;
        }

        public static bool IsDateBetween(this DateTime? date, DateTime? date1, DateTime? date2)
        {
            if (!date.HasValue) return false;
            if (!date1.HasValue && !date2.HasValue) return true;

            return date.Value.IsDateBetween(date1, date2);
        }
        public static bool IsDateBetween(this DateTime date, DateTime? date1, DateTime? date2)
        {
            if (!date1.HasValue && !date2.HasValue) return true;
            var result = true;
            if (date1.HasValue)
                result = date >= date1.Value;
            if (date2.HasValue)
                result = result && date <= date2.Value;

            return result;
        }
        public static bool IsDateBetween(this DateTime date, Period period)
        {
            return period != null && date.IsDateBetween(period.FechaInicio, period.FechaFin);
        }

        public static bool IsDateBetween(this DateTime date, List<DateTime> lstDays)
        {
            if (lstDays.IsEmpty()) return false;

            date = date.Date;
            return lstDays.Any(x => x.Date == date);
        }

        public static string ToShortDateString(this DateTime? date)
        {
            return date?.ToShortDateString() ?? string.Empty;
        }

        public static string ToLongDateString(this DateTime? date, string nullValue = "-")
        {
            return date?.ToLongDateString() ?? nullValue;
        }

    }
}
