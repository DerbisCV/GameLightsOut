//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Solvtio.Models
{
    using System;
    
    public partial class STPROC_GetNegociacionGestion_Result
	{
		#region Properties Ini

		public int IdExpediente { get; set; }
        public int IdGestor { get; set; }
        public bool Plan30 { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public string NoExpediente { get; set; }
        public string ReferenciaExterna { get; set; }
        public string TipoExpediente { get; set; }
        public string OficinaCliente { get; set; }
        public Nullable<decimal> Deuda { get; set; }
        public string Gestor { get; set; }
        public string Deudor { get; set; }
        public string DeudorTelefono { get; set; }
        public string NoCuentaPrestamo { get; set; }
        public string OficinaSucursalNo { get; set; }
        public string OficinaSucursalTelefono { get; set; }
        public string Observacion { get; set; }
        public string TipoEstadoLast { get; set; }
        public string NegociacionTipoEstadoLast { get; set; }
        public string DeudorPrincipal { get; set; }

		#endregion

		#region Properties 13/05/2016

		public int IdTipoExpediente { get; set; }
		public int IdClienteOficina { get; set; }
		public int IdTipoEstadoLast { get; set; }
		public int IdTipoArea { get; set; }

		#endregion 
	}
}
