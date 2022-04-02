using System;

namespace Solvtio.Models
{
    public class ModelCalendarioDiaItem //: ModelCalendarioDiaBase, IModelCalendarioDiaBase
    {
        #region Constructors

        public ModelCalendarioDiaItem()
        {
        }
        public ModelCalendarioDiaItem(DateTime fecha, int idExpediente, int idExpedienteEstado)
        {
            Fecha = fecha;
            IdExpediente = idExpediente;
            IdExpedienteEstado = idExpedienteEstado;
        }
        public ModelCalendarioDiaItem(Hip_ExpedienteEstadoSubasta estadoSubasta)
        {
            if (estadoSubasta.FechaSolicitudAdjudicacionLimite != null) Fecha = estadoSubasta.FechaSolicitudAdjudicacionLimite.Value;
            IdExpediente = estadoSubasta.ExpedienteEstado.IdExpediente;
            IdExpedienteEstado = estadoSubasta.ExpedienteEstadoId;
            Titulo = estadoSubasta.ExpedienteEstado.Expediente.NoExpediente;
        }
        public ModelCalendarioDiaItem(DateTime fecha, ref int noSemana)
        {
            Fecha = fecha;
            NoSemana = noSemana;
            if (fecha.DayOfWeek == DayOfWeek.Sunday) noSemana++;
        }

        #endregion

        #region Properties
        public DateTime Fecha { get; set; }
        public int NoSemana { get; set; }
        public int IdExpediente { get; set; }
        public int? IdExpedienteEstado { get; set; }

        public string Titulo { get; set; }

        //      public ModelCalendarioDiaVistas ModelCalendarioDiaVistas { get; set; }
        //public ModelCalendarioDiaOpposition ModelCalendarioDiaLanzamiento { get; set; }
        //public List<ExpedienteVista> LstExpedienteVista { get; set; }

        //      public List<Hip_ExpedienteEstadoAdjudicacionVencimiento> LstHipAdjudicacionVencimiento { get; set; }

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
