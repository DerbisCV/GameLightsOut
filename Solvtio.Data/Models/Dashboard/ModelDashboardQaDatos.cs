namespace Solvtio.Models
{
    public class ModelDashboardQaDatos
    {
		#region Constructor

		public ModelDashboardQaDatos()
		{
			CreateBase();		
		}
		public ModelDashboardQaDatos(TipoExpedienteEnum tipoExpediente)
		{
			CreateBase();
            Filter.IdTipoExpediente = (int)tipoExpediente;
            Filter.TipoExpedienteSelected = tipoExpediente;
		}
		public ModelDashboardQaDatos(ModelFilterBase filter)
		{
			CreateBase();
            Filter = filter;
			if (Filter.IdTipoExpediente.HasValue)
                Filter.TipoExpedienteSelected = (TipoExpedienteEnum)Filter.IdTipoExpediente.Value;
		}

		private void CreateBase()
		{
            Filter = new ModelFilterBase();
		}

		#endregion

		public ModelFilterBase Filter { get; set; }

		#region Hipotecario
  
        public int? ExpHipQaDatosSinInmueble { get; set; } //Expedientes sin inmuebles: Expedientes hipotecarios activos que no tengan inmuebles		
	    public int? ExpHipQaDatosSinFechaDemanda { get; set; } //Expedientes sin fecha de demanda: Expedientes activos en el estado trámite o superior sin fecha de demanda
        public int? ExpHipQaDatosSinPartidoJudicial { get; set; } //Expedientes sin partido judicial: Expedientes activos en el estado trámite o superior sin partido judicial
        public int? ExpHipQaDatosSinNoAuto { get; set; } //Expedientes sin No.Auto: Expedientes activos en el estado trámite o superior sin número de auto.

        public int? ExpHipQaDatosSinJuzgado { get; set; }
        public int? ExpHipQaDatosSinDemandaAdmitida { get; set; }
        public int? ExpHipQaDatosAdjudicacionIncompletos { get; set; }

        #endregion

        #region Ejecutivo

        #endregion

        #region Alquiler

        #endregion

        #region Negociacion

        #endregion

        #region Ordinario

        #endregion

        #region Cláusula Suelo

        #endregion

        #region Properties ReadOnly
        #endregion
    }
}
