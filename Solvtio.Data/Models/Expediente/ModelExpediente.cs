using Solvtio.Common;
using System;

namespace Solvtio.Models
{
    public class ModelExpediente
    {
        #region Constructors
        public ModelExpediente()
        {
        }

		public ModelExpediente(Expediente exp)
		{
		//	this.IdExpediente = exp.IdExpediente;
		//	this.NoExpediente = exp.NoExpediente;
		//	this.ReferenciaExterna = exp.ReferenciaExterna;
		//	this.TipoExpediente = (TipoExpedienteEnum)exp.IdTipoExpediente;
		//	this.ClienteOficina = new ModelClienteOficina(exp.Gnr_ClienteOficina);
		//	this.DeudorPrincipal = new ModelPersona(exp.ExpedienteDeudors.FirstOrDefault()); //DeudorPrincipal;
		//	this.FechaAlta = exp.FechaAlta;
		//	this.Importe = new ModelMoney(exp.DeudaFinal);
		//	this.EstadoActual = new ModelEstado(exp.EstadoActual);
		//	this.Procurador = new ModelPersona(exp.Gnr_Procurador);
        }

		#endregion

		#region Properties

        public int IdExpediente { get; set; }
        public string NoExpediente { get; set; }
        public string ReferenciaExterna { get; set; }
        public TipoExpedienteEnum TipoExpediente { get; set; }
        //public ModelClienteOficina ClienteOficina { get; set; }
        //public ModelPersona DeudorPrincipal { get; set; }
        //public DateTime FechaAlta { get; set; }
        //public ModelMoney Importe { get; set; }
        //public ModelTipoEstado TipoEstadoActual { get; set; }
        public string ClienteOficina { get; set; }

		#endregion

		#region Properties ReadOnly
        //private int? _subastasSenaladasTotal;
        //public int SubastasSenaladasTotal
        //{
        //    get
        //    {
        //        if (!_subastasSenaladasTotal.HasValue)
        //            _subastasSenaladasTotal = this.LstResumenMes.Sum(x => x.SubastasSenaladas);

        //        return _subastasSenaladasTotal.Value;
        //    }
        //}
		#endregion

		
	}
}
