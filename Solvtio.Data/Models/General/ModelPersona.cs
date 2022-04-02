namespace Solvtio.Models
{
    public class ModelPersona : ModelEntityBase
    {
        #region Constructors
        public ModelPersona() { }
        public ModelPersona(int idPersona, string nameOnly, string apellidos, string noDocumento) : base(idPersona, nameOnly) 
        {
            Apellidos = apellidos;
            NoDocumento = noDocumento;
        }



		//public ModelPersona(Gnr_Procurador _procurador)
		//{
		//	if (procurador != null)
		//	{
		//		this.Id = procurador.IdPersona;
		//		if (procurador.Gnr_Persona != null)
		//		{
		//			this.Name = procurador.Gnr_Persona.Nombre;
		//			this.Apellidos = procurador.Gnr_Persona.Apellidos;
		//			this.NoDocumento = procurador.Gnr_Persona.NoDocumento;
		//		}
		//	}
		//}
        #endregion

        #region Properties
        public string Apellidos { get; set; }
        public string NoDocumento { get; set; }

		private ExpedienteDeudor _expedienteDeudor;
		public ExpedienteDeudor ExpedienteDeudor 
		{
			get 
			{
				return _expedienteDeudor; 
			}
			set
			{
				_expedienteDeudor = value;
				if (_expedienteDeudor != null)
					setPersonData(_expedienteDeudor.Gnr_Persona);			
			}
		}

		private Gnr_Procurador _procurador;
		public Gnr_Procurador Procurador
		{
			get
			{
				return _procurador;
			}
			set
			{
				_procurador = value;
				if (_procurador != null)
					setPersonData(_procurador.Gnr_Persona);
			}
		}

		private void setPersonData(Gnr_Persona persona)
		{
			if (_procurador.Gnr_Persona == null) return;

            Id = persona.IdPersona;
            Name = persona.Nombre;
            Apellidos = persona.Apellidos;
            NoDocumento = persona.NoDocumento;			
		}

        #endregion

        #region ReagOnly Properties

        private string _nombreCompleto;
        public string NombreCompleto
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_nombreCompleto))
                    _nombreCompleto = string.Format("{0} {1}", Name, Apellidos);

                return _nombreCompleto;
            }
        }
        #endregion

        #region Methods
        #endregion
    }
}
