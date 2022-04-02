using System;
using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelITPListado
    {
        public ModelITPListado()
	    {
            Itps = new List<ModelITP>();
	    }
        public ModelITPListado(DateTime fecha1, DateTime fecha2)
		{
            FechaInicio = fecha1;
            FechaFin = fecha2;

            Itps = new List<ModelITP>();
		}

        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }

        public TipoAccion? Accion { get; set; }
        public NotaRapida Nota { get; set; }
        public IList<ModelITP> Itps { get; set; }
    }
}