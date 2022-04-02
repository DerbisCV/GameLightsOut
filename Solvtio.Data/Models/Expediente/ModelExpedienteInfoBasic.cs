using System;

namespace Solvtio.Models
{
    public class ModelExpedienteInfoBasic
    {
        #region Constructors
        public ModelExpedienteInfoBasic()
        {
			CreateBase();
        }

		private void CreateBase()
		{
 		}
		#endregion

		#region Properties
        public int IdCliente { get; set; }
		public int IdExpediente { get; set; }
        public string NoExpediente { get; set; }
        public string ReferenciaExterna { get; set; }
        public DateTime FechaAlta { get; set; }
		public string Observaciones { get; set; }
        public string EstadoActualName { get; set; }
		public DateTime EstadoActualFecha { get; set; }
        public string DeudorPrincipalNombre { get; set; }
		public string DeudorPrincipalNoDocumento { get; set; }
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
