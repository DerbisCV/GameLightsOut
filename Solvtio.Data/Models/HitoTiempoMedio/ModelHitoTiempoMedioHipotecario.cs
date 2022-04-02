using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvtio.Models.HitoTiempoMedio
{
    public class ModelHitoTiempoMedioHipotecario
    {
        #region Constructor

        public ModelHitoTiempoMedioHipotecario(List<TipoHitoProcesalTiempoMedio> lstTipoHitoProcesalTiempoMedio, Expediente entidad,
            HipExpedienteEstadoPresentacionDemanda estadoPresentacionDemanda,
            HipExpedienteEstadoTramitacionSubasta estadoTramitacionSubasta,
            Hip_ExpedienteEstadoAdjudicacion estadoAdjudicacion)
        {
            Expediente = entidad;
            LstTipoHitoProcesalTiempoMedio = lstTipoHitoProcesalTiempoMedio;
            EstadoPresentacionDemanda = estadoPresentacionDemanda;
            EstadoTramitacionSubasta = estadoTramitacionSubasta;
            EstadoAdjudicacion = estadoAdjudicacion;

            Hito2PresentacionDemanda = new ModelHitoTiempoMedioDetail(Expediente.Inicio, EstadoPresentacionDemanda?.FechaPresentacion, GetTipoHitoProcesalTiempoMedio(3618), TiempoPrevistoMax);
            Hito3AdmisionDemanda = new ModelHitoTiempoMedioDetail(Expediente.Inicio, EstadoTramitacionSubasta?.AdmitidaFecha, GetTipoHitoProcesalTiempoMedio(3619), TiempoPrevistoMax);
            Hito4CierreSubasta = new ModelHitoTiempoMedioDetail(Expediente.Inicio, Expediente.ExpedienteSubastaLast?.FechaCelebracion, GetTipoHitoProcesalTiempoMedio(3620), TiempoPrevistoMax);
            Hito5Adjudicacion = new ModelHitoTiempoMedioDetail(Expediente.Inicio, EstadoAdjudicacion?.FechaAdjudicacion, GetTipoHitoProcesalTiempoMedio(3621), TiempoPrevistoMax);
        }

        #endregion

        #region Properties Primary

        public Expediente Expediente { get; }
        public List<TipoHitoProcesalTiempoMedio> LstTipoHitoProcesalTiempoMedio { get; }
        public HipExpedienteEstadoPresentacionDemanda EstadoPresentacionDemanda { get; }
        public HipExpedienteEstadoTramitacionSubasta EstadoTramitacionSubasta { get; }
        public Hip_ExpedienteEstadoAdjudicacion EstadoAdjudicacion { get; }

        #endregion

        #region Properties Hitos

        public ModelHitoTiempoMedioDetail Hito2PresentacionDemanda { get; set; }
        public ModelHitoTiempoMedioDetail Hito3AdmisionDemanda { get; set; }
        public ModelHitoTiempoMedioDetail Hito4CierreSubasta { get; set; }
        public ModelHitoTiempoMedioDetail Hito5Adjudicacion { get; set; }

        #endregion

        #region Properties Readonly

        public bool HayOposicion => EstadoTramitacionSubasta != null && EstadoTramitacionSubasta.Oposicion;

        public int TiempoPrevistoMax => HayOposicion ? LstTipoHitoProcesalTiempoMedio.Max(x => x.Tiempo2) : LstTipoHitoProcesalTiempoMedio.Max(x => x.Tiempo1);

        #endregion

        #region Methods

        private TipoHitoProcesalTiempoMedio GetTipoHitoProcesalTiempoMedio(int idTipoHitoProcesal)
        {
            return LstTipoHitoProcesalTiempoMedio.FirstOrDefault(x => x.IdTipoHitoProcesal == idTipoHitoProcesal);
        }

        public DateTime GetFechaFinPrevista() 
        {
            if (Expediente.Fin.HasValue) return Expediente.Fin.Value;

            if (Hito5Adjudicacion.FechaFinPrevista.HasValue) return Hito5Adjudicacion.FechaFinPrevista.Value;
            if (Hito4CierreSubasta.FechaFinPrevista.HasValue) return Hito4CierreSubasta.FechaFinPrevista.Value;
            if (Hito3AdmisionDemanda.FechaFinPrevista.HasValue) return Hito3AdmisionDemanda.FechaFinPrevista.Value;
            if (Hito2PresentacionDemanda.FechaFinPrevista.HasValue) return Hito2PresentacionDemanda.FechaFinPrevista.Value;

            return Expediente.Inicio.HasValue ? 
                Expediente.Inicio.Value.AddDays(TiempoPrevistoMax) :
                DateTime.Today.AddDays(TiempoPrevistoMax);
        }

        #endregion
    }
}
