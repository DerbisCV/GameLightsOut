using System.Linq;

namespace Solvtio.Models
{
    public class ModelNegociacion
	{

		#region Constructors
		public ModelNegociacion() { }

		public ModelNegociacion(Neg_Gestion neg_Gestion)
		{
            Expediente = neg_Gestion.Expediente;
			Refresh(neg_Gestion.Expediente);
		}
		public ModelNegociacion(Expediente expediente)
        {
			Refresh(expediente);
        }

		private void Refresh(Expediente expediente)
		{
			if (expediente == null) return;

			//Expediente = exp;
			IdExpediente = expediente.IdExpediente;
			NoExpediente = expediente.NoExpediente;
			ReferenciaExterna = expediente.ReferenciaExterna;
			TipoExpediente = expediente.Gnr_TipoExpediente.Abreviado;
			ClienteOficinaNombre = expediente.Gnr_ClienteOficina.Nombre;
			ClienteOficinaTelefono = expediente.Gnr_ClienteOficina.Gnr_Cliente.Telefono;
			if (expediente.HipotecaEnEjecucion != null)
			{
				NoCuentaPrestamo = expediente.HipotecaEnEjecucion.NoCuentaPrestamo;
				DeudaCierreFijacion = expediente.HipotecaEnEjecucion.DeudaCierreFijacion;
				if (expediente.HipotecaEnEjecucion.Gnr_Persona != null)
				{
					DeudorId = expediente.HipotecaEnEjecucion.IdPersona.Value;
					DeudorNombre = expediente.HipotecaEnEjecucion.Gnr_Persona.NombreCompleto;
					DeudorTelefono = expediente.HipotecaEnEjecucion.Gnr_Persona.TelefonoPrincipal;
				}
			}
			else
			{
				var deudorPrincipal = expediente.ExpedienteDeudors.FirstOrDefault(x => x.IdTipoDeudor == (int)DeudorTipo.DeudorPrincipal);
				if (deudorPrincipal != null && deudorPrincipal.Gnr_Persona != null)
				{
					DeudorId = deudorPrincipal.IdPersona;
					DeudorNombre = deudorPrincipal.Gnr_Persona.NombreApellidos;
					DeudorTelefono = deudorPrincipal.Gnr_Persona.TelefonoPrincipal;
				}

				if (expediente.Ejc_Expediente != null)
				{
					NoCuentaPrestamo = string.Format("{0}-{1}", expediente.Ejc_Expediente.CuentaOficina, expediente.Ejc_Expediente.CuentaNo);
					DeudaCierreFijacion = expediente.Ejc_Expediente.Importe ?? 0;
				}
				if (expediente.Alq_Expediente != null)
				{
					//NoCuentaPrestamo = string.Format("{0}-{1}", expediente.Alq_Expediente.CuentaOficina, expediente.Alq_Expediente.CuentaNo);
					DeudaCierreFijacion = expediente.Alq_Expediente.DeudaPendiente ?? 0;
				}
			}
		}

		#endregion

		#region Properties
		public Expediente Expediente { get; set; }
		public int IdExpediente { get; set; }
		public string NoExpediente { get; set; }
		public string NoCuentaPrestamo { get; set; }
        public string ReferenciaExterna { get; set; }
		public string ClienteOficinaNombre { get; set; }
		public string ClienteOficinaTelefono { get; set; }
		public int DeudorId { get; set; }
		public string DeudorNombre { get; set; }
		public string DeudorTelefono { get; set; }
		public decimal DeudaCierreFijacion { get; set; }
		public string TipoExpediente { get; set; }

		#endregion

	}
}
