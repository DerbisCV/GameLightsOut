using System;

namespace Solvtio.Models
{
    public class DcvTestBase
	{
		#region Properties ModelFilterBase
		public static ModelFilterBase FilterEmpty = new ModelFilterBase() { };
		public static ModelFilterBase FilterHipotecario = new ModelFilterBase(TipoExpedienteEnum.Hipotecario);
		public static ModelFilterBase FilterAlquiler = new ModelFilterBase(TipoExpedienteEnum.Alquiler) { RowsMaxToTake = 10 };
		public static ModelFilterBase FilterEjecutivo = new ModelFilterBase(TipoExpedienteEnum.Ejecutivo);
        public static ModelFilterBase FilterOrdinario = new ModelFilterBase(TipoExpedienteEnum.Ordinario);
        public static ModelFilterBase Filter201509 = new ModelFilterBase()
		{
			FechaInicio = new DateTime(2015, 9, 1),
			FechaFin = new DateTime(2015, 9, 30)
		};
		#endregion

		//internal const int Seconds60 = 60000;
		//internal const int Alq_IdExpedienteEstado_TramitacionJuzgado = 245655;
		//internal const int Alq_IdExpedienteEstado_TramitacionJuzgado_Actuacion = 365;

		//internal const int IdPersonaExist = 18689;
		//internal const int IdDocumentoExist = 35188;
		//internal const int IdExpedienteExist4Document = 12389;
		//internal const int IdExpedienteEstadoExist = 224971;
		//internal const int IdExpHipotecarioExist = 12660;
		//internal const int IdExpEjecutivoExist = 31850;
		//internal const int IdExpAlquilerExist = 35188;

		public const int EjcIdExpDeudor = 58866;

        public const int Alq_IdExpedienteEstado_Lanzamiento = 249466;
		public const int Ejc_IdExpedienteEstado_Recepcion = 256340;
		public const int Ejc_IdExpedienteEstado_PresentacionDemanda = 258900;
		public const int Ejc_IdExpedienteEstado_Notificacion = 258960;
		public const int Ejc_IdExpedienteEstado_TramiteEmbargo = 255986;
		public const int Ejc_IdExpedienteEstado_SolicitudSubasta = 0;
		public const int Ejc_IdExpedienteEstado_Subasta = 0;
		public const int Ejc_IdExpedienteEstado_AdjudicacionBien = 0;
		public const int Ejc_IdExpedienteEstado_Finalizacion = 0;
        public const int Ejc_IdSalarioSaldo = 3;
		public const int Ejc_IdMueble = 2;
    }
}
