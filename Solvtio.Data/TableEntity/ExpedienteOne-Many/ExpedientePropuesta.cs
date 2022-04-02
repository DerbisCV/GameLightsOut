using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ExpedientePropuesta")]
    public class ExpedientePropuesta
    {
        #region Constructors

        public ExpedientePropuesta(){ CreateBase(); }
        public ExpedientePropuesta(string titulo, string usuario)
        {
            CreateBase();
            Titulo = titulo;
            Usuario = usuario;
        }
        public ExpedientePropuesta(int idExpediente, string usuario)
        {
            CreateBase();
            IdExpediente = idExpediente;
            Usuario = usuario;
        }

        private void CreateBase()
        {
            Fecha = DateTime.Today;
            FechaAlta = DateTime.Now;
            Estado = TipoEstadoPropuesta.Borrador;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedientePropuesta { get; set; }

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public string Titulo { get; set; }
        public TipoEstadoPropuesta Estado { get; set; }

        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaAlta { get; set; }

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
            return $"{Fecha.ToShortDateString()}: {Titulo} [{Estado.GetDescription()}]";
        }

        #endregion

    }

}
