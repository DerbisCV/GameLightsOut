using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ExpedienteCliente")]
    public class ExpedienteCliente
    {
        #region Constructors

        public ExpedienteCliente(){ CreateBase(); }
        public ExpedienteCliente(int idExpediente, string usuario)
        {
            CreateBase();
            IdExpediente = idExpediente;
            Usuario = usuario;
        }

        private void CreateBase()
        {
            FechaAlta = DateTime.Now;
        }

        #endregion

        #region Properties
        
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedienteCliente { get; set; }

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public int? IdClientePersona { get; set; }
        [ForeignKey("IdClientePersona")]
        public virtual Gnr_Persona ClientePersona { get; set; }

        public string Observaciones { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAlta { get; set; }

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
