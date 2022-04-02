using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("Auto")]
    public class Auto : ActuacionBase
    {
        #region Constructors

        public Auto(){ CreateBase(); }
        public Auto(string observaciones, string usuario)
        {
            CreateBase();
            Observaciones = observaciones;
            Usuario = usuario;
        }
        public Auto(int idExpediente, string usuario)
        {
            CreateBase();
            IdExpediente = idExpediente;
            Usuario = usuario;
        }

        private void CreateBase()
        {
            Fecha = DateTime.Today;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAuto { get; set; }

        public int IdExpedienteEstado { get; set; }
        //[ForeignKey("IdExpedienteEstado")]
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public string Titulo { get; set; }
        public DateTime? FechaNotificacion { get; set; }
        public DateTime? FechaVencimiento { get; set; }

        #endregion

        #region Properties virtual ICollection

        //public virtual ICollection<NotificacionMailAttachment> NotificacionMailAttachmentSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{Fecha.ToShortDateString()}: {Observaciones}";
        }

        #endregion

    }

}
