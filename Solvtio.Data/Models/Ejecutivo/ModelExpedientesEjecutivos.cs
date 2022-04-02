using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelExpedientesEjecutivos
    {
        public ModelExpedientesEjecutivos()
        {
        }
        public ModelExpedientesEjecutivos(ModelFilterBase filter)
        {
            Filter = filter;
        }

        public ModelFilterBase Filter { get; set; }
		public List<stProc_GetExpedientesEjecutivo_Result> LstExpedientes { get; set; }
        public List<Ejc_Expediente> LstExpEjecutivos { get; set; }
    }
}
