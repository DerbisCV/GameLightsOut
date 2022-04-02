using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("InmuebleNota")]
    public class InmuebleNota
    {
        #region Constructors

        public InmuebleNota(){ CreateBase(); }
        public InmuebleNota(TipoNotaInmueble tipo, string nota, string usuario)
        {
            CreateBase();
            TipoNota = tipo;
            Nota = nota;
            Usuario = usuario;
        }
        public InmuebleNota(int idInmueble, string usuario)
        {
            CreateBase();
            IdInmueble = idInmueble;
            Usuario = usuario;
        }
        //public ExpedienteNota(ExpedienteEstado estado)
        //{
        //    CreateBase();
        //    IdExpediente = estado.IdExpediente;
        //    IdExpedienteEstado = estado.ExpedienteEstadoId;
        //    Nota = estado.Nota;
        //    Usuario = estado.NotaUsuario;
        //    NoteType = NoteType.Estado;
        //}

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
        public virtual Inmueble Inmueble { get; set; }

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
