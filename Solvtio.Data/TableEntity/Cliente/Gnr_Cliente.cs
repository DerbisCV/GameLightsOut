using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public class Gnr_Cliente : INombre
    {
        #region Constructors

        public Gnr_Cliente()
        {
            Facturas = new List<Factura>();
            Gnr_ClienteOficina = new List<Gnr_ClienteOficina>();
            ProcuradoresClientes = new List<ProcuradoresCliente>();
            PropuestaComercials = new List<PropuestaComercial>();

            ClienteCrm = false;
            ClienteSolvtio = true;
            FechaAlta = DateTime.Now;
        }

        #endregion

        #region Properties

        public int? IdGestorCarteraHip { get; set; }
        public int? IdGestorCarteraAlq { get; set; }
        public int? IdGestorCarteraEjc { get; set; }
        public int? IdGestorCarteraOrd { get; set; }
        public int? IdGestorCarteraCs { get; set; }
        public int? IdGestorCarteraTpa { get; set; }
        public string NombreCorto { get; set; }

        public bool Inactivo { get; set; }

        [DefaultValue(false)]
        public bool ClienteCrm { get; set; }

        [DefaultValue(true)]
        public bool ClienteSolvtio { get; set; }

        public decimal? CostePersonal { get; set; }
        public decimal? CosteOtros { get; set; }

        public decimal CosteTotal => (CostePersonal ?? 0) + (CosteOtros ?? 0);

        public int? IdArea { get; set; }
        [ForeignKey("IdArea")]
        public virtual CaracteristicaBase Area { get; set; }






        [DataType(DataType.Date)]
        public DateTime? ContratoFecha { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ContratoFechaUltimaNovacion { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ContratoFechaVencimiento { get; set; }

        public string ContratoVencimientoInfo { get; set; }
        public string ContratoTitular { get; set; }
        public string ContratoTitularCIF { get; set; }
        public string ContratoServicer { get; set; }
        public string ContratoFondoEntidad { get; set; }
        public string ContratoRelacionComercial { get; set; }
        public string ContratoGestorCuenta { get; set; }
        public string ContratoDirector { get; set; }

        [DefaultValue(false)]
        public bool ContratoResuelto { get; set; }

        [DefaultValue(false)]
        public bool ContratoFormatoDigital { get; set; }

        [DefaultValue(false)]
        public bool ContratoRenovacionTacita { get; set; }

        public string ContratoAreaResponsable { get; set; }



        #endregion

        #region Properties Readonly

        public int Id => IdCliente;

        #endregion

        #region Properties virtual ICollection

        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<Gnr_ClienteOficina> Gnr_ClienteOficina { get; set; }
        public virtual Gnr_TipoIdentidad Gnr_TipoIdentidad { get; set; }
        public virtual ICollection<ProcuradoresCliente> ProcuradoresClientes { get; set; }
        public virtual ICollection<PropuestaComercial> PropuestaComercials { get; set; }

        public virtual ICollection<ClienteFacturaHitoProcesal> ClienteFacturaHitoProcesalSet { get; set; }
        
        //public virtual ICollection<Pagador> Pagadores { get; set; }
        public virtual ICollection<PagadorCliente> PagadorClienteSet { get; set; }

        public virtual ICollection<ClienteTipoExpedienteConfiguracion> ClienteTipoExpedienteConfiguracionSet { get; set; }
        public virtual ICollection<ClienteObjetivo> ClienteObjetivoSet { get; set; }

        #endregion

        #region Properties Before EF CodeFirst

        public int IdCliente { get; set; }
        public string CodigoCliente { get; set; }
        public string Nombre { get; set; }
        public int IdTipoIdentidad { get; set; }
        public string NoDocumento { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string PersonaContacto { get; set; }
        public int? IdAbogadoPadrino { get; set; }
        public DateTime? FechaCaptacion { get; set; }
        public string FacturacionNombre { get; set; }
        public string FacturacionNoDocumento { get; set; }
        public string FacturacionDireccion { get; set; }
        public string FacturacionEmail { get; set; }
        public string FacturacionTelefono { get; set; }
        public string Usuario { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public bool RequerimientoProcurador { get; set; }
        public int? IdSupervisorNoEjecutivo { get; set; }
        public virtual AlertaSupervisor AlertaSupervisor { get; set; }
        public virtual Gnr_Abogado Gnr_Abogado { get; set; }

        #endregion

        #region Methods

        internal void RefreshBy(Gnr_Cliente model)
        {
            Nombre = model.Nombre;
            NombreCorto = model.NombreCorto;
            IdGestorCarteraHip = model.IdGestorCarteraHip;
            IdGestorCarteraAlq = model.IdGestorCarteraAlq;
            IdGestorCarteraEjc = model.IdGestorCarteraEjc;
            IdGestorCarteraOrd = model.IdGestorCarteraOrd;
            IdGestorCarteraCs = model.IdGestorCarteraCs;
            IdGestorCarteraTpa = model.IdGestorCarteraTpa;
            Inactivo = model.Inactivo;
            ClienteCrm = model.ClienteCrm;
            ClienteSolvtio = model.ClienteSolvtio;
            CostePersonal = model.CostePersonal;
            CosteOtros = model.CosteOtros;
            IdArea = model.IdArea;
            Direccion = model.Direccion;

            ContratoFecha = model.ContratoFecha;
            ContratoFechaUltimaNovacion = model.ContratoFechaUltimaNovacion;
            ContratoFechaVencimiento = model.ContratoFechaVencimiento;
            ContratoResuelto = model.ContratoResuelto;
            ContratoFormatoDigital = model.ContratoFormatoDigital;
            ContratoVencimientoInfo = model.ContratoVencimientoInfo;
            ContratoTitular = model.ContratoTitular;
            ContratoTitularCIF = model.ContratoTitularCIF;
            ContratoServicer = model.ContratoServicer;
            ContratoFondoEntidad = model.ContratoFondoEntidad;
            ContratoRelacionComercial = model.ContratoRelacionComercial;
            ContratoGestorCuenta = model.ContratoGestorCuenta;
            ContratoDirector = model.ContratoDirector;

            ContratoRenovacionTacita = model.ContratoRenovacionTacita;
            ContratoAreaResponsable = model.ContratoAreaResponsable;
        }

        #endregion
    }
}
