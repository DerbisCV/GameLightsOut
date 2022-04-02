using Solvtio.Common;
using Solvtio.Models.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("TipoSubFaseEstado")]
    public class TipoSubFaseEstado : INombre
    {
        #region Constructors

        public TipoSubFaseEstado()
        {
            CreateBase();
        }
        public TipoSubFaseEstado(TipoFaseEstado tipoFaseEstado)
        {
            CreateBase();
            IdTipoSubFaseEstado = (int)tipoFaseEstado;
            Nombre = tipoFaseEstado.GetDescription();
        }
        public TipoSubFaseEstado(string name)
        {
            CreateBase();
            Nombre = name;
        }
        public TipoSubFaseEstado(ExpedienteEstadoTipo estadoTipo, string name)
        {
            CreateBase();
            Nombre = name;
            TipoEstado = estadoTipo;
        }

        private void CreateBase()
        {
            Activo = true;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTipoSubFaseEstado { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }

        public string ClientePhaseCoded { get; set; }

        public ExpedienteEstadoTipo? TipoEstado { get; set; }

        #endregion

        #region Properties virtual ICollection

        public virtual ICollection<ExpedienteEstado> ExpedienteEstadoSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion
    }
}
