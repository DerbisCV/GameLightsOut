using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solvtio.Models
{
    [Table("ExpedienteTituloEjecutivo")]
    public class ExpedienteTituloEjecutivo
    {
        #region Constructors

        public ExpedienteTituloEjecutivo()
        {
        }

        public ExpedienteTituloEjecutivo(int idExpediente) : this()
        {
            IdExpediente = idExpediente;
        }
        //public ExpedienteTituloEjecutivo(int idExpediente, DateTime? fecha, string noTituloEjecutivo) : this()
        //{
        //    IdExpediente = idExpediente;
        //    Fecha = fecha;
        //    NoTituloEjecutivo = noTituloEjecutivo;
        //}

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedienteTituloEjecutivo { get; set; }

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public DateTime? FechaSolicitud { get; set; }
        public DateTime? FechaObtencion { get; set; }

        public int? TituloEjecutivoIncidenciaId { get; set; }
        [ForeignKey("TituloEjecutivoIncidenciaId")]
        public virtual CaracteristicaBase TituloEjecutivoIncidencia { get; set; }

        public string Nota { get; set; }

        #endregion

        #region One 2 Many

        //public virtual ICollection<ConcursalComunicacionCredito> ConcursalComunicacionCreditoSet { get; set; }

        #endregion

        #region Properties ReadOnly

        //private string Hora => Fecha.ToString("HH:mm") ?? "";

        #endregion

        internal void RefreshBy(ExpedienteTituloEjecutivo model)
        {
            FechaSolicitud = model.FechaSolicitud;
            FechaObtencion = model.FechaObtencion;
            TituloEjecutivoIncidenciaId = model.TituloEjecutivoIncidenciaId;
            Nota = model.Nota;
        }

    }
}
