using System;
using System.Collections.Generic;
using System.Linq;

namespace Solvtio.Models
{
    public class ModelCalendarioAdjudicacion
    {
         public ModelCalendarioAdjudicacion()
        {
            Anio = DateTime.Now.Year;
            Mes = DateTime.Now.Month;

	        LstAnios = GetListAnios();
	        //LoadData();
        }

	    public ModelCalendarioAdjudicacion(DateTime fecha)
        {
            Anio = fecha.Year;
            Mes = fecha.Month;

            LoadData();
        }
		public ModelCalendarioAdjudicacion(int mes, int anio)
		{
            Anio = anio;
            Mes = mes;

			LoadData();
			LstAnios = GetListAnios();
		}

        public int Anio { get; set; }
        public int Mes { get; set; }
        public int? MesChange { get; set; }
        public int? Test { get; set; }
        public IList<ModelCalendarioSemana> Semanas { get; set; }
        public IList<ModelCalendarioDia> Dias { get; set; }
		public IList<int> LstAnios { get; set; }
        private string _mesNombre;
        public string MesNombre
        {
            get
            {
                    //if (string.IsNullOrWhiteSpace(_mesNombre))
                    //{
                        switch (Mes)
                        {
                            case 1:
                                _mesNombre = "Enero";
                                break;
                            case 2:
                                _mesNombre = "Febrero";
                                break;
                            case 3:
                                _mesNombre = "Marzo";
                                break;
                            case 4:
                                _mesNombre = "Abril";
                                break;
                            case 5:
                                _mesNombre = "Mayo";
                                break;
                            case 6:
                                _mesNombre = "Junio";
                                break;
                            case 7:
                                _mesNombre = "Julio";
                                break;
                            case 8:
                                _mesNombre = "Agosto";
                                break;
                            case 9:
                                _mesNombre = "Septiembre";
                                break;
                            case 10:
                                _mesNombre = "Octubre";
                                break;
                            case 11:
                                _mesNombre = "Noviembre";
                                break;
                            case 12:
                                _mesNombre = "Diciembre";
                                break;
                            default:
                                _mesNombre = "Indefinido";
                                break;
                        }
                    //}
                        return _mesNombre;
            }
        }

		public int TotalSenialadas
	    {
		    get
		    {
				//return this.Dias == null ? 0 : this.Dias.Sum(x => x.SenialadasCount);
                return 0;
		    }
	    }

        public int TotalPosesiones
        {
            get
            {
                return Dias == null ? 0 : Dias.Sum(x => x.PosesionesCount);
            }
        }
		public int TotalSuspendidas
		{
			get
			{
				//return this.Dias == null ? 0 : this.Dias.Sum(x => x.SuspendidasCount);
                return 0;
			}
		}
		public int TotalIva
		{
			get
			{
				//return this.Dias == null ? 0 : this.Dias.Sum(x => x.IvaCount);
                return 0;
			}
		}
		public int TotalTitulizadas
		{
			get
			{
				//return this.Dias == null ? 0 : this.Dias.Sum(x => x.TitulizadasCount);
                return 0;
			}
		}

	    public void Refresh()
	    {
			#region Si el mes cambia

			if (MesChange.HasValue)
			{
				Mes = Mes + MesChange.Value;

				if (Mes == 0)
				{
					Mes = 12;
					Anio = Anio - 1;
				}
				if (Mes == 13)
				{
					Mes = 1;
					Anio = Anio + 1;
				}
			}

			#endregion
	    }

	    public void LoadData()
	    {
		    Refresh();

            var date = new DateTime(Anio, Mes, 1);
            Dias = new List<ModelCalendarioDia>();
            int noSemana = 1;
            for (int i = 0; i < 31; i++)
            {
                var newDate = date.AddDays(i);
                if (newDate.Month == Mes)
                {
                    var dia = new ModelCalendarioDia(date.AddDays(i), ref noSemana);

                    Dias.Add(dia);                    
                }
            }


        }

        //public static int GetWeekOfMonth(DateTime date)
        //{
        //    DateTime beginningOfMonth = new DateTime(date.Year, date.Month, 1);

        //    while (date.Date.AddDays(1).DayOfWeek != CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek)
        //        date = date.AddDays(1);

        //    return (int)Math.Truncate((double)date.Subtract(beginningOfMonth).TotalDays / 7f) + 1;
        //} 


        public ModelCalendarioDia GetDay(int noSemana, DayOfWeek dayOfWeek)
        {
            var result = Dias.FirstOrDefault(x => x.NoSemana == noSemana && x.Fecha.DayOfWeek == dayOfWeek);
            return result ?? new ModelCalendarioDia();
        }

        public bool ExistDataForWeek(int noSemana)
        {
            return Dias.Any(x => x.NoSemana == noSemana && x.Fecha.DayOfWeek != DayOfWeek.Saturday && x.Fecha.DayOfWeek != DayOfWeek.Sunday);
        }
        
        private IList<int> GetListAnios(int cantAnios = 10)
		{
			var result = new List<int>();

			int anioInicial = DateTime.Now.Year - (cantAnios / 2);
			for (int i = 0; i < cantAnios; i++)
			{
				result.Add(anioInicial+i);
			}

			return result;
		}
        
    }
}
