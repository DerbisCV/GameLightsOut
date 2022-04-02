namespace Solvtio.Models
{
    public partial class vInmueblePrincipal
    {
        public int? IdInmueble { get; set; }
        public int IdExpediente { get; set; }
        public int IdTipoInmueble { get; set; }
        public bool EsHabitual { get; set; }
        public decimal Superficie { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string DireccionLocalidad { get; set; }
        public string DireccionCodigoPostal { get; set; }
        public string DireccionProvincia { get; set; }
        public decimal PrestamoCapital { get; set; }
        public decimal DeudaPrincipal { get; set; }
        public string NumeroFinca { get; set; }
        public string Tomo { get; set; }
        public string Libro { get; set; }
        public string Folio { get; set; }
        public string Registro { get; set; }
        public string Inscripcion { get; set; }
        public string Oficina { get; set; }
        public string NoCuentaPrestamo { get; set; }
    }
}
