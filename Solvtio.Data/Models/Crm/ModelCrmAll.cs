using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelCrmAll
    {
		#region Constructors

		public ModelCrmAll() 
		{
			CreateBase();
		}

		public ModelCrmAll(ModelFilterBase filter)
        {
			CreateBase();
            Filter = filter;
        }

		private void CreateBase()
		{
			Filter = new ModelFilterBase();
		}

        #endregion

        #region Properties 

        public ModelFilterBase Filter { get; set; }

        public List<Tarea> LstTarea { get; set; }
        public List<Gnr_ClienteOficina> LstEmpresa { get; set; }

        #endregion

        #region Properties ReadOnly

        //public bool MostrarOtrosParaEstadoImpulso => Filter.TipoIndicadorQaSelected.HasValue;

        #endregion
    }
}
