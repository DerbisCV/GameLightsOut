using System;
using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelCalendarioDiaVistas //: IModelCalendarioDiaBase
    {
		public ModelCalendarioDiaVistas() { CreateBase(); }


        public ModelCalendarioDiaVistas(int countTotal, int countWithOpposition)
        {
            CountWithOpposition = countWithOpposition;
            CountWithOutOpposition = countTotal - countWithOpposition;
        }

		private void CreateBase()
		{
			LstModelVistaResumen = new List<ModelVistaResumen>();
		}

        public int CountWithOpposition { get; set; }
        public int CountWithOutOpposition { get; set; }


		public List<ModelVistaResumen> LstModelVistaResumen { get; set; }
        public List<Alq_Expediente_EstadoTramitaJuzgado_Actuacion> LstActuacion { get; set; }
    }

	public class ModelVistaResumen
	{
		public ModelVistaResumen() { }
		public ModelVistaResumen(string clasification, List<ModelVistaExpediente> lstExp, int count)
		{
            Clasification = clasification;
            LstExpedientes = lstExp;
            Count = count;
		}

        public ModelVistaResumen(string clasification, int count)
        {
            Clasification = clasification;
            Count = count;
        }

        public string Clasification { get; set; }

        public int Count { get; set; }
        public List<ModelVistaExpediente> LstExpedientes { get; set; }
	}

    public class ModelVistaExpediente
    {
        #region Constructors

        public ModelVistaExpediente() {}
        public ModelVistaExpediente(int idExpediente, string noExpediente)
        {
            IdExp = idExpediente;
            NoExp = noExpediente;
        }
        public ModelVistaExpediente(ExpedienteVencimiento expVencimiento)
        {
            IdExp = expVencimiento.IdExpediente;
            NoExp = expVencimiento.Expediente.NoExpediente;
            FechaHora = expVencimiento.Fecha;
            ExpedienteVencimiento = expVencimiento;
        }
        public ModelVistaExpediente(ExpedienteVista expVista)
        {
            IdExp = expVista.IdExpediente;
            NoExp = expVista.Expediente.NoExpediente;
            FechaHora = expVista.Fecha;
            //ExpedienteVencimiento = expVencimiento;
            Abogado = expVista.Abogado;
        }

        #endregion

        #region Properties

        public int IdExp { get; set; }
        public string NoExp { get; set; }
        private DateTime? FechaHora { get; }
        private string Hora => FechaHora?.ToString("HH:mm") ?? "";
        private ExpedienteVencimiento ExpedienteVencimiento { get; }
        public Gnr_Abogado Abogado { get; set; }

        #endregion

        public string ToStringHtml(string clasificacion)
        {
            var classDom = ExpedienteVencimiento == null ? "" : 
                ExpedienteVencimiento.Ejecutado ? "text-primary" : 
                "text-danger";
            var textHora = string.IsNullOrWhiteSpace(Hora) || Hora.Equals("00:00") ? "" : $"{Hora}: ";
            var textAbogado = Abogado == null ? "" : $" <small>({Abogado.Persona.Nombre})</small>";

            return $"<p class='{classDom}'>{textHora}{clasificacion} - <strong>{NoExp}</strong>{textAbogado}</p>";
        }

    }
}
