using Solvtio.Models;
using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelEmpleadoListado
    {
        #region Constructor
        public ModelEmpleadoListado()
        {
            createBase();
        }

        public ModelEmpleadoListado(ModelFilterBase filter)
        {
            createBase();
            Filter = filter;
        }

        private void createBase()
        {
            Filter = new ModelFilterBase();
            LstEmpleados = new List<Usuario>();
        }
        #endregion

        #region Properties

        public ModelFilterBase Filter { get; set; }
        public List<Usuario> LstEmpleados { get; set; }

        public List<EvaluacionEmpleado> LstEvaluacionEmpleado { get; set; }

        #endregion
    }
}
