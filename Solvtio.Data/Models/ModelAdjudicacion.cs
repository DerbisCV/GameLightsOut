using System;
using System.Text;
using Solvtio.Common;

namespace Solvtio.Models
{
    public class ModelAdjudicacion
    {
        public ModelAdjudicacion() { }

        public ModelAdjudicacion(Hip_ExpedienteEstadoAdjudicacion ee)
        {
            
            ExpedienteEstadoId = ee.ExpedienteEstadoId;
            FechaAdjudicacion = ee.FechaAdjudicacion ;
            //DocumentoActaAdjudicacionId = ee.DocumentoActaAdjudicacionId ;
            LiquidacionITP = ee.LiquidacionITP;
            FechaLiquidacionITP = ee.FechaLiquidacionITP;
            //DocumentoLiquidacionITPId = ee.DocumentoLiquidacionITPId;
            FechaCertificadoInscripcion = ee.FechaCertificadoInscripcion;
            //DocumentoCertificadoInscripcionId = ee.DocumentoCertificadoInscripcionId;
            FechaDiligenciaPosesion = ee.FechaDiligenciaPosesion;
            //DocumentoDiligenciaPosesionId = ee.DocumentoDiligenciaPosesionId;
            Inquilinos= ee.Inquilinos;
            FechaLanzamiento= ee.FechaLanzamiento;
            //DocumentoSolicitudLanzamientoId = ee.DocumentoSolicitudLanzamientoId;
            FechaEntregaLLaves = ee.FechaEntregaLLaves;
            //DocumentoEntregaLLavesId = ee.DocumentoEntregaLLavesId;
            Defectos = ee.Defectos;
            Subsanado = ee.Subsanado;
            FechaSubsanado = ee.FechaSubsanado;
            FormaPacifica = ee.FormaPacifica;
            Ocupantes = ee.Ocupantes;
            FechaVista = ee.FechaVista;
            //ContratoAlquiler = ee.ContratoAqluiler;
            FechaTestimonio = ee.FechaTestimonio;
            //DocumentoTestimonioDecretoId = ee.DocumentoTestimonioDecretoId;
            //DocumentoOcupantesId = ee.DocumentoOcupantesId;
            //DocumentoVistaOcupantesId = ee.DocumentoVistaOcupantesId;

            IdExpediente = ee.ExpedienteEstado.IdExpediente;
            NoExpediente = ee.ExpedienteEstado.Expediente.NoExpediente;
            ExpedienteRefExterna = ee.ExpedienteEstado.Expediente.ReferenciaExterna;

            Juzgado = ee.ExpedienteEstado.Expediente.JuzgadoName; // ""; // el del estado (presentacion demamda)
            Procurador = ee.ExpedienteEstado.Expediente.ProcuradorNombreCompleto; // el del estado (presentacion demamda)
            NotaRapida = ee.Nota;
            //EstadoSubastaObservaciones = expedienteEstadoDatoSubasta.Observaciones; // del estado subasta MotivoSuspension = ""; //Estado subasta onbsrer susp.

        }
        public int IdExpediente { get; set; }
        public string NoExpediente { get; set; }
        public string ExpedienteRefExterna { get; set; }

        public string Juzgado { get; set; }
        public string Procurador { get; set; }
        public string NotaRapida { get; set; }
        public int ExpedienteEstadoId { get; set; }
        public Nullable<System.DateTime> FechaAdjudicacion { get; set; }
        public Nullable<int> DocumentoActaAdjudicacionId { get; set; }
        public Nullable<bool> LiquidacionITP { get; set; }

        public Nullable<System.DateTime> FechaLiquidacionITP { get; set; }

