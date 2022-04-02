using Solvtio.Common;
using System;

namespace Solvtio.Models
{
    public class ModelFilterBaseOld
    {
        #region Constructors

        public ModelFilterBaseOld() { }
        public ModelFilterBaseOld(int? idTipo1, DateTime? fechaInicio = null, DateTime? fechaFin = null) 
        {
            IdTipo1 = idTipo1;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

        #endregion

        #region Properties

        public DateTime? FechaInicio { get; set; }

        public DateTime? _fechaFin;
        public DateTime? FechaFin
        {
            get
            {
                return _fechaFin;
            }
            set
            {
                _fechaFin = value.HasValue ? value.Value.GetEndOfDay() : value;
            }
        }

        public int? IdTipo1 { get; set; }

        #endregion



    }
}
