using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("InmuebleEstado")]
    public class InmuebleEstado
    {
        #region Constructors

        public InmuebleEstado(){ CreateBase(); }
        //public InmuebleEstado(int id, string telefono, string email)
        //{
        //    CreateBase();
        //    NombreApellidos = nombre;
        //    Telefono = telefono;
        //    Email = email;
        //}

        private void CreateBase()
        {
            Fecha = DateTime.Now.Date;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdInmuebleEstado { get; set; }

        public int IdInmueble { get; set; }
        [ForeignKey("IdInmueble")]
        public virtual Inmueble Inmueble { get; set; }

        public int IdTipoEstado { get; set; }
        [ForeignKey("IdTipoEstado")]
        public virtual CaracteristicaBase TipoEstado { get; set; }

        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }

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

        //public override string ToString()
        //{
        //    return $"{Fecha.ToShortDateString()} [{TipoEstado}] [{Email}].";
        //}

        #endregion

    }
}
