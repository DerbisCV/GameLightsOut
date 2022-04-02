using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    //[Table("ExpedienteEstadoVerbalTramitacionJuzgado")]
    //public class ExpedienteEstadoVerbalTramitacionJuzgado
    //{
    //    #region Constructors

    //    public ExpedienteEstadoVerbalTramitacionJuzgado()
    //    {
    //    }
    //    public ExpedienteEstadoVerbalTramitacionJuzgado(int idExpedienteEstado)
    //    {
    //        IdExpedienteEstado = idExpedienteEstado;
    //    }

    //    #endregion

    //    #region Properties

    //    [Key]
    //    [ForeignKey("ExpedienteEstado")]
    //    public int IdExpedienteEstado { get; set; }
    //    public virtual ExpedienteEstado ExpedienteEstado { get; set; }
    //    public int IdExpediente { get; set; }


    //    public DateTime? AdmitidaFecha { get; set; }
    //    public DateTime? FechaAutoSubsanado { get; set; }
    //    public DateTime? FechaCertificacionCargas { get; set; }
    //    public DateTime? FechaVistaOcupantes { get; set; }

    //    public int? IdAbogadoVista { get; set; }
    //    [ForeignKey("IdAbogadoVista")]
    //    public virtual Gnr_Abogado Gnr_Abogado { get; set; }

    //    public DateTime? FechaSentencia2 { get; set; }

    //    #endregion

    //    #region Properties Oposicion

    //    public bool Oposicion { get; set; }
    //    public DateTime? OposicionFechaLanzamientoInicial { get; set; }
    //    public DateTime? OposicionFecha { get; set; }
    //    public DateTime? OposicionFechaDecretoFin { get; set; }
    //    public DateTime? OposicionFechaSentencia { get; set; }
    //    public DateTime? OposicionFechaRecursoApelacion { get; set; }
    //    public DateTime? OposicionFechaNulidadActuaciones { get; set; }
    //    public DateTime? OposicionVistaFecha { get; set; }
    //    public DateTime? OposicionSuspensionVista { get; set; }
    //    public DateTime? OposicionFechaSuspension60Dias { get; set; }
    //    public int? OposicionSentenciaResultado { get; set; }

    //    #endregion

    //    #region Properties Suspensión

    //    public DateTime? SuspensionFecha { get; set; }
    //    public bool SuspensionAjg { get; set; }
    //    public bool SuspensionPendienteAcuerdo { get; set; }
    //    public bool SuspensionInstruccionesCliente { get; set; }
    //    public string SuspensionObservaciones { get; set; }

    //    public int? IdMotivoSuspension { get; set; }
    //    [ForeignKey("IdMotivoSuspension")]
    //    public virtual Gnr_TipoEstadoMotivo MotivoSuspension { get; set; }

    //    #endregion

    //    #region Properties Apelacion

    //    public DateTime? ApelacionFecha { get; set; }
    //    public int? ApelacionPor { get; set; }
    //    public int? ApelacionResultado { get; set; }

    //    #endregion

    //    #region virtual ICollection

    //    //public virtual ICollection<Alq_Expediente_EstadoTramitaJuzgado_Actuacion> Alq_Expediente_EstadoTramitaJuzgado_Actuaciones { get; set; }

    //    #endregion




    //    #region Properties Readonly
    //    #endregion



    //}
}
