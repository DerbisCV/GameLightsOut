using System;
using Solvtio.Models.Model;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Solvtio.Models
{
    [Table("ExpedientePrestamo")]
    public class ExpedientePrestamo
    {
       
        #region Constructors

        public ExpedientePrestamo()
        {
            CreateBase();
        }

        public ExpedientePrestamo(int idExpediente)
        {
            CreateBase();
            IdExpediente = idExpediente;
        }
        public ExpedientePrestamo(int idExpediente, DateTime? fecha, string noPrestamo)
        {
            CreateBase();

            IdExpediente = idExpediente;
            Fecha = fecha;
            NoPrestamo = noPrestamo;
        }

        private void CreateBase()
        {
            //Fecha = DateTime.Now;
        }

        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExpedientePrestamo { get; set; }

        public int IdExpediente { get; set; }
        [ForeignKey("IdExpediente")]
        public virtual Expediente Expediente { get; set; }

        public DateTime? Fecha { get; set; }
        public string NoPrestamo { get; set; }
        public string Observaciones { get; set; }

        public PrestamoGarantiaType? Garantia { get; set; }
        public bool Cedido { get; set; }

        #endregion

        #region One 2 Many

        public virtual ICollection<ConcursalComunicacionCredito> ConcursalComunicacionCreditoSet { get; set; }

        #endregion

        #region Properties ReadOnly

        //private string Hora => Fecha.ToString("HH:mm") ?? "";

        #endregion

    }
}
