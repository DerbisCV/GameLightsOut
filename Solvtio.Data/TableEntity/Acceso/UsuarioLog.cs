using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    public class UsuarioLog
	{
		#region Constructors

		public UsuarioLog()
		{
			FechaAlta = DateTime.Now;
		}
		public UsuarioLog(string usuario, ActionLogType actionLogType, int idExpAndReferencia)
		{
			UserName = usuario;
			ActionLog = actionLogType;
			IdReferencia = idExpAndReferencia;
			FechaAlta = DateTime.Now;
		}
        public UsuarioLog(string usuario, ActionLogType actionLogType, int? idExpediente, int idReferencia)
        {
            UserName = usuario;
            ActionLog = actionLogType;
            IdReferencia = idReferencia;
            IdExpediente = idExpediente;
            FechaAlta = DateTime.Now;
        }

        #endregion

        #region Properties

        [Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int IdUsuarioLog { get; set; }

		//public int IdUsuario { get; set; }
		//public virtual Usuario Usuario { get; set; }

		public ActionLogType ActionLog { get; set; }

		public int? IdReferencia { get; set; }
		public DateTime FechaAlta { get; set; }

        public int? IdExpediente { get; set; }
		[ForeignKey("IdExpediente")]
		public virtual Expediente Expediente { get; set; }
	    public string UserName { get; set; }

        #endregion

        #region Properties Readonly

        #endregion
    }
}
