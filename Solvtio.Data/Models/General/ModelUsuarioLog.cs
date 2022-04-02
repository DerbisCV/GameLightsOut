using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelUsuarioLog : ModelWithFilterBase
    {
        #region Constructors

        public ModelUsuarioLog() { }
        public ModelUsuarioLog(ModelFilterBase filter)
            : base(filter) 
        {
        }

        #endregion

        #region Properties

        public List<UsuarioLog> ListUsuarioLog { get; set; }

        #endregion

        #region ReagOnly Properties
        #endregion

        #region Methods
        #endregion
    }
}
