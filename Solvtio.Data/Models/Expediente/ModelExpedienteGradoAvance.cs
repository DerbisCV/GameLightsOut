using System;

namespace Solvtio.Models
{
    public class ModelExpedienteGradoAvance
    {
		#region Constructors

        public ModelExpedienteGradoAvance()
        {
			CreateBase();
        }
        public ModelExpedienteGradoAvance(int? gradoAvance)
        {
            CreateBase();
            GradoAvance = gradoAvance;
        }
        public ModelExpedienteGradoAvance(int? gradoAvance, DateTime? finEstimado)
        {
            CreateBase();
            GradoAvance = gradoAvance;
            FinEstimado = finEstimado;
        }

        private void CreateBase()
		{
 		}

		#endregion

		#region Properties

        public int? GradoAvance { get; set; }
        public DateTime? FinEstimado { get; set; }

        #endregion

        #region Properties ReadOnly 

        #endregion
    }
}
