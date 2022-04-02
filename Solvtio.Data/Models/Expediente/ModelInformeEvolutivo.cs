using Solvtio.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solvtio.Models
{
    public class ModelInformeEvolutivo
    {
        #region Constructors
        public ModelInformeEvolutivo()
        {
			CreateBase();
        }

		public ModelInformeEvolutivo(Expediente exp)
		{
			CreateBase();
            Expediente = exp;
        }

		private void CreateBase()
		{
			LstHitos = new List<ModelHitoProcesal>();
			LstEstados = new List<ModelHitoProcesal>();
            LstHitosHip = new List<ModelHitoProcesal>();
            LstModelTramiteJudicial = new List<ModelTramiteJudicial>();
        }
		#endregion

		#region Properties

        public Expediente Expediente { get; set; }
        public List<ModelHitoProcesal> LstHitos { get; set; }
		public List<ModelHitoProcesal> LstEstados { get; set; }

        public List<ModelHitoProcesal> LstHitosHip { get; set; }

        public List<ModelTramiteJudicial> LstModelTramiteJudicial { get; set; }

        #endregion

        #region Properties ReadOnly

        private List<ModelHitoProcesal> _lstHitosWithFechaHitoAnterior;
		public List<ModelHitoProcesal> LstHitosWithFechaHitoAnterior
		{
			get
			{
				if (_lstHitosWithFechaHitoAnterior == null)
					_lstHitosWithFechaHitoAnterior = LstHitos.Where(x => x.FechaHitoAnterior.HasValue).ToList();
		
				return _lstHitosWithFechaHitoAnterior;
			}
		}

		private List<ModelHitoProcesal> _lstEstadosWithFechaHitoAnterior;
		public List<ModelHitoProcesal> LstEstadosWithFechaHitoAnterior
		{
			get
			{
				if (_lstEstadosWithFechaHitoAnterior == null)
					_lstEstadosWithFechaHitoAnterior = LstEstados.Where(x => x.FechaHitoAnterior.HasValue).ToList();

				return _lstEstadosWithFechaHitoAnterior;
			}
		}

		private int? _totalDias;
		public int TotalDias
		{
			get
			{
				if (!_totalDias.HasValue)
				{
					if (Expediente == null) return 0;

					var estadoRecepcion = Expediente.ExpedienteEstadoes.FirstOrDefault(x => x.IdTipoEstado == (int)ExpedienteEstadoTipo.RecepcionExpediente);
					var estadoFinalizado = Expediente.ExpedienteEstadoes.FirstOrDefault(x => x.IdTipoEstado == (int)ExpedienteEstadoTipo.HipotecarioFinalizado);

					var fechaInicio = estadoRecepcion != null ? estadoRecepcion.Fecha : Expediente.FechaAlta;
					var fechaFin = estadoFinalizado != null ? estadoFinalizado.Fecha : DateTime.Now;

					_totalDias = fechaFin.Date.GetDaysBetweenDates(fechaInicio);
				}


				return _totalDias.Value;
			}
		}

		private int? _promedioDiasPorHito;
		public int PromedioDiasPorHito
		{
			get
			{
				if (!_promedioDiasPorHito.HasValue)
				{
					if (LstHitosWithFechaHitoAnterior.IsEmpty()) return 0;
					_promedioDiasPorHito = (int)(LstHitosWithFechaHitoAnterior.Average(x => x.CountDays));
				}

				return _promedioDiasPorHito.Value;
			}
		}

		private int? _promedioDiasPorEstado;
		public int PromedioDiasPorEstado
		{
			get
			{
				if (!_promedioDiasPorEstado.HasValue)
				{
					if (LstEstadosWithFechaHitoAnterior.IsEmpty()) return 0;
					_promedioDiasPorEstado = (int)(LstEstadosWithFechaHitoAnterior.Average(x => x.CountDays));
				}

				return _promedioDiasPorEstado.Value;
			}
		}

		#endregion

		
	}
}
