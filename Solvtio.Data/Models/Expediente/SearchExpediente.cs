namespace Solvtio.Models
{
    public class SearchExpediente
    {
        #region Constructors
        public SearchExpediente() {}

        public SearchExpediente(Expediente exp) : this()
        {
        }

        #endregion

        #region Properties

        //public int IdExpediente { get; set; }
        //public string NoExpediente { get; set; }
        //public string ReferenciaExterna { get; set; }
        //public TipoExpedienteEnum TipoExpediente { get; set; }
        ////public ModelClienteOficina ClienteOficina { get; set; }
        ////public ModelPersona DeudorPrincipal { get; set; }
        ////public DateTime FechaAlta { get; set; }
        ////public ModelMoney Importe { get; set; }
        ////public ModelTipoEstado TipoEstadoActual { get; set; }
        //public string ClienteOficina { get; set; }

        #endregion

        #region Properties ReadOnly
        //private int? _subastasSenaladasTotal;
        //public int SubastasSenaladasTotal
        //{
        //    get
        //    {
        //        if (!_subastasSenaladasTotal.HasValue)
        //            _subastasSenaladasTotal = this.LstResumenMes.Sum(x => x.SubastasSenaladas);

        //        return _subastasSenaladasTotal.Value;
        //    }
        //}
        #endregion
    }
}
