using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solvtio.Common
{
	public static class Dates
	{
		public static DateTime GetDateTimeOrDefault(this DateTime? origen, DateTime dateDefault)
		{
			return origen ?? dateDefault;
		}

        public static DateTime GetFirstDayOfMonth(this DateTime origen)
        {
            return new DateTime(origen.Year, origen.Month, 1);
        }

        public static DateTime? GetMinDateTime(this DateTime? date1, DateTime? date2)
        {
            return 
                !date2.HasValue ? date1 :
                !date1.HasValue ? date2 :
                date1 > date2 ? date2 :
                date1;
        }
        public static DateTime? GetMinDateTime(this DateTime date1, DateTime? date2)
        {
            return
                !date2.HasValue ? date1 :
                date1 > date2 ? date2 :
                date1;
        }

        public static string GetMesNombre(this int noMes)
		{
			string mesNombre;

			switch (noMes)
			{
				case 1:
					mesNombre = "Enero";
					break;
				case 2:
					mesNombre = "Febrero";
					break;
				case 3:
					mesNombre = "Marzo";
					break;
				case 4:
					mesNombre = "Abril";
					break;
				case 5:
					mesNombre = "Mayo";
					break;
				case 6:
					mesNombre = "Junio";
					break;
				case 7:
					mesNombre = "Julio";
					break;
				case 8:
					mesNombre = "Agosto";
					break;
				case 9:
					mesNombre = "Septiembre";
					break;
				case 10:
					mesNombre = "Octubre";
					break;
				case 11:
					mesNombre = "Noviembre";
					break;
				case 12:
					mesNombre = "Diciembre";
					break;
				default:
					mesNombre = "Indefinido";
					break;
			}

			return mesNombre;
		}

		public static IList<int> GetListAnios(int cantAnios = 10)
		{
			var result = new List<int>();

			var anioInicial = DateTime.Now.Year - (cantAnios / 2);
			for (var i = 0; i < cantAnios; i++)
			{
				result.Add(anioInicial + i);
			}

			return result;
		}

        public static DateTime? ToDateTimeOrDefault(this string strDateTime)
        {
            if (string.IsNullOrWhiteSpace(strDateTime)) return null;

            DateTime result = DateTime.MinValue;
            if (DateTime.TryParse(strDateTime, out result)) return result;            

            return null;
        }

		public static int GetTotalDays(this DateTime? date1)
        {
			return GetTotalDays(date1, DateTime.Now);
		}

		public static int GetTotalDays(this DateTime? date1, DateTime? date2)
		{
			if (!date1.HasValue || !date2.HasValue) return 0;

			return Math.Abs((int)(date2.Value - date1.Value).TotalDays);
		}


		//public static IList<DateTime> GetDates(int noWeek = 1)
		//{
		//    DateTime.Now.We
		//    var result = new List<int>();

		//    var anioInicial = DateTime.Now.Year - (cantAnios / 2);
		//    for (var i = 0; i < cantAnios; i++)
		//    {
		//        result.Add(anioInicial + i);
		//    }

		//    return result;
		//}
	}

}
