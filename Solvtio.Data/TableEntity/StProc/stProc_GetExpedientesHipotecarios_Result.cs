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
    
    public partial class stProc_GetExpedientesHipotecarios_Result
    {
        public int IdExpediente { get; set; }
        public string NoExpediente { get; set; }
        public string ReferenciaExterna { get; set; }
        public int IdClienteOficina { get; set; }
        public string OficinaCliente { get; set; }
        public int IdCliente { get; set; }
        public string Cliente { get; set; }
        public Nullable<int> IdPersona { get; set; }
        public string DeudorPrincipal { get; set; }
        public Nullable<int> IdPartidoJudicial { get; set; }
        public string PartidoJudicial { get; set; }
        public Nullable<int> IdProcurador { get; set; }
        public string Procurador { get; set; }
        public string TipoEstadoLast { get; set; }
        public Nullable<decimal> DeudaFinal { get; set; }
        public Nullable<decimal> DeudaCierreFijacion { get; set; }
        public System.DateTime FechaAlta { get; set; }
    }
}
