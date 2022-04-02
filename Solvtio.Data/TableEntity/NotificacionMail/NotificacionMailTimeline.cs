using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("NotificacionMailTimeline")]
    public partial class NotificacionMailTimeline : IDescripcion
    {
        #region Constructors

        public NotificacionMailTimeline()
        {
            CreateBase();
        }

        public NotificacionMailTimeline(int idNotificacionMail, string descripcion, string usuario)
        {
            CreateBase();

            IdNotificacionMail = idNotificacionMail;
            Descripcion = descripcion;
            Usuario = usuario;
        }

        private void CreateBase()
        {
            Fecha = DateTime.Now;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdNotificacionMailTimeline { get; set; }

        public int IdNotificacionMail { get; set; }
        [ForeignKey("IdNotificacionMail")]
        public virtual NotificacionMail NotificacionMail { get; set; }

        public string Descripcion { get; set; }
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
