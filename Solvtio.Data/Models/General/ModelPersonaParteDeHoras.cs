using System;
using System.Collections.Generic;
using System.Linq;

namespace Solvtio.Models
{
    public class ModelPersonaParteDeHoras
    {
        #region Constructors

		public ModelPersonaParteDeHoras() 
        {
            createBase();
        }
        public ModelPersonaParteDeHoras(int idPersona, int year, int month)
        {
            createBase();
            IdPersona = idPersona;
            Anio = year;
            Mes = month;

            LstDateWeek = new List<DateWithWeek>();
            var dateAct = new DateTime(year, month, 1);
            var noWeek = 1;
            do
            {
                LstDateWeek.Add(new DateWithWeek(dateAct, noWeek));
                dateAct = dateAct.AddDays(1);
                if (dateAct.DayOfWeek == DayOfWeek.Monday) noWeek++;
            } while (dateAct.Month == month);
        }

        private void createBase()
        {
            Anio = DateTime.Now.Year;
            Mes = DateTime.Now.Month;


            //Filter = new ModelFilterBase();
        }

        #endregion

        #region Properties
  
        public Gnr_Persona Persona { get; set; }
        public int IdPersona { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }

        public List<DateWithWeek> LstDateWeek { get; set; }

        public List<ExpedienteHora> LstExpedienteHora { get; set; }

        #endregion

        #region Properties Readonly

        public List<int> LstWeeks => LstDateWeek.Select(x => x.NoWeek).Distinct().ToList();

        #endregion

        #region Methods

        public ModelPersonaParteDeHorasOneDay GetModelPersonaParteDeHorasOneDay(int noWeek, DayOfWeek dayOfWeek)
        {
            var item = LstDateWeek.FirstOrDefault(x => x.NoWeek == noWeek && x.Date.DayOfWeek == dayOfWeek);
            if (item == null) return null;

            var result = new ModelPersonaParteDeHorasOneDay()
            {
                Date = item.Date,
                LstExpedienteHora = LstExpedienteHora.Where(x => x.Fecha == item.Date).ToList()
            };

            return result;
        }

        #endregion
    }

    public class ModelPersonaParteDeHorasOneDay
    {
        #region Properties

        public DateTime Date { get; set; }
        public List<ExpedienteHora> LstExpedienteHora { get; set; }

        #endregion
    }
}
