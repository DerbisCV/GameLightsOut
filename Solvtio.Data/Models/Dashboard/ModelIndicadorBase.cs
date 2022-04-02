namespace Solvtio.Models
{
    public class ModelIndicadorBase
	{
		#region Constructor

		public ModelIndicadorBase()
		{
		}
        public ModelIndicadorBase(string name, int count, Gnr_Cliente cliente)
        {
            IndicadorName = name;
            Cantidad = count;
            Cliente = cliente;
        }
        public ModelIndicadorBase(string name, int count, decimal? importe)
		{
			IndicadorName = name;
			Cantidad = count;
			Importe = importe ?? 0;
		}
		public ModelIndicadorBase(string name, int count, decimal? importe, int refInt)
		{
			IndicadorName = name;
			Cantidad = count;
			Importe = importe ?? 0;
			RefInt = refInt;
		}

		#endregion

		#region Properties

		public string IndicadorName { get; set; }
		public int Cantidad { get; set; }
		public decimal Importe { get; set; }

		public int RefInt { get; set; }

        public Gnr_Cliente Cliente { get; set; }

        #endregion

        #region Properties ReadOnly
        #endregion
    }

}
