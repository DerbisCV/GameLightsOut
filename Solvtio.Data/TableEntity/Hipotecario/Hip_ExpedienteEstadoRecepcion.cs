namespace Solvtio.Models
{
    public class HipExpedienteEstadoRecepcion : EstadoRecepcionBase
    {
        #region Constructors

        public HipExpedienteEstadoRecepcion()
        {
        }
        public HipExpedienteEstadoRecepcion(int idExpedienteEstado)
        {
            IdExpedienteEstado = idExpedienteEstado;
        }

        #endregion

        #region Properties

        //public int IdExpedienteEstado { get; set; }
        //public virtual ExpedienteEstado ExpedienteEstado { get; set; }
        //public DateTime? FechaResolucionIncidenciaDocumental { get; set; }

        public bool TituloEjecutivo { get; set; }
        public bool TituloInscrito { get; set; }
        public bool RevisionCargas { get; set; }
        public bool BurofaxesEnviados { get; set; }
        public bool BurofaxesFiadores { get; set; }
        public bool PagosCuenta { get; set; }
        public bool CantidadesConsignar { get; set; }
        public bool NotaSimple { get; set; }
        public bool JurisdiccionVoluntaria { get; set; }

        public bool SituacionConcursalIntervinientes { get; set; }
        public bool ClausulasAbusivasAlCierre { get; set; }
        public string Incidencias { get; set; }

        #endregion

        #region Methods

        internal void RefreshBy(Ejc_ExpedienteEstadoRecepcion model)
        {
            NotaSimple = model.NotaSimple;
            TituloEjecutivo = model.TituloEjecutivo;
            TituloInscrito = model.TituloInscrito;
            FechaResolucionIncidenciaDocumental = model.FechaResolucionIncidenciaDocumental;
            BurofaxesEnviados = model.BurofaxesEnviados;
            BurofaxesFiadores = model.BurofaxesFiadores;
            PagosCuenta = model.PagosCuenta;
            CantidadesConsignar = model.CantidadesConsignar;
        }

        internal void RefreshBy(HipExpedienteEstadoRecepcion model)
        {
            NotaSimple = model.NotaSimple;
            TituloEjecutivo = model.TituloEjecutivo;
            TituloInscrito = model.TituloInscrito;
            FechaResolucionIncidenciaDocumental = model.FechaResolucionIncidenciaDocumental;
            BurofaxesEnviados = model.BurofaxesEnviados;
            BurofaxesFiadores = model.BurofaxesFiadores;
            PagosCuenta = model.PagosCuenta;
            CantidadesConsignar = model.CantidadesConsignar;
        }

        #endregion
    }
}
