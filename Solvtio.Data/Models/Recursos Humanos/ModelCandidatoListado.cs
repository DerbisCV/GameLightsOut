using Solvtio.Models;
using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelCandidatoListado
    {
        #region Constructor
        public ModelCandidatoListado()
        {
            createBase();
        }

        public ModelCandidatoListado(ModelFilterBase filter)
        {
            createBase();
            Filter = filter;
        }

        private void createBase()
        {
            Filter = new ModelFilterBase();
            LstCandidatos = new List<Candidato>();
        }
        #endregion

        #region Properties

        public ModelFilterBase Filter { get; set; }
        public List<Candidato> LstCandidatos { get; set; }

        #endregion
    }
}
