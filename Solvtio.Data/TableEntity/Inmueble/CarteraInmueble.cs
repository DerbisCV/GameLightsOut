using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("CarteraInmueble")]
    public class CarteraInmueble
    {
        #region Constructors

        public CarteraInmueble(){ CreateBase(); }
        public CarteraInmueble(int idCartera, int idInmueble, string usuario)
        {
            CreateBase();
            IdCartera = idCartera;
            IdInmueble = idInmueble;
            Usuario = usuario;
        }


        private void CreateBase()
        {
            FechaAlta = DateTime.Today;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCarteraInmueble { get; set; }

        public int IdCartera { get; set; }
        [ForeignKey("IdCartera")]
        public virtual CarteraInmobiliaria Cartera { get; set; }

        public int IdInmueble { get; set; }
        [ForeignKey("IdInmueble")]
        public virtual Hip_Inmueble HipInmueble { get; set; }
               
        //public string Nota { get; set; }

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

        //public override string ToString()
        //{
        //    return $"{FechaAlta.ToShortDateString()} [{TipoNota.GetDescription()}]: {Nota}.";
        //}

        #endregion

    }
}
