using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class ModelComparativaAnual
	{
		#region Constructors
		public ModelComparativaAnual()
		{
			CreateBase();
		}
		public ModelComparativaAnual(int year)
		{
			CreateBase();
            Filter = new ModelFilterBase(TipoExpedienteEnum.Hipotecario) { Anio = year };
		}
		public ModelComparativaAnual(ModelFilterBase filter)
		{
			CreateBase();
            Filter = filter;
		}
		public void CreateBase()
		{
            Filter = new ModelFilterBase();
            LstResumenPorAnio = new List<ResumenPorAnio>();
		}
		#endregion

		#region Properties
		public ModelFilterBase Filter { get; set; }
		public List<ResumenPorAnio> LstResumenPorAnio { get; set; }
		#endregion

		#region Properties ReadOnly

		#endregion

	}
}
