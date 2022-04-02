using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelNegociacionListado
	{		
		#region Constructors

		public ModelNegociacionListado()
		{
			CreateBase();
	    }

		public ModelNegociacionListado(ModelFilterBase filter)
        {
			CreateBase();
            Filter = filter;
        }

		private void CreateBase()
		{
			Filter = new ModelFilterBase();
			ExpNegociaciones = new List<STPROC_GetNegociacionGestion_Result>();
            ExpedienteNegociacionSet = new List<ExpedienteNegociacion>();
        }

		#endregion

		#region Properties

		public ModelFilterBase Filter { get; set; }
		public IList<STPROC_GetNegociacionGestion_Result> ExpNegociaciones { get; set; }
        public IList<ExpedienteNegociacion> ExpedienteNegociacionSet { get; set; }

        public Usuario Gestor { get; set; }
        public List<Usuario> LstGestores { get; set; }

        #endregion
    }

    public class ModelNegociacionPendienteListado
	{
		#region Constructors

		public ModelNegociacionPendienteListado()
		{
			CreateBase();
	    }

		public ModelNegociacionPendienteListado(ModelFilterBase filter)
        {
			CreateBase();
            Filter = filter;
        }

		private void CreateBase()
		{
			Filter = new ModelFilterBase();
			ExpNegociaciones = new List<ModelNegociacion>();
		}
		#endregion
		 
		#region Properties

		public ModelFilterBase Filter { get; set; }
		public IList<ModelNegociacion> ExpNegociaciones { get; set; }

		#endregion
    }
}
