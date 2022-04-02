using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedientePrelitigio")]
    public partial class ExpedientePrelitigio
    {
        #region Constructors

        public ExpedientePrelitigio()
        {
            CreateBase();
        }

        public ExpedientePrelitigio(int idExpediente)
        {
            IdExpediente = idExpediente;
            CreateBase();
        }

        private void CreateBase()
        {
        }

        #endregion

        #region Properties

        [Key, ForeignKey("Expediente")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int IdExpediente { get; set; }
        public Expediente Expediente { get; set; }


        [DataType(DataType.Date)]
        public DateTime? TituloEjecutivoFechaSolicitud { get; set; }
        [DataType(DataType.Date)]
        public DateTime? TituloEjecutivoFechaObtencion { get; set; }

        public int? TituloEjecutivoIncidenciaId { get; set; }
        [ForeignKey("TituloEjecutivoIncidenciaId")]
        public virtual CaracteristicaBase TituloEjecutivoIncidencia { get; set; }

        public string TituloEjecutivoNota { get; set; }




        [DataType(DataType.Date)]
        public DateTime? BuroFax30FechaSolicitud { get; set; }
        [DataType(DataType.Date)]
        public DateTime? BuroFax30FechaObtencion { get; set; }
        public int? BuroFax30ResultadoId { get; set; }
        [ForeignKey("BuroFax30ResultadoId")]
        public virtual CaracteristicaBase BuroFax30Resultado { get; set; }
        public string BuroFax30Incidencia { get; set; }

        [DataType(DataType.Date)]
        public DateTime? BuroFax10FechaSolicitud { get; set; }
        [DataType(DataType.Date)]
        public DateTime? BuroFax10FechaObtencion { get; set; }
        public int? BuroFax10ResultadoId { get; set; }
        [ForeignKey("BuroFax10ResultadoId")]
        public virtual CaracteristicaBase BuroFax10Resultado { get; set; }
        public string BuroFax10Incidencia { get; set; }




        [DataType(DataType.Date)]
        public DateTime? LiquidacionFechaSolicitud { get; set; }
        [DataType(DataType.Date)]
        public DateTime? LiquidacionFechaObtencion { get; set; }

        public int? LiquidacionIncidenciaId { get; set; }
        [ForeignKey("LiquidacionIncidenciaId")]
        public virtual CaracteristicaBase LiquidacionIncidencia { get; set; }

        public string LiquidacionNota { get; set; }

        [DataType(DataType.Date)]
        public DateTime? CertificadoFechaSolicitud { get; set; }
        [DataType(DataType.Date)]
        public DateTime? CertificadoFechaObtencion { get; set; }
        [DataType(DataType.Date)]
        public DateTime? CertificadoFechaEnvio { get; set; }
        public string CertificadoNota { get; set; }
        public int? IdExpedienteHip { get; set; } //Este deberia dejarlo de usar, en su lugar usaremos IdExpedienteHijo
        public int? IdExpedienteHijo { get; set; }

        public string ReferenciaExternaMACRO { get; set; }
        public int? IdContrato { get; set; }
        public string Cuenta { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaContrato { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaVencimiento { get; set; }

        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        #endregion

        #region Methods

        internal void Refresh(ExpedientePrelitigio modelBase)
        {
            TituloEjecutivoFechaSolicitud = modelBase.TituloEjecutivoFechaSolicitud;
            TituloEjecutivoFechaObtencion = modelBase.TituloEjecutivoFechaObtencion;
            TituloEjecutivoIncidenciaId = modelBase.TituloEjecutivoIncidenciaId;

            //BuroFax30FechaSolicitud = modelBase.BuroFax30FechaSolicitud;
            //BuroFax30FechaObtencion = modelBase.BuroFax30FechaObtencion;
            //BuroFax30ResultadoId = modelBase.BuroFax30ResultadoId;

            //BuroFax10FechaSolicitud = modelBase.BuroFax10FechaSolicitud;
            //BuroFax10FechaObtencion = modelBase.BuroFax10FechaObtencion;
            //BuroFax10ResultadoId = modelBase.BuroFax10ResultadoId;
            //BuroFax30Incidencia = modelBase.BuroFax30Incidencia;
            //BuroFax10Incidencia = modelBase.BuroFax10Incidencia;

            LiquidacionFechaSolicitud = modelBase.LiquidacionFechaSolicitud;
            LiquidacionFechaObtencion = modelBase.LiquidacionFechaObtencion;
            LiquidacionIncidenciaId = modelBase.LiquidacionIncidenciaId;

            CertificadoFechaSolicitud = modelBase.CertificadoFechaSolicitud;
            CertificadoFechaObtencion = modelBase.CertificadoFechaObtencion;
            CertificadoFechaEnvio = modelBase.CertificadoFechaEnvio;

            TituloEjecutivoNota = modelBase.TituloEjecutivoNota;

            LiquidacionNota = modelBase.LiquidacionNota;
            CertificadoNota = modelBase.CertificadoNota;

            ReferenciaExternaMACRO = modelBase.ReferenciaExternaMACRO;
            IdContrato = modelBase.IdContrato;
            Cuenta = modelBase.Cuenta;
            FechaContrato = modelBase.FechaContrato;
            FechaVencimiento = modelBase.FechaVencimiento;
        }

        #endregion
    }
}
