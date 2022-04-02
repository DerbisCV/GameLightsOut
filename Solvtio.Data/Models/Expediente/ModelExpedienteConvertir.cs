namespace Solvtio.Models
{
    public class ModelExpedienteConvertir : ModelBase
    {
        #region Constructors
        public ModelExpedienteConvertir(int idExpediente, TipoExpedienteEnum tipoExpediente)
        {
            CreateBase();
            IdExpediente = idExpediente;
            TipoExpediente = tipoExpediente;
        }

        private void CreateBase()
        {
        }

        #endregion

        #region Properties
        public int IdExpediente { get; set; }
        public TipoExpedienteEnum TipoExpediente { get; set; }

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
