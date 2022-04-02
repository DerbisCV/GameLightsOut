namespace Solvtio.Models
{
    public partial class Mnt_Expediente
    {
        public int IdExpediente { get; set; }
        public string CuentaOficina { get; set; }
        public string CuentaNo { get; set; }
        public decimal? Importe { get; set; }
        public int IdDeudorPrincipal { get; set; }
        public virtual Expediente Expediente { get; set; }
        public virtual Gnr_Persona Gnr_Persona { get; set; }
    }
}
