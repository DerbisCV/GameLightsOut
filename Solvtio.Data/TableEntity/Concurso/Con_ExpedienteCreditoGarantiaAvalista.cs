namespace Solvtio.Models
{
    public partial class Con_ExpedienteCreditoGarantiaAvalista
    {
        public int IdExpedienteCreditoGarantiaAvalista { get; set; }
        public int IdExpedienteCredito { get; set; }
        public int IdPersona { get; set; }
        public int IdTipoDeudor { get; set; }
        public virtual Con_ExpedienteCredito Con_ExpedienteCredito { get; set; }
        public virtual Gnr_Persona Gnr_Persona { get; set; }
        public virtual Gnr_TipoDeudor Gnr_TipoDeudor { get; set; }
    }
}
