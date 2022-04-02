namespace Solvtio.Models
{
    public class ModelExpedienteRelacionados
    {
        #region Constructors

        public ModelExpedienteRelacionados()
        {
            CreateBase();
        }
        public ModelExpedienteRelacionados(int? idExpediente1, int? idExpediente2)
        {
            CreateBase();
            IdExpediente1 = idExpediente1;
            IdExpediente2 = idExpediente2;
        }

        private void CreateBase()
        {
        }

        #endregion

        #region Properties

        public int? IdExpediente1 { get; set; }
        public int? IdExpediente2 { get; set; }

        public string NoExpediente1 { get; set; }
        public string NoExpediente2 { get; set; }

        public Expediente Expediente1 { get; set; }
        public Expediente Expediente2 { get; set; }

        public string UserName { get; set; }
        public string Error { get; set; }

        #endregion

        #region Properties ReadOnly 

        #endregion
    }
}
