using Solvtio.Models;
using System;

namespace Solvtio.Data.Models.Dtos
{
    public class ExpedienteNotaDto
    {
        #region Properties

        public int IdExpedienteNota { get; set; }
        public int IdExpediente { get; set; }        
        public int? IdExpedienteEstado { get; set; }
        public int? IdFase { get; set; }
        public int? IdSubfase { get; set; }
        public string Nota { get; set; }
        public NoteType NoteType { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }

        #endregion
    }
}
