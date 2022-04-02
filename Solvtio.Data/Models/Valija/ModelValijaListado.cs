using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelValijaListado
	{
   
		#region Constructor
		public ModelValijaListado() 
		{
            createBase();
		}

        public ModelValijaListado(ModelFilterBase filter)
        {
            createBase();
            Filter = filter;
        }

        private void createBase()
        {
            Filter = new ModelFilterBase();
            LstValijas = new List<Gnr_Valija>();
        }
		#endregion
		
		#region Properties
		public ModelFilterBase Filter { get; set; }
		public List<Gnr_Valija> LstValijas { get; set; }
		#endregion
	}
}
