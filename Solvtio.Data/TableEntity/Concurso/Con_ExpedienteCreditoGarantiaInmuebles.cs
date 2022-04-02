using System;

namespace Solvtio.Models
{
    public partial class Con_ExpedienteCreditoGarantiaInmuebles
    {
        public int IdExpedienteCreditoGarantiaInmueble { get; set; }
        public int IdExpedienteCredito { get; set; }
        public int IdTipoInmueble { get; set; }
        public decimal Superficie { get; set; }
        public string Descripcion { get; set; }
        public string Tomo { get; set; }
        public string Libro { get; set; }
        public string Folio { get; set; }
        public string NumeroFinca { get; set; }
        public string Inscripcion { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string CodigoPostal { get; set; }
        public string Provincia { get; set; }
        public string Lote { get; set; }
        public decimal? ImporteSubasta { get; set; }
        public decimal? ImporteAdjudicacion { get; set; }
        public bool Adjudicado { get; set; }
        public DateTime? FechaAdjudicacion { get; set; }
        public virtual Con_ExpedienteCredito Con_ExpedienteCredito { get; set; }
        public virtual Hip_TipoInmueble Hip_TipoInmueble { get; set; }
    }
}
