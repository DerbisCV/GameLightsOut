using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("IdPersona")]
        public virtual Gnr_Persona Gnr_Persona { get; set; }

        public string EnvioDemandas { get; set; }
        public int? IdPartidoJudicial { get; set; }

        public virtual ICollection<Expediente> Expedientes { get; set; }
		public virtual ICollection<ProcuradorPartidoJudicial> PartidoJudicialSet { get; set; }

        #endregion

        #region Properties Readonly

        public int Id => IdPersona;

        //private string _nombre;
        public string Nombre => Gnr_Persona?.NombreApellidos;
        //{
        //    get
        //    {
        //        if (string.IsNullOrEmpty(_nombre))
        //        {
        //            //var tratamiento = Gnr_Persona.IdTipoTratamiento != null ? Gnr_Persona.Gnr_TipoTratamiento.Descripcion : string.Empty;
        //            _nombre =
        //                $"{Gnr_Persona.Nombre ?? string.Empty} {Gnr_Persona.Apellidos ?? string.Empty}".Trim();
        //        }

        //        return _nombre;
        //    }
        //}

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
