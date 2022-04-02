using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;
using System.Security.Principal;
using static System.String;

namespace Solvtio.Models
{
    public static class Conversiones
	{
	    public static string GetUserName(this IPrincipal user)
	    {
            return GetUserName(user?.Identity.Name);

                //.Replace("@chabogados.es", "")
                //.Replace("live.com#", "")
                //.Replace("@hotmail.com", "")?? Empty;
	    }
        public static string GetUserName(this string usuarioName)
        {
            return IsNullOrWhiteSpace(usuarioName) ?
               Empty :
               usuarioName
                .Replace("@chabogados.es", "")
                .Replace("live.com#", "")
                .Replace("@hotmail.com", "")
                .Replace("DOMINIO\\", "")
                .Replace("Usr:", "");
        }

        public static string NumeroALetras(this string num)
		{
			string res, dec = "";
			Int64 entero;
			int decimales;
			double nro;

			try
			{
				nro = Convert.ToDouble(num);
			}
			catch
			{
				return "";
			}

			entero = Convert.ToInt64(Math.Truncate(nro));
			decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));

			if (decimales > 0)
			{
				dec = " CON " + decimales.ToString() + "/100";
			}

			res = NumeroALetras(Convert.ToDouble(entero)) + dec;
			return res;
		}

		public static string NumeroALetras(this int num)
		{
			return NumeroALetras(Convert.ToDouble(num));
		}

		public static string NumeroALetras(this decimal? num)
		{
			return NumeroALetras(Convert.ToDouble(num ?? 0));
		}
		public static string NumeroALetras(this decimal num)
		{
			return NumeroALetras(Convert.ToDouble(num));
		}

		public static string NumeroALetrasCompleto(this decimal? num)
		{
			decimal numValue = num ?? 0;

			return numValue.NumeroALetrasCompleto();
		}
		public static string NumeroALetrasCompleto(this decimal numValue)
		{
			return Format("{0} ({1:N2}) €",
				NumeroALetras(Convert.ToDouble(numValue)),
				numValue);
		}

		public static string ToImporteConLetras(this decimal? importe)
		{
			decimal importeValue = importe ?? 0;

			return importeValue.ToImporteConLetras();
		}
		public static string ToImporteConLetras(this decimal importeValue)
		{
			decimal parteEntera = Math.Truncate(importeValue);
			int parteDecimal = Convert.ToInt16(100 * (importeValue - parteEntera));

			string result = Format("{0} EUROS", NumeroALetras(parteEntera));
			if (parteDecimal > 0)
				result += Format(" CON {0} CÉNTIMOS", NumeroALetras(parteDecimal));

			result += Format(" ({0:N2} €)", importeValue);
            if (result.Contains("UNO CÉNTIMOS") || result.Contains("UNO EUROS"))
            {
                result = result.Replace("UNO", "UN");
            }

                
			return result;
		}

		public static string ToImporte(this decimal? num, string symbolCurrency = " €")
		{
			decimal numValue = num ?? 0;
			var result = numValue.ToImporte(symbolCurrency);
			return result;
		}
		public static string ToImporte(this decimal numValue, string symbolCurrency = " €")
		{
			return Format("{0:N2}{1}", numValue, symbolCurrency);
		}
        public static string ToPorCientoV2(this decimal numValue)
        {
            return Format("{0:N2}%€", numValue);
        }
		public static string ToNumber(this decimal? num)
		{
			decimal numValue = num ?? 0;
			return numValue.ToNumber();
		}
		public static string ToNumber(this decimal numValue)
		{
			return Format("{0:N2}", numValue);
		}

        public static string ToPorciento(this decimal? num) {
            return Format("{0:N} %", num);
        }

        public static string ToPorciento(this decimal numValue)
        {
            return Format("{0:N} %", numValue);
        }

        public static decimal ToRedondeo(this decimal numValue)
        {
                        int deuda = (int)( numValue);
                        if (deuda > 100)
                        {
                            string strDeuda = deuda.ToString();
                            strDeuda = strDeuda.Substring(0, strDeuda.Length - 2) + "00";
                            Int32.TryParse(strDeuda, out deuda);
                        }

                        return deuda;        
        }
        public static decimal ToRedondeo(this decimal? num)
        {
            int deuda = (int)(num);
            if (deuda > 100)
            {
                string strDeuda = deuda.ToString();
                strDeuda = strDeuda.Substring(0, strDeuda.Length - 2) + "00";
                Int32.TryParse(strDeuda, out deuda);
            }

            return deuda; 
        }
        

		public static string NumeroALetras(this double valueOriginal)
		{
			string Num2Text = "";
			double value = Math.Truncate(valueOriginal);
			int valueRest = Convert.ToInt16(100 * (valueOriginal - value));

			if (value == 0) Num2Text = "CERO";
			else if (value == 1) Num2Text = "UNO";
			else if (value == 2) Num2Text = "DOS";
			else if (value == 3) Num2Text = "TRES";
			else if (value == 4) Num2Text = "CUATRO";
			else if (value == 5) Num2Text = "CINCO";
			else if (value == 6) Num2Text = "SEIS";
			else if (value == 7) Num2Text = "SIETE";
			else if (value == 8) Num2Text = "OCHO";
			else if (value == 9) Num2Text = "NUEVE";
			else if (value == 10) Num2Text = "DIEZ";
			else if (value == 11) Num2Text = "ONCE";
			else if (value == 12) Num2Text = "DOCE";
			else if (value == 13) Num2Text = "TRECE";
			else if (value == 14) Num2Text = "CATORCE";
			else if (value == 15) Num2Text = "QUINCE";
			else if (value < 20) Num2Text = "DIECI" + NumeroALetras(value - 10);
			else if (value == 20) Num2Text = "VEINTE";
			else if (value < 30) Num2Text = "VEINTI" + NumeroALetras(value - 20);
			else if (value == 30) Num2Text = "TREINTA";
			else if (value == 40) Num2Text = "CUARENTA";
			else if (value == 50) Num2Text = "CINCUENTA";
			else if (value == 60) Num2Text = "SESENTA";
			else if (value == 70) Num2Text = "SETENTA";
			else if (value == 80) Num2Text = "OCHENTA";
			else if (value == 90) Num2Text = "NOVENTA";

			else if (value < 100) Num2Text = NumeroALetras(Math.Truncate(value / 10) * 10) + " Y " + NumeroALetras(value % 10);
			else if (value == 100) Num2Text = "CIEN";
			else if (value < 200) Num2Text = "CIENTO " + NumeroALetras(value - 100);
			else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = NumeroALetras(Math.Truncate(value / 100)) + "CIENTOS";

			else if (value == 500) Num2Text = "QUINIENTOS";
			else if (value == 700) Num2Text = "SETECIENTOS";
			else if (value == 900) Num2Text = "NOVECIENTOS";
			else if (value < 1000) Num2Text = NumeroALetras(Math.Truncate(value / 100) * 100) + " " + NumeroALetras(value % 100);
			else if (value == 1000) Num2Text = "MIL";
			else if (value < 2000) Num2Text = "MIL " + NumeroALetras(value % 1000);
			
            else if (value < 1000000)
			{
				Num2Text = NumeroALetras(Math.Truncate(value / 1000)) + " MIL";
                if (Num2Text.Contains("UNO MIL"))
                {
                    Num2Text = Num2Text.Replace("UNO", "UN");
                }
             
				if ((value % 1000) > 0) Num2Text = Num2Text + " " + NumeroALetras(value % 1000);
			}

			else if (value == 1000000) Num2Text = "UN MILLÓN";
			else if (value < 2000000) Num2Text = "UN MILLÓN " + NumeroALetras(value % 1000000);
			else if (value < 1000000000000)
			{
				Num2Text = NumeroALetras(Math.Truncate(value / 1000000)) + " MILLONES ";
				if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + NumeroALetras(value - Math.Truncate(value / 1000000) * 1000000);
			}
			else if (value == 1000000000000) Num2Text = "UN BILLON";
			else if (value < 2000000000000) Num2Text = "UN BILLON " + NumeroALetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);
			else
			{
				Num2Text = NumeroALetras(Math.Truncate(value / 1000000000000)) + " BILLONES";
				if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + NumeroALetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);
			}

			if (valueRest > 0)
				Num2Text += Format(" CON {0}", NumeroALetras(valueRest));

			return Num2Text;
		}



        public static List<int> GetListOfNumber(this int numberIni, int numberEnd)
        {
            var result = new List<int>();
            if (numberEnd < numberIni) return result;

            var noActual = numberIni;
            do
            {
                result.Add(noActual);
                noActual++;
            } while (numberEnd >= noActual);

            return result;
        }


        public static string GetMonthName(this int month)
		{
			string monthName = Empty;
			switch (month)
			{
				case 1:
					monthName = "Enero";
					break;
				case 2:
					monthName = "Febrero";
					break;
				case 3:
					monthName = "Marzo";
					break;
				case 4:
					monthName = "Abril";
					break;
				case 5:
					monthName = "Mayo";
					break;
				case 6:
					monthName = "Junio";
					break;
				case 7:
					monthName = "Julio";
					break;
				case 8:
					monthName = "Agosto";
					break;
				case 9:
					monthName = "Septiembre";
					break;
				case 10:
					monthName = "Octubre";
					break;
				case 11:
					monthName = "Noviembre";
					break;
				case 12:
					monthName = "Diciembre";
					break;
				default:
					break;
			}
			return monthName;
		}

		//public static string FechaALetras(this DateTime? fecha)
		//{
		//	//		var fechaEscrituraLetra =  + " de " +  + " de " + ;
		//	if (fecha.HasValue)
		//		return Format("{0} de {1} de {2}", 
		//			fecha.Value.Day,
		//			Conversiones.GetMonthName(fecha.Value.Month),
		//			fecha.Value.Year); //fecha.Value.ToString("dd de MMMM de yyyy");

		//	return "fecha indefinida";
		//}

        public static string FechaALetras(this DateTime? fecha)
        {
            return fecha.HasValue ? fecha.Value.FechaALetras() : "fecha indefinida";
        }
        public static string FechaALetras(this DateTime fecha)
		{
			return Format("{0} de {1} de {2}",
					fecha.Day,
					Conversiones.GetMonthName(fecha.Month),
					fecha.Year); //fecha.Value.ToString("dd de MMMM de yyyy");
		}
	}

	public static class Util
	{
		#region EnsureDirectory

		public static void EnsureDirectory(string strFileDirectory)
		{
			System.IO.DirectoryInfo oDirInfo = new System.IO.DirectoryInfo(strFileDirectory);
			EnsureDirectory(oDirInfo);
		}

		public static void EnsureDirectory(System.IO.DirectoryInfo oDirInfo)
		{
			if (oDirInfo.Parent != null)
				EnsureDirectory(oDirInfo.Parent);
			if (!oDirInfo.Exists)
			{
				oDirInfo.Create();
			}
		}
		#endregion

		public static string GetErrorMessage(this Exception exception)
		{
			var result = new StringBuilder();
			var exType = exception.GetType();

			if (exType == typeof(System.Data.Entity.Infrastructure.DbUpdateException))
			{
				var ex = (DbUpdateException)exception;

				result.AppendLine(exception.Message);
				if (exception.InnerException != null && exception.InnerException.InnerException != null)
					result.AppendLine(exception.InnerException.InnerException.Message);
			}
			else if (exType == typeof(System.Data.Entity.Validation.DbEntityValidationException))
			{
				var ex = (DbEntityValidationException)exception;
				int x = 0;
				foreach (DbEntityValidationResult errorEf in ex.EntityValidationErrors)
				{
					x++;
					int y = 0;
					foreach (DbValidationError item in errorEf.ValidationErrors)
					{
						y++;
						result.AppendLine(Format("{0}.{1}: {2}", x, y, item.ErrorMessage));
					}

				}
			}
		    if (exType == typeof(InvalidOperationException))
		    {
                var ex = (InvalidOperationException)exception;
                result.AppendLine(ex.Message);
            }
            if (exType == typeof(System.Data.DataException))
            {
                var ex = (System.Data.DataException)exception;
                result.AppendLine(ex.Message);
            }
            else
		        result.AppendLine(exception.Message);

		    return result.ToString()
				.Replace("\r\n", "    ")
				.Replace("\\", "-");
		}

		public static string GetErrorMessage(this DbEntityValidationException ex) 
		{
			var result = new StringBuilder();

			int x = 0;
			foreach (DbEntityValidationResult errorEf in ex.EntityValidationErrors)
			{
				var entidad = errorEf.Entry.Entity.ToString();
				x++;
				int y = 0;
				foreach (DbValidationError item in errorEf.ValidationErrors)
				{
					y++;
					result.AppendLine(Format("{0}.{1}: {2} ({3})", x, y, item.ErrorMessage, entidad));
				}
				
			}

			return result.ToString();
		}

		public static List<int> ListEstadosFinalizados = new List<int>() { 8, 39,  45, 79 };
	}
}

