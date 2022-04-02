using System;
using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class ModelCuadroDeMandoResumen
	{
		public int AnioBase { get; set; }

		public ResumenPorAnio ResumenPorAnio1 { get; set; }
        public ResumenPorAnio ResumenPorAnio2 { get; set; }
        public ResumenPorAnio ResumenPorAnio3 { get; set; }

        public int CantidadTotalExpedientes { get; set; }
		public decimal ImporteTotalExpedientes { get; set; }
		public int CantidadTotalExpedientesFinalizados { get; set; }
		public decimal ImporteTotalExpedientesFinalizados { get; set; }
		public List<ResumenPor> LstResumenPorTipoExpediente { get; set; }
		public List<ResumenPor> LstResumenPorOficina { get; set; }

		private int? _cantidadTotalEnCurso;
		public int CantidadTotalEnCurso 
		{
			get 
			{
				if (!_cantidadTotalEnCurso.HasValue)
					_cantidadTotalEnCurso = CantidadTotalExpedientes - CantidadTotalExpedientesFinalizados;
				return _cantidadTotalEnCurso.Value;
			}
		}

		private int? _porcientoEnCurso;
		public int PorcientoEnCurso
		{
			get
			{
				if (!_porcientoEnCurso.HasValue)
				{
					_porcientoEnCurso = (CantidadTotalExpedientes == 0) ? 0 :
						Convert.ToInt32(100 * CantidadTotalEnCurso / CantidadTotalExpedientes);
				}
					
				return _porcientoEnCurso.Value;
			}
		}

		private int? _porcientoFinalizados;
		public int PorcientoFinalizados
		{
			get
			{
				if (!_porcientoFinalizados.HasValue)
				{
					_porcientoFinalizados = 100 - PorcientoEnCurso;
				}

				return _porcientoFinalizados.Value;
			}
		}

		public ModelCuadroDeMandoResumen() 
		{
			createBase();
		}
		public ModelCuadroDeMandoResumen(int year)
		{
			createBase();
			AnioBase = year;
		}
		public void createBase()
		{
			AnioBase = DateTime.Now.Year;
			LstResumenPorTipoExpediente = new List<ResumenPor>();
			LstResumenPorOficina = new List<ResumenPor>();
		}


	}

	public partial class ResumenPor
	{
		public int Id { get; set; }
		public string Descripcion { get; set; }
		public int Cantidad { get; set; }
		public int CantidadFinalizados { get; set; }
		public decimal Importe { get; set; }
		public decimal ImporteFinalizados { get; set; }
	}

	public class ResumenPorAnio
	{
	    public ResumenPorAnio()
	    {
	    }

	    public ResumenPorAnio(int year)
	    {
            Year = year;
	        LstResumenPorTipoExpediente = new List<ResumenPor>();
	        LstResumenPorCliente = new List<ResumenPor>();
	    }

        public int Year { get; set; }
        public int Count { get; set; }

        public List<ResumenPor> LstResumenPor { get; set; }
        public List<ResumenPor> LstResumenPorTipoExpediente { get; set; }
        public List<ResumenPor> LstResumenPorCliente { get; set; }
    }
}
