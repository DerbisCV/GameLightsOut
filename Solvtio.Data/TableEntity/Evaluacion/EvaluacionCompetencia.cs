using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("EvaluacionCompetencia")]
    public class EvaluacionCompetencia : INombre
    {
        #region Constructors

        public EvaluacionCompetencia() { }
        public EvaluacionCompetencia(int idGrupo, string name)
        {
            IdGrupo = idGrupo;
            Nombre = name;
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEvaluacionCompetencia { get; set; }

        public string Nombre { get; set; }

        public int IdGrupo { get; set; }
        [ForeignKey("IdGrupo")]
        public virtual EvaluacionCompetenciaGrupo Grupo { get; set; }

        #endregion

        #region Properties One 2 Many

        public virtual ICollection<EvaluacionEmpleadoCompetencia> EvaluacionEmpleadoCompetenciaSet { get; set; }

        #endregion

        #region Properties Readonly

        #endregion
    }
}
