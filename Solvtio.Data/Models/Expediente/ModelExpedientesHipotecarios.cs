using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelExpedientesHipotecarios
	{
		#region Constructors
		public ModelExpedientesHipotecarios() 
		{
			CreateBase();
		}
		public ModelExpedientesHipotecarios(ModelFilterBase filter)
        {
			CreateBase();
            Filter = filter;
        }

		private void CreateBase()
		{
			Filter = new ModelFilterBase();
			LstExpedientes = new List<stProc_GetExpedientesHipotecarios_Result>();
		}
		#endregion

		#region Properties

		public ModelFilterBase Filter { get; set; }
        public List<stProc_GetExpedientesHipotecarios_Result> LstExpedientes { get; set; }
        public List<Hip_ExpedienteEstadoAdjudicacion> HipExpedienteEstadoAdjudicacionSet { get; set; }
	    public IList<Expediente> ExpedienteSet { get; set; }

        #endregion
    }
}
