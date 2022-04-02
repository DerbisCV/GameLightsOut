using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Solvtio.Common
{
    public static class DcvCommon
    {
        #region IEnumerable<T>
        public static bool IsEmpty<T>(this IEnumerable<T> lstValues)
        {
            return lstValues == null || !lstValues.Any();
        }
        public static bool IsNotEmpty<T>(this IEnumerable<T> lstValues)
        {
            return !lstValues.IsEmpty();
        }
        #endregion

        #region DataTable
        public static bool HasData(this DataTable dt)
        {
            return dt != null && dt.Rows.Count > 0;
        }
        #endregion
    }
}
