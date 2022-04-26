using Solvtio.Models.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Solvtio.Models
{
    public class Gnr_Persona : IDireccion
    {
        #region Constructors

        public Gnr_Persona()
        {
            Con_Expediente = new List<Con_Expediente>();
            Con_ExpedienteAdministrador = new List<Con_ExpedienteAdministrador>();
            Con_ExpedienteCreditoGarantiaAvalista = new List<Con_ExpedienteCreditoGarantiaAvalista>();
            Ejc_Expediente = new List<Ejc_Expediente>();
            ExpedienteAcreedores = new List<ExpedienteAcreedore>();
            ExpedienteDeudors = new List<ExpedienteDeudor>();
            Gnr_PersonaExpediente = new List<Gnr_PersonaExpediente>();
            Hip_TitularInmueble = new List<Hip_TitularInmueble>();
            Mnt_Expediente = new List<Mnt_Expediente>();
            Neg_Gestion = new List<Neg_Gestion>();
            Gnr_PersonaDireccion = new List<Gnr_PersonaDireccion>();
            Gnr_PersonaTelefono = new List<Gnr_PersonaTelefono>();

            IdTipoIdentidad = 0;
            IdTipoTratamiento = 0;
            Apellidos = Email = "";
        }

        public Gnr_Persona(int idpersona, string nombre, int count1)
        {
            IdPersona = idpersona;
            Nombre = nombre;
            Count1 = count1;
        }
        public Gnr_Persona(int idOtro)
        {
            IdExpediente = idOtro;
        }

        #endregion

        #region Properties

        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int IdTipoIdentidad { get; set; }
        public string NoDocumento { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string Telefono { get; set; }
        public string Telefono2 { get; set; }
        public string Telefono3 { get; set; }
        public string Telefono4 { get; set; }

        public int? IdTipoTratamiento { get; set; }
        public Guid? UserId { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAlta { get; set; }

        public string Direccion { get; set; }
        public string CodigoPostal { get; set; }
        public int? IdProvincia { get; set; }
        [ForeignKey("IdProvincia")]
        public virtual Provincia Provincia { get; set; }
        public int? IdMunicipio { get; set; }
        [ForeignKey("IdMunicipio")]
        public virtual Municipio Municipio { get; set; }

        public string CodigoExterno { get; set; }


        public string NivelProfesional { get; set; }
        public string Profesion { get; set; }
        public string ProfesionAnterior { get; set; }

        #endregion

        #region Properties NotMapped

        [NotMapped]
        public string DomicilioNotificacion { get; set; }

        [NotMapped]
        public int Count1 { get; set; }

        [NotMapped]
        public int IdExpediente { get; set; }

        #endregion

        #region Properties (Computed)

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string NombreApellidos
        {
            get { return $"{Nombre} {Apellidos}"; }
            private set
            {
                //Just need this here to trick EF
            }
        }

        #endregion

        #region Properties ReadOnly

        public string TelefonosTodos => $"{Telefono}" +
            $"{(string.IsNullOrWhiteSpace(Telefono2) ? string.Empty : $" / {Telefono2}")}" +
            $"{(string.IsNullOrWhiteSpace(Telefono3) ? string.Empty : $" / {Telefono3}")}" +
            $"{(string.IsNullOrWhiteSpace(Telefono4) ? string.Empty : $" / {Telefono4}")}";

        public string EmailsTodos => $"{Email}" +
            $"{(string.IsNullOrWhiteSpace(Email2) ? string.Empty : $"; {Email2}")}" +
            $"{(string.IsNullOrWhiteSpace(Email3) ? string.Empty : $"; {Email3}")}";

        private string _nombreCompleto;
        public string NombreCompleto
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_nombreCompleto))
                    _nombreCompleto = string.Format("{0} {1}", Nombre, Apellidos);

                return _nombreCompleto;
            }
        }

        private string _telefono;
        public string TelefonoPrincipal
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_telefono))
                {
                    var telefonoFirst = Gnr_PersonaTelefono.FirstOrDefault(x => x.Telefono != "");
                    if (telefonoFirst != null)
                        _telefono = telefonoFirst.Telefono;
                }

                return _telefono;
            }
        }

        #endregion

        #region Properties virtual (One to One)

        public virtual Gnr_Abogado Gnr_Abogado { get; set; }
        [ForeignKey("IdProcurador")]
        public virtual Gnr_Procurador Gnr_Procurador { get; set; }
        [ForeignKey("IdTipoIdentidad")]
        public virtual Gnr_TipoIdentidad Gnr_TipoIdentidad { get; set; }
        [ForeignKey("IdTipoTratamiento")]
        public virtual Gnr_TipoTratamiento Gnr_TipoTratamiento { get; set; }
        //public virtual AlertaDestinatario AlertaDestinatario { get; set; }
        //public virtual AlertaSupervisor AlertaSupervisor { get; set; }
        //public virtual aspnet_Users aspnet_Users { get; set; }

        #endregion

        #region Properties virtual (ICollection)

        public virtual ICollection<Con_Expediente> Con_Expediente { get; set; }
        public virtual ICollection<Con_ExpedienteAdministrador> Con_ExpedienteAdministrador { get; set; }
        public virtual ICollection<Con_ExpedienteCreditoGarantiaAvalista> Con_ExpedienteCreditoGarantiaAvalista { get; set; }
        public virtual ICollection<Ejc_Expediente> Ejc_Expediente { get; set; }

        public virtual ICollection<ExpedienteOrdinario> ExpedienteOrdinarioSet { get; set; }
        public virtual ICollection<ExpedienteOrdinarioCs> ExpedienteOrdinarioCsSet { get; set; }

        public virtual ICollection<ExpedienteAcreedore> ExpedienteAcreedores { get; set; }
        public virtual ICollection<ExpedienteDeudor> ExpedienteDeudors { get; set; }
        public virtual ICollection<Gnr_PersonaExpediente> Gnr_PersonaExpediente { get; set; }
        public virtual ICollection<Hip_TitularInmueble> Hip_TitularInmueble { get; set; }
        public virtual ICollection<Mnt_Expediente> Mnt_Expediente { get; set; }
        public virtual ICollection<Neg_Gestion> Neg_Gestion { get; set; }
        public virtual ICollection<Gnr_PersonaDireccion> Gnr_PersonaDireccion { get; set; }
        public virtual ICollection<Gnr_PersonaTelefono> Gnr_PersonaTelefono { get; set; }
        public virtual ICollection<ExpedienteHora> ExpedienteHoraSet { get; set; }

        #endregion

        #region Properties NotMapped

        [NotMapped]
        public ModelAbogado ModelAbogado { get; set; }

        #endregion

        #region Methods

        internal void RefreshBy(Gnr_Persona model)
        {
            Nombre = model.Nombre;
            Apellidos = model.Apellidos;
            IdTipoIdentidad = model.IdTipoIdentidad;
            NoDocumento = model.NoDocumento;
            Email = model.Email;
            Email2 = model.Email2;
            Email3 = model.Email3;
            Telefono = model.Telefono;
            Telefono2 = model.Telefono2;
            Telefono3 = model.Telefono3;
            Telefono4 = model.Telefono4;
            Direccion = model.Direccion;
            CodigoPostal = model.CodigoPostal;
            IdProvincia = model.IdProvincia;
            IdMunicipio = model.IdMunicipio;

            NivelProfesional = model.NivelProfesional;
            Profesion = model.Profesion;
            ProfesionAnterior = model.ProfesionAnterior;
        }

        #endregion

    }

    public interface IDireccion
    {
        string Direccion { get; set; }
        string CodigoPostal { get; set; }
        int? IdProvincia { get; set; }
        int? IdMunicipio { get; set; }
    }
}
