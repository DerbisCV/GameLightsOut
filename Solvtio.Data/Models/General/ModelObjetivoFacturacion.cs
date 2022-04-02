using System;
using System.Collections.Generic;
using System.Linq;

namespace Solvtio.Models
{
    public class ModelObjetivoFacturacion
    {
        #region Constructors

        public ModelObjetivoFacturacion()
        {
            Filter = new ModelFilterBase();
            Filter.Anio = System.DateTime.Now.Year;
        }
        public ModelObjetivoFacturacion(int? year) : this()
        {
            if (year.HasValue)
                Filter.Anio = year;
        }
        public ModelObjetivoFacturacion(ModelFilterBase filter) : this()
        {
            Filter = filter;
        }

        #endregion

        #region Properties 

        public ModelFilterBase Filter { get; set; }
        public List<ClienteObjetivo> LstClienteObjetivo { get; set; }

        public List<ClienteObjetivo> LstObjetivoByAreaNeocio => RefreshLstObjetivoByAreaNeocio(); //{ get; set; }

        private List<ClienteObjetivo> RefreshLstObjetivoByAreaNeocio()
        {
            if (LstClienteObjetivo== null) return LstClienteObjetivo;

            var result = new List<ClienteObjetivo>();

            foreach (var idAreaNegocio in LstClienteObjetivo.Select(x => x.IdAreaNegocio).Distinct())
            {
                var queryByAreaNegocio = LstClienteObjetivo.Where(x => x.IdAreaNegocio == idAreaNegocio);

                var clienteObjetivo = new ClienteObjetivo();
                clienteObjetivo.AreaNegocio = LstClienteObjetivo.First(x => x.IdAreaNegocio == idAreaNegocio).AreaNegocio;

                clienteObjetivo.Mes01 = new PlanReal(queryByAreaNegocio, 1);
                clienteObjetivo.Mes02 = new PlanReal(queryByAreaNegocio, 2);
                clienteObjetivo.Mes03 = new PlanReal(queryByAreaNegocio, 3);
                clienteObjetivo.Mes04 = new PlanReal(queryByAreaNegocio, 4);
                clienteObjetivo.Mes05 = new PlanReal(queryByAreaNegocio, 5);
                clienteObjetivo.Mes06 = new PlanReal(queryByAreaNegocio, 6);
                clienteObjetivo.Mes07 = new PlanReal(queryByAreaNegocio, 7);
                clienteObjetivo.Mes08 = new PlanReal(queryByAreaNegocio, 8);
                clienteObjetivo.Mes09 = new PlanReal(queryByAreaNegocio, 9);
                clienteObjetivo.Mes10 = new PlanReal(queryByAreaNegocio, 10);
                clienteObjetivo.Mes11 = new PlanReal(queryByAreaNegocio, 11);
                clienteObjetivo.Mes12 = new PlanReal(queryByAreaNegocio, 12);

                clienteObjetivo.ImportePlaneado = queryByAreaNegocio.Sum(x => x.ImportePlaneado);
                clienteObjetivo.ImporteConseguido = queryByAreaNegocio.Sum(x => x.ImporteConseguido ?? 0);

                result.Add(clienteObjetivo);
            }

            return result;
        }

        public List<Gnr_Cliente> LstCliente { get; set; }
        public List<Gnr_ClienteOficina> LstClienteOficina { get; set; }


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
