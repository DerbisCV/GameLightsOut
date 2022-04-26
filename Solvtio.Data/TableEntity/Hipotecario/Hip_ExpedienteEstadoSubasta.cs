using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public class Hip_ExpedienteEstadoSubasta : ExpedienteEstadoSubastaBase
    {
		#region Constructors

		public Hip_ExpedienteEstadoSubasta()
		{
            TipoModeloSubastaId = 1;
            SubastaSuspension = Postores = Titulizado = AdjudicacionCliente = Oposicion = Consignar = IVA = false;
		}

		#endregion

		#region Properties

		public int ExpedienteEstadoId { get; set; }

		[ForeignKey("ExpedienteEstadoId")]
		public virtual ExpedienteEstado ExpedienteEstado { get; set; }
        
		public DateTime? FechaSolicitudSubasta { get; set; }
        public int TipoModeloSubastaId { get; set; }
        public int? DocumentoSolicitudSubastaId { get; set; }
        public int? DocumentoCelebracionSubastaId1 { get; set; }
        public bool? SubastaSuspension { get; set; }
        public DateTime? FechaCelebracionSubasta1 { get; set; }
        public DateTime? FechaCelebracionSubasta2 { get; set; }
        public int? DocumentoCelebracionSubastaId2 { get; set; }
        public DateTime? FechaResultadoSubasta { get; set; }
        public DateTime? FechaAdjudicacion { get; set; }
        public int? DocumentoActaSubastaId { get; set; }
        public bool Titulizado { get; set; }
        public int? DocumentoCesionRemateId { get; set; }
        public int? DocumentoMandamientoPagoId { get; set; }
        public bool AdjudicacionCliente { get; set; }
        public int? DocumentoLiquidacionInteresesId { get; set; }
        public string MotivoSuspension { get; set; }
        public bool Oposicion { get; set; }
        public DateTime? OposicionFecha { get; set; }
        public int? OposicionDocumentoId { get; set; }
        public DateTime? OposicionVistaFecha { get; set; }
        public int? OposicionVistaDocumentoId { get; set; }
        public DateTime? OposicionResolucionFecha { get; set; }
        public int? OposicionResolucionDocumentoId { get; set; }
        public DateTime? AutorizadoEnvioGestor { get; set; }
        public int? IdTipoTitulizado { get; set; }
        public string Nota { get; set; }
        public string Autorizado { get; set; }
        public DateTime? FechaBoe { get; set; }
        public DateTime? FechaAperturaSubasta { get; set; }
        public bool? SubastaSuspension2 { get; set; }
        public bool PublicadoBoe { get; set; }
        
        #endregion

        #region Properties Computed

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		public DateTime? FechaCelebracionSubasta2o1
		{
			get { return FechaCelebracionSubasta2.HasValue ? FechaCelebracionSubasta2 : FechaCelebracionSubasta1; }
			private set {} //Just need this here to trick EF
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

		//public virtual ExpedienteDocumento ExpedienteDocumento { get; set; }
		//      public virtual ExpedienteDocumento ExpedienteDocumento1 { get; set; }
		//      public virtual ExpedienteDocumento ExpedienteDocumento2 { get; set; }
		//      public virtual ExpedienteDocumento ExpedienteDocumento3 { get; set; }
		//      public virtual ExpedienteDocumento ExpedienteDocumento4 { get; set; }
		//      public virtual ExpedienteDocumento ExpedienteDocumento5 { get; set; }
		//      public virtual ExpedienteDocumento ExpedienteDocumento6 { get; set; }
		//      public virtual ExpedienteDocumento ExpedienteDocumento7 { get; set; }
		//      public virtual ExpedienteDocumento ExpedienteDocumento8 { get; set; }
		//      public virtual ExpedienteDocumento ExpedienteDocumento9 { get; set; }

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
