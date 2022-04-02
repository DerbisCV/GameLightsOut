using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelExpedienteNota
    {
        #region Constructors

		public ModelExpedienteNota() 
        {
            CreateBase();
        }
        public ModelExpedienteNota(int? idExpediente, NoteType? noteType, int? idExpedienteEstado)
        {
            CreateBase();
            IdExpediente = idExpediente;
            IdExpedienteEstado = idExpedienteEstado;
            NoteType = noteType;
        }

        private void CreateBase()
        {
            LstExpedienteNota = new List<ExpedienteNota>();
        }

        #endregion

        #region Properties

        public int? IdExpediente { get; set; }
        public int? IdExpedienteEstado { get; set; }
        public NoteType? NoteType { get; set; }
        public List<ExpedienteNota> LstExpedienteNota { get; set; }

        #endregion

        #region ReagOnly Properties
        #endregion

        #region Methods
        #endregion
    }
}
