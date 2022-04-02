using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public partial class Con_ExpedienteEstadoConvenio : IConConclusion, IConCalificacion
    {
        #region Properties

        #region Properties 1

        public int ExpedienteEstadoId { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public bool ConvenioAnticipado { get; set; }
        public string SentenciaAprobandoConvenio { get; set; }
        public bool SuperaLimites { get; set; }

        public int? DocumentoSentenciaConvenioId { get; set; }
        public int? DocumentoAutoJuezId { get; set; }
        public virtual ExpedienteDocumento ExpedienteDocumento { get; set; }
        public virtual ExpedienteDocumento ExpedienteDocumento1 { get; set; }

        #endregion

        #region Properties Masa Pasivo

        //public decimal? MasaPasivoPrivilegioEspecialTotal { get; set; }
        //public decimal? MasaPasivoPrivilegioEspecialCliente { get; set; }
        //public decimal? MasaPasivoPrivilegioEspecialClientePorciento { get; set; }
        //public decimal? MasaPasivoPrivilegioGeneralTotal { get; set; }
        //public decimal? MasaPasivoPrivilegioGeneralCliente { get; set; }
        //public decimal? MasaPasivoPrivilegioGeneralClientePorciento { get; set; }
        //public decimal? MasaPasivoOrdinarioTotal { get; set; }
        //public decimal? MasaPasivoOrdinarioCliente { get; set; }
        //public decimal? MasaPasivoOrdinarioClientePorciento { get; set; }
        //public decimal? MasaPasivoSubordinadoTotal { get; set; }
        //public decimal? MasaPasivoSubordinadoCliente { get; set; }
        //public decimal? MasaPasivoSubordinadoClientePorciento { get; set; }

        //public decimal? MasaPasivoContraMasaTotal { get; set; }
        //public decimal? MasaPasivoContraMasaCliente { get; set; }
        //public decimal? MasaPasivoContraMasaClientePorciento { get; set; }

        //public decimal? ContingentePrivilegioEspecialTotal { get; set; }
        //public decimal? ContingentePrivilegioEspecialCliente { get; set; }
        //public decimal? ContingentePrivilegioEspecialClientePorciento { get; set; }
        //public decimal? ContingentePrivilegioGeneralTotal { get; set; }
        //public decimal? ContingentePrivilegioGeneralCliente { get; set; }
        //public decimal? ContingentePrivilegioGeneralClientePorciento { get; set; }
        //public decimal? ContingenteOrdinarioTotal { get; set; }
        //public decimal? ContingenteOrdinarioCliente { get; set; }
        //public decimal? ContingenteOrdinarioClientePorciento { get; set; }
        //public decimal? ContingenteSubordinadoTotal { get; set; }
        //public decimal? ContingenteSubordinadoCliente { get; set; }
        //public decimal? ContingenteSubordinadoClientePorciento { get; set; }

        #endregion

        #region Properties Informacion Convenio

        public DateTime? FechaApertura { get; set; } 
        public DateTime? FechaJuntaAcreedores { get; set; }
        public DateTime? FechaPresentacionPropuestaConvenio { get; set; }
        public DateTime? FechaConvenioAutoAprobacion { get; set; }
        public DateTime? FechaConvenioImpugnacion { get; set; }

        public bool ConvenioVotacionJuntaAcreedores { get; set; }
        public bool ConvenioAdhesion { get; set; }
        public bool ConvenioArrastre { get; set; }

        public string ConvenioResumen { get; set; }

        #endregion

        public DateTime? ConclusionFechaSolicitud { get; set; }
        public DateTime? ConclusionFechaOposicion { get; set; }
        public DateTime? ConclusionFechaRendicionCuentas { get; set; }
        public DateTime? ConclusionFechaOposicionRendicionCuentas { get; set; }
        public DateTime? ConclusionFechaAuto { get; set; }

        public DateTime? CalificacionFechaApertura { get; set; }
        public DateTime? CalificacionFechaPersonacion { get; set; }
        public DateTime? CalificacionFechaVista { get; set; }
        public DateTime? CalificacionFechaSentencia { get; set; }
        public bool CalificacionPersonacion { get; set; }

        public int? CalificacionACId { get; set; }
        [ForeignKey("CalificacionACId")]
        public virtual Con_TipoCalificacion CalificacionAC { get; set; }

        public int? CalificacionFiscalId { get; set; }
        [ForeignKey("CalificacionFiscalId")]
        public virtual Con_TipoCalificacion CalificacionFiscal { get; set; }

        public int? CalificacionDefinitivaId { get; set; }
        [ForeignKey("CalificacionDefinitivaId")]
        public virtual Con_TipoCalificacion CalificacionDefinitiva { get; set; }

        #endregion

        #region Properties Readonly

        //public decimal MasaPasivoTotal => (MasaPasivoPrivilegioEspecialTotal ?? 0) + (MasaPasivoPrivilegioGeneralTotal ?? 0) + (MasaPasivoOrdinarioTotal ?? 0) + (MasaPasivoSubordinadoTotal ?? 0);
        //public decimal MasaPasivoCliente => (MasaPasivoPrivilegioEspecialCliente ?? 0) + (MasaPasivoPrivilegioGeneralCliente ?? 0) + (MasaPasivoOrdinarioCliente ?? 0) + (MasaPasivoSubordinadoCliente ?? 0);

        //public decimal ContingenteTotal => (ContingentePrivilegioEspecialTotal ?? 0) + (ContingentePrivilegioGeneralTotal ?? 0) + (ContingenteOrdinarioTotal ?? 0) + (ContingenteSubordinadoTotal ?? 0);
        //public decimal ContingenteCliente => (ContingentePrivilegioEspecialCliente ?? 0) + (ContingentePrivilegioGeneralCliente ?? 0) + (ContingenteOrdinarioCliente ?? 0) + (ContingenteSubordinadoCliente ?? 0);

        #endregion

        #region Methods

        public void Refresh(Con_ExpedienteEstadoConvenio model)
        {
            FechaJuntaAcreedores = model.FechaJuntaAcreedores;
            FechaConvenioAutoAprobacion = model.FechaConvenioAutoAprobacion;
            FechaConvenioImpugnacion = model.FechaConvenioImpugnacion;
            ConvenioVotacionJuntaAcreedores = model.ConvenioVotacionJuntaAcreedores;
            ConvenioAdhesion = model.ConvenioAdhesion;
            ConvenioArrastre = model.ConvenioArrastre;
            ConvenioResumen = model.ConvenioResumen;

            RefreshClasificacion(model);
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

        public void RefreshClasificacion(IConCalificacion modelBase)
        {
            CalificacionFechaApertura = modelBase.CalificacionFechaApertura;
            CalificacionFechaPersonacion = modelBase.CalificacionFechaPersonacion;
            CalificacionFechaVista = modelBase.CalificacionFechaVista;
            CalificacionFechaSentencia = modelBase.CalificacionFechaSentencia;
            CalificacionPersonacion = modelBase.CalificacionPersonacion;

            CalificacionACId = modelBase.CalificacionACId;
            CalificacionFiscalId = modelBase.CalificacionFiscalId;
            CalificacionDefinitivaId = modelBase.CalificacionDefinitivaId;
        }

        #endregion

    }
}
