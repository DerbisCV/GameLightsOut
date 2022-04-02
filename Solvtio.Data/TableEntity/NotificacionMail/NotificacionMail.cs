using Solvtio.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Net.Mail;

namespace Solvtio.Models
{
    [Table("NotificacionMails")]
    public partial class NotificacionMail
    {
        #region Constructors

        public NotificacionMail()
        {
            CreateBase();
        }
        public NotificacionMail(MailMessage mailMsg)
        {
            CreateBase();

            De = mailMsg.From.Address;
            foreach (var x in mailMsg.To)
                DestinatariosToCc += $"{x.Address}, ";
            foreach (var x in mailMsg.CC)
                DestinatariosToCc += $"{x.Address}, ";
            foreach (var x in mailMsg.Bcc)
                DestinatariosToCc += $"{x.Address}, ";

            Cuerpo = mailMsg.Body;
            IsBodyHtml = mailMsg.IsBodyHtml;
        }

        public NotificacionMail(NotificacionMail notifBase)
        {
            CreateBase();

            Fecha = notifBase.Fecha;
            Urgente = notifBase.Urgente;
            De = notifBase.De;
            DestinatariosToCc = notifBase.DestinatariosToCc;
            Asunto = notifBase.Asunto;
            Cuerpo = notifBase.Cuerpo;
            IsBodyHtml = notifBase.IsBodyHtml;
            RefMessageId = notifBase.RefMessageId;
            IdClienteOficina = notifBase.IdClienteOficina;
            Observaciones = notifBase.Observaciones;
            IdExpediente = notifBase.IdExpediente;
            IdCategoriaColor = notifBase.IdCategoriaColor;
        }

        public NotificacionMail(ModelNotificacionMail modelNotificacionMail)
        {
            CreateBase();

            De = modelNotificacionMail.De;
            DestinatariosToCc = modelNotificacionMail.DestinatariosToCc;
            Asunto = modelNotificacionMail.Asunto;
            Cuerpo = modelNotificacionMail.Cuerpo;
            IsBodyHtml = modelNotificacionMail.IsBodyHtml;
            NoExpediente = modelNotificacionMail.NoExpediente;
            Fecha = DateTime.ParseExact(modelNotificacionMail.Fecha, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            RefMessageId = modelNotificacionMail.RefMessageId;
            Urgente = modelNotificacionMail.Urgente;
            UsuarioAlta = modelNotificacionMail.Usuario;
            if (modelNotificacionMail.IdUsuario1 > 0) IdUsuarioAsignado = modelNotificacionMail.IdUsuario1;
            //if (modelNotificacionMail.IdUsuario2 > 0) IdUsuarioAsignado2 = modelNotificacionMail.IdUsuario2;
            //if (modelNotificacionMail.IdUsuario3 > 0) IdUsuarioAsignado3 = modelNotificacionMail.IdUsuario3;
            if (modelNotificacionMail.IdTipoAreaNotificacion > 0) IdTipoAreaNotificacion = modelNotificacionMail.IdTipoAreaNotificacion;
            if (modelNotificacionMail.Finalizar) Estado = EstadoMail.Tramitado;
            Observaciones = modelNotificacionMail.Observaciones;
        }

        private void CreateBase()
        {
            Fecha = FechaAlta = FechaActualizacion = DateTime.Now;
            Estado = EstadoMail.Pendiente;
            NotificacionMailAttachmentSet = new Collection<NotificacionMailAttachment>();
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdNotificacionMail { get; set; }

        [Index]
        public DateTime Fecha { get; set; }
        public string Asunto { get; set; }
        public string Cuerpo { get; set; }
        public bool IsBodyHtml { get; set; }
        public string RefMessageId { get; set; }
        public string De { get; set; }
        public int CountAttachment { get; set; }
        public string Observaciones { get; set; }

        public int? IdClienteOficina { get; set; }
        [ForeignKey("IdClienteOficina")]
        public virtual Gnr_ClienteOficina ClienteOficina { get; set; }

        public string DestinatariosToCc { get; set; }

        public int? IdExpediente { get; set; }
        public virtual Expediente Expediente { get; set; }


        public int? IdTipoAreaNotificacion { get; set; }
        [ForeignKey("IdTipoAreaNotificacion")]
        public virtual TipoAreaNotificacion TipoAreaNotificacion { get; set; }
        public DateTime? FechaUltimaAsignacionArea { get; set; }

        public int? IdUsuarioAsignado { get; set; }
        [ForeignKey("IdUsuarioAsignado")]
        public virtual Usuario UsuarioAsignado { get; set; }

        public int? IdUsuarioAsignado2 { get; set; }
        [ForeignKey("IdUsuarioAsignado2")]
        public virtual Usuario UsuarioAsignado2 { get; set; }

        public int? IdUsuarioAsignado3 { get; set; }
        [ForeignKey("IdUsuarioAsignado3")]
        public virtual Usuario UsuarioAsignado3 { get; set; }

        public int? IdGrupoAsignado { get; set; }
        [ForeignKey("IdGrupoAsignado")]
        public virtual Grupo GrupoAsignado { get; set; }

        public DateTime FechaAlta { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string UsuarioAlta { get; set; }
        public string UsuarioActualizacion { get; set; }
        public bool Urgente { get; set; }

        public EstadoMail? Estado { get; set; }

        public int? ClonadoDesdeIdNotificacion { get; set; }

        public int? IdCategoriaColor { get; set; }
        [ForeignKey("IdCategoriaColor")]
        public virtual CaracteristicaBase CategoriaColor { get; set; }

        #endregion

        #region Properties virtual ICollection

        public virtual ICollection<NotificacionMailAttachment> NotificacionMailAttachmentSet { get; set; }
        public virtual ICollection<NotificacionMailAsignacion> NotificacionMailAsignacionSet { get; set; }
        public virtual ICollection<NotificacionMailTimeline> NotificacionMailTimelineSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        [NotMapped]
        public string NoExpediente { get; set; }

        #endregion
    }
}
