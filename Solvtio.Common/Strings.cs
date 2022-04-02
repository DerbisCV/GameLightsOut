using System.Text;

namespace Solvtio.Common
{
    public static partial class Strings
    {
        public static string ToFormatHhMm(this int totalMinutos)
        {
            var minutos = 0;
            var horas = Math.DivRem(totalMinutos, 60, out minutos);
            return $"{horas.ToString().PadLeft(2, '0')}:{minutos.ToString().PadLeft(2, '0')}";
        }

        public static string GetRigthFrom(this string origen, string subStringToFind)
        {
            var result = string.Empty;

            var pos = origen.IndexOf(subStringToFind, System.StringComparison.Ordinal);
            if (pos < 0) return result;
            pos = pos + subStringToFind.Length;

            result = origen.Substring(pos, origen.Length - pos);

            return result;
        }

        public static string GetLeftFrom(this string origen, string subStringToFind)
        {
            var result = string.Empty;

            var pos = origen.IndexOf(subStringToFind, System.StringComparison.Ordinal);
            if (pos < 0) return origen;
            //pos = pos + subStringToFind.Length;

            result = origen.Substring(0, origen.Length - pos);

            return result;
        }

        public static string GetLeft(this string origen, int count = 30)
        {
            if (string.IsNullOrWhiteSpace(origen) || origen.Length <= count) return origen;

            return count < 5 ?
                origen.Substring(0, count) :
                origen.Substring(0, count - 3) + "...";
        }

        public static decimal GetDecimalOrDefault(this string origen, decimal decimalToDefault)
        {
            var result = decimalToDefault;

            decimal.TryParse(origen, out result);

            return result;
        }

        public static DateTime? GetDateOrDefault(this string origen)
        {
            DateTime result = DateTime.MinValue;

            if (DateTime.TryParse(origen, out result))
                return result;

            return null;
        }

        public static DateTime GetDateOr(this string origen, DateTime dataDefault)
        {
            var result = origen.GetDateOrDefault();
            return result ?? dataDefault;
        }

        public static bool IsNullOrWhiteSpace(this string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }

        public static string ToFormatRtf(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return string.Empty;
            return text;
            //   var richTextBox = new RichTextBox {Text = text };
            //var rtfFormattedString = richTextBox.Rtf
            //.Replace("{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft Sans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17 ", "")
            //.Replace("{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft Sans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17", "")
            //.Replace("\\par\r\n}\r\n", "")
            //       ;

            //return rtfFormattedString;
        }

        public static string AddParagraphRtf(this string textBase, string textToAdd)
        {
            return textBase + textToAdd.RtfCrearParrafo();
        }

        public static string RtfCrearParrafo(this string text)
        {
            return "{\\pard " + text + "\\par}";

            //             \s3\f1\sb200\cf1
            //  Una linea en estilo 3
            //\par}
            //            {\pard \s1\b\f1\sb200 //         Otra linea en estilo 1 //       \par}

        }

        public static string ToFormatRtf(this StringBuilder sb)
        {
            return sb.ToString();
            //return sb.ToString().ToFormatRtf();

            //if (string.IsNullOrWhiteSpace(sb.ToString()))
            //var richTextBox = new RichTextBox { Text = sb.ToString() };
            //var rtfFormattedString = richTextBox.Rtf
            //    .Replace("{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft Sans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17 ", "")
            //    .Replace("{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft Sans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17", "")
            //    .Replace("\\par\r\n}\r\n", "");

            //return rtfFormattedString;
        }

        public static byte[] GetBytes(this string text)
        {
            return Encoding.UTF8.GetBytes(text);

            //byte[] bytes = new byte[text.Length * sizeof(char)];
            //Buffer.BlockCopy(text.ToCharArray(), 0, bytes, 0, bytes.Length);
            //return bytes;
        }

        public static string GetString(this byte[] bytes)
        {
            return Encoding.UTF8.GetString(bytes);

            //var chars = new char[bytes.Length / sizeof(char)];
            //Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            //return new string(chars);
        }

        #region GenerarSqlCmd

        public static string GenerarSqlCmd(this string cmdBase, string param1, int? param2, string param3, int? param4, bool param5)
        {
            var sql = string.Format("{0} {1}, {2}, {3}, {4}, {5}",
                cmdBase,
                GetParamStringOrNull(param1),
                param2.HasValue ? param2.ToString() : "NULL",
                GetParamStringOrNull(param3),
                param4.HasValue ? param4.ToString() : "NULL",
                param5 ? "1" : "0");

            return sql;
        }



        public static string GenerarSqlCmd(this string cmdBase, string param1, string param2, string param3, int? param4, int? param5)
        {
            var sql = string.Format("{0} {1}, {2}, {3}, {4}, {5}",
                cmdBase,
                GetParamStringOrNull(param1),
                GetParamStringOrNull(param2),
                GetParamStringOrNull(param3),
                param4.HasValue ? param4.ToString() : "NULL",
                param5.HasValue ? param5.ToString() : "NULL");

            return sql;
        }

        public static string GenerarSqlCmd(this string cmdBase, int? param1, int? param2, int? param3, int? param4, int? param5)
        {
            var sql = string.Format("{0} {1}, {2}, {3}, {4}, {5}",
                cmdBase,
                param1.HasValue ? param1.ToString() : "NULL",
                param2.HasValue ? param2.ToString() : "NULL",
                param3.HasValue ? param3.ToString() : "NULL",
                param4.HasValue ? param4.ToString() : "NULL",
                param5.HasValue ? param5.ToString() : "NULL");

            return sql;
        }

        public static string GenerarSqlCmd(this string cmdBase, int? param1, int? param2)
        {
            var sql = string.Format("{0} {1}, {2}",
                cmdBase,
                param1.HasValue ? param1.ToString() : "NULL",
                param2.HasValue ? param2.ToString() : "NULL");

            return sql;
        }

        public static string GenerarSqlCmd(this string cmdBase, int? param1, int? param2, string param3)
        {
            var sql = string.Format("{0} {1}, {2}, {3}",
                cmdBase,
                param1.HasValue ? param1.ToString() : "NULL",
                param2.HasValue ? param2.ToString() : "NULL",
                GetParamStringOrNull(param3));

            return sql;
        }

        public static string GenerarSqlCmd(this string cmdBase, DateTime? param1, DateTime? param2)
        {
            var sql = string.Format("{0} {1}, {2}",
                cmdBase,
                param1.HasValue ? string.Format("'{0}'", param1) : "NULL",
                param2.HasValue ? string.Format("'{0}'", param2) : "NULL");

            return sql;
        }

        private static string GetParamStringOrNull(string paramValue)
        {
            if (string.IsNullOrWhiteSpace(paramValue)) return "NULL";

            return string.Format("'{0}'", paramValue);
        }
        #endregion

        #region Path & FileName

        public static string GetExtensionQba(this string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName)) return string.Empty;
            var extension = Path.GetExtension(fullName);

            return extension;
        }

        #endregion
    }
}
