using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ExpedienteNota")]
    public class ExpedienteNota
    {
        #region Constructors

        public ExpedienteNota(){ CreateBase(); }
        public ExpedienteNota(string nota, string usuario)
        {
            CreateBase();
            Nota = nota;
            Usuario = usuario;
        }
        public ExpedienteNota(int idExpediente, string usuario)
        {
            CreateBase();
            IdExpediente = idExpediente;
            Usuario = usuario;
        }
        public ExpedienteNota(ExpedienteEstado estado)
        {
            CreateBase();
            IdExpediente = estado.IdExpediente;
            IdExpedienteEstado = estado.ExpedienteEstadoId;
            Nota = estado.Nota;
            Usuario = estado.NotaUsuario;
            NoteType = NoteType.Estado;
        }

        private void CreateBase()
        {
            Fecha = DateTime.Today;
            NoteType = NoteType.None;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedienteNota { get; set; }

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public int? IdExpedienteEstado { get; set; }
        [ForeignKey("IdExpedienteEstado")]
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public int? IdFase { get; set; }
        [ForeignKey("IdFase")]
        public virtual CaracteristicaBase Fase { get; set; }

        public int? IdSubfase { get; set; }
        [ForeignKey("IdSubfase")]
        public virtual CaracteristicaBase Subfase { get; set; }

        public string Nota { get; set; }
        public NoteType NoteType { get; set; }
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
            return $"{Fecha.ToShortDateString()} ({NoteType.GetDescription()}): {Nota}.";
        }

        public void RefreshBy(ExpedienteNota model)
        {
            Nota = model.Nota;
            NoteType = model.NoteType;
            Usuario = model.Usuario;
            Fecha = model.Fecha;
        }

        #endregion

    }
}
