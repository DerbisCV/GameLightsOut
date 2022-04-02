using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solvtio.Common
{
    public class ModelMoney
    {
        #region Constructor
        public ModelMoney(decimal? value, string moneda = "€") 
        {
            this.DecimalValue = value ?? 0;
            this.Importe = value ?? 0;
            this.Moneda = moneda;
        }
		public ModelMoney()
		{
			this.Moneda = "€";
		}
        #endregion

        #region Properties
        private decimal DecimalValue { get; set; }
        public decimal Importe { get; set; }
        public string Moneda { get; set; }
        #endregion

        #region Properties ReadOnly
        public override string ToString()
        {
            return String.Format("{0:C}", this.Importe);
        }

        //private string Importe;
        //public int SubastasSenaladasTotal
        //{
        //    get
        //    {
        //        if (!_subastasSenaladasTotal.HasValue)
        //            _subastasSenaladasTotal = this.LstResumenMes.Sum(x => x.SubastasSenaladas);

        //        return _subastasSenaladasTotal.Value;
        //    }
        //}
        //@String.Format("{0:C}", infoTipoEstado.DeudaFinal)
        #endregion

        
    }
}
