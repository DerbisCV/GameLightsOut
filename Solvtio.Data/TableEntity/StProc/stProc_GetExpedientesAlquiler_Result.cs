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
    
    public partial class stProc_GetExpedientesAlquiler_Result
    {
        public int IdExpediente { get; set; }
        public string NoExpediente { get; set; }
        public string ReferenciaExterna { get; set; }
        public string ReferenciaExternaMACRO { get; set; }
        public string ReferenciaExternaMSGI { get; set; }
        public string NumAuto { get; set; }
        public Nullable<int> IdAlqContrato { get; set; }
        public string Juzgado { get; set; }
        public int IdClienteOficina { get; set; }
        public string OficinaCliente { get; set; }
        public int IdCliente { get; set; }
        public string Cliente { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> IdProcurador { get; set; }
        public string TipoEstadoLast { get; set; }
        public Nullable<System.DateTime> FechaPresentacionDemanda { get; set; }
        public Nullable<int> IdPersona { get; set; }
        public string DeudorPrincipal { get; set; }
        public Nullable<decimal> DeudaInicial { get; set; }
        public Nullable<decimal> DeudaPendiente { get; set; }
        public Nullable<decimal> DeudaFinal { get; set; }
        public Nullable<bool> EnervacionJudicial { get; set; }
        public Nullable<bool> PagoDeuda { get; set; }
        public Nullable<bool> EntregaPosesion { get; set; }
        public Nullable<bool> DesestimacionDemanda { get; set; }
        public Nullable<bool> DesestimientoJudicial { get; set; }
        public Nullable<bool> PorAcuerdo { get; set; }
        public Nullable<bool> Devuelto { get; set; }
        public Nullable<bool> Llaves { get; set; }
        public Nullable<int> IdTipoEstadoCliente { get; set; }
        public string TipoEstadoCliente { get; set; }
        public string InmueblePrincipalProvincia { get; set; }
        public string InmueblePrincipalCodigoPostal { get; set; }
        public string InmueblePrincipalLocalidad { get; set; }
        public Nullable<bool> ParalizacionInstCliente { get; set; }
        public Nullable<bool> Mediacion { get; set; }
    }
}
