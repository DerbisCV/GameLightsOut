using System;
using Solvtio.Models.Model;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using System.ComponentModel.DataAnnotations;

namespace Solvtio.Models
{
    [Table("ExpedienteParalizado")]
    public class ExpedienteParalizado
    {
        #region Constructors

        public ExpedienteParalizado()
        {
            CreateBase();
        }

        public ExpedienteParalizado(Expediente expediente, string userName)
        {
            CreateBase();
            IdExpediente = expediente.IdExpediente;
            IdExpedienteEstado = expediente.IdEstadoLast.Value;
            Expediente = expediente;
            Usuario = userName;
        }
        public ExpedienteParalizado(int idExpediente, int idExpedienteEstado, DateTime fecha, string observaciones = "")
        {
            CreateBase();

            IdExpediente = idExpediente;
            IdExpedienteEstado = idExpedienteEstado;
            Inicio = fecha;
            Observaciones = observaciones;
        }

        private void CreateBase()
        {
            Inicio = DateTime.Now;
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedienteParalizado { get; set; }

        public int IdExpediente { get; set; }
        public virtual Expediente Expediente { get; set; }

        public DateTime Inicio { get; set; }
        public DateTime? Fin { get; set; }
        public string Usuario { get; set; }
        public string Observaciones { get; set; }

        public int IdExpedienteEstado { get; set; }
        //[ForeignKey("IdExpedienteEstado")]
        //public virtual ExpedienteEstado ExpedienteEstado { get; set; }

        public int? IdMotivo { get; set; }
        [ForeignKey("IdMotivo")]
        public virtual CaracteristicaBase Motivo { get; set; }

        #endregion

        #region Properties ReadOnly

        public DateTime FinVirtual  => Fin ?? DateTime.Now;
        public int Dias => Inicio.GetDaysBetweenDates(FinVirtual);

        #endregion

        public string ToStringHtml()
        {
            var classDom = Fin.HasValue ? "text-primary" : "text-danger";
            return $"<span class='{classDom}'>{Inicio.ToShortDateString()} - {Fin.ToShortDateString()} (<strong>{Dias} días</strong>)</span>";
        }

    }
}

