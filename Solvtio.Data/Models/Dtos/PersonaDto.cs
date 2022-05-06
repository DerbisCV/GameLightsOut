namespace Solvtio.Data.Models.Dtos
{
    public class PersonaDto
    {
        #region Properties

        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string NombreApellidos { get; set; }
        public int IdTipoIdentidad { get; set; }
        public string NoDocumento { get; set; }
        public string Telefono { get; set; }
        public string TelefonosTodos { get; set; }
        public string TelefonoPrincipal { get; set; }
        public string Email { get; set; }
        public string EmailsTodos { get; set; }

        public string Direccion { get; set; }
        public string CodigoPostal { get; set; }

        public string DomicilioNotificacion { get; set; }

        #endregion
    }
}
