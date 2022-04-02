using Solvtio.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvtio.Models
{
    public class ModelExpedienteHipotecarioTiemposMedios
    {
        #region Constructors

        public ModelExpedienteHipotecarioTiemposMedios()
        {
        }
        public ModelExpedienteHipotecarioTiemposMedios(Hip_Expediente expHipotecario)
        {
            IdExpediente = expHipotecario.IdExpediente;
            NoExpediente = expHipotecario.Expediente.NoExpediente;
            ReferenciaExterna = expHipotecario.Expediente.ReferenciaExterna;

            ClienteOficina = expHipotecario.Expediente.Gnr_ClienteOficina.Nombre;
            Cliente = expHipotecario.Expediente.Gnr_ClienteOficina.Gnr_Cliente.Nombre;
            Juzgado = expHipotecario.Expediente.Juzgado;

            var estadoRecepcionExpediente = expHipotecario.Expediente.ExpedienteEstadoes.FirstOrDefault(x => x.TipoEstadoValue == ExpedienteEstadoTipo.RecepcionExpediente);
            var estadoPresentacionDemanda = expHipotecario.Expediente.ExpedienteEstadoes.FirstOrDefault(x => x.TipoEstadoValue == ExpedienteEstadoTipo.HipotecarioPresentacionDemanda);
            var estadoTramitacionJuzgado = expHipotecario.Expediente.ExpedienteEstadoes.FirstOrDefault(x => x.TipoEstadoValue == ExpedienteEstadoTipo.HipotecarioTramitacionSubasta);
            var estadoSubasta = expHipotecario.Expediente.ExpedienteEstadoes.FirstOrDefault(x => x.TipoEstadoValue == ExpedienteEstadoTipo.HipotecarioSubasta);
            var subasta = expHipotecario.Expediente.ExpedienteSubastaLast;
            var estadoAdjudicacion = expHipotecario.Expediente.ExpedienteEstadoes.FirstOrDefault(x => x.TipoEstadoValue == ExpedienteEstadoTipo.HipotecarioAdjudicacionDelBien);

            if (estadoRecepcionExpediente != null)
                FechaRecepcion = estadoRecepcionExpediente.Fecha;
            if (estadoPresentacionDemanda != null)
                FechaDemandaPresentacion = estadoPresentacionDemanda.Hip_ExpedienteEstadoPresentacionDemanda.FechaPresentacion;
            if (estadoTramitacionJuzgado != null)
            {
                FechaDemandaAdmision = estadoTramitacionJuzgado.HipExpedienteEstadoTramitacionSubasta.AdmitidaFecha;
                FechaTramitacionCertificacionCargas = estadoTramitacionJuzgado.HipExpedienteEstadoTramitacionSubasta.FechaCertificacionCargas;
                FechaTramitacionRequerimientoPago = estadoTramitacionJuzgado.Hip_ExpedienteEstadoDatoRequerimiento.Where(x => x.FechaRequerimientoPago.HasValue).Min(r => r.FechaRequerimientoPago);
                FechaSubastaSolicitud = estadoTramitacionJuzgado.HipExpedienteEstadoTramitacionSubasta.FechaSolicitudSubasta;
            }
            if (subasta != null)
            {
                FechaSubastaDecreto = subasta.FechaDecretoSubasta;
                FechaSubastaApertura = subasta.FechaDecretoSubasta;
                FechaSubastaCelebracion = subasta.FechaCelebracion;
                //FechaAdjudicacionSolicitud = estadoSubasta.Hip_ExpedienteEstadoSubasta.FechaSolicitudAdjudicacion;
            }
            if (estadoAdjudicacion != null)
            {
                FechaAdjudicacionDecreto = estadoAdjudicacion.Hip_ExpedienteEstadoAdjudicacion.FechaAdjudicacion;
                FechaAdjudicacionTestimonio = estadoAdjudicacion.Hip_ExpedienteEstadoAdjudicacion.FechaTestimonio;
                FechaAdjudicacionSolicitudPosesion = estadoAdjudicacion.Hip_ExpedienteEstadoAdjudicacion.FechaSolicitudPosesion;
                FechaAdjudicacionPosesion = estadoAdjudicacion.Hip_ExpedienteEstadoAdjudicacion.FechaDiligenciaPosesion;
            }
        }

        #endregion

        #region Properties

        public int IdExpediente { get; set; }
        public string NoExpediente { get; set; }
        public string ReferenciaExterna { get; set; }

        public DateTime? FechaRecepcion { get; set; }
        public DateTime? FechaDemandaPresentacion { get; set; }
        public DateTime? FechaDemandaAdmision { get; set; }
        public DateTime? FechaTramitacionCertificacionCargas { get; set; }
        public DateTime? FechaTramitacionRequerimientoPago { get; set; }
        public DateTime? FechaSubastaSolicitud { get; set; }
        public DateTime? FechaSubastaDecreto { get; set; }
        public DateTime? FechaSubastaApertura { get; set; }
        public DateTime? FechaSubastaCelebracion { get; set; }
        public DateTime? FechaAdjudicacionSolicitud { get; set; }
        public DateTime? FechaAdjudicacionDecreto { get; set; }
        public DateTime? FechaAdjudicacionTestimonio { get; set; }
        public DateTime? FechaAdjudicacionSolicitudPosesion { get; set; }
        public DateTime? FechaAdjudicacionPosesion { get; set; }

        public string Cliente { get; set; }
        public string ClienteOficina { get; set; }
        public Juzgado Juzgado { get; set; }

        #endregion

        #region Properties ReadOnly

        public int? DiasHastaDemandaPresentacion => GetCountDias(FechaRecepcion, FechaDemandaPresentacion);
        public int? DiasHastaDemandaAdmision => GetCountDias(FechaDemandaPresentacion, FechaDemandaAdmision);

        public int? DiasHastaTramitacionCertificacionCargas => GetCountDias(FechaDemandaAdmision, FechaTramitacionCertificacionCargas);
        public int? DiasHastaTramitacionRequerimientoPago => GetCountDias(FechaDemandaAdmision, FechaTramitacionRequerimientoPago);

        public int? DiasHastaSubastaSolicitud => GetCountDias(FechaTramitacionRequerimientoPago, FechaSubastaSolicitud);
        public int? DiasHastaSubastaDecreto => GetCountDias(FechaSubastaSolicitud, FechaSubastaDecreto);
        public int? DiasHastaSubastaApertura => GetCountDias(FechaSubastaDecreto, FechaSubastaApertura);
        public int? DiasHastaSubastaCierre => GetCountDias(FechaSubastaApertura, FechaSubastaCelebracion);
        public int? DiasHastaAdjudicacionSolicitud => GetCountDias(FechaSubastaCelebracion, FechaAdjudicacionSolicitud);
        public int? DiasHastaAdjudicacionDecreto => GetCountDias(FechaAdjudicacionSolicitud, FechaAdjudicacionDecreto);
        public int? DiasHastaAdjudicacionTestimonio => GetCountDias(FechaAdjudicacionDecreto, FechaAdjudicacionTestimonio);
        public int? DiasHastaAdjudicacionSolicitudPosesion => GetCountDias(FechaAdjudicacionTestimonio, FechaAdjudicacionSolicitudPosesion);
        public int? DiasHastaAdjudicacionPosesion => GetCountDias(FechaAdjudicacionSolicitudPosesion, FechaAdjudicacionPosesion);

        #endregion

        #region Methods

        public int? GetCountDias(DateTime? fecha1, DateTime? fecha2)
        {
            if (!fecha1.HasValue || !fecha2.HasValue || fecha1.Value > fecha2.Value) return null;
            fecha1 = fecha1.Value.Date;
            fecha2 = fecha2.Value.Date;

            return fecha1.Value == fecha2.Value ? 0 :
                fecha1.Value.GetDaysBetweenDates(fecha2.Value);
        }

        #endregion
    }

}
