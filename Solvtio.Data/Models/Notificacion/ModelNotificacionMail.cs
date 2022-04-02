using System;
using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelNotificacionMail
    {
        #region Constructors

        public ModelNotificacionMail()
        {
            CreateBase();
        }
        private void CreateBase()
        {
            De = DestinatariosToCc = Cuerpo = "";
            IsBodyHtml = false;
            //Fecha = DateTime.Now;
            AttachmentSet = new List<ModelNotificacionMailAttachment>();
        }

        #endregion

        #region Properties 

        public string RefMessageId { get; set; }
        public string De { get; set; }
        public string DestinatariosToCc { get; set; }
        public string Asunto { get; set; }
        public string Cuerpo { get; set; }
        public bool IsBodyHtml { get; set; }
        public string NoExpediente { get; set; }
        public string Fecha { get; set; }
        public int? IdTipoAreaNotificacion { get; set; }
        public bool Urgente { get; set; }

        public int CountAttachment { get; set; }
        public virtual List<ModelNotificacionMailAttachment> AttachmentSet { get; set; }

        public int? IdUsuario1 { get; set; }
        public int? IdUsuario2 { get; set; }
        public int? IdUsuario3 { get; set; }
        public bool Finalizar { get; set; }
        public string Usuario { get; set; }
        public string Observaciones { get; set; }

        public bool IsValid()
        {
            return true;
        }

        #endregion
    }

    public class ModelNotificacionMailAttachment
    {
        public string NombreFichero { get; set; }
        public string FileUrl { get; set; }
        public string FechaDocumento { get; set; }
    }
}
