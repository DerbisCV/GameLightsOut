using System;
using System.Collections.Generic;
using System.Linq;
using Solvtio.Common;

namespace Solvtio.Models
{
    public class ModelFilterBy
    {
		#region Constructors
		public ModelFilterBy()
		{
		}
        public ModelFilterBy(ModelFilterBase filter)
        {
            Filter = filter;
        }
		#endregion

		#region Properties

		public ModelFilterBase Filter { get; set; }

		public List<ModelExpedienteHipotecarioTiemposMedios> LstExpedienteHipotecarioTiemposMedios { get; set; }
        public List<ModelExpedienteHipotecarioTiemposMediosJuzgado> LstExpedienteHipotecarioTiemposMediosJuzgado { get; set; }
        public List<Expediente> LstExpediente { get; set; }

        #endregion

        #region Properties ReadOnly

        public int? DiasHastaDemandaPresentacion => GetPromedioDiasPorTipo(1);
        public int? DiasHastaDemandaAdmision => GetPromedioDiasPorTipo(2);
        public int? DiasHastaTramitacionCertificacionCargas => GetPromedioDiasPorTipo(3);
        public int? DiasHastaTramitacionRequerimientoPago => GetPromedioDiasPorTipo(4);
        public int? DiasHastaSubastaSolicitud => GetPromedioDiasPorTipo(5);
        public int? DiasHastaSubastaDecreto => GetPromedioDiasPorTipo(6);
        public int? DiasHastaSubastaApertura => GetPromedioDiasPorTipo(7);
        public int? DiasHastaSubastaCierre => GetPromedioDiasPorTipo(8);
        public int? DiasHastaAdjudicacionSolicitud => GetPromedioDiasPorTipo(9);
        public int? DiasHastaAdjudicacionDecreto => GetPromedioDiasPorTipo(10);
        public int? DiasHastaAdjudicacionTestimonio => GetPromedioDiasPorTipo(11);
        public int? DiasHastaAdjudicacionSolicitudPosesion => GetPromedioDiasPorTipo(12);
        public int? DiasHastaAdjudicacionPosesion => GetPromedioDiasPorTipo(13);

        #endregion

        #region Methods

        public int? GetPromedioDiasPorTipo(int tipo)
        {
            var lst = GetListDiasPorTipo(tipo);
            if (lst.IsEmpty()) return null;
            return lst.Sum() / lst.Count;
        }

