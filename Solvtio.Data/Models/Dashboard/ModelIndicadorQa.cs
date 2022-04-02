using Solvtio.Common;
using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelIndicadorQa
	{
		#region Constructor

		public ModelIndicadorQa()
		{
		}
		public ModelIndicadorQa(string name, int count, TipoExpedienteEnum tipoExpediente, TipoIndicadorQa tipoIndicadorQa)
		{
			IndicadorName = name;
			Count = count;
			TipoExpediente = tipoExpediente;
			TipoIndicadorQa = tipoIndicadorQa;
		}

        public ModelIndicadorQa(int count, TipoIndicadorQa tipoIndicadorQa)
        {
            IndicadorName = tipoIndicadorQa.GetDescription();
            Count = count;
            //TipoExpediente = tipoExpediente;
            TipoIndicadorQa = tipoIndicadorQa;
        }

        //private int getCountInMonth(IQueryable<DateTime> query, DateTime dateMin, DateTime? dateMax = null)
        //{
        //	var dateIni = dateMin.GetDateIniOfMonth();
        //	var dateEnd = dateMax.HasValue ? dateMax.Value.GetDateEndOfMonth() : dateMin.GetDateEndOfMonth();

        //	return query.Count(x => x >= dateIni && x <= dateEnd);
        //}

        #endregion

        #region Properties

        public string IndicadorName { get; set; }

		public int Count { get; set; }
		public TipoExpedienteEnum TipoExpediente { get; set; }
		public TipoIndicadorQa TipoIndicadorQa { get; set; }

        public List<ModelIndicadorQaDetail> LstExpedientes { get; set; }

        #endregion

        #region Properties ReadOnly

        //private int? _countPrevious03ByMonth;
        //public int CountPrevious03ByMonth
        //{
        //	get
        //	{
        //		if (!_countPrevious03ByMonth.HasValue)
        //			_countPrevious03ByMonth = (int)(CountPrevious03 / 3);

        //		return _countPrevious03ByMonth.Value;
        //	}
        //}

        //private int? _countPrevious12ByMonth;
        //public int CountPrevious12ByMonth
        //{
        //	get
        //	{
        //		if (!_countPrevious12ByMonth.HasValue)
        //			_countPrevious12ByMonth = (int)(CountPrevious03 / 12);

        //		return _countPrevious12ByMonth.Value;
        //	}
        //}

        //private int? _percent01;
        //public int Percent01
        //{
        //	get
        //	{
        //		if (!_percent01.HasValue)
        //			_percent01 = CountPrevious01 == 0 ? 0 : (100*CountCurrent / CountPrevious01)-100;

        //		return _percent01.Value;
        //	}
        //}

        //private int? _percent03;
        //public int Percent03
        //{
        //	get
        //	{
        //		if (!_percent03.HasValue)
        //			_percent03 = CountPrevious03ByMonth == 0 ? 0 : (100 * CountCurrent / CountPrevious03ByMonth) - 100;

        //		return _percent03.Value;
        //	}
        //}

        //private int? _percent12;
        //public int Percent12
        //{
        //	get
        //	{
        //		if (!_percent12.HasValue)
        //			_percent12 = CountPrevious12ByMonth == 0 ? 0 : (100 * CountCurrent / CountPrevious12ByMonth) - 100;

        //		return _percent12.Value;
        //	}
        //}

        #endregion
    }

    public class ModelIndicadorQaDetail
    {
        #region Constructor

        public ModelIndicadorQaDetail()
        {
        }
        public ModelIndicadorQaDetail(Expediente exp)
        {
            IdExpediente = exp.IdExpediente;
            NoExpediente = exp.NoExpediente;
        }

        #endregion

        #region Properties

        public int IdExpediente { get; set; }
        public string NoExpediente { get; set; }

        public ExpedienteNota UltimaNota { get; set; }
        public Impulso UltimaImpulso { get; set; }

        #endregion


    }

}
