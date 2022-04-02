using Solvtio.Models.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;

namespace Solvtio.Models
{
    public class ExpedienteEstadoSubastaBase : IExpedienteEstadoSubasta
    {
        #region Properties IExpedienteEstadoSubasta

        public bool? SubastaElectronicaPuja { get; set; }
        public decimal? SubastaElectronicaImportePuja { get; set; }
        public DateTime? SubastaElectronicaFechaFinMejoraPuja { get; set; }

        #endregion

        #region Properties Subasta Electronica

        public DateTime? FechaDecretoSubasta { get; set; }

        public int? IdMotivoSuspensionDecretoSubasta { get; set; }
        [ForeignKey("IdMotivoSuspensionDecretoSubasta")]
        public virtual Gnr_TipoEstadoMotivo MotivoSuspensionDecretoSubasta { get; set; }

        public int? IdMotivoSuspension { get; set; }
        [ForeignKey("IdMotivoSuspension")]
        public virtual Gnr_TipoEstadoMotivo MotivoSuspensionSubasta { get; set; }

        public bool SuspensionDecretoSubasta { get; set; }
        public DateTime? EdictoFecha { get; set; }
        public bool EdictoConDefecto { get; set; }
        public bool EdictoTasaDisponible { get; set; }

        public DateTime? FechaCierrePuja { get; set; }
        public DateTime? FechaCierrePuja2 { get; set; }
        public bool SuspendidaCierrePuja1 { get; set; }
        public bool SuspendidaCierrePuja2 { get; set; }

        public bool FestivoFinDeSemana { get; set; }
        public DateTime? FechaFinMejoraPuja { get; set; }

        public bool? Puja { get; set; }
        public decimal ImportePuja { get; set; }

        #endregion

        #region Properties Post-Subasta

        public DateTime? FechaSolicitudAdjudicacion { get; set; }
        public decimal ImporteSolicitudAdjudicacion { get; set; }
        public DateTime? FechaSolicitudAdjudicacionLimite { get; set; }
        public bool IVA { get; set; }
        public bool Postores { get; set; }
        public bool AdjudicacionTercero { get; set; } //Adjudicación a tercero (Finalizar expediente para facturación)
        public decimal? TasacionCostes { get; set; }
        public decimal? LiquidacionIntereses { get; set; }
        public bool ImpugnacionIntereses { get; set; }
        public bool ImpugnacionCostas { get; set; }
        public decimal? DecretoIntereses { get; set; }
        public decimal? DecretoCostas { get; set; }
        public decimal? DecisionPociento { get; set; }
        public decimal? ImporteAdjudicacion { get; set; }
        public bool Consignar { get; set; }
        [Display(Name = "Cesión")]
        public SubastaCesionType? Cesion { get; set; }
        public DateTime? FechaEnvioInstruccionesProcurador { get; set; }
        public DateTime? FechaActaSubasta { get; set; }


        #endregion

        #region Properties Computed

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? FechaCierrePuja2o1
        {
            get { return FechaCierrePuja2.HasValue ? FechaCierrePuja2 : FechaCierrePuja; }
            private set { } //Just need this here to trick EF
        }

        #endregion

        #region Methods

        internal void RefreshBy(ExpedienteEstadoSubastaBase model)
        {
            FechaEnvioInstruccionesProcurador = model.FechaEnvioInstruccionesProcurador;
            FechaActaSubasta = model.FechaActaSubasta;
            IVA = model.IVA;
            Postores = model.Postores;
            LiquidacionIntereses = model.LiquidacionIntereses;
            TasacionCostes = model.TasacionCostes;
            DecisionPociento = model.DecisionPociento;
            ImporteAdjudicacion = model.ImporteAdjudicacion;
            Consignar = model.Consignar;
            FechaDecretoSubasta = model.FechaDecretoSubasta;

            FechaCierrePuja = model.FechaCierrePuja;
            FechaCierrePuja2 = model.FechaCierrePuja2;
            if (FechaCierrePuja.HasValue)
                FestivoFinDeSemana = model.FestivoFinDeSemana || FechaCierrePuja.IsWeekEnd();
            else
                FestivoFinDeSemana = false;
            if (FechaCierrePuja2.HasValue)
                FestivoFinDeSemana = model.FestivoFinDeSemana || FechaCierrePuja2.IsWeekEnd();
            else
                FestivoFinDeSemana = false;

            SuspendidaCierrePuja1 = model.SuspendidaCierrePuja1;
            SuspendidaCierrePuja2 = model.SuspendidaCierrePuja2;
            Puja = model.Puja;
            IdMotivoSuspension = model.IdMotivoSuspension;

            FechaSolicitudAdjudicacion = model.FechaSolicitudAdjudicacion;
            ImporteSolicitudAdjudicacion = model.ImporteSolicitudAdjudicacion;
            if (model.FechaSolicitudAdjudicacion.HasValue)
                FechaSolicitudAdjudicacionLimite = null;
            else
            {
                FechaSolicitudAdjudicacionLimite = model.FechaSolicitudAdjudicacionLimite;
                if (model.FechaCierrePuja2o1.HasValue)
                    FechaSolicitudAdjudicacionLimite = model.FechaCierrePuja2o1.Value.AddDaysHabiles(19);
            }

            ImportePuja = model.ImportePuja;
            if (ImportePuja > 0 && !model.FechaFinMejoraPuja.HasValue && FechaCierrePuja.HasValue)
                FechaFinMejoraPuja = FechaCierrePuja.AddDaysHabiles(15);
            else
                FechaFinMejoraPuja = model.FechaFinMejoraPuja;

            IdMotivoSuspensionDecretoSubasta = model.IdMotivoSuspensionDecretoSubasta;
            SuspensionDecretoSubasta = model.SuspensionDecretoSubasta;
            ImpugnacionIntereses = model.ImpugnacionIntereses;
            ImpugnacionCostas = model.ImpugnacionCostas;
            DecretoIntereses = model.DecretoIntereses;
            DecretoCostas = model.DecretoCostas;
            Cesion = model.Cesion;

            EdictoFecha = model.EdictoFecha;
            EdictoConDefecto = model.EdictoConDefecto;
            EdictoTasaDisponible = model.EdictoTasaDisponible;
            AdjudicacionTercero = model.AdjudicacionTercero;

            SubastaElectronicaPuja = model.SubastaElectronicaPuja;
            SubastaElectronicaImportePuja = model.SubastaElectronicaImportePuja;
            SubastaElectronicaFechaFinMejoraPuja = model.SubastaElectronicaFechaFinMejoraPuja;
        }

        #endregion


    }
}
