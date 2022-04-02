using System;
using System.Collections.Generic;
using Solvtio.Common;

namespace Solvtio.Models
{
    public class ModelSubastaListado
    {
	    public ModelSubastaListado()
	    {
            Subastas = new List<ModelSubasta>();
	    }
        public ModelSubastaListado(DateTime fecha1, DateTime fecha2, TipoEstadoSubasta tipoEstadoSubasta)
		{
            FechaInicio = fecha1.Date;
            FechaFin = fecha2.GetEndOfDay();
            TipoEstadoSubasta = tipoEstadoSubasta;

		    Subastas = new List<ModelSubasta>();
		}

        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public TipoEstadoSubasta? TipoEstadoSubasta { get; set; }
		public int? IdClienteOficina { get; set; }
		public TipoExport? Export { get; set; }

        public TipoAccion? Accion { get; set; }
        public NotaRapida Nota { get; set; }

        public IList<ModelSubasta> Subastas { get; set; }
        public List<ExpedienteSubasta> LstExpedienteSubasta { get; set; }
    }
}
