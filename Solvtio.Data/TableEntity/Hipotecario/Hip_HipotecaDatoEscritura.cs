namespace Solvtio.Models
{
    public partial class Hip_HipotecaDatoEscritura
    {
        public int IdEscritura { get; set; }
        public int IdHipoteca { get; set; }
        public System.DateTime FechaEscritura { get; set; }
        public string ColegioNotario { get; set; }
        public string Notario { get; set; }
        public string NoProtocolo { get; set; }
        public string Observaciones { get; set; }
        public bool MandamientoJudicialEjecutivo { get; set; }
        public bool? Inscrita { get; set; }
        public virtual Hip_Hipoteca Hip_Hipoteca { get; set; }
    }
}
