using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ExpedienteAbogado")]
    public class ExpedienteAbogado
    {
        #region Constructors

        public ExpedienteAbogado(){ CreateBase(); }
        public ExpedienteAbogado(int idExpediente, int idAbogado)
        {
            CreateBase();
            IdExpediente = idExpediente;
            IdAbogado = idAbogado;
        }

        private void CreateBase()
        {
        }

        #endregion

        #region Properties
        
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedienteAbogado { get; set; }

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public int IdAbogado{ get; set; }
        [ForeignKey("IdAbogado")]
        public virtual Gnr_Abogado Abogado { get; set; }

       

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
