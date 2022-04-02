using Solvtio.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("PeriodoSemana")]
    public class PeriodoSemana 
    {
        #region Constructors

        public PeriodoSemana()
        {
            CreateBase();
        }
        public PeriodoSemana(int year, int semana)
        {
            CreateBase();
            IdPeriodoSemana = 100*year + semana;
            var day1 = new DateTime(year, 1, 1);
            var dayLunes1 = GetDayOfWeekBefore(DayOfWeek.Monday, day1);
            Inicio = dayLunes1.AddDays(7 * (semana - 1)).Date;
            Fin = Inicio.AddDays(6);
        }

        private DateTime GetDayOfWeekBefore(DayOfWeek dayOfWeek, DateTime dateBase)
        {
            if (dateBase.DayOfWeek == dayOfWeek) return dateBase;
            return GetDayOfWeekBefore(dayOfWeek, dateBase.AddDays(-1));
        }

        private void CreateBase()
        {
            //FechaAlta = DateTime.Now;
            //Activo = true;
        }


        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdPeriodoSemana { get; set; }

        [DataType(DataType.Date)]
        public DateTime Inicio { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fin { get; set; }

        #endregion

        #region Properties virtual ICollection

        public virtual ICollection<DivisionReal> DivisionRealSet { get; set; }
        //public virtual ICollection<Gnr_TipoEstado> TipoEstadoSet { get; set; }
        //public virtual ICollection<ExpedienteVencimiento> ExpedienteVencimientoSet { get; set; }

        #endregion

        #region Properties ReadOnly

        public DateTime Fin2359 => Fin.Date.AddDays(1).AddSeconds(-1);

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion
    }
}

