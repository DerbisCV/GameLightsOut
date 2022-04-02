using System;

namespace Solvtio.Models
{
    public class ExpedienteEstadoRequerimientoPagoBase
    {
        #region Properties

        public int IdExpediente { get; set; }
        public DateTime? FechaRequerimientoPago { get; set; }
        public bool Positivo { get; set; }
        public string RequerimientoDeudor { get; set; }
        public int TipoDeudor { get; set; }
        public int ResultadoApelacion { get; set; }

        #endregion

        #region Properties Readonly

        public string TipoDeudorName => TipoDeudor == 2 ? "Fiador/Avalista" : "Deudor";

        #endregion


        public virtual void Refresh(ExpedienteEstadoRequerimientoPagoBase model)
        {
            FechaRequerimientoPago = model.FechaRequerimientoPago;
            Positivo = model.Positivo;
            RequerimientoDeudor = model.RequerimientoDeudor;
            TipoDeudor = model.TipoDeudor;
            ResultadoApelacion = model.ResultadoApelacion;
        }

    }
}