        public List<int> GetListDiasPorTipo(int tipo)
        {
            if (LstExpedienteHipotecarioTiemposMedios.IsEmpty()) return null;

            if (tipo.Equals(1))            
                return LstExpedienteHipotecarioTiemposMedios
                    .Where(x => x.DiasHastaDemandaPresentacion.HasValue
                        && x.DiasHastaDemandaPresentacion > 0
                        && x.DiasHastaDemandaPresentacion < 365)
                    .Select(x => x.DiasHastaDemandaPresentacion.Value)
                    .ToList();
            if (tipo.Equals(2))
                return LstExpedienteHipotecarioTiemposMedios
                    .Where(x => x.DiasHastaDemandaAdmision.HasValue
                        && x.DiasHastaDemandaAdmision > 0
                        && x.DiasHastaDemandaAdmision < 365)
                    .Select(x => x.DiasHastaDemandaAdmision.Value)
                    .ToList();
            if (tipo.Equals(3))
                return LstExpedienteHipotecarioTiemposMedios
                    .Where(x => x.DiasHastaTramitacionCertificacionCargas.HasValue
                        && x.DiasHastaTramitacionCertificacionCargas > 0
                        && x.DiasHastaTramitacionCertificacionCargas < 365)
                    .Select(x => x.DiasHastaTramitacionCertificacionCargas.Value)
                    .ToList();
            if (tipo.Equals(4))
                return LstExpedienteHipotecarioTiemposMedios
                    .Where(x => x.DiasHastaTramitacionRequerimientoPago.HasValue
                        && x.DiasHastaTramitacionRequerimientoPago > 0
                        && x.DiasHastaTramitacionRequerimientoPago < 365)
                    .Select(x => x.DiasHastaTramitacionRequerimientoPago.Value)
                    .ToList();
            if (tipo.Equals(5))
                return LstExpedienteHipotecarioTiemposMedios
                    .Where(x => x.DiasHastaSubastaSolicitud.HasValue
                        && x.DiasHastaSubastaSolicitud > 0
                        && x.DiasHastaSubastaSolicitud < 365)
                    .Select(x => x.DiasHastaSubastaSolicitud.Value)
                    .ToList();
            if (tipo.Equals(6))
                return LstExpedienteHipotecarioTiemposMedios
                    .Where(x => x.DiasHastaSubastaDecreto.HasValue
                        && x.DiasHastaSubastaDecreto > 0
                        && x.DiasHastaSubastaDecreto < 365)
                    .Select(x => x.DiasHastaSubastaDecreto.Value)
                    .ToList();
            if (tipo.Equals(7))
                return LstExpedienteHipotecarioTiemposMedios
                    .Where(x => x.DiasHastaSubastaApertura.HasValue
                        && x.DiasHastaSubastaApertura > 0
                        && x.DiasHastaSubastaApertura < 365)
                    .Select(x => x.DiasHastaSubastaApertura.Value)
                    .ToList();
            if (tipo.Equals(8))
                return LstExpedienteHipotecarioTiemposMedios
                    .Where(x => x.DiasHastaSubastaCierre.HasValue
                        && x.DiasHastaSubastaCierre > 0
                        && x.DiasHastaSubastaCierre < 365)
                    .Select(x => x.DiasHastaSubastaCierre.Value)
                    .ToList();
            if (tipo.Equals(9))
                return LstExpedienteHipotecarioTiemposMedios
                    .Where(x => x.DiasHastaAdjudicacionSolicitud.HasValue
                        && x.DiasHastaAdjudicacionSolicitud > 0
                        && x.DiasHastaAdjudicacionSolicitud < 365)
                    .Select(x => x.DiasHastaAdjudicacionSolicitud.Value)
                    .ToList();
            if (tipo.Equals(10))
                return LstExpedienteHipotecarioTiemposMedios
                    .Where(x => x.DiasHastaAdjudicacionDecreto.HasValue
                        && x.DiasHastaAdjudicacionDecreto > 0
                        && x.DiasHastaAdjudicacionDecreto < 365)
                    .Select(x => x.DiasHastaAdjudicacionDecreto.Value)
                    .ToList();
            if (tipo.Equals(11))
                return LstExpedienteHipotecarioTiemposMedios
                    .Where(x => x.DiasHastaAdjudicacionTestimonio.HasValue
                        && x.DiasHastaAdjudicacionTestimonio > 0
                        && x.DiasHastaAdjudicacionTestimonio < 365)
                    .Select(x => x.DiasHastaAdjudicacionTestimonio.Value)
                    .ToList();
            if (tipo.Equals(12))
                return LstExpedienteHipotecarioTiemposMedios
                    .Where(x => x.DiasHastaAdjudicacionSolicitudPosesion.HasValue
                        && x.DiasHastaAdjudicacionSolicitudPosesion > 0
                        && x.DiasHastaAdjudicacionSolicitudPosesion < 365)
                    .Select(x => x.DiasHastaAdjudicacionSolicitudPosesion.Value)
                    .ToList();
            if (tipo.Equals(13))
                return LstExpedienteHipotecarioTiemposMedios
                    .Where(x => x.DiasHastaAdjudicacionPosesion.HasValue
                        && x.DiasHastaAdjudicacionPosesion > 0
                        && x.DiasHastaAdjudicacionPosesion < 365)
                    .Select(x => x.DiasHastaAdjudicacionPosesion.Value)
                    .ToList();

            return null;
        }

        #endregion
    }

}
