using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelExpedientesSegunEstados
	{
		#region Constructors

		public ModelExpedientesSegunEstados()
		{
		}
        public ModelExpedientesSegunEstados(ModelFilterBase filter)
        {
            Filter = filter;
        }

		#endregion

		#region Properties

		public ModelFilterBase Filter { get; set; }

		public List<STPROC_GetExpHipotecariosFinalizados_Result> LstExpedienteHipotecarioFinalizado { get; set; }
		public List<STPROC_GetExpHipotecariosPresentacionDemanda_Result> LstExpedienteHipotecarioPresentacionDemanda { get; set; }
		public List<STPROC_GetExpHipotecariosSubasta_Result> LstExpedienteHipotecarioSubasta { get; set; }

		public List<STPROC_GetExpAlquilerPresentacionDemanda_Result> LstExpedienteAlquilerPresentacionDemanda { get; set; }
		public List<STPROC_GetExpAlquilerFinalizados_Result> LstExpedienteAlquilerFinalizado { get; set; }

        public List<Hip_ExpedienteEstadoAdjudicacion> LstExpedienteHipotecarioAdjudicacion { get; set; }

        public List<Expediente> LstExpediente { get; set; }
		public List<Hip_Inmueble> LstHipInmueble { get; set; }

		public List<ExpedienteEstado> LstExpedienteEstado { get; set; }
	    public List<Hip_ExpedienteEstadoProcesoParalizado> LstExpedienteEstadoProcesoParalizado { get; set; }
	    public List<Hip_ExpedienteEstadoFinalizacion> LstExpedienteEstadoHipFinalizado { get; set; }
	    public List<HipExpedienteEstadoPresentacionDemanda> LstExpedienteEstadoHipPresentacionDemanda { get; set; }
	    public List<HipExpedienteEstadoTramitacionSubasta> LstExpedienteEstadoHipTramitacionSubasta { get; set; }

        public List<Alq_Expediente_EstadoFinalizacion> LstExpedienteEstadoAlqFinalizado { get; set; }
        public List<Alq_Expediente_EstadoPresentacionDemanda> LstExpedienteEstadoAlqPresentacionDemanda { get; set; }

        #endregion
    }
}
