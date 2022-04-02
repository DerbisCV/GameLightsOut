using Solvtio.Common;
using Solvtio.Models.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteDeudorBurofax")]
    public class ExpedienteDeudorBurofax : ExpedienteDeudorBase
    {
        #region Constructors

        public ExpedienteDeudorBurofax()
        {
            BurofaxType = BurofaxType.Burofax30;
        }

        public ExpedienteDeudorBurofax(ExpedienteDeudor expDeudor) : this()
        {
            IdExpedienteDeudor = expDeudor.IdExpedienteDeudor;
            IdExpediente = expDeudor.IdExpediente;
            ExpedienteDeudor = expDeudor;
        }

        #endregion

        #region Properties

        public BurofaxType BurofaxType { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaSolicitud { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaVencimiento { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaObtencion { get; set; }

        public int? ResultadoId { get; set; }
        [ForeignKey("ResultadoId")]
        public virtual CaracteristicaBase Resultado { get; set; }

        public string Incidencia { get; set; }


        public string Usuario { get; set; }

        #endregion

        #region Properties ReadOnly

        public string AcuseReciboInfoReadOnly => $"{FechaObtencion.ToShortDateString()} {Incidencia}";

        #endregion

        #region NotMapped

        [NotMapped]
        public ExpedienteDeudorBurofax ExpedienteDeudorBurofax2 { get; set; }

        [NotMapped]
        public ExpedienteDeudorBurofax ExpedienteDeudorBurofax3 { get; set; }

        #endregion

        internal void Refresh()
        {
            if (!FechaVencimiento.HasValue)
                FechaVencimiento = FechaSolicitud.AddDaysHabiles(BurofaxType == BurofaxType.Burofax10 ? 10 : 30);
        }

        internal void Refresh(ExpedienteDeudorBurofax model)
        {
            FechaSolicitud = model.FechaSolicitud;
            FechaVencimiento = model.FechaVencimiento;
            FechaObtencion = model.FechaObtencion;
            BurofaxType = model.BurofaxType;
            ResultadoId = model.ResultadoId;
            Incidencia = model.Incidencia;
            Usuario = model.Usuario;

            Refresh();
        }

    }
}
