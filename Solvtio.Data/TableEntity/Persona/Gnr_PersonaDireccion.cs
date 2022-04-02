namespace Solvtio.Models
{
    public partial class Gnr_PersonaDireccion
    {
        public int IdPersonaDireccion { get; set; }
        public int IdPersona { get; set; }
        public int IdTipoDireccion { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Region { get; set; }
        public string CodigoPostal { get; set; }
        public string Pais { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public virtual Gnr_Persona Gnr_Persona { get; set; }
        public virtual Gnr_TipoDireccion Gnr_TipoDireccion { get; set; }
    }
}
