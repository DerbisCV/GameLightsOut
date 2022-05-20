using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("TipoIncidenciaEstado")]
    public class TipoIncidenciaEstado : IName
    {
        #region Constructors

        public TipoIncidenciaEstado()
        {
            CreateBase();
        }
        public TipoIncidenciaEstado(string name)
        {
            CreateBase();
            Nombre = name;
        }

        private void CreateBase()
        {
            Activo = true;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoIncidenciaEstado { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public bool Activo { get; set; }

        public ExpedienteEstadoTipo? TipoEstado { get; set; }

        #endregion

        #region Properties virtual ICollection

        public virtual ICollection<ExpedienteEstado> ExpedienteEstadoSet { get; set; }

        #endregion

        #region Properties ReadOnly
        public int Id => IdTipoIncidenciaEstado;
        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion
    }
}
