using System;
using System.Collections.Generic;
using System.Linq;

namespace Solvtio.Models
{
    public class ModelSubastaResumenAnual
    {
		#region Constructors
        public ModelSubastaResumenAnual()
        {
			CreateBase();
            Anio = DateTime.Now.Year;
	        
	        //LoadData();
        }

		public ModelSubastaResumenAnual(int anio)
		{
			CreateBase();
            Anio = anio;

			//LoadData();
		}

		private void CreateBase()
		{
            LstAnios = Solvtio.Common.Dates.GetListAnios(3);
		}
		#endregion

		#region Properties
        public int Anio { get; set; }
		public IList<ModelSubastaResumenMes> LstResumenMes { get; set; }
		public IList<ModelSubastaResumenCliente> LstResumenCliente { get; set; }
		public IList<int> LstAnios { get; set; }
		#endregion

		#region Properties ReadOnly
		private int? _subastasSenaladasTotal;
		public int SubastasSenaladasTotal
		{
			get
			{
				if (!_subastasSenaladasTotal.HasValue)
					_subastasSenaladasTotal = LstResumenMes.Sum(x => x.SubastasSenaladas);

				return _subastasSenaladasTotal.Value;
			}
		}

		private decimal? _subastasSuspendidasTotal;
		public decimal SubastasSuspendidasTotal
		{
			get
			{
				if (!_subastasSuspendidasTotal.HasValue)
					_subastasSuspendidasTotal = LstResumenMes.Sum(x => x.SubastasSuspendidas);

				return _subastasSuspendidasTotal.Value;
			}
		}

		private decimal? _subastasCelebradasTotal;
		public decimal SubastasCelebradasTotal
		{
			get
			{
				if (!_subastasCelebradasTotal.HasValue)
					_subastasCelebradasTotal = LstResumenMes.Sum(x => x.SubastasCelebradas);

				return _subastasCelebradasTotal.Value;
			}
		}

		private decimal? _subastasSuspendidasPorciento;
		public decimal SubastasSuspendidasPorciento
		{
			get
			{
				if (!_subastasSuspendidasPorciento.HasValue)
					_subastasSuspendidasPorciento = SubastasSenaladasTotal == 0 ? 0 : 100M * SubastasSuspendidasTotal / SubastasSenaladasTotal;

				return _subastasSuspendidasPorciento.Value;
			}
		}

		private decimal? _subastasCelebradasPorciento;
		public decimal SubastasCelebradasPorciento
		{
			get
			{
				if (!_subastasCelebradasPorciento.HasValue)
					_subastasCelebradasPorciento = SubastasSenaladasTotal == 0 ? 0 : 100M * SubastasCelebradasTotal / SubastasSenaladasTotal;

                return _subastasCelebradasPorciento.Value;
			}
		}

		#endregion

    }
}
