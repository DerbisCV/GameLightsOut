using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelValijaResumen
	{
   
		#region Constructor
		public ModelValijaResumen() 
		{
            createBase();
		}

        public ModelValijaResumen(int idTipoExp)
        {
            createBase();
            Filtro.TipoExpedienteSelected = 1;
        }

        private void createBase()
        {
            Filtro = new ModelFiltroBase();
            LstValijaSemana = new List<ModelValijaSemana>();
        }
		#endregion
		
		#region Properties
		public ModelFiltroBase Filtro { get; set; }
		public List<ModelValijaSemana> LstValijaSemana { get; set; }
		#endregion
	}
}
