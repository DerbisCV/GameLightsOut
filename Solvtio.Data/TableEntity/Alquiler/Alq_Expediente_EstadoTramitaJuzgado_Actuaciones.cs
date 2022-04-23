using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("Alq_Expediente_EstadoTramitaJuzgado_Actuaciones")]
	public partial class Alq_Expediente_EstadoTramitaJuzgado_Actuacion
    {
        public int ID { get; set; }
        public int? IDestado { get; set; }
        public DateTime? Fecha { get; set; }
        public int? IDtipo { get; set; }
        public string Observaciones { get; set; }

        public int? IdAbogado { get; set; }
        [ForeignKey("IdAbogado")]
        public virtual Gnr_Abogado Abogado { get; set; }

        public virtual Alq_Expediente_EstadoTramitaJuzgado Alq_Expediente_EstadoTramitaJuzgado { get; set; }
        public virtual Gnr_ListasValores_Valores Gnr_ListasValores_Valores { get; set; }

        #region Properties ReadOnly

        private string Hora => Fecha?.ToString("HH:mm") ?? "";

        #endregion

        public string ToStringHtml()
        {
            var classDom = Alq_Expediente_EstadoTramitaJuzgado == null ? "" :
                Alq_Expediente_EstadoTramitaJuzgado.Oposicion ? "text-danger" :
                "text-primary";
            var textHora = string.IsNullOrWhiteSpace(Hora) || Hora.Equals("00:00") ? "" : $"{Hora}: ";
            var textAbogado = Abogado == null ? "" : $" <small>({Abogado.Persona.Nombre})</small>";

            return $"<span class='{classDom}'>{textHora} - <strong>{Alq_Expediente_EstadoTramitaJuzgado.ExpedienteEstado.Expediente.NoExpediente}</strong>{textAbogado}</span>";
        }

        //<a href = "@Url.Action(MVC.Alquiler.TramitaJuzgadoEdit(actuacion.IDestado))" target="_blank">
        //                            @actuacion.Fecha.Value.ToString("HH:mm") - <strong>@actuacion.Alq_Expediente_EstadoTramitaJuzgado.ExpedienteEstado.Expediente.NoExpediente</strong>
        //                            @if(actuacion.Abogado != null)
        //{
        //                                < small > (@actuacion.Abogado.Persona.Nombre) </ small >
        //                            }
        //                        </a>

    }
}
