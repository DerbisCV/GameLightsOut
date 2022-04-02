using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelAbogadoFacturacion
	{
		#region Constructors

		public ModelAbogadoFacturacion() 
		{
			Filter = new ModelFilterBase();
			LstAbogadoFacturacionMes = new List<ModelAbogadoFacturacionMes>();
		}
		public ModelAbogadoFacturacion(ModelFilterBase filter) : this()
        {
            Filter = filter;
        }

		#endregion

		#region Properties

		public ModelFilterBase Filter { get; set; }
		public List<ModelAbogadoFacturacionMes> LstAbogadoFacturacionMes { get; set; }

        #endregion
    }

	public class ModelAbogadoFacturacionMes
	{
        public ModelAbogadoFacturacionMes() {}
		public ModelAbogadoFacturacionMes(int idAbogado, string nombre)
		{
			IdAbogado = idAbogado;
			Abogado = nombre;
		}

		public int IdAbogado { get; set; }
		public int Mes { get; set; }
		public string Abogado { get; set; }

		public decimal? Facturado01 { get; set; }
		public decimal? Facturado02 { get; set; }
		public decimal? Facturado03 { get; set; }
		public decimal? Facturado04 { get; set; }
		public decimal? Facturado05 { get; set; }
		public decimal? Facturado06 { get; set; }
		public decimal? Facturado07 { get; set; }
		public decimal? Facturado08 { get; set; }
		public decimal? Facturado09 { get; set; }
		public decimal? Facturado10 { get; set; }
		public decimal? Facturado11 { get; set; }
		public decimal? Facturado12 { get; set; }

		public decimal FacturadoTotal =>
			(Facturado01 ?? 0) +
			(Facturado02 ?? 0) +
			(Facturado03 ?? 0) +
			(Facturado04 ?? 0) +
			(Facturado05 ?? 0) +
			(Facturado06 ?? 0) +
			(Facturado07 ?? 0) +
			(Facturado08 ?? 0) +
			(Facturado09 ?? 0) +
			(Facturado10 ?? 0) +
			(Facturado11 ?? 0) +
			(Facturado12 ?? 0);
	}
}

