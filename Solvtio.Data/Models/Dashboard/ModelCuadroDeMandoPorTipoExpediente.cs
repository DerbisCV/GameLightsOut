using Solvtio.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solvtio.Models
{
    public partial class ModelCuadroDeMandoPorTipoExpediente
	{
		#region Constructors
		public ModelCuadroDeMandoPorTipoExpediente()
		{
			CreateBase();
		}
		public ModelCuadroDeMandoPorTipoExpediente(int tipoExpediente)
		{
			CreateBase();
            Filter = new ModelFilterBase(tipoExpediente);
		}
		public ModelCuadroDeMandoPorTipoExpediente(ModelFilterBase filter)
		{
			CreateBase();
            Filter = filter;
		}
		public void CreateBase()
		{
            Filter = new ModelFilterBase();
            LstCuadroDeMandoPorTipoExpediete = new List<stProc_CuadroDeMando_PorTipoExpediete_Result>();
		}
		#endregion

		#region Properties

		public ModelFilterBase Filter { get; set; }
		public List<stProc_CuadroDeMando_PorTipoExpediete_Result> LstCuadroDeMandoPorTipoExpediete { get; set; }

		public List<ModelCuadroDeMandoOneTipoExpediente> LstCuadroDeMando { get; set; }
		public List<ModelCuadroDeMandoOneCliente> LstCuadroDeMandoCliente { get; set; }

		#endregion

		#region Properties ReadOnly

		public int? Total => LstCuadroDeMando != null ? LstCuadroDeMando.Sum(x => x.Total) : LstCuadroDeMandoCliente.Sum(x => x.Total);
		public int? Finalizados => LstCuadroDeMando != null ? LstCuadroDeMando.Sum(x => x.Finalizados) : LstCuadroDeMandoCliente.Sum(x => x.Finalizados);
		public int? Activos => Total - Finalizados;

		private int? _cantidadTotal;
		public int CantidadTotal
		{
			get
			{
				if (!_cantidadTotal.HasValue)
					_cantidadTotal = LstCuadroDeMandoPorTipoExpediete.Sum(x => x.Cantidad);

				return _cantidadTotal.Value;
			}
		}

		private int? _cantidadFinalizados;
		public int CantidadFinalizados
		{
			get
			{
				if (!_cantidadFinalizados.HasValue)
					_cantidadFinalizados = LstCuadroDeMandoPorTipoExpediete
                        .Where(x => x.IdTipoEstadoLast.HasValue && Util.ListEstadosFinalizados.Contains(x.IdTipoEstadoLast.Value))
						.Sum(x => x.Cantidad);

				return _cantidadFinalizados.Value;
			}
		}

		private int? _cantidadEnCurso;
		public int CantidadEnCurso 
		{
			get 
			{
				if (!_cantidadEnCurso.HasValue)
					_cantidadEnCurso = CantidadTotal - CantidadFinalizados;

				return _cantidadEnCurso.Value;
			}
		}


		private int? _porcientoEnCurso;
		public int PorcientoEnCurso
		{
			get
			{
				if (!_porcientoEnCurso.HasValue)
				{
					_porcientoEnCurso = (CantidadTotal == 0) ? 0 :
						Convert.ToInt32(100 * CantidadEnCurso / CantidadTotal);
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

		#endregion
	}

	public class ModelCuadroDeMandoOneTipoExpediente
    {
		public string Area { get; set; }
		public TipoExpedienteEnum TipoExpediente { get; set; }
		public List<stProc_CuadroDeMando_PorTipoExpediete_Result> LstCuadroDeMando { get; set; }

		public int? Total => LstCuadroDeMando.Sum(x => x.Cantidad);
		public int? Finalizados => LstCuadroDeMando.Sum(x => x.Finalziados);
		public int? Activos => Total - Finalizados;
	}

	public class ModelCuadroDeMandoOneCliente
	{
		public ModelCuadroDeMandoOneCliente() {}
		public ModelCuadroDeMandoOneCliente(int idCliente, string nombre)
		{
			IdCliente = idCliente;
			Cliente = nombre;

			LstCuadroDeMando = new List<ModelCuadroDeMandoOneClienteItemDetail>();
		}

		public int IdCliente { get; set; }
		public string Cliente { get; set; }

		public TipoExpedienteEnum TipoExpediente { get; set; }
		public List<ModelCuadroDeMandoOneClienteItemDetail> LstCuadroDeMando { get; set; }

		public int? Total => LstCuadroDeMando.Sum(x => x.Total);
		public int? Finalizados => LstCuadroDeMando.Sum(x => x.Finalizados);
		public int? Activos => Total - Finalizados;
	}

	public class ModelCuadroDeMandoOneClienteItemDetail
    {
		public ModelCuadroDeMandoOneClienteItemDetail() { }
		public ModelCuadroDeMandoOneClienteItemDetail(int idTipoExp, int activos, int finalizados, decimal deudaFinal)
		{
			TipoExpediente = (TipoExpedienteEnum)idTipoExp;
			Activos = activos;
			Finalizados = finalizados;
			DeudaFinal = deudaFinal;
		}

		public TipoExpedienteEnum TipoExpediente { get; set; }
		public int Activos { get; set; }
		public int Finalizados { get; set; }
		public int Total => Activos + Finalizados;
		public decimal? DeudaFinal { get; set; }
	}

}
