using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Solvtio.Common
{
    public static class ChmEnum
    {

		public static string GetDescription(this Type enumType, int? value)
		{
			if (!value.HasValue) return string.Empty;

			foreach (var enumValue in Enum.GetValues(enumType))
			{
				if (value.Value == (int)enumValue)
					return enumValue.GetDescriptionOf();				
			}

			return string.Empty;
		}

        public static List<string> ToList(this Type enumType)
        {
            var result = new List<string>();
	        foreach (var enumValue in Enum.GetValues(enumType))
		        result.Add(enumValue.ToString());

	        return result;
        }

        public static string GetDescription(this Enum valor)
        {
            if (valor == null) return string.Empty;

            Type type = valor.GetType();
            FieldInfo fieldInfo = type.GetField(valor.ToString());
            if (fieldInfo == null) return "-"; // return $"{type.Name} Indefinido";
            var attribs = fieldInfo.GetCustomAttributes(
                            typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            return (attribs == null || attribs.Length == 0) ?
                    valor.ToString() : attribs[0].Description;
        }

        public static string ToStringSpanish(this bool? valor)
        {
            if (!valor.HasValue) return "-";

            return valor.Value ? "Si" : "No";
        }

        public static string GetDescriptionShort(this Enum valor)
        {
            var result = valor.GetDescription();
            result = result
                .Replace("Toma de Posesión Anticipada", "TPA")
                .Replace("Ordinario", "Ord")
                .Replace("Alquiler - ", "")
                .Replace("Hipotecario - ", "")
                .Replace("Hip - Factura - ", "")
                .Replace("Ordinario - ", "")
                .Replace("Clausula Suelo - ", "")
                .Replace("Cláusula Suelo - ", "")
                .Replace("Ejecutivo - ", "")
                .Replace("Negociación - ", "")
                .Replace("Alarma - ", "");

            return result;
        }

        public static string GetDescriptionOf<T>(this T valor)
        {
            Type type = valor.GetType();
            FieldInfo fieldInfo = type.GetField(valor.ToString());
            var attribs = fieldInfo.GetCustomAttributes(
                            typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            return (attribs == null || attribs.Length == 0) ?
                    valor.ToString() : attribs[0].Description;
        }






        public static KeyValue GetKeyValue<T>(this T valor)
        {
            return new KeyValue(valor.ToString(), valor.GetDescriptionOf());
        }




        public static List<TEnum> ToEnumList<TEnum>(this TEnum enumObj)
            where TEnum : struct, IComparable, IFormattable, IConvertible
        {
            var values = from TEnum e in Enum.GetValues(typeof(TEnum))
                         select e;
            return values.ToList();
        }

        //public static List<KeyValue> ToEnumListNew(this Enum e)
        //{
        //    var result = new List<KeyValue>();

        //    Type tipo = Enum.GetUnderlyingType(e.GetType());
        //    string[] nombres = Enum.GetNames(e.GetType());
        //    Array valores = Enum.GetValues(e.GetType());

        //    for (int i = 0; i < nombres.Length; i++)
        //        result.Add(new KeyValue(nombres[i], Convert.ChangeType(valores.GetValue(i), tipo).ToString()));

        //    return result;
        //}

        public static IList<KeyValue> GetKeyValueList(this Type enumType)
        {
            var arrValores = Enum.GetValues(enumType);
            var lstEnumDescripcion = new List<KeyValue>();

            foreach (var valor in arrValores)
            {
                int valorInt = (int)valor;
                FieldInfo fieldInfo = enumType.GetField(valor.ToString());
                var attribs = fieldInfo
                       .GetCustomAttributes(typeof(DescriptionAttribute), false)
                       as DescriptionAttribute[];

                var descripcion = (attribs == null || attribs.Length == 0) ?
                       valor.ToString() :
                       attribs[0].Description;

                lstEnumDescripcion.Add(
                       new KeyValue(valorInt, valor.GetHashCode().ToString(), descripcion));
            }

            return lstEnumDescripcion;
        }



        public static T ToEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

        public static T ToEnumOrDefault<T>(this string value, T defaultValue)
        {
            if (string.IsNullOrEmpty(value)) return defaultValue;

            //foreach (T item in Enum.GetValues(typeof(T)))
            //{
            //    if (value == item.GetDescription())
            //    { }
            //}

            try
            {
                return (T)Enum.Parse(typeof(T), value, true);
            }
            catch { return defaultValue; }
            //T result;
            //return Enum.TryParse<T>(value, true, out result) ? result : defaultValue;
        }

        public static T ToEnumOrDefaultByDescription<T>(this string valueDescription, T defaultValue)
        {
            if (string.IsNullOrEmpty(valueDescription)) return defaultValue;

            foreach (T item in Enum.GetValues(typeof(T)))
            {
                if (valueDescription == item.GetDescriptionOf())
                {
                    return (T)Enum.Parse(typeof(T), item.ToString(), true);
                }
            }

            return defaultValue;
            //try
            //{
            //    return (T)Enum.Parse(typeof(T), valueDescription, true);
            //}
            //catch { return defaultValue; }
            //T result;
            //return Enum.TryParse<T>(value, true, out result) ? result : defaultValue;
        }
    }
}
