using System.ComponentModel;

namespace Solvtio.Models
{  
    public enum TipoTarea
	{
		[Description("-")]
		None = 0,
        Email = 1,
        Llamada = 2,
		[Description("Para hacer")]
        ParaHacer = 3,
		[Description("Reunión")]
        Reunion = 4,
        Seguimiento = 5,
        [Description("Comida / Café")]
        ComidaCafe = 6,
    }

    public enum TipoContacto
    {
        Persona = 1,
        Empresa = 2,
    }

    public enum TipoPrecio
    {
        Fijo = 1,
        PorHora = 2,
        PorMes = 3,
        PorAnio = 4,
    }

    public enum TipoOportunidad
    {
        [Description("Negociación")]
        Negociacion = 1,
        Caso = 2,
    }

    public enum EstadoOportunidad
    {
        [Description("En Proceso")]
        EnProceso = 1,
        Ganada = 2,
        Perdida = 3,
        //Cerrada = 9,
    }

    public enum TipoInstirucionReligiosa
    {
        No = 0,
        [Description("Congregación")]
        Congregacion = 1,
        [Description("Diócesis")]
        Diocesis = 2,
    }

    public enum TipoEstadoCliente
    {
        Inactivo = -1,
        Potencial = 0,
        Activo = 2
    }

}