        public Nullable<int> DocumentoLiquidacionITPId { get; set; }
        public Nullable<System.DateTime> FechaCertificadoInscripcion { get; set; }
        public Nullable<int> DocumentoCertificadoInscripcionId { get; set; }
        public Nullable<System.DateTime> FechaDiligenciaPosesion { get; set; }
        public Nullable<int> DocumentoDiligenciaPosesionId { get; set; }
        public Nullable<bool> Inquilinos { get; set; }
        public Nullable<System.DateTime> FechaLanzamiento { get; set; }
        public Nullable<int> DocumentoSolicitudLanzamientoId { get; set; }
        public Nullable<System.DateTime> FechaEntregaLLaves { get; set; }
        public Nullable<int> DocumentoEntregaLLavesId { get; set; }
        public Nullable<bool> Defectos { get; set; }
        public Nullable<bool> Subsanado { get; set; }
        public Nullable<System.DateTime> FechaSubsanado { get; set; }
        public Nullable<bool> FormaPacifica { get; set; }
        public Nullable<bool> Ocupantes { get; set; }
        public Nullable<System.DateTime> FechaVista { get; set; }
        public Nullable<bool> ContratoAlquiler { get; set; }
        public Nullable<System.DateTime> FechaTestimonio { get; set; }
        public Nullable<int> DocumentoTestimonioDecretoId { get; set; }
        public Nullable<int> DocumentoOcupantesId { get; set; }
        public Nullable<int> DocumentoVistaOcupantesId { get; set; }
        
        private String _FechaLiquidacionITPStr;
        public String FechaLiquidacionITPStr
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_FechaLiquidacionITPStr))
                {
                    _FechaLiquidacionITPStr = FechaLiquidacionITP.HasValue ? FechaLiquidacionITP.Value.ToString("dd/MM/yyyy-HH:mm") : "-";
                }

                return _FechaLiquidacionITPStr;
            }
        }

        private String _FechaAdjudicacionStr;
        public String FechaAdjudicacionStr
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_FechaAdjudicacionStr))
                {
                    _FechaAdjudicacionStr = FechaAdjudicacion.HasValue ? FechaAdjudicacion.Value.ToString("dd/MM/yyyy-HH:mm") : "-";
                }

                return _FechaAdjudicacionStr;
            }
        }

        private String _FechaCertificadoInscripcionStr;
        public String FechaCertificadoInscripcionStr
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_FechaCertificadoInscripcionStr))
                {
                    _FechaCertificadoInscripcionStr = FechaCertificadoInscripcion.HasValue ? FechaLiquidacionITP.Value.ToString("dd/MM/yyyy-HH:mm") : "-";
                }

                return _FechaCertificadoInscripcionStr;
            }
        }

        private String _FechaDiligenciaPosesionStr;
        public String FechaDiligenciaPosesionStr
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_FechaDiligenciaPosesionStr))
                {
                    _FechaDiligenciaPosesionStr = FechaDiligenciaPosesion.HasValue ? FechaDiligenciaPosesion.Value.ToString("dd/MM/yyyy-HH:mm") : "-";
                }

                return _FechaDiligenciaPosesionStr;
            }
        }

        private String _FechaLanzamientoStr;
        public String FechaLanzamientoStr
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_FechaLanzamientoStr))
                {
                    _FechaLanzamientoStr = FechaLanzamiento.HasValue ? FechaLanzamiento.Value.ToString("dd/MM/yyyy-HH:mm") : "-";
                }

                return _FechaLanzamientoStr;
            }
        }

        private String _FechaEntregaLLavesStr;
        public String FechaEntregaLLavesStr
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_FechaEntregaLLavesStr))
                {
                    _FechaEntregaLLavesStr = FechaEntregaLLaves.HasValue ? FechaEntregaLLaves.Value.ToString("dd/MM/yyyy-HH:mm") : "-";
                }

                return _FechaEntregaLLavesStr;
            }
        }

        private string _masInfoHtml;
        public string MasInfoHtml
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_masInfoHtml))
                {
                    var sb = new StringBuilder();
                    
                    AppendInfo(sb, "Juzgado", Juzgado);
                    AppendInfo(sb, "Procurador", Procurador);
                    //AppendInfo(sb, "Nota", NotaRapida);

                    _masInfoHtml = sb.ToString();
                }

                return _masInfoHtml;
            }
        }

        private void AppendInfo(StringBuilder sb, string toShow, object value)
        {
            //var valueStr = "";
            //if (value.GetType() == System.DateTime)
            //    valueStr = value.ToString
            if (value != null && !string.IsNullOrWhiteSpace(value.ToString()))
                sb.AppendFormat("<span class='field-name-small'>{0}</span><span class='field-value-small'>: {1}{2}</span>", toShow, value, HtmlHelpers.HTML_BR);
        }
    }
}
