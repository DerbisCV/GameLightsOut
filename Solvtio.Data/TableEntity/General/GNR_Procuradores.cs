using System.Collections.Generic;

namespace Solvtio.Models
{
    public partial class GNR_Procuradores
    {
        public GNR_Procuradores()
        {
            ProcuradoresClientes = new List<ProcuradoresCliente>();
        }

        public int IdProcurador { get; set; }
        public int? IdPartidoJudicial { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Telefono2 { get; set; }
        public string Movil { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Provincia { get; set; }
        public string Direccion { get; set; }
        public int? IdTratamiento { get; set; }
        public string EnvioDemandas { get; set; }
        public virtual ICollection<ProcuradoresCliente> ProcuradoresClientes { get; set; }
    }
}
