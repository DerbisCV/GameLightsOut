using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelInmuebles
	{
		#region Constructors
		public ModelInmuebles() 
		{
			CreateBase();
		}
        public ModelInmuebles(int rowsMaxToTake)
        {
            CreateBase();
            Filter.RowsMaxToTake = rowsMaxToTake;
        }
        public ModelInmuebles(int? idCartera, int rowsMaxToTake)
        {
            CreateBase();
            Filter.IdCartera = idCartera;
            Filter.RowsMaxToTake = rowsMaxToTake;
        }
        public ModelInmuebles(int? idCartera, bool realEstate, TipoIndicadorQa? indicador, int rowsMaxToTake)
        {
            CreateBase();
            RealEstate = realEstate;
            Filter.TipoIndicadorQaSelected = indicador;
            Filter.IdCartera = idCartera;
            Filter.RowsMaxToTake = rowsMaxToTake;
        }
        public ModelInmuebles(ModelFilterBase filter)
        {
			CreateBase();
            Filter = filter;
        }

		private void CreateBase()
		{
            RealEstate = false;
            Filter = new ModelFilterBase();
            LstInmuebles = new List<Hip_Inmueble>();
		}
        #endregion

        #region Properties

        public bool RealEstate { get; set; }
        public ModelFilterBase Filter { get; set; }
        public List<Hip_Inmueble> LstInmuebles { get; set; }
        public List<Inmueble> LstInmueble { get; set; }
        public List<Asset> LstAsset { get; set; }

        #endregion
    }
}
