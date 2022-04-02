using System;
using System.Collections.Generic;
using Solvtio.Common;

namespace Solvtio.Models
{
    public class ModelExpedienteEstadoResumen
	{
		#region Constructor
		public ModelExpedienteEstadoResumen() 
		{
            createBase();
		}

        public ModelExpedienteEstadoResumen(int idTipoExpediente)
        {
            createBase();
            Filtro.TipoExpedienteSelected = idTipoExpediente;
        }
        public ModelExpedienteEstadoResumen(TipoExpedienteEnum tipoExpediente)
        {
            createBase();
            Filtro.TipoExpedienteSelected = (int)tipoExpediente;
        }

        private void createBase()
        {
            LstExpedienteEstadoSemana = new List<ModelExpedienteEstadoSemana>();
            Filtro = new ModelFiltroBase();
            Filtro.TipoEstadoSelected = 1;
            Filtro.NoSemanaFin = 1 + (DateTime.Now.DayOfYear / 7).ToIntegerOrDefault(54);
            Filtro.NoSemanaIni = Filtro.NoSemanaFin - 5;
        }
		#endregion
		
		#region Properties
		public ModelFiltroBase Filtro { get; set; }
		public List<ModelExpedienteEstadoSemana> LstExpedienteEstadoSemana { get; set; }
		#endregion

	}
}
