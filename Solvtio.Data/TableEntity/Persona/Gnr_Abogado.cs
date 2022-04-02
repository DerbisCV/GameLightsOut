using System.Collections.Generic;

namespace Solvtio.Models
{
    public class Gnr_Abogado : IPersona
    {
        #region Constructors

        public Gnr_Abogado()
        {
            Activo = true;

            Alq_Expediente = new List<Alq_Expediente>();
            Alq_Expediente_EstadoTramitaJuzgado = new List<Alq_Expediente_EstadoTramitaJuzgado>();
            Expedientes = new List<Expediente>();
            Gnr_Cliente = new List<Gnr_Cliente>();
        }

        #endregion

        #region Properties

        public int IdPersona { get; set; }
        public virtual Gnr_Persona Persona { get; set; }

        public string NoColegiado { get; set; }
        public bool PuedeFirmarDemanda { get; set; }
        public bool EsAbogadoDeZona { get; set; }

        public int? IdDepartamento { get; set; }
        public virtual Departamento Departamento { get; set; }

        public int? IdArea { get; set; }
        public virtual Area Area { get; set; }

        public bool RolAccionComercial { get; set; }
        //public virtual TipoAreaNotificacion TipoAreaNotificacion { get; set; }
        public bool? Activo { get; set; }

        #endregion

        #region One To Many

        public virtual ICollection<Alq_Expediente> Alq_Expediente { get; set; }
        public virtual ICollection<Alq_Expediente_EstadoTramitaJuzgado> Alq_Expediente_EstadoTramitaJuzgado { get; set; }
        public virtual ICollection<Expediente> Expedientes { get; set; }
        public virtual ICollection<Gnr_Cliente> Gnr_Cliente { get; set; }
        public virtual ICollection<ExpedienteEstado> ExpedienteEstadoSet { get; set; }
        public virtual ICollection<ExpedienteEstadoAbogadoHistorico> ExpedienteEstadoAbogadoHistoricoSet { get; set; }
        public virtual ICollection<ExpedienteJurisdiccionVoluntaria> ExpedienteJurisdiccionVoluntariaSet { get; set; }
        public virtual ICollection<HipExpedienteEstadoTramitacionSubasta> HipExpedienteEstadoTramitacionSubastaSet { get; set; }//
        public virtual ICollection<ExpedienteVista> ExpedienteVistaSet { get; set; }
        public virtual ICollection<Alq_Expediente_EstadoTramitaJuzgado_Actuacion> AlqEstadoTramitaJuzgadoActuacionSet { get; set; }
        public virtual ICollection<AbogadoFacturacion> AbogadoFacturacionSet { get; set; }
        
        #endregion

        #region Properties ReadOnly

        private string _nombreCompleto;
        public string NombreCompleto
        {
            get
            {
                if (string.IsNullOrEmpty(_nombreCompleto) && Persona != null)
                    _nombreCompleto = $"{Persona.Nombre} {Persona.Apellidos}".Trim();
            
                return _nombreCompleto;
            }
        }

        #endregion
    }
}
