using Solvtio.Common;
using Solvtio.Models.Model;
using System.Collections.Generic;
using System.Linq;

namespace Solvtio.Models
{
    public class ModelExpedientesAll
	{
		#region Constructors

		public ModelExpedientesAll() 
		{
			CreateBase();
		}
		public ModelExpedientesAll(ModelFilterBase filter)
        {
			CreateBase();
            Filter = filter;
        }

		private void CreateBase()
		{
			Filter = new ModelFilterBase();
			LstExpedientes = new List<Expediente>();
            LstExpTotalesNotEndByLayer = new List<ExpTotales>();
            LstExpTotalesNotEndByState = new List<ExpTotales>();
            LstExpTotalesNotEndByClient = new List<ExpTotales>();
            LstExpTotalesByState = new List<ExpTotales>();
        }

		#endregion

		#region Properties

		public ModelFilterBase Filter { get; set; }
        public List<Expediente> LstExpedientes { get; set; }
	    public List<ExpedienteNegociacion> LstExpedienteNegociacion { get; set; }
        public List<ExpedienteOrdinarioCs> LstExpedienteOrdinarioCs { get; set; }
        public List<Procura> LstProcura { get; set; }

        public List<Juzgado> LstJuzgado { get; set; }

        public List<Hip_Inmueble> LstInmueble { get; set; }
        public List<ExpedienteContrato> LstExpedienteContrato { get; set; }
        public List<ExpedienteCobro> LstExpedienteCobro { get; set; }
        public List<ExpedienteGastoSuplido> LstExpedienteGastoSuplido { get; set; }

        public List<Mediacion> LstMediacion { get; set; }
        public List<ExpTotales> LstExpTotalesNotEndByLayer { get; set; }
        public List<ExpTotales> LstExpTotalesNotEndByState { get; set; }
        public List<ExpTotales> LstExpTotalesNotEndByClient { get; set; }
        public List<ExpTotales> LstExpTotalesByState { get; set; }
        public List<DivisionReal> LstDivisionReal { get; set; }
        public List<FichaNegocio> LstFichaNegocio { get; set; }
        public List<JuzgadoTramiteJudicial> LstJuzgadoTramiteJudicial { get; set; }

        public List<KeyValue> LstKeyValue1 { get; set; }
        public List<KeyValue> LstKeyValue2 { get; set; }

        public List<ModelResumenAnualCount> LstModelResumenAnualCount { get; set; }

        public List<ModelSqlDeudoresMultiProcedimiento> LstPersonas { get; set; }

        public List<ModelExpedientesJuzgadoTiempoFinHip> LstModelExpedientesJuzgadoTiempoFinHip { get; set; }

        #endregion

        #region Properties ReadOnly

        public bool MostrarDecretoSubasta => Filter.TipoIndicadorQaSelected.HasValue && (
            Filter.TipoIndicadorQaSelected == TipoIndicadorQa.HipotecarioDecretoConvocatoriaSubasta 
            || Filter.TipoIndicadorQaSelected == TipoIndicadorQa.HipotecarioAlarmaDecretoConvocatoria);

	    public bool MostrarAdjudicacion => Filter.TipoIndicadorQaSelected.HasValue && (
            Filter.TipoIndicadorQaSelected == TipoIndicadorQa.HipotecarioPendienteAdjudicacion
            || Filter.TipoIndicadorQaSelected == TipoIndicadorQa.HipotecarioAlarmaDecretoAdjudicacion);

        //public bool MostrarOtrosParaEstadoImpulso => Filter.TipoIndicadorQaSelected.HasValue && (
        //                                       Filter.TipoIndicadorQaSelected == TipoIndicadorQa.HipotecarioIncidenciaDecretoAjdudicacion
        //                                          || Filter.TipoIndicadorQaSelected == TipoIndicadorQa.HipotecarioIncidenciaDecretoAjdudicacion);
	    public bool MostrarOtrosParaEstadoImpulso => Filter.TipoIndicadorQaSelected.HasValue;

        public bool MostrarEstadoImpulso => MostrarDecretoSubasta || MostrarAdjudicacion || MostrarOtrosParaEstadoImpulso;

