using System;

namespace Solvtio.Models
{
    public class Ejc_ExpedienteEstadoSubasta : ExpedienteEstadoSubastaBase
    {
        #region Constructors

        public Ejc_ExpedienteEstadoSubasta()
        {
            //TipoModeloSubastaId = 1;
            SubastaSuspension = Postores = 
                //Titulizado = AdjudicacionCliente = 
                Oposicion = Consignar = IVA = false;
        }

        #endregion

        #region Properties

        public int IdExpedienteEstado { get; set; }
        public int IdExpediente { get; set; }
        public DateTime? FechaCelebracion1 { get; set; }
        public DateTime? FechaCelebracion2 { get; set; }
        public string Autorizados { get; set; }
        public bool SubastaSuspension { get; set; }
        public string SubastaSuspensionMotivo { get; set; }

        public bool Oposicion { get; set; }
        public DateTime? OposicionFecha { get; set; }
        public DateTime? OposicionFechaVista { get; set; }
        public DateTime? OposicionFechaResolucion { get; set; }
        public int? IdDocumentoCelebracion1 { get; set; }
        public int? IdDocumentoCelebracion2 { get; set; }
        public int? IdDocumentoActaSubasta { get; set; }
        public int? IdDocumentoMandamientoPago { get; set; }
        public int? IdDocumentoCesionRemate { get; set; }
        public int? IdDocumentoLiquidacionIntereses { get; set; }
        public int? IdDocumentoOposicion { get; set; }
        public int? IdDocumentoOposicionSenalamientoVista { get; set; }
        public int? IdDocumentoOposicionResolucion { get; set; }

        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        #endregion

    }
}
