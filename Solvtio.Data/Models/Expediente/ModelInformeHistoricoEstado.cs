using Solvtio.Common;
using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelInformeHistoricoEstado
    {
        #region Constructors
        public ModelInformeHistoricoEstado()
        {
			CreateBase();
        }

        public ModelInformeHistoricoEstado(int idExpedienteEstado)
        {
            CreateBase();
            IdExpedienteEstado = idExpedienteEstado;
        }

        private void CreateBase()
		{
		    Errores = new List<string>();
            //LstHitos = new List<ModelHitoProcesal>();
            //LstEstados = new List<ModelHitoProcesal>();
        }
		#endregion

		#region Properties

        public int IdExpedienteEstado { get; set; }
        public List<ExpedienteEstadoAbogadoHistorico> LstExpedienteEstadoAbogadoHistorico { get; set; }
        public List<string> Errores { get; set; }

        #endregion

        #region Properties ReadOnly

        public bool HasError => Errores.IsNotEmpty();

  //      private List<ModelHitoProcesal> _lstHitosWithFechaHitoAnterior;
		//public List<ModelHitoProcesal> LstHitosWithFechaHitoAnterior
		//{
		//	get
		//	{
		//		if (_lstHitosWithFechaHitoAnterior == null)
		//			_lstHitosWithFechaHitoAnterior = this.LstHitos.Where(x => x.FechaHitoAnterior.HasValue).ToList();
		
		//		return _lstHitosWithFechaHitoAnterior;
		//	}
		//}

		#endregion

		
	}
}
