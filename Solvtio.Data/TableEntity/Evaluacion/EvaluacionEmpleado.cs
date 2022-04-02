using Solvtio.Models.Common;
using Solvtio.Models.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Solvtio.Models
{
    [Table("EvaluacionEmpleado")]
    public class EvaluacionEmpleado : Auditable
    {
        #region Constructors

        public EvaluacionEmpleado() { }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEvaluacionEmpleado { get; set; }

        public int IdEmpleado { get; set; }
        [ForeignKey("IdEmpleado")]
        public virtual Usuario Empleado { get; set; }

        public int? IdEvaluador { get; set; }
        [ForeignKey("IdEvaluador")]
        public virtual Usuario Evaluador { get; set; }

        public string PeriodoEvaluacion { get; set; }

        public NotasEvaluacion EvaluadorNotas { get; set; }
        public NotasEvaluacion EvaluadoNotas { get; set; }

        public TipoRiesgoFuga? RiesgoFuga { get; set; }

        public TipoEstadoEvaluacionEmpleado Estado { get; set; }


        public TipoResultadoObjetivo? ObjetivoEvaluacion { get; set; }
        public TipoResultadoObjetivo? ObjetivoAutoEvaluacion { get; set; }



        public int? IdSucesorEmergencia1 { get; set; }
        [ForeignKey("IdSucesorEmergencia1")]
        public virtual Usuario SucesorEmergencia1 { get; set; }

        public int? IdSucesorEmergencia2 { get; set; }
        [ForeignKey("IdSucesorEmergencia2")]
        public virtual Usuario SucesorEmergencia2 { get; set; }

        public int? IdSucesor1 { get; set; }
        [ForeignKey("IdSucesor1")]
        public virtual Usuario Sucesor1 { get; set; }

        public int? IdSucesor2 { get; set; }
        [ForeignKey("IdSucesor2")]
        public virtual Usuario Sucesor2 { get; set; }


        public int? IdSucesorEmergenciaAutoEvaluacion1 { get; set; }
        public int? IdSucesorEmergenciaAutoEvaluacion2 { get; set; }
        public int? IdSucesorAutoEvaluacion1 { get; set; }
        public int? IdSucesorAutoEvaluacion2 { get; set; }

        #endregion

        #region Properties One 2 Many

        public virtual ICollection<EvaluacionEmpleadoObjetivo> EvaluacionEmpleadoObjetivoSet { get; set; }
        public virtual ICollection<EvaluacionEmpleadoCompetencia> EvaluacionEmpleadoCompetenciaSet { get; set; }

        #endregion

        #region Properties Readonly

        public override bool IsNew => IdEvaluacionEmpleado < 1;

        public int TotalPuntuacionEvaluacion => EvaluacionEmpleadoCompetenciaSet.Sum(x => x.PuntuacionEvaluacion);
        public int TotalPuntuacionAutoEvaluacion => EvaluacionEmpleadoCompetenciaSet.Sum(x => x.PuntuacionAutoEvaluacion);

        #endregion

        [NotMapped]
        public bool Finalizar { get; set; }

        #region Methods

        internal void RefreshAutoEvaluacion(EvaluacionEmpleado model)
        {
            PeriodoEvaluacion = model.PeriodoEvaluacion;
            EvaluadoNotas.ObservacionesGenerales = model.EvaluadoNotas?.ObservacionesGenerales;
            ObjetivoAutoEvaluacion = model.ObjetivoAutoEvaluacion;

            IdSucesorEmergenciaAutoEvaluacion1 = model.IdSucesorEmergenciaAutoEvaluacion1;
            IdSucesorEmergenciaAutoEvaluacion2 = model.IdSucesorEmergenciaAutoEvaluacion2;
            IdSucesorAutoEvaluacion1 = model.IdSucesorAutoEvaluacion1;
            IdSucesorAutoEvaluacion2 = model.IdSucesorAutoEvaluacion2;

            if (model.Finalizar && Estado < TipoEstadoEvaluacionEmpleado.AutoEvaluacionFinalizada)
                Estado = TipoEstadoEvaluacionEmpleado.AutoEvaluacionFinalizada;
            else if (Estado < TipoEstadoEvaluacionEmpleado.AutoEvaluacionIniciada)
                Estado = TipoEstadoEvaluacionEmpleado.AutoEvaluacionIniciada;
        }

        internal void RefreshEvaluacion(EvaluacionEmpleado model)
        {
            PeriodoEvaluacion = model.PeriodoEvaluacion;
            IdEvaluador = model.IdEvaluador;
            RiesgoFuga = model.RiesgoFuga;
            IdSucesorEmergencia1 = model.IdSucesorEmergencia1;
            IdSucesorEmergencia2 = model.IdSucesorEmergencia2;
            IdSucesor1 = model.IdSucesor1;
            IdSucesor2 = model.IdSucesor2;
            EvaluadorNotas.ObservacionesGenerales = model.EvaluadorNotas?.ObservacionesGenerales;
            EvaluadorNotas.ObservacionesOtras = model.EvaluadorNotas?.ObservacionesOtras;
            EvaluadorNotas.PuntosFuertes = model.EvaluadorNotas?.PuntosFuertes;
            EvaluadorNotas.AreasDeMejora = model.EvaluadorNotas?.AreasDeMejora;
            ObjetivoEvaluacion = model.ObjetivoEvaluacion;
            Estado = model.Estado;
        }

        #endregion
    }

    public class NotasEvaluacion
    {
        public string ObservacionesGenerales { get; set; }
        public string PuntosFuertes { get; set; }
        public string AreasDeMejora { get; set; }
        public string ObservacionesOtras { get; set; }
    }
}
