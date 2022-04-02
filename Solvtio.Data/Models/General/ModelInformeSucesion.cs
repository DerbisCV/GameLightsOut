using Solvtio.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvtio.Models
{
    public class ModelInformeSucesion
    {
        #region Constructors

        public ModelInformeSucesion()
        {
            CreateBase();
        }

        public ModelInformeSucesion(int? tipo)
        {
            CreateBase();
            Tipo = tipo ?? 1;
        }

        private void CreateBase()
        {
            Tipo = 1;
            LstExpedienteSucesion = new List<Expediente>();
        }

        #endregion

        #region Properties

        public int Tipo { get; set; }
        public TipoExport? Export { get; set; }

        public List<Expediente> LstExpedienteSucesion { get; set; }

        #endregion

    }
}
