using System;
using System.Text;
using Solvtio.Common;

namespace Solvtio.Models
{
    public class ModelITP
    {
        public ModelITP()
        {
        }

        public ModelITP(Hip_ExpedienteEstadoAdjudicacion expedienteEstadoDatoAdjudicacion)
        {
            //encabezado
            IdExpediente = expedienteEstadoDatoAdjudicacion.ExpedienteEstado.IdExpediente;
            NoExpediente = expedienteEstadoDatoAdjudicacion.ExpedienteEstado.Expediente.NoExpediente;
            ExpedienteRefExterna = expedienteEstadoDatoAdjudicacion.ExpedienteEstado.Expediente.ReferenciaExterna;

            ExpedienteEstadoId = expedienteEstadoDatoAdjudicacion.ExpedienteEstadoId;
            FechaAdjudicacion = expedienteEstadoDatoAdjudicacion.FechaAdjudicacion;
            //DocumentoActaAdjudicacionId = expedienteEstadoDatoAdjudicacion.DocumentoActaAdjudicacionId;
            LiquidacionITP = expedienteEstadoDatoAdjudicacion.LiquidacionITP;
            FechaLiquidacionITP = expedienteEstadoDatoAdjudicacion.FechaLiquidacionITP;
            //DocumentoLiquidacionITPId = expedienteEstadoDatoAdjudicacion.DocumentoLiquidacionITPId;
            FechaCertificadoInscripcion = expedienteEstadoDatoAdjudicacion.FechaCertificadoInscripcion;
            //DocumentoCertificacionInscripcionId = expedienteEstadoDatoAdjudicacion.DocumentoCertificadoInscripcionId;
            FechaDiligenciaPosesion = expedienteEstadoDatoAdjudicacion.FechaDiligenciaPosesion;
            //DocumentoDiligenciaPosesionId = expedienteEstadoDatoAdjudicacion.DocumentoDiligenciaPosesionId;
            Inquilinos = expedienteEstadoDatoAdjudicacion.Inquilinos;
            FechaLanzamiento = expedienteEstadoDatoAdjudicacion.FechaLanzamiento;
            //DocumentoSolicitudLanzamientoId = expedienteEstadoDatoAdjudicacion.DocumentoSolicitudLanzamientoId;
            FechaEntregaLlaves = expedienteEstadoDatoAdjudicacion.FechaEntregaLLaves;
            //DocumentoEntregaLLavesId = expedienteEstadoDatoAdjudicacion.DocumentoEntregaLLavesId;
            Juzgado = expedienteEstadoDatoAdjudicacion.ExpedienteEstado.Expediente.JuzgadoName; // ""; // el del estado (presentacion demamda)
            Procurador = expedienteEstadoDatoAdjudicacion.ExpedienteEstado.Expediente.ProcuradorNombreCompleto; // el del estado (presentacion demamda)
            TestimonioFecha = expedienteEstadoDatoAdjudicacion.FechaTestimonio;
           /* Defectos = expedienteEstadoDatoAdjudicacion.Defectos;
            Subsanado = expedienteEstadoDatoAdjudicacion.Subsanado;
            SubsanadoFecha = expedienteEstadoDatoAdjudicacion.SubsanadoFecha;
            TestimonioFecha = expedienteEstadoDatoAdjudicacion.TestimonioFecha;
            FormaPacifica = expedienteEstadoDatoAdjudicacion.FormaPacifica;
            Vistafecha = expedienteEstadoDatoAdjudicacion.VistaFecha;
            ContratoAlquiler = expedienteEstadoDatoAdjudicacion.ContratoAlquiler;
            DocumentoTestimonioDecretoAdjudicacionId = expedienteEstadoDatoAdjudicacion.DocumentoTestimonioDecretoAdjudicacionId;
            DocumentoOcupantesId = expedienteEstadoDatoAdjudicacion.DocumentoOcupantesId;
            DocumentoVistaOcupantesId = expedienteEstadoDatoAdjudicacion.DocumentoVistaOcupantesId;*/
            NotaRapida = expedienteEstadoDatoAdjudicacion.Nota;
          
            

            /*  Consignar = expedienteEstadoDatoSubasta.Consignar;
                Iva = expedienteEstadoDatoSubasta.IsIva;
                Cesion = expedienteEstadoDatoSubasta.DocumentoCesionRemateId.HasValue;
                //Titulizada = expedienteEstadoDatoSubasta.IdTipoTitulizado.HasValue;
                Titulizada = expedienteEstadoDatoSubasta.ExpedienteEstado.Expediente.EsTitulizado;

                Suspendida = expedienteEstadoDatoSubasta.Suspendida;
                Oposicion = expedienteEstadoDatoSubasta.Oposicion;

                CantidadAlertasExpediente = expedienteEstadoDatoSubasta.ExpedienteEstado.Expediente.ExpedienteAlertas
                    .Count(x => x.Activo);


                Juzgado = expedienteEstadoDatoSubasta.ExpedienteEstado.Expediente.JuzgadoAdmisionDemanda; // ""; // el del estado (presentacion demamda)
                Procurador = expedienteEstadoDatoSubasta.ExpedienteEstado.Expediente.ProcuradorNombreCompleto; // el del estado (presentacion demamda)
                EstadoSubastaObservaciones = expedienteEstadoDatoSubasta.Observaciones; // del estado subasta MotivoSuspension = ""; //Estado subasta onbsrer susp.

                DecisionPociento = expedienteEstadoDatoSubasta.DecisionPociento; // el campo nuevo

                LiquidadcionIntereses = expedienteEstadoDatoSubasta.LiquidacionIntereses; //  del estado subasta
                //Costas = expedienteEstadoDatoSubasta.Costas; // del estado subasta
                ImpAdjudicacion = expedienteEstadoDatoSubasta.ImporteAdjudicacion; // del estado subasta*/

        }

