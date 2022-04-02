using System;
using System.Collections.Generic;
using Solvtio.Common;
using Solvtio.Models;
using System.Linq;

namespace Solvtio.Esp.Datos
{
    public class ModelFilterByVarios
    {
		#region Constructors

		public ModelFilterByVarios()
		{
		}
        public ModelFilterByVarios(ModelFilterBase filter)
        {
            Filter = filter;
        }

		#endregion

		#region Properties

		public ModelFilterBase Filter { get; set; }
        public List<ExpedienteNota> LstExpedienteNota { get; set; }

        public void Refresh()
        {
            //LstAbogados = LstExpedienteEstado
            //    .Select(x => x.AbogadoActual).ToList()
            //    .Distinct()
            //    .ToList();
        }

        #endregion

        #region Properties ReadOnly


        #endregion
    }
}
