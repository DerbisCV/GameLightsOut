namespace Solvtio.Models
{
    public class ModelDashboardAlarmas
	{
		#region Constructor

		public ModelDashboardAlarmas()
		{
			CreateBase();		
		}
		public ModelDashboardAlarmas(TipoExpedienteEnum tipoExpediente)
		{
			CreateBase();
			Filter.IdTipoExpediente = (int)tipoExpediente;
			Filter.TipoExpedienteSelected = tipoExpediente;
		}
        public ModelDashboardAlarmas(TipoExpedienteEnum tipoExpediente, int? idPersona, int? idTipoGestionado = null)
        {
            CreateBase();
            Filter.IdTipoExpediente = (int)tipoExpediente;
            Filter.TipoExpedienteSelected = tipoExpediente;
            Filter.IdUsuario = idPersona;
            Filter.IdTipoOtro4 = idTipoGestionado;
        }
        public ModelDashboardAlarmas(ModelFilterBase filter)
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

        #region Properties Hipotecario

        public int? HipotecarioAlarmaIncidentados { get; set; }
        public int? HipotecarioAlarmaAdmisionDemanda { get; set; }
        public int? HipotecarioAlarmaInadmisionDemanda { get; set; }
        public int? HipotecarioAlarmaSucesionCopiaSellada { get; set; }
		public int? HipotecarioAlarmaCertificacionCargas { get; set; }
        public int? HipotecarioAlarmaRequerimientoPago { get; set; }
        public int? HipotecarioAlarmaSolicitudSubasta { get; set; }
        public int? HipotecarioAlarmaDecretoConvocatoria { get; set; }
        public int? HipotecarioAlarmaDecretoAdjudicacion { get; set; }
        public int? HipotecarioAlarmaPosesion { get; set; }
        public int? HipotecarioAlarmaTestimonio { get; set; }

        public int? HipotecarioAlarmaRecepcionSolicitudCierre01 { get; set; }
        public int? HipotecarioAlarmaRecepcionSolicitudCierre02 { get; set; }
        public int? HipotecarioAlarmaRecepcionSolicitudCierre03 { get; set; }
        public int? HipotecarioAlarmaRecepcionSolicitudCierre04 { get; set; }
        public int? HipotecarioAlarmaRecepcionSolicitudCierre05 { get; set; }


        #endregion

        #region Properties Alquiler

        //public int Alq_FacturasPdtes { get; set; }	
        public int? AlquilerAlarmaPresentacionDemanda { get; set; }
		public int AlquilerAlarmaDemandaAdmitida { get; set; }
		public int AlquilerAlarmaPendienteNotificacion { get; set; }
		public int AlquilerAlarmaPendienteDecretoFin { get; set; }
		public int? AlquilerAlarmaPendienteTomaPosesion { get; set; }
        public int AlquilerAlarmaPendienteEnervacion { get; set; }
        public int? AlquilerAlarmaRecepcionDemandaSellada { get; set; }

        public int? AlquilerAlarmaRecepcionDemandaSelladaOrd { get; set; }
        public int? AlquilerAlarmaRecepcionDemandaSelladaEjc { get; set; }
        public int? AlquilerAlarmaRecepcionDemandaSelladaMn { get; set; }

        public int? AlquilerAlarmaRecepcionDenuncia { get; set; }


        public int AlquilerAlarmaPendienteAjg { get; set; }
	    public int AlquilerAlarmaPendienteAcuerdo { get; set; }
	    public int AlquilerAlarmaPendienteInstruccionesCliente { get; set; }
	    public int? AlquilerAlarmaImpulsoPendienteAplicativoCliente { get; set; }
        public int? AlquilerAlarmaPdteFechaResolucionIncidencia { get; set; }
        public int? AlquilerAlarmaEjecutarDecretoFinSentencia { get; set; }

        #endregion

        #region Negociacion

        public int NegociacionAlarmaExpiradoTiempoNegAlquiler { get; set; }
        public int NegociacionAlarmaExpiradoTiempoNegPrecontencioso { get; set; }

        #endregion

        #region Ejecutivo 

        public int? EjecutivoAlarmaRecepcionDemandaSellada { get; set; }
        public int? EjecutivoAlarmaAdmisionDemanda { get; set; }
        public int? EjecutivoAlarmaRequerimientoPago { get; set; }
        public int? EjecutivoAlarmaAveriguacionPatrimonial { get; set; }
        public int? EjecutivoAlarmaMejoraEmbargo { get; set; }
        public int? EjecutivoAlarmaDecretoEmbargo { get; set; }
	    public int? EjecutivoAlarmaProrrogaEmbargo { get; set; }
        public int? EjecutivoAlarmaSucesionCopiaSellada { get; set; }
        #endregion

        #region Ordinario 

        public int? OrdinarioAlarmaPdteDemanda { get; set; }
        public int? OrdinarioAlarmaDecretoAdmision { get; set; }
        public int? OrdinarioAlarmaEmplazamientoPositivo { get; set; }
        public int? OrdinarioAlarmaEmplazamientoNegativo { get; set; }
        public int? OrdinarioAlarmaAudienciaPrevia { get; set; }
        public int? OrdinarioAlarmaJuicio { get; set; }
        public int? OrdinarioAlarmaSentencia { get; set; }
        public int? OrdinarioAlarmaPdteSentencia { get; set; }
        public int? OrdinarioAlarmaRecepcionDemandaSellada { get; set; }
        public int? OrdinarioAlarmaSucesionCopiaSellada { get; set; }

        #endregion

        #region Properties OrdinarioCs 

        public int OrdinarioCsAlarmaVencimientoAllanamiento { get; set; }
        public int OrdinarioCsAlarmaPendienteCopiaSelladaAllanamiento { get; set; }
        public int? OrdinarioCsAlarmaSentencia { get; set; }
	    public int? OrdinarioCsAlarmaPendienteFinalizacion { get; set; }
        public int? OrdinarioCsAlarmaSentenciaSinCostasAbonadas { get; set; }

        #endregion

        #region JV

        public int? JvAlarmaPdteAdmision { get; set; }
        public int JvAlarmaPdteNotificacion { get; set; }
        public int? JvAlarmaPdteLibradoMandamiento { get; set; }
        public int? JvAlarmaPdteRecepcionEscritura { get; set; }
        public int? JvAlarmaRecepcionDemandaSellada { get; set; }

        //public int? OrdinarioCsAlarmaSentenciaSinCostasAbonadas { get; set; }


        #endregion

        #region Monitorio 

        public int? MonitorioAlarmaRecepcionDemandaSellada { get; set; }
        public int? MonitorioAlarmaSucesionCopiaSellada { get; set; }

        #endregion

        #region CyM / Concurso 

        //public int? ConcursoAlarmaCumplidoHito01 { get; set; }
        //public int? ConcursoAlarmaCumplidoHito57 { get; set; }
        //public int? ConcursoAlarmaCumplidoHito14_18 { get; set; }
        //public int? ConcursoAlarmaCumplidoHito14_48 { get; set; }
        //public int? ConcursoAlarmaCumplidoHito73 { get; set; }
        //public int? ConcursoAlarmaCumplidoHito74 { get; set; }

        public int? ConcursoAlarmaProcedeFacturacion_01 { get; set; }
        public int? ConcursoAlarmaProcedeFacturacion_57 { get; set; }
        public int? ConcursoAlarmaProcedeFacturacion_14_18m { get; set; }
        public int? ConcursoAlarmaProcedeFacturacion_14_48m { get; set; }
        public int? ConcursoAlarmaProcedeFacturacion_74 { get; set; }
        public int? ConcursoAlarmaProcedeFacturacion_78 { get; set; }
        public int? ConcursoAlarmaProcedeFacturacion_79 { get; set; }

        public int? ConcursoAlarmaProcedeFacturacion_73 { get; set; }
        public int? ConcursoAlarmaProcedeFacturacion_52 { get; set; }
        public int? ConcursoAlarmaProcedeFacturacion_54 { get; set; }
        public int? ConcursoAlarmaProcedeFacturacion_55 { get; set; }
        public int? ConcursoAlarmaProcedeFacturacion_56 { get; set; }
        public int? ConcursoAlarmaProcedeFacturacion_63 { get; set; }
        public int? ConcursoAlarmaProcedeFacturacion_64 { get; set; }


        #endregion

        #region Properties ReadOnly
        //public int Hip_PdteNotificacionCalc
        //{
        //	get
        //	{
        //		return Hip_EnTramitacionJuzgadoConCertificacionCargas - Hip_EnTramitacionJuzgadoConCertificacionCargasYRequerimientoPago;
        //	}
        //}
        #endregion


    }
}
