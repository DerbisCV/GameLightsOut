using Solvtio.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvtio.Models
{
    public class ModelExpInmueble
    {
        #region Constructors

        public ModelExpInmueble() { }
        public ModelExpInmueble(Expediente expediente, ExpedienteDeudor deudorPrincipal, Hip_Inmueble inmueble)
        {
            Expediente = expediente;
            DeudorPrincipal = deudorPrincipal;
            Inmueble = inmueble;
        }

        #endregion

        #region Properties

        public Expediente Expediente { get; set; }
        public ExpedienteDeudor DeudorPrincipal { get; set; }
        public Hip_Inmueble Inmueble { get; set; }


        #endregion

        #region Properties ReadOnly

        //public int CountTotal => Count01 + Count02 + Count03 + Count04 + Count05 + Count06 + Count07 + Count08 + Count09 + Count10 + Count11 + Count12;

        #endregion

    }
}
