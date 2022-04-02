using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public partial class RolePage
	{
		#region Constructors

		public RolePage()
		{
			FechaAlta = DateTime.Now;
		}

		public RolePage(int idRole, string partialUrlPath, bool allowed)
		{
			IdRole = idRole;
			PartialUrl = partialUrlPath;
			Allowed = allowed;

			FechaAlta = DateTime.Now;
		}

		#endregion

		#region Properties

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int IdRolePage { get; set; }

		public int IdRole { get; set; }
		public virtual Role Role { get; set; }

		public string PartialUrl { get; set; }

		public bool Allowed { get; set; }

		public DateTime FechaAlta { get; set; }

		//public virtual ICollection<Usuario> UsuarioSet { get; set; }
		//public virtual ICollection<Alq_Expediente_EstadoTramitaJuzgado> Alq_Expediente_EstadoTramitaJuzgado { get; set; }
		//public virtual ICollection<Expediente> Expedientes { get; set; }
		//public virtual Gnr_Persona Gnr_Persona { get; set; }
		//public virtual ICollection<Gnr_Cliente> Gnr_Cliente { get; set; }

		#endregion

		#region Properties Readonly

		#endregion
	}
}
