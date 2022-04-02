namespace Solvtio.Models
{
    public partial class Con_ExpedienteCreditoCalificacion
    {
        public int IdExpedienteCreditoCalificacion { get; set; }
        public int IdExpedienteCredito { get; set; }
        public System.DateTime Fecha { get; set; }
        public int IdTipoCalificacionCredito { get; set; }
        public int IdTipoCalificacionCreditoTiempo { get; set; }
        public virtual Con_ExpedienteCredito Con_ExpedienteCredito { get; set; }
        public virtual Con_TipoCalificacion Con_TipoCalificacion { get; set; }
        public virtual Con_TipoCalificacionTiempo Con_TipoCalificacionTiempo { get; set; }
        public virtual TipoCalificacionCreditoTiempo TipoCalificacionCreditoTiempo { get; set; }
        public virtual TipoClasificacionCredito TipoClasificacionCredito { get; set; }
    }
}
