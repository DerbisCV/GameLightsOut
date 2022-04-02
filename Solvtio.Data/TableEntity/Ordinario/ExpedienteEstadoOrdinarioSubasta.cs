using Solvtio.Models.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoOrdinarioSubasta")]
    public class ExpedienteEstadoOrdinarioSubasta
    {
		#region Constructors

		public ExpedienteEstadoOrdinarioSubasta()
		{
			TipoModeloSubastaId = 1;
			SubastaSuspension = Postores = Titulizado = AdjudicacionCliente = Oposicion = Consignar = IVA = false;
		}
        public ExpedienteEstadoOrdinarioSubasta(int idExpedienteEstado)
        {
            IdExpedienteEstado = idExpedienteEstado;
            TipoModeloSubastaId = 1;
            SubastaSuspension = Postores = Titulizado = AdjudicacionCliente = Oposicion = Consignar = IVA = false;
        }

        #endregion

        #region Properties

        [Key]
        [ForeignKey("ExpedienteEstado")]
        public int IdExpedienteEstado { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }
        public int IdExpediente { get; set; }

        
        public DateTime? FechaSolicitudSubasta { get; set; }
        public int TipoModeloSubastaId { get; set; }
        public bool? SubastaSuspension { get; set; }
        public DateTime? FechaCelebracionSubasta1 { get; set; }
        public DateTime? FechaCelebracionSubasta2 { get; set; }
        public DateTime? FechaEnvioInstruccionesProcurador { get; set; }
        public DateTime? FechaResultadoSubasta { get; set; }
        public DateTime? FechaAdjudicacion { get; set; }
        public decimal? ImporteAdjudicacion { get; set; }
        public DateTime? FechaActaSubasta { get; set; }
        public bool Postores { get; set; }
        public bool Titulizado { get; set; }
        public decimal? TasacionCostes { get; set; }
        public decimal? LiquidacionIntereses { get; set; }
        public bool AdjudicacionCliente { get; set; }
        public string MotivoSuspension { get; set; }
        public bool Oposicion { get; set; }
        public DateTime? OposicionFecha { get; set; }
        public DateTime? OposicionVistaFecha { get; set; }
        public DateTime? OposicionResolucionFecha { get; set; }
        public DateTime? AutorizadoEnvioGestor { get; set; }
        public int? IdTipoTitulizado { get; set; }
        public bool Consignar { get; set; }
        public decimal? DecisionPociento { get; set; }
        public string Nota { get; set; }
        public string Autorizado { get; set; }
        public bool IVA { get; set; }
        public DateTime? FechaDecretoSubasta { get; set; }
        public DateTime? FechaBoe { get; set; }
        public DateTime? FechaCierrePuja { get; set; }
        public DateTime? FechaFinMejoraPuja { get; set; }
        public bool FestivoFinDeSemana { get; set; }
        public bool? Puja { get; set; }
        public decimal ImportePuja { get; set; }
        public DateTime? FechaSolicitudAdjudicacionLimite { get; set; }
        public DateTime? FechaAperturaSubasta { get; set; }
        public bool? SubastaSuspension2 { get; set; }
        public bool PublicadoBoe { get; set; }
        public DateTime? FechaCierrePuja2 { get; set; }
        public bool SuspendidaCierrePuja1 { get; set; }
        public bool SuspendidaCierrePuja2 { get; set; }
        public DateTime? FechaSolicitudAdjudicacion { get; set; }
        public decimal ImporteSolicitudAdjudicacion { get; set; }

		public int? IdMotivoSuspension { get; set; }
		[ForeignKey("IdMotivoSuspension")]
		public virtual Gnr_TipoEstadoMotivo MotivoSuspensionSubasta { get; set; }

		public int? IdMotivoSuspensionDecretoSubasta { get; set; }
		[ForeignKey("IdMotivoSuspensionDecretoSubasta")]
		public virtual Gnr_TipoEstadoMotivo MotivoSuspensionDecretoSubasta { get; set; }



		public bool SuspensionDecretoSubasta { get; set; }
		public bool ImpugnacionIntereses { get; set; }
		public bool ImpugnacionCostas { get; set; }
		public decimal? DecretoIntereses { get; set; }
		public decimal? DecretoCostas { get; set; }

        [Display(Name = "Cesión")]
        public SubastaCesionType? Cesion { get; set; }

        #endregion

        #region Properties Computed

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		public DateTime? FechaCelebracionSubasta2o1
		{
			get { return FechaCelebracionSubasta2.HasValue ? FechaCelebracionSubasta2 : FechaCelebracionSubasta1; }
			private set {} //Just need this here to trick EF
		}
		[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		public DateTime? FechaCierrePuja2o1
		{
			get { return FechaCierrePuja2.HasValue ? FechaCierrePuja2 : FechaCierrePuja; }
			private set { } //Just need this here to trick EF
		}
		[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		public bool? SuspendidaCierrePuja2o1
		{
			get
			{
				return 
					FechaCierrePuja2.HasValue ? SuspendidaCierrePuja2 : 					
					SuspendidaCierrePuja1;
			}
			private set { } //Just need this here to trick EF
		}

		[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		public bool? SubastaSuspension2o1
		{
			get
			{
				return
					!SubastaSuspension2.HasValue && !SubastaSuspension.HasValue ? (bool?)null : 
					FechaCelebracionSubasta2.HasValue ? SubastaSuspension2 : 
					SubastaSuspension;
			}
			private set { } //Just need this here to trick EF
		}

		#endregion

		#region Properties virtual

        public virtual Hip_TipoSubasta Hip_TipoSubasta { get; set; }
        public virtual Hip_TipoTitulizado Hip_TipoTitulizado { get; set; }

		#endregion

		#region Properties ReadOnly

		private DateTime? _fechaCelebracionSubasta;
		public DateTime? FechaCelebracionSubasta
		{
			get
			{
				if (!_fechaCelebracionSubasta.HasValue)
					_fechaCelebracionSubasta =
                        FechaCelebracionSubasta2.HasValue
							? FechaCelebracionSubasta2
                            : FechaCelebracionSubasta1.HasValue
								  ? FechaCelebracionSubasta1
                                  : null;

				return _fechaCelebracionSubasta;
			}
		}


		private bool? _suspendida;
		public bool Suspendida
		{
			get
			{
				if (!_suspendida.HasValue)
					_suspendida = SubastaSuspension.HasValue && SubastaSuspension.Value;

				return _suspendida.Value;
			}
		}

		private bool? _titulizada;
		public bool Titulizada
		{
			get
			{
				if (!_titulizada.HasValue)
				{
					_titulizada =
                        ExpedienteEstado != null &&
                        ExpedienteEstado.Expediente != null &&
                        ExpedienteEstado.Expediente.Hip_Expediente != null &&
                        ExpedienteEstado.Expediente.Hip_Expediente.EsTitulizado; // Titulizado.HasValue && Titulizado.Value;
				}
				//_titulizada = Titulizado.HasValue && Titulizado.Value; 

				return _titulizada.Value;
			}
		}

		private bool? _isIva;
		public bool IsIva
		{
			get
			{
				if (!_isIva.HasValue)
					_isIva = AdjudicacionCliente;

				return _isIva.Value;
			}
		}

		#endregion

	}
}
