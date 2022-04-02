using System.Collections.Generic;

namespace Solvtio.Models
{
    public class Gnr_Procurador : IGnrPersona
    {
        #region Constructors

        public Gnr_Procurador()
        {
            Expedientes = new List<Expediente>();
			PartidoJudicialSet = new List<ProcuradorPartidoJudicial>();
        }

        #endregion

        #region Properties

        public int IdPersona { get; set; }
		public virtual Gnr_Persona Gnr_Persona { get; set; }

        public string EnvioDemandas { get; set; }
        public int? IdPartidoJudicial { get; set; }

        public virtual ICollection<Expediente> Expedientes { get; set; }
		public virtual ICollection<ProcuradorPartidoJudicial> PartidoJudicialSet { get; set; }

        #endregion

        #region Properties Readonly

        private string _nombreCompleto;
        public string NombreCompleto
        {
            get
            {
                if (string.IsNullOrEmpty(_nombreCompleto))
                {
                    var tratamiento = Gnr_Persona.IdTipoTratamiento != null ? Gnr_Persona.Gnr_TipoTratamiento.Descripcion : string.Empty;
                    _nombreCompleto =
                        $"{tratamiento} {Gnr_Persona.Nombre ?? string.Empty} {Gnr_Persona.Apellidos ?? string.Empty}".Trim();
                }

                return _nombreCompleto;
            }
        }

        private string _tipoProcurador;
        public string TipoProcurador
        {
            get
            {
                if (string.IsNullOrEmpty(_tipoProcurador))
                    _tipoProcurador = $"Procurador{(Gnr_Persona.IdTipoTratamiento != null && Gnr_Persona.IdTipoTratamiento == 2 ? "a" : string.Empty)}";

                return _tipoProcurador;
            }
        }

        #endregion
    }


}
