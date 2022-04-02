using Solvtio.Common;
using Solvtio;
using System;
using System.Collections.Generic;
using Solvtio.Models.Enumeraciones;

namespace Solvtio.Models
{
    public class ModelFilterBase
	{
		#region Constructors
		public ModelFilterBase()
		{
            CreateBase();
		}
		public ModelFilterBase(int tipoExpediente)
		{
            CreateBase();
            IdTipoExpediente = tipoExpediente;
            TipoExpedienteSelected = (TipoExpedienteEnum)tipoExpediente;
		}
		public ModelFilterBase(TipoExpedienteEnum? tipoExpediente)
		{
            CreateBase();
			if (tipoExpediente.HasValue)
            {
                TipoExpedienteSelected = tipoExpediente.Value;
                IdTipoExpediente = (int)TipoExpedienteSelected;
            }			
		}
		public ModelFilterBase(TipoIndicadorQa? indicador)
		{
            CreateBase();
			TipoIndicadorQaSelected = indicador;
		}

	    public ModelFilterBase(TipoIndicadorQa indicador, TipoExpedienteEnum? tipoExp)
	    {
	        CreateBase();
	        TipoIndicadorQaSelected = indicador;
	        if (!tipoExp.HasValue) return;

	        TipoExpedienteSelected = tipoExp.Value;
	        IdTipoExpediente = (int)tipoExp;
	    }

        public ModelFilterBase(SlaType? hitoProcesalType, TipoExpedienteEnum? tipoExp)
	    {
	        CreateBase();
	        HitoProcesalTypeSelected = hitoProcesalType;
	        if (!tipoExp.HasValue) return;

	        TipoExpedienteSelected = tipoExp.Value;
	        IdTipoExpediente = (int)tipoExp;
	    }
        public ModelFilterBase(TipoExpedienteEnum tipoExpediente, int year, int month, ExpedienteEstadoTipo? expEstado)
        {
            CreateBase();
            TipoExpedienteSelected = tipoExpediente;
            ExpedienteEstadoTipoSelected = expEstado;
            SetDatesToMonth(year, month);
        }
        public ModelFilterBase(int year, int month)
        {
            CreateBase();
            SetDatesToMonth(year, month);
        }
        public ModelFilterBase(TipoExpedienteEnum tipoExpediente, int? year)
        {
            CreateBase();
            TipoExpedienteSelected = tipoExpediente;
            Anio = year;
        }
        public ModelFilterBase(TipoExpedienteEnum tipoExpediente, ExpedienteEstadoTipo? expEstado)
        {
            CreateBase();
            TipoExpedienteSelected = tipoExpediente;
            if (expEstado.HasValue)
            {
                ExpedienteEstadoTipoSelected = expEstado;
                IdTipoEstadoSelected = (int?)expEstado;
            }
        }
        public ModelFilterBase(DateTime? inicio, DateTime? fin)
        {
            CreateBase();
            FechaInicio = inicio;
            FechaFin = fin;
        }

        private void CreateBase()
		{
			TipoExpedienteSelected = TipoExpedienteEnum.Todos;
			Anio = DateTime.Now.Year;
		}
        #endregion

        #region Properties

        public int? IdTipoOtro1 { get; set; }
        public int? IdTipoOtro2 { get; set; }
        public int? IdTipoOtro3 { get; set; }
        public int? IdTipoOtro4 { get; set; }
        public int? IdTipoOtro5 { get; set; }

        public List<int> LstInteger1 { get; set; }
        public List<int> LstInteger2 { get; set; }
        public List<int> LstInteger3 { get; set; }

        public bool? Boolean1 { get; set; }
        public bool? Boolean2 { get; set; }

        public TipoExpedienteEnum TipoExpedienteSelected { get; set; }
		public TipoIndicadorQa? TipoIndicadorQaSelected { get; set; }
        public IndicadorResultadoType? IndicadorResultadoTypeSelected { get; set; }
        public ActionLogType? ActionLogType { get; set; }
	    public SlaType? HitoProcesalTypeSelected { get; set; }
	    public CategoryColor? CategoryColorSelected { get; set; }
        public TipoVencimiento? TipoVencimientoSelected { get; set; }
        public EstadoOportunidad? EstadoOportunidad { get; set; }
        public TipoAprobacion? TipoAprobacion { get; set; }

        public int? IdTipoExpediente { get; set; }
		public int? IdTipoArea { get; set; }
        public int? IdAreaNegocio { get; set; }
        public List<int> LstTipoArea { get; set; }


        public int? IdProcurador { get; set; }
        public int? ClienteSelected { get; set; }
		public int? ClienteOficinaSelected { get; set; }
		public int? IdTipoEstadoSelected { get; set; }
        public int? IdTipoEstadoDistinctOf { get; set; }
        public bool? OnlyActive { get; set; }

        public int? IdTipoInmuebleSelected { get; set; }


        public int? IdUsuario { get; set; }
        public int? IdArea { get; set; }
        public int? IdCartera { get; set; }

        public string UserName { get; set; }

        public int? RowsMaxToTake { get; set; }
        public ExpedienteEstadoTipo? ExpedienteEstadoTipoSelected { get; set; }
        public InmuebleOrigen? InmuebleOrigen { get; set; }
        public TipoEstadoCliente? TipoEstadoCliente { get; set; }
        public TipoEstadoEvaluacionEmpleado? TipoEstadoEvaluacionEmpleado { get; set; }

        public string NoExpedientePartial { get; set; }
		public string NamePartial { get; set; }
		public string NoAutoPartial { get; set; }
		public string ReferenciaExterna { get; set; }
		public string Referencia2 { get; set; }
		public string Grupo { get; set; }

        public IList<int> LstAnios { get; set; }
        public int? Anio { get; set; }
        public int? NoIni { get; set; }
        public int? NoEnd { get; set; }
        public string AnioDesde { get; set; }
        public string AnioHasta { get; set; }
        public string SalarioDesde { get; set; }
        public string SalarioHasta { get; set; }
        public int? Mes { get; set; }
        public bool? Activo { get; set; }

        public ModelAnioMes Desde { get; set; }
        public ModelAnioMes Hasta { get; set; }

        public decimal? ValorDesde { get; set; }
        public decimal? ValorHasta { get; set; }

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
        public TipoCalendarioEstado? TipoCalendarioEstadoSelected { get; set; }
        public TipoExport? Export { get; set; }

		public bool? Pendiente { get; set; }
		public TipoAreaGestion? TipoAreaGestion { get; set; }

        public EstadoTiket? EstadoTiket { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Public Methods

        public void SetDatesToMonth(DateTime date)
        {
            SetDatesToMonth(date.Year, date.Month);
        }

        public void SetDatesToMonth(int year, int month)
        {
            Anio = year;

            FechaInicio = new DateTime(year, month, 1);
            FechaFin = DatesWeeks.GetDateEndOfMonth(year, month);
        }
		#endregion

		#region Private Methods

		#endregion
    }

    public class ModelAnioMes
    {
        public int? Anio { get; set; }
        public int? Mes { get; set; }

        public bool HasValue => Anio.HasValue && Mes.HasValue;
        public DateTime Inicio => new DateTime(Anio.Value, Mes.Value, 1);
        public DateTime Fin => Inicio.AddMonths(1).AddSeconds(-1);
    }
}
