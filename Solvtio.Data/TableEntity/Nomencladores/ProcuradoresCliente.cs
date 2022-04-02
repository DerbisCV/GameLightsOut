namespace Solvtio.Models
{
    public partial class ProcuradoresCliente
    {
        public int IdProcuradorCliente { get; set; }
        public int IdCliente { get; set; }
        public int IdProcurador { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public virtual Gnr_Cliente Gnr_Cliente { get; set; }
        public virtual GNR_Procuradores GNR_Procuradores { get; set; }
    }
}
