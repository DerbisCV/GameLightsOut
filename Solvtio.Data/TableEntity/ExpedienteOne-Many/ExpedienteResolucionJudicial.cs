using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ExpedienteResolucionJudicial")]
    public class ExpedienteResolucionJudicial
    {
        #region Constructors

        public ExpedienteResolucionJudicial(){ CreateBase(); }
        public ExpedienteResolucionJudicial(int idExpediente, string usuario)
        {
            CreateBase();
            IdExpediente = idExpediente;
            Usuario = usuario;
        }

        private void CreateBase()
        {
            Fecha = DateTime.Today;
            FechaAlta = DateTime.Now;
        }

        #endregion

        #region Properties
        
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedienteResolucionJudicial { get; set; }

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public DateTime Fecha { get; set; }
        public int? IdTipo { get; set; }
        [ForeignKey("IdTipo")]
        public virtual CaracteristicaBase Tipo { get; set; }

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
