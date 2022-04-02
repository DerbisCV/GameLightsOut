using System;
using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelFiltroBase
	{
		#region Constructors
		public ModelFiltroBase() 
		{
            TipoExpedienteSelected = 1;
            createBase();
		}
		public ModelFiltroBase(int tipoExpediente) 
		{
            TipoExpedienteSelected = tipoExpediente;
            createBase();
		}

        private void createBase()
        {
            Anio = DateTime.Now.Year;
            LstAnios = Solvtio.Common.Dates.GetListAnios(3);
        }
		#endregion

		#region Properties
		public int? TipoExpedienteSelected { get; set; }
		public int? ClienteOficinaSelected { get; set; }

		public int? TipoEstadoSelected { get; set; }

		public int? Anio { get; set; }
        public IList<int> LstAnios { get; set; }
		public int? NoSemanaIni { get; set; }
		public int? NoSemanaFin { get; set; }
        public int? IdCliente { get; set; }
		#endregion
	}
}
