using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Enumeraciones;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("ExpedienteHora")]
    public class ExpedienteHora
    {
        #region Constructors

        public ExpedienteHora(){ CreateBase(); }
        public ExpedienteHora(int idExpediente, string usuario)
        {
            CreateBase();
            IdExpediente = idExpediente;
            Usuario = usuario;
        }

        private void CreateBase()
        {
            Fecha = DateTime.Today;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedienteHora { get; set; }

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public int? IdEmpleado { get; set; }
        [ForeignKey("IdEmpleado")]
        public virtual Gnr_Persona Empleado { get; set; }

        public DateTime Fecha { get; set; }
        public int TotalMinutos { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }

        #endregion

        #region Properties ReadOnly

        public string Tiempo => TotalMinutos.ToFormatHhMm();

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{Fecha.ToShortDateString()}: {TotalMinutos} min: {Observaciones}.";
        }

        //public string Tiempo()
        //{
        //    int minutos = 0;
        //    var horas = Math.DivRem(TotalMinutos, 60, out minutos);
        //    return $"{horas.ToString().PadLeft(2, '0')}:{minutos.ToString().PadLeft(2, '0')}";
        //}

        #endregion

    }
}
