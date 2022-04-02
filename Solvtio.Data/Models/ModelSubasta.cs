using Solvtio.Common;
using System;
using System.Linq;
using System.Text;


namespace Solvtio.Models
{
    public class ModelSubasta
	{
		public ModelSubasta()
		{
		}

        public ModelSubasta(Hip_ExpedienteEstadoSubasta expedienteEstadoDatoSubasta)
		{
            Hip_ExpedienteEstadoSubasta = expedienteEstadoDatoSubasta;

			IdSubasta = expedienteEstadoDatoSubasta.ExpedienteEstadoId;
			IdExpediente = expedienteEstadoDatoSubasta.ExpedienteEstado.IdExpediente;
			NoExpediente = expedienteEstadoDatoSubasta.ExpedienteEstado.Expediente.NoExpediente;
			ExpedienteRefExterna = expedienteEstadoDatoSubasta.ExpedienteEstado.Expediente.ReferenciaExterna;
			NotaRapida = expedienteEstadoDatoSubasta.Nota;
            

			FechaSubasta = expedienteEstadoDatoSubasta.FechaCelebracionSubasta1;
			FechaSubasta2 = expedienteEstadoDatoSubasta.FechaCelebracionSubasta2;
			FechaSubastaActa = expedienteEstadoDatoSubasta.FechaActaSubasta;
			FechaSolicitudAdjudicacion = expedienteEstadoDatoSubasta.FechaAdjudicacion;
            AutorizadoEnvioGestor = expedienteEstadoDatoSubasta.AutorizadoEnvioGestor;


			Consignar = expedienteEstadoDatoSubasta.Consignar;
			Iva = expedienteEstadoDatoSubasta.IsIva;
			Cesion = expedienteEstadoDatoSubasta.DocumentoCesionRemateId.HasValue;
	        Titulizada = expedienteEstadoDatoSubasta.ExpedienteEstado.Expediente.Hip_Expediente.EsTitulizado;

			Suspendida = expedienteEstadoDatoSubasta.SubastaSuspension.HasValue && expedienteEstadoDatoSubasta.SubastaSuspension.Value;
			Suspendida2 = expedienteEstadoDatoSubasta.SubastaSuspension2.HasValue && expedienteEstadoDatoSubasta.SubastaSuspension2.Value;
            Oposicion = expedienteEstadoDatoSubasta.Oposicion;

            CantidadAlertasExpediente = expedienteEstadoDatoSubasta.ExpedienteEstado.Expediente.ExpedienteAlertas
                .Count(x => x.Activo);

			ClienteOficina = expedienteEstadoDatoSubasta.ExpedienteEstado.Expediente.Gnr_ClienteOficina.Nombre;
			Juzgado = expedienteEstadoDatoSubasta.ExpedienteEstado.Expediente.JuzgadoName; // ""; // el del estado (presentacion demamda)
			Procurador = expedienteEstadoDatoSubasta.ExpedienteEstado.Expediente.ProcuradorNombreCompleto; // el del estado (presentacion demamda)
			//EstadoSubastaObservaciones = expedienteEstadoDatoSubasta.Observaciones; // del estado subasta MotivoSuspension = ""; //Estado subasta onbsrer susp.

			DecisionPociento = expedienteEstadoDatoSubasta.DecisionPociento; // el campo nuevo

            LiquidadcionIntereses = expedienteEstadoDatoSubasta.LiquidacionIntereses; //  del estado subasta
            //Costas = expedienteEstadoDatoSubasta.Costas; // del estado subasta
            ImpAdjudicacion = expedienteEstadoDatoSubasta.ImporteAdjudicacion; // del estado subasta

			FechaBoe = expedienteEstadoDatoSubasta.FechaBoe;
			FechaCierrePuja = expedienteEstadoDatoSubasta.FechaCierrePuja;
			FechaFinMejoraPuja = expedienteEstadoDatoSubasta.FechaFinMejoraPuja;
			FechaSolicitudAdjudicacionLimite = expedienteEstadoDatoSubasta.FechaSolicitudAdjudicacionLimite;
		}

		public int IdSubasta { get; set; }
		public int IdExpediente { get; set; }
		public string NoExpediente { get; set; }
		public string ExpedienteRefExterna { get; set; }
        public string NotaRapida { get; set; }


		public Hip_ExpedienteEstadoSubasta Hip_ExpedienteEstadoSubasta { get; set; }

		public DateTime? FechaSubasta { get; set; }
		public DateTime? FechaSubasta2 { get; set; }
		public DateTime? FechaSubastaActa { get; set; }
		public DateTime? FechaSolicitudAdjudicacion { get; set; }
        public DateTime? AutorizadoEnvioGestor { get; set; }

		public DateTime? FechaBoe { get; set; }
		public DateTime? FechaCierrePuja { get; set; }
		public DateTime? FechaFinMejoraPuja { get; set; }
		public DateTime? FechaSolicitudAdjudicacionLimite { get; set; }

		public string ClienteOficina { get; set; }
		public string Juzgado { get; set; }
		
		public string EstadoSubastaObservaciones { get; set; }
		public string Procurador { get; set; }
        //public string MotivoSuspension { get; set; }

		public bool Consignar { get; set; }
		public bool Iva { get; set; }
		public bool Cesion { get; set; }
		public bool Titulizada { get; set; }
        public bool Suspendida { get; set; }
		public bool Suspendida2 { get; set; } 
        public bool Oposicion { get; set; }

		public decimal? LiquidadcionIntereses { get; set; }
		public decimal? Costas { get; set; }
		public decimal? DecisionPociento { get; set; }
		public decimal? ImpAdjudicacion { get; set; }

        public int CantidadAlertasExpediente { get; set; }

		private string _fechaSubastaStr;
		public string FechaSubastaStr
		{
			get
			{
				if (string.IsNullOrWhiteSpace(_fechaSubastaStr))
				{
					_fechaSubastaStr = FechaSubasta.HasValue ? FechaSubasta.Value.ToString("dd/MM/yyyy-HH:mm") : "-";
				}

				return _fechaSubastaStr;
			}
		}

		private string _fechaSubastaActaStr;
		public string FechaSubastaActaStr
		{
			get
			{
				if (string.IsNullOrWhiteSpace(_fechaSubastaActaStr))
				{
					_fechaSubastaActaStr = FechaSubastaActa.HasValue ? FechaSubastaActa.Value.ToString("dd/MM/yyyy-HH:mm") : "-";
				}

				return _fechaSubastaActaStr;
			}
		}

		private string _fechaSolicitudAdjudicacionStr;
		public string FechaSolicitudAdjudicacionStr
		{
			get
			{
				if (string.IsNullOrWhiteSpace(_fechaSolicitudAdjudicacionStr))
				{
					_fechaSolicitudAdjudicacionStr = FechaSolicitudAdjudicacion.HasValue ? FechaSolicitudAdjudicacion.Value.ToString("dd/MM/yyyy HH:mm") : "-";
				}

				return _fechaSolicitudAdjudicacionStr;
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
        }


	}
}
