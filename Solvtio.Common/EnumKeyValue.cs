using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Solvtio.Common
{
    public static partial class EnumKeyValue
    {
        //public static IList<KeyValue> GetKeyValueList(this Type enumType)
        //{
        //    var arrValores = Enum.GetValues(enumType);
        //    var lstEnumDescripcion = new List<KeyValue>();

        //    foreach (var valor in arrValores)
        //    {
        //        FieldInfo fieldInfo = enumType.GetField(valor.ToString());
        //        var attribs = fieldInfo
        //               .GetCustomAttributes(typeof(DescriptionAttribute), false)
        //               as DescriptionAttribute[];

        //        var descripcion = (attribs == null || attribs.Length == 0) ?
        //               valor.ToString() :
        //               attribs[0].Description;

        //        lstEnumDescripcion.Add(
        //               new KeyValue(valor.GetHashCode().ToString(), descripcion));
        //    }

        //    return lstEnumDescripcion;
        //}
    }	
}
