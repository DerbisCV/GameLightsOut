using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelExpedientesByCliente
    {
        #region Constructors
        public ModelExpedientesByCliente()
        {
			CreateBase();

        }
		public ModelExpedientesByCliente(int idCliente)
		{
			CreateBase();
            Filtro.IdCliente = idCliente;
		}

		private void CreateBase()
		{
            Filtro = new ModelFiltroBase();
            LstExpedientes = new List<ModelExpedienteInfoBasic>();
 		}
		#endregion

		#region Properties
        public ModelFiltroBase Filtro { get; set; }
        //public int IdCliente { get; set; }
 
        public IList<ModelExpedienteInfoBasic> LstExpedientes { get; set; }
		public Gnr_Cliente Gnr_Cliente { get; set; }
        //public IList<ModelSubastaResumenCliente> LstResumenCliente { get; set; }

		#endregion

		#region Properties ReadOnly
        //private int? _subastasSenaladasTotal;
        //public int SubastasSenaladasTotal
        //{
        //    get
        //    {
        //        if (!_subastasSenaladasTotal.HasValue)
        //            _subastasSenaladasTotal = this.LstResumenMes.Sum(x => x.SubastasSenaladas);

        //        return _subastasSenaladasTotal.Value;
        //    }
        //}
		#endregion

		
	}
}
