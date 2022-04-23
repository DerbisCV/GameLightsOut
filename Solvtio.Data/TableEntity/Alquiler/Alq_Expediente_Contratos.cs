using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
	[Table("Alq_Expediente_Contratos")]
    public partial class Alq_Expediente_Contrato
    {

        public Alq_Expediente_Contrato()
        {
            Alq_Expediente_Contratos_Deuda_Lineas = new List<Alq_Expediente_Contratos_Deuda_Lineas>();
            Alq_Expediente_Contratos_PlanPagos_Lineas = new List<Alq_Expediente_Contratos_PlanPagos_Lineas>();
        }

        public int ID { get; set; }
        public int IdExpediente { get; set; }
        public string EntidadOrigen { get; set; }
        public DateTime? FechaContrato { get; set; }
        public decimal? RentaInicial { get; set; }
        public int? IdValorPeriodicidad { get; set; }
        public DateTime? PlazoPago { get; set; }
        public int? IdModalidadPago { get; set; }
        public int? IdRevisionRentaIndice { get; set; }
        public int? IdRevisionRentaPeriodicidad { get; set; }
        public DateTime? FechaPrimeraRevision { get; set; }
        public decimal? DeudaInicial { get; set; }
        public decimal? DeudaSatisfecha { get; set; }
        public decimal? DeudaPendiente { get; set; }
        public int? PlazosPago { get; set; }
        public bool? EstaCompleto { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAlta { get; set; }
        public virtual Alq_Expediente Alq_Expediente { get; set; }
        public virtual ICollection<Alq_Expediente_Contratos_Deuda_Lineas> Alq_Expediente_Contratos_Deuda_Lineas { get; set; }
        public virtual ICollection<Alq_Expediente_Contratos_PlanPagos_Lineas> Alq_Expediente_Contratos_PlanPagos_Lineas { get; set; }
        public virtual Gnr_ListasValores_Valores Gnr_ListasValores_Valores { get; set; }
        public virtual Gnr_ListasValores_Valores Gnr_ListasValores_Valores1 { get; set; }
        public virtual Gnr_ListasValores_Valores Gnr_ListasValores_Valores2 { get; set; }
        public virtual Gnr_ListasValores_Valores Gnr_ListasValores_Valores3 { get; set; }

        internal void RefreshBy(Alq_Expediente_Contrato model)
        {
            EntidadOrigen = model.EntidadOrigen;
            FechaContrato = model.FechaContrato;
            RentaInicial = model.RentaInicial;

            IdModalidadPago = model.IdModalidadPago;
            IdRevisionRentaIndice = model.IdRevisionRentaIndice;
            IdRevisionRentaPeriodicidad = model.IdRevisionRentaPeriodicidad;
            FechaPrimeraRevision = model.FechaPrimeraRevision;
        }
    }
}
