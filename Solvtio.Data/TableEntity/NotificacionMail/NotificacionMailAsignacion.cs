using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("NotificacionMailAsignacion")]
    public partial class NotificacionMailAsignacion
    {
        #region Constructors

        public NotificacionMailAsignacion()
        {
            CreateBase();
        }

        public NotificacionMailAsignacion(int idTipoAreaNotificacion, string usuario)
        {
            CreateBase();

            IdTipoAreaNotificacion = idTipoAreaNotificacion;
            Usuario = usuario;
        }

        private void CreateBase()
        {
            Fecha = DateTime.Now;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdNotificacionMailAsignacion { get; set; }

        public int IdNotificacionMail { get; set; }
        [ForeignKey("IdNotificacionMail")]
        public virtual NotificacionMail NotificacionMail { get; set; }

        public int IdTipoAreaNotificacion { get; set; }
        [ForeignKey("IdTipoAreaNotificacion")]
        public virtual TipoAreaNotificacion TipoAreaNotificacion { get; set; }
        public DateTime Fecha { get; set; }

        public string Usuario { get; set; }

        #endregion

        #region Properties ReadOnly
        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion
    }
}
