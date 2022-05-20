using Solvtio.Data.Models.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public class ExpedienteDeudor
    {
        #region Constructors

        public ExpedienteDeudor()
        {
        }

        public ExpedienteDeudor(int idPersona, DeudorTipo deudorTipo = DeudorTipo.DeudorPrincipal, string domicilioNotificacion = "")
        {
            IdTipoDeudor = (int)deudorTipo;
            IdPersona = idPersona;
            DomicilioNotificacion = domicilioNotificacion;
        }
        public ExpedienteDeudor(int idPersona, int idTipoDeudor)
        {
            IdTipoDeudor = idTipoDeudor;
            IdPersona = idPersona;
        }
        public ExpedienteDeudor(ExpedienteDeudor expDeudorBase)
        {
            IdTipoDeudor = expDeudorBase.IdTipoDeudor;
            IdPersona = expDeudorBase.IdPersona;

            RequerimientoPagoFecha = expDeudorBase.RequerimientoPagoFecha;
            RequerimientoPagoPositivo = expDeudorBase.RequerimientoPagoPositivo;
            RequerimientoPagoResultadoApelacion = expDeudorBase.RequerimientoPagoResultadoApelacion;
        }

        public ExpedienteDeudor(Gnr_Persona basePersona, DeudorTipo tipoDeudor, int idExpediente) : this(basePersona.IdPersona, tipoDeudor, basePersona.Direccion)
        {
            IdExpediente = idExpediente;
        }

        public ExpedienteDeudor(ExpedienteDeudorDto model) : this()
        {
            IdExpediente = model.IdExpediente;
            IdTipoDeudor = model.IdTipoDeudor;
            DomicilioNotificacion = model.DomicilioNotificacion;
            CodigoPostal = model.CodigoPostal;
            IdProvincia = model.IdProvincia;
            IdMunicipio = model.IdMunicipio;

            CodigoPostal = model.CodigoPostal;
            AbogadoNombre = model.AbogadoNombre;
            AbogadoDespacho = model.AbogadoDespacho;
            AbogadoTelefono = model.AbogadoTelefono;
            AbogadoDireccion = model.AbogadoDireccion;
            AbogadoEmail = model.AbogadoEmail;
            //public PersonaDto Persona { get; set; } //TelefonosTodos EmailsTodos

            if (model.IdExpedienteDeudor > 0) IdExpedienteDeudor = model.IdExpedienteDeudor;
            if (model.Persona.IdPersona > 0) IdPersona = model.Persona.IdPersona;
        }

        #endregion

        #region Properties New

        public int? IdProvincia { get; set; }
        [ForeignKey("IdProvincia")]
        public virtual Provincia Provincia { get; set; }

        public int? IdMunicipio { get; set; }
        [ForeignKey("IdMunicipio")]
        public virtual Municipio Municipio { get; set; }

        public string CodigoPostal { get; set; }

        public int? IdExpedienteContrato { get; set; }
        [ForeignKey("IdExpedienteContrato")]
        public virtual ExpedienteContrato ExpedienteContrato { get; set; }

        public int? IdTipoGarantia { get; set; }
        [ForeignKey("IdTipoGarantia")]
        public virtual CaracteristicaBase TipoGarantia { get; set; }

        public int? IdTipoResponsabilidad { get; set; }
        [ForeignKey("IdTipoResponsabilidad")]
        public virtual CaracteristicaBase TipoResponsabilidad { get; set; }

        public string Observaciones { get; set; }

        public string AbogadoNombre { get; set; }
        public string AbogadoDespacho { get; set; }
        public string AbogadoTelefono { get; set; }
        public string AbogadoEmail { get; set; }
        public string AbogadoDireccion { get; set; }

        #endregion

        #region Properties Notificaciones / Req Pago

        public DateTime? NotificacionFecha { get; set; }
        public PositivoNegativoType? NotificacionEstado { get; set; }
        public bool NotificacionEdictos { get; set; }

        public DateTime? RequerimientoPagoFecha { get; set; }
        public bool RequerimientoPagoPositivo { get; set; }
        public PositivoNegativoType? RequerimientoPagoEstado { get; set; }
        public TipoResultadoApelacion? RequerimientoPagoResultadoApelacion { get; set; }

        #endregion

        #region Properties virtual ICollection

        public virtual ICollection<ExpedienteDeudorEjcutivo> ExpedienteDeudorEjcutivoSet { get; set; }
        public virtual ICollection<ExpedienteDeudorSalarioSaldo> ExpedienteDeudorSalarioSaldoSet { get; set; }
        public virtual ICollection<ExpedienteDeudorMueble> ExpedienteDeudorMuebleSet { get; set; }
        public virtual ICollection<ExpedienteDeudorEjcutivoAveriguacion> ExpedienteDeudorEjcutivoAveriguacionSet { get; set; }
        public virtual ICollection<ExpedienteDeudorBurofax> ExpedienteDeudorBurofaxSet { get; set; }

        #endregion

        #region Properties Old

        public int IdExpedienteDeudor { get; set; }
        [Index]
        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public int IdPersona { get; set; }
        [ForeignKey("IdPersona")]
        public virtual Gnr_Persona Gnr_Persona { get; set; }

        public int IdTipoDeudor { get; set; }
        [ForeignKey("IdTipoDeudor")]
        public virtual Gnr_TipoDeudor Gnr_TipoDeudor { get; set; }

        public string DomicilioNotificacion { get; set; }

        #endregion

        #region Properties ReadOnly

        private string _nombreCompleto;
        public string NombreCompleto
        {
            get
            {
                if (string.IsNullOrEmpty(_nombreCompleto))
                {

                    string tratamientodesc = "";
                    if (Gnr_Persona.IdTipoTratamiento != null)
                    {
                        if (Gnr_Persona.IdTipoTratamiento == 3)
                        {
                            tratamientodesc = Gnr_Persona.Gnr_TipoTratamiento.Descripcion.ToString();
                        }
                        else
                        {
                            tratamientodesc = Gnr_Persona.Gnr_TipoTratamiento.Descripcion.ToString().ToUpper();
                        }
                    }

                    var tratamiento = Gnr_Persona.IdTipoTratamiento != null && Gnr_Persona.IdTipoTratamiento > 0 ? tratamientodesc + " " : string.Empty;
                    var nombre = Gnr_Persona.Nombre != null ? Gnr_Persona.Nombre : string.Empty;
                    var apellido = Gnr_Persona.Apellidos != null ? Gnr_Persona.Apellidos : string.Empty;
                    _nombreCompleto = string.Format("{0}{1} {2}",
                        tratamiento,
                        nombre.ToUpper(),
                        apellido.ToUpper()).Trim();
                }

                return _nombreCompleto;
            }
        }

        private string _nombreCompletoSinTratamiento;
        public string NombreCompletoSinTratamiento
        {
            get
            {
                if (string.IsNullOrEmpty(_nombreCompletoSinTratamiento))
                {
                    _nombreCompletoSinTratamiento = string.Format("{0} {1}",
                        Gnr_Persona.Nombre,
                        Gnr_Persona.Apellidos).Trim();
                }

                return _nombreCompletoSinTratamiento;
            }
        }

        private string _nombreCompletoParaSubFolder;
        public string NombreCompletoParaSubFolder
        {
            get
            {
                if (string.IsNullOrEmpty(_nombreCompletoParaSubFolder))
                    _nombreCompletoParaSubFolder = NombreCompletoSinTratamiento
                                .Replace(".", "")
                                .Replace(",", "")
                                .Replace(";", "")
                                .Replace(":", "")
                                .Replace(" ", ".")
                                .Replace(@".\", @"\");

                return _nombreCompletoParaSubFolder;
            }
        }

        #endregion
    }
}
