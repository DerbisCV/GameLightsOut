using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    public class Alq_Expediente
    {
        #region Constructors

        public Alq_Expediente()
        {
            Alq_Expediente_Contratos = new List<Alq_Expediente_Contrato>();
            //Ejc_Expediente1 = new List<Ejc_Expediente>();
            IdAccionPropuesta = 1;
        }

        #endregion

        #region Properties Para Borrar

        //public decimal? IncentivoImporte { get; set; }
        //public DateTime? IncentivoFecha { get; set; }

        #endregion

        #region Properties

        public int Id => IdExpediente;

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public string ReferenciaExternaMACRO { get; set; }
        public string ReferenciaExternaMSGI { get; set; }
        public decimal? DeudaInicial { get; set; }
        public decimal? DeudaPendiente { get; set; }

        public decimal? DeudaRecuperada { get; set; }


        public DateTime? FechaEstadoActual { get; set; }
        public string NumAuto { get; set; }
        public int? IdAbogadoZona { get; set; }

        public string ObservacionesMigracion { get; set; }
        public bool EstaCompleto { get; set; }
        public DateTime? FechaEnvioBurofax { get; set; }
        public DateTime? FechaRecepcionBurofax { get; set; }
        public TipoRecepcionBurofaxMotivo? RecepcionBurofaxMotivo { get; set; }

        public decimal? Fianza { get; set; }
        public decimal? GarantiaAdicional { get; set; }
        public int? IdAlqContrato { get; set; }
        public string TipoProcedimiento { get; set; }
        public TipoSegmento? Segmento { get; set; }
        public string Cedente { get; set; }
        public string CodigoActivoCedente { get; set; }
        public decimal? ImporteCostas { get; set; }
        public decimal? ImporteCondonacion { get; set; }


        public string PromocionNo { get; set; }
        public string PromocionNombre { get; set; }


        public int IdAccionPropuesta { get; set; }
        [ForeignKey("IdAccionPropuesta")]
        public virtual Gnr_ListasValores_Valores AccionPropuesta { get; set; }

        public int? IdTipoGarantiaAdicional { get; set; }
        [ForeignKey("IdTipoGarantiaAdicional")]
        public virtual Gnr_ListasValores_Valores TipoGarantiaAdicional { get; set; }

        public int? IdProcedimientoActual { get; set; }
        [ForeignKey("IdProcedimientoActual")]
        public virtual Gnr_ListasValores_Valores ProcedimientoActual { get; set; }

        public int? IdEstadoDemanda { get; set; }
        [ForeignKey("IdEstadoDemanda")]
        public virtual Gnr_ListasValores_Valores EstadoDemanda { get; set; }

        public int? IdTipoEstadoCliente { get; set; }
        [ForeignKey("IdTipoEstadoCliente")]
        public virtual Gnr_TipoEstadoCliente Gnr_TipoEstadoCliente { get; set; }

        public bool DerivadoDepartamentoConcursal { get; set; }
        public bool ServiciosSociales { get; set; }
        public bool TomadaPosesion { get; set; }

        //public virtual Gnr_Abogado Gnr_Abogado { get; set; }



        public int? IdExpedienteEjc { get; set; }
        //[ForeignKey("IdExpedienteEjc")]
        //public virtual Ejc_Expediente Ejc_Expediente { get; set; }

        public int? IdExpedientePadre { get; set; }

        public virtual ICollection<Alq_Expediente_Contrato> Alq_Expediente_Contratos { get; set; }
        //public virtual ICollection<Ejc_Expediente> Ejc_Expediente1 { get; set; }

        #endregion

        #region NotMapped

        [NotMapped]
        public virtual Alq_Expediente_Contrato ContratoFirst { get; set; }

        [NotMapped]
        public virtual Alq_Expediente_EstadoPresentacionDemanda EstadoPresentacionDemanda { get; set; }

        [NotMapped]
        public virtual Alq_Expediente_EstadoTramitaJuzgado EstadoTramitaJuzgado { get; set; }

        [NotMapped]
        public virtual Alq_Expediente_EstadoLanzamiento EstadoLanzamiento { get; set; }
        [NotMapped]
        public virtual AlqExpedienteEstadoPresentacionDenuncia EstadoPresentacionDenuncia { get; set; }
        [NotMapped]
        public virtual AlqExpedienteEstadoTramitacionDenuncia EstadoTramitacionDenuncia { get; set; }

        [NotMapped]
        public virtual Alq_Expediente_EstadoFinalizacion EstadoFinalizacion { get; set; }

        [NotMapped]
        public virtual ExpedienteVista Vista { get; set; }
        [NotMapped]
        public virtual ExpedienteVista VistaLanzamiento { get; set; }

        [NotMapped]
        public string InformacionMediador { get; set; }

        #endregion

        internal void Refresh(Alq_Expediente modelBase)
        {
            if (modelBase == null) return;

            ReferenciaExternaMACRO = modelBase.ReferenciaExternaMACRO;
            ReferenciaExternaMSGI = modelBase.ReferenciaExternaMSGI;
            IdAlqContrato = modelBase.IdAlqContrato;
            DeudaInicial = modelBase.DeudaInicial;
            DeudaPendiente = modelBase.DeudaPendiente;
            DeudaRecuperada = modelBase.DeudaRecuperada;
            FechaEnvioBurofax = modelBase.FechaEnvioBurofax;
            FechaRecepcionBurofax = modelBase.FechaRecepcionBurofax;
            RecepcionBurofaxMotivo = modelBase.RecepcionBurofaxMotivo;
            TipoProcedimiento = modelBase.TipoProcedimiento;
            Fianza = modelBase.Fianza;
            GarantiaAdicional = modelBase.GarantiaAdicional;
            IdAbogadoZona = modelBase.IdAbogadoZona;
            NumAuto = modelBase.NumAuto;
            Segmento = modelBase.Segmento;
            IdTipoEstadoCliente = modelBase.IdTipoEstadoCliente;
            Cedente = modelBase.Cedente;
            CodigoActivoCedente = modelBase.CodigoActivoCedente;
            IdTipoGarantiaAdicional = modelBase.IdTipoGarantiaAdicional;
            IdProcedimientoActual = modelBase.IdProcedimientoActual;
            IdEstadoDemanda = modelBase.IdEstadoDemanda;
            ImporteCostas = modelBase.ImporteCostas;
            ImporteCondonacion = modelBase.ImporteCondonacion;
            DerivadoDepartamentoConcursal = modelBase.DerivadoDepartamentoConcursal;
            ServiciosSociales = modelBase.ServiciosSociales;
            PromocionNo = modelBase.PromocionNo;
            PromocionNombre = modelBase.PromocionNombre;
            TomadaPosesion = modelBase.TomadaPosesion;
        }

        internal void RefreshBy(AlqExpedienteDto model)
        {
            ReferenciaExternaMACRO = model.ReferenciaExternaMACRO;
            ReferenciaExternaMSGI = model.ReferenciaExternaMSGI;
            IdAlqContrato = model.IdAlqContrato;
            Segmento = model.Segmento;
            DeudaInicial = model.DeudaInicial;
            DeudaPendiente = model.DeudaPendiente;
            TipoProcedimiento = model.TipoProcedimiento;
            DeudaRecuperada = model.DeudaRecuperada;
            PromocionNo = model.PromocionNo;
            PromocionNombre = model.PromocionNombre;
            Fianza = model.Fianza;
            GarantiaAdicional = model.GarantiaAdicional;
            IdAbogadoZona = model.IdAbogadoZona;
            FechaEnvioBurofax = model.FechaEnvioBurofax;
            FechaRecepcionBurofax = model.FechaRecepcionBurofax;
            RecepcionBurofaxMotivo = model.RecepcionBurofaxMotivo;
            IdTipoEstadoCliente = model.IdTipoEstadoCliente;
            DerivadoDepartamentoConcursal = model.DerivadoDepartamentoConcursal;
            ServiciosSociales = model.ServiciosSociales;
            TomadaPosesion = model.TomadaPosesion;

            Cedente = model.Cedente;
            CodigoActivoCedente = model.CodigoActivoCedente;
            IdTipoGarantiaAdicional = model.IdTipoGarantiaAdicional;
            IdProcedimientoActual = model.IdProcedimientoActual;
            IdEstadoDemanda = model.IdEstadoDemanda;
            ImporteCostas = model.ImporteCostas;
            ImporteCondonacion = model.ImporteCondonacion;

            if (Expediente != null)
            {
                Expediente.SucesionPresentada = model.SucesionPresentada;
                Expediente.SucesionCopiaSellada = model.SucesionCopiaSellada;
                Expediente.SucesionAcordada = model.SucesionAcordada;
                Expediente.SucesionDenegada = model.SucesionDenegada;
                Expediente.IdSucesionCausaIncidencia = model.IdSucesionCausaIncidencia;
                Expediente.SucesionOposicion = model.SucesionOposicion;
                Expediente.SucesionRecurrida = model.SucesionRecurrida;
                Expediente.SucesionResultadoRecuso = model.SucesionResultadoRecuso;
                Expediente.IdSucesionEstadoProcesalCliente = model.IdSucesionEstadoProcesalCliente;
                Expediente.IdSucesionProblemasDetalles = model.IdSucesionProblemasDetalles;            
            }
        }
    }
}
