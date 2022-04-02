using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class Gnr_ListasValores_Listas
    {
        public Gnr_ListasValores_Listas()
        {
            Gnr_ListasValores_Valores = new List<Gnr_ListasValores_Valores>();
        }

        public int ID { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Descripción { get; set; }
        public string Familia { get; set; }
        public int Orden { get; set; }
        public virtual ICollection<Gnr_ListasValores_Valores> Gnr_ListasValores_Valores { get; set; }
    }
}
