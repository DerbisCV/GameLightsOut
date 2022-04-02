using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("NotificacionBuzon")]
    public class NotificacionBuzon
    {
        #region Constructors
        public NotificacionBuzon()
        {
            CreateBase();
        }

        private void CreateBase()
        {
            //Fecha = FechaAlta = FechaActualizacion = DateTime.Now;
            //Tramitado = false;
            //NotificacionMailAttachmentSet = new Collection<NotificacionMailAttachment>();
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdNotificacionBuzon { get; set; }
        public int IdClienteOficina { get; set; }
        [ForeignKey("IdClienteOficina")]
        public virtual Gnr_ClienteOficina ClienteOficina { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool Activo { get; set; }
        public DateTime? Checked { get; set; }

        public string SpUrlFolderNotificacion { get; set; }

        public string ClienteOficinaOtras { get; set; }

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
    }
}
