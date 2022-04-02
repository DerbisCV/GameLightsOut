using System;
using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelAdjudicacionListado
    {
         public ModelAdjudicacionListado()
	    {
            Adjudicaciones = new List<ModelAdjudicacion>();
	    }
         public ModelAdjudicacionListado(DateTime fecha1, DateTime fecha2)
		{
            FechaInicio = fecha1;
            FechaFin = fecha2;

            Adjudicaciones = new List<ModelAdjudicacion>();
		}

        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }

        public Solvtio.Common.TipoAccion? Accion { get; set; }
        public NotaRapida Nota { get; set; }
        public IList<ModelAdjudicacion> Adjudicaciones { get; set; }
    }
}