        public int? IdExpediente { get; set; }
        public string NoExpediente { get; set; }
        public string ExpedienteRefExterna { get; set; }
        public int? ExpedienteEstadoId { get; set; }
        public string Juzgado { get; set; }
        public string Procurador { get; set; }
        public string NotaRapida { get; set; }
        public DateTime? FechaAdjudicacion { get; set; }
        public int? DocumentoActaAdjudicacionId { get; set; }
        public bool? LiquidacionITP { get; set; }
        public DateTime? FechaLiquidacionITP { get; set; }
        public int? DocumentoLiquidacionITPId { get; set; }
        public DateTime? FechaCertificadoInscripcion { get; set; }
        public int?  DocumentoCertificacionInscripcionId { get; set; }
        public DateTime? FechaDiligenciaPosesion { get; set; }
        public int? DocumentoDiligenciaPosesionId { get; set; }
        public bool? Inquilinos { get; set; }
        public DateTime? FechaLanzamiento { get; set; }
        public int? DocumentoSolicitudLanzamientoId { get; set; }
        public DateTime? FechaEntregaLlaves { get; set; }
        public int? DocumentoEntregaLLavesId { get; set; }
        public bool? Defectos { get; set; }
        public bool? Subsanado { get; set; }
        public DateTime? SubsanadoFecha { get; set; }
        public DateTime? TestimonioFecha { get; set; }

        public DateTime? TestimonioFechaCalendario {
            get { return TestimonioFecha.Value.AddDays(20); }
        }
        public bool? FormaPacifica { get; set; }
        public DateTime? Vistafecha { get; set; }
        public bool? ContratoAlquiler { get; set; }
        public int? DocumentoTestimonioDecretoAdjudicacionId { get; set; }
        public int? DocumentoOcupantesId { get; set; }
        public int? DocumentoVistaOcupantesId { get; set; }

