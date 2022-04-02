using Solvtio.Common;
using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelBurofaxAlquiler
	{
		#region Constructors
		public ModelBurofaxAlquiler() { }
		public ModelBurofaxAlquiler(int idExp) 
		{
            IdExpediente = idExp;
		}
		#endregion

		#region Properties

		public int IdExpediente { get; set; }
		public Expediente Expediente { get; set; }
		public Alq_Expediente_Contrato Alq_Expediente_Contrato { get; set; }
		public Hip_Inmueble Hip_Inmueble { get; set; }
		public ExpedienteDeudor ExpedienteDeudor { get; set; }

		public List<KeyValue> TipoPlantillaBurofaxAll { get; set; }
		public string TipoPlantillaBurofaxSelected { get; set; }

		public int IdExpedienteDeudor { get; set; }

		#endregion
	}
}
