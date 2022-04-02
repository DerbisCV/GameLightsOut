using Solvtio.Common;
using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelAbogado
    {
        #region Constructor

        public ModelAbogado()
        {
            createBase();
        }

        public ModelAbogado(Gnr_Persona persona)
        {
            createBase();
            Persona = persona;
        }

        private void createBase()
        {
            LstExpedientesActivos = new List<KeyValuePair<string, int>>();
            LstExpedientesActivosOficinas = new List<KeyValuePair<string, int>>();
            LstExpedientesActivosClientes = new List<KeyValuePair<string, int>>();
            LstExpedientesActivosEstados = new List<KeyValuePair<string, int>>();
            LstExpActivos = new List<KeyValue>();
        }

        #endregion

        #region Properties

        public Gnr_Persona Persona { get; set; }
        public Usuario Usuario { get; set; }

        public List<KeyValue> LstExpActivos { get; set; }
        public List<KeyValue> LstData { get; set; }
        public List<KeyValuePair<string, int>> LstExpedientesActivos { get; set; }
        public List<KeyValuePair<string, int>> LstExpedientesActivosOficinas { get; set; }
        public List<KeyValuePair<string, int>> LstExpedientesActivosClientes { get; set; }
        public List<KeyValuePair<string, int>> LstExpedientesActivosEstados { get; set; }

        public List<ModelSqlViewGastoDirectoAnualAbogadoCliente> LstModelSqlViewGastoDirectoAnualAbogadoCliente { get; set; }


        public int TotalExpActivos { get; set; }
        public int TotalExpFinalizdos { get; set; }
        public decimal TotalExpActivosDeuda { get; set; }
        public decimal TotalExpFinalizdosDeuda { get; set; }


        public int AlarmasActivos { get; set; }
        public int FacturasActivos { get; set; }
        public int FacturableRealizado { get; set; }
        public int FacturableProximo { get; set; }
        public int FacturableFuturo { get; set; }


        public int VistasActivos { get; set; }
        public int VencimientosActivos { get; set; }
        public int NotificacionesActivos { get; set; }

        #endregion
    }

    public class ModelFacturable
    {
        public decimal FacturableConFecha { get; set; }
        public decimal FacturableSinFecha { get; set; }


        public decimal FacturableRealizado { get; set; }
        public decimal FacturableProximo { get; set; }
    }

    public class ModelSqlViewGastoDirectoAnualAbogadoCliente
    {
        public int IdAbogado { get; set; }
        public int? QAbogado { get; set; }
        public int Anio { get; set; }
        public decimal? GastoDirectoTotal { get; set; }

        public int IdCliente { get; set; }
        public int? QCliente { get; set; }
        public decimal? GastoDirectoCliente { get; set; }
        public string Cliente { get; set; }
        public string Abogado { get; set; }
    }
}
