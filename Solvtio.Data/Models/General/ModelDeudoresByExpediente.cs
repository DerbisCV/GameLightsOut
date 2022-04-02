using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelDeudoresByExpediente
    {
        #region Constructors

		public ModelDeudoresByExpediente() 
        {
            CreateBase();
        }
        public ModelDeudoresByExpediente(int idExpediente, string title)
        {
            CreateBase();
            IdExpediente = idExpediente;
            Title = title;
        }

        private void CreateBase()
        {
            LstExpedienteDeudor = new List<ExpedienteDeudor>();
        }

        #endregion

        #region Properties

        public int IdExpediente { get; set; }
        public string Title { get; set; }

        public List<ExpedienteDeudor> LstExpedienteDeudor { get; set; }

        #endregion

        #region ReagOnly Properties
        #endregion

        #region Methods
        #endregion
    }
}
