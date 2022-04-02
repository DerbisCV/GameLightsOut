using Solvtio.Models.Model;
using Solvtio.Models.Common;
using Solvtio.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteNegociacion")]
    public class ExpedienteNegociacion
    {
        #region Constructors

        public ExpedienteNegociacion()
        {
            CreateBase();
        }

        public ExpedienteNegociacion(int idExpediente)
        {
            CreateBase();
            IdExpediente = idExpediente;
        }

        private void CreateBase()
        {
            FechaAlta = DateTime.Now;
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedienteNegociacion { get; set; }

        [Index(IsUnique = true), ForeignKey("Expediente")]
        public int IdExpediente { get; set; }
        public virtual Expediente Expediente { get; set; }



        [Required]
        public DateTime FechaAlta { get; set; }

        #endregion

        #region Pre-Contencioso

        public int? IdGestor { get; set; }
        [ForeignKey("IdGestor")]
        public virtual Usuario Gestor { get; set; }

        public DateTime? PrecontenciosoFechaInicio { get; set; }
        public DateTime? PrecontenciosoFechaFin { get; set; }
        //public DateTime? PrecontenciosoFechaLocalizado { get; set; }
        public DateTime? PrecontenciosoFechaEntregaInmueble { get; set; }
        public string PrecontenciosoSucursalContacto { get; set; }
        public string PrecontenciosoSucursalNumero { get; set; }
        public string PrecontenciosoSucursalTelefono { get; set; }
        public string PrecontenciosoDatosContacto { get; set; }
        public string PrecontenciosoSucursalObservaciones { get; set; }
        public ExpedienteEstadoTipo? PrecontenciosoEstado { get; set; }
        public decimal? PrecontenciosoDeudaInicial { get; set; }
        public decimal? PrecontenciosoDeudaNegociada { get; set; }
        public decimal? PrecontenciosoDeudaRecuperada { get; set; }

        public int? PrecontenciosoNegociacionFinalizadaPor { get; set; }

        //Precontencioso - Agregar: (Fecha , Fecha , Fecha )
        public DateTime? PrecontenciosoFechaPropuesta { get; set; }
        public DateTime? PrecontenciosoFechaAprobada { get; set; }
        public DateTime? PrecontenciosoFechaDenegada { get; set; }
        public ContactadoTipo? PrecontenciosoContactado { get; set; }

        #endregion

        #region Contencioso

        public int? IdGestorContencioso { get; set; }
        [ForeignKey("IdGestorContencioso")]
        public virtual Usuario GestorContencioso { get; set; }

        public DateTime? ContenciosoFechaInicio { get; set; }
        public DateTime? ContenciosoFechaFin { get; set; }
        public DateTime? ContenciosoFechaPrevistaEntrega { get; set; }
        public DateTime? ContenciosoFechaEntregaInmueble { get; set; }

        public int? ContenciosoNegociacionFinalizadaPor { get; set; }
        [ForeignKey("ContenciosoNegociacionFinalizadaPor")]
        public virtual CaracteristicaBase ContenciosoNegociacionFinalizada { get; set; }

        public string ContenciosoDatosContacto { get; set; }
        public string ContenciosoIncidencias { get; set; }
        public DateTime? ContenciosoFechaFirma { get; set; }
        public DateTime? ContenciosoFechaPresentacionJuzgado { get; set; }
        public DateTime? ContenciosoFechaEnvioFacturacion { get; set; }
        public bool ContenciosoDiligenciaPosesion { get; set; }
        public decimal? ContenciosoIncentivoImporte { get; set; }
        public DateTime? ContenciosoIncentivoFechaEfectividad { get; set; }
        public decimal? ContenciosoDeudaDecreto { get; set; }
        public ExpedienteEstadoTipo ContenciosoEstado { get; set; }
        public ContactadoTipo? ContenciosoContactado { get; set; }

        public decimal? ContenciosoAprobadoQuitaPorciento { get; set; }
        public DateTime? ContenciosoFechaLanzamientoCliente { get; set; }
        public int? ContenciosoSituacionCierreCarteraId { get; set; }
        [ForeignKey("ContenciosoSituacionCierreCarteraId")]
        public virtual CaracteristicaBase ContenciosoSituacionCierreCartera { get; set; }

        public int? ContenciosoSituacionId { get; set; }
        [ForeignKey("ContenciosoSituacionId")]
        public virtual CaracteristicaBase ContenciosoSituacion { get; set; }

        public string Fase { get; set; }

        public DateTime? ContenciosoFechaPrinex { get; set; }

        #endregion

        #region Contencioso Propuesta

        public DateTime? ContenciosoQuitaFechaPropuesta { get; set; }
        public decimal? ContenciosoQuitaImporte { get; set; }
        public DateTime? ContenciosoFechaPropuestaEnviada { get; set; }
        public DateTime? ContenciosoFechaPropuestaAceptada { get; set; }
        public DateTime? ContenciosoFechaPepaDenegada { get; set; }
        public DateTime? ContenciosoFechaPepaCancelada { get; set; }

        public DateTime? ContenciosoQuitaFechaPropuesta2 { get; set; }
        public decimal? ContenciosoQuitaImporte2 { get; set; }
        public DateTime? ContenciosoFechaPropuestaEnviada2 { get; set; }
        public DateTime? ContenciosoFechaPropuestaAceptada2 { get; set; }
        public DateTime? ContenciosoFechaPepaDenegada2 { get; set; }
        public DateTime? ContenciosoFechaPepaCancelada2 { get; set; }

        #endregion

        #region TPA

        public string TpaClasificacionPropuesta { get; set; }
        public string TpaAutos { get; set; }
        public string TpaSociedadCliente { get; set; }

        public DateTime? TpaFechaLanzamiento { get; set; }
        public DateTime? TpaFechaContactado { get; set; }
        public bool TpaPropuestaPendienteDocumentacion { get; set; }
        public bool TpaPropuestaPendienteEnvio { get; set; }

        #endregion

        #region Negociacion Unificado

        public int? IdContactabilidadResultado { get; set; }
        [ForeignKey("IdContactabilidadResultado")]
        public virtual CaracteristicaBase ContactabilidadResultado { get; set; }

        public int? IdContactabilidadMotivoKo { get; set; }
        [ForeignKey("IdContactabilidadMotivoKo")]
        public virtual CaracteristicaBase ContactabilidadMotivoKo { get; set; }

        public int? IdSegmentacionestrategia { get; set; }
        [ForeignKey("IdSegmentacionestrategia")]
        public virtual CaracteristicaBase Segmentacionestrategia { get; set; }

        public int? IdFaseNegociacion { get; set; }
        [ForeignKey("IdFaseNegociacion")]
        public virtual CaracteristicaBase FaseNegociacion { get; set; }

        public string NotaNegociacionNoProcede { get; set; }

        public int? IdEstrategia1 { get; set; }
        [ForeignKey("IdEstrategia1")]
        public virtual CaracteristicaBase Estrategia1 { get; set; }

        public int? IdEstrategia2 { get; set; }
        [ForeignKey("IdEstrategia2")]
        public virtual CaracteristicaBase Estrategia2 { get; set; }

        public int? IdPendienteTestimonio { get; set; }
        [ForeignKey("IdPendienteTestimonio")]
        public virtual CaracteristicaBase PendienteTestimonio { get; set; }

        public string NotaImpulsoRealizar { get; set; }

        public DateTime? FechaObs { get; set; }

        public DateTime? FechaAccionesInicio { get; set; }
        public DateTime? FechaAccionesFin { get; set; }

        public string NotaNegociacion { get; set; }

        public string Centro1 { get; set; }
        public string Centro1Territorio { get; set; }
        public string Centro1Gestor { get; set; }
        public string Centro1Director { get; set; }

        public int? IdTipoSolucion { get; set; }
        [ForeignKey("IdTipoSolucion")]
        public virtual CaracteristicaBase TipoSolucion { get; set; }

        public string NotaCategoriaDeuda { get; set; }
        public DateTime? FechaFirmaAcuerdo { get; set; }

        public decimal? ImportePropuestaRechazada { get; set; }
        public string NotaRecovery { get; set; }
        public string NotaParaLetradoNegociador { get; set; }

        public string Centro2 { get; set; }
        public string Centro2Territorio { get; set; }
        public string Centro2Gestor { get; set; }

        public decimal? ImporteLiquidacion { get; set; }
        public DateTime? FechaCierre { get; set; }
        public int? TotalCuotasImpagadasAlCierre { get; set; }

        public decimal? Pago1 { get; set; }
        public decimal? Pago2 { get; set; }
        public decimal? Pago3 { get; set; }
        public decimal? Pago4 { get; set; }
        public decimal? Pago5 { get; set; }
        public decimal? Pago6 { get; set; }

        public bool PagoACuenta { get; set; }

        public DateTime? FechaImpulso { get; set; }
        public string NotaImpulso { get; set; }

        #endregion

        #region Properties Not Mapped

        //Este campo lo hemos agregado porque el autocomplete no va bien cuando el dom name es  Expediente.IdJuzgado (Ejemplo en NegociacionEdit.cshtml)
        [NotMapped]
        public int? IdJuzgado { set; get; }

        [NotMapped]
        public DateTime? FechaLanzamiento { set; get; }
        [NotMapped]
        public DateTime? FechaCelebracionSubasta { set; get; }
        [NotMapped]
        public DateTime? FechaAdjudicacion { set; get; }

        [NotMapped]
        public string ContenciosoNegociacionFinalizadaPorNombre { set; get; }
        [NotMapped]
        public string PrecontenciosoNegociacionFinalizadaPorNombre { set; get; }

        #endregion

        #region Methods

        public string ShowSituacionPrecontencioso()
        {
            //Si ya tenemos el finalizado por lo mostrremos, en caso de no tenerlo mostraremos la situación.
            return
                PrecontenciosoNegociacionFinalizadaPor.HasValue ? PrecontenciosoNegociacionFinalizadaPor.GetDescriptionNegociacionFinalizadaPor() :
                PrecontenciosoEstado.HasValue ? PrecontenciosoEstado.GetDescription() :
                string.Empty;
        }

        public string ShowSituacionContencioso()
        {
            //Si ya tenemos el finalizado por lo mostrremos, en caso de no tenerlo mostraremos la situación.
            return
                ContenciosoNegociacionFinalizadaPor.HasValue ? ContenciosoNegociacionFinalizadaPor.GetDescriptionNegociacionFinalizadaPor() :
                ContenciosoEstado.GetDescription();
        }

        public void RefreshBy(ExpedienteNegociacion model)
        {
            IdContactabilidadResultado = model.IdContactabilidadResultado;
            IdContactabilidadMotivoKo = model.IdContactabilidadMotivoKo;
            IdSegmentacionestrategia = model.IdSegmentacionestrategia;
            IdFaseNegociacion = model.IdFaseNegociacion;
            NotaNegociacionNoProcede = model.NotaNegociacionNoProcede;
            IdEstrategia1 = model.IdEstrategia1;
            IdEstrategia2 = model.IdEstrategia2;
            IdPendienteTestimonio = model.IdPendienteTestimonio;
            NotaImpulsoRealizar = model.NotaImpulsoRealizar;
            FechaObs = model.FechaObs;
            FechaAccionesInicio = model.FechaAccionesInicio;
            FechaAccionesFin = model.FechaAccionesFin;            
            NotaNegociacion = model.NotaNegociacion;
            Centro1 = model.Centro1;
            Centro1Territorio = model.Centro1Territorio;
            Centro1Gestor = model.Centro1Gestor;
            Centro1Director = model.Centro1Director;
            IdTipoSolucion = model.IdTipoSolucion;
            NotaCategoriaDeuda = model.NotaCategoriaDeuda;
            FechaFirmaAcuerdo = model.FechaFirmaAcuerdo;
            ImportePropuestaRechazada = model.ImportePropuestaRechazada;
            NotaRecovery = model.NotaRecovery;
            NotaParaLetradoNegociador = model.NotaParaLetradoNegociador;
            Centro2 = model.Centro2;
            Centro2Territorio = model.Centro2Territorio;
            Centro2Gestor = model.Centro2Gestor;
            ImporteLiquidacion = model.ImporteLiquidacion;
            FechaCierre = model.FechaCierre;
            TotalCuotasImpagadasAlCierre = model.TotalCuotasImpagadasAlCierre;
            Pago1 = model.Pago1;
            Pago2 = model.Pago2;
            Pago3 = model.Pago3;
            Pago4 = model.Pago4;
            Pago5 = model.Pago5;
            Pago6 = model.Pago6;
            PagoACuenta = model.PagoACuenta;
            FechaImpulso = model.FechaImpulso;
            NotaImpulso = model.NotaImpulso;
        }

        #endregion


    }
}
