using Solvtio.Models.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("AlqExpedienteEstadoTramitacionDenuncia")]
    public class AlqExpedienteEstadoTramitacionDenuncia
    {
        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("ExpedienteEstado")]
        public int IdExpedienteEstado { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public int IdExpediente { get; set; }

        public DateTime? FechaAutoConclusion { get; set; }

        public DateTime? AdmitidaFecha { get; set; }
        public DateTime? AdmitidaFechaAutoSubsanado { get; set; }
        public int? IdAbogadoVista { get; set; }
        [ForeignKey("IdAbogadoVista")]
        public virtual Gnr_Abogado AbogadoVista { get; set; }

        public DateTime? FechaEscritoDefensa { get; set; }
        public DateTime? FechaEscritoAcusacion { get; set; }
        public DateTime? FechaEscritoAcusacionMf { get; set; }
        public DateTime? FechaSentencia1 { get; set; }
        public DateTime? FechaSentencia2 { get; set; }
        public int? IdSentenciaResultado { get; set; }
        public DateTime? FechaRecursoApelacion { get; set; }
        public DateTime? FechaNulidadActuaciones { get; set; }

        public DateTime? SuspensionFecha { get; set; }
        public bool SuspensionAjg { get; set; }
        public bool SuspensionPendienteAcuerdo { get; set; }
        public bool SuspensionInstruccionesCliente { get; set; }
        public string SuspensionObservaciones { get; set; }

        public int? IdMotivoSuspension { get; set; }
        [ForeignKey("IdMotivoSuspension")]
        public virtual Gnr_TipoEstadoMotivo MotivoSuspension { get; set; }

        public DateTime? ApelacionFecha { get; set; }
        public int? IdApelacionPor { get; set; }
        public int? IdApelacionResultado { get; set; }

        public DateTime? DiligenciaPreviaFechaAutoApertura { get; set; }
        public DateTime? DiligenciaPreviaOficioFechaEnvio { get; set; }
        public DateTime? DiligenciaPreviaOficioFechaRecepcion  { get; set; }
        public string DiligenciaPreviaOficioObservaciones { get; set; }

        #endregion

    }
}
