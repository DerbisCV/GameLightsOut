using System;
using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelDashboardSla
	{
		#region Constructor

		public ModelDashboardSla()
		{
			CreateBase();		
		}
		public ModelDashboardSla(TipoExpedienteEnum tipoExpediente)
		{
			CreateBase();
            Filter.IdTipoExpediente = (int)tipoExpediente;
            Filter.TipoExpedienteSelected = tipoExpediente;
		}
		public ModelDashboardSla(ModelFilterBase filter)
		{
			CreateBase();
            Filter = filter;
			if (Filter.IdTipoExpediente.HasValue)
                Filter.TipoExpedienteSelected = (TipoExpedienteEnum)Filter.IdTipoExpediente.Value;
		}

		private void CreateBase()
		{
            Filter = new ModelFilterBase();
		}

		#endregion

		public ModelFilterBase Filter { get; set; }

		#region Properties Hipotecario
   
        public ModelDashboardSlaChild HipotecarioSlaPresentacionDemanda { get; set; }
        public ModelDashboardSlaChild AlquilerSlaPresentacionDemanda { get; set; }
        public ModelDashboardSlaChild OrdinarioSlaPresentacionDemanda { get; set; }
        public ModelDashboardSlaChild EjecutivoSlaPresentacionDemanda { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion
    }
}
