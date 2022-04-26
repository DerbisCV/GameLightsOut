using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public class Ejc_Expediente
    {
        #region Contructors

        public Ejc_Expediente()
        {
            CreateBase();
        }

        public Ejc_Expediente(int idExpediente, int idDeudorPrincipal, Hip_Hipoteca hipoteca)
        {
            CreateBase();

            IdExpediente = idExpediente;
            IdDeudorPrincipal = idDeudorPrincipal;

            CuentaOficina = hipoteca == null ? "" : hipoteca.OficinaNoCuenta;
            CuentaNo = hipoteca == null ? "" : hipoteca.NoCuentaPrestamo;
        }

        public void CreateBase()
        {
            CuentaOficina = "-   ";
            CuentaNo = "-         ";

            //Alq_ExpedienteSet = new List<Alq_Expediente>();
            //Hip_Expediente1 = new List<Hip_Expediente>();
        }

        #endregion
        
        #region Properties

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public string CuentaOficina { get; set; }
        public string CuentaNo { get; set; }
        public decimal? Importe { get; set; }
        public decimal? AdmitidaDeudaReclamada { get; set; }

        public int IdDeudorPrincipal { get; set; }
        [ForeignKey("IdDeudorPrincipal")]
        public virtual Gnr_Persona Gnr_Persona { get; set; }

        public int? IdExpedienteHip { get; set; }
        //[ForeignKey("IdExpedienteHip")]
        //public virtual Hip_Expediente ExpedienteHipotecario { get; set; }

        public int? IdExpedienteAlq { get; set; }
        [ForeignKey("IdExpedienteAlq")]
        public virtual Alq_Expediente Alq_Expediente { get; set; }

        public int? IdExpedienteOrd { get; set; }

        public int? IdExpedienteMn { get; set; }

        public bool TasacionCostas { get; set; }

        public DateTime? FechaFacturaHito1 { get; set; }
        public DateTime? FechaFacturaHito2 { get; set; }
        public DateTime? FechaPosesionPositivaInmuebles { get; set; }

        public DateTime? ApelacionEjecutanteFechaInterposicion { get; set; }
        public DateTime? ApelacionEjecutanteFechaImpugnacion { get; set; }

        //public virtual ICollection<Alq_Expediente> Alq_ExpedienteSet { get; set; }
        //public virtual ICollection<Hip_Expediente> Hip_Expediente1 { get; set; }
        
        #endregion

        #region Properties ReadOnly


        #endregion

        #region Methods

        internal void RefreshBy(Ejc_Expediente model)
        {
            CuentaOficina = model.CuentaOficina;
            CuentaNo = model.CuentaNo;
            Importe = model.Importe;
            AdmitidaDeudaReclamada = model.AdmitidaDeudaReclamada;
            FechaFacturaHito1 = model.FechaFacturaHito1;
            FechaFacturaHito2 = model.FechaFacturaHito2;
            IdDeudorPrincipal = model.IdDeudorPrincipal;
            TasacionCostas = model.TasacionCostas;
            FechaPosesionPositivaInmuebles = model.FechaPosesionPositivaInmuebles;

            ApelacionEjecutanteFechaInterposicion = model.ApelacionEjecutanteFechaInterposicion;
            ApelacionEjecutanteFechaImpugnacion = model.ApelacionEjecutanteFechaImpugnacion;
        }

        #endregion
    }
}
