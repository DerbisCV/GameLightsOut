using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelExpedienteVistaAll
    {
		#region Constructors

		public ModelExpedienteVistaAll() 
		{
			CreateBase();
		}
        public ModelExpedienteVistaAll(string email)
        {
            CreateBase();
            Filter.UserName = email;
        }
        public ModelExpedienteVistaAll(int year, int month, string email = null)
        {
            CreateBase();
            Filter.Anio = year;
            Filter.Mes = month;
            Filter.UserName = email;
        }
        public ModelExpedienteVistaAll(ModelFilterBase filter)
        {
			CreateBase();
            Filter = filter;
        }

		private void CreateBase()
		{
			Filter = new ModelFilterBase();
            LstExpedienteVista = new List<ExpedienteVista>();
		}

		#endregion

		#region Properties

		public ModelFilterBase Filter { get; set; }

	    public List<ExpedienteVista> LstExpedienteVista { get; set; }
        public List<ExpedienteVencimiento> LstExpedienteVencimiento { get; set; }

        public List<Impulso> LstImpulso { get; set; }
        public List<Actuacion> LstActuacion { get; set; }
        public List<ExpedienteParalizado> LstExpedienteParalizado { get; set; }

        public List<ModelExpOficinaIndicador> LstExpOficinaIndicador { get; set; }

        public List<ModelExpInmueble> LstModelExpInmueble { get; set; }
        public List<Expediente> LstExpediente { get; set; }
        public List<ModelActividadAbogado> LstModelActividadAbogado { get; set; }

        #endregion

        #region Properties ReadOnly

        //public bool MostrarOtrosParaEstadoImpulso => Filter.TipoIndicadorQaSelected.HasValue && (
        //                                       Filter.TipoIndicadorQaSelected == TipoIndicadorQa.HipotecarioIncidenciaDecretoAjdudicacion
        //                                          || Filter.TipoIndicadorQaSelected == TipoIndicadorQa.HipotecarioIncidenciaDecretoAjdudicacion);
        //public bool MostrarOtrosParaEstadoImpulso => Filter.TipoIndicadorQaSelected.HasValue;

        //   public bool MostrarEstadoImpulso => MostrarDecretoSubasta || MostrarAdjudicacion || MostrarOtrosParaEstadoImpulso;

        #endregion
    }


}
