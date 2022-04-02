using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelExpedientesOrdinarios
    {
		#region Constructors
		public ModelExpedientesOrdinarios() 
		{
			CreateBase();
		}
		public ModelExpedientesOrdinarios(ModelFilterBase filter)
        {
			CreateBase();
            Filter = filter;
        }

		private void CreateBase()
		{
			Filter = new ModelFilterBase();
			LstExpedientes = new List<Expediente>();
		}
		#endregion

		#region Properties
		public ModelFilterBase Filter { get; set; }
        public List<Expediente> LstExpedientes { get; set; }
		#endregion
	}
}
