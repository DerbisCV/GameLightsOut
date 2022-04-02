using System;
using System.Collections.Generic;
using Solvtio.Common;
using System.Linq;

namespace Solvtio.Models
{
    public class ModelCalendarioSemana
    {
        public int NoSemana { get; set; }
        public ModelCalendarioDia Lunes { get; set; }
        public ModelCalendarioDia Martes { get; set; }
        public ModelCalendarioDia Miercoles { get; set; }
        public ModelCalendarioDia Jueves { get; set; }
        public ModelCalendarioDia Viernes { get; set; }

        public ModelCalendarioSemana(int anio, int mes, int indexSemana)
        {
            NoSemana = 1 + indexSemana;
            var day = new DateTime(anio, mes, 1+(7*indexSemana));
        
            for (int i = 0; i < 7; i++)
            {
                var newDate = day.AddDays(i);
                FillDayOfWeek(newDate);
                if (newDate.DayOfWeek == DayOfWeek.Friday)
                    break;
            }
        }

        private void FillDayOfWeek(DateTime newDay)
        {
            switch (newDay.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Lunes = new ModelCalendarioDia(newDay);
                    break;
                case DayOfWeek.Tuesday:
                    Martes = new ModelCalendarioDia(newDay);
                    break;
                case DayOfWeek.Wednesday:
                    Miercoles = new ModelCalendarioDia(newDay);
                    break;
                case DayOfWeek.Thursday:
                    Jueves = new ModelCalendarioDia(newDay);
                    break;
                case DayOfWeek.Friday:
                    Viernes = new ModelCalendarioDia(newDay);
                    break;
                case DayOfWeek.Saturday:
                    break;
                case DayOfWeek.Sunday:
                    break;
                default:
                    break;
            }
        }
    }

    public class ModelCalendarioDia
    {
        #region Constructors
        public ModelCalendarioDia()
        {
			CreateBase();
        }
        public ModelCalendarioDia(DateTime fecha, int senialadas = 0, int titulizadas = 0, int suspendidas = 0, int posesiones = 0)
        {
			CreateBase();
            Fecha = fecha;
            SenialadasCount = senialadas;
            TitulizadasCount = titulizadas;
            SuspendidasCount = suspendidas;
            PosesionesCount = posesiones;
        }
        public ModelCalendarioDia(DateTime fecha, ref int noSemana)
        {
			CreateBase();
            Fecha = fecha;
            NoSemana = noSemana;
            SenialadasCount = 0;
            TitulizadasCount = 0;
            SuspendidasCount = 0;
            PosesionesCount = 0;

            if (fecha.DayOfWeek == DayOfWeek.Sunday) noSemana++;
        }

		private void CreateBase()
		{
			LstEstadoSubasta = new List<ExpedienteSubasta>();
		}
        #endregion

        #region Properties
        public DateTime Fecha { get; set; }
        public int NoSemana { get; set; }
        public int PosesionesCount { get; set; }
        public int SenialadasCount { get; set; }
        public int TitulizadasCount { get; set; }
        public int SuspendidasCount { get; set; }
		public int IvaCount { get; set; }

		public int PujaBoeCount { get; set; }
		public int PujaCierreCount { get; set; }
		public int PujaFinMejoraCount { get; set; }
		public int PujaSolicitudAdjudicacionCount { get; set; }
		public int CelebracionSubastaCount { get; set; }

		public IList<ExpedienteSubasta> LstEstadoSubasta { get; set; }
		

        #endregion

		#region Properties ReadOnly

		private DateTime? _fechaEndOfDay;
		public DateTime FechaEndOfDay
		{
			get
			{
				if (!_fechaEndOfDay.HasValue)
					_fechaEndOfDay = Fecha.GetEndOfDay();

				return _fechaEndOfDay.Value;
			}
		}

		public List<ExpedienteSubasta> LstEstadoSubastaCelebracionSubasta
		{
			get
			{
				return LstEstadoSubasta
					.Where(x => x.FechaCelebracion.HasValue && x.FechaCelebracion.IsDateBetween(Fecha, FechaEndOfDay))
					.ToList();
			}
		}

		//public List<ExpedienteSubasta> LstEstadoSubastaCierrePuja
		//{
		//	get
		//	{
		//	    return LstEstadoSubasta
		//	        .Where(x => x.FechaCelebracion.HasValue && x.FechaCelebracion.IsDateBetween(this.Fecha, this.FechaEndOfDay))
		//	        .ToList();
  //          }
		//}

		public List<ExpedienteSubasta> LstEstadoSubastaFinMejoraPuja
		{
			get
			{
				return LstEstadoSubasta
					.Where(x => x.Expediente.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.SubastaElectronicaFechaFinMejoraPuja.HasValue && x.Expediente.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.SubastaElectronicaFechaFinMejoraPuja.IsDateBetween(Fecha, FechaEndOfDay))
					.ToList();
			}
		}

		public List<ExpedienteSubasta> LstEstadoSubastaSolicitudAdjudicacionLimite
		{
			get
			{
				return LstEstadoSubasta
					.Where(x => x.Expediente.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.PostSubastaFechaSolicitudAdjudicacion.HasValue && x.Expediente.ExpedienteEstadoLast.HipExpedienteEstadoTramitacionSubasta.PostSubastaFechaSolicitudAdjudicacion.IsDateBetween(Fecha, FechaEndOfDay))
					.ToList();
			}
		}

		#endregion
	}
}
