using Solvtio.Common;
using System;
using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelInformeNotasGenerales
    {
        #region Constructors
        public ModelInformeNotasGenerales()
        {
			CreateBase();
        }

		public ModelInformeNotasGenerales(Expediente exp)
		{
			CreateBase();
			Expediente = exp;
        }

		private void CreateBase()
		{
			LstNotasGenerales = new List<ModelNotaGeneral>();
 		}

		#endregion

		#region Properties

        public Expediente Expediente { get; set; }
        public List<ModelNotaGeneral> LstNotasGenerales { get; set; }

		#endregion

		#region Properties ReadOnly

		//private List<ModelHitoProcesal> _lstHitosWithFechaHitoAnterior;
		//public List<ModelHitoProcesal> LstHitosWithFechaHitoAnterior
		//{
		//	get
		//	{
		//		if (_lstHitosWithFechaHitoAnterior == null)
		//			_lstHitosWithFechaHitoAnterior = this.LstNotasGenerales.Where(x => x.FechaHitoAnterior.HasValue).ToList();
		
		//		return _lstHitosWithFechaHitoAnterior;
		//	}
		//}

		//private List<ModelHitoProcesal> _lstEstadosWithFechaHitoAnterior;
		//public List<ModelHitoProcesal> LstEstadosWithFechaHitoAnterior
		//{
		//	get
		//	{
		//		if (_lstEstadosWithFechaHitoAnterior == null)
		//			_lstEstadosWithFechaHitoAnterior = this.LstEstados.Where(x => x.FechaHitoAnterior.HasValue).ToList();

		//		return _lstEstadosWithFechaHitoAnterior;
		//	}
		//}

		//private int? _totalDias;
		//public int TotalDias
		//{
		//	get
		//	{
		//		if (!_totalDias.HasValue)
		//		{
		//			if (this.Expediente == null) return 0;

		//			var estadoRecepcion = this.Expediente.ExpedienteEstadoes.FirstOrDefault(x => x.IdTipoEstado == (int)ExpedienteEstadoTipo.RecepcionExpediente);
		//			var estadoFinalizado = this.Expediente.ExpedienteEstadoes.FirstOrDefault(x => x.IdTipoEstado == (int)ExpedienteEstadoTipo.HipotecarioFinalizado);

		//			var fechaInicio = estadoRecepcion != null ? estadoRecepcion.Fecha : this.Expediente.FechaAlta;
		//			var fechaFin = estadoFinalizado != null ? estadoFinalizado.Fecha : DateTime.Now;

		//			_totalDias = fechaFin.Date.GetDaysBetweenDates(fechaInicio);
		//		}


		//		return _totalDias.Value;
		//	}
		//}

		//private int? _promedioDiasPorHito;
		//public int PromedioDiasPorHito
		//{
		//	get
		//	{
		//		if (!_promedioDiasPorHito.HasValue)
		//		{
		//			if (this.LstHitosWithFechaHitoAnterior.IsEmpty()) return 0;
		//			_promedioDiasPorHito = (int)(this.LstHitosWithFechaHitoAnterior.Average(x => x.CountDays));
		//		}

		//		return _promedioDiasPorHito.Value;
		//	}
		//}

		//private int? _promedioDiasPorEstado;
		//public int PromedioDiasPorEstado
		//{
		//	get
		//	{
		//		if (!_promedioDiasPorEstado.HasValue)
		//		{
		//			if (this.LstEstadosWithFechaHitoAnterior.IsEmpty()) return 0;
		//			_promedioDiasPorEstado = (int)(this.LstEstadosWithFechaHitoAnterior.Average(x => x.CountDays));
		//		}

		//		return _promedioDiasPorEstado.Value;
		//	}
		//}

		#endregion		
	}

    public class ModelNotaGeneral
    {
        public ModelNotaGeneral() {}
        public ModelNotaGeneral(ExpedienteEstado item)
        {
            Titulo = $"Estado: {item.TipoEstadoValue.GetDescription()}";
            Fecha = item.Fecha;
            Descripcion = item.Observacion;
        }
        public ModelNotaGeneral(ExpedienteNota item)
        {
            Titulo = $"Nota: {item.NoteType.GetDescription()}";
            Fecha = item.Fecha;
            Descripcion = item.Nota;
        }
        public ModelNotaGeneral(Impulso item)
        {
            Titulo = $"Impulso: {item.TipoImpulso.GetDescription()}";
            Fecha = item.Fecha;
            Descripcion = item.Observaciones;
        }

        public DateTime Fecha { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
    }
}
