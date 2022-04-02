using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class Gnr_Juzgado
    {
        public Gnr_Juzgado()
        {
            //Alq_Expediente = new List<Alq_Expediente>();
        }

        public int IdJuzgado { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        //public virtual ICollection<Alq_Expediente> Alq_Expediente { get; set; }
    }
}
