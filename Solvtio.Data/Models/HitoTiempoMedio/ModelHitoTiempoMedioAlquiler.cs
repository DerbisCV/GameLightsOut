using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvtio.Models.HitoTiempoMedio
{
    public class ModelHitoTiempoMedioAlquiler
    {
        #region Constructor

        public ModelHitoTiempoMedioAlquiler(List<TipoHitoProcesalTiempoMedio> lstTipoHitoProcesalTiempoMedio, Expediente entidad,
            Alq_Expediente_EstadoPresentacionDemanda estadoPresentacionDemanda,
            Alq_Expediente_EstadoTramitaJuzgado estadoTramitacionSubasta,
            Alq_Expediente_EstadoAdjudicacion estadoAdjudicacion)
        {
            Expediente = entidad;
            LstTipoHitoProcesalTiempoMedio = lstTipoHitoProcesalTiempoMedio;
            EstadoPresentacionDemanda = estadoPresentacionDemanda;
            EstadoTramitacionJuzgado = estadoTramitacionSubasta;
            EstadoAdjudicacion = estadoAdjudicacion;

            Hito2PresentacionDemanda = new ModelHitoTiempoMedioDetail(Expediente.Inicio, EstadoPresentacionDemanda?.FechaPresentacion, GetTipoHitoProcesalTiempoMedio(3624), TiempoPrevistoMax);
            Hito3AdmisionDemanda = new ModelHitoTiempoMedioDetail(Expediente.Inicio, EstadoTramitacionJuzgado?.AdmitidaFecha, GetTipoHitoProcesalTiempoMedio(3625), TiempoPrevistoMax);

            var fechaH4 = EstadoTramitacionJuzgado?.OposicionFechaDecretoFin;
            if (fechaH4 == null) fechaH4 = EstadoTramitacionJuzgado?.FechaSentencia2;
            if (fechaH4 == null) fechaH4 = EstadoTramitacionJuzgado?.OposicionFechaSentencia;
            Hito4CierreSubasta = new ModelHitoTiempoMedioDetail(Expediente.Inicio, fechaH4, GetTipoHitoProcesalTiempoMedio(3626), TiempoPrevistoMax);

            //Hito4CierreSubasta = new ModelHitoTiempoMedioDetail(Expediente.Inicio, Expediente.ExpedienteSubastaLast?.FechaCelebracion, GetTipoHitoProcesalTiempoMedio(3626), TiempoPrevistoMax);
            //Hito5Adjudicacion = new ModelHitoTiempoMedioDetail(Expediente.Inicio, EstadoAdjudicacion?.FechaAdjudicacion, GetTipoHitoProcesalTiempoMedio(3627), TiempoPrevistoMax);
        }

        #endregion

        #region Properties Primary

        public Expediente Expediente { get; }
        public List<TipoHitoProcesalTiempoMedio> LstTipoHitoProcesalTiempoMedio { get; }
        public Alq_Expediente_EstadoPresentacionDemanda EstadoPresentacionDemanda { get; }
        public Alq_Expediente_EstadoTramitaJuzgado EstadoTramitacionJuzgado { get; }
        public Alq_Expediente_EstadoAdjudicacion EstadoAdjudicacion { get; }

        #endregion

        #region Properties Hitos

        public ModelHitoTiempoMedioDetail Hito2PresentacionDemanda { get; set; }
        public ModelHitoTiempoMedioDetail Hito3AdmisionDemanda { get; set; }
        public ModelHitoTiempoMedioDetail Hito4CierreSubasta { get; set; }
        public ModelHitoTiempoMedioDetail Hito5Adjudicacion { get; set; }

        #endregion

        #region Properties Readonly

        public bool HayOposicion => EstadoTramitacionJuzgado != null && EstadoTramitacionJuzgado.Oposicion;

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

            //if (Hito5Adjudicacion.FechaFinPrevista.HasValue) return Hito5Adjudicacion.FechaFinPrevista.Value;
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
