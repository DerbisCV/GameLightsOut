namespace Solvtio.Models
{
    public class ModelAlarma
	{
		#region Constructors

        public ModelAlarma()
        {
			CreateBase();
        }

        private void CreateBase()
		{
 		}

		#endregion

		#region Properties

		#region Alarmas Comunes

		public bool AlarmaExpiradoTiempoNegociacion { get; set; }

        #endregion

        #region Alarmas Hipotecario 

        public bool? HipotecarioAlarmaIncidentados { get; set; }
        public bool? HipotecarioAlarmaAdmisionDemanda { get; set; }
        public bool? HipotecarioAlarmaInadmisionDemanda { get; set; }
        public bool? HipotecarioAlarmaSucesionCopiaSellada { get; set; }
        public bool? HipotecarioAlarmaCertificacionCargas { get; set; }
        public bool? HipotecarioAlarmaRequerimientoPago { get; set; }
        public bool? HipotecarioAlarmaSolicitudSubasta { get; set; }
        public bool? HipotecarioAlarmaDecretoConvocatoria { get; set; }
        public bool? HipotecarioAlarmaDecretoAdjudicacion { get; set; }
        public bool? HipotecarioAlarmaPosesion { get; set; }
        public bool? HipotecarioAlarmaTestimonio { get; set; }


        //      public bool HipotecarioAlarmaConvocatoriaSubasta { get; set; }					
        //public bool HipotecarioAlarmaLanzamiento { get; set; }
        //      public bool HipotecarioAlarmaResolucionApelacion { get; set; }        
        //      public bool AlarmaHipSolicitudAdjudicacion { get; set; }
        public bool? EjecutivoAlarmaSucesionCopiaSellada { get; set; }
        public bool? OrdinarioAlarmaSucesionCopiaSellada { get; set; }
        public bool? MonitorioAlarmaSucesionCopiaSellada { get; set; }


        #endregion

        #region Ejecutivo 

        public bool? EjecutivoAlarmaRecepcionDemandaSellada { get; set; }
        public bool? EjecutivoAlarmaAdmisionDemanda { get; set; }
        public bool? EjecutivoAlarmaRequerimientoPago { get; set; }
        public bool? EjecutivoAlarmaAveriguacionPatrimonial { get; set; }
        public bool? EjecutivoAlarmaMejoraEmbargo { get; set; }
        public bool? EjecutivoAlarmaDecretoEmbargo { get; set; }
        public bool? EjecutivoAlarmaProrrogaEmbargo { get; set; }

        #endregion

        #region Alarmas Alquiler 

        public bool? AlquilerAlarmaPdteFechaResolucionIncidencia { get; set; }
        public bool? AlquilerAlarmaPresentacionDemanda { get; set; }
        public bool AlquilerAlarmaDemandaAdmitida { get; set; }
        public bool AlquilerAlarmaPendienteNotificacion { get; set; }
        public bool AlquilerAlarmaPendienteDecretoFin { get; set; }
        public bool AlquilerAlarmaPendienteTomaPosesion { get; set; }
        public bool AlquilerAlarmaPendienteEnervacion { get; set; }
	    public bool AlquilerAlarmaPendienteAjg { get; set; }
	    public bool AlquilerAlarmaPendienteAcuerdo { get; set; }
	    public bool AlquilerAlarmaPendienteInstruccionesCliente { get; set; }
        public bool? AlquilerAlarmaImpulsoPendienteAplicativoCliente { get; set; }

        #endregion

        #region Ordinario

        public bool? OrdinarioAlarmaPdteDemanda { get; set; }
        public bool? OrdinarioAlarmaDecretoAdmision { get; set; }
        public bool? OrdinarioAlarmaEmplazamientoPositivo { get; set; }
        public bool? OrdinarioAlarmaEmplazamientoNegativo { get; set; }
        public bool? OrdinarioAlarmaAudienciaPrevia { get; set; }
        public bool? OrdinarioAlarmaJuicio { get; set; }
        public bool? OrdinarioAlarmaSentencia { get; set; }

        #endregion

        #region OrdinarioCs 

        public bool? OrdinarioCsAlarmaVencimientoAllanamiento { get; set; }
	    public bool? OrdinarioCsAlarmaPendienteCopiaSelladaAllanamiento { get; set; }
	    public bool? OrdinarioCsAlarmaSentencia { get; set; }
        public bool? OrdinarioCsAlarmaSentenciaSinCostasAbonadas { get; set; }
        public bool? OrdinarioCsAlarmaPendienteFinalizacion { get; set; }

        #endregion

        #region JV 

        public bool? JvAlarmaPdteAdmision { get; set; }

        #endregion


        #endregion

        #region Properties ReadOnly 

        public int CountAlarms =>
            (HipotecarioAlarmaIncidentados ?? false ? 1 : 0)
            + (HipotecarioAlarmaAdmisionDemanda ?? false ? 1 : 0)
            + (HipotecarioAlarmaInadmisionDemanda ?? false ? 1 : 0)
            + (HipotecarioAlarmaSucesionCopiaSellada ?? false ? 1 : 0)
            + (HipotecarioAlarmaCertificacionCargas ?? false ? 1 : 0)
            + (HipotecarioAlarmaRequerimientoPago ?? false ? 1 : 0)
            + (HipotecarioAlarmaSolicitudSubasta ?? false ? 1 : 0)
            + (HipotecarioAlarmaDecretoConvocatoria ?? false ? 1 : 0)
            + (HipotecarioAlarmaDecretoAdjudicacion ?? false ? 1 : 0)
            + (HipotecarioAlarmaPosesion ?? false ? 1 : 0)
            + (HipotecarioAlarmaTestimonio ?? false ? 1 : 0)

            //+ (HipotecarioAlarmaResolucionApelacion ? 1 : 0)
            //+ (HipotecarioAlarmaConvocatoriaSubasta ? 1 : 0)
            //+ (HipotecarioAlarmaLanzamiento ? 1 : 0)

            + (AlarmaExpiradoTiempoNegociacion ? 1 : 0)
            //+ (AlarmaHipSolicitudAdjudicacion ? 1 : 0)            
            
            + (EjecutivoAlarmaSucesionCopiaSellada ?? false ? 1 : 0)
            + (OrdinarioAlarmaSucesionCopiaSellada ?? false ? 1 : 0)
            + (MonitorioAlarmaSucesionCopiaSellada ?? false ? 1 : 0)

            + (AlquilerAlarmaPdteFechaResolucionIncidencia ?? false ? 1 : 0)
            + (AlquilerAlarmaPresentacionDemanda ?? false ? 1 : 0)
            + (AlquilerAlarmaDemandaAdmitida ? 1 : 0)
            + (AlquilerAlarmaPendienteNotificacion ? 1 : 0)
            + (AlquilerAlarmaPendienteDecretoFin ? 1 : 0)
            + (AlquilerAlarmaPendienteTomaPosesion ? 1 : 0)
            + (AlquilerAlarmaPendienteEnervacion ? 1 : 0)

            + (AlquilerAlarmaPendienteAjg ? 1 : 0)
            + (AlquilerAlarmaPendienteAcuerdo ? 1 : 0)
            + (AlquilerAlarmaPendienteInstruccionesCliente ? 1 : 0)
            + (AlquilerAlarmaImpulsoPendienteAplicativoCliente ?? false ? 1 : 0)

            + (OrdinarioCsAlarmaVencimientoAllanamiento ?? false ? 1 : 0)
            + (OrdinarioCsAlarmaPendienteCopiaSelladaAllanamiento ?? false ? 1 : 0)
            + (OrdinarioCsAlarmaSentencia ?? false ? 1 : 0)
            + (OrdinarioCsAlarmaSentenciaSinCostasAbonadas ?? false ? 1 : 0)
            + (OrdinarioCsAlarmaPendienteFinalizacion ?? false ? 1 : 0)

            + (EjecutivoAlarmaRecepcionDemandaSellada ?? false ? 1 : 0)
            + (EjecutivoAlarmaAdmisionDemanda ?? false ? 1 : 0)
            + (EjecutivoAlarmaRequerimientoPago ?? false ? 1 : 0)
            + (EjecutivoAlarmaAveriguacionPatrimonial ?? false ? 1 : 0)
            + (EjecutivoAlarmaMejoraEmbargo ?? false ? 1 : 0)
            + (EjecutivoAlarmaDecretoEmbargo ?? false ? 1 : 0)
            + (EjecutivoAlarmaProrrogaEmbargo ?? false ? 1 : 0)

            + (OrdinarioAlarmaPdteDemanda ?? false ? 1 : 0)
            + (OrdinarioAlarmaDecretoAdmision ?? false ? 1 : 0)
            + (OrdinarioAlarmaEmplazamientoPositivo ?? false ? 1 : 0)
            + (OrdinarioAlarmaEmplazamientoNegativo ?? false ? 1 : 0)
            + (OrdinarioAlarmaAudienciaPrevia ?? false ? 1 : 0)
            + (OrdinarioAlarmaJuicio ?? false ? 1 : 0)
            + (OrdinarioAlarmaSentencia ?? false ? 1 : 0)

            + (JvAlarmaPdteAdmision ?? false ? 1 : 0)

            ;

        #endregion
    }
}
