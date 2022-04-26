using Solvtio.Common;
using Solvtio.Models.Model;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Solvtio.Models
{
    public class Con_Expediente
    {
        #region Constructors

        public Con_Expediente()
        {
            createBase();
        }
        public Con_Expediente(int? idDeudorPrincipal)
        {
            createBase();
            if (idDeudorPrincipal.HasValue)
                IdDeudorPrincipal = idDeudorPrincipal;
        }

        private void createBase()
        {
            FechaDeclaracion = FechaPublicacionBoe = FechaAlta = DateTime.Now;
        }

        #endregion

        #region Properties

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public DateTime FechaDeclaracion { get; set; }
        public DateTime FechaPublicacionBoe { get; set; }
        public int PlazoEnDias { get; set; }

        public int? IdDeudorPrincipal { get; set; }
        public virtual Gnr_Persona Gnr_Persona { get; set; }

        public DateTime? FechaFacturaHito1 { get; set; }
        public DateTime? FechaFacturaHito2 { get; set; }
        public TipoProcedimientoConcursal? TipoProcedimientoConcursal { get; set; }

        public decimal? TotalDeudaReconocida { get; set; }
        public decimal? CalificacionDefinitiva { get; set; }

        #region  Obsolete (Notas)
        public string Estrategia { get; set; }
        public string NotaAntecedente { get; set; }
        public string NotaFaseComun { get; set; }
        public string NotaFaseConvenio { get; set; }
        public string NotaFaseLiquidacion { get; set; }
        public string NotaPropuestaConvenio { get; set; }
        #endregion

        public string OrigenDelCredito { get; set; }
        public string GestorCliente { get; set; }
        public TipoCalificacionConcursal? CalificacionConcursal { get; set; }

        public decimal? MasaActiva { get; set; }
        public decimal? MasaPasiva { get; set; }
        public string DireccionTerritorial { get; set; }
        public string Grupo { get; set; }

        public int? IdTipoRei { get; set; }
        [ForeignKey("IdTipoRei")]
        public virtual CaracteristicaBase TipoRei { get; set; }

        public bool BlanqueoCapitalAutoevaluacionRiesgo { get; set; }
        public bool BlanqueoCapitalIdentificacion { get; set; }
        public bool BlanqueoCapitalDeclaracionResponsable { get; set; }
        public bool BlanqueoCapitalCuestionarioRiesgo { get; set; }

        public decimal? EconomicoValorGarantiaRealPropia { get; set; }
        public decimal? EconomicoValorGarantiaPersonalPropia { get; set; }


        [Obsolete("Usar ModelExpReiExt.EconomicoPorcientoCreditoConcurso")]
        public decimal? EconomicoPorcientoCreditoConcurso { get; set; }

        [Obsolete("Usar ModelExpReiExt.EconomicoPorcientoCreditoOrdinario")]
        public decimal? EconomicoPorcientoCreditoOrdinario { get; set; }



        [Obsolete("Se ha movido al estado Fase Común")]
        public decimal? EconomicoGarantiaInmobiliaria { get; set; }
        [Obsolete("Se ha movido al estado Fase Común")]
        public decimal? EconomicoGarantiaInmobiliariaNo { get; set; }
        [Obsolete("Se ha movido al estado Fase Común")]
        public decimal? EconomicoGarantiaDeudorCliente { get; set; }
        [Obsolete("Se ha movido al estado Fase Común")]
        public decimal? EconomicoGarantiaInversiones { get; set; }
        [Obsolete("Se ha movido al estado Fase Común")]
        public decimal? EconomicoGarantiaOtros { get; set; }
        [Obsolete("Se ha movido al estado Fase Común")]
        public decimal? EconomicoGarantiaEfectivo { get; set; }

        public string Usuario { get; set; }
        public DateTime FechaAlta { get; set; }

        #endregion

        #region Properties ReadOnly

        [Obsolete("Se ha movido al estado Fase Común")]
        public decimal EconomicoGarantiaMasaActiva => 0;
        //    (EconomicoGarantiaInmobiliaria ?? 0) +
        //    (EconomicoGarantiaInmobiliariaNo ?? 0) +
        //    (EconomicoGarantiaDeudorCliente ?? 0) +
        //    (EconomicoGarantiaInversiones ?? 0) +
        //    (EconomicoGarantiaOtros ?? 0) +
        //    (EconomicoGarantiaEfectivo ?? 0);

        public decimal? ResultadoPatrimonial => MasaActiva - MasaPasiva;

        public decimal? SumaDeudaInsinuada => Expediente.ExpedienteContratoSet.IsEmpty() ? 0 : Expediente.ExpedienteContratoSet.Sum(x => x.DeudaInsinuada);
        public decimal? SumaDeudaReconocida => Expediente.ExpedienteContratoSet.IsEmpty() ? 0 : Expediente.ExpedienteContratoSet.Sum(x => x.DeudaReconocida);
        public decimal? DiferenciaDeudaInsinuadaReconocida => (SumaDeudaInsinuada ?? 0) - (SumaDeudaReconocida ?? 0);

        public string AdministracionConcursalMainName => ModelExpReiExt == null ? "" : ModelExpReiExt.AdministracionConcursalMainName;

        //public decimal SumImporteRecuperado => Expediente?.ExpedienteContratoSet == null ? 0 : Expediente.ExpedienteContratoSet.Sum(x => x.SumImporteRecuperado);

        #endregion

        #region Properties NotMapped

        [NotMapped]
        public Con_ExpedienteEstadoComun EstadoFaseComun { get; set; }

        [NotMapped]
        public Con_ExpedienteEstadoLiquidacion EstadoLiquidacion { get; set; }

        [NotMapped]
        public ModelExpReiExt ModelExpReiExt { get; set; }

        #endregion

        #region Methods

        internal void Refresh(Con_Expediente modelBase)
        {
            FechaDeclaracion = modelBase.FechaDeclaracion;
            FechaPublicacionBoe = modelBase.FechaPublicacionBoe;
            PlazoEnDias = modelBase.PlazoEnDias;
            TipoProcedimientoConcursal = modelBase.TipoProcedimientoConcursal;
            TotalDeudaReconocida = modelBase.TotalDeudaReconocida;
            CalificacionDefinitiva = modelBase.CalificacionDefinitiva;

            //NotaAntecedente = modelBase.NotaAntecedente;
            //Estrategia = modelBase.Estrategia;
            //NotaFaseComun = modelBase.NotaFaseComun;
            //NotaFaseConvenio = modelBase.NotaFaseConvenio;
            //NotaFaseLiquidacion = modelBase.NotaFaseLiquidacion;
            //NotaPropuestaConvenio = modelBase.NotaPropuestaConvenio;

            OrigenDelCredito = modelBase.OrigenDelCredito;
            GestorCliente = modelBase.GestorCliente;
            CalificacionConcursal = modelBase.CalificacionConcursal;
            MasaActiva = modelBase.MasaActiva;
            MasaPasiva = modelBase.MasaPasiva;
            DireccionTerritorial = modelBase.DireccionTerritorial;
            Grupo = modelBase.Grupo;
            IdTipoRei = modelBase.IdTipoRei;

            BlanqueoCapitalAutoevaluacionRiesgo = modelBase.BlanqueoCapitalAutoevaluacionRiesgo;
            BlanqueoCapitalIdentificacion = modelBase.BlanqueoCapitalIdentificacion;
            BlanqueoCapitalDeclaracionResponsable = modelBase.BlanqueoCapitalDeclaracionResponsable;
            BlanqueoCapitalCuestionarioRiesgo = modelBase.BlanqueoCapitalCuestionarioRiesgo;

            //EconomicoPorcientoCreditoConcurso = modelBase.EconomicoPorcientoCreditoConcurso;
            //EconomicoPorcientoCreditoOrdinario = modelBase.EconomicoPorcientoCreditoOrdinario;
            EconomicoValorGarantiaRealPropia = modelBase.EconomicoValorGarantiaRealPropia;
            EconomicoValorGarantiaPersonalPropia = modelBase.EconomicoValorGarantiaPersonalPropia;

            //EconomicoGarantiaInmobiliaria = modelBase.EconomicoGarantiaInmobiliaria;
            //EconomicoGarantiaInmobiliariaNo = modelBase.EconomicoGarantiaInmobiliariaNo;
            //EconomicoGarantiaDeudorCliente = modelBase.EconomicoGarantiaDeudorCliente;
            //EconomicoGarantiaInversiones = modelBase.EconomicoGarantiaInversiones;
            //EconomicoGarantiaOtros = modelBase.EconomicoGarantiaOtros;            
            //EconomicoGarantiaEfectivo = modelBase.EconomicoGarantiaEfectivo;

        }

        #endregion

    }

    public class ModelExpReiExt
    {
        public decimal? ContratoTotalDeudaInsinuada { get; set; }
        public decimal? ContratoTotalDeudaReconocida { get; set; }
        public decimal? ContratoTotalImporteRecuperado { get; set; }

        public Con_ExpedienteEstadoComun EstadoFaseComun { get; set; }


        //public Con_ExpedienteAdministrador AdministracionConcursalMain { get; set; }
        public ExpedienteDeudor AdministracionConcursalMain { get; set; }

        //public decimal? ContratoTotalMasaPasivoPrivilegioGeneralCliente { get; set; }
        //public decimal? ContratoTotalMasaPasivoOrdinarioCliente { get; set; }
        //public decimal? ContratoTotalMasaPasivoSubordinadoCliente { get; set; }
        //public decimal? ContratoTotalMasaPasivoContingenteCliente { get; set; }

        //estadoFaseComun.MasaPasivoPrivilegioEspecialCliente = CalculateClasificacionClienteImporte(lstComunicacionCredito, 153);
        //estadoFaseComun.MasaPasivoPrivilegioGeneralCliente = CalculateClasificacionClienteImporte(lstComunicacionCredito, 154);
        //estadoFaseComun. = CalculateClasificacionClienteImporte(lstComunicacionCredito, 155);
        //estadoFaseComun. = CalculateClasificacionClienteImporte(lstComunicacionCredito, 156);

        //public decimal? ContratoTotalInmobiliaria { get; set; }
        //public decimal? ContratoTotalInmobiliariaNo { get; set; }
        //public decimal? ContratoTotalDeudor { get; set; }
        //public decimal? ContratoTotalInversionOtros { get; set; }

        public string AdministracionConcursalMainName => AdministracionConcursalMain?.Gnr_Persona == null ? "" : AdministracionConcursalMain?.Gnr_Persona?.NombreApellidos;

        public decimal? EconomicoPorcCreditoConcurso => EstadoFaseComun == null || EstadoFaseComun.MasaPasivoTotal == 0 ? null : ContratoTotalDeudaReconocida / EstadoFaseComun.MasaPasivoTotal;

        public decimal? EconomicoPorcientoCreditoOrdinario => EstadoFaseComun == null || EstadoFaseComun.MasaPasivoOrdinarioTotal == 0 ? null : EstadoFaseComun.MasaPasivoOrdinarioCliente / EstadoFaseComun.MasaPasivoOrdinarioTotal;

        //public decimal? EconomicoPorcientoCreditoOrdinario => EstadoFaseComun == null || EstadoFaseComun.MasaPasivoOrdinarioTotal == 0 ? null : EstadoFaseComun.MasaPasivoOrdinarioCliente / EstadoFaseComun.MasaPasivoOrdinarioTotal;
    }

}
