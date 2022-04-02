using System;
using System.Collections.Generic;

namespace Solvtio.Models
{
	public class ModelDashboardGestionArea
	{
		#region Constructor

		public ModelDashboardGestionArea()
		{
			CreateBase();		
		}
		public ModelDashboardGestionArea(TipoAreaGestion tipoAreaGestion)
		{
			CreateBase();
			Filter.TipoAreaGestion = tipoAreaGestion;
		}
		public ModelDashboardGestionArea(ModelFilterBase filter)
		{
			CreateBase();
			Filter = filter;
			if (Filter.IdTipoExpediente.HasValue)
				Filter.TipoExpedienteSelected = (TipoExpedienteEnum)Filter.IdTipoExpediente.Value;
		}

		private void CreateBase()
		{
			var fecha = DateTime.Now.AddMonths(-1);
			Filter = new ModelFilterBase {Anio = fecha.Year, Mes = fecha.Month};
			LstIndicadorQa = new List<ModelIndicadorQa>();
			LstIndicadorAlarma = new List<ModelIndicadorQa>();
			LstIndicadorResultados = new List<ModelIndicadorResultado>();
		}

		#endregion

		#region Properties

 		public ModelFilterBase Filter { get; set; }   

		public List<ModelIndicadorQa> LstIndicadorQa { get; set; }
		public List<ModelIndicadorQa> LstIndicadorAlarma { get; set; }	
		public List<ModelIndicadorResultado> LstIndicadorResultados { get; set; }		

		#endregion

		#region Properties ReadOnly

		//public int Hip_PdteNotificacionCalc
		//{
		//	get
		//	{
		//		return Hip_EnTramitacionJuzgadoConCertificacionCargas - Hip_EnTramitacionJuzgadoConCertificacionCargasYRequerimientoPago;
		//	}
		//}

		#endregion
	}



}
