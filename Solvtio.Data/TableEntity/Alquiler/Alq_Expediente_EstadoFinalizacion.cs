using Solvtio.Data.Models.Estado.Alquiler;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public partial class Alq_Expediente_EstadoFinalizacion : EstadoAlqFinalizacionPoco
    {
        #region Properties

        public int IdExpedienteEstado { get; set; }
        [ForeignKey("IdExpedienteEstado")]
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public int? IdMotivo { get; set; }
        [ForeignKey("IdMotivo")]
        public virtual Gnr_TipoEstadoMotivo Motivo { get; set; }

        #endregion

        public void RefreshBy(EstadoAlqFinalizacionDto model)
        {
            IdMotivo = model.IdMotivo;
            IdExpedienteEstado = model.IdExpedienteEstado;
            PagoDeuda = model.PagoDeuda;
            EntregaPosesion = model.EntregaPosesion;
            DesestimacionDemanda = model.DesestimacionDemanda;
            Llaves = model.Llaves;
            EnervacionJudicial = model.EnervacionJudicial;
            DesestimientoJudicial = model.DesestimientoJudicial;
            PorAcuerdo = model.PorAcuerdo;
            ParalizacionInstCliente = model.ParalizacionInstCliente;
            Mediacion = model.Mediacion;
            CondonacionSinProceso = model.CondonacionSinProceso;
            Facturable = model.Facturable;
            Precontencioso = model.Precontencioso;
            SentenciaEstimatoria = model.SentenciaEstimatoria;
            Archivo = model.Archivo;
            ArchivoProvisional = model.ArchivoProvisional;
            CesionVenia = model.CesionVenia;
        }
    }
}
