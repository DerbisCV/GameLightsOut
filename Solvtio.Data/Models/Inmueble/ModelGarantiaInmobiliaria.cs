using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelGarantiaInmobiliaria
    {
		#region Properties

		public int IdExpediente { get; set; }
        public List<ExpedienteContrato> LstContrato { get; set; }

        #endregion
    }



}
