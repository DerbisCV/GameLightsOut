using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvtio.Models
{
    public class ModelCauAll
    {
        public ModelCauAll()
        {
        }
        public ModelCauAll(ModelFilterBase filter)
        {
            Filter = filter;
        }

        public ModelFilterBase Filter { get; set; }
        public List<Tiket> LstTiket { get; set; }

    }
}
