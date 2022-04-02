using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("InmuebleContrato")]
    public class InmuebleContrato
    {
        #region Constructors

        public InmuebleContrato(){ CreateBase(); }
        public InmuebleContrato(int idInmueble, int idExpediente)
        {
            CreateBase();
            IdInmueble = idInmueble;
            IdExpediente = idExpediente;
        }
        private void CreateBase()
        {
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdInmuebleContrato { get; set; }

        public int IdInmueble { get; set; }
        //[ForeignKey("IdInmueble")]
        //public virtual Hip_Inmueble Inmueble { get; set; }

        public int IdExpedienteContrato { get; set; }
        [ForeignKey("IdExpedienteContrato")]
        public virtual ExpedienteContrato Contrato { get; set; }

        public string RangoRegistral { get; set; }
        public decimal? PorcientoPropiedadHipotecado { get; set; }

        #endregion

        #region Properties virtual ICollection

        //public virtual ICollection<NotificacionMailAttachment> NotificacionMailAttachmentSet { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        [NotMapped]
        public int IdExpediente { get; set; }

        [NotMapped]
        public Hip_Inmueble Finca { get; set; }

        #endregion

        #region Methods

        //public override string ToString()
        //{
        //    return $"{Fecha.ToShortDateString()} [{TipoNota.GetDescription()}]: {Nota}.";
        //}

        #endregion

    }
}
