using Solvtio.Common;
using Solvtio.Models.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("Asset")]
    public class Asset
    {
        #region Constructors

        public Asset()
        {
            CreateBase();
        }
        public Asset(int idExpediente)
        {
            CreateBase();
            IdExpediente = idExpediente;
        }

        private void CreateBase()
        {
            //EsHabitual = true;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAsset { get; set; }

        [Index]
        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public string Notas { get; set; }

        #region DataTape Main

        public string Referencia { get; set; }

        public int IdTipoInmueble { get; set; }
        [ForeignKey("IdTipoInmueble")]
        public virtual Hip_TipoInmueble TipoAsset { get; set; }

        public string TipoActivo { get; set; }
        public string SubTipo { get; set; }
        public string Promocion { get; set; }
        public string SubPortfolio { get; set; }


        public decimal? Tasacion { get; set; }
        public DateTime? TasacionFecha { get; set; }

        public int? IdAbogado { get; set; }
        [ForeignKey("IdAbogado")]
        public virtual Gnr_Abogado Abogado { get; set; }

        #endregion

        #region Direccion

        public string Direccion { get; set; }
        public string CcAa { get; set; }
        public string ProvinciaName { get; set; }
        public string Poblacion { get; set; }
        public string CodigoPostal { get; set; }

        public int? IdProvincia { get; set; }
        [ForeignKey("IdProvincia")]
        public virtual Provincia Provincia { get; set; }

        public int? IdMunicipio { get; set; }
        [ForeignKey("IdMunicipio")]
        public virtual Municipio Municipio { get; set; }

        #endregion

        #region Registro Catastral

        public string RefCatastral { get; set; }
        public string Registro { get; set; }
        public string RegistroNo { get; set; }
        public string FincaNo { get; set; }
        public decimal? SuperficieConstruida { get; set; }
        public decimal? SuperficieParcela { get; set; }

        #endregion

        #region Otros

        public bool PosesionLegal { get; set; }
        public bool Alquilado { get; set; }
        public bool Okupas { get; set; }

        public string UrlLinkExterno { get; set; }
        public string LpoStatus { get; set; }

        #endregion

        #region Flags

        public TipoFlagInmueble? LegalTitle { get; set; }
        public TipoFlagInmueble? Registrable { get; set; }
        public TipoFlagInmueble? CoOwnership { get; set; }
        public TipoFlagInmueble? UnderConstruction { get; set; }
        public TipoFlagInmueble? ChargesBurdens { get; set; }
        public TipoFlagInmueble? Vpo { get; set; }
        public TipoFlagInmueble? Lessees { get; set; }
        public TipoFlagInmueble? Squatters { get; set; }
        public TipoFlagInmueble? SuspendeVulnerability { get; set; }
        public TipoFlagInmueble? PossibleVulnerability { get; set; }
        public TipoFlagInmueble? SuspendedTjueEcj { get; set; }
        public TipoFlagInmueble? FirstRefusalReversion { get; set; }

        public string FlagSummary { get; set; }
        public string FlagExclusion { get; set; }
        public string FlagSecondClosing { get; set; }
        public string FlagSpA { get; set; }

        #endregion

        #region SPECIFIC DATA PROPERTY (from Registry Excerpts)

        public string SdpLien { get; set; }
        public DateTime? SdpDateRegistryExcerpts { get; set; }
        public TipoSiNo? SdpOwnedLegal { get; set; }
        public string SdpOwnerName { get; set; }
        public string SdpOwnerId { get; set; }

        public int? IdSdpTypeUse { get; set; }
        [ForeignKey("IdSdpTypeUse")]
        public virtual CaracteristicaBase SdpTypeUse { get; set; }

        public int? IdSdpAssetStatus { get; set; }
        [ForeignKey("IdSdpAssetStatus")]
        public virtual CaracteristicaBase SdpAssetStatus { get; set; }

        public string SdpCommentsPropertyCondition { get; set; }

        public TipoSiNo? SdpAdministrativeConcession { get; set; }
        public DateTime? SdpDateFinisingAdministrativeConcession { get; set; }
        public string SdpFinisingAdministrativeConcession { get; set; }
        public string SdpCommentsAdministrativeConcession { get; set; }


        public TipoSiNo? SdpVpo { get; set; }
        public DateTime? SdpDateVpoConstitution { get; set; }

        public int? IdSdpVpoInForce { get; set; }
        [ForeignKey("IdSdpVpoInForce")]
        public virtual CaracteristicaBase SdpVpoInForce { get; set; }

        public string SdpVpoComments { get; set; }

        public TipoSiNo? SdpCoOwnership { get; set; }
        public string SdpCoOwnershipName { get; set; } //Obsoleto
        public string SdpCoOwnershipComments { get; set; }
        public decimal? SdpCoOwnershipPercent { get; set; }

        public string SdpPropertyCondition { get; set; }
        public string SdpPropertySubCondition { get; set; }

        public TipoSiNo? SdpOutstandingTax { get; set; }
        public string SdpOutstandingTaxComments { get; set; }
        public TipoSiNo? SdpUrbanisticIssues { get; set; }
        public string SdpUrbanisticIssuesComments { get; set; }






        public string SdpTypeProperty { get; set; }



        #endregion

        #region DOCUMENTATION				

        public TipoSiNo? DocRegistryRequested { get; set; }
        public string DocRegistryReceived { get; set; }
        public string DocRegistryRequestedId { get; set; }
        public string DocRegistryComments { get; set; }
        public string DocJudicialReceived { get; set; }

        #endregion

        #region CHARGES AND BURDENS (from Registry Excerpts)																						

        public decimal? CbCharge1 { get; set; }
        public int? IdCbCharge1Type { get; set; }
        [ForeignKey("IdCbCharge1Type")]
        public virtual CaracteristicaBase CbCharge1Type { get; set; }
        public decimal? CbCharge2 { get; set; }
        public int? IdCbCharge2Type { get; set; }
        [ForeignKey("IdCbCharge2Type")]
        public virtual CaracteristicaBase CbCharge2Type { get; set; }
        public decimal? CbCharge3 { get; set; }
        public int? IdCbCharge3Type { get; set; }
        [ForeignKey("IdCbCharge3Type")]
        public virtual CaracteristicaBase CbCharge3Type { get; set; }
        public decimal? CbCharge4 { get; set; }
        public int? IdCbCharge4Type { get; set; }
        [ForeignKey("IdCbCharge4Type")]
        public virtual CaracteristicaBase CbCharge4Type { get; set; }
        public decimal? CbCharge5 { get; set; }
        public int? IdCbCharge5Type { get; set; }
        [ForeignKey("IdCbCharge5Type")]
        public virtual CaracteristicaBase CbCharge5Type { get; set; }
        public string CbChargeComments { get; set; }

        public decimal? CbBurden1 { get; set; }
        public int? IdCbBurden1Type { get; set; }
        [ForeignKey("IdCbBurden1Type")]
        public virtual CaracteristicaBase CbBurden1Type { get; set; }
        public decimal? CbBurden2 { get; set; }
        public int? IdCbBurden2Type { get; set; }
        [ForeignKey("IdCbBurden2Type")]
        public virtual CaracteristicaBase CbBurden2Type { get; set; }
        public decimal? CbBurden3 { get; set; }
        public int? IdCbBurden3Type { get; set; }
        [ForeignKey("IdCbBurden3Type")]
        public virtual CaracteristicaBase CbBurden3Type { get; set; }
        public decimal? CbBurden4 { get; set; }
        public int? IdCbBurden4Type { get; set; }
        [ForeignKey("IdCbBurden4Type")]
        public virtual CaracteristicaBase CbBurden4Type { get; set; }
        public decimal? CbBurden5 { get; set; }
        public int? IdCbBurden5Type { get; set; }
        [ForeignKey("IdCbBurden5Type")]
        public virtual CaracteristicaBase CbBurden5Type { get; set; }
        public string CbBurdenComments { get; set; }

        #endregion

        #region JUDICIAL PROCEEDING								

        public string JudicialTypeProceeding { get; set; }
        public string JudicialCourt { get; set; }
        public string JudicialProceedingNo { get; set; }
        public int? IdJudicialLegalStatus { get; set; }
        [ForeignKey("IdJudicialLegalStatus")]
        public virtual CaracteristicaBase JudicialLegalStatus { get; set; }
        public TipoSiNo? JudicialAwardingDecree { get; set; }
        public TipoSiNo? JudicialNegativeRegistration { get; set; }
        public string JudicialComments { get; set; }
        public TipoSiNo? JudicialPendingResolutionEcj { get; set; }
        public string JudicialClausesEcj { get; set; }

        #endregion

        #region POSSESION PROCEEDING

        public string PossProceedingType { get; set; }
        public string PossProceedingCourt { get; set; }
        public string PossProceedingNo { get; set; }
        public string PossProceedingComments { get; set; }

        #endregion

        #region POSSESION

        public int? IdPossOcupationalSituation { get; set; }
        [ForeignKey("IdPossOcupationalSituation")]
        public virtual CaracteristicaBase PossOcupationalSituation { get; set; }

        public string PossOcupationalSituationComments { get; set; }

        public int? IdPossOcupationalSituationComm { get; set; }
        [ForeignKey("IdPossOcupationalSituationComm")]
        public virtual CaracteristicaBase PossOcupationalSituationComm { get; set; }

        public TipoSiNo? PossVulnerableMortgageDebtors { get; set; }
        public int? IdPossVulnerableMortgageDebtorsComm { get; set; }
        [ForeignKey("IdPossVulnerableMortgageDebtorsComm")]
        public virtual CaracteristicaBase PossVulnerableMortgageDebtorsComm { get; set; }

        public TipoSiNo? PossRightFirstFefusal { get; set; }
        public string PossComments { get; set; }

        public TipoSiNo? PossLaunchTakeOver { get; set; }
        public DateTime? PossLaunchTakeOverDate { get; set; }
        public string PossLaunchTakeOverComment { get; set; }

        #endregion

        #endregion

        #region Properties One to Many

        //public virtual ICollection<Hip_TitularInmueble> Hip_TitularInmueble { get; set; }
        //public virtual ICollection<HipInmuebleNota> HipInmuebleNotaSet { get; set; }

        //public virtual ICollection<CarteraInmueble> CarteraInmuebleSet { get; set; }

        //[NotMapped]
        //public ICollection<InmuebleContrato> InmuebleContratoSet { get; set; }

        #endregion

        #region Properties ReadOnly

        public string DireccionCompleta => $"{Direccion} {CodigoPostal} {Municipio?.Nombre} {Provincia?.Nombre}";

        public decimal CbChargeTotal => (CbCharge1 ?? 0) + (CbCharge2 ?? 0) + (CbCharge3 ?? 0) + (CbCharge4 ?? 0) + (CbCharge5 ?? 0);
        public decimal CbBurdenTotal => (CbBurden1 ?? 0) + (CbBurden2 ?? 0) + (CbBurden3 ?? 0) + (CbBurden4 ?? 0) + (CbBurden5 ?? 0);

        #endregion

        #region Methods

        //public override string ToString()
        //{
        //    return 
        //        !string.IsNullOrWhiteSpace(NumeroFinca) ? NumeroFinca : 
        //        !string.IsNullOrWhiteSpace(Descripcion) ? Descripcion : 
        //        Direccion;
        //}

        internal void RefreshBy(Asset model)
        {
            #region Generic Data

            Referencia = model.Referencia;
            Promocion = model.Promocion;
            SubPortfolio = model.SubPortfolio;
            TipoActivo = model.TipoActivo;
            SubTipo = model.SubTipo;

            Tasacion = model.Tasacion;
            TasacionFecha = model.TasacionFecha;
            IdAbogado = model.IdAbogado;
            SuperficieConstruida = model.SuperficieConstruida;
            SuperficieParcela = model.SuperficieParcela;

            LpoStatus = model.LpoStatus;
            Okupas = model.Okupas;
            PosesionLegal = model.PosesionLegal;
            Alquilado = model.Alquilado;

            CcAa = model.CcAa;
            ProvinciaName = model.ProvinciaName;
            Direccion = model.Direccion;
            CodigoPostal = model.CodigoPostal;
            Poblacion = model.Poblacion;

            RefCatastral = model.RefCatastral;
            Registro = model.Registro;
            RegistroNo = model.RegistroNo;
            FincaNo = model.FincaNo;
            UrlLinkExterno = model.UrlLinkExterno;
            Notas = model.Notas;

            #endregion

            #region DOCUMENTATION				

            DocRegistryRequested = model.DocRegistryRequested;
            DocRegistryReceived = model.DocRegistryReceived;
            DocRegistryRequestedId = model.DocRegistryRequestedId;
            DocRegistryComments = model.DocRegistryComments;
            DocJudicialReceived = model.DocJudicialReceived;

            #endregion

            #region SPECIFIC DATA PROPERTY (from Registry Excerpts)

            SdpLien = model.SdpLien;
            SdpDateRegistryExcerpts = model.SdpDateRegistryExcerpts;
            SdpOwnedLegal = model.SdpOwnedLegal;
            SdpOwnerName = model.SdpOwnerName;
            SdpOwnerId = model.SdpOwnerId;
            SdpTypeProperty = model.SdpTypeProperty;
            IdSdpTypeUse = model.IdSdpTypeUse;
            IdSdpAssetStatus = model.IdSdpAssetStatus;
            SdpPropertyCondition = model.SdpPropertyCondition;
            SdpPropertySubCondition = model.SdpPropertySubCondition;
            SdpCommentsPropertyCondition = model.SdpCommentsPropertyCondition;

            SdpAdministrativeConcession = model.SdpAdministrativeConcession;
            SdpDateFinisingAdministrativeConcession = model.SdpDateFinisingAdministrativeConcession;
            SdpCommentsAdministrativeConcession = model.SdpCommentsAdministrativeConcession;
            SdpFinisingAdministrativeConcession = model.SdpFinisingAdministrativeConcession;

            SdpVpo = model.SdpVpo;
            SdpDateVpoConstitution = model.SdpDateVpoConstitution;
            IdSdpVpoInForce = model.IdSdpVpoInForce;
            SdpVpoComments = model.SdpVpoComments;
            SdpCoOwnership = model.SdpCoOwnership;
            SdpCoOwnershipPercent = model.SdpCoOwnershipPercent;
            SdpCoOwnershipComments = model.SdpCoOwnershipComments;
            SdpOutstandingTax = model.SdpOutstandingTax;
            SdpOutstandingTaxComments = model.SdpOutstandingTaxComments;
            SdpUrbanisticIssues = model.SdpUrbanisticIssues;
            SdpUrbanisticIssuesComments = model.SdpUrbanisticIssuesComments;

            #endregion

            #region Flags

            LegalTitle = model.LegalTitle;
            Registrable = model.Registrable;
            CoOwnership = model.CoOwnership;
            UnderConstruction = model.UnderConstruction;
            ChargesBurdens = model.ChargesBurdens;
            Vpo = model.Vpo;
            Lessees = model.Lessees;
            Squatters = model.Squatters;
            SuspendeVulnerability = model.SuspendeVulnerability;
            PossibleVulnerability = model.PossibleVulnerability;
            SuspendedTjueEcj = model.SuspendedTjueEcj;
            FirstRefusalReversion = model.FirstRefusalReversion;

            FlagSummary = model.FlagSummary;
            FlagExclusion = model.FlagExclusion;
            FlagSecondClosing = model.FlagSecondClosing;
            FlagSpA = model.FlagSpA;

            #endregion

            #region CHARGES AND BURDENS (from Registry Excerpts)																						

            IdCbCharge1Type = model.IdCbCharge1Type;
            CbCharge1 = model.CbCharge1;
            IdCbCharge2Type = model.IdCbCharge2Type;
            CbCharge2 = model.CbCharge2;
            IdCbCharge3Type = model.IdCbCharge3Type;
            CbCharge3 = model.CbCharge3;
            IdCbCharge4Type = model.IdCbCharge4Type;
            CbCharge4 = model.CbCharge4;
            IdCbCharge5Type = model.IdCbCharge5Type;
            CbCharge5 = model.CbCharge5;
            CbChargeComments = model.CbChargeComments;

            IdCbBurden1Type = model.IdCbBurden1Type;
            CbBurden1 = model.CbBurden1;
            IdCbBurden2Type = model.IdCbBurden2Type;
            CbBurden2 = model.CbBurden2;
            IdCbBurden3Type = model.IdCbBurden3Type;
            CbBurden3 = model.CbBurden3;
            IdCbBurden4Type = model.IdCbBurden4Type;
            CbBurden4 = model.CbBurden4;
            IdCbBurden5Type = model.IdCbBurden5Type;
            CbBurden5 = model.CbBurden5;
            CbBurdenComments = model.CbBurdenComments;

            #endregion

            #region JUDICIAL PROCEEDING								

            JudicialTypeProceeding = model.JudicialTypeProceeding;
            JudicialCourt = model.JudicialCourt;
            JudicialProceedingNo = model.JudicialProceedingNo;
            IdJudicialLegalStatus = model.IdJudicialLegalStatus;
            JudicialAwardingDecree = model.JudicialAwardingDecree;
            JudicialNegativeRegistration = model.JudicialNegativeRegistration;
            JudicialComments = model.JudicialComments;
            JudicialPendingResolutionEcj = model.JudicialPendingResolutionEcj;
            JudicialClausesEcj = model.JudicialClausesEcj;

            #endregion

            #region POSSESION PROCEEDING						

            PossProceedingType = model.PossProceedingType;
            PossProceedingCourt = model.PossProceedingCourt;
            PossProceedingNo = model.PossProceedingNo;
            PossProceedingComments = model.PossProceedingComments;

            #endregion

            #region POSSESION

            IdPossOcupationalSituation = model.IdPossOcupationalSituation;
            PossOcupationalSituationComments = model.PossOcupationalSituationComments;
            PossVulnerableMortgageDebtors = model.PossVulnerableMortgageDebtors;
            IdPossVulnerableMortgageDebtorsComm = model.IdPossVulnerableMortgageDebtorsComm;
            PossRightFirstFefusal = model.PossRightFirstFefusal;
            PossComments = model.PossComments;
            PossLaunchTakeOver = model.PossLaunchTakeOver;
            PossLaunchTakeOverComment = model.PossLaunchTakeOverComment;

            #endregion

        }

        #endregion
    }
}

