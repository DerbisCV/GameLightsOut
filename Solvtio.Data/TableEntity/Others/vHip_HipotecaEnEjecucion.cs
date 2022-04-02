using System;

namespace Solvtio.Models
{
    public partial class vHip_HipotecaEnEjecucion
    {
        public int IdHipoteca { get; set; }
        public int IdValija { get; set; }
        public int? IdExpediente { get; set; }
        public int? IdPeriodicidad { get; set; }
        public int? IdTipoReferenciaHipotecaria { get; set; }
        public int? IdPartidoJudicial { get; set; }
        public int? IdPersona { get; set; }
        public int IdTipoArea { get; set; }
        public int? IdJuzgado { get; set; }
        public string OficinaNoCuenta { get; set; }
        public string NoCuentaPrestamo { get; set; }
        public int NoHipoteca { get; set; }
        public decimal DeudaCierreFijacion { get; set; }
        public decimal? PrestamoCapital { get; set; }
        public string ColegioNotarioFijacion { get; set; }
        public string NotarioFijacion { get; set; }
        public string Registro { get; set; }
        public int? CuotasCantidad { get; set; }
        public decimal? CuotasValor { get; set; }
        public DateTime? CuotasFechaPrimera { get; set; }
        public DateTime? CuotasFechaUltima { get; set; }
        public decimal? TipoInteresInicial { get; set; }
        public decimal? TipoInteresUltimo { get; set; }
        public decimal? TipoInteresMoratorio { get; set; }
        public DateTime? FechaModificacionTipoInteres { get; set; }
        public DateTime? FechaPrimeraCuotaImpagada { get; set; }
        public DateTime? FechaCierre { get; set; }
        public DateTime? DemandaFecha { get; set; }
        public bool Ejecutar { get; set; }
        public decimal? DiferencialIndiceReferenciaHipotecaria { get; set; }
        public bool? DemandaSucesionBancaria { get; set; }
        public bool? DemandaBurofaxNoNotificado { get; set; }
        public DateTime? NovacionFechaFinPeriodoCarencia { get; set; }
        public int? NovacionNoCuotas { get; set; }
        public DateTime? NovacionFechaPeriodoAmortizacionInicio { get; set; }
        public DateTime? NovacionFechaPeriodoAmortizacionFin { get; set; }
        public decimal? NovacionComision { get; set; }
        public DateTime? FechaActaFijacion { get; set; }
        public bool? Carencia { get; set; }
        public bool? Diferencial { get; set; }
        public string ReferenciaExterna { get; set; }
        public string EntidadOrigen { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }
        public System.DateTime FechaAlta { get; set; }
    }
}
