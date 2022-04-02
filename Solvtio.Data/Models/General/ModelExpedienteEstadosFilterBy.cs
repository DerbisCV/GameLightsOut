using System;
using System.Collections.Generic;
using Solvtio.Common;
using Solvtio.Models;
using System.Linq;

namespace Solvtio.Esp.Datos
{
    public class ModelExpedienteEstadosFilterBy
    {
		#region Constructors

		public ModelExpedienteEstadosFilterBy()
		{
		}
        public ModelExpedienteEstadosFilterBy(ModelFilterBase filter)
        {
            Filter = filter;
        }

		#endregion

		#region Properties

		public ModelFilterBase Filter { get; set; }
        public List<ExpedienteEstado> LstExpedienteEstado { get; set; }

        public List<Gnr_Abogado> LstAbogados { get; set; }

        public void Refresh()
        {
            LstAbogados = LstExpedienteEstado
                .Select(x => x.AbogadoActual).ToList()
                .Distinct()
                .ToList();
        }

        #endregion

        #region Properties ReadOnly


        #endregion
    }
}
