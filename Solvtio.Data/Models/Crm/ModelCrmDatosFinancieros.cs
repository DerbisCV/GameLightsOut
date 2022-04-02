using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelCrmDatosFinancieros
    {
		#region Constructors

		public ModelCrmDatosFinancieros() 
		{
			CreateBase();
		}

		private void CreateBase()
		{
		}

        #endregion

        #region Properties 

        public int IdClienteOficina { get; set; }
        public Gnr_ClienteOficina Oficina { get; set; }
        public Gnr_Cliente ClienteAsociado { get; set; }

        public ModelCrmDatosFinancierosAnio ModelAno0 { get; set; }
        public ModelCrmDatosFinancierosAnio ModelAno1 { get; set; }

        public decimal TotalFacturacion { get; set; }
        public int StockActual { get; set; }

        #endregion

        #region Properties ReadOnly

        //public bool MostrarOtrosParaEstadoImpulso => Filter.TipoIndicadorQaSelected.HasValue;

        #endregion
    }



    public class ModelCrmDatosFinancierosAnio
    {
        public int Anio { get; set; }

        public decimal Facturacion { get; set; }
        public int Entradas { get; set; }

    }

}
