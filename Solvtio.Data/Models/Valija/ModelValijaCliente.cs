namespace Solvtio.Models
{
    public class ModelValijaCliente
	{
		#region Constructor
		public ModelValijaCliente() 
		{
            ModelClienteOficina = new ModelClienteOficina();
		}

		public ModelValijaCliente(stProc_GetValijaResumenSemanal_Result item)
		{
            ModelClienteOficina = new ModelClienteOficina(item);
            CountEmpresa = item.CountEmpresa ?? 0;
            CountParticular = item.CountParticular ?? 0;
            CountOtro = item.CountOtro ?? 0;
            Deuda = item.Deuda ?? 0;
		}
		#endregion
		
		#region Properties
		public ModelClienteOficina ModelClienteOficina { get; set; }
		public int CountEmpresa { get; set; }
		public int CountParticular { get; set; }
		public int CountOtro { get; set; }
		public decimal Deuda { get; set; }
		#endregion

		#region Properties ReadOnly
		public int Count 
		{
			get 
			{
				return CountEmpresa + CountParticular + CountOtro;
			}
		}

		#endregion
	}
}
