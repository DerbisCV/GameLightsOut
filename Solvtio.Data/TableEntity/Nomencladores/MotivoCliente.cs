using Solvtio.Models.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("MotivoCliente")]
    public class MotivoCliente : Auditable, INombre
    {
        #region Constructors

        public MotivoCliente()
        {
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMotivoCliente { get; set; }

        public string Nombre { get; set; }

        public bool Activo { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Usuario { get; set; }

        #endregion

        #region Properties ReadOnly

        public override bool IsNew => IdMotivoCliente <= 0;

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public string NoExpediente { get; set; }

        #endregion
    }
}
