using System.Collections.Generic;
using System.Linq;

namespace Solvtio.Models
{
    public class ModelExpedienteEstadoSemana
	{
		#region Constructor
		public ModelExpedienteEstadoSemana() 
		{
            LstExpedienteEstadoCliente = new List<ModelExpedienteEstadoCliente>();
		}

		public ModelExpedienteEstadoSemana(stProc_GetExpedienteEstadoResumenSemanal_Result item)
		{
            LstExpedienteEstadoCliente = new List<ModelExpedienteEstadoCliente>();
            NoSemana = item.WeekNumber ?? 0;
		}
		#endregion
		
		#region Properties
		public int NoSemana { get; set; }
		public List<ModelExpedienteEstadoCliente> LstExpedienteEstadoCliente { get; set; }
		#endregion

		#region Properties ReadOnly
		private int? _countInState;
		public int CountInState
		{
			get
			{
				if (!_countInState.HasValue)
					_countInState = LstExpedienteEstadoCliente.Sum(x => x.CountInState);

				return _countInState.Value;
			}
		}

		private int? _countIn;
		public int CountIn
		{
			get
			{
				if (!_countIn.HasValue)
					_countIn = LstExpedienteEstadoCliente.Sum(x => x.CountIn);

				return _countIn.Value;
			}
		}

		private int? _countOut;
		public int CountOut
		{
			get
			{
				if (!_countOut.HasValue)
					_countOut = LstExpedienteEstadoCliente.Sum(x => x.CountOut);

				return _countOut.Value;
			}
		}
		#endregion
	}
}
