using System.ComponentModel;

namespace Solvtio.Models.Enumeraciones
{
    public enum ResultsOrderBy
    {
        [Description("Precio")]
        PrecioMenorPrimero,

        [Description("Solo en stock")]
        SoloEnStock,

        [Description("Más vendidos")]
        MasVendidos
    }
	
	public enum TipoDocumentoValue 
	{
		MinutaDacion = 5, 
		MinutaAdjudicacionSinOposicion = 6,
		MinutaAdjudicacionConOposicion = 7,
		MinutaRefinanciacionSinSubasta = 8,
		MinutaRegularizacionRefinanciacion = 9,
		MinutaEjecutivoCAM = 10,
		MinutaMonitorio = 11,
		MinutaEjecutivos = 12,
	};


    public enum TipoAlertaEnum
    {
        Manual = 1,
        ExpedienteSinMovimiento = 2,
        ExpedienteConDemandaSinAutoDeAdmision = 3,
        ExpedienteConcursalCelebracionJuntaAcreedores = 8,
        ExpedienteHipotecarioPendientePresentarDemanda = 12,
        ExpedienteHipotecarioPendienteRequerimientoPagoPositivo = 13,
        ExpedienteHipotecarioPendienteSolicitarSubasta = 14,
        ExpedienteHipotecarioPrepararVista = 15,
        ExpedienteHipotecarioTestimonioAdjudicacion = 16,

    }

	public enum TipoCalendarioEstado
	{
		Todas = 0,

		[Description("Señaladas")]
		Senialada = 1,
		Titulizada = 2,
		Suspendida = 3,
		Iva = 4,

		[Description("Con Oposición")]
		ConOposicion = 51,
		[Description("Sin Oposición")]
		SinOposicion = 52,
	}


	/// <summary>
	/// Obsoleto (Usar la enumeracion --> Solvtio.Models.Model.ExpedienteEstadoTipo)
	/// </summary>
    public enum TipoEstadoValue
    {
        //RecepcionExpediente = 1,
        //Otro = 6,
        //Finalizado = 8,
        //ConcursalFinalizado = 45,
    }
}
