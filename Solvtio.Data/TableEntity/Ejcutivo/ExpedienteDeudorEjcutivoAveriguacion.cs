using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteDeudorEjcutivoAveriguacion")]
    public sealed class ExpedienteDeudorEjcutivoAveriguacion : ExpedienteDeudorBase
    {
        #region Constructors

        public ExpedienteDeudorEjcutivoAveriguacion()
        {
        }

        public ExpedienteDeudorEjcutivoAveriguacion(ExpedienteDeudor expDeudor)
        {
            IdExpedienteDeudor = expDeudor.IdExpedienteDeudor;
            IdExpediente = expDeudor.IdExpediente;
            ExpedienteDeudor = expDeudor;
        }

        #endregion

        #region Properties

        public DateTime? AveriguacionPatrimonialFecha { get; set; }
        public DateTime? AveriguacionPatrimonialFechaRecepcion { get; set; }

        //Fecha de Solicitud
        //    Fecha de Recepción.


        public bool AveriguacionPatrimonialSaldosRetenciones { get; set; }
        public bool AveriguacionPatrimonialSalarios { get; set; }
        public bool AveriguacionPatrimonialInmuebles { get; set; }
        public bool AveriguacionPatrimonialMuebles { get; set; }

        public DateTime? MejoraEmbargoFecha { get; set; }
        public bool MejoraEmbargoSaldosRetenciones { get; set; }
        public bool MejoraEmbargoSalarios { get; set; }
        public bool MejoraEmbargoInmuebles { get; set; }
        public bool MejoraEmbargoMuebles { get; set; }

        public DateTime? DecretoEmbargoFecha { get; set; }
        public bool DecretoEmbargoSaldosRetenciones { get; set; }
        public bool DecretoEmbargoSalarios { get; set; }
        public bool DecretoEmbargoInmuebles { get; set; }
        public bool DecretoEmbargoMuebles { get; set; }

        public string Usuario { get; set; }

        #endregion

        #region NotMapped

        //[NotMapped]
        //public decimal? ImporteEmbargadoTotal { get; set; }

        #endregion

    }
}
