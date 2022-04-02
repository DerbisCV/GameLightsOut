using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("EvaluacionCompetenciaGrupo")]
    public class EvaluacionCompetenciaGrupo : INombre
    {
        #region Constructors

        public EvaluacionCompetenciaGrupo() { }
        public EvaluacionCompetenciaGrupo(string name)
        {
            Nombre = name;
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEvaluacionCompetenciaGrupo { get; set; }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        #endregion

        #region Properties One 2 Many

        public virtual ICollection<EvaluacionCompetencia> EvaluacionCompetenciaSet { get; set; }

        #endregion

        #region Properties Readonly

        #endregion

    }
}
