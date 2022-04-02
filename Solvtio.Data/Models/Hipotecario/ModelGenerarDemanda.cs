using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelGenerarDemanda
	{
		#region Constructors
		public ModelGenerarDemanda()
		{
			CreateBase();
		}

		private void CreateBase()
		{
			Errores = new List<string>();
		}
		#endregion

		#region Properties

		public Expediente Expediente { get; set; } //ExpedienteDeudores & Inmuebles
		public Hip_Hipoteca Hipoteca { get; set; }
		public Hip_Inmueble Inmueble { get; set; }

		public string UrlCrearDemanda { get; set; }

		public List<string> Errores { get; set; }

		#endregion
	}
}
