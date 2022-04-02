namespace Solvtio.Models
{
    public partial class Hip_HipotecaPagoACuenta
    {
        public int IdPagoACuenta { get; set; }
        public int IdHipoteca { get; set; }
        public System.DateTime Fecha { get; set; }
        public decimal Importe { get; set; }
        public virtual Hip_Hipoteca Hip_Hipoteca { get; set; }
    }
}
