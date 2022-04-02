using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelCliente : ModelEntityBase
    {
        #region Constructors

        public ModelCliente() {}
        public ModelCliente(int idCliente, string cliente) : base(idCliente, cliente) { }
        public ModelCliente(Gnr_Cliente cliente) : this (cliente.IdCliente, cliente.Nombre)
        { }

        #endregion

        #region Properties

        public List<ModelMargenBrutoDetail> LstMargenBruto { get; set; } = new List<ModelMargenBrutoDetail>();
        public List<ModelSqlViewGastoDirectoAnualAbogadoCliente> LstModelSqlViewGastoDirectoAnualAbogadoCliente { get; set; }

        #endregion

        #region ReagOnly Properties
        #endregion

        #region Methods
        #endregion
    }

    public class ModelMargenBrutoDetail 
    {
        public string Period { get; set; }
        public decimal? FacturacionObjetivo { get; set; }
        public decimal? Facturacion { get; set; }
        public decimal? GastosDirectos { get; set; }
        public decimal? GastosIndirectos { get; set; }

        public decimal GastosTotal => (GastosDirectos ?? 0) + (GastosIndirectos ?? 0);
        public decimal MargenBruto => (Facturacion ?? 0) - GastosTotal;
    }
}
