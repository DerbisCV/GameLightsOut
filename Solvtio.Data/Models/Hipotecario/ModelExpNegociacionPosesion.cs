using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelExpNegociacionPosesion
	{
		#region Constructors
		public ModelExpNegociacionPosesion() 
		{
			CreateBase();
		}
		public ModelExpNegociacionPosesion(ModelFilterBase filter)
        {
			CreateBase();
            Filter = filter;
        }

		private void CreateBase()
		{
			Filter = new ModelFilterBase();
			LstEstadoNegociacionPosesion = new List<Hip_ExpedienteEstadoNegociacionPosesion>();
		}
		#endregion

		#region Properties
		public ModelFilterBase Filter { get; set; }
		public List<Hip_ExpedienteEstadoNegociacionPosesion> LstEstadoNegociacionPosesion { get; set; }
		#endregion
	}
}
