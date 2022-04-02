using System.Collections.Generic;
using System.Linq;

namespace Solvtio.Models
{
    public class ModelNotificacionAll
    {
		#region Constructors
		public ModelNotificacionAll() 
		{
			CreateBase();
		}
		public ModelNotificacionAll(ModelFilterBase filter)
        {
			CreateBase();
            Filter = filter;
        }

		private void CreateBase()
		{
			Filter = new ModelFilterBase();
            LstNotificacionMail = new List<NotificacionMail>();
		}
		#endregion

		#region Properties

		public ModelFilterBase Filter { get; set; }
        public List<NotificacionMail> LstNotificacionMail { get; set; }

        public List<NotificacionMail> LstNotificacionMailPendiente => LstNotificacionMail.Where(x => x.Estado == EstadoMail.Pendiente).ToList();

        public Usuario Usuario { get; set; }
        public Gnr_Persona Persona { get; set; }
        public List<Usuario> LstUsuario { get; set; }
        public int TotalTramitado { get; set; }
        public int TotalPendiente { get; set; }
        public int Total => TotalTramitado + TotalPendiente;

        #endregion
    }
}
