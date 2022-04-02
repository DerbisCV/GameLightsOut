using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelExpedientesDocumentos
    {
        #region Constructors

		public ModelExpedientesDocumentos() 
        {
            createBase();
        }

        private void createBase()
        {
            Filter = new ModelFilterBase();
            LstDocumentos = new List<ExpedienteDocumento>();
        }

        #endregion

        #region Properties

        public ModelFilterBase Filter { get; set; }
        public List<ExpedienteDocumento> LstDocumentos { get; set; }
        //public string RefExternaMacro { get; set; }
        //public ModelEntityBase Juzgado { get; set; }
        //public ModelEntityBase PartidoJudicial { get; set; }
        //public DateTime? FechaPresentacionDemanda { get; set; }
        //public DateTime? FechaVista { get; set; }
        //public DateTime? FechaLanzamiento { get; set; }

        //public bool? EnervacionJudicial { get; set; }
        //public bool? PagoDeuda { get; set; }
        //public bool? EntregaPosesion { get; set; }
        //public bool? DesestimacionDemanda { get; set; }
        //public bool? DesestimientoJudicial { get; set; }
        //public bool? PorAcuerdo { get; set; }
        //public bool? Devuelto { get; set; }
        //public bool? Llaves { get; set; }

        #endregion

        #region ReagOnly Properties
        #endregion

        #region Methods
        #endregion
    }
}
