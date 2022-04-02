using Solvtio.Common;
using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelPropuestaSubasta
    {
        #region Constructors

        public ModelPropuestaSubasta()
        {
            CreateBase();
        }
        public ModelPropuestaSubasta(int idExpediente)
        {
            CreateBase();
            IdExpediente = idExpediente;
        }
        public ModelPropuestaSubasta(int idExpediente, int? tipo, string title)
        {
            CreateBase();
            IdExpediente = idExpediente;
            Tipo = tipo;
            Title = title;
        }

        private void CreateBase()
        {
            Variante = 1;
        }

        #endregion

        #region Properties

        public int IdExpediente { get; set; }
        public Expediente Expediente { get; set; }

        public HipExpedienteEstadoPresentacionDemanda EstadoPresentacionDemanda { get; set; }
        public HipExpedienteEstadoTramitacionSubasta EstadoTramitacionSubasta { get; set; }
        public List<Hip_Inmueble> InmuebleSet { get; set; }
        public string FileNameResult { get; set; }
        public string FileNamePartial { get; set; }
        public int? Tipo { get; set; }
        public string Title { get; set; }

        public ExpedienteVista VistaLanzamiento { get; set; }
        public ExpedienteVista VistaLanzamientoSuspendido { get; set; }
        public ExpedienteVista VistaCelebracion { get; set; }
        public Impulso ImpulsoLast { get; set; }

        public Hip_HipotecaDatoEscritura Escritura { get; set; }

        public string Errors { get; set; }
        public int Variante { get; set; }

        #endregion

        #region Properties ReadOnly 

        public Hip_Inmueble Inmueble => InmuebleSet.IsEmpty() ? null : InmuebleSet[0];

        #endregion

        #region Methods

        public string GetFincaTipoSubasta()
        {
            if (Expediente.Hip_Inmueble.IsEmpty()) return string.Empty;

            var sbFincaTipoSubasta = "";
            foreach (var inmueble in Expediente.Hip_Inmueble)
                sbFincaTipoSubasta = sbFincaTipoSubasta + $"{inmueble.NumeroFinca} {inmueble.TipoSubasta.ToString("C")} , ";

            return sbFincaTipoSubasta;
        }

        #endregion
    }
}
