using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelCalendarioListadoAll
	{
        #region Constructor

		public ModelCalendarioListadoAll() 
		{
            createBase();
		}

        public ModelCalendarioListadoAll(ModelFilterBase filter)
		{
            createBase();
            Filter = filter;
		}

        private void createBase()
        {
            Filter = new ModelFilterBase();
            LstVistas = new List<ModelVistasCalendar>();
            LstTasas = new List<Alq_Expediente_EstadoPresentacionDemanda>();
            LstLanzamiento = new List<Alq_Expediente_EstadoLanzamiento>();
            LstExpedienteVista = new List<ExpedienteVista>();
            LstExpedienteVencimiento = new List<ExpedienteVencimiento>();
            LstExpedienteSubasta = new List<ExpedienteSubasta>();
        }

		#endregion
		
		#region Properties

		public ModelFilterBase Filter { get; set; }
		public List<Alq_Expediente_EstadoPresentacionDemanda> LstTasas { get; set; }
		public List<ModelVistasCalendar> LstVistas { get; set; }
		public List<Alq_Expediente_EstadoLanzamiento> LstLanzamiento { get; set; }
		public List<ExpedienteVista> LstExpedienteVista { get; set; }
        public List<ExpedienteVencimiento> LstExpedienteVencimiento { get; set; }
        public List<ExpedienteSubasta> LstExpedienteSubasta { get; set; }
        public List<Expediente> LstExpediente01 { get; set; }

        #endregion

        #region Properties ReadOnly
        #endregion




    }
}
