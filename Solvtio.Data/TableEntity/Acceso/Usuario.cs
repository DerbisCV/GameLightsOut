using Solvtio.Models.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public class Usuario : INombre
	{
        #region Constructors

        public Usuario()
        {
            CreateBase();
        }

        private void CreateBase()
        {
            FechaAlta = DateTime.Now;
        }

        #endregion

        #region Properties

        [Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int IdUsuario { get; set; }

		[Required]
		public string Nombre { get; set; }
		public string NtAccount { get; set; }

		[Required]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

        public TipoEmpleado? TipoEmpleado { get; set; }

        public int IdRole { get; set; }
		public virtual Role Role { get; set; }

        public DateTime? UltimoAcceso { get; set; }
		public bool Inactivo { get; set; }
		public DateTime FechaAlta { get; set; }
        public bool EsJefeArea { get; set; }



        public int? IdTipoAreaNotificacion { get; set; }
        [ForeignKey("IdTipoAreaNotificacion")]
        public virtual TipoAreaNotificacion TipoAreaNotificacion { get; set; }



        public int? IdDivision { get; set; }
        [ForeignKey("IdDivision")]
        public virtual Division Division { get; set; }

        public int? IdClienteOficina { get; set; }
        [ForeignKey("IdClienteOficina")]
        public virtual Gnr_ClienteOficina ClienteOficina { get; set; }

        public int? IdCliente { get; set; }
        [ForeignKey("IdCliente")]
        public virtual Gnr_Cliente Cliente { get; set; }

        public int? IdClienteCrm { get; set; }
        [ForeignKey("IdClienteCrm")]
        public virtual Gnr_Cliente ClienteCrm { get; set; }

        public string PuestoTrabajo { get; set; }
        public string Cargo { get; set; }
        public string FotoPerfil { get; set; }
        public string NoSeguridadSocial { get; set; }

        //public virtual GrupoUsuario GrupoUsuario { get; set; }
        public virtual ICollection<UsuarioRole> UsuarioRoleSet { get; set; }
        public virtual ICollection<ExpedienteNegociacion> ExpedienteNegociacionSet { get; set; }
	    public virtual ICollection<GrupoUsuario> GrupoUsuarioSet { get; set; }
        public virtual ICollection<OportunidadUsuario> OportunidadUsuarioSet { get; set; }

        public virtual ICollection<Nomina> NominaSet { get; set; }

        public string UrlFoto { get; set; }
        public string UrlCv { get; set; }

        public string NoEmpleado { get; set; }
        public string NoDocumento { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public string EmailPersonal { get; set; }
        public string TelefonoPersonal { get; set; }

        public string UnidadNegocio { get; set; }
        public int? IdDepartamento { get; set; }
        public virtual Departamento Departamento { get; set; }
        public string TelefonoPuesto { get; set; }
        public string Ubicacion { get; set; }

        //Old Properties
        public string TipoContrato { get; set; }
        public int? IdContratoTipo { get; set; }
        [ForeignKey("IdContratoTipo")]
        public CaracteristicaBase ContratoTipo { get; set; }

        public string Ubicacion1 { get; set; }
        public string Ubicacion2 { get; set; }
        public string Ubicacion3 { get; set; }

        //Fecha cambio de nivel   Fecha baja





        [DataType(DataType.Date)]
        public DateTime? FechaBaja { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaCambioNivel { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaNacimientoHijo1 { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaNacimientoHijo2 { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaNacimientoHijo3 { get; set; }

        public TipoSexo? Sexo { get; set; }

        public int? IdGrupoProfesional { get; set; }
        [ForeignKey("IdGrupoProfesional")]
        public CaracteristicaBase GrupoProfesional { get; set; }

        public int? IdNivelSalarial { get; set; }
        [ForeignKey("IdNivelSalarial")]
        public CaracteristicaBase NivelSalarial { get; set; }

        public decimal? MaximoVariable { get; set; }

        public int? IdLineaNegocio { get; set; }
        [ForeignKey("IdLineaNegocio")]
        public CaracteristicaBase LineaNegocio { get; set; }

        public int? IdPosicion { get; set; }
        [ForeignKey("IdPosicion")]
        public CaracteristicaBase Posicion { get; set; }

        #endregion

        #region ICollection

        public virtual ICollection<UsuarioExperiencia> UsuarioExperienciaSet { get; set; }
        public virtual ICollection<UsuarioFormacion> UsuarioFormacionSet { get; set; }
        public virtual ICollection<UsuarioIdioma> UsuarioIdiomaSet { get; set; }
        public virtual ICollection<UsuarioInformatica> UsuarioInformaticaSet { get; set; }
        public virtual ICollection<UsuarioAreasDominio> UsuarioAreasDominioSet { get; set; }
        public virtual ICollection<UsuarioRetribucion> UsuarioRetribucionSet { get; set; }
        public virtual ICollection<UsuarioEvaluacion> UsuarioEvaluacionSet { get; set; }

        #endregion

        #region Properties (Computed)

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string NombreApellidos
        {
            get
            {
                var nameFull = Nombre;
                if (!string.IsNullOrWhiteSpace(Apellido1))
                    nameFull = nameFull + " " + Apellido1;
                if (!string.IsNullOrWhiteSpace(Apellido2))
                    nameFull = nameFull + " " + Apellido2;

                return nameFull;
            }
            private set
            {
                //Just need this here to trick EF
            }
        }

        #endregion

        #region Properties Readonly

        public RoleType? RoleType => (RoleType?)IdRole;

        public string NombreCompleto => $"{Nombre} {Apellido1} {Apellido2}".Trim();

        //public bool IsResponsableDirectivo => TipoEmpleado == Model.TipoEmpleado.Responsables || TipoEmpleado == Model.TipoEmpleado.Directivo || TipoEmpleado == Model.TipoEmpleado.Director;

        #endregion

        #region Properties NotMapped

        [NotMapped]
        public int Count { get; set; }

        #endregion

        public virtual ICollection<EvaluacionEmpleado> EvaluacionEmpleadoSet { get; set; }

        public void RefreshBy(Usuario model)
        {
            NoDocumento = model.NoDocumento;
            NoEmpleado = model.NoEmpleado;
            Nombre = model.Nombre;
            Apellido1 = model.Apellido1;
            Apellido2 = model.Apellido2;
            FechaNacimiento = model.FechaNacimiento;
            Telefono = model.Telefono;
            Direccion = model.Direccion;
            EmailPersonal = model.EmailPersonal;
            TelefonoPersonal = model.TelefonoPersonal;
            UnidadNegocio = model.UnidadNegocio;
            IdDepartamento = model.IdDepartamento;
            TelefonoPuesto = model.TelefonoPuesto;
            Ubicacion = model.Ubicacion;
            IdContratoTipo = model.IdContratoTipo;
            Email = model.Email;
            NtAccount = model.NtAccount;
            IdRole = model.IdRole;
            EsJefeArea = model.EsJefeArea;
            Inactivo = model.Inactivo;
            FechaAlta = model.FechaAlta;
            IdTipoAreaNotificacion = model.IdTipoAreaNotificacion;
            IdClienteOficina = model.IdClienteOficina;
            IdCliente = model.IdCliente;
            IdClienteCrm = model.IdClienteCrm;
            IdDivision = model.IdDivision;
            PuestoTrabajo = model.PuestoTrabajo;
            Cargo = model.Cargo;
            NoSeguridadSocial = model.NoSeguridadSocial;

            FechaBaja = model.FechaBaja;
            FechaCambioNivel = model.FechaCambioNivel;
            FechaNacimientoHijo1 = model.FechaNacimientoHijo1;
            FechaNacimientoHijo2 = model.FechaNacimientoHijo2;
            FechaNacimientoHijo3 = model.FechaNacimientoHijo3;
            IdGrupoProfesional = model.IdGrupoProfesional;
            IdNivelSalarial = model.IdNivelSalarial;
            MaximoVariable = model.MaximoVariable;
            Sexo = model.Sexo;

            IdLineaNegocio = model.IdLineaNegocio;
            IdPosicion = model.IdPosicion;
        }
    }
}
