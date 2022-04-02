using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelExpedientesAlquileres
    {
		public ModelExpedientesAlquileres()
		{
		}
        public ModelExpedientesAlquileres(ModelFilterBase filter)
        {
            // TODO: Complete member initialization
            Filter = filter;
        }

        public ModelFilterBase Filter { get; set; }
        //public List<stProc_GetExpedientesAlquiler_Result> LstExpedientes { get; set; }
        public List<Expediente> LstExpediente { get; set; }
        public List<Alq_Expediente> LstExpedienteAlquiler { get; set; }
    }
}
