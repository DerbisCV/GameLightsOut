using System;
using System.Collections.Generic;
using System.Linq;

namespace Solvtio.Models
{
    public class ModelCalendarioDiaAll //: ModelCalendarioDiaBase, IModelCalendarioDiaBase
    {
        #region Constructors

        public ModelCalendarioDiaAll()
        {
        }
        public ModelCalendarioDiaAll(DateTime fecha, int senialadas = 0, int titulizadas = 0, int suspendidas = 0, int posesiones = 0)
        {
            Fecha = fecha;
            //SenialadasCount = senialadas;
            //TitulizadasCount = titulizadas;
            //SuspendidasCount = suspendidas;
            //PosesionesCount = posesiones;
        }
        public ModelCalendarioDiaAll(DateTime fecha, ref int noSemana)
        {
            Fecha = fecha;
            NoSemana = noSemana;
            //SenialadasCount = 0;
            //TitulizadasCount = 0;
            //SuspendidasCount = 0;
            //PosesionesCount = 0;

            if (fecha.DayOfWeek == DayOfWeek.Sunday) noSemana++;
        }

        public ModelCalendarioDiaAll(DateTime? fecha, List<ExpedienteVista> lstExpedienteVistaAll)
        {
            if (!fecha.HasValue) return;

            Fecha = fecha.Value;
            LstExpedienteVista = lstExpedienteVistaAll.Where(x => 
                x.Fecha.Day == Fecha.Day
                && x.Fecha.Month == Fecha.Month
                && x.Fecha.Year == Fecha.Year
                ).ToList();
        }

        #endregion

        #region Properties

        public DateTime Fecha { get; set; }
        public int NoSemana { get; set; }
        public int CountTotal { get; set; }

		public string Grupo { get; set; }

        public ModelCalendarioDiaVistas ModelCalendarioDiaVistas { get; set; }
		public ModelCalendarioDiaOpposition ModelCalendarioDiaLanzamiento { get; set; }
		public List<ExpedienteVista> LstExpedienteVista { get; set; }

        public List<Hip_ExpedienteEstadoAdjudicacionVencimiento> LstHipAdjudicacionVencimiento { get; set; }
        public List<ExpedienteVencimiento> LstExpedienteVencimiento { get; set; }

        public List<ModelCalendarioDiaItem> LstModelCalendarioDiaItem { get; set; }
        public List<Tarea> LstTarea { get; set; }
        #endregion

        #region Properties Readonly

        //private List<ModelVistaResumen> _lstModelVistaResumen;
        //public List<ModelVistaResumen> LstModelVistaResumen
        //{
        //	get
        //	{
        //		if (_lstModelVistaResumen == null)
        //		{
        //			List<ModelVistaResumen> tmpList = new List<ModelVistaResumen>();

        //			var qList = this.ModelCalendarioDiaVistas.LstModelVistaResumen
        //				.Select(x => x.ModelCalendarioDiaVistas)
        //				//.Select(x => new ModelVistaResumen(x..Clasification, x.Count))
        //				.ToList();

        //			_lstModelVistaResumen = new List<ModelVistaResumen>();
        //			//foreach (var modelDiaVista in qList)
        //			//{

        //			//}
        //			//	foreach (var clasificacion in modelDiaVista.LstModelVistaResumen.Select(x => x.Clasification).Distinct())
        //			//	{
        //			//		var vistaResumen = new ModelVistaResumen(clasificacion, qList.Where(x => x.Clasification == clasificacion).Sum(x => x.Count));
        //			//		_lstModelVistaResumen.Add(vistaResumen);
        //			//	}

        //			//this.Dias.Select(d => new (d.LstModelVistaResumen
        //			////_lstModelVistaResumen = this.CountTotal - this.CountWithOposition;
        //		}

        //		return _lstModelVistaResumen;
        //	}
        //}


        //private int? _countWithOutOposition;
        //public int CountWithOutOposition
        //{
        //    get
        //    {
        //        if (!_countWithOutOposition.HasValue)
        //            _countWithOutOposition = this.CountTotal - this.CountWithOposition;

        //        return _countWithOutOposition.Value;
        //    }
        //}
        #endregion

    }
}
