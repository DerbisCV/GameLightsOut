using Solvtio.Models.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteEstadoJuraCuentaTramitacion")]
    public class ExpedienteEstadoJuraCuentaTramitacion : IExpedienteEstadoChild
    {
        #region Constructors

        public ExpedienteEstadoJuraCuentaTramitacion()
        {
        }
        public ExpedienteEstadoJuraCuentaTramitacion(int idExpedienteEstado)
        {
            IdExpedienteEstado = idExpedienteEstado;
        }
        public ExpedienteEstadoJuraCuentaTramitacion(int? idExpediente)
        {
            if (idExpediente.HasValue) IdExpediente = idExpediente.Value;
        }

        #endregion

        #region Properties

        [Key]
        [ForeignKey("ExpedienteEstado")]
        public int IdExpedienteEstado { get; set; }
        public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public int IdExpediente { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DecretoAdmisionFecha { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DecretoAdmisionFechaVencimiento { get; set; }
        public TipoAccionDecreto DecretoAdmisionAccion { get; set; }

        public bool ImpugnacionExcesiva { get; set; }
        public bool ImpugnacionIndebida { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ImpugnacionFecha { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ImpugnacionFechaDecreto { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ImpugnacionFechaRecursoRevision { get; set; }
        public TipoResultadoApelacion ImpugnacionResultadoDecreto { get; set; }
        public TipoResultadoApelacion ImpugnacionResultadoRevision { get; set; }
        public string ImpugnacionMotivo { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaAutoJuez { get; set; }

        [DataType(DataType.Date)]
        public DateTime? RecursoRevisionFechaAutoJuez { get; set; }
        [DataType(DataType.Date)]
        public DateTime? RecursoApelacionFecha { get; set; }
        [DataType(DataType.Date)]
        public DateTime? RecursoApelacionFechaResultado { get; set; }


        [DataType(DataType.Date)]
        public DateTime? PagarFecha { get; set; }
        public string PagarNoCuenta { get; set; }
        public string PagarConcepto { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaDecretoFin { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ColegioAbogadoFechaOficio { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ColegioAbogadoFechaInforme { get; set; }


        internal void RefreshBy(ExpedienteEstadoJuraCuentaTramitacion model)
        {
            DecretoAdmisionFecha = model.DecretoAdmisionFecha;
            DecretoAdmisionFechaVencimiento = model.DecretoAdmisionFechaVencimiento;
            DecretoAdmisionAccion = model.DecretoAdmisionAccion;

            ImpugnacionExcesiva = model.ImpugnacionExcesiva;
            ImpugnacionIndebida = model.ImpugnacionIndebida;
            ImpugnacionFecha = model.ImpugnacionFecha;
            ImpugnacionFechaDecreto = model.ImpugnacionFechaDecreto;
            ImpugnacionFechaRecursoRevision = model.ImpugnacionFechaRecursoRevision;
            ImpugnacionResultadoDecreto = model.ImpugnacionResultadoDecreto;
            ImpugnacionResultadoRevision = model.ImpugnacionResultadoRevision;
            PagarFecha = model.PagarFecha;
            PagarNoCuenta = model.PagarNoCuenta;
            PagarConcepto = model.PagarConcepto;
            FechaDecretoFin = model.FechaDecretoFin;
            ColegioAbogadoFechaOficio = model.ColegioAbogadoFechaOficio;
            ColegioAbogadoFechaInforme = model.ColegioAbogadoFechaInforme;
            ImpugnacionMotivo = model.ImpugnacionMotivo;

            RecursoRevisionFechaAutoJuez = model.RecursoRevisionFechaAutoJuez;
            RecursoApelacionFecha = model.RecursoApelacionFecha;
            RecursoApelacionFechaResultado = model.RecursoApelacionFechaResultado;

            FechaAutoJuez = model.FechaAutoJuez;
            //DecretoAdmisionAccion = model.DecretoAdmisionAccion;            
        }

        #endregion
    }
}
