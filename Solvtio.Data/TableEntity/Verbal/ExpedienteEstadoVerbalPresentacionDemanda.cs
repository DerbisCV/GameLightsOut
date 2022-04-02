using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoVerbalPresentacionDemanda")]
    public class ExpedienteEstadoVerbalPresentacionDemanda : EstadoPresentacionDemandaBase
    {
        #region Constructors

        public ExpedienteEstadoVerbalPresentacionDemanda()
        {
        }
        public ExpedienteEstadoVerbalPresentacionDemanda(int idExpedienteEstado)
        {
            IdExpedienteEstado = idExpedienteEstado;
        }

        #endregion

        #region Properties

        [Key]       
        public int IdExpedienteEstado { get; set; }

        public int IdExpediente { get; set; }

        public DateTime? FechaPagoTasas { get; set; }
        public DateTime? FechaPagoTasasAutomaticas { get; set; }
        public string AdmitidaNoAuto { get; set; }
        public string AdmitidaJuzgado { get; set; }
        public DateTime? NoAdmitidaFecha { get; set; }
        public DateTime? NoAdmitidaFechaApelacion { get; set; }
        public bool? NoAdmitidaApelacion { get; set; }
        public string ParalizadoPor { get; set; }

        #endregion

        #region Properties Readonly

        #endregion

    }
}
