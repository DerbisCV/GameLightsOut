using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("InmuebleContacto")]
    public class InmuebleContacto
    {
        #region Constructors

        public InmuebleContacto(){ CreateBase(); }
        public InmuebleContacto(string nombre, string telefono, string email)
        {
            CreateBase();
            NombreApellidos = nombre;
            Telefono = telefono;
            Email = email;
        }

        private void CreateBase()
        {
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdInmuebleContacto { get; set; }

        public int IdInmueble { get; set; }
        [ForeignKey("IdInmueble")]
        public virtual Inmueble Inmueble { get; set; }

        public string NombreApellidos { get; set; }
        public string Cargo { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Observaciones { get; set; }

        #endregion

        #region Properties virtual ICollection

        //public virtual ICollection<NotificacionMailAttachment> NotificacionMailAttachmentSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{NombreApellidos} [{Telefono}] [{Email}].";
        }

        #endregion

    }
}
