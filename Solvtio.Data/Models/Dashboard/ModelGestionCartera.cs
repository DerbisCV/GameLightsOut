using System;
using System.Collections.Generic;

namespace Solvtio.Models
{
	public class ModelGestionCartera : ModelBase
	{
		#region Constructor

		public ModelGestionCartera()
		{
			CreateBase();		
		}
		public ModelGestionCartera(TipoExpedienteEnum tipoExpediente, bool filterByClient = false, int? idCliente = null, int? idClienteOficina = null)
		{
			CreateBase();
			FilterByClient = filterByClient;
			Filter.IdTipoExpediente = (int)tipoExpediente;
			Filter.ClienteSelected = idCliente;
			Filter.ClienteOficinaSelected = idClienteOficina;
		}
		public ModelGestionCartera(ModelFilterBase filter)
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
			LstIndicador = new List<ModelIndicadorBase>();
			//LstIndicadorYearMinus1 = new List<ModelIndicadorBase>();
			//LstIndicadorYearMinus2 = new List<ModelIndicadorBase>(); 
			//LstIndicadorYearMinus3 = new List<ModelIndicadorBase>();

			LstIndicadorYear = new List<ModelIndicadorBase>();
			LstIndicadorByMonth = new List<ModelIndicadorBase>();
		}

		#endregion

		#region Properties

 		public ModelFilterBase Filter { get; set; }
		public bool FilterByClient { get; set; } // Si es true, el filtro es por cliente, en caso contrario será por ClienteOficina

		public List<ModelIndicadorBase> LstIndicador { get; set; }
		//public List<ModelIndicadorBase> LstIndicadorYearMinus1 { get; set; }
		//public List<ModelIndicadorBase> LstIndicadorYearMinus2 { get; set; }
		//public List<ModelIndicadorBase> LstIndicadorYearMinus3 { get; set; }

		public List<ModelIndicadorBase> LstIndicadorYear { get; set; }
		public List<ModelIndicadorBase> LstIndicadorByMonth { get; set; }	
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
