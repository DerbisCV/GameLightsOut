using System;
using System.Data;
using System.Globalization;

namespace Solvtio.Common
{
	public static class ConvertTo
	{
		public static int ToIntegerOrDefault(this int? value, int defaultValue = 0)
		{
		    return value ?? defaultValue;
		}

		public static int ToIntegerOrDefault(this object value, int defaultValue = 0)
		{
			if (value == null) return defaultValue;

			int result;
			return int.TryParse(value.ToString(), out result) ? result : defaultValue;
		}

		public static int? ToIntegerOrNullable(this object value)
		{
			int result;
			if (int.TryParse(value.ToString(), out result)) return result;

			return null;
		}


		#region ToDecimalOrDefault
		public static decimal ToDecimalOrDefault(this decimal? value, decimal defaultValue = 0)
        {
            return value.HasValue ? value.Value : defaultValue;
        }

        public static decimal ConvertToDecimalOrDefault(this object value, decimal defaultValue = 0)
        {
            decimal result = defaultValue;
            Decimal.TryParse(value.ToString(), out result);

            return result;
        }

		public static decimal? ToDecimalOrNullable(this object value)
		{
			var strValue = value.ToString()
				.Replace("€", "")
				.Replace("%", "")
				.Replace(" ", "");

            decimal result;
            if (decimal.TryParse(strValue, out result)) return result;

			return null;
		}

		#endregion

		#region ConvertToString

		public static string ConvertToStringCurrency(this object value, decimal defaultValue, string currencySymbol, int cantidadDecimales = 2)
		{
		    return value == null ? string.Empty : value.ConvertToDecimalOrDefault(defaultValue).ConvertToStringCurrency(currencySymbol, cantidadDecimales);
		}
        public static string ConvertToStringCurrency(this decimal? value, string currencySymbol, int cantidadDecimales, string showIfempty = "")
        {
            if (!value.HasValue) return showIfempty;
            return ConvertToStringCurrency(value.Value, currencySymbol, cantidadDecimales, showIfempty);
        }
        public static string ConvertToStringCurrency(this decimal value, string currencySymbol, int cantidadDecimales, string showIfempty = "")
        {
            if (value == 0) return showIfempty;

            //var result = value.ToString("#,#", CultureInfo.InvariantCulture) + currencySymbol; 
            var result = value.ToString($"N{cantidadDecimales}", new CultureInfo("es-ES")) + currencySymbol;

            return result;
        }

        public static string ConvertToStringCurrencyInMil(this decimal value, string currencySymbol, int cantidadDecimales, string showIfempty = "")
        {
            value = value / 1000;
            return value.ConvertToStringCurrency(currencySymbol, cantidadDecimales, showIfempty);
        }
        #endregion

		#region Methods New ING

		public static string ConvertToEncode(this string value)
		{
			if (value == null) return null;

			return value
				.Replace(".", "-");
		}

		public static string ConvertToUncode(this string value)
		{
			if (value == null) return null;

			return value
				.Replace("-", ".");
		}
		#endregion

		#region From DataRow

		public static string ConvertToStringOrDefault(this DataRow dr, string columnName, string defaultValue = "")
		{
			try
			{
				return dr[columnName].ToString();
			}
			catch { return defaultValue; }
		}

		public static string ConvertToStringOrDefault(this DataRow dr, int columnIndex, string defaultValue = "")
		{
			try
			{
				return dr[columnIndex].ToString();
			}
			catch { return defaultValue; }
		}

		public static decimal ConvertToDecimalOrDefault(this DataRow dr, string columnName, decimal defaultValue = 0)
		{
			try
			{
				return dr[columnName].ConvertToDecimalOrDefault(defaultValue);
			}
			catch { return defaultValue; }
		}

		public static decimal? ConvertToDecimalOrNullable(this DataRow dr, string columnName)
		{
			try
			{
				decimal result;
				if (Decimal.TryParse(dr[columnName].ToString(), out result))
					return result;

				return (decimal?)(null);
			}
			catch { return (decimal?)(null); }
		}

		public static int? ToIntegerOrNullable(this DataRow dr, string columnName)
		{
			try
			{
				return Convert.ToInt32(dr[columnName].ToString());
			}
			catch { return (int?)(null); }
		}

		public static DateTime? ConvertToDateTimeOrNullable(this DataRow dr, string columnName)
		{
			try
			{
				DateTime result;
				if (DateTime.TryParse(dr[columnName].ToString(), out result))
					return result;

				return null;
			}
			catch { return null; }
		}

		#endregion

	}
}
