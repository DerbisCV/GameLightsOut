using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    public class Hip_Expediente
    {
        #region Constructors

        public Hip_Expediente()
        {
            CreateBase();
        }
        public Hip_Expediente(int idExpediente)
        {
            CreateBase();
            IdExpediente = idExpediente;
        }

        public void CreateBase()
        {
            Ejc_Expediente = new List<Ejc_Expediente>();
            ExpedienteAccions = new List<ExpedienteAccion>();
            Hip_ExpedienteGarantia = new List<Hip_ExpedienteGarantia>();
        }

        #endregion

        #region Properties

        [ForeignKey("Expediente")]
        public int IdExpediente { get; set; }
        public virtual Expediente Expediente { get; set; }

        public bool FacturaIntegral { get; set; }
        public bool EsTitulizado { get; set; }
        public bool MayorCuantia { get; set; }
        public string ObservacionesMigracion { get; set; }
        public bool? InmueblesPrestamoEnPorciento { get; set; }
        public DateTime? FechaFacturaHito1 { get; set; }
        public DateTime? FechaFacturaHito2 { get; set; }

        public int? IdExpedienteEjc { get; set; }
        [ForeignKey("IdExpedienteEjc")]
        public Ejc_Expediente ExpedienteEjecutivo { get; set; }

        public int? IdExpedienteOrd { get; set; }
        public int? IdExpedienteJV { get; set; }
        public int? IdExpedientePrelitigio { get; set; }


        public decimal DeudaPrincipal { get; set; }
        public decimal DeudaIntRemuneratorios { get; set; }
        public decimal DeudaIntDemora { get; set; }
        public decimal DeudaComisionesGastos { get; set; }
        public decimal DeudaIntDemoraCalculados { get; set; }
        public decimal DeudaMinutaLetrado { get; set; }
        public decimal DeudaMinutaProcurador { get; set; }
        public decimal DeudaTasaJudicial { get; set; }

        public decimal CostasPresupuestadas { get; set; }

        #endregion

        #region Properties Readonly

        public decimal DeudaTotal => DeudaPrincipal + DeudaIntRemuneratorios + DeudaMinutaLetrado + DeudaMinutaProcurador;

        #endregion

        #region Properties NotMapped

        [NotMapped]
        public Hip_Hipoteca Hipoteca { get; set; }

        #endregion

        #region Properties virtual

        public virtual Ejc_Expediente Ejc_Expediente1 { get; set; }
        public virtual ICollection<Ejc_Expediente> Ejc_Expediente { get; set; }
        public virtual ICollection<ExpedienteAccion> ExpedienteAccions { get; set; }
        public virtual ICollection<Hip_ExpedienteGarantia> Hip_ExpedienteGarantia { get; set; }

        #endregion

        #region Properties New

        public int? AutoSobreseimientoIdMotivo { get; set; }
        public int? AutoSobreseimientoIdEstado { get; set; }
        public int? AutoSobreseimientoIdApelacionPor { get; set; }
        public DateTime? AutoSobreseimientoFechaApelacion { get; set; }
        public int? AutoSobreseimientoIdResultadoApelacion { get; set; }
        public bool AutoSobreseimientoFinalizado { get; set; }
        public bool Ocupantes { get; set; }
        public DateTime? OcupantesFechaCelebracionVista { get; set; }
        public DateTime? OcupantesFechaResolucion { get; set; }
        public int? OcupantesResultado { get; set; }

        public DateTime? ApelacionEjecutanteFechaInterposicion { get; set; }
        public DateTime? ApelacionEjecutanteFechaImpugnacion { get; set; }

        public bool Oposicion { get; set; }
        public int? OposicionResultado { get; set; }
        public DateTime? OposicionFecha { get; set; }
        public DateTime? OposicionVistaFecha { get; set; }
        public DateTime? OposicionResolucionFecha { get; set; }
        public bool Apelacion { get; set; }
        public DateTime? ApelacionFecha { get; set; }
        public DateTime? ApelacionResultadoFecha { get; set; }
        public int? ApelacionPor { get; set; }
        public int? ApelacionResultado { get; set; }

        public DateTime? FechaPosesionPositivaInmuebles { get; set; }


        public int? IdRevisionJudicial { get; set; }
        [ForeignKey("IdRevisionJudicial")]
        public virtual CaracteristicaBase RevisionJudicial { get; set; }

        public int? IdLibertadArredanticia { get; set; }
        [ForeignKey("IdLibertadArredanticia")]
        public virtual CaracteristicaBase LibertadArredanticia { get; set; }

        public int? IdEstadoVenia { get; set; }
        [ForeignKey("IdEstadoVenia")]
        public virtual CaracteristicaBase EstadoVenia { get; set; }

        public DateTime? FechaVeniaAdmitida { get; set; }


        #endregion

        #region Methods

        internal void Refresh(Hip_Expediente model)
        {
            FacturaIntegral = model.FacturaIntegral;
            EsTitulizado = model.EsTitulizado;
            MayorCuantia = model.MayorCuantia;
            ObservacionesMigracion = model.ObservacionesMigracion;
            InmueblesPrestamoEnPorciento = model.InmueblesPrestamoEnPorciento;
            FechaFacturaHito1 = model.FechaFacturaHito1;
            FechaFacturaHito2 = model.FechaFacturaHito2;
            AutoSobreseimientoIdMotivo = model.AutoSobreseimientoIdMotivo;
            AutoSobreseimientoIdEstado = model.AutoSobreseimientoIdEstado;
            AutoSobreseimientoIdApelacionPor = model.AutoSobreseimientoIdApelacionPor;
            AutoSobreseimientoFechaApelacion = model.AutoSobreseimientoFechaApelacion;
            AutoSobreseimientoIdResultadoApelacion = model.AutoSobreseimientoIdResultadoApelacion;
            AutoSobreseimientoFinalizado = model.AutoSobreseimientoFinalizado;
            Ocupantes = model.Ocupantes;
            OcupantesFechaCelebracionVista = model.OcupantesFechaCelebracionVista;
            OcupantesFechaResolucion = model.OcupantesFechaResolucion;
            OcupantesResultado = model.OcupantesResultado;

            DeudaPrincipal = model.DeudaPrincipal;
            DeudaIntRemuneratorios = model.DeudaIntRemuneratorios;
            DeudaIntDemora = model.DeudaIntDemora;
            DeudaComisionesGastos = model.DeudaComisionesGastos;
            DeudaIntDemoraCalculados = model.DeudaIntDemoraCalculados;
            DeudaMinutaLetrado = model.DeudaMinutaLetrado;
            DeudaMinutaProcurador = model.DeudaMinutaProcurador;
            DeudaTasaJudicial = model.DeudaTasaJudicial;
            CostasPresupuestadas = model.CostasPresupuestadas;

            Oposicion = model.Oposicion;
            OposicionResultado = model.OposicionResultado;
            OposicionFecha = model.OposicionFecha;
            OposicionVistaFecha = model.OposicionVistaFecha;
            OposicionResolucionFecha = model.OposicionResolucionFecha;
            Apelacion = model.Apelacion;
            ApelacionFecha = model.ApelacionFecha;
            ApelacionResultadoFecha = model.ApelacionResultadoFecha;
            ApelacionPor = model.ApelacionPor;
            ApelacionResultado = model.ApelacionResultado;
            FechaPosesionPositivaInmuebles = model.FechaPosesionPositivaInmuebles;

            IdRevisionJudicial = model.IdRevisionJudicial;
            IdLibertadArredanticia = model.IdLibertadArredanticia;
            IdEstadoVenia = model.IdEstadoVenia;
            FechaVeniaAdmitida = model.FechaVeniaAdmitida;

            ApelacionEjecutanteFechaInterposicion = model.ApelacionEjecutanteFechaInterposicion;
            ApelacionEjecutanteFechaImpugnacion = model.ApelacionEjecutanteFechaImpugnacion;
        }

        #endregion


    }
}
