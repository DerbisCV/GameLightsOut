using System;

namespace Solvtio.Models
{
    public class ModelVistasCalendar
	{
		#region Constructors
		public ModelVistasCalendar() { }
		#endregion

		#region Properties
		public int IdExpediente { get; set; }
		public int IdExpedienteEstado { get; set; }
		public string NoExpediente { get; set; }

		public DateTime Fecha { get; set; }
		public int IdActucacion { get; set; }
		public bool Oposicion { get; set; }

		//public int? IdAbogadoVista { get; set; }
		#endregion


	}

}
