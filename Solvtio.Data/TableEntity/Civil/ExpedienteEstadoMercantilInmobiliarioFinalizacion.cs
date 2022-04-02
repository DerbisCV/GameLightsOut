using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoMercantilInmobiliarioFinalizacion")]
    public class ExpedienteEstadoMercantilInmobiliarioFinalizacion
    {
        #region Constructors

        public ExpedienteEstadoMercantilInmobiliarioFinalizacion()
        {
        }
        public ExpedienteEstadoMercantilInmobiliarioFinalizacion(int idExpedienteEstado)
        {
            IdExpedienteEstado = idExpedienteEstado;
        }

        #endregion

        #region Properties

        [Key]
        [ForeignKey("ExpedienteEstado")]
        public int IdExpedienteEstado { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }
        public int IdExpediente { get; set; }

        //public bool PagoDeuda { get; set; }
        //public bool EntregaPosesion { get; set; }
        //public bool DesestimacionDemanda { get; set; }
        //public bool Llaves { get; set; }
        //public bool EnervacionJudicial { get; set; }
        //public bool DesestimientoJudicial { get; set; }
        //public bool PorAcuerdo { get; set; }
        //public bool ParalizacionInstCliente { get; set; }
        //public bool Mediacion { get; set; }
        //public bool CondonacionSinProceso { get; set; }
        //public bool Facturable { get; set; }
        //public bool Precontencioso { get; set; }
        //public bool SentenciaEstimatoria { get; set; }

        #endregion

        #region Methods

        internal void Refresh(ExpedienteEstadoMercantilInmobiliarioFinalizacion model)
        {
            ExpedienteEstado.Expediente.Fin = model.ExpedienteEstado.Fecha;
            //entidad.EnervacionJudicial = model.EnervacionJudicial;
            //entidad.PagoDeuda = model.PagoDeuda;
            //entidad.EntregaPosesion = model.EntregaPosesion;
            //entidad.DesestimacionDemanda = model.DesestimacionDemanda;
            //entidad.DesestimientoJudicial = model.DesestimientoJudicial;
            //entidad.PorAcuerdo = model.PorAcuerdo;
            //entidad.Llaves = model.Llaves;
            //entidad.ParalizacionInstCliente = model.ParalizacionInstCliente;
            //entidad.Mediacion = model.Mediacion;
            //entidad.CondonacionSinProceso = model.CondonacionSinProceso;
            //entidad.Facturable = model.Facturable;
            //entidad.Precontencioso = model.Precontencioso;
            //entidad.SentenciaEstimatoria = model.SentenciaEstimatoria;
        }

        #endregion

    }
}
