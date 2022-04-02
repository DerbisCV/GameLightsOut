using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvtio.Models
{
    public class ModelEvaluaciones
    {
        public ModelEvaluaciones(Usuario ususario)
        {
            Ususario = ususario;
        }

        public Usuario Ususario { get; set; }
        public List<EvaluacionEmpleado> LstEvaluacionEmpleado { get; set; }
    }
}
