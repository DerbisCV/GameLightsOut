using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("HipInmuebleNota")]
    public class HipInmuebleNota
    {
        #region Constructors

        public HipInmuebleNota(){ CreateBase(); }
        public HipInmuebleNota(TipoNotaInmueble tipo, string nota, string usuario)
        {
            CreateBase();
            TipoNota = tipo;
            Nota = nota;
            Usuario = usuario;
        }
        public HipInmuebleNota(int idInmueble, string usuario)
        {
            CreateBase();
            IdInmueble = idInmueble;
            Usuario = usuario;
        }
        private void CreateBase()
        {
            Fecha = DateTime.Today;
            TipoNota = TipoNotaInmueble.Nota;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdInmuebleNota { get; set; }

        public int IdInmueble { get; set; }
        [ForeignKey("IdInmueble")]
        public virtual Hip_Inmueble Inmueble { get; set; }

        public string Nota { get; set; }
        public TipoNotaInmueble TipoNota { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }

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
            return $"{Fecha.ToShortDateString()} [{TipoNota.GetDescription()}]: {Nota}.";
        }

        #endregion

    }
}
