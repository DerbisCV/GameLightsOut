namespace Solvtio.Models
{
    public partial class ModelHipoteca
	{
		#region Constructors
		public ModelHipoteca() { }

		public ModelHipoteca(Hip_Hipoteca hipoteca)
		{
            Title = "Datos de la Hipoteca";
            IdHipoteca = hipoteca.IdHipoteca;
            IdExpediente = hipoteca.IdExpediente.Value;
            Hip_Hipoteca = hipoteca;
			Refresh(hipoteca);
		}

		public void Refresh(Hip_Hipoteca hipoteca)
		{
			if (hipoteca == null) return;

			IdExpediente = hipoteca.IdExpediente.Value;
			NoExpediente = hipoteca.Expediente.NoExpediente;
			NoCuentaPrestamo = hipoteca.NoCuentaPrestamo;
			DeudorNombreCompleto = hipoteca.Gnr_Persona.NombreCompleto;
			DeudorTelefonoPrincipal = hipoteca.Gnr_Persona.TelefonoPrincipal;
			DeudaCierreFijacion = hipoteca.DeudaCierreFijacion;

			//TipoExpediente = hipoteca.Gnr_TipoExpediente.Abreviado;
			//ClienteOficinaNombre = hipoteca.Gnr_ClienteOficina.Nombre;
			//ClienteOficinaTelefono = hipoteca.Gnr_ClienteOficina.Gnr_Cliente.Telefono;
			//if (hipoteca.HipotecaEnEjecucion != null)
			//{
			//	NoCuentaPrestamo = hipoteca.HipotecaEnEjecucion.NoCuentaPrestamo;
				
			//	if (hipoteca.HipotecaEnEjecucion.Gnr_Persona != null)
			//	{
			//		DeudorId = hipoteca.HipotecaEnEjecucion.IdPersona.Value;
			//		DeudorNombre = hipoteca.HipotecaEnEjecucion.
			//		DeudorTelefono = hipoteca.HipotecaEnEjecucion
			//	}
			//}
		}

		#endregion

		#region Properties
		public int IdHipoteca { get; set; }
		public int IdExpediente { get; set; }
		public string Title { get; set; }
		public Hip_Hipoteca Hip_Hipoteca { get; set; }
		public string NoExpediente { get; set; }
		public string NoCuentaPrestamo { get; set; }
		public string DeudorNombreCompleto { get; set; }
        public string DeudorTelefonoPrincipal { get; set; }
		public decimal DeudaCierreFijacion { get; set; }
		#endregion

	}
}
