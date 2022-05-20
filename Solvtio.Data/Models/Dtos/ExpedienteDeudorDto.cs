namespace Solvtio.Data.Models.Dtos
{
    public class ExpedienteDeudorDto
    {
        public int IdExpedienteDeudor { get; set; }
        public int IdExpediente { get; set; }
        public int IdTipoDeudor { get; set; }
        public DtoIdNombre Gnr_TipoDeudor { get; set; }

        public int? IdProvincia { get; set; }
        public DtoIdNombre Provincia { get; set; }
        public int? IdMunicipio { get; set; }

        public PersonaDto Persona { get; set; } //TelefonosTodos EmailsTodos

        public string DomicilioNotificacion { get; set; }
        public string CodigoPostal { get; set; }
        public string AbogadoNombre { get; set; }
        public string AbogadoDespacho { get; set; }
        public string AbogadoTelefono { get; set; }
        public string AbogadoEmail { get; set; }
        public string AbogadoDireccion { get; set; }


        //public int IdPersona { get; set; }
        //public int IdTipoDeudor { get; set; }
        //public virtual Expediente Expediente { get; set; }
        //public virtual Gnr_Persona Gnr_Persona { get; set; }



        //[ForeignKey("IdProvincia")]


        //[ForeignKey("IdMunicipio")]
        //public virtual Municipio Municipio { get; set; }



        //public int? IdExpedienteContrato { get; set; }
        //[ForeignKey("IdExpedienteContrato")]
        //public virtual ExpedienteContrato ExpedienteContrato { get; set; }

        //public int? IdTipoGarantia { get; set; }
        //[ForeignKey("IdTipoGarantia")]
        //public virtual CaracteristicaBase TipoGarantia { get; set; }

        //public int? IdTipoResponsabilidad { get; set; }
        //[ForeignKey("IdTipoResponsabilidad")]
        //public virtual CaracteristicaBase TipoResponsabilidad { get; set; }

        //public string Observaciones { get; set; }

        public string personaNoDocumento { get; set; }
        public string personaNombre { get; set; }
        public string personaApellidos { get; set; }
        public string personaTelefono { get; set; }
        public string personaEmail { get; set; }
        public int? personaIdTipoIdentidad { get; set; }

        #region Methods


        #endregion
    }
}
