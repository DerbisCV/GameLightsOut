using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelNomencladorAll
    {
		#region Constructors
		public ModelNomencladorAll() 
		{
			CreateBase();
		}
		public ModelNomencladorAll(ModelFilterBase filter)
        {
			CreateBase();
            Filter = filter;
        }

		private void CreateBase()
		{
			Filter = new ModelFilterBase();
		}
        #endregion

        #region Properties 

        public ModelFilterBase Filter { get; set; }

        public List<Gnr_Cliente> LstCliente { get; set; }
        public List<Gnr_ClienteOficina> LstClienteOficina { get; set; }
        public List<Pagador> LstPagador { get; set; }
        public List<Gnr_Procurador> LstProcurador { get; set; }
	    public List<PartidoJudicial> LstPartidoJudicial { get; set; }
        public List<CaracteristicaBase> LstCaracteristicaBase { get; set; }
        public List<Sla> LstSla { get; set; }
        public List<Contacto> LstContacto { get; set; }
        public List<Oportunidad> LstOportunidad { get; set; }
        public List<Tarea> LstTarea { get; set; }
        public List<Juzgado> LstJuzgado { get; set; }
        public List<TipoSubFaseEstado> LstTipoSubFaseEstado { get; set; }
        public List<TipoIncidenciaEstado> LstTipoIncidenciaEstado { get; set; }
        public List<Cartera> LstCartera { get; set; }
        public List<Comite> LstComite { get; set; }
        public List<EntidadGestora> LstEntidadGestora { get; set; }
        public List<ServicioBufete> LstServicioBufete { get; set; }
        public List<ClienteServicioBufete> LstClienteServicioBufete { get; set; }
        
        public List<CarteraInmobiliaria> LstCarteraInmobiliaria { get; set; }
        public List<TipoHitoProcesal> LstTipoHitoProcesal { get; set; }

        public Usuario Usuario { get; set; }
        public List<Proveedor> LstProveedor { get; set; }
        public List<Informe> LstInforme { get; set; }

        #endregion

        #region Properties ReadOnly

        //public bool MostrarOtrosParaEstadoImpulso => Filter.TipoIndicadorQaSelected.HasValue;

        #endregion
    }
}
