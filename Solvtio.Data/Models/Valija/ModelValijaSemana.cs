using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelValijaSemana
	{
		#region Constructor
		public ModelValijaSemana() 
		{
            LstValijaCliente = new List<ModelValijaCliente>();
		}

		public ModelValijaSemana(stProc_GetValijaResumenSemanal_Result item)
		{
            LstValijaCliente = new List<ModelValijaCliente>();
            NoSemana = item.NoSemana ?? 0;
		}
		#endregion
		
		#region Properties
		public int NoSemana { get; set; }
		public List<ModelValijaCliente> LstValijaCliente { get; set; }
		#endregion
	}
}
