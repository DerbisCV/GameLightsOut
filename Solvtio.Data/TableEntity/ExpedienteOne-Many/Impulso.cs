using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("Impulso")]
    public class Impulso : ActuacionBase
    {
        #region Constructors

        public Impulso(){ CreateBase(); }
        public Impulso(string observaciones, string usuario)
        {
            CreateBase();
            Observaciones = observaciones;
            Usuario = usuario;
        }
        public Impulso(int idExpediente, string usuario)
        {
            CreateBase();
            IdExpediente = idExpediente;
            Usuario = usuario;
        }

        private void CreateBase()
        {
            Fecha = DateTime.Today;
            TipoImpulso = TipoImpulso.None;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdImpulso { get; set; }

        public TipoImpulso TipoImpulso { get; set; }
        public bool AplicativoCliente { get; set; }

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
            return $"{Fecha.ToShortDateString()} ({TipoImpulso.GetDescription()}): {Observaciones}";
        }

        #endregion

    }

}
