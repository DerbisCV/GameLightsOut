using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    public class Hip_Inmueble : InmuebleBase, IInmuebleCatastro
    {
        #region Constructors

        public Hip_Inmueble()
        {
            CreateBase();
        }
        public Hip_Inmueble(int idExpediente, int? idExpDeudor)
        {
            CreateBase();
            IdExpediente = idExpediente;
            IdExpedienteDeudor = idExpDeudor;
            EsHabitual = true;
        }

        private void CreateBase()
        {
            Hip_TitularInmueble = new List<Hip_TitularInmueble>();
        }

        #endregion

        #region Properties New

        public int? IdProvincia { get; set; }
        [ForeignKey("IdProvincia")]
        public virtual Provincia Provincia { get; set; }

        public int? IdMunicipio { get; set; }
        [ForeignKey("IdMunicipio")]
        public virtual Municipio Municipio { get; set; }

        public int? IdExpedienteDeudor { get; set; } //Solo se usará en (ExpedienteDeudorEjcutivo) donde los bines inmuebles tienen que estar asociados por Deudor
                                                     //[ForeignKey("IdExpedienteDeudor")]
                                                     //public virtual ExpedienteDeudor ExpedienteDeudor { get; set; }

        public int? IdInmuebleGestion { get; set; }
        [ForeignKey("IdInmuebleGestion")]
        public virtual Inmueble InmuebleGestion { get; set; }

        public string RefCatastral { get; set; }
        public string ReferenciaExterna { get; set; }
        public int? IdItemCalendarInSp { get; set; }

        #region Hipotecario Adjudicacion

        public DateTime? PosesionFechaSolicitud { get; set; }
        public DateTime? PosesionFecha { get; set; }
        public PositivoNegativoType? PosesionResultado { get; set; }
        public DateTime? LanzamientoFecha { get; set; }
        public DateTime? EntregaLlavesFecha { get; set; }
        public bool Ley12013 { get; set; }
        public bool ReconocidoArrendamiento { get; set; }
        public bool InstruccionGestores { get; set; }
        public bool AcuerdoFormalizado { get; set; }
        public bool RecuperadaPosesionJudicial { get; set; }
        public DateTime? FechaCertificacionCargas { get; set; }


        public bool OcupadaTerceros { get; set; }
        public bool OcupadaDemandados { get; set; }
        public bool NoPedidaPosesionEnPlazo { get; set; }
        public bool Desconocida { get; set; }


        public string LiquidacionEstado { get; set; }

        public int? SuperficieConstruida { get; set; }
        public int? SuperficieParcela { get; set; }
        public string UsoPrincipal { get; set; }
        public int? AnioConstruccion { get; set; }

        public decimal? Valoracion { get; set; }
        public decimal? ValorEstimadoM2 { get; set; }
        public decimal? DeudaCalculo { get; set; }
        public string UrlGeolocalizacion { get; set; }
        public bool Destacado { get; set; }
        public string NoContrato { get; set; }
        public decimal? TasacionActualizada { get; set; }
        public DateTime? TasacionActualizadaFecha { get; set; }

        public bool DesvinculandoDelExpediente { get; set; }

        public int? IdDesvinculandoMotivo { get; set; }
        [ForeignKey("IdDesvinculandoMotivo")]
        public virtual CaracteristicaBase DesvinculandoMotivo { get; set; }

        public int? IdEstrategia { get; set; }
        [ForeignKey("IdEstrategia")]
        public virtual CaracteristicaBase Estrategia { get; set; }

        #endregion

        #region Alquiler Lanzamiento

        public DateTime? LanzamientoFecha1 { get; set; }
        public DateTime? LanzamientoFecha2 { get; set; }
        public PositivoNegativoType? LanzamientoResultado1 { get; set; }
        public PositivoNegativoType? LanzamientoResultado2 { get; set; }
        public int? LanzamientoSuspensionMotivoId1 { get; set; }
        public int? LanzamientoSuspensionMotivoId2 { get; set; }
        public DateTime? LanzamientoVistaFecha { get; set; }

        #endregion

        #region Ejecutivo

        public DateTime? EjcFechaInscripcion { get; set; }
        public DateTime? EjcFechaEmbargoSolicitudProrroga { get; set; }
        public DateTime? EjcFechaEmbargoInstruccionesNoProrrogar { get; set; }

        public DateTime? EjcFechaAvaluo { get; set; }
        public DateTime? EjcFechaOficioCargasAnteriores { get; set; }
        public DateTime? EjcFechaCertificacionCargas { get; set; }
        public DateTime? EjcFechaLiquidacionCargasAnteriores { get; set; }
        public decimal? EjcImporte { get; set; }

        public string EjcRegistro { get; set; }
        public string EjcLetraEmbargo { get; set; }
        public bool EjcValoracionViaApremio { get; set; }

        #endregion

        #region FijacionSaldo

        public string FijacionSaldoNotario { get; set; }
        public string FijacionSaldoColegio { get; set; }
        public DateTime? FijacionSaldoFecha { get; set; }
        public string FijacionSaldoProtocolo { get; set; }
        public int? FijacionSaldoNumeroCuotasImpagadas { get; set; }

        #endregion

        #region Concurso

        public int? IdExpedientePrestamo { get; set; }
        [ForeignKey("IdExpedientePrestamo")]
        public virtual ExpedientePrestamo ExpedientePrestamo { get; set; }

        //public int? IdExpedienteContrato { get; set; }
        //[ForeignKey("IdExpedienteContrato")]
        //public virtual ExpedienteContrato ExpedienteContrato { get; set; }

        #endregion

        #endregion

        #region Tpn

        [DataType(DataType.Date)]
        public DateTime? TpnInformeOcupacionalFechaSolicitud { get; set; }
        [DataType(DataType.Date)]
        public DateTime? TpnInformeOcupacionalFechaRecepcion { get; set; }
        public bool TpnInformeOcupacionalOcupado { get; set; }


        public TipoTpnTnt? TpnTntTipo { get; set; }

        [DataType(DataType.Date)]
        public DateTime? TpnTntFechaTomaAgendada { get; set; }

        [DataType(DataType.Date)]
        public DateTime? TpnTntFechaToma { get; set; }

        [DataType(DataType.Date)]
        public DateTime? TpnTntFechaActa { get; set; }

        public string TpnTntIncidencia { get; set; }

        #endregion

        #region Properties Old

        [Index]
        public int? IdExpediente { get; set; }
        public virtual Expediente Expediente { get; set; }

        public string Direccion { get; set; }
        public string DireccionLocalidad { get; set; }
        public string DireccionCodigoPostal { get; set; }
        public string DireccionProvincia { get; set; }
        public decimal TipoSubasta { get; set; }
        public bool PrestamoEnPorciento { get; set; }

        public decimal PrestamoIntRemuneratorios { get; set; }
        public decimal PrestamoIntDemora { get; set; }
        public decimal PrestamoPrestAccesorias { get; set; }
        public decimal PrestamoCostas { get; set; }
        public decimal PrestamoGastos { get; set; }
        public decimal PrestamoIntRemuneratoriosPorciento { get; set; }
        public decimal PrestamoIntDemoraPorciento { get; set; }
        public decimal PrestamoPrestAccesoriasPorciento { get; set; }
        public decimal PrestamoCostasPorciento { get; set; }
        public decimal PrestamoGastosPorciento { get; set; }
        public decimal DeudaPrincipal { get; set; }
        public decimal DeudaIntRemuneratorios { get; set; }
        public decimal DeudaIntDemora { get; set; }
        public decimal DeudaComisionesGastos { get; set; }
        public string NumeroFinca { get; set; }
        public string Tomo { get; set; }
        public string Libro { get; set; }
        public string Folio { get; set; }
        public string Registro { get; set; }
        public string Inscripcion { get; set; }
        public string Oficina { get; set; }
        public string NoCuentaPrestamo { get; set; }



        public string IdUfir { get; set; }
        public bool IsVpo { get; set; }

        public int? IdRegistrationStatus { get; set; }
        [ForeignKey("IdRegistrationStatus")]
        public virtual CaracteristicaBase RegistrationStatus { get; set; }

        public int? IdDefectReason { get; set; }
        [ForeignKey("IdDefectReason")]
        public virtual CaracteristicaBase DefectReason { get; set; }

        #endregion

        #region Properties NotMapped

        [NotMapped]
        public int? IdMunicipioCatastro { get; set; }

        [NotMapped]
        public bool ForAll { get; set; }

        [NotMapped]
        public bool EnCartera { get; set; }

        [NotMapped]
        public InmuebleContrato InmuebleContratoMain { get; set; }

        #endregion

        #region Properties One to One


        public virtual Hip_TipoInmueble Hip_TipoInmueble { get; set; }

        #endregion

        #region Properties One to Many

        public virtual ICollection<Hip_TitularInmueble> Hip_TitularInmueble { get; set; }
        public virtual ICollection<HipInmuebleNota> HipInmuebleNotaSet { get; set; }

        public virtual ICollection<CarteraInmueble> CarteraInmuebleSet { get; set; }

        //[NotMapped]
        //public ICollection<InmuebleContrato> InmuebleContratoSet { get; set; }

        #endregion

        #region Properties ReadOnly

        public DateTime? LanzamientoFecha2o1 => LanzamientoFecha2 ?? LanzamientoFecha1;
        public string DireccionCompleta => $"{Direccion} {DireccionCodigoPostal} {Municipio?.Nombre} {Provincia?.Nombre}";

        private decimal? _prestamoResponsabilidadHipotecaria;
        public decimal PrestamoResponsabilidadHipotecaria
        {
            get
            {
                if (!_prestamoResponsabilidadHipotecaria.HasValue)
                {
                    _prestamoResponsabilidadHipotecaria = (decimal)(PrestamoCapital + PrestamoIntRemuneratorios + PrestamoIntDemora + PrestamoPrestAccesorias + PrestamoCostas + PrestamoGastos);
                }

                return _prestamoResponsabilidadHipotecaria.Value;
            }
        }

        public string DescripcionCompleta =>
            !string.IsNullOrWhiteSpace(Descripcion) ? Descripcion :
            Direccion;

        #endregion

        #region Methods

        public override string ToString()
        {
            return
                !string.IsNullOrWhiteSpace(NumeroFinca) ? NumeroFinca :
                !string.IsNullOrWhiteSpace(Descripcion) ? Descripcion :
                Direccion;
        }

        internal void RefreshBy(Hip_Inmueble inmueble)
        {
            IdTipoInmueble = inmueble.IdTipoInmueble;
            Referencia = inmueble.Referencia;
            Descripcion = inmueble.Descripcion;
            EsHabitual = inmueble.EsHabitual;
            EstaVacia = inmueble.EstaVacia;
            Superficie = inmueble.Superficie;
            PrestamoCapital = inmueble.PrestamoCapital;
            Direccion = inmueble.Direccion;
            DireccionCodigoPostal = inmueble.DireccionCodigoPostal;
            DireccionLocalidad = inmueble.DireccionLocalidad;
            DireccionProvincia = inmueble.DireccionProvincia;
            IdProvincia = inmueble.IdProvincia;
            IdMunicipio = inmueble.IdMunicipio;
            NumeroFinca = inmueble.NumeroFinca;
            Tomo = inmueble.Tomo;
            Libro = inmueble.Libro;
            Folio = inmueble.Folio;
            Registro = inmueble.Registro;
            Inscripcion = inmueble.Inscripcion;
            RefCatastral = inmueble.RefCatastral;
            ReferenciaExterna = inmueble.ReferenciaExterna;
            Valoracion = inmueble.Valoracion;
            ValorEstimadoM2 = inmueble.ValorEstimadoM2;
            DeudaCalculo = inmueble.DeudaCalculo;
            UrlGeolocalizacion = inmueble.UrlGeolocalizacion;
            Destacado = inmueble.Destacado;
            NoContrato = inmueble.NoContrato;
            TasacionActualizada = inmueble.TasacionActualizada;
            DesvinculandoDelExpediente = inmueble.DesvinculandoDelExpediente;
            IdDesvinculandoMotivo = inmueble.IdDesvinculandoMotivo;
            IdEstrategia = inmueble.IdEstrategia;
            ImporteAdjudicado = inmueble.ImporteAdjudicado;

            IdUfir = inmueble.IdUfir;
            IsVpo = inmueble.IsVpo;
            IdRegistrationStatus = inmueble.IdRegistrationStatus;
            IdDefectReason = inmueble.IdDefectReason;
            TasacionActualizadaFecha = inmueble.TasacionActualizadaFecha;
        }

        internal void RefreshByTpn(Hip_Inmueble modelBase)
        {
            if (!IdExpediente.HasValue || Expediente == null || Expediente.TipoExpediente != TipoExpedienteEnum.TPN) return;

            TpnInformeOcupacionalFechaSolicitud = modelBase.TpnInformeOcupacionalFechaSolicitud;
            TpnInformeOcupacionalFechaRecepcion = modelBase.TpnInformeOcupacionalFechaRecepcion;
            TpnInformeOcupacionalOcupado = modelBase.TpnInformeOcupacionalOcupado;
            TpnTntTipo = modelBase.TpnTntTipo;
            TpnTntFechaTomaAgendada = modelBase.TpnTntFechaTomaAgendada;
            TpnTntFechaToma = modelBase.TpnTntFechaToma;
            TpnTntIncidencia = modelBase.TpnTntIncidencia;
            TpnTntFechaActa = modelBase.TpnTntFechaActa;
        }

        internal void RefreshByFijacionSaldo(Hip_Inmueble modelBase)
        {
            if (!IdExpediente.HasValue) return;

            FijacionSaldoNotario = modelBase.FijacionSaldoNotario;
            FijacionSaldoColegio = modelBase.FijacionSaldoColegio;
            FijacionSaldoFecha = modelBase.FijacionSaldoFecha;
            FijacionSaldoProtocolo = modelBase.FijacionSaldoProtocolo;
            FijacionSaldoNumeroCuotasImpagadas = modelBase.FijacionSaldoNumeroCuotasImpagadas;
        }

        internal void RefreshPrestamoDeudas(Hip_Inmueble inmueble)
        {
            TipoSubasta = inmueble.TipoSubasta;
            PrestamoEnPorciento = inmueble.PrestamoEnPorciento;

            PrestamoIntRemuneratorios = inmueble.PrestamoIntRemuneratorios;
            PrestamoIntRemuneratoriosPorciento = inmueble.PrestamoIntRemuneratoriosPorciento;
            PrestamoIntDemora = inmueble.PrestamoIntDemora;
            PrestamoIntDemoraPorciento = inmueble.PrestamoIntDemoraPorciento;
            PrestamoPrestAccesorias = inmueble.PrestamoPrestAccesorias;
            PrestamoPrestAccesoriasPorciento = inmueble.PrestamoPrestAccesoriasPorciento;
            PrestamoCostas = inmueble.PrestamoCostas;
            PrestamoCostasPorciento = inmueble.PrestamoCostasPorciento;
            PrestamoGastos = inmueble.PrestamoGastos;
            PrestamoGastosPorciento = inmueble.PrestamoGastosPorciento;
            //PrestamoResponsabilidadHipotecaria = inmueble.PrestamoIntDemora;

            DeudaPrincipal = inmueble.DeudaPrincipal;
            DeudaIntRemuneratorios = inmueble.DeudaIntRemuneratorios;
            DeudaIntDemora = inmueble.DeudaIntDemora;
            DeudaComisionesGastos = inmueble.DeudaComisionesGastos;
        }

        internal void RefreshEjc(Hip_Inmueble inmueble)
        {
            EjcFechaInscripcion = inmueble.EjcFechaInscripcion;
            EjcFechaEmbargoSolicitudProrroga = inmueble.EjcFechaEmbargoSolicitudProrroga;
            EjcFechaEmbargoInstruccionesNoProrrogar = inmueble.EjcFechaEmbargoInstruccionesNoProrrogar; //
            EjcFechaAvaluo = inmueble.EjcFechaAvaluo;
            EjcFechaOficioCargasAnteriores = inmueble.EjcFechaOficioCargasAnteriores;
            EjcFechaCertificacionCargas = inmueble.EjcFechaCertificacionCargas;
            EjcFechaLiquidacionCargasAnteriores = inmueble.EjcFechaLiquidacionCargasAnteriores;
            EjcImporte = inmueble.EjcImporte;
            EjcRegistro = inmueble.EjcRegistro;
            EjcLetraEmbargo = inmueble.EjcLetraEmbargo;
            EjcValoracionViaApremio = inmueble.EjcValoracionViaApremio;
        }

        #endregion
    }
}

