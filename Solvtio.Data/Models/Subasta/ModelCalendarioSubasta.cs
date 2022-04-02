using System;
using System.Collections.Generic;
using System.Linq;


namespace Solvtio.Models
{
    public class ModelCalendarioSubasta
	{
		#region Constructors
		public ModelCalendarioSubasta()
        {
            Anio = DateTime.Now.Year;
            Mes = DateTime.Now.Month;

	        LstAnios = GetListAnios();
	        //LoadData();
        }

	    public ModelCalendarioSubasta(DateTime fecha, int countDays)
        {
            FechaInicioSemana = fecha;
			LoadData(fecha, countDays);
        }

		public ModelCalendarioSubasta(int mes, int anio)
		{
            Anio = anio;
            Mes = mes;

			LoadData();
			LstAnios = GetListAnios();
		}
		#endregion

		#region Properties
		public int Anio { get; set; }
        public int Mes { get; set; }

		public DateTime? FechaInicioSemana { get; set; }

        public int? MesChange { get; set; }
        public int Test { get; set; }
        public IList<ModelCalendarioSemana> Semanas { get; set; }
        public IList<ModelCalendarioDia> Dias { get; set; }
		public IList<int> LstAnios { get; set; }

		public IList<ExpedienteSubasta> LstEstadoSubasta { get; set; }
		#endregion

		#region Properties ReadOnly
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
				return Dias == null ? 0 : Dias.Sum(x => x.SenialadasCount);
		    }
	    }
		public int TotalSuspendidas
		{
			get
			{
				return Dias == null ? 0 : Dias.Sum(x => x.SuspendidasCount);
			}
		}
		public int TotalIva
		{
			get
			{
				return Dias == null ? 0 : Dias.Sum(x => x.IvaCount);
			}
		}
		public int TotalTitulizadas
		{
			get
			{
				return Dias == null ? 0 : Dias.Sum(x => x.TitulizadasCount);
			}
		}

		public int TotalPujaBoe
		{
			get { return Dias == null ? 0 : Dias.Sum(x => x.PujaBoeCount); }
		}
		public int TotalPujaCierre
		{
			get { return Dias == null ? 0 : Dias.Sum(x => x.PujaCierreCount); }
		}
		//public int TotalPujaFinMejora
		//{
		//	get { return Dias?.Sum(x => x.PujaFinMejoraCount) ?? 0; }
		//}
		public int TotalPujaSolicitudAdjudicacion
		{
			get { return Dias?.Sum(x => x.PujaSolicitudAdjudicacionCount) ?? 0; }
		}

		public int TotalCelebracionSubasta
		{
			get { return Dias == null ? 0 : Dias.Sum(x => x.CelebracionSubastaCount); }
		}
		#endregion
		
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

		private void LoadData(DateTime date, int countDays)
		{
            Dias = new List<ModelCalendarioDia>();
			int noSemana = 1;
			for (int i = 0; i < countDays; i++)
			{
				//var newDate = date.AddDays(i);
				var dia = new ModelCalendarioDia(date.AddDays(i), ref noSemana);
                Dias.Add(dia);
			}
		}


        public ModelCalendarioDia GetDay(int noSemana, DayOfWeek dayOfWeek)
        {
            var result = Dias.FirstOrDefault(x => x.NoSemana == noSemana && x.Fecha.DayOfWeek == dayOfWeek);
			if (result == null) return new ModelCalendarioDia();

			//result.LstEstadoSubasta = this.LstEstadoSubasta.Where(x => ).ToL
            return result;
        }

        public bool ExistDataForWeek(int noSemana)
        {
            //return this.Dias.Any(x => x.NoSemana == noSemana && x.Fecha.DayOfWeek != DayOfWeek.Saturday && x.Fecha.DayOfWeek != DayOfWeek.Sunday);
			return Dias.Any(x => x.NoSemana == noSemana);
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
