using System;
using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelDashboardSlaChildDetail
    {
        public ModelDashboardSlaChildDetail() { }
        public ModelDashboardSlaChildDetail(Gnr_ClienteOficina oficina, int total, int yellow, int red)
        {
            Oficina = oficina;            
            CountYellow = yellow;
            CountRed = red;
            CountGreen = total-yellow-red;
        }

        public Gnr_ClienteOficina Oficina { get; set; }
        public int? CountGreen { get; set; }
        public int? CountYellow { get; set; }
        public int? CountRed { get; set; }

        public int CountTotal => CountGreen ?? 0 + CountYellow ?? 0 + CountRed ?? 0;
    }

}
