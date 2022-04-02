using System.Collections.Generic;
using System.Linq;
using Solvtio.Common;

namespace Solvtio.Models
{
    public class ModelGenerarFichaNegociacion
    {
		#region Constructors
		public ModelGenerarFichaNegociacion()
		{
			CreateBase();
		}

		private void CreateBase()
		{
			Errores = new List<string>();
		}
		#endregion

		#region Properties

		public ExpedienteNegociacion ExpedienteNegociacion { get; set; }
		public Usuario ContenciosoGestor { get; set; }
		//public Hip_Inmueble Inmueble { get; set; }

		//public string UrlCrearDemanda { get; set; }
        public string FullPathFileGenerated { get; set; }

        public List<string> Errores { get; set; }

        #endregion

        #region Properties ReadOnly

        public bool HasError => Errores.IsNotEmpty();
        public Expediente Expediente => ExpedienteNegociacion.Expediente;
        public Hip_Inmueble Inmueble => Expediente.Hip_Inmueble.FirstOrDefault();
        public Usuario Gestor => ExpedienteNegociacion.Gestor;

        public ExpedienteDeudor DeudorPrincipal
        {
            get
            {
                if (Expediente == null || Expediente.ExpedienteDeudors.IsEmpty()) return null;
                return Expediente.ExpedienteDeudors.Any(x => x.IdTipoDeudor == 1) ? 
                    Expediente.ExpedienteDeudors.First(x => x.IdTipoDeudor == 1) : 
                    Expediente.ExpedienteDeudors.First();
            }
        }

        #endregion

        public bool IsValid()
        {
            if (ExpedienteNegociacion == null)
            {
                Errores.Add("Debe especificar el expediente de negociación.");
                return false;
            }

            if (Expediente == null) Errores.Add("Debe especificar el expediente.");
            if (Inmueble == null) Errores.Add("Debe especificar al menos un inmueble.");

            return !HasError;
        }
    }
}
