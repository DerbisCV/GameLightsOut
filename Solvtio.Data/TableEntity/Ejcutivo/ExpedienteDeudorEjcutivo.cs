using System;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ExpedienteDeudorEjcutivo")]
    public class ExpedienteDeudorEjcutivo : ExpedienteDeudorBase
    {
        #region Constructors

        public ExpedienteDeudorEjcutivo()
        {
        }

        public ExpedienteDeudorEjcutivo(ExpedienteDeudor expDeudor)
        {
            IdExpedienteDeudor = expDeudor.IdExpedienteDeudor;
            IdExpediente = expDeudor.IdExpediente;
            ExpedienteDeudor = expDeudor;
        }

        #endregion

        #region Properties

        public bool Oposicion { get; set; }
        public DateTime? OposicionFecha { get; set; }
        public DateTime? OposicionFechaVista { get; set; }
        public DateTime? OposicionFechaResolucion { get; set; }
        public int OposicionResultado { get; set; }

        public bool Apelacion { get; set; }
        public DateTime? ApelacionFecha { get; set; }
        public int? ApelacionPorId { get; set; }
        public DateTime? ApelacionFechaResolucion { get; set; }
        public int ApelacionResultado { get; set; }

        //public bool OficioPositivo { get; set; }
        //public string Oficio { get; set; }

        public DateTime? RequerimientoPagoFecha { get; set; }
        public PositivoNegativoType? RequerimientoPagoResultado { get; set; }

        public DateTime? AveriguacionDomiciliariaFecha { get; set; }
        public PositivoNegativoType? AveriguacionDomiciliariaResultado { get; set; }
        //public DateTime? AveriguacionRequerimientoPagoFecha { get; set; }
        public DateTime? AcuerdoEdictoFecha { get; set; }
        

        public bool EfectividadEmbargoBienesInmuebles { get; set; }
        public bool EfectividadEmbargoBienesMuebles { get; set; }
        public bool EfectividadEmbargoBienesSalarios { get; set; }
        public bool EfectividadEmbargoBienesSaldosRetenciones { get; set; }

        #endregion

        #region NotMapped

        [NotMapped]
        public decimal? ImporteEmbargadoTotal { get; set; }

        #endregion

    }
}
