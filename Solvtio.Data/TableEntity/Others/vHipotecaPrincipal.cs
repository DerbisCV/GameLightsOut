namespace Solvtio.Models
{
    public partial class vHipotecaPrincipal
    {
        public int IdHipoteca { get; set; }
        public int? IdExpediente { get; set; }
        public int IdValija { get; set; }
        public int? IdPersona { get; set; }
        public int IdTipoArea { get; set; }
        public string OficinaNoCuenta { get; set; }
        public string NoCuentaPrestamo { get; set; }
        public int NoHipoteca { get; set; }
        public decimal DeudaCierreFijacion { get; set; }
        public bool Ejecutar { get; set; }
        public int? IdPartidoJudicial { get; set; }
    }
}
