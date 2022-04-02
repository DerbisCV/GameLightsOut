using Solvtio.Models.Common;
using Solvtio.Models.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public partial class Gnr_ClienteOficina : Auditable, INombre, IDireccion
    {
        #region Constructors

        public Gnr_ClienteOficina()
        {
            CreateBase();
        }
        public Gnr_ClienteOficina(int? idCliente)
        {
            CreateBase();
            if (idCliente.HasValue)
                IdCliente = idCliente.Value;
        }
        public void CreateBase()
        {
            CIF = "PENDIENTE";
            Expedientes = new List<Expediente>();
            Gnr_Valija = new List<Gnr_Valija>();
        }

        #endregion

        #region Properties

        public override bool IsNew => IdClienteOficina <= 0;

        public int IdClienteOficina { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }
        public string Email { get; set; }


        public int IdCliente { get; set; }
        public virtual Gnr_Cliente Gnr_Cliente { get; set; }

        public int? IdTipoExpediente { get; set; }
        public virtual Gnr_TipoExpediente Gnr_TipoExpediente { get; set; }

        public TipoInstirucionReligiosa? TipoInstirucionReligiosa { get; set; }
        public int IdPais { get; set; }

        public string NoCuenta { get; set; }
        public string Color { get; set; }
        public string Notas { get; set; }

        public bool BlanqueoCapitalAutoevaluacionRiesgo { get; set; }
        public bool BlanqueoCapitalIdentificacionPersonaJuridica { get; set; }
        public bool BlanqueoCapitalRiesgoCliente { get; set; }
        public bool BlanqueoCapitalDeclaracionResponsabilidad { get; set; }

        #endregion

        #region Properties CRM

        public string Web { get; set; }
        public string Interlocutor { get; set; }
        public string CIF { get; set; }

        public int? IdClienteOficinaReferencia { get; set; }

        public string Grupo { get; set; }

        public int? IdTipo { get; set; }
        [ForeignKey("IdTipo")]
        public virtual CaracteristicaBase Tipo { get; set; }


        public string Direccion { get; set; }
        public string CodigoPostal { get; set; }
        public int? IdProvincia { get; set; }
        [ForeignKey("IdProvincia")]
        public virtual Provincia Provincia { get; set; }
        public int? IdMunicipio { get; set; }
        [ForeignKey("IdMunicipio")]
        public virtual Municipio Municipio { get; set; }


        public TipoEstadoCliente? Estado { get; set; }

        public virtual ICollection<Tarea> TareaSet { get; set; }
        public virtual ICollection<ClienteServicioBufete> ClienteServicioBufeteSet { get; set; }

        #endregion

        #region Properties Demandante

        public string Demandante { get; set; }
        public string DemandanteCif { get; set; }
        public string DemandanteDireccion { get; set; }

        #endregion

        #region Properties virtual ICollection

        public virtual ICollection<Expediente> Expedientes { get; set; }
        public virtual ICollection<Gnr_Valija> Gnr_Valija { get; set; }
        public virtual ICollection<SlaOficina> SlaOficinaSet { get; set; }
        public virtual ICollection<Contacto> ContactoSet { get; set; }

        public virtual ICollection<Nota> NotaSet { get; set; }

        public virtual ICollection<Contrato> ContratoSet { get; set; }

        #endregion

        #region Methods

        internal void RefreshNomencladorBase(Gnr_ClienteOficina model)
        {
            if (model.CIF == "PENDIENTE") CIF = $"PENDIENTE{model.IdClienteOficina}";

            Nombre = model.Nombre;
            NombreCorto = model.NombreCorto;
            NoCuenta = model.NoCuenta;
            Email = model.Email;
            IdCliente = model.IdCliente;

            Demandante = model.Demandante;
            DemandanteCif = model.DemandanteCif;
            DemandanteDireccion = model.DemandanteDireccion;
        }

        #endregion
    }
}
