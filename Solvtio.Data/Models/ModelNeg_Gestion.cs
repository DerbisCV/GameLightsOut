namespace Solvtio.Models
{
    public partial class ModelNeg_Gestion
	{
		#region Constructors
		public ModelNeg_Gestion() { }

		public ModelNeg_Gestion(Neg_Gestion neg_Gestion)
		{
            Neg_Gestion = neg_Gestion;
            Expediente = neg_Gestion.Expediente;
			Refresh(neg_Gestion.Expediente);
		}

		private void Refresh(Expediente expediente)
		{
			if (expediente == null) return;

			////Expediente = exp;
			//IdExpediente = expediente.IdExpediente;
			//NoExpediente = expediente.NoExpediente;
			//ReferenciaExterna = expediente.ReferenciaExterna;
			//TipoExpediente = expediente.Gnr_TipoExpediente.Abreviado;
			//ClienteOficinaNombre = expediente.Gnr_ClienteOficina.Nombre;
			//ClienteOficinaTelefono = expediente.Gnr_ClienteOficina.Gnr_Cliente.Telefono;
			//if (expediente.HipotecaEnEjecucion != null)
			//{
			//	NoCuentaPrestamo = expediente.HipotecaEnEjecucion.NoCuentaPrestamo;
			//	DeudaCierreFijacion = expediente.HipotecaEnEjecucion.DeudaCierreFijacion;
			//	if (expediente.HipotecaEnEjecucion.Gnr_Persona != null)
			//	{
			//		DeudorId = expediente.HipotecaEnEjecucion.IdPersona.Value;
			//		DeudorNombre = expediente.HipotecaEnEjecucion.Gnr_Persona.NombreCompleto;
			//		DeudorTelefono = expediente.HipotecaEnEjecucion.Gnr_Persona.TelefonoPrincipal;
			//	}
			//}
		}

		#endregion

		#region Properties
		public Neg_Gestion Neg_Gestion { get; set; }
		public Expediente Expediente { get; set; }

		#endregion
	}
}
