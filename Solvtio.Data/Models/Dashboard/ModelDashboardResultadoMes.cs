using System;
using System.Collections.Generic;

namespace Solvtio.Models
{
	public class ModelDashboardResultadoPeriodo
	{
		#region Constructor

		public ModelDashboardResultadoPeriodo()
		{
			CreateBase();		
		}
		public ModelDashboardResultadoPeriodo(TipoExpedienteEnum tipoExpediente)
		{
			CreateBase();
			Filter.IdTipoExpediente = (int)tipoExpediente;
			Filter.TipoExpedienteSelected = tipoExpediente;
		}
		public ModelDashboardResultadoPeriodo(ModelFilterBase filter)
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
			LstIndicadorResultados = new List<ModelIndicadorResultado>();
		}

		#endregion

		#region Properties

 		public ModelFilterBase Filter { get; set; }   

		public List<ModelIndicadorResultado> LstIndicadorResultados { get; set; }

	    public List<ModelIndicadorResultadoChild> LstIndicadorResultadoChild { get; set; } //La usamos para el listado del indicador

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
