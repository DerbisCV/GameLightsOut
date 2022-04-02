
using System.Collections.Generic;
using System.Text;

namespace Solvtio.Models
{
    public class ModelExpReiGeneral
    {
		#region Constructors

        public ModelExpReiGeneral()
        {
			CreateBase();
        }
        public ModelExpReiGeneral(int idExpediente)
        {
            CreateBase();
            IdExpediente = idExpediente;
        }

        private void CreateBase()
		{
            Variante = 1;
 		}

		#endregion

		#region Properties

	
		public int IdExpediente { get; set; }
		public Expediente Expediente { get; set; }

        public Con_ExpedienteEstadoComun EstadoFaseComun { get; set; }

        public ModelGarantiaInmobiliaria ModelGarantiaInmobiliaria { get; set; }

        public List<ExpedienteDeudor> GarantiasPersonales { get; set; }
        public List<ConcursalGarantiaOtra> GarantiasOtras { get; set; }

        

        public string FileNameResult { get; set; }

        public string Errors { get; set; }
        public int Variante { get; set; }

        #endregion

        #region Properties ReadOnly 

        //public Hip_Inmueble Inmueble => InmuebleSet.IsEmpty() ? null : InmuebleSet[0];

        #endregion

        #region Methods

        //public string GetFincaTipoSubasta()
        //{
        //    if (Expediente.Hip_Inmueble.IsEmpty()) return string.Empty;
            
        //    var sbFincaTipoSubasta = "";
        //    foreach (var inmueble in Expediente.Hip_Inmueble)
        //        sbFincaTipoSubasta = sbFincaTipoSubasta + $"{inmueble.NumeroFinca} {inmueble.TipoSubasta.ToString("C")} , ";
      
        //    return sbFincaTipoSubasta;
        //}

        #endregion
    }
}
