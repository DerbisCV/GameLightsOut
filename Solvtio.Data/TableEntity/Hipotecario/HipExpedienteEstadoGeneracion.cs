using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("HipExpedienteEstadoGeneracion")]
    public class HipExpedienteEstadoGeneracion : EstadoBase
    {
        #region Constructors

        public HipExpedienteEstadoGeneracion()
        {
        }
        public HipExpedienteEstadoGeneracion(int idExpediente)
        {
            IdExpediente = idExpediente;
        }

        #endregion

        #region Properties

        public int IdExpediente { get; set; }

        public DateTime? TituloEjecutivoFechaSolicitud { get; set; }
        public DateTime? TituloEjecutivoFechaObtencion { get; set; }
        public int? TituloEjecutivoIncidenciaId { get; set; }
        [ForeignKey("TituloEjecutivoIncidenciaId")]
        public virtual CaracteristicaBase TituloEjecutivoIncidencia { get; set; }
        public string TituloEjecutivoNota { get; set; }

        public DateTime? BuroFax30FechaSolicitud { get; set; }
        public DateTime? BuroFax30FechaObtencion { get; set; }
        public int? BuroFax30ResultadoId { get; set; }
        [ForeignKey("BuroFax30ResultadoId")]
        public virtual CaracteristicaBase BuroFax30Resultado { get; set; }
        public string BuroFax30Incidencia { get; set; }


        public DateTime? BuroFax10FechaSolicitud { get; set; }
        public DateTime? BuroFax10FechaObtencion { get; set; }
        public int? BuroFax10ResultadoId { get; set; }
        [ForeignKey("BuroFax10ResultadoId")]
        public virtual CaracteristicaBase BuroFax10Resultado { get; set; }
        public string BuroFax10Incidencia { get; set; }


        public DateTime? LiquidacionFechaSolicitud { get; set; }
        public DateTime? LiquidacionFechaObtencion { get; set; }
        public int? LiquidacionIncidenciaId { get; set; }
        [ForeignKey("LiquidacionIncidenciaId")]
        public virtual CaracteristicaBase LiquidacionIncidencia { get; set; }
        public string LiquidacionNota { get; set; }

        public DateTime? CertificadoFechaSolicitud { get; set; }
        public DateTime? CertificadoFechaObtencion { get; set; }
        public DateTime? CertificadoFechaEnvio { get; set; }
        public string CertificadoNota { get; set; }

        #endregion

        #region Methods

        internal void RefreshBy(HipExpedienteEstadoGeneracion modelBase)
        {
            TituloEjecutivoFechaSolicitud = modelBase.TituloEjecutivoFechaSolicitud;
            TituloEjecutivoFechaObtencion = modelBase.TituloEjecutivoFechaObtencion;
            TituloEjecutivoIncidenciaId = modelBase.TituloEjecutivoIncidenciaId;

            BuroFax30FechaSolicitud = modelBase.BuroFax30FechaSolicitud;
            BuroFax30FechaObtencion = modelBase.BuroFax30FechaObtencion;
            BuroFax30ResultadoId = modelBase.BuroFax30ResultadoId;

            BuroFax10FechaSolicitud = modelBase.BuroFax10FechaSolicitud;
            BuroFax10FechaObtencion = modelBase.BuroFax10FechaObtencion;
            BuroFax10ResultadoId = modelBase.BuroFax10ResultadoId;

            LiquidacionFechaSolicitud = modelBase.LiquidacionFechaSolicitud;
            LiquidacionFechaObtencion = modelBase.LiquidacionFechaObtencion;
            LiquidacionIncidenciaId = modelBase.LiquidacionIncidenciaId;

            CertificadoFechaSolicitud = modelBase.CertificadoFechaSolicitud;
            CertificadoFechaObtencion = modelBase.CertificadoFechaObtencion;
            CertificadoFechaEnvio = modelBase.CertificadoFechaEnvio;

            TituloEjecutivoNota = modelBase.TituloEjecutivoNota;
            BuroFax30Incidencia = modelBase.BuroFax30Incidencia;
            BuroFax10Incidencia = modelBase.BuroFax10Incidencia;
            LiquidacionNota = modelBase.LiquidacionNota;
            CertificadoNota = modelBase.CertificadoNota;
        }

        #endregion
    }
}
