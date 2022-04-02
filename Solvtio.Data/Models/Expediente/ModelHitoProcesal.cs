using Solvtio.Common;
using System;

namespace Solvtio.Models
{
    public class ModelHitoProcesal
    {
        #region Constructors
        public ModelHitoProcesal()
        {
			CreateBase();
        }

		public ModelHitoProcesal(DateTime fecha, string name)
		{
			CreateBase();
            Fecha = fecha;
            Nombre = name;
		}
		public ModelHitoProcesal(DateTime fecha, string name, DateTime? fechaHitoAnterior)
		{
			CreateBase();
            Fecha = fecha;
            Nombre = name;
            FechaHitoAnterior = fechaHitoAnterior;
		}

		private void CreateBase()
		{
			//LstHitos = new List<ModelHitoProcesal>();
 		}
		#endregion

		#region Properties

        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }

		public DateTime? FechaHitoAnterior { get; set; }
		#endregion

		#region Properties ReadOnly
		private int? _countDays;
		public int CountDays
		{
			get
			{
				if (!_countDays.HasValue)
					_countDays = FechaHitoAnterior.HasValue ?
                        Fecha.GetDaysBetweenDates(FechaHitoAnterior.Value) - 1 :
						0;

				return _countDays.Value;
			}
		}
		#endregion	
	}


    public class ModelEvolutivoItem
    {
        //private ModelHitoProcesal x;
        #region Constructors

        public ModelEvolutivoItem()
        {
            CreateBase();
        }

        public ModelEvolutivoItem(DateTime fecha, string name)
        {
            CreateBase();
            Fecha = fecha;
            Nombre = name;
        }
               
        public ModelEvolutivoItem(ModelHitoProcesal item)
        {
            Tipo = "Hito";
            Fecha = item.Fecha;
            Nombre = item.Nombre;
        }
        public ModelEvolutivoItem(ExpedienteNota item)
        {
            Tipo = "Nota";
            Fecha = item.Fecha;
            Nombre = item.Nota;
        }
        public ModelEvolutivoItem(Impulso item)
        {
            Tipo = "Impulso";
            Fecha = item.Fecha;
            Nombre = item.Observaciones;
            TipoEspecifico = item.TipoImpulso.GetDescription();
        }
        public ModelEvolutivoItem(ExpedienteVencimiento item)
        {
            Tipo = "Vencimiento";
            Fecha = item.Fecha;
            Nombre = item.Observaciones;
            TipoEspecifico = item.TipoVencimiento.GetDescription();
            Ejecutado = item.Ejecutado;
            Urgente = item.Urgente;
        }

        private void CreateBase()
        {
            //LstHitos = new List<ModelHitoProcesal>();
        }
        #endregion

        #region Properties

        public string Tipo { get; set; }
        public string TipoEspecifico { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public bool Ejecutado { get; set; }
        public bool Urgente { get; set; }

        //public DateTime? FechaHitoAnterior { get; set; }

        #endregion

        #region Properties ReadOnly
        //private int? _countDays;
        //public int CountDays
        //{
        //    get
        //    {
        //        if (!_countDays.HasValue)
        //            _countDays = FechaHitoAnterior.HasValue ?
        //                Fecha.GetDaysBetweenDates(FechaHitoAnterior.Value) - 1 :
        //                0;

        //        return _countDays.Value;
        //    }
        //}
        #endregion
    }

    public class ModelTramiteJudicial
    {
        #region Constructors

        public ModelTramiteJudicial()
        {
            CreateBase();
        }

        public ModelTramiteJudicial(JuzgadoTramiteJudicial tramiteJudicial)
        {
            CreateBase();
            JuzgadoTramiteJudicial = tramiteJudicial;
        }
        //public ModelTramiteJudicial(DateTime fecha, string name, DateTime? fechaHitoAnterior)
        //{
        //    CreateBase();
        //    Fecha = fecha;
        //    Nombre = name;
        //    FechaHitoAnterior = fechaHitoAnterior;
        //}

        private void CreateBase()
        {
            //LstHitos = new List<ModelTramiteJudicial>();
        }
        #endregion

        #region Properties

        public JuzgadoTramiteJudicial JuzgadoTramiteJudicial { get; set; }

        public DateTime? InicioEstimado { get; set; }
        public DateTime? InicioReal { get; set; }

        public DateTime? FinEstimado { get; set; }
        public DateTime? FinReal { get; set; }

        #endregion

        #region Properties ReadOnly
        //private int? _countDays;
        //public int CountDays
        //{
        //    get
        //    {
        //        if (!_countDays.HasValue)
        //            _countDays = FechaHitoAnterior.HasValue ?
        //                Fecha.GetDaysBetweenDates(FechaHitoAnterior.Value) - 1 :
        //                0;

        //        return _countDays.Value;
        //    }
        //}
        #endregion
    }

}
