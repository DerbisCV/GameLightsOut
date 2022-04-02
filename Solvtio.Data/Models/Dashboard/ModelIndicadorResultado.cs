using System;
using System.Collections.Generic;
using System.Linq;
using Solvtio.Common;

namespace Solvtio.Models
{
    public class ModelIndicadorResultado
	{
		#region Constructor

		public ModelIndicadorResultado()
		{
			CreateBase();
		}
		public ModelIndicadorResultado(string name)
		{
			CreateBase();
			IndicadorName = name;
		}
		public ModelIndicadorResultado(string name, int count, int count1, int count3, int count12)
		{
			CreateBase();
			IndicadorName = name;
			Count1 = count;
			Count2 = count1;
			Count3 = count3;
			Count4 = count12;
		}

        public ModelIndicadorResultado(string name, IQueryable<DateTime> queryDate, Period period1, Period period2, Period period3, Period period4)
        {
            CreateBase();
            IndicadorName = name;
            Period1 = period1;
            Period2 = period2;
            Period3 = period3;
            Period4 = period4;

            Count1 = GetCountInMonth(queryDate, Period1);
            Count2 = GetCountInMonth(queryDate, Period2);
            Count3 = GetCountInMonth(queryDate, Period3);
            Count4 = GetCountInMonth(queryDate, Period4);
        }

	    public ModelIndicadorResultado(IndicadorResultadoType type, IQueryable<ModelIndicadorResultadoChild> queryDate, Period period1, Period period2, Period period3, Period period4)
	    {
	        CreateBase();
	        Indicador = type;
	        IndicadorName = type.GetDescription();
	        Period1 = period1;
	        Period2 = period2;
	        Period3 = period3;
	        Period4 = period4;

	        Count1 = GetCountInMonth(queryDate, Period1);
	        Count2 = GetCountInMonth(queryDate, Period2);
	        Count3 = GetCountInMonth(queryDate, Period3);
	        Count4 = GetCountInMonth(queryDate, Period4);

	        foreach (var idOficina in queryDate.Select(x => x.Oficina.IdClienteOficina).Distinct())
	        {
	            var keyValue = new KeyValue
	            {
	                Key = idOficina.ToString(),
	                Value = queryDate.First(x => x.Oficina.IdClienteOficina == idOficina).Oficina.NombreCorto,
	                KeyInt = GetCountInMonth(queryDate.Where(x => x.Oficina.IdClienteOficina == idOficina), Period1)
	            };

	            if (keyValue.KeyInt > 0) LstOficinas.Add(keyValue);
	        }
	    }


        public ModelIndicadorResultado(string name, IQueryable<ModelIndicadorResultadoChild> queryDate, Period period1, Period period2, Period period3, Period period4)
        {
            CreateBase();
            IndicadorName = name;
            Period1 = period1;
            Period2 = period2;
            Period3 = period3;
            Period4 = period4;

            Count1 = GetCountInMonth(queryDate, Period1);
            Count2 = GetCountInMonth(queryDate, Period2);
            Count3 = GetCountInMonth(queryDate, Period3);
            Count4 = GetCountInMonth(queryDate, Period4);

            foreach (int idOficina in queryDate.Select(x => x.Oficina.IdClienteOficina).Distinct())
            {
                var keyValue = new KeyValue
                {
                    Key = idOficina.ToString(),
                    Value = queryDate.First(x => x.Oficina.IdClienteOficina == idOficina).Oficina.NombreCorto,
                    KeyInt = GetCountInMonth(queryDate.Where(x => x.Oficina.IdClienteOficina == idOficina), Period1)
                };

                if (keyValue.KeyInt > 0) LstOficinas.Add(keyValue);
            }
        }

        public ModelIndicadorResultado(string name, TipoIndicadorQa? indicador, IQueryable<ModelIndicadorResultadoChild> queryDate, Period period1, Period period2, Period period3, Period period4)
        {
            CreateBase();
            IndicadorName = name;
            TipoIndicadorQa = indicador;
            Period1 = period1;
            Period2 = period2;
            Period3 = period3;
            Period4 = period4;

            Count1 = GetCountInMonth(queryDate, Period1);
            Count2 = GetCountInMonth(queryDate, Period2);
            Count3 = GetCountInMonth(queryDate, Period3);
            Count4 = GetCountInMonth(queryDate, Period4);

            foreach (int idOficina in queryDate.Select(x => x.Oficina.IdClienteOficina).Distinct())
            {
                var keyValue = new KeyValue
                {
                    Key = idOficina.ToString(),
                    Value = queryDate.First(x => x.Oficina.IdClienteOficina == idOficina).Oficina.NombreCorto,
                    KeyInt = GetCountInMonth(queryDate.Where(x => x.Oficina.IdClienteOficina == idOficina), Period1)
                };

                if (keyValue.KeyInt > 0) LstOficinas.Add(keyValue);
            }
        }


