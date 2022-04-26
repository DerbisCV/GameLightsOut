using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class Gnr_Valija
    {
        public Gnr_Valija()
        {
            //Expedientes = new List<Expediente>();
        }

        public int IdValija { get; set; }
        public int IdClienteOficina { get; set; }
        public System.DateTime FechaRecepcion { get; set; }
        public string Referencia { get; set; }
        public string Usuario { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public int IdTipoExpediente { get; set; }
        
  //      public virtual ICollection<Expediente> Expedientes { get; set; }
  //      public virtual Gnr_ClienteOficina Gnr_ClienteOficina { get; set; }
  //      public virtual Gnr_TipoExpediente Gnr_TipoExpediente { get; set; }

		//public virtual ICollection<Hip_Hipoteca> Hip_Hipoteca { get; set; }
    }
}
