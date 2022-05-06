namespace Solvtio.Data.Models.Dtos
{
    public class ExpedienteDeudorDto
    {
        public int IdExpedienteDeudor { get; set; }
        public DtoIdNombre Gnr_TipoDeudor { get; set; }
        public DtoIdNombre Provincia { get; set; }
        public PersonaDto Persona { get; set; } //TelefonosTodos EmailsTodos
        public int IdExpediente { get; set; }
        public string DomicilioNotificacion { get; set; }
        public string AbogadoNombre { get; set; }
        public string AbogadoDespacho { get; set; }
        public string AbogadoTelefono { get; set; }

        //public int IdPersona { get; set; }
        //public int IdTipoDeudor { get; set; }
        //public virtual Expediente Expediente { get; set; }
        //public virtual Gnr_Persona Gnr_Persona { get; set; }
        //public string AbogadoEmail { get; set; }
        //public string AbogadoDireccion { get; set; }

        #region Properties New

        //public int? IdProvincia { get; set; }
        //[ForeignKey("IdProvincia")]

        //public int? IdMunicipio { get; set; }
        //[ForeignKey("IdMunicipio")]
        //public virtual Municipio Municipio { get; set; }

        //public string CodigoPostal { get; set; }

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

        #endregion
    }
}
