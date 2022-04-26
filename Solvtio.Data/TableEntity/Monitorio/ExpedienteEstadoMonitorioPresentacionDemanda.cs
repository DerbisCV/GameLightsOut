using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoMonitorioPresentacionDemanda")]
    public class ExpedienteEstadoMonitorioPresentacionDemanda : EstadoPresentacionDemandaBase
    {
        #region Constructors

        public ExpedienteEstadoMonitorioPresentacionDemanda()
        {
        }
        public ExpedienteEstadoMonitorioPresentacionDemanda(int idExpedienteEstado)
        {
            IdExpedienteEstado = idExpedienteEstado;
        }

        #endregion

        #region Properties



        public int IdExpediente { get; set; }

        public DateTime? FechaPagoTasas { get; set; }


        public DateTime? AdmitidaFecha { get; set; }
        public string AdmitidaNoAuto { get; set; }
        public string AdmitidaJuzgado { get; set; }
        public DateTime? NoAdmitidaFecha { get; set; }
        public DateTime? NoAdmitidaFechaApelacion { get; set; }
        public bool NoAdmitidaApelacion { get; set; }

        public DateTime? NoAdmitidaFechaResultadoApelacion { get; set; }
        public int? NoAdmitidaResultadoApelacionId { get; set; }

        #endregion

        #region Properties Readonly

        #endregion

    }
}
