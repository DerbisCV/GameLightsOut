using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public class Hip_ExpedienteEstadoDatoRequerimiento : ExpedienteEstadoRequerimientoPagoBase
    {
        public int IdExpedienteEstadoRequerimiento { get; set; }

        [Index]
        public int ExpedienteEstadoId { get; set; }
        [ForeignKey("ExpedienteEstadoId")]
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        //public bool Positivo_Default { get; set; }

        public int? DocumentoRequerimientoPagoId { get; set; }
        public int? DocumentoSolicitudEdictosId { get; set; }
        //public virtual ExpedienteDocumento ExpedienteDocumento { get; set; }
        //public virtual ExpedienteDocumento ExpedienteDocumento1 { get; set; }

        public override void Refresh(ExpedienteEstadoRequerimientoPagoBase model)
        {
            base.Refresh(model);
            IdExpediente = ExpedienteEstado.IdExpediente;
            //Positivo = model.Positivo;
            //RequerimientoDeudor = model.RequerimientoDeudor;
            //TipoDeudor = model.TipoDeudor;
            //ResultadoApelacion = model.ResultadoApelacion;
        }

    }
}
