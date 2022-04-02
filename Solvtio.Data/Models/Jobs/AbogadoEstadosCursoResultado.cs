using System;

namespace Solvtio.Esp
{
    public class AbogadoEstadosCursoResultado
    {
        public string NoExpediente { get; set; }
        public string ReferenciaExterna { get; set; }
        public string Referencia2 { get; set; }
        public string NoAuto { get; set; }
        public string HitoVeniado { get; set; }
        public bool EsHeredado { get; set; }
        public DateTime? SucesionPresentada { get; set; }
        public bool SucesionOposicion { get; set; }
        public string SucesiónRealizada { get; set; }
        public DateTime? SucesionDenegada { get; set; }
        public string SucesionCausaIncidencia { get; set; }
        public DateTime? SucesionRecurrida { get; set; }
        public string SucesionResultadoRecuso { get; set; }
        public string Cliente { get; set; }
        public string Oficina { get; set; }
        public string Tipo { get; set; }
        public string Procurador { get; set; }
        public string Area { get; set; }
        public decimal? DeudaFinal { get; set; }
        public string FechaCierre { get; set; }
        public string Deudor { get; set; }
        public string JuzgadoName { get; set; }
        public string PartidoJudicial { get; set; }
        public string H1Factura { get; set; }
        public DateTime? H1Fecha { get; set; }
        public decimal? H1Importe { get; set; }
        public string H2Factura { get; set; }
        public DateTime? H2Fecha { get; set; }
        public decimal? H2Importe { get; set; }
        public string Estado { get; set; }
        public string Fase { get; set; }
        public DateTime? Fecha { get; set; }
        public string Incidencia { get; set; }
        public DateTime? Resolucion { get; set; }
        public DateTime? ImpulsoFecha { get; set; }
        public string ImpulsoNota { get; set; }
        public string AbogadoExpediente { get; set; }
        public string AbogadoEstado1 { get; set; }
        public string AbogadoEstado2 { get; set; }
        public DateTime? FechaAlta { get; set; }
        public bool Paralizado { get; set; }
        public DateTime? ParalizadoFecha { get; set; }
        public string ParalizadoMotivo { get; set; }
        public DateTime? UltimaNotaFecha { get; set; }
        public string UltimaNota { get; set; }
        public string UltimaNotaUsuario { get; set; }
        public string Origen { get; set; }
        public string Cartera { get; set; }
        public string Pagador { get; set; }
        public string ContratoRef { get; set; }
        public bool ServicioIntegral { get; set; }
        public int IdCliente { get; set; }
        public int IdExpediente { get; set; }
        public string SubTipoProcedimiento { get; set; }
    }
}
