namespace Solvtio.Models
{
    public partial class ProcuradorPartidoJudicial
    {
        public int IdProcuradorPartidoJudicial { get; set; }
        public int IdProcurador { get; set; }
        public int IdPartidoJudicial { get; set; }
        public string Observaciones { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public string Usuario { get; set; }
        public virtual Gnr_Procurador Procurador { get; set; }
        public virtual PartidoJudicial PartidoJudicial { get; set; }
    }
}
