using Solvtio.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteRecursoReposicion")]
    public class ExpedienteRecursoReposicion
    {
        #region Constructors

        public ExpedienteRecursoReposicion() { FechaAlta = DateTime.Now; }
        public ExpedienteRecursoReposicion(int idExpediente, string tipoAcuerdo, string usuario) : this()
        {
            IdExpediente = idExpediente;
            Usuario = usuario;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedienteRecursoReposicion { get; set; }

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public DateTime? FechaEjecutanteInterposicion { get; set; }
        public DateTime? FechaEjecutanteImpugnacion { get; set; }

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

        #region Methods

        public override string ToString()
        {
            return $"{IdExpedienteRecursoReposicion}: {FechaEjecutanteInterposicion.ToShortDateString()} / {FechaEjecutanteImpugnacion.ToShortDateString()}";
        }

        public void RefreshBy(ExpedienteRecursoReposicion model)
        {
            FechaEjecutanteInterposicion = model.FechaEjecutanteInterposicion;
            FechaEjecutanteImpugnacion = model.FechaEjecutanteImpugnacion;
        }

        #endregion

    }
}
