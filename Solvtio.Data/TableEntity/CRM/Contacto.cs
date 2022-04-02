using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;
using System.Collections.Generic;

namespace Solvtio.Models
{
    [Table("Contacto")]
    public class Contacto : INombre
    {
        #region Constructors

        public Contacto()
        {
            CreateBase();
        }
        public Contacto(int? idEmpresa)
        {
            CreateBase();
            IdEmpresa = idEmpresa;
        }

        private void CreateBase()
        {
            FechaAlta = DateTime.Now;
            TipoContacto = TipoContacto.Persona;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdContacto { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public TipoContacto TipoContacto { get; set; }

        public string Cargo { get; set; }
        public int? IdEmpresa { get; set; }
        [ForeignKey("IdEmpresa")]
        public Gnr_ClienteOficina Empresa { get; set; }

        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string DireccionProvincia{ get; set; }
        public string DireccionCiudad { get; set; }
        public string DireccionCp { get; set; }

        public string Notas { get; set; }

        public DateTime FechaAlta { get; set; }
        public bool Inactivo { get; set; }
        public bool IncludeInNewsLetter { get; set; }        

        public virtual ICollection<Oportunidad> OportunidadSet { get; set; } //Oportunidades con ...
        public virtual ICollection<OportunidadContacto> OportunidadContactoSet { get; set; }

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

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public DateTime? FechaNotificacionDemandaConDiasHabiles { get; set; }

        #endregion
    }
}
