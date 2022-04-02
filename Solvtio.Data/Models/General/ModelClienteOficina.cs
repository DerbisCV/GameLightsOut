using System;
using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelClienteOficina
	{
		#region Constructor

		public ModelClienteOficina() 
		{
            createBase();
		}

        public ModelClienteOficina(stProc_GetValijaResumenSemanal_Result item)
		{
            IdClienteOficina = item.IdClienteOficina;
            ClienteOficina = item.ClienteOficina;
		}

		public ModelClienteOficina(stProc_GetExpedienteEstadoResumenSemanal_Result item)
		{
            IdClienteOficina = item.IdClienteOficina;
            ClienteOficina = item.Nombre;
		}

        public ModelClienteOficina(Gnr_ClienteOficina clienteOficina)
        {
            createBase();

            IdClienteOficina = clienteOficina.IdClienteOficina;
            ClienteOficina = clienteOficina.Nombre;
            IdCliente = clienteOficina.Gnr_Cliente.IdCliente;
            Cliente = clienteOficina.Gnr_Cliente.Nombre;

            Oficina = clienteOficina;
        }

        private void createBase()
        {
            LstExpActivosPorTipo = new List<ModelBaseSituacionTipoExp>();
            LstIndicadoresQa = new List<ModelIndicadorQa>();
        }

        #endregion

        #region Properties

        public int IdClienteOficina { get; set; }
		public int IdCliente { get; set; }

		public string ClienteOficina { get; set; }
		public string Cliente { get; set; }

        public Gnr_ClienteOficina Oficina { get; set; }
        public int TotalExpActivos { get; set; }
        public int TotalExpFinalizdos { get; set; }
        public decimal TotalExpActivosDeuda { get; set; }
        public decimal TotalExpFinalizdosDeuda { get; set; }

        public List<ModelBaseSituacionTipoExp> LstExpActivosPorTipo { get; set; }
        public List<ModelIndicadorQa> LstIndicadoresQa { get; set; }

        public List<ModelIndicadorQa> LstExp{ get; set; }

        #endregion
    }
}
