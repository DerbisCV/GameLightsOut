using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.IO;

namespace Solvtio.Models
{
    [Table("NotificacionMailAttachment")]
    public partial class NotificacionMailAttachment
    {
        #region Constructors

        public NotificacionMailAttachment()
        {
            CreateBase();
        }

        public NotificacionMailAttachment(string dirDocumentos, string fileName, string refMessageId)
        {
            CreateBase();

            Nombre = fileName;
            Directorio = dirDocumentos;
            NombreFichero = string.Format("{0} - {1}", refMessageId, fileName);
        }

        public NotificacionMailAttachment(NotificacionMailAttachment attachment, int idNotificacionMail)
        {
            CreateBase();

            Directorio = attachment.Directorio;
            Nombre = attachment.Nombre;
            NombreFichero = $"{idNotificacionMail} - {attachment.Nombre}";
            FileUrl = attachment.FileUrl;
        }
        public NotificacionMailAttachment(ModelNotificacionMailAttachment attachment)
        {
            CreateBase();

            Directorio = "";
            Nombre = attachment.NombreFichero;
            NombreFichero = attachment.NombreFichero;
            FileUrl = attachment.FileUrl;
            if (!string.IsNullOrWhiteSpace(attachment.FechaDocumento) && attachment.FechaDocumento.Length >= 10)
                FechaDocumento = DateTime.ParseExact(attachment.FechaDocumento.Substring(0, 10), "yyyy-MM-dd", CultureInfo.InvariantCulture); // attachment.FechaDocumento;
        }

        private void CreateBase()
        {         
        }

        public void SetNewName(string newFileNameWithPath)
        {
            NombreFichero = newFileNameWithPath
                .Replace(Directorio, "")
                .Replace("\\", "");
            Nombre = NombreFichero.Replace($"{IdNotificacionMail} - ", "");
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdNotificacionMailAttachment { get; set; }
        public string Nombre { get; set; }
        public string NombreFichero { get; set; }
        public string Directorio { get; set; }
        public string FileUrl { get; set; }

        public DateTime? FechaDocumento { get; set; }

        public int IdNotificacionMail { get; set; }
        [ForeignKey("IdNotificacionMail")]
        public virtual NotificacionMail NotificacionMail { get; set; }

        #endregion

        #region Properties ReadOnly

        public string NombreFicheroConRuta => Path.Combine(Directorio ?? "", NombreFichero);
        public bool IsEmailBase => NombreFichero.Contains($"{IdNotificacionMail} - {IdNotificacionMail}.eml");
        public bool IsEmail => NombreFichero.EndsWith(".eml");

        #endregion

        #region Properties NotMapped

        [NotMapped]
        public string NoExpediente { get; set; }

        #endregion
    }
}
