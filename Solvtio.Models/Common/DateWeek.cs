using Solvtio.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvtio.Models
{
    public class DateWithWeek
    {
        #region Constructors

        public DateWithWeek() { }
        public DateWithWeek(DateTime date, int noWeek)
        {
            NoWeek = noWeek;
            Date = date;
        }


        #endregion

        #region Properties

        public int NoWeek { get; set; }
        public DateTime Date { get; set; }

        #endregion
    }
}
