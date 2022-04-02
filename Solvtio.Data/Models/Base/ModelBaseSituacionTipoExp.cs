using System;
using System.Collections.Generic;
using System.Linq;

namespace Solvtio.Models
{
    public class ModelBaseSituacionTipoExp
	{
        #region Constructor

        public ModelBaseSituacionTipoExp()
        {
            createBase();
        }
        public ModelBaseSituacionTipoExp(Gnr_TipoExpediente tipoExp, IQueryable<Expediente> queryActivos, List<Gnr_TipoEstado> lstTipoEstadoAll, List<TipoSubFaseEstado> lstTipoSubFaseEstado)
        {
            createBase();
            TipoExpediente = tipoExp;

            var queryActivosInExp = queryActivos.Where(x => x.IdTipoExpediente == tipoExp.IdTipoExpediente);
            TotalActivos = queryActivosInExp.Count();
            if (TotalActivos > 0)
            {
                TotalActivosDeuda = queryActivosInExp.Sum(x => x.DeudaFinal ?? 0);

                var lstTipoEstadoActivos = queryActivosInExp.Where(x => x.IdEstadoLast.HasValue).Select(x => x.ExpedienteEstadoLast.IdTipoEstado).Distinct().ToList();
                foreach (var idItem in lstTipoEstadoActivos)
                {
                    var item = lstTipoEstadoAll.FirstOrDefault(x => x.IdTipoEstado == idItem);
                    if (item != null)
                        LstExpActivosPorTipoEstado.Add(new ModelBaseSituacionTipoEstado(item, queryActivosInExp));
                }

                var lstTipoSubFaseEstadoActivos = queryActivosInExp.Where(x => x.IdEstadoLast.HasValue).Select(x => x.ExpedienteEstadoLast.IdTipoSubFaseEstado).Distinct().ToList();
                foreach (var idItem in lstTipoSubFaseEstadoActivos)
                {
                    var item = lstTipoSubFaseEstado.FirstOrDefault(x => x.IdTipoSubFaseEstado == idItem);
                    if (item != null)
                        LstExpActivosPorTipoSubFaseEstado.Add(new ModelBaseSituacionTipoEstadoFase(item, queryActivosInExp));
                }
            }
        }

        private void createBase()
        {
            LstExpActivosPorTipoEstado = new List<ModelBaseSituacionTipoEstado>();
            LstExpActivosPorTipoSubFaseEstado = new List<ModelBaseSituacionTipoEstadoFase>();
        }

        #endregion

        #region Properties

        public Gnr_TipoExpediente TipoExpediente { get; set; }
        public int TotalActivos { get; set; }
        public decimal TotalActivosDeuda { get; set; }
        public int TotalFinalizados { get; set; }

        public List<ModelBaseSituacionTipoEstado> LstExpActivosPorTipoEstado { get; set; }
        public List<ModelBaseSituacionTipoEstadoFase> LstExpActivosPorTipoSubFaseEstado { get; set; }

        #endregion

        #region Properties ReadOnly

        //public bool HasInfo => !string.IsNullOrWhiteSpace(InfoMessage);
        //   public bool HasError => !string.IsNullOrWhiteSpace(ErrorMessage);

        #endregion
    }

    public class ModelBaseSituacionTipoEstado
    {
        #region Constructor

        public ModelBaseSituacionTipoEstado()
        {
            createBase();
        }
        public ModelBaseSituacionTipoEstado(Gnr_TipoEstado tipoEstado, IQueryable<Expediente> queryActivos)
        {
            createBase();
            TipoEstado = tipoEstado;

            TotalActivos = queryActivos.Count(x => x.ExpedienteEstadoLast.IdTipoEstado == tipoEstado.IdTipoEstado);
        }

        private void createBase()
        {
        }

        #endregion

        #region Properties

        public Gnr_TipoEstado TipoEstado { get; set; }
        public int TotalActivos { get; set; }

        #endregion

        #region Properties ReadOnly

        //public bool HasInfo => !string.IsNullOrWhiteSpace(InfoMessage);

        #endregion
    }

    public class ModelBaseSituacionTipoEstadoFase
    {
        #region Constructor

        public ModelBaseSituacionTipoEstadoFase()
        {
            createBase();
        }
        public ModelBaseSituacionTipoEstadoFase(TipoSubFaseEstado tipoEstado, IQueryable<Expediente> queryActivos) //, List<Gnr_TipoEstado> lstTipoEstadoAll, List<TipoSubFaseEstado> lstTipoSubFaseEstado)
        {
            createBase();
            TipoSubFaseEstado = tipoEstado;

            TotalActivos = queryActivos.Count(x => x.ExpedienteEstadoLast.IdTipoSubFaseEstado == tipoEstado.IdTipoSubFaseEstado);
        }

        private void createBase()
        {
        }

        #endregion

        #region Properties

        public TipoSubFaseEstado TipoSubFaseEstado { get; set; }
        public int TotalActivos { get; set; }

        #endregion

        #region Properties ReadOnly

        //public bool HasInfo => !string.IsNullOrWhiteSpace(InfoMessage);

        #endregion
    }

}
