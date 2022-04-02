using System;

namespace Solvtio.Models
{
    public class ModelExpedienteAlquiler : ModelExpedienteBase
    {
        #region Constructors

		public ModelExpedienteAlquiler() { }
        public ModelExpedienteAlquiler(Expediente exp) : base(exp)
        {
            if (exp.Alq_Expediente != null)
            {
                RefExternaMacro = exp.Alq_Expediente.ReferenciaExternaMACRO;
                //this.NoAuto = exp.Alq_Expediente.
                //this.Juzgado = exp.Alq_Expediente.
                //this.PartidoJudicial = exp.Alq_Expediente.
                //this.NoAuto = exp.Alq_Expediente.
                //this.Juzgado = exp.Alq_Expediente.
                //this.PartidoJudicial = exp.Alq_Expediente.
                //this.FechaPresentacionDemanda = exp.Alq_Expediente.
                //this.FechaVista = exp.Alq_Expediente.
                //this.FechaLanzamiento = exp.Alq_Expediente.
                //this.EnervacionJudicial = exp.Alq_Expediente.
                //this.PagoDeuda = exp.Alq_Expediente.
                //this.EntregaPosesion = exp.Alq_Expediente.
                //this.DesestimacionDemanda = exp.Alq_Expediente.
                //this.DesestimientoJudicial = exp.Alq_Expediente.
                //this.PorAcuerdo = exp.Alq_Expediente.
                //this.Devuelto = exp.Alq_Expediente.
                //this.Llaves = exp.Alq_Expediente.
                //this.NoAuto = exp.Alq_Expediente.
                //this.NoAuto = exp.Alq_Expediente.
            }
        }

        #endregion

        #region Properties

        public string NoAuto { get; set; }
        public string RefExternaMacro { get; set; }
        public ModelEntityBase Juzgado { get; set; }
        public ModelEntityBase PartidoJudicial { get; set; }
        public DateTime? FechaPresentacionDemanda { get; set; }
        public DateTime? FechaVista { get; set; }
        public DateTime? FechaLanzamiento { get; set; }

        public bool? EnervacionJudicial { get; set; }
        public bool? PagoDeuda { get; set; }
        public bool? EntregaPosesion { get; set; }
        public bool? DesestimacionDemanda { get; set; }
        public bool? DesestimientoJudicial { get; set; }
        public bool? PorAcuerdo { get; set; }
        public bool? Devuelto { get; set; }
        public bool? Llaves { get; set; }

        #endregion

        #region ReagOnly Properties
        #endregion

        #region Methods
        #endregion
    }
}