        //----------------------------------------------------------
        //prop conversion de FechaAdjudicacion a string
        private string _fechaAdjudicacionStr;
        public string FechaAdjudicacionStr
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_fechaAdjudicacionStr))
                {
                    _fechaAdjudicacionStr = FechaAdjudicacion.HasValue ? FechaAdjudicacion.Value.ToString("dd/MM/yyyy-HH:mm") : "-";
                }

                return _fechaAdjudicacionStr;
            }
        }

        private string _fechaTestimonioStr;
        public string FechaTestimonioStr
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_fechaTestimonioStr))
                {
                    _fechaTestimonioStr = TestimonioFecha.HasValue ? TestimonioFecha.Value.ToString("dd/MM/yyyy-HH:mm") : "-";
                }

                return _fechaTestimonioStr;
            }
        }
        //prop conversion de FechaLiquidacionITP a string
        private string _fechaLiquidacionITPStr;
        public string FechaLiquidacionITPStr
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_fechaLiquidacionITPStr))
                {
                    _fechaLiquidacionITPStr = FechaLiquidacionITP.HasValue ? FechaLiquidacionITP.Value.ToString("dd/MM/yyyy-HH:mm") : "-";
                }

                return _fechaLiquidacionITPStr;
            }
        }

        //prop conversion de FechaCertificadoInscripcion a string
        private string _fechaCertificadoInscripcionStr;
        public string FechaCertificadoInscripcionStr
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_fechaCertificadoInscripcionStr))
                {
                    _fechaCertificadoInscripcionStr = FechaCertificadoInscripcion.HasValue ? FechaCertificadoInscripcion.Value.ToString("dd/MM/yyyy HH:mm") : "-";
                }

                return _fechaCertificadoInscripcionStr;
            }
        }

        //prop conversion de FechaLanzamiento a string
        private string _fechaLanzamientoStr;
        public string FechaLanzamientoStr
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_fechaLanzamientoStr))
                {
                    _fechaLanzamientoStr = FechaLanzamiento.HasValue ? FechaLanzamiento.Value.ToString("dd/MM/yyyy HH:mm") : "-";
                }

                return _fechaLanzamientoStr;
            }
        }

        //prop conversion de FechaEntregaLlaves a string
        private string _fechaEntregaLlavesStr;
        public string FechaEntregaLlavesStr
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_fechaEntregaLlavesStr))
                {
                    _fechaEntregaLlavesStr = FechaEntregaLlaves.HasValue ? FechaEntregaLlaves.Value.ToString("dd/MM/yyyy HH:mm") : "-";
                }

                return _fechaEntregaLlavesStr;
            }
        }



        //prop conversion de SubsanadoFecha a string
        private string _subsanadoFechaStr;
        public string SubsanadoFechaStr
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_subsanadoFechaStr))
                {
                    _subsanadoFechaStr = SubsanadoFecha.HasValue ? SubsanadoFecha.Value.ToString("dd/MM/yyyy HH:mm") : "-";
                }

                return _subsanadoFechaStr;
            }
        }

        //prop conversion de TestimonioFecha a string
        private string _testimonioFechaStr;
        public string TestimonioFechaStr
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_testimonioFechaStr))
                {
                    _testimonioFechaStr = TestimonioFecha.HasValue ? TestimonioFecha.Value.ToString("dd/MM/yyyy HH:mm") : "-";
                }

                return _testimonioFechaStr;
            }
        }


        //prop conversion de Vistafecha a string
        private string _vistafechaStr;
        public string VistafechaStr
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_vistafechaStr))
                {
                    _vistafechaStr = Vistafecha.HasValue ? Vistafecha.Value.ToString("dd/MM/yyyy HH:mm") : "-";
                }
                return _vistafechaStr;
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
        //----------------------------------------------------------

        /*
                private string _masInfoHtml;
                public string MasInfoHtml
                {
                    get
                    {
                        if (string.IsNullOrWhiteSpace(_masInfoHtml))
                        {
                            var sb = new StringBuilder();

                            AppendInfo(sb, "Observaciones", EstadoSubastaObservaciones);
                            AppendInfo(sb, "Juzgado", Juzgado);
                            AppendInfo(sb, "Procurador", Procurador);
                            AppendInfo(sb, "Decisión (%)", DecisionPociento);
                            AppendInfo(sb, "Liquidadción Intereses", LiquidadcionIntereses);
                            AppendInfo(sb, "Imp. Adjudicación", ImpAdjudicacion);
                            AppendInfo(sb, "Solicitud de Autorización", AutorizadoEnvioGestor);
                            AppendInfo(sb, "Nota", NotaRapida);

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
                }*/


    }
}
