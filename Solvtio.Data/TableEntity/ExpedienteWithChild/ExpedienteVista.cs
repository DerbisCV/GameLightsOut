using System;
using Solvtio.Models.Model;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;

namespace Solvtio.Models
{
    public class ExpedienteVista
    {
        #region Constructors

        public ExpedienteVista()
        {
            CreateBase();
        }

        public ExpedienteVista(Expediente expediente)
        {
            CreateBase();
            IdExpediente = expediente.IdExpediente;
            Expediente = expediente;
            IdAbogado = expediente.IdAbogado;
        }
        public ExpedienteVista(int idExpediente, int tipoVista, DateTime fecha, string observaciones = "", bool oposicion = false, int? idInmueble = null)
        {
            CreateBase();

            IdExpediente = idExpediente;
            IdTipoVista = tipoVista;
            Fecha = fecha;
            Observaciones = observaciones;
            Oposicion = oposicion;
            IdInmueble = idInmueble;
        }

        private void CreateBase()
        {
            Oposicion = false;
            Fecha = DateTime.Now;
            FechaAlta = DateTime.Now;
        }

        #endregion

        #region Properties

        public int IdExpedienteVista { get; set; }

        [Index("IX_IdExpedienteAndIdTipoVista", 1)]
        public int IdExpediente { get; set; }
        public virtual Expediente Expediente { get; set; }

        [Index("IX_IdExpedienteAndIdTipoVista", 2)]
        public int IdTipoVista { get; set; }
        public virtual TipoVista TipoVista { get; set; }

        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }

        public int? IdAbogado { get; set; }
        [ForeignKey("IdAbogado")]
        public virtual Gnr_Abogado Abogado { get; set; }

        public int? IdExpedienteEstado { get; set; }
        public int? IdInmueble { get; set; }
        [ForeignKey("IdInmueble")]
        public virtual Hip_Inmueble Inmueble { get; set; }

        public int? IdItemCalendarInSp { get; set; }

        public bool Telematica { get; set; }
        public bool Oposicion { get; set; }
        public bool Suspendida { get; set; }
        public bool Realizada { get; set; }

        public int? IdMotivoSuspension { get; set; }
        [ForeignKey("IdMotivoSuspension")]
        public virtual CaracteristicaBase MotivoSuspension { get; set; }
        public PositivoNegativoType? Resultado { get; set; }

        public string Usuario { get; set; }
        public DateTime FechaAlta { get; set; }

        #endregion

        #region Properties ReadOnly

        public TipoVistaEnum? TipoVistaEnum  => (TipoVistaEnum?)IdTipoVista;
        public bool EstaSuspendida => Suspendida || IdMotivoSuspension.HasValue;
        private string Hora => Fecha.ToString("HH:mm") ?? "";

        public string MessageHito
        {
            get
            {
                var result = TipoVista.Nombre;
                if (Suspendida) result += ", Suspendida";
                if (MotivoSuspension != null) result += ", " + MotivoSuspension.Nombre;

                return result;
            }
        }

        #endregion

        public string ToStringHtml()
        {
            var classDom = EstaSuspendida ? "text-danger" : Oposicion ? "text-warning" : "text-primary";
            var textHora = string.IsNullOrWhiteSpace(Hora) || Hora.Equals("00:00") ? "" : $"{Hora}: ";
            var textResultado = 
                Resultado == PositivoNegativoType.Positivo ? $" <i class='icon-thumbs-up text-info'></i>" :
                Resultado == PositivoNegativoType.Negativo ? $" <i class='icon-thumbs-down text-warning'></i>" :
                "";
            var textTipoVista = TipoVista == null ? "" : $" ({TipoVista.Clasificacion}{textResultado})";
            var textAbogado = Abogado == null || IdAbogado == 0 ? "" : $" <small>({Abogado.Persona.NombreApellidos})</small>";

            if (Expediente.TipoExpediente == TipoExpedienteEnum.MultiDivisa && string.IsNullOrWhiteSpace(textAbogado))
                textAbogado = $" <small>({Usuario.Replace("@tarsso.com", "")})</small>";

            return $"<span class='{classDom}'>{textHora} <strong>{Expediente.TipoExpediente.GetDescriptionShort()} {Expediente.NoExpediente}</strong>{textTipoVista}{textAbogado}</span>";
        }

    }
}
