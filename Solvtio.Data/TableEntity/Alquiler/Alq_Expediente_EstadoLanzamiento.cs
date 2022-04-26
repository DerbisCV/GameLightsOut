using System;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    public partial class Alq_Expediente_EstadoLanzamiento
    {
        #region Properties

        public int IdExpedienteEstado { get; set; }
        [ForeignKey("IdExpedienteEstado")]
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public DateTime? FechaSolicitudLanzamiento { get; set; }
        public DateTime? FechaLanzamientoAdminita { get; set; }
        public DateTime? FechaLanzamientoNoAdminita { get; set; }
        public DateTime? FechaRecuperacion { get; set; }

        public DateTime? OposicionFecha { get; set; }
        public DateTime? OposicionFechaImpugnacion { get; set; }

        public string Autorizado { get; set; }
        public DateTime? FechaEnvioInstruccionesProcurador { get; set; }
        public bool Oposicion { get; set; }
        public DateTime? OposicionVistaFecha { get; set; }
        public DateTime? OposicionResolucionFecha { get; set; }





        public DateTime? LanzamientoFecha1 { get; set; }
        public DateTime? LanzamientoFecha2 { get; set; }
        public PositivoNegativoType? LanzamientoResultado1 { get; set; }
        public PositivoNegativoType? LanzamientoResultado2 { get; set; }
        public bool LanzamientoSuspension1 { get; set; }
        public bool LanzamientoSuspension2 { get; set; }
        public DateTime? LanzamientoSuspensionFecha1 { get; set; }
        public DateTime? LanzamientoSuspensionFecha2 { get; set; }
        public string LanzamientoMotivoSuspension1 { get; set; }
        public string LanzamientoMotivoSuspension2 { get; set; }

        public bool Tpa { get; set; }
        public DateTime? PosesionFechaRecepcion { get; set; }

        #endregion

        #region Properties ExpedienteDocumento OLD
        //public virtual ExpedienteDocumento ExpedienteDocumentoActa { get; set; }
        //public virtual ExpedienteDocumento ExpedienteDocumentoCelebracion1 { get; set; }
        //public virtual ExpedienteDocumento ExpedienteDocumentoCelebracion2 { get; set; }
        //public virtual ExpedienteDocumento ExpedienteDocumento3 { get; set; }
        //public virtual ExpedienteDocumento ExpedienteDocumento4 { get; set; }
        //public virtual ExpedienteDocumento ExpedienteDocumento5 { get; set; }
        //public virtual ExpedienteDocumento ExpedienteDocumento6 { get; set; }
        //public virtual ExpedienteDocumento ExpedienteDocumento7 { get; set; }
        //public virtual ExpedienteDocumento ExpedienteDocumento8 { get; set; }
        //public virtual ExpedienteDocumento ExpedienteDocumento9 { get; set; }

        public int? DocumentoSolicitudLanzamientoId { get; set; }
        public int? DocumentoCelebracionLanzamientoId1 { get; set; }
        public int? DocumentoCelebracionLanzamientoId2 { get; set; }
        public int? DocumentoActaLanzamientoId { get; set; }
        public int? DocumentoMandamientoPagoId { get; set; }
        public int? DocumentoCesionRemateId { get; set; }
        public int? DocumentoLiquidacionInteresesId { get; set; }
        public int? OposicionDocumentoId { get; set; }
        public int? OposicionVistaDocumentoId { get; set; }
        public int? OposicionResolucionDocumentoId { get; set; }
        #endregion

        #region Methods

        internal void RefreshBy(Alq_Expediente_EstadoLanzamiento model)
        {

            FechaSolicitudLanzamiento = model.FechaSolicitudLanzamiento;
            FechaLanzamientoAdminita = model.FechaLanzamientoAdminita;
            FechaLanzamientoNoAdminita = model.FechaLanzamientoNoAdminita;
            OposicionFecha = model.OposicionFecha;
            OposicionFechaImpugnacion = model.OposicionFechaImpugnacion;
            FechaRecuperacion = model.FechaRecuperacion;
            //LanzamientoFecha2 = model.LanzamientoFecha2;

            #region OLD

            LanzamientoFecha2 = model.LanzamientoFecha2;
            Oposicion = model.Oposicion;
            OposicionVistaFecha = model.OposicionVistaFecha;
            OposicionResolucionFecha = model.OposicionResolucionFecha;
            LanzamientoFecha1 = model.LanzamientoFecha1;
            LanzamientoFecha2 = model.LanzamientoFecha2;
            LanzamientoResultado1 = model.LanzamientoResultado1;
            LanzamientoResultado2 = model.LanzamientoResultado2;
            LanzamientoSuspension1 = model.LanzamientoSuspension1;
            LanzamientoSuspension2 = model.LanzamientoSuspension2;
            LanzamientoSuspensionFecha1 = model.LanzamientoSuspensionFecha1;
            LanzamientoSuspensionFecha2 = model.LanzamientoSuspensionFecha2;
            LanzamientoMotivoSuspension1 = model.LanzamientoMotivoSuspension1;
            LanzamientoMotivoSuspension2 = model.LanzamientoMotivoSuspension2;
            Tpa = model.Tpa;
            PosesionFechaRecepcion = model.PosesionFechaRecepcion;

            #endregion
        }

        #endregion

    }
}
