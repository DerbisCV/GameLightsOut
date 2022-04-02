using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelSolicitudDocumentalAll
    {
        public ModelSolicitudDocumentalAll()
        {
        }
        public ModelSolicitudDocumentalAll(ModelFilterBase filter)
        {
            Filter = filter;
        }

        public ModelFilterBase Filter { get; set; }
        public List<SolicitudDocumental> LstSolicitudDocumental { get; set; }

    }
}
