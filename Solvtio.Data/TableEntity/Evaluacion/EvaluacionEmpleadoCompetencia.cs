using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Models.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("EvaluacionEmpleadoCompetencia")]
    public class EvaluacionEmpleadoCompetencia : Auditable
    {
        #region Constructors

        public EvaluacionEmpleadoCompetencia() 
        {
            CreatedDate = UpdatedDate = DateTime.Now;
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEvaluacionEmpleadoCompetencia { get; set; }

        public int IdEvaluacionEmpleado { get; set; }
        [ForeignKey("IdEvaluacionEmpleado")]
        public virtual EvaluacionEmpleado EvaluacionEmpleado { get; set; }

        public int IdEvaluacionCompetencia { get; set; }
        [ForeignKey("IdEvaluacionCompetencia")]
        public virtual EvaluacionCompetencia EvaluacionCompetencia { get; set; }

        public TipoResultadoEvaluacionCompetencia? AutoEvaluacion { get; set; } //AutoEvaluacion
        public TipoResultadoEvaluacionCompetencia? Evaluacion { get; set; }

        #endregion

        #region Properties Readonly

        public override bool IsNew => IdEvaluacionEmpleadoCompetencia < 1;

        public int PuntuacionEvaluacion => !Evaluacion.HasValue ? 0 : (int)Evaluacion;
        public int PuntuacionAutoEvaluacion => !AutoEvaluacion.HasValue ? 0 : (int)AutoEvaluacion;

        #endregion
    }
}
