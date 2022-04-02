using System.ComponentModel;

namespace Solvtio.Common
{

    public enum EnumTipo2Test
    {
        [Description("Prueba 0")]
        Prueba0 = 0,

        [Description("Es la prueba número 5")]
        Prueba5 = 5,

        [Description("Más vendidos")]
        Prueba99 = 99
    }

    public enum ResultsOrderBy
    {
        [Description("Precio")]
        PrecioMenorPrimero = 0,

        [Description("Solo en stock")]
        SoloEnStock = 1,

        [Description("Más vendidos")]
        MasVendidos = 2
    }

	public enum TipoEstadoSubasta
	{
		Todas = 0,

        [Description("Señaladas")]
		Senialada = 1,

		Titulizada = 2,
		Suspendida = 3,
		Iva = 4,

		[Description("Publicación en el BOE")]
		PujaBoe = 11,
		[Description("Cierre de la Puja")]
		PujaCierre = 12,
		[Description("Fin de Mejora de la Puja")]
		PujaFinMejora = 13,
		[Description("Limite Solicitud de Adjudicación")]
		PujaSolicitudAdjudicacionLimite = 14,

		[Description("Celebración de Subasta")]
		CelebracionSubasta = 15
	}

	public enum TipoExport
	{
		Excel = 1,
        Excel2 = 2,
        Excel3 = 3,
        Excel4 = 4,
        Excel5 = 5,
    }
    public enum TipoAccion
    {
        ListadoSubastaUpdateNote = 1 //Actualizar nota rapida
    }

    public enum PeriodType
    {
        Mensual = 1,
        //Bimensual,
        Trimestral,
        //Cuatrimestre,
        //Semestral,
        Anual,
    }

}
