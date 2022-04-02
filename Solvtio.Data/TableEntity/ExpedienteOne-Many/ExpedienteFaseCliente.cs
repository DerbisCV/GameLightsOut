using Solvtio.Models.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteFaseCliente")]
    public class ExpedienteFaseCliente : Auditable
    {
        #region Constructors

        public ExpedienteFaseCliente() { CreateBase(); }
        public ExpedienteFaseCliente(string nota, string usuario)
        {
            CreateBase();
            //Nota = nota;
            //Usuario = usuario;
        }
        public ExpedienteFaseCliente(int idExpediente)
        {
            CreateBase();
            IdExpediente = idExpediente;
            //Usuario = usuario;
        }
        //public ExpedienteFaseCliente(ExpedienteEstado estado)
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
            //NoteType = NoteType.None;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedienteFaseCliente { get; set; }

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        public int IdFaseCliente { get; set; }
        [ForeignKey("IdFaseCliente")]
        public virtual FaseCliente FaseCliente { get; set; }

        public int? IdMotivoCliente { get; set; }
        [ForeignKey("IdMotivoCliente")]
        public virtual MotivoCliente MotivoCliente { get; set; }

        #endregion

        #region Properties virtual ICollection

        //public virtual ICollection<NotificacionMailAttachment> NotificacionMailAttachmentSet { get; set; }

        #endregion

        #region Properties ReadOnly

        public override bool IsNew => IdExpedienteFaseCliente <= 0;

        internal void Refresh(ExpedienteFaseCliente modelBase)
        {
            Fecha = modelBase.Fecha;
            IdMotivoCliente = modelBase.IdMotivoCliente;
        }

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion

        #region Methods

        //public override string ToString()
        //{
        //    return $"{Fecha.ToShortDateString()} [{NoteType.GetDescription()}]: {Nota}.";
        //}

        //public void RefreshBy(ExpedienteFaseCliente model)
        //{
        //    Nota = model.Nota;
        //    NoteType = model.NoteType;
        //    Usuario = model.Usuario;
        //    Fecha = model.Fecha;
        //}

        #endregion

    }
}
