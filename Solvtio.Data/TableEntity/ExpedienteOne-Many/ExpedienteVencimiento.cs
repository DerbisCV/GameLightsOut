using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Models.Enumeraciones;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ExpedienteVencimiento")]
    public class ExpedienteVencimiento
    {
        #region Constructors

        public ExpedienteVencimiento(){ CreateBase(); }
        public ExpedienteVencimiento(int idExpediente, string usuario)
        {
            CreateBase();
            IdExpediente = idExpediente;
            Usuario = usuario;
        }
        public ExpedienteVencimiento(int idExpediente, TipoVencimiento tipo, DateTime fecha, string observaciones = "", string usuario = "")
        {
            CreateBase();

            IdExpediente = idExpediente;
            TipoVencimiento = tipo;
            Fecha = fecha;
            Observaciones = observaciones;
            Usuario = usuario;
        }

        private void CreateBase()
        {
            Fecha = DateTime.Today;
            TipoVencimiento = TipoVencimiento.Vencimiento;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedienteVencimiento { get; set; }

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public DateTime Fecha { get; set; }
        public bool Ejecutado { get; set; }
        public bool Urgente { get; set; }
        public string Observaciones { get; set; }

        public TipoVencimiento TipoVencimiento { get; set; }
        public ExpedienteEstadoTipo? TipoEstado { get; set; }


        public int? IdArea { get; set; }
        [ForeignKey("IdArea")]
        public virtual Area Area { get; set; }


        public int? IdAbogado { get; set; }
        [ForeignKey("IdAbogado")]
        public virtual Gnr_Abogado Abogado { get; set; }

        public string Usuario { get; set; }

        public int? IdItemCalendarInSp { get; set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{Fecha.ToShortDateString()}: {Observaciones}.";
        }

        #endregion

    }
}
