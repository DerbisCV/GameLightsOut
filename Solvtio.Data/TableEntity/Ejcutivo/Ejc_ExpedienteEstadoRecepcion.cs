using System;

namespace Solvtio.Models
{
    public class Ejc_ExpedienteEstadoRecepcion : EstadoRecepcionBase, IExpedienteEstadoChild
    {
        #region Constructors

        public Ejc_ExpedienteEstadoRecepcion() { }
        public Ejc_ExpedienteEstadoRecepcion(int idExpediente)
        {
            IdExpediente = idExpediente;
        }

        #endregion

        #region Properties

        public int IdExpediente { get; set; }

        public bool TituloEjecutivo { get; set; }
        public bool TituloInscrito { get; set; }
        public bool BurofaxesEnviados { get; set; }
        public bool BurofaxesFiadores { get; set; }
        public bool PagosCuenta { get; set; }
        public bool CantidadesConsignar { get; set; }
        public bool NotaSimple { get; set; }
        public bool JurisdiccionVoluntaria { get; set; }



        #endregion

        #region Methods

        internal void RefreshBy(ExpedienteEstadoMonitorioRecepcion estadoMonitorioRecepcion)
        {
            FechaResolucionIncidenciaDocumental = estadoMonitorioRecepcion.FechaResolucionIncidenciaDocumental;
            TituloEjecutivo = estadoMonitorioRecepcion.TituloEjecutivo;
            TituloInscrito = estadoMonitorioRecepcion.TituloInscrito;
            FechaResolucionIncidenciaDocumental = estadoMonitorioRecepcion.FechaResolucionIncidenciaDocumental;
            BurofaxesEnviados = estadoMonitorioRecepcion.BurofaxesEnviados;
            BurofaxesFiadores = estadoMonitorioRecepcion.BurofaxesFiadores;
            PagosCuenta = estadoMonitorioRecepcion.PagosCuenta;
            CantidadesConsignar = estadoMonitorioRecepcion.CantidadesConsignar;
        }

        #endregion
    }
}
