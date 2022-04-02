namespace Solvtio.Models
{
    public class ModelSubastaResumenCliente
    {
		#region Constructors

        public ModelSubastaResumenCliente()
        {
			CreateBase();
			//this.Anio = DateTime.Now.Year;
			//this.Mes = DateTime.Now.Month;

	        //LoadData();
        }

		public ModelSubastaResumenCliente(int idCliente, string name, int senaladas, int suspendidas, int celebradas)
		{
			CreateBase();
            IdCliente = idCliente;
            Cliente = name;
            SubastasSenaladas = senaladas;
            SubastasSuspendidas = suspendidas;
		    SubastasCelebradas = celebradas;
		}

		private void CreateBase()
		{
 			//this.LstAnios = GetListAnios();
		}

		#endregion

		#region Properties
		public int IdCliente { get; set; }
		public string Cliente { get; set; }
		public int SubastasSenaladas { get; set; }
		public int SubastasSuspendidas { get; set; }
        public int SubastasCelebradas { get; set; }

        #endregion

        #region Properties ReadOnly
        //public int SubastasCelebradas
        //{
        //	get
        //	{
        //		return SubastasSenaladas - SubastasSuspendidas;
        //	}
        //}

        private decimal? _subastasSuspendidasPorciento;
		public decimal SubastasSuspendidasPorciento
		{
			get
			{
				if (!_subastasSuspendidasPorciento.HasValue)
					_subastasSuspendidasPorciento = SubastasSenaladas == 0 ? 0 : 100M * SubastasSuspendidas / SubastasSenaladas;

				return _subastasSuspendidasPorciento.Value;
			}
		}

		private decimal? _subastasCelebradasPorciento;
		public decimal SubastasCelebradasPorciento
		{
			get
			{
				if (!_subastasCelebradasPorciento.HasValue)
					_subastasCelebradasPorciento = SubastasSenaladas == 0 ? 0 : 100 - SubastasSuspendidasPorciento;

				return _subastasCelebradasPorciento.Value;
			}
		}
		#endregion


		//public void Refresh()
		//{
		//	#region Si el mes cambia

		//	if (this.MesChange.HasValue)
		//	{
		//		Mes = Mes + MesChange.Value;

		//		if (Mes == 0)
		//		{
		//			Mes = 12;
		//			Anio = Anio - 1;
		//		}
		//		if (Mes == 13)
		//		{
		//			Mes = 1;
		//			Anio = Anio + 1;
		//		}
		//	}

		//	#endregion
		//}

	    public void LoadData()
	    {
		    //Refresh();

			//var date = new DateTime(Anio, Mes, 1);
			//this.Dias = new List<ModelCalendarioDia>();
			//int noSemana = 1;
			//for (int i = 0; i < 31; i++)
			//{
			//	var newDate = date.AddDays(i);
			//	if (newDate.Month == Mes)
			//	{
			//		var dia = new ModelCalendarioDia(date.AddDays(i), ref noSemana);

			//		this.Dias.Add(dia);                    
			//	}
			//}


        }

        //public static int GetWeekOfMonth(DateTime date)
        //{
        //    DateTime beginningOfMonth = new DateTime(date.Year, date.Month, 1);

        //    while (date.Date.AddDays(1).DayOfWeek != CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek)
        //        date = date.AddDays(1);

        //    return (int)Math.Truncate((double)date.Subtract(beginningOfMonth).TotalDays / 7f) + 1;
        //} 


		//public ModelCalendarioDia GetDay(int noSemana, DayOfWeek dayOfWeek)
		//{
		//	var result = this.Dias.FirstOrDefault(x => x.NoSemana == noSemana && x.Fecha.DayOfWeek == dayOfWeek);
		//	return result ?? new ModelCalendarioDia();
		//}

		//public bool ExistDataForWeek(int noSemana)
		//{
		//	return this.Dias.Any(x => x.NoSemana == noSemana && x.Fecha.DayOfWeek != DayOfWeek.Saturday && x.Fecha.DayOfWeek != DayOfWeek.Sunday);
		//}

		//private IList<int> GetListAnios(int cantAnios = 10)
		//{
		//	var result = new List<int>();

		//	int anioInicial = DateTime.Now.Year - (cantAnios / 2);
		//	for (int i = 0; i < cantAnios; i++)
		//	{
		//		result.Add(anioInicial+i);
		//	}

		//	return result;
		//}

    }
}
