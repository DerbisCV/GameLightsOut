using Solvtio.Common;
using Solvtio.Models.Model;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public class ExpedienteFactura
    {
        #region Constructors

        public ExpedienteFactura()
        {
            CreateBase();
        }
        public ExpedienteFactura(HitoFacturacionValue hitoFacturacion, string usuario)
        {
            CreateBase();
            HitoFacturacion = hitoFacturacion;
            UsuarioAlta = UsuarioActualizacion = usuario;
        }
        public ExpedienteFactura(int hitoFacturacion, string usuario)
        {
            CreateBase();
            HitoFacturacion = (HitoFacturacionValue)hitoFacturacion;
            UsuarioAlta = UsuarioActualizacion = usuario;
        }
        public ExpedienteFactura(Expediente expediente, TipoIndicadorQa indicador, HitoFacturacionValue hitoFacturacion, string usuario)
        {
            CreateBase();
            HitoFacturacion = hitoFacturacion;
            UsuarioAlta = UsuarioActualizacion = usuario;

            Expediente = expediente;
            IdExpediente = expediente.IdExpediente;
            Importe = 
                hitoFacturacion == HitoFacturacionValue.Hito1 ? expediente.ImpFacturableH1 :
                hitoFacturacion == HitoFacturacionValue.Hito2 ? expediente.ImpFacturableH2 :
                hitoFacturacion == HitoFacturacionValue.Hito3 ? expediente.ImpFacturableH3 :
                hitoFacturacion == HitoFacturacionValue.Hito4 ? expediente.ImpFacturableH4 :
                hitoFacturacion == HitoFacturacionValue.Hito5 ? expediente.ImpFacturableH5 :
                hitoFacturacion == HitoFacturacionValue.Hito6 ? expediente.ImpFacturableH6 :
                (decimal?)null;

            if (indicador == TipoIndicadorQa.OrdinarioCsFacturasBancoPopularHito1)
            {
                Observaciones = $"No Auto: {expediente.NoAuto}, Juzgado: {expediente.JuzgadoName}";
                HitoFechaReferencia = expediente.ExpedienteOrdinarioCs.AllanamientoFecha;
            }
            else if (indicador == TipoIndicadorQa.OrdinarioCsFacturasBancoPopularHito2)
            {
                Observaciones = $"No Auto: {expediente.NoAuto}, Juzgado: {expediente.JuzgadoName}";
                HitoFechaReferencia = expediente.ExpedienteEstadoLast?.Fecha;
            }
            else if (indicador == TipoIndicadorQa.OrdinarioCsFacturasHito2PendienteFinalizar)
            {
                Observaciones = $"No Auto: {expediente.NoAuto}, Juzgado: {expediente.JuzgadoName}";
                //HitoFechaReferencia = expediente.ExpedienteEstadoLast?.Fecha;
            }

            //IdTipoHitoProcesal =
            //    indicador == TipoIndicadorQa.MyCFacturasAbanca52 ?  :
            //    hitoFacturacion == HitoFacturacionValue.Hito3 ? expediente.ImpFacturableH3 :
            //    hitoFacturacion == HitoFacturacionValue.Hito4 ? expediente.ImpFacturableH4 :
            //    hitoFacturacion == HitoFacturacionValue.Hito5 ? expediente.ImpFacturableH5 :
            //    hitoFacturacion == HitoFacturacionValue.Hito6 ? expediente.ImpFacturableH6 :
            //    (decimal?)null;

        }
        private void CreateBase()
        {
            Observaciones = "";
            Fecha = FechaAlta = FechaActualizacion = DateTime.Now;
        }

        #endregion

		#region Properties

        public int IdExpedienteFactura { get; set; }
        public int IdExpediente { get; set; }
        public HitoFacturacionValue HitoFacturacion { get; set; }

        //Derbis 07/04/2021: Esta propiedad se agrega para que se llene desde el facturador, en teoria deberia usarse la enumeracion (HitoFacturacionValue) pero desde el facturador necesitan mas tipos
        //Evaluar con el tiempo si es una opción adecuada, posiblemente debamos eliminar la enumeracion
        public int? IdTipoHitoFacturacion { get; set; }
        [ForeignKey("IdTipoHitoFacturacion")]
        public virtual HitoFacturacion TipoHitoFacturacion { get; set; }

        public int? IdTipoHitoProcesal { get; set; }
        [ForeignKey("IdTipoHitoProcesal")]
        public virtual TipoHitoProcesal TipoHitoProcesal { get; set; }

        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string UsuarioAlta { get; set; }
        public string UsuarioActualizacion { get; set; }
        public int? IdFactura { get; set; }
        public decimal? Importe { get; set; }
        public Expediente Expediente { get; set; }
        public Factura Factura { get; set; }
        public DateTime? HitoFechaReferencia { get; set; }

        #endregion

        #region Properties ReadOnly

        public string HitoFacturacionNombre => TipoHitoFacturacion == null ? HitoFacturacion.GetDescription() : TipoHitoFacturacion.Nombre;

        #endregion

        #region Properties NotMapped

        [NotMapped]
        public bool IsSelected { get; set; }
        [NotMapped]
        public string NoFactura { get; set; }

        [NotMapped]
        public Gnr_Persona Persona { get; set; }

        #endregion

        #region Methods

        //public string NoFactura { get; set; }

        #endregion
    }
}
