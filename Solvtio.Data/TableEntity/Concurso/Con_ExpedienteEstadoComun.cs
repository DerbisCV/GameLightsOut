using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public partial class Con_ExpedienteEstadoComun : ReiMasaActiva, IConConclusion
    {
        #region Properties

        public int ExpedienteEstadoId { get; set; }
        public decimal? ActivoProvisional { get; set; }
        public decimal? PasivoProvisional { get; set; }
        public decimal? ActivoDefinitivo { get; set; }
        public decimal? PasivoDefinitivo { get; set; }
        public DateTime? FechaInformeProvisional { get; set; }
        public DateTime? FechaInformeDefinitivo { get; set; }
        public DateTime? FechaComunicarCredito { get; set; }
        public DateTime? FechaFinPlazoPresentacionCredito { get; set; }

        public decimal? MasaPasivoPrivilegioEspecialTotal { get; set; }
        public decimal? MasaPasivoPrivilegioEspecialClientePorciento { get; set; }

        //< td class="v-align text-right">@Html.DcvCurrency(Model., "MasaPasivoPrivilegioEspecialTotal")</td>
        //          <td class="v-align text-right">@Html.DcvCurrency(Model., "MasaPasivoPrivilegioEspecialCliente", "€", ".00", true)</td>
        //          <td class="v-align text-right">@Html.DcvPercent(Model.MasaPasivoPrivilegioEspecialClientePorciento, "", "%", ".0", true)</td>


        public decimal? MasaPasivoPrivilegioGeneralTotal { get; set; }
        public decimal? MasaPasivoPrivilegioGeneralClientePorciento { get; set; }
        public decimal? MasaPasivoOrdinarioTotal { get; set; }
        public decimal? MasaPasivoOrdinarioClientePorciento { get; set; }
        public decimal? MasaPasivoSubordinadoTotal { get; set; }
        public decimal? MasaPasivoSubordinadoClientePorciento { get; set; }
        public decimal? MasaPasivoContraMasaTotal { get; set; }
        public decimal? MasaPasivoContraMasaClientePorciento { get; set; }
        public decimal? ContingentePrivilegioEspecialTotal { get; set; }
        public decimal? ContingentePrivilegioEspecialClientePorciento { get; set; }
        public decimal? ContingentePrivilegioGeneralTotal { get; set; }
        public decimal? ContingentePrivilegioGeneralClientePorciento { get; set; }
        public decimal? ContingenteOrdinarioTotal { get; set; }
        public decimal? ContingenteOrdinarioClientePorciento { get; set; }
        public decimal? ContingenteSubordinadoTotal { get; set; }
        public decimal? ContingenteSubordinadoClientePorciento { get; set; }

        public DateTime? ConclusionFechaSolicitud { get; set; }
        public DateTime? ConclusionFechaOposicion { get; set; }
        public DateTime? ConclusionFechaRendicionCuentas { get; set; }
        public DateTime? ConclusionFechaOposicionRendicionCuentas { get; set; }
        public DateTime? ConclusionFechaAuto { get; set; }


        public int? DocumentoCreditosClienteId { get; set; }
        public int? DocumentoComunicacionCreditosId { get; set; }
        public int? DocumentoInformeAdministradorId { get; set; }
        public int? DocumentoAutoJuezId { get; set; }

        public virtual ExpedienteDocumento ExpedienteDocumento { get; set; }
        public virtual ExpedienteDocumento ExpedienteDocumento1 { get; set; }
        public virtual ExpedienteDocumento ExpedienteDocumento2 { get; set; }
        public virtual ExpedienteDocumento ExpedienteDocumento3 { get; set; }

        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        #endregion

        #region Properties NotMapped

        [NotMapped]
        public decimal? MasaPasivoPrivilegioEspecialCliente { get; set; }

        [NotMapped]
        public decimal? MasaPasivoPrivilegioGeneralCliente { get; set; }
        [NotMapped]
        public decimal? MasaPasivoOrdinarioCliente { get; set; }
        [NotMapped]
        public decimal? MasaPasivoSubordinadoCliente { get; set; }
        [NotMapped]
        public decimal? MasaPasivoContraMasaCliente { get; set; }
        [NotMapped]
        public decimal? ContingentePrivilegioEspecialCliente { get; set; }
        [NotMapped]
        public decimal? ContingentePrivilegioGeneralCliente { get; set; }
        [NotMapped]
        public decimal? ContingenteOrdinarioCliente { get; set; }
        [NotMapped]
        public decimal? ContingenteSubordinadoCliente { get; set; }

        #endregion

        #region Properties Readonly

        public decimal MasaPasivoTotal => (MasaPasivoPrivilegioEspecialTotal ?? 0) + (MasaPasivoPrivilegioGeneralTotal ?? 0) + (MasaPasivoOrdinarioTotal ?? 0) + (MasaPasivoSubordinadoTotal ?? 0);
        public decimal MasaPasivoCliente => (MasaPasivoPrivilegioEspecialCliente ?? 0) + (MasaPasivoPrivilegioGeneralCliente ?? 0) + (MasaPasivoOrdinarioCliente ?? 0) + (MasaPasivoSubordinadoCliente ?? 0);

        public decimal ContingenteTotal => (ContingentePrivilegioEspecialTotal ?? 0) + (ContingentePrivilegioGeneralTotal ?? 0) + (ContingenteOrdinarioTotal ?? 0) + (ContingenteSubordinadoTotal ?? 0);
        public decimal ContingenteCliente => (ContingentePrivilegioEspecialCliente ?? 0) + (ContingentePrivilegioGeneralCliente ?? 0) + (ContingenteOrdinarioCliente ?? 0) + (ContingenteSubordinadoCliente ?? 0);

        #endregion

        #region Methods

        public void RefreshBy(Con_ExpedienteEstadoComun model)
        {
            ActivoProvisional = model.ActivoProvisional;
            PasivoProvisional = model.PasivoProvisional;
            ActivoDefinitivo = model.ActivoDefinitivo;
            PasivoDefinitivo = model.PasivoDefinitivo;

            FechaInformeProvisional = model.FechaInformeProvisional;
            FechaInformeDefinitivo = model.FechaInformeDefinitivo;
            FechaComunicarCredito = model.FechaComunicarCredito;
            FechaFinPlazoPresentacionCredito = model.FechaFinPlazoPresentacionCredito;

            MasaPasivoPrivilegioEspecialTotal = model.MasaPasivoPrivilegioEspecialTotal;
            MasaPasivoPrivilegioEspecialClientePorciento = CalculatePercent(model.MasaPasivoPrivilegioEspecialCliente, model.MasaPasivoPrivilegioEspecialTotal);
            MasaPasivoPrivilegioGeneralTotal = model.MasaPasivoPrivilegioGeneralTotal;
            MasaPasivoPrivilegioGeneralClientePorciento = CalculatePercent(model.MasaPasivoPrivilegioGeneralCliente, model.MasaPasivoPrivilegioGeneralTotal);
            MasaPasivoOrdinarioTotal = model.MasaPasivoOrdinarioTotal;
            MasaPasivoOrdinarioClientePorciento = CalculatePercent(model.MasaPasivoOrdinarioCliente, model.MasaPasivoOrdinarioTotal);
            MasaPasivoSubordinadoTotal = model.MasaPasivoSubordinadoTotal;
            MasaPasivoSubordinadoClientePorciento = CalculatePercent(model.MasaPasivoSubordinadoCliente, model.MasaPasivoSubordinadoTotal);

            MasaPasivoContraMasaTotal = model.MasaPasivoContraMasaTotal;
            MasaPasivoContraMasaClientePorciento = CalculatePercent(model.MasaPasivoContraMasaCliente, model.MasaPasivoContraMasaTotal);

            ContingentePrivilegioEspecialTotal = model.ContingentePrivilegioEspecialTotal;
            ContingentePrivilegioEspecialClientePorciento = CalculatePercent(model.ContingentePrivilegioEspecialCliente, model.ContingentePrivilegioEspecialTotal);
            ContingentePrivilegioGeneralTotal = model.ContingentePrivilegioGeneralTotal;
            ContingentePrivilegioGeneralClientePorciento = CalculatePercent(model.ContingentePrivilegioGeneralCliente, model.ContingentePrivilegioGeneralTotal);
            ContingenteOrdinarioTotal = model.ContingenteOrdinarioTotal;
            ContingenteOrdinarioClientePorciento = CalculatePercent(model.ContingenteOrdinarioCliente, model.ContingenteOrdinarioTotal);
            ContingenteSubordinadoTotal = model.ContingenteSubordinadoTotal;
            ContingenteSubordinadoClientePorciento = CalculatePercent(model.ContingenteSubordinadoCliente, model.ContingenteSubordinadoTotal);

            EconomicoGarantiaInmobiliaria = model.EconomicoGarantiaInmobiliaria;
            EconomicoGarantiaInmobiliariaNo = model.EconomicoGarantiaInmobiliariaNo;
            EconomicoGarantiaDeudorCliente = model.EconomicoGarantiaDeudorCliente;
            EconomicoGarantiaInversiones = model.EconomicoGarantiaInversiones;
            EconomicoGarantiaOtros = model.EconomicoGarantiaOtros;
            EconomicoGarantiaEfectivo = model.EconomicoGarantiaEfectivo;

            RefreshConclusion(model);
        }

        public void RefreshConclusion(IConConclusion modelBase)
        {
            ConclusionFechaSolicitud = modelBase.ConclusionFechaSolicitud;
            ConclusionFechaOposicion = modelBase.ConclusionFechaOposicion;
            ConclusionFechaRendicionCuentas = modelBase.ConclusionFechaRendicionCuentas;
            ConclusionFechaOposicionRendicionCuentas = modelBase.ConclusionFechaOposicionRendicionCuentas;
            ConclusionFechaAuto = modelBase.ConclusionFechaAuto;
        }

        private decimal? CalculatePercent(decimal? valueParcial, decimal? valueTotal100)
        {
            if (!valueParcial.HasValue || !valueTotal100.HasValue || valueTotal100 == 0) return null;
            return 100 * valueParcial.Value / valueTotal100.Value;
        }

        #endregion


    }

    public class ReiMasaActiva
    {
        public decimal? EconomicoGarantiaInmobiliaria { get; set; }
        public decimal? EconomicoGarantiaInmobiliariaNo { get; set; }
        public decimal? EconomicoGarantiaDeudorCliente { get; set; }
        public decimal? EconomicoGarantiaInversiones { get; set; }
        public decimal? EconomicoGarantiaOtros { get; set; }
        public decimal? EconomicoGarantiaEfectivo { get; set; }

        public decimal EconomicoGarantiaMasaActiva =>
            (EconomicoGarantiaInmobiliaria ?? 0) +
            (EconomicoGarantiaInmobiliariaNo ?? 0) +
            (EconomicoGarantiaDeudorCliente ?? 0) +
            (EconomicoGarantiaInversiones ?? 0) +
            (EconomicoGarantiaOtros ?? 0) +
            (EconomicoGarantiaEfectivo ?? 0);
    }

}
