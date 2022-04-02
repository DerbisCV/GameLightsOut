using Solvtio.Models.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("EvaluacionEmpleadoObjetivo")]
    public class EvaluacionEmpleadoObjetivo : INombre
    {
        #region Constructors

        public EvaluacionEmpleadoObjetivo() { }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEvaluacionEmpleadoObjetivo { get; set; }

        public int IdEvaluacionEmpleado { get; set; }
        [ForeignKey("IdEvaluacionEmpleado")]
        public virtual EvaluacionEmpleado EvaluacionEmpleado { get; set; }

        public string Nombre { get; set; } //Objetivo

        [DataType(DataType.Date)]
        public DateTime? FechaEstimadaCumplimiento { get; set; }

        [Range(0, 100)]
        [Obsolete("Obsoleto: Usar en su lugar: (AutoEvaluacion)")]
        public int? PorcientoComplimientoEvaluado { get; set; } //Valor de 0 - 100

        [Range(0, 100)]
        [Obsolete("Obsoleto: Usar en su lugar: (Evaluacion)")]
        public int? PorcientoComplimientoEvaluador { get; set; } //Valor de 0 - 100

        public TipoResultadoObjetivo? AutoEvaluacion { get; set; }
        public TipoResultadoObjetivo? Evaluacion { get; set; }

        #endregion

        #region Properties Readonly

        public int PuntuacionEvaluado => !AutoEvaluacion.HasValue ? 0 : (int)AutoEvaluacion.Value;

        public int PuntuacionEvaluador => !Evaluacion.HasValue ? 0 : (int)Evaluacion.Value;

        #endregion
    }
}
