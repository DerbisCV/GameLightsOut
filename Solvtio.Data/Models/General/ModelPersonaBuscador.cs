using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelPersonaBuscador
    {
        #region Constructors

		public ModelPersonaBuscador() 
        {
            createBase();
        }
        public ModelPersonaBuscador(ModelFilterBase filter)
        {
            createBase();
            Filter = filter;
        }

        private void createBase()
        {
            Filter = new ModelFilterBase();
            LstPersonas = new List<Gnr_Persona>();
        }

        #endregion

        #region Properties

        public ModelFilterBase Filter { get; set; }
  
        public List<Gnr_Persona> LstPersonas { get; set; }
        public List<Gnr_Abogado> LstAbogados { get; set; }

        #endregion

        #region ReagOnly Properties
        #endregion

        #region Methods
        #endregion
    }
}
