using System;
using System.Collections.Generic;
using Solvtio.Common;
using Solvtio.Models;
using System.Linq;

namespace Solvtio.Esp.Datos
{
    public class ModelExpedienteEstadoReducido
    {
		#region Constructors

		public ModelExpedienteEstadoReducido()
		{
		}

		#endregion

		#region Properties

		public string NoExpediente { get; set; }
        public string IdExpediente { get; set; }
        public string NoAuto { get; set; }

        public ExpedienteEstado ExpedienteEstado { get; set; }

        #endregion

        #region Properties ReadOnly


        #endregion
    }
}