        private void CreateBase()
		{
			LstOficinas = new List<KeyValue>();
		}
		private int GetCountInMonth(IQueryable<DateTime> query, DateTime dateMin, DateTime? dateMax = null)
		{
		    return GetCountInMonth(query, new Period(
                dateMin.GetDateIniOfMonth(),
                dateMax?.GetDateEndOfMonth() ?? dateMin.GetDateEndOfMonth()));

   //         var dateIni = dateMin.GetDateIniOfMonth();
			//var dateEnd = dateMax.HasValue ? dateMax.Value.GetDateEndOfMonth() : dateMin.GetDateEndOfMonth();

			//return query.Count(x => x >= dateIni && x <= dateEnd);
		}
        private int GetCountInMonth(IQueryable<DateTime> query, Period period)
        {
            return query.Count(x => x >= period.FechaInicio.Value && x <= period.FechaFin.Value);
        }

        private int GetCountInMonth(IQueryable<ModelIndicadorResultadoChild> query, DateTime dateMin, DateTime? dateMax = null)
		{
			return GetCountInMonth(query.Select(x => x.Fecha), dateMin, dateMax);
		}
        private int GetCountInMonth(IQueryable<ModelIndicadorResultadoChild> query, Period period)
        {
            return GetCountInMonth(query.Select(x => x.Fecha), period);
        }

        #endregion

        #region Properties

        public string IndicadorName { get; set; }
        public IndicadorResultadoType? Indicador { get; set; }

        public int Count1 { get; set; }
		public int Count2 { get; set; }
		public int Count3 { get; set; }
		public int Count4 { get; set; }

		public List<KeyValue> LstOficinas { get; set; }

        public Period Period1 { get; set; }
        public Period Period2 { get; set; }
        public Period Period3 { get; set; }
        public Period Period4 { get; set; }
        public TipoIndicadorQa? TipoIndicadorQa { get; set; }

        #endregion

        #region Properties ReadOnly

        private int? _countPrevious03ByMonth;
		public int CountPrevious03ByMonth
		{
			get
			{
				if (!_countPrevious03ByMonth.HasValue)
					_countPrevious03ByMonth = (int)(Count3 / 3);

				return _countPrevious03ByMonth.Value;
			}
		}

		private int? _countPrevious12ByMonth;
		public int CountPrevious12ByMonth
		{
			get
			{
				if (!_countPrevious12ByMonth.HasValue)
					_countPrevious12ByMonth = (int)(Count3 / 12);

				return _countPrevious12ByMonth.Value;
			}
		}

		private int? _percent01;
		public int Percent01
		{
			get
			{
				if (!_percent01.HasValue)
					_percent01 = Count2 == 0 ? 0 : (100*Count1 / Count2)-100;

				return _percent01.Value;
			}
		}

		private int? _percent03;
		public int Percent03
		{
			get
			{
				if (!_percent03.HasValue)
					_percent03 = CountPrevious03ByMonth == 0 ? 0 : (100 * Count1 / CountPrevious03ByMonth) - 100;

				return _percent03.Value;
			}
		}

		private int? _percent12;
		public int Percent12
		{
			get
			{
				if (!_percent12.HasValue)
					_percent12 = CountPrevious12ByMonth == 0 ? 0 : (100 * Count1 / CountPrevious12ByMonth) - 100;

				return _percent12.Value;
			}
		}

        #endregion

        #region Methods

	    public int GetPercent(int count1, int count2)
	    {
            return count2 == 0 ? 0 : (100 * count1 / count2) - 100;
        }

	    #endregion
    }

	public class ModelIndicadorResultadoChild
	{
        #region Constructor

	    public ModelIndicadorResultadoChild() { }
        public ModelIndicadorResultadoChild(ModelIndicadorResultadoChild itemBase, List<ModelIndicadorResultadoChild> lstConExpRepetidos)
        {
            Oficina = itemBase.Oficina;
            IdExpediente = itemBase.IdExpediente;
            NoExpediente = itemBase.NoExpediente;
            Fecha = lstConExpRepetidos.First(x => x.IdExpediente == IdExpediente).Fecha;
        }

        public ModelIndicadorResultadoChild(DateTime fecha, Gnr_ClienteOficina oficina)
	    {
	        Fecha = fecha;
	        Oficina = oficina;
	    }

        #endregion

        #region Properties

        public DateTime Fecha { get; set; }
		public Gnr_ClienteOficina Oficina { get; set; }

	    public int IdExpediente { get; set; }
	    public string NoExpediente { get; set; }

    #endregion
}
}
