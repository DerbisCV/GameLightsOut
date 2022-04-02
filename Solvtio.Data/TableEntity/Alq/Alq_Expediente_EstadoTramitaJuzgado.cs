using Solvtio.Models.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public class Alq_Expediente_EstadoTramitaJuzgado
    {
        #region Contructors

        public Alq_Expediente_EstadoTramitaJuzgado()
        {
            Alq_Expediente_EstadoTramitaJuzgado_Actuaciones = new List<Alq_Expediente_EstadoTramitaJuzgado_Actuacion>();
        }

        #endregion

        #region Properties Others

        public int IdExpedienteEstado { get; set; }
        [ForeignKey("IdExpedienteEstado")]
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public DateTime? AdmitidaFecha { get; set; }
        public DateTime? FechaAutoSubsanado { get; set; }
        public DateTime? FechaCertificacionCargas { get; set; }
        public DateTime? FechaVistaOcupantes { get; set; }

        //public bool MediacionSocial { get; set; }
        //public bool NegociacionAlquiler { get; set; }



        public int? IdAbogadoVista { get; set; }
        [ForeignKey("IdAbogadoVista")]
        public virtual Gnr_Abogado Gnr_Abogado { get; set; }

        public DateTime? FechaSentencia2 { get; set; }
        //public DateTime? FechaNotificacionDemandado { get; set; }

        #endregion

        #region Properties Oposicion

        public bool Oposicion { get; set; }
        public DateTime? OposicionFechaLanzamientoInicial { get; set; }
        public DateTime? OposicionFecha { get; set; }
        public DateTime? OposicionFechaDecretoFin { get; set; }
        public DateTime? OposicionFechaSentencia { get; set; }
        public DateTime? OposicionFechaRecursoApelacion { get; set; }
        public DateTime? OposicionFechaNulidadActuaciones { get; set; }
        public int? DocumentoCertificacionCargasId { get; set; }
        public int? DocumentoDecretoAdmision { get; set; }
        public DateTime? OposicionVistaFecha { get; set; }
        public DateTime? OposicionSuspensionVista { get; set; }
        public DateTime? OposicionFechaSuspension60Dias { get; set; }
        public int? OposicionSentenciaResultado { get; set; }

        #endregion

        #region Properties Suspensión

        public DateTime? SuspensionFecha { get; set; }
        public bool SuspensionAjg { get; set; }
        public bool SuspensionPendienteAcuerdo { get; set; }
        public bool SuspensionInstruccionesCliente { get; set; }
        public string SuspensionObservaciones { get; set; }

        public int? IdMotivoSuspension { get; set; }
        [ForeignKey("IdMotivoSuspension")]
        public virtual Gnr_TipoEstadoMotivo MotivoSuspension { get; set; }

        #endregion

        #region Properties Apelacion

        public DateTime? ApelacionFecha { get; set; }
        public int? ApelacionPor { get; set; }
        public int? ApelacionResultado { get; set; }

        #endregion

        #region virtual ICollection

        public virtual ICollection<Alq_Expediente_EstadoTramitaJuzgado_Actuacion> Alq_Expediente_EstadoTramitaJuzgado_Actuaciones { get; set; }

        #endregion








        public virtual ExpedienteDocumento ExpedienteDocumento { get; set; }
        public virtual ExpedienteDocumento ExpedienteDocumento1 { get; set; }

        #region Properties NotMapped

        private TramitacionJuzgadoSentenciaResultado? _sentenciaResultado;
        [NotMapped]
        public TramitacionJuzgadoSentenciaResultado? SentenciaResultado
        {
            get
            {
                _sentenciaResultado = (TramitacionJuzgadoSentenciaResultado)1;
                if (!_sentenciaResultado.HasValue && OposicionSentenciaResultado.HasValue)
                {
                    _sentenciaResultado = (TramitacionJuzgadoSentenciaResultado)(OposicionSentenciaResultado.Value);
                }

                return _sentenciaResultado;
            }
            set
            {
                _sentenciaResultado = value;
                OposicionSentenciaResultado = (int)value;
            }
        }

        #endregion

    }
}
