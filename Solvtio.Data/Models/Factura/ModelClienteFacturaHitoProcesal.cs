using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvtio.Models
{
    public class ModelClienteFacturaHitoProcesal
    {
        #region Constructors

        public ModelClienteFacturaHitoProcesal()
        {
            CreateBase();
        }
        public ModelClienteFacturaHitoProcesal(int? idCliente)
        {
            CreateBase();

            if (idCliente.HasValue)
                Filter.ClienteSelected = idCliente;
        }
        public ModelClienteFacturaHitoProcesal(ModelFilterBase filter)
        {
            CreateBase();
            Filter = filter;
        }
        private void CreateBase()
        {
            Filter = new ModelFilterBase();
            LstModelFacturaHitoProcesalAtClient = new List<ModelFacturaHitoProcesalAtClient>();
        }

        #endregion

        #region Properties

        public ModelFilterBase Filter { get; set; }

        public List<ModelFacturaHitoProcesalAtClient> LstModelFacturaHitoProcesalAtClient { get; set; }

        #endregion

    }

    public class ModelFacturaHitoProcesalAtClient
    {
        public Gnr_Cliente Cliente { get; set; }

        public ClienteFacturaHitoProcesal ModelH1 { get; set; }
        public ClienteFacturaHitoProcesal ModelH2 { get; set; }
        public ClienteFacturaHitoProcesal ModelH3 { get; set; }
        public ClienteFacturaHitoProcesal ModelH4 { get; set; }
        public ClienteFacturaHitoProcesal ModelH5 { get; set; }
        public ClienteFacturaHitoProcesal ModelH6 { get; set; }
    }
}
