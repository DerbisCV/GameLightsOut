namespace Solvtio.Models
{
    public class ModelExpedienteEstadoCliente
	{
		#region Constructor
		public ModelExpedienteEstadoCliente() 
		{
            ModelClienteOficina = new ModelClienteOficina();
		}

		public ModelExpedienteEstadoCliente(stProc_GetExpedienteEstadoResumenSemanal_Result item)
		{
            ModelClienteOficina = new ModelClienteOficina(item);
            CountInState = item.CountInState ?? 0;
            CountIn = item.CountIn ?? 0;
            CountOut = item.CountOut ?? 0;
		} 
		#endregion
		
		#region Properties
		public ModelClienteOficina ModelClienteOficina { get; set; }
		public int CountInState { get; set; }
		public int CountIn { get; set; }
		public int CountOut { get; set; }
		#endregion

		#region Properties ReadOnly
		//public int Count 
		//{
		//	get 
		//	{
		//		return CountIn + CountOut;
		//	}
		//}

		#endregion
	}
}