        public List<Expediente> LstExpedientesHip => LstExpedientes.Where(x => x.TipoExpediente == TipoExpedienteEnum.Hipotecario).ToList();
        public List<Expediente> LstExpedientesOCs => LstExpedientes.Where(x => x.TipoExpediente == TipoExpedienteEnum.OrdinarioCs).ToList();
        public List<Expediente> LstExpedientesOCsAT => LstExpedientes.Where(x => x.TipoExpediente == TipoExpedienteEnum.OrdinarioCs && x.ExpedienteEstadoes.Any(y => y.IdTipoEstado == 1513)).ToList();
        public List<Expediente> LstExpedientesOCsAP => LstExpedientes.Where(x => x.TipoExpediente == TipoExpedienteEnum.OrdinarioCs && x.ExpedienteEstadoes.Any(y => y.IdTipoEstado == 1514)).ToList();
        public List<Expediente> LstExpedientesOCsAc => LstExpedientes.Where(x => x.TipoExpediente == TipoExpedienteEnum.OrdinarioCs && x.ExpedienteEstadoes.All(y => y.IdTipoEstado != 1513 && y.IdTipoEstado != 1514)).ToList();

        #endregion

        #region Methods

        public void RefreshModelResumenAnualCount() 
        {
            LstModelResumenAnualCount = new List<ModelResumenAnualCount>();
            var lstYear = LstExpedientes.Select(x => x.FinPrevisto.Value.Year).Distinct().OrderBy(x => x).ToList();
            foreach (var year in lstYear)
            {
                var query = LstExpedientes.Where(x => x.FinPrevisto.Value.Year == year);

                var modelResumenAnualCount = new ModelResumenAnualCount();
                modelResumenAnualCount.Anio = year;
                modelResumenAnualCount.Mes01 = query.Count(x => x.FinPrevisto.Value.Month == 1);
                modelResumenAnualCount.Mes02 = query.Count(x => x.FinPrevisto.Value.Month == 2);
                modelResumenAnualCount.Mes03 = query.Count(x => x.FinPrevisto.Value.Month == 3);
                modelResumenAnualCount.Mes04 = query.Count(x => x.FinPrevisto.Value.Month == 4);
                modelResumenAnualCount.Mes05 = query.Count(x => x.FinPrevisto.Value.Month == 5);
                modelResumenAnualCount.Mes06 = query.Count(x => x.FinPrevisto.Value.Month == 6);
                modelResumenAnualCount.Mes07 = query.Count(x => x.FinPrevisto.Value.Month == 7);
                modelResumenAnualCount.Mes08 = query.Count(x => x.FinPrevisto.Value.Month == 8);
                modelResumenAnualCount.Mes09 = query.Count(x => x.FinPrevisto.Value.Month == 9);
                modelResumenAnualCount.Mes10 = query.Count(x => x.FinPrevisto.Value.Month == 10);
                modelResumenAnualCount.Mes11 = query.Count(x => x.FinPrevisto.Value.Month == 11);
                modelResumenAnualCount.Mes12 = query.Count(x => x.FinPrevisto.Value.Month == 12);

                LstModelResumenAnualCount.Add(modelResumenAnualCount);
            }
        }

        #endregion
    }

    public class ExpTotales
    {
        public Gnr_Persona Persona { get; set; }
        public Gnr_Cliente Cliente { get; set; }
        public Gnr_TipoEstado TipoEstado { get; set; }

        public int? TotalAlq { get; set; }
        public int? TotalCon { get; set; }
        public int? TotalEjc { get; set; }
        public int? TotalHip { get; set; }
        public int? TotalCs { get; set; }
        public int? TotalOrd { get; set; }
        public int? TotalJv { get; set; }
        public int? TotalSan { get; set; }
        public int? TotalMn { get; set; }
        public int? TotalCm { get; set; }
        public int? TotalTpa { get; set; }
        public int? TotalEjcAlq { get; set; }

        public int Total => 
            (TotalAlq ?? 0)
            + (TotalCon ?? 0)
            + (TotalEjc ?? 0)
            + (TotalHip ?? 0)
            + (TotalCs ?? 0)
            + (TotalOrd ?? 0)
            + (TotalJv ?? 0)
            + (TotalSan ?? 0)
            + (TotalMn ?? 0)
            + (TotalCm ?? 0)
            + (TotalTpa ?? 0)
            + (TotalEjcAlq ?? 0);

    }

    public class ModelResumenAnualCount
    {
        public int Anio { get; set; }

        public int Mes01 { get; set; }
        public int Mes02 { get; set; }
        public int Mes03 { get; set; }
        public int Mes04 { get; set; }
        public int Mes05 { get; set; }
        public int Mes06 { get; set; }
        public int Mes07 { get; set; }
        public int Mes08 { get; set; }
        public int Mes09 { get; set; }
        public int Mes10 { get; set; }
        public int Mes11 { get; set; }
        public int Mes12 { get; set; }

        public int Total => Mes01 + Mes02 + Mes03 + Mes04 + Mes05 + Mes06 + Mes07 + Mes08 + Mes09 + Mes10 + Mes11 + Mes12;
    }

}
